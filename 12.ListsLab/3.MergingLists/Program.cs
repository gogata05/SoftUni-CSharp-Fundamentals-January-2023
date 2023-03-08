//3 5 2 43 12 3 54 10 23 
//76 5 34 2 4 12
//3 76 5 5 2 34 43 2 12 4 3 12 54 10 23

//76 5 34 2 4 12
//3 5 2 43 12 3 54 10 23 
//76 3 5 5 34 2 2 43 4 12 12 3 54 10 23
;
List<int> leftList = Console.ReadLine().Split().Select(int.Parse).ToList();//8
List<int> rightList = Console.ReadLine().Split().Select(int.Parse).ToList();//5

  
List<int> finalList = new List<int>() { };

int minValue = Math.Min(leftList.Count, rightList.Count);//koe e po-malko

for (int i = 0; i < minValue; i++)
{
    finalList.Add(leftList[i]);//3 5
    finalList.Add(rightList[i]);// 76 5
}

if (leftList.Count > rightList.Count)
{
    for (int i = minValue; i < leftList.Count; i++)
    {
        finalList.Add(leftList[i]);
    }
}
else if (rightList.Count > leftList.Count)
{
    for (int i = minValue; i < rightList.Count; i++)
    {
        finalList.Add(rightList[i]);
    }
   
}

Console.WriteLine(string.Join(" ", finalList));