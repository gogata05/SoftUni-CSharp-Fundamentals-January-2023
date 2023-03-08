string[] words = Console.ReadLine().Split().Where(x=> x.Length%2==0).ToArray();

foreach (var item in words)
{
    Console.WriteLine(item);
}

//Console.ReadLine().Split().Where(x=>x.Length%2==0).ToList().ForEach(Console.WriteLine);
int[] nums = Console.ReadLine().Split().Select(int.Parse).ToArray();