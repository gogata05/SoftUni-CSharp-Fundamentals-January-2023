string text = Console.ReadLine();
int vowelsCount = GetVowelsCount(text);
Console.WriteLine(vowelsCount);

int GetVowelsCount(string text)
{
    int vowelsCount = 0;

    char[] vowels = new char[] { 'a', 'e', 'o', 'i', 'u' };
    foreach (var letter in text.ToLower())
    {
        if (vowels.Contains(letter));
        {
            vowelsCount++;
        }
    }
    return vowelsCount;
}

