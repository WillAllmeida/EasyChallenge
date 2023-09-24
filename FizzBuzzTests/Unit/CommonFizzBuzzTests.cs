using TwistedFizzBuzz;

namespace FizzBuzzTests.Unit;
public class CommonFizzBuzzTests
{
    private readonly string _tokens =
    """
    [
        { "multiple": 3, "word": "Fizz" },
        { "multiple": 5, "word": "Buzz" }
    ]
    """;
    private readonly FizzBuzz _fizzBuzz;

    public CommonFizzBuzzTests()
    {
        _fizzBuzz = new FizzBuzz(_tokens);
    }

    [Fact]
    public void ExecuteMethodShouldProcessOnlyValidInputs()
    {
        //Arrange

        //Act
        string result = _fizzBuzz.ExecuteFizzBuzz("1, 2, 3, 4, 5, a, b, 6");

        //Assert
        string expectedOutput = string.Format(@"1{0}2{0}Fizz{0}4{0}Buzz{0}Fizz{0}", Environment.NewLine);
        Assert.Equal(expectedOutput, result);
    }
}
