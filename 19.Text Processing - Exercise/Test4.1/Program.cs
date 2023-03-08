using System.Text;

string text = Console.ReadLine();
var sb = new StringBuilder();
foreach (var itemLetter in text)
{
    int charNum = itemLetter;
    charNum += 3;
    sb.Append((char)charNum);
}

Console.WriteLine(sb.ToString());