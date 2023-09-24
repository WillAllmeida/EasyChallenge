using System.Text;
using System.Text.RegularExpressions;

namespace TwistedFizzBuzz;

public class FizzBuzz
{
    #region Properties
    private readonly Dictionary<int, string> _tokens = new Dictionary<int, string>();
    public StringBuilder _sb { get; }
    #endregion

    #region Constructors

    public FizzBuzz(string tokens)
    {
        _tokens = tokens.HandleGeneratedTokens();
        _sb = new StringBuilder();
    }

    #endregion

    #region Methods
    public string ExecuteFizzBuzz(string input)
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
            var numbers = input.Split(",");

            foreach (var num in numbers)
            {
                if (int.TryParse(num, out int i))
                {
                    ProcessOutput(i);
                }
            }
        }

        return _sb.ToString();

    }

    private void ProcessOutput(int number)
    {
        bool isMultiple = false;
        foreach (var item in _tokens)
        {
            if (number % item.Key == 0)
            {
                _sb.Append(item.Value);
                isMultiple = true;
            }
        }

        if (!isMultiple)
        {
            _sb.Append(number);
        }

        _sb.Append(Environment.NewLine);
    }
    #endregion

}
