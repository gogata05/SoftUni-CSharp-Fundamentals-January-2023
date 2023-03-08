Dictionary<string, int> dictionary = new Dictionary<string, int>();
string commandResource = Console.ReadLine();//Gold//Silver//Copper//stop
while (commandResource!="stop")
{
    string quantity = Console.ReadLine();//155//10//17
    if (!dictionary.ContainsKey(commandResource))//gold
    {
        dictionary.Add(commandResource,0);//gold=0
    }
    dictionary[commandResource] += int.Parse(quantity);//155

    commandResource = Console.ReadLine();
}

foreach (var item in dictionary)
{
    Console.WriteLine($"{item.Key} -> {item.Value}");
}
