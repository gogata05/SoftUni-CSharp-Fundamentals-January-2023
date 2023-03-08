int[] inputNums = Console.ReadLine().Split().Select(int.Parse).ToArray();

for (int i = 0; i < inputNums.Length - 1; i++)
{
    for (int j = 0; j < inputNums.Length - 1 - i; j++)
    {
        inputNums[j] = inputNums[j] + inputNums[j + 1];
    }
}
Console.WriteLine(inputNums[0]);

//
