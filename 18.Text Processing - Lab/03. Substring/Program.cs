string wordToDelete = Console.ReadLine();//ice
string text = Console.ReadLine();//kicegiciceeb

while (text.Contains(wordToDelete))
{
    int startIndex = text.IndexOf(wordToDelete);//-1//kicegiciceeb.indexof(ice)

    text = text.Remove(startIndex, wordToDelete.Length);
}
Console.WriteLine(text);
//kgb