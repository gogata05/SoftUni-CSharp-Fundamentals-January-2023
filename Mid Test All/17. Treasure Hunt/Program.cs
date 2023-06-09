List<string> initialTreasureChestList = new List<string>(Console.ReadLine().Split("|"));//Gold|Silver|Bronze|Medallion|Cup
string command = Console.ReadLine();//Loot Wood Gold Coins //Loot Silver Pistol //Drop 3 //Steal 3 //Yohoho! 
while (command != "Yohoho!")//Loot Wood Gold Coins //Loot Silver Pistol //Drop 3 //Steal 3 //Yohoho!
{
    List<string> commandList = command.Split().ToList();//check//Loot Wood Gold Coins

    if (commandList[0] == "Loot")////Loot Wood Gold Coins
    {
        foreach (var item in commandList.Skip(1))//Wood Gold Coins and we skip Loot
        {
            if (!initialTreasureChestList.Contains(item))
            {
                initialTreasureChestList.Insert(0, item);//check
            }

        }
    }
    else if (commandList[0] == "Drop")//RemoveAt & Add in the end//Drop index 3
    {
        int removeIndex = int.Parse(commandList[1]);//3/remove index 3
        if (removeIndex >= 0 && removeIndex < initialTreasureChestList.Count - 1)//if index<0 if not bigger than count
        {
            string element = initialTreasureChestList[removeIndex];//Gold//remember Gold
            initialTreasureChestList.RemoveAt(removeIndex);//remove index 3//Gold
            initialTreasureChestList.Add(element);//we add gold at the end
        }
    }
    else if (commandList[0] == "Steal")//Steal 3/We remove last 3 indexes in main and we put
                                       //the in stolen list & Print in reverse
                                       //Pistol Coins Wood Silver Bronze Medallion Cup Gold
                                       ////Remove Gold Cup Medallion
    {
        int removeLastIndexAndAddToStolenList = int.Parse(commandList[1]);//3
        List<string> stolenList = new List<string>() { };//empty//to print
        if (removeLastIndexAndAddToStolenList > initialTreasureChestList.Count)//3>2 lets say 2/than its equil
        {
            removeLastIndexAndAddToStolenList = initialTreasureChestList.Count;//exp 2=2 to remove if we dont have enough
        }
        for (int i = 0; i < removeLastIndexAndAddToStolenList; i++)//3 times we remove and add
        {
            stolenList.Add(initialTreasureChestList[initialTreasureChestList.Count - 1]);//we add last index of main elements to stolen list
            initialTreasureChestList.RemoveAt(initialTreasureChestList.Count - 1);//we remove the last index of main elements
        }
        stolenList.Reverse();
        Console.WriteLine(string.Join(", ", stolenList));
    }
    command = Console.ReadLine();
}

if (initialTreasureChestList.Count == 0)
{
    Console.WriteLine("Failed treasure hunt.");
}
else
{
    int sumItemsInList = initialTreasureChestList.Sum(x => x.Length);//27//Pistol(6) + Coins(5) + Wood(4)  + Silver(6) + Bronze(6) = 27
    double averageGain = sumItemsInList / (double)initialTreasureChestList.Count;
    Console.WriteLine($"Average treasure gain: {averageGain:f2} pirate credits.");
}