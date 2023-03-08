List<int> nums = Console.ReadLine().Split().Select(int.Parse).ToList();//main list

string command = Console.ReadLine();

while (command!="end")
{
    string[] commandInfoArray = command.Split();
    List<string> commandInfo = commandInfoArray.ToList();

    if (commandInfo[0] == "Delete")//5
    {

        int commandInfoInt = int.Parse(commandInfo[1]);
        if (nums.Contains(commandInfoInt))
        {
            nums.RemoveAt(nums.IndexOf(commandInfoInt));
        }
    }
    else if (commandInfo[0] == "Insert")//element and possition//10 1
    {
        int number = int.Parse(commandInfo[1]);
        int index = int.Parse(commandInfo[2]);
        nums.Insert(index, number);//number, index?
    }



    command = Console.ReadLine();
}
Console.WriteLine(string.Join(" ", nums));
//input:
//1 2 3 4 5 5 5 6
//Delete 5
//Insert 10 1
//Delete 5
//end
//my output: 1 10 2 3 4 5 6
//expected output: 1 10 2 3 4 6

