using System.Text.RegularExpressions;

string input = Console.ReadLine();//@mix#tix3dj#poOl##loOp#wl@@bong&song%4very$long@thong#Part##traP##@@leveL@@Level@##car#rac##tu@pack@@ckap@#rr#sAw##wAs#r#@w1r
string pattern = @"([#|@])([A-Za-z]{3,})\1{2}([A-Za-z]{3,})\1";
Regex regex = new Regex(pattern);
MatchCollection matches = regex.Matches(input);
int pairsFound = matches.Count;//5
int mirrorWordsCount = 0;
List<string> mirrorList = new List<string>() { };
if (pairsFound>0)
{
    Console.WriteLine($"{pairsFound} word pairs found!");
    foreach (Match item in matches)
    {
        string wordOne = item.Groups[2].Value;
        string wordTwo = item.Groups[3].Value;
        char[] charArray = wordTwo.ToCharArray();
        Array.Reverse(charArray);
        string reversed = new string(charArray);
        if (wordOne == reversed)
        {
            mirrorWordsCount++;
            string combineWord = $"{wordOne} <=> {wordTwo}";
            if (!mirrorList.Contains(combineWord))
            {
                mirrorList.Add(combineWord);
            }
           
        }
    }
    if (mirrorWordsCount>0)
    {
        Console.WriteLine($"The mirror words are: ");
        Console.Write(string.Join(", ", mirrorList));
    }
    else
    {
        Console.WriteLine($"No mirror words!"); 
    }
}
else
{
    Console.WriteLine($"No word pairs found!");
    Console.WriteLine($"No mirror words!");

}

