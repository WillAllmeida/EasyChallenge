using TwistedFizzBuzz;

string tokens =
@"
[
    { ""multiple"": 3, ""word"": ""Fizz"" },
    { ""multiple"": 5, ""word"": ""Buzz"" }
]
";

var fizzBuzz = new FizzBuzz(tokens);

fizzBuzz.ExecuteFizzBuzz("1-100");
