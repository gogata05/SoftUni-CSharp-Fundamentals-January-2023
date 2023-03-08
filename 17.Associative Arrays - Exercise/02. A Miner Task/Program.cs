Dictionary<string, int> dictionary = new Dictionary<string, int>();//count 0
string commandResource = Console.ReadLine(); //Gold//Silver//Copper//stop
while (commandResource!= "stop") //Gold//Silver//Copper//stop
{
    int quantity = int.Parse(Console.ReadLine());//155//10/17
    //Skips the else and the nesting
    if (!dictionary.ContainsKey(commandResource))//Gold
    {
        dictionary.Add(commandResource,0);//add gold=0
    }
    dictionary[commandResource] += quantity;//0+=quantity

    commandResource = Console.ReadLine();
}
foreach (var item in dictionary)
{
    Console.WriteLine($"{item.Key} -> {item.Value}");
}

