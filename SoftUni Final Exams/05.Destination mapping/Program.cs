using System.Text.RegularExpressions;

string pattern = @"([=\/])([A-Z][a-zA-Z]{2,})\1";
string input = Console.ReadLine();
Regex regex  = new Regex(pattern);
MatchCollection  matches = regex.Matches(input);
