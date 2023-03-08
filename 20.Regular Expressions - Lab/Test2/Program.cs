using System.Text.RegularExpressions;

string pattern = @"(?:(?<=^)|(?<=\s))\+359([ -])2\1\d{3}([ -])\d{4}\b";
string input = Console.ReadLine();
Regex regex  = new Regex(pattern);
MatchCollection  matches = regex.Matches(input);
string[] arrayStrings = matches.Select(x=>x.Value).ToArray();
Console.WriteLine(string.Join(", ", arrayStrings));