using System.Text.RegularExpressions;

namespace TwistedFizzBuzz;

public class FizzBuzz
{
    #region Properties
    private readonly Dictionary<int, string> _tokens = new Dictionary<int, string>();
    #endregion

    #region Constructors
    public FizzBuzz() { }

    public FizzBuzz(string tokens)
    {
        _tokens = tokens.HandleGeneratedTokens();
    }

    public FizzBuzz(Dictionary<int, string> tokens)
    {
        _tokens = tokens;
    }
    #endregion

    #region Methods
    public void ExecuteFizzBuzz(string input)
    {
        var isRangeType = Regex.Match(input, "^(-?\\d+)-(-?\\d+$)");

        if (isRangeType.Success)
        {
            int firstValue = int.Parse(isRangeType.Groups[1].Value);
            int lastValue = int.Parse(isRangeType.Groups[2].Value);

            for (int i = firstValue; i <= lastValue; i++)
            {
                ProcessOutput(i);
            }
        }
        else
        {
            var inputs = input.Split(",").Select(int.Parse).ToArray();

            foreach (var i in inputs)
            {
                ProcessOutput(i);
            }
        }

    }

    private void ProcessOutput(int number)
    {
        bool isMultiple = false;
        foreach (var item in _tokens)
        {
            if (number % item.Key == 0)
            {
                Console.Write(item.Value);
                isMultiple = true;
            }
        }

        if (!isMultiple)
        {
            Console.Write(number);
        }

        Console.Write(Environment.NewLine);
    }
    #endregion

}
