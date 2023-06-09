Dictionary<string, List<int>> dictionary = new Dictionary<string, List<int>>();
string input = Console.ReadLine();//
//Tortuga || 345000 || 1250
//Santo Domingo||240000||630
//Havana||410000||1100           //Sail
//Plunder=>Tortuga=>75000=>380
//Prosper=>Santo Domingo=>180    //End
while (input!="Sail")//Tortuga||345000||1250
{
    string[] inputArray = input.Split("||");
    string town = inputArray[0];
    int population = int.Parse(inputArray[1]);
    int gold = int.Parse(inputArray[2]);
    if(!dictionary.ContainsKey(town))
    {
        dictionary[town] = new(){};//Tortuga
        dictionary[town].Insert(0,population);//345000
        dictionary[town].Insert(1,gold);
    }
    else
    {
        dictionary[town][0] += population;//+=population
        dictionary[town][1] += gold;
    }
    input = Console.ReadLine();
}
string command = Console.ReadLine();
while (command!="End")////Plunder=>Tortuga=>75000=>380
{
    string[] commandArray = command.Split("=>");
    string act = commandArray[0];//Plunder
    if (act=="Plunder")
    {
        string city = commandArray[1];//Tortuga
        int populationKilled = int.Parse(commandArray[2]);//75000
        int goldStolen = int.Parse(commandArray[3]);//380
        
        dictionary[city][0] -= populationKilled;
        dictionary[city][1] -= goldStolen;
        Console.WriteLine($"{city} plundered! {goldStolen} gold stolen, {populationKilled} citizens killed.");
        if (dictionary[city][0] <= 0 || dictionary[city][1] <= 0)
        {
            Console.WriteLine($"{city} has been wiped off the map!");
            dictionary.Remove(city);
        }
    
    }
    else if (act=="Prosper")
    {
        string city = commandArray[1];//Tortuga
        int goldAdded = int.Parse(commandArray[2]);
        if (goldAdded<=0)
        {
            Console.WriteLine("Gold added cannot be a negative number!");
        }
        else
        {
            dictionary[city][1] += goldAdded;
            int totalGold = dictionary[city][1];
            Console.WriteLine($"{goldAdded} gold added to the city treasury. {city} now has {totalGold} gold.");
        }
    }
    command = Console.ReadLine();
}
int count = dictionary.Count;
if (count==0)
{
    Console.WriteLine($"Ahoy, Captain! All targets have been plundered and destroyed!");
}
else
{
    Console.WriteLine($"Ahoy, Captain! There are {count} wealthy settlements to go to:");
    foreach (var item in dictionary)
    {
        string city = item.Key;
        int population = item.Value[0];
        int gold = item.Value[1];
        Console.WriteLine($"{city} -> Population: {population} citizens, Gold: {gold} kg");
    }
}


