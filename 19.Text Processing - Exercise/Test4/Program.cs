using System;

string input = Console.ReadLine(); // Programming is cool!
string result = "";
foreach (char currChar in input)
{
    int currPosition = currChar; // currChar = "P" in int => 80
    currPosition += 3;
    result += (char)currPosition; // 83 int into char => 'S'
}
Console.WriteLine(result);