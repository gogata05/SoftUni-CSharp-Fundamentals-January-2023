int[] nums = Console.ReadLine().Split().Select(int.Parse).ToArray();
int average = (int)nums.Average();
int[] result = nums.Where(x => x > average).OrderByDescending(x => x).Take(5).ToArray();

if (result.Any())
{
    Console.WriteLine(string.Join(" ", result));
}
else
{
    Console.WriteLine("No");
}