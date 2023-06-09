//23 -2 321 87 42 90 -123 

List<int> numList = Console.ReadLine().Split().Select(int.Parse).ToList();
string command = Console.ReadLine();
while (command!="end")
{
    string[] commandArray = command.Split();
    string act = commandArray[0];//swap
    if (act=="swap")//swap 3 6 
    {
        int index1 = int.Parse(commandArray[1]);//?=>?
        int index2 = int.Parse(commandArray[2]);//?=>?
        int replace = numList[index1];////?=>?
        numList[index1] = numList[index2];////?=>?
        numList[index2] = replace;////?=>?


    }
    else if (act== "multiply")
    {
        int index1 = int.Parse(commandArray[1]);//3=>87
        int index2 = int.Parse(commandArray[2]);//6=>-123
        int newNum = numList[index1] * numList[index2];//23*321
        numList[index1] = newNum;//=7383
    }
    else if (act == "decrease")
    {
        for (int i = 0; i < numList.Count; i++)
        {
            numList[i]-=1;
        } 
    }
    command = Console.ReadLine();
}

Console.Write(string.Join(", ", numList));

