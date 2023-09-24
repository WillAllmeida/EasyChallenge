using TwistedFizzBuzz;

namespace FizzBuzzTests.Unit;

public class CustomFizzBuzzTests
{
    private readonly string _tokens =
    """
    [
        { "multiple": 5, "word": "Fizz" },
        { "multiple": 9, "word": "Buzz" },
        { "multiple": 27, "word": "Bar" }
    ]
    """;
    private readonly FizzBuzz _fizzBuzz;

    public CustomFizzBuzzTests()
    {
        _fizzBuzz = new FizzBuzz(_tokens);
    }

    [Fact]
    public void ExecuteMethodShouldProcessARangeAndPrintOutputs()
    {
        //Arrange

        //Act
        string result = _fizzBuzz.ExecuteFizzBuzz("-1-10");

        //Assert
        string expectedOutput = string.Format(@"-1{0}FizzBuzzBar{0}1{0}2{0}3{0}4{0}" +
                                                "Fizz{0}6{0}7{0}8{0}Buzz{0}Fizz{0}", Environment.NewLine);
        Assert.Equal(expectedOutput, result);
    }

    [Fact]
    public void ExecuteMethodShouldProcessASetAndPrintOutputs()
    {
        //Arrange

        //Act
        string result = _fizzBuzz.ExecuteFizzBuzz("-5, 6, 300, 12, 15");

        //Assert
        string expectedOutput = string.Format(@"Fizz{0}6{0}Fizz{0}12{0}Fizz{0}", Environment.NewLine);
        Assert.Equal(expectedOutput, result);
    }
}
