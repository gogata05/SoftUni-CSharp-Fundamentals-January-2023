string text = Console.ReadLine(); //aaaabbbccc
char previousChar = text[0];   // 'a'
Console.Write(previousChar);

for (int i = 1; i < text.Length; i++)
{
    char currentChar = text[i];//a
    if (previousChar != currentChar) // a != b then previusChar = b
    {
        previousChar = currentChar;
        Console.Write(previousChar); // 'ab'
    }
}