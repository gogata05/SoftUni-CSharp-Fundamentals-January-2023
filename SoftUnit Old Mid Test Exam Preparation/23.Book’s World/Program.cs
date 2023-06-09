using System;
using System.Collections.Generic;

List<string> genres = new(Console.ReadLine().Split(" | "));
while (true)
{
    string command = Console.ReadLine();
    if (command == "Stop!")
    {
        break;
    }
    string[] commandArray = command.Split(" ");
    string act = commandArray[0];
    if (act == "Join")
    {
        string genre = commandArray[1];
        if (!genres.Contains(genre))
        {
            genres.Add(genre);
        }
    }
    else if (act == "Drop")
    {
        string genre = commandArray[1];
        genres.Remove(genre);
    }
    else if (act == "Replace")
    {
        string oldGenre = commandArray[1];
        string newGenre = commandArray[2];
        if (genres.Contains(oldGenre) && !genres.Contains(newGenre))
        {
            int index = genres.IndexOf(oldGenre);
            genres[index] = newGenre;
        }
    }
    else if (act == "Prefer")
    {
        int genreIndex1 = int.Parse(commandArray[1]) ;
        int genreIndex2 = int.Parse(commandArray[2]) ;

        if (genreIndex1 >= 0 && genreIndex1 < genres.Count &&
            genreIndex2 >= 0 && genreIndex2 < genres.Count)
        {
            string temp = genres[genreIndex1];
            genres[genreIndex1] = genres[genreIndex2];
            genres[genreIndex2] = temp;
        }
    }
}
Console.WriteLine(string.Join(" ", genres));