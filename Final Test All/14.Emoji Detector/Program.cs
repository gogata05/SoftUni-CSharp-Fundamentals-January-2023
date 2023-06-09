using System.Text.RegularExpressions;
Dictionary<string,string>dictionary = new Dictionary<string,string>();
string input = Console.ReadLine();
string pattern1 = @"([:|*]){2}([A-Z][a-z]{2,})\1{2}";
string pattern2 = @"[0-9]";
Regex regex1 = new Regex(pattern1);
Regex regex2 = new Regex(pattern2);
MatchCollection matchesNames = regex1.Matches(input);//names
MatchCollection matchesNumbers = regex2.Matches(input);//nums
List<int> integerList2 = matchesNumbers.Select(m => int.Parse(m.Value)).ToList();

int coolThresholdSum = integerList2.Aggregate((a, b) => a * b);//540
int emojuCount = matchesNames.Count;//4
int asciiSum = 0;

Console.WriteLine($"Cool threshold: {coolThresholdSum}");
Console.WriteLine($"{emojuCount} emojis found in the text. The cool ones are:");

foreach (Match match in matchesNames)
{
    string currentMatchWith = match.Value;
    string currentMatchWithout = match.Groups[2].Value;
    if (!dictionary.ContainsKey(currentMatchWith))
    {
        foreach (char c in currentMatchWithout)
        {
            asciiSum += Convert.ToInt32(c);
        }

        if (asciiSum>coolThresholdSum)
        {
            dictionary.Add(currentMatchWith, currentMatchWithout);
            asciiSum = 0;
        }
    }
}

foreach (var item in dictionary)
{
    string finalNames = item.Key;
    Console.WriteLine($"{finalNames}");
}

