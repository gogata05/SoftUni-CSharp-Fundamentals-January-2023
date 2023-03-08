int n = int.Parse(Console.ReadLine());
int totalSum = 0;
int totalVowel = 0;
int totalConsonant = 0;
int consonantDevaded = 0;
int[] totalSumArray = new int[n];

for (int i = 0; i < n; i++)
{
    string name = Console.ReadLine();
    for (int j = 0; j < name.Length; j++)
    {
        char character = name[j];
        if (character == 'a' || character == 'A' || character == 'u' || character == 'U' || character == 'o' ||
            character == 'O' || character == 'e' || character == 'E' || character == 'i' || character == 'I')

        {
            totalVowel += (int)character;
        }
        else
        {
            consonantDevaded = (int)character / name.Length;
            totalConsonant += consonantDevaded;
        }

        if (j == name.Length - 1)
        {
            totalVowel *= name.Length;
            totalSum = totalVowel + totalConsonant;
            totalSumArray[i] = totalSum;
            totalVowel = 0;
            totalConsonant = 0;

        }
    }
}
Array.Sort(totalSumArray);
foreach (var item in totalSumArray)
{
    Console.WriteLine(item);
}