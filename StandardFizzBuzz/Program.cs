using System.Text;
using TwistedFizzBuzz;

string tokens =
"""
[
    { "multiple": 3, "word": "Fizz" },
    { "multiple": 5, "word": "Buzz" }
]
""";

var fizzBuzz = new FizzBuzz(tokens);

Console.Write(fizzBuzz.ExecuteFizzBuzz("1-100"));
