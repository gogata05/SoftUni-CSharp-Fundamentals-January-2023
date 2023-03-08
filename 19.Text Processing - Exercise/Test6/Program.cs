string text = Console.ReadLine();//aaaaabbbbbcdddeeeedssaa
char currentChar = text[0];
Console.Write(currentChar);
for (int i = 1; i < text.Length; i++)
{
  char lastChar = text[i];//a
  if (currentChar!=lastChar)
  {
      Console.Write(lastChar);
      currentChar = lastChar;
  }
}