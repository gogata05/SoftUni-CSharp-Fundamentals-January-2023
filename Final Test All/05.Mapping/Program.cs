using System.Text.RegularExpressions;

string pattern = @"([=\/])([A-Z][a-zA-Z]{2,})\1";
string input = Console.ReadLine();
Regex regex = new Regex(pattern);
MatchCollection matches = regex.Matches(input);
int travelPoints = 0;
Match match = regex.Match(input);
if (!match.Success)
{
    Console.WriteLine($"Destinations: ");
    Console.WriteLine($"Travel Points: {travelPoints}");
    return;
}
List<string> destinationList = matches.Select(m => m.Value).ToList();

for (int i = 0; i < destinationList.Count; i++)
{
    string currentItem = destinationList[i];
    currentItem = currentItem.Replace("=", "");
    currentItem = currentItem.Replace("/", "");
    destinationList[i] = currentItem;
}
foreach (var item in destinationList)
{
    travelPoints += item.Length;
}
Console.WriteLine($"Destinations: {string.Join(", ", destinationList).Replace("=", "").Replace("/", "")}");
Console.WriteLine($"Travel Points: {travelPoints}");
