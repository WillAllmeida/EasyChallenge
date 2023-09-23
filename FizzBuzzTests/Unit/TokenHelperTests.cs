using TwistedFizzBuzz;

namespace FizzBuzzTests.Unit;
public class TokenHelperTests
{
    [Fact]
    public void HandleMethodShouldReturnCorrectDictionaryForOneEntry()
    {
        //Arrange
        string input = @"[{ ""multiple"": 3, ""word"": ""Fizz"" }]";

        //Act
        var result = input.HandleGeneratedTokens();

        //Assert
        Dictionary<int, string> expectedResult = new Dictionary<int, string>
        {
            [3] = "Fizz"
        };
        Assert.Equal(result, expectedResult);
    }

    [Fact]
    public void HandleMethodShouldReturnCorrectDictionaryForMultipleEntries()
    {
        //Arrange
        string input = @"
        [
            { ""multiple"": 2, ""word"": ""Fizz"" },
            { ""multiple"": 3, ""word"": ""Buzz"" },
            { ""multiple"": 5, ""word"": ""Bar"" }
        ]
        ";

        //Act
        var result = input.HandleGeneratedTokens();

        //Assert
        Dictionary<int, string> expectedResult = new Dictionary<int, string>
        {
            [2] = "Fizz",
            [3] = "Buzz",
            [5] = "Bar"
        };

        Assert.Equal(result, expectedResult);
    }

    [Fact]
    public void HandleMethodShouldReturnEmptyDictionaryForNoEntries()
    {
        //Arrange
        string input = "[]";

        //Act
        var result = input.HandleGeneratedTokens();

        //Assert
        Dictionary<int, string> expectedResult = new Dictionary<int, string>
        {
        };
        Assert.Equal(result, expectedResult);
    }
}
