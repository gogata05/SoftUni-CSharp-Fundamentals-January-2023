List<int> numbers = Console.ReadLine().Split().Select(int.Parse).ToList();

for (int i = numbers.Count-1; i >= 0; i--)
{
	if (numbers[i]<0)
	{
		numbers.RemoveAt(i);
	}
}

numbers.Reverse();


Console.WriteLine(string.Join(" ", numbers));