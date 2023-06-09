List<string> textList = new List<string>(Console.ReadLine().Split('!'));
string command = Console.ReadLine();
while (command!= "Go Shopping!")
{
    string[] commandArray = command.Split();
    string act = commandArray[0];
    if (act== "Urgent")
    {
        string item = commandArray[1];
        if (!textList.Contains(item))
        {
            textList.Insert(0,item);
        }
    }
    else if (act== "Unnecessary")
    {
        string itemRemove = commandArray[1];
        if (textList.Contains(itemRemove))
        {
            int index = textList.IndexOf(itemRemove);
            textList.RemoveAt(index);
        }
    }
    else if (act == "Correct")//Correct Pepper Onion 
    {
        string oldItem = commandArray[1];
        if (textList.Contains(oldItem))
        {
            string newItem = commandArray[2];
            int index = textList.IndexOf(oldItem);
            textList[index] = newItem;
        }
    }
    else if (act== "Rearrange")
    {
        string item = commandArray[1];
        if (textList.Contains(item))
        {
            
            int copy = textList.IndexOf(item);
            textList.RemoveAt(copy);
            textList.Add(item);
        }
    }
    command = Console.ReadLine();
}

Console.Write(string.Join(", ", textList));