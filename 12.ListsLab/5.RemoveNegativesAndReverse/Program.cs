//10 -5 7 9 -33 50 
//50 9 7 10 
//7 -2 -10 1 
//1 7 
//-1 -2 -3 
//empty

List<int> nums = Console.ReadLine().Split().Select(int.Parse).ToList();

List<int> result = new List<int>() { };

foreach (var item in nums)
{
	if (item>=0)
	{
		result.Add(item);
	}
}

result.Reverse();


Console.WriteLine(string.Join(" ", result));

