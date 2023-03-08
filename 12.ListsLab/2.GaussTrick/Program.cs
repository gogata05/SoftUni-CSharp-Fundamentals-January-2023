//1 2 3 4 5 -> 1+5 , 2+4 , 3-> 6,6,3 - subirane na 4islata naobratno
//1 2 3 4-> 5 5 

;
List<int> nums = Console.ReadLine().Split().Select(int.Parse).ToList();

List<int> result = new List<int>() { };

for (int i = 0; i < nums.Count / 2; i++)//delim na 2 za da suberem 4islata naobratno

{
int currentSum = nums[i]+ nums[nums.Count - 1 - i];//1 + locaciq//5,4,3,2, da wurwim otdqsno nalqwo
    result.Add(currentSum);
}

if (nums.Count %2 != 0)
{
    result.Add(nums[nums.Count / 2]);//ako e ne4etno dobawqme indexa 
}
Console.WriteLine(string.Join(" ", result));