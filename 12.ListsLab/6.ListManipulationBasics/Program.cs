List<int> numbers = Console.ReadLine().Split().Select(int.Parse).ToList();
string command = Console.ReadLine();

while (command!= "end")
{
    //Add { number}: add a number to the end of the list.
    //Remove { number}: remove a number from the list. 
    //RemoveAt { index}: remove a number at a given index.
    //Insert { number} { index}: insert a number at a given index.
    string[] commandInfo = command.Split();//["Add","3"]

    if (commandInfo[0] == "Add")
    {
        int number = int.Parse(commandInfo[1]);
        numbers.Add(number);
    }
    else if (commandInfo[0] == "Remove")
    {
        int number = int.Parse(commandInfo[1]);
        numbers.Remove(number);
    }
    else if (commandInfo[0] == "RemoveAt")
    {
        int index = int.Parse(commandInfo[1]);
        numbers.RemoveAt(index);
    }
    else if (commandInfo[0] == "Insert")
    {
        int number = int.Parse(commandInfo[1]);
        int index = int.Parse(commandInfo[2]);
        numbers.Insert(index, number);
    }
}
Console.WriteLine(string.Join(" ", numbers));