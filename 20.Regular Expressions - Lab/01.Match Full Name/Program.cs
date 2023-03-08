using System.Text.RegularExpressions;

string pattern = @"\b[A-Z][a-z]+ [A-Z][a-z]+\b";
string input = Console.ReadLine();//Bethany Taylor, Oliver miller, sophia Johnson, SARah Wilson,John Smith, Sam Smith

Regex regex = new Regex(pattern);
MatchCollection matchCollection = regex.Matches(input);

foreach (Match itemMatch in matchCollection)
{
    Console.Write(itemMatch.Value+" ");
}
//Bethany Taylor John Smith