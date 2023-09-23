using System.Text.Json;

namespace TwistedFizzBuzz;
public static class TokenHelper
{
    private static readonly JsonSerializerOptions _options = new JsonSerializerOptions
    {
        PropertyNameCaseInsensitive = true
    };
    public static Dictionary<int, string> HandleGeneratedTokens(this string input)
    {
        var tokens = JsonSerializer.Deserialize<List<Token>>(input, _options);

        return tokens!.ToDictionary(t => t.Multiple, t => t.Word);
    }
}
