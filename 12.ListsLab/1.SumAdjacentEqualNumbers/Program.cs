//3 3 6 1-> 6 6 1 -> 12 1

;
List<double> nums = Console.ReadLine().Split().Select(double.Parse).ToList();//0,1,2,3//3 3 6 1


for (int i = 0; i < nums.Count-1; i++)//-1
{//3
	if (nums[i]== nums[i+1])//if 3==3//[0]==[1]//prowerka na susedno 4islo
	{
		
        nums[i] = nums[i] + nums[i + 1];//3+3=6
		nums.RemoveAt(i+1);
		i= -1;

    }
}

Console.WriteLine(string.Join(" ", nums));
