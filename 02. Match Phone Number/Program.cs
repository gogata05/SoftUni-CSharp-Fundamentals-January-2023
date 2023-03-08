using System.Text.RegularExpressions;

string pattern = @"(?:(?<=^)|(?<=\s))\+359([ -])2\1\d{3}([ -])\d{4}\b"; //@"(\+359[- /]2[- /]\d{3}[- ]\d{4})";
string input = Console.ReadLine();

Regex regex = new Regex(pattern);
MatchCollection matchCollection = regex.Matches(input);

string[] result = matchCollection.Select(x => x.Value).ToArray();
Console.WriteLine(string.Join(", ", result));
