int[] inputNums = Console.ReadLine().Split().Select(int.Parse).ToArray();   
int sum = 0;

for (int i = 0; i < inputNums.Length; i++)
{
	if (inputNums[i] %2 ==0)
	{
		sum += inputNums[i];
	}
}
Console.WriteLine(sum);