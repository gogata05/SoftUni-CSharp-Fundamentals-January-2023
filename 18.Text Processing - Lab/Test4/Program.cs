string[] bannedWords = Console.ReadLine().Split(", ");//lunix, windows
string text = Console.ReadLine();
foreach (var item in bannedWords)
{
    text = text.Replace(item, new string('*', item.Length));
}

Console.WriteLine(text);