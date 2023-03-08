using System.Text.RegularExpressions;

string pattern = @"\w+";
string input = "StoSho";

Regex regex = new Regex(pattern);
bool isMatch = regex.IsMatch(input);
Console.WriteLine(isMatch);