using System.Text;
using TwistedFizzBuzz;

string tokens =
"""
[
    { "multiple": 5, "word": "Fizz" },
    { "multiple": 9, "word": "Buzz" },
    { "multiple": 27, "word": "Bar" }
]
""";

var fizzBuzz = new FizzBuzz(tokens);

Console.Write(fizzBuzz.ExecuteFizzBuzz("-20-127"));
