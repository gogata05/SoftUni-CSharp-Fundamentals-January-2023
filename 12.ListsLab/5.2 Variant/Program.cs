List<int> nums = Console.ReadLine().Split().Select(int.Parse).ToList();

nums.RemoveAll(x => x < 0);
if (nums.Count >0)
{
    nums.Reverse();

    Console.WriteLine(string.Join(" ", nums));
}
else
{
    Console.WriteLine("empty");
}

