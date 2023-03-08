using System.Text.RegularExpressions;

string pattern = @"\b[A-Z][a-z]+ [A-Z][a-z]+\b";
string input = Console.ReadLine();//names
Regex regex = new Regex(pattern);
MatchCollection matches = regex.Matches(input);
foreach (Match match in matches)
{
    Console.Write(match.Value +" ");
}
