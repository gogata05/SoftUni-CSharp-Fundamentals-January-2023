int[] firstArray = Console.ReadLine().Split().Select(int.Parse).ToArray();
int[] secondArray = Console.ReadLine().Split().Select(int.Parse).ToArray();

int totalSum = 0;
bool identical = true;

for (int i = 0; i < firstArray.Length; i++)
{
	totalSum += firstArray[i];
	if (firstArray[i] != secondArray[i])
	{
		Console.WriteLine($"Arrays are not identical. Found difference at {i} index");
		totalSum += firstArray[i];
		identical = false;
		break;
	}
}

if (identical) // if false we dont enter here!
{
    Console.WriteLine($"Arrays are identical. Sum: {totalSum}");
}
