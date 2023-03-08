using System.Text.RegularExpressions;

string input = "Hello, world!";
string pattern = @"\w+";

MatchCollection matches = Regex.Matches(input, pattern);

foreach (Match match in matches)
{
    Console.WriteLine(match.Value);
}
