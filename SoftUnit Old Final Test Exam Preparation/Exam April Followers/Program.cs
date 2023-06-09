using System;
using System.Collections.Generic;

Dictionary<string, List<int>> followers = new Dictionary<string, List<int>>();

string input;
while ((input = Console.ReadLine()) != "Log out")
{
    string[] tokens = input.Split(": ", StringSplitOptions.RemoveEmptyEntries);
    string command = tokens[0];

    if (command.StartsWith("New"))
    {
        string username = tokens[1];
        if (!followers.ContainsKey(username))
        {
            followers[username] = new List<int> { 0, 0 };
        }
    }
    else if (command.StartsWith("Like"))
    {
        string username = tokens[1];
        int likes = int.Parse(tokens[2]);
        if (!followers.ContainsKey(username))
        {
            followers[username] = new List<int> { likes, 0 };
        }
        else
        {
            followers[username][0] += likes;
        }
    }
    else if (command.StartsWith("Comment"))
    {
        string username = tokens[1];
        if (!followers.ContainsKey(username))
        {
            followers[username] = new List<int> { 0, 1 };
        }
        else
        {
            followers[username][1] += 1;
        }
    }
    else if (command.StartsWith("Blocked"))
    {
        string username = tokens[1];
        if (!followers.ContainsKey(username))
        {
            Console.WriteLine($"{username} doesn't exist.");
        }
        else
        {
            followers.Remove(username);
        }
    }
}

Console.WriteLine($"{followers.Count} followers");
foreach (var follower in followers)
{
    Console.WriteLine($"{follower.Key}: {follower.Value[0] + follower.Value[1]}");
}