using TwistedFizzBuzz;

namespace FizzBuzzTests.Unit;

public class StandardFizzBuzzTests
{
    private readonly string _tokens =
    """
    [
        { "multiple": 3, "word": "Fizz" },
        { "multiple": 5, "word": "Buzz" }
    ]
    """;
    private readonly FizzBuzz _fizzBuzz;

    public StandardFizzBuzzTests()
    {
        _fizzBuzz = new FizzBuzz(_tokens);
    }

    [Fact]
    public void ExecuteMethodShouldProcessARangeAndPrintOutputs()
    {
        //Arrange

        //Act
        string result = _fizzBuzz.ExecuteFizzBuzz("1-15");

        //Assert
        string expectedOutput = string.Format(@"1{0}2{0}Fizz{0}4{0}Buzz{0}Fizz{0}" +
                                                "7{0}8{0}Fizz{0}Buzz{0}11{0}Fizz{0}" +
                                                "13{0}14{0}FizzBuzz{0}", Environment.NewLine);
        Assert.Equal(expectedOutput, result);
    }

    [Fact]
    public void ExecuteMethodShouldProcessASetAndPrintOutputs()
    {
        //Arrange

        //Act
        string result = _fizzBuzz.ExecuteFizzBuzz("-5, 6, 300, 12, 15");

        //Assert
        string expectedOutput = string.Format(@"Buzz{0}Fizz{0}FizzBuzz{0}Fizz{0}FizzBuzz{0}", Environment.NewLine);
        Assert.Equal(expectedOutput, result);
    }
}