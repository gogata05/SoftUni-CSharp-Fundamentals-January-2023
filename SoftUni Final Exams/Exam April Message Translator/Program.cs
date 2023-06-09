using System;
using System.Text.RegularExpressions;

int n = int.Parse(Console.ReadLine());
string pattern = @"^!(?<command>[A-Z][a-z]{2,})!:\[(?<message>[A-Za-z]{8,})\]$";

for (int i = 0; i < n; i++)
{
    string input = Console.ReadLine();
    Match match = Regex.Match(input, pattern);
    if (match.Success)
    {
        string command = match.Groups["command"].Value;
        string message = match.Groups["message"].Value;
        string translatedMessage = "";
        foreach (char c in message)
        {
            int asciiValue = (int)c;
            translatedMessage += asciiValue + " ";
        }
        Console.WriteLine($"{command}: {translatedMessage.Trim()}");
    }
    else
    {
        Console.WriteLine("The message is invalid");
    }
}
