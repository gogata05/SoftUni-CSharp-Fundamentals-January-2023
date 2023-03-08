int[] numbers = Console.ReadLine().Split().Select(int.Parse).ToArray(); 

int longestSequanceStartIndex = 0;
int longestSequanceLength = 0;

for (int i = 1; i < numbers.Length; i++)
{
    int currentSequanceStartIndex = i - 1;
    int currentSequanceLength = 1;

    while (i < numbers.Length && numbers[i] == numbers[i-1])
    {
        currentSequanceLength++;
        i++;
    }

    if (currentSequanceLength > longestSequanceLength)
    {
        longestSequanceLength = currentSequanceLength;
        longestSequanceStartIndex = currentSequanceStartIndex;
    }
}

for (int i = longestSequanceStartIndex; i < longestSequanceStartIndex + longestSequanceLength; i++)
{
    Console.Write($"{numbers[i]} ");
}