//66/100 judge
List<string> collectionList = new List<string>(Console.ReadLine().Split(", ")); //Iron, Wood, Sword 
string command = Console.ReadLine(); ;// Collect - Gold// can it be list?
List<string> commandList = new List<string>() { };//empty

while (command != "Craft!")//Collect - Gold
{
    commandList.Add(command);//we add Collect - Gold -> //Iron Wood Sword Collect - Gold 
    int indexToReplaceDash = commandList.IndexOf(command);//index 3 / 
    commandList[indexToReplaceDash] = commandList[indexToReplaceDash].Replace(" - ", " ");////Iron Wood Sword Collect Gold 
                                                                                          //  0    1     2        3

    string value = commandList.Last();//value = Collect Gold
    //commandList.Add(value);
    List<string> commandListSeparated = value.Split(' ').ToList();
    string action = commandListSeparated[0];//Collect 
    string item = commandListSeparated[1];//Gold

    if (commandListSeparated[0] == "Collect")//gold
    {
        int indexOfCollect = collectionList.IndexOf(item);//do we have item=gold in collection
        if (indexOfCollect == -1)//if the item exists in the list
        {
            collectionList.Add(item);//Iron Wood Sword Gold
        }
    }
    else if (commandListSeparated[0] == "Drop")
    {
        int indexOfDrop = collectionList.IndexOf(item);//do we have item=wood in collection
        if (indexOfDrop != -1)//if the item exists in the list
        {
            collectionList.Remove(item);
        }

    }
    //else if (commandListSeparated[0] == "Combine Items")//2 words?//Sword:Bow
    //{
    //    //Combine Items - Sword:Bow 
    //}
    else if (commandListSeparated[0] == "Renew")// Iron, 
    {
        int indexToReplace = collectionList.IndexOf(item);//=Iron//index of replace
        if (indexToReplace != -1) // if the item exists in the list
        {
            collectionList.RemoveAt(indexToReplace); // remove the item from its current position
            collectionList.Add(item); // add the item to the last position
        }
    }

    command = Console.ReadLine();
    //commandList = (Console.ReadLine().Split(" - "));
}

Console.WriteLine(string.Join(", ", collectionList));