using System;
using System.Text.RegularExpressions;

string spell = Console.ReadLine();
string command;

while ((command = Console.ReadLine()) != "Abracadabra")
{
    string[] commandParts = command.Split(' ');

    switch (commandParts[0])
    {
        case "Abjuration":
            spell = spell.ToUpper();
            Console.WriteLine(spell);
            break;
        case "Necromancy":
            spell = spell.ToLower();
            Console.WriteLine(spell);
            break;
        case "Illusion":
            int index = int.Parse(commandParts[1]);
            char letter = commandParts[2][0];

            if (index >= 0 && index < spell.Length)
            {
                char[] spellArray = spell.ToCharArray();
                spellArray[index] = letter;
                spell = new string(spellArray);
                Console.WriteLine("Done!");
            }
            else
            {
                Console.WriteLine("The spell was too weak.");
            }
            break;
        case "Divination":
            string firstSubstring = commandParts[1];
            string secondSubstring = commandParts[2];

            if (spell.Contains(firstSubstring))
            {
                spell = spell.Replace(firstSubstring, secondSubstring);
                Console.WriteLine(spell);
            }
            break;
        case "Alteration":
            string substringToRemove = commandParts[1];

            if (spell.Contains(substringToRemove))
            {
                spell = spell.Replace(substringToRemove, "");
                Console.WriteLine(spell);
            }
            break;
        default:
            Console.WriteLine("The spell did not work!");
            break;
    }
}
