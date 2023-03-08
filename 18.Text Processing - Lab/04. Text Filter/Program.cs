string[] bannedWords = Console.ReadLine().Split(", ");//Linux, Windows 
string text = Console.ReadLine();// It is not Li....

foreach (var item in bannedWords)
{
    text = text.Replace(item, new string('*', item.Length));
}

Console.WriteLine(text);