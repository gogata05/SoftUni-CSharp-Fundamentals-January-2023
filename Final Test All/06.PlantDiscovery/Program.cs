using System.Numerics;
using System.Text.RegularExpressions;

int n = int.Parse(Console.ReadLine());//3
Dictionary<string, double> dictionary1 = new Dictionary<string, double>();//double?
Dictionary<string, List<double>> dictionary2 = new Dictionary<string, List<double>>();//double?
double rating = 0;
double average = 0;
for (int i = 0; i < n; i++)
{
    string commandTest = Console.ReadLine();
    string pattern = @"[a-zA-Z]+<->\d+";
    Regex regex = new Regex(pattern);
    Match match = regex.Match(commandTest);
    if (!match.Success)
    {
        Console.WriteLine("error");
        i--;
        continue;
    }
    string[] plantNamesArray = commandTest.Split("<->", StringSplitOptions.RemoveEmptyEntries);
    string plant1 = plantNamesArray[0];//Arnoldii
    double quantity = double.Parse(plantNamesArray[1]);//4
    if (!dictionary1.ContainsKey(plant1))
    {
        //dictionary1[plant1] = new List<double>();
        dictionary1.Add(plant1, quantity);//dictionary = plant //quantity////Arnoldii 4 Woodii 7 Welwitschia 2
    }
}
string command = Console.ReadLine();////Rate: Woodii - 10 //Rate: Welwitschia - 7 //Rate: Arnoldii - 3 //Rate: Woodii - 5 //Update: Woodii - 5 //Reset: Arnoldii //Exhibition    
while (command != "Exhibition")
{

    string[] commandArrayB = command.Trim().Split(':', '-');
    string[] commandArray = commandArrayB.Select(s => s.Trim()).Where(s => s != "").ToArray();
    string actCommand = commandArray[0];
    string plant2 = commandArray[1];//Woodii
    if (commandArray[0] == "Rate")
    {
        if (dictionary1.ContainsKey(plant2))
        {
            rating = double.Parse(commandArray[2]);//10
            if (!dictionary2.ContainsKey(plant2))
            {
                dictionary2[plant2] = new List<double>();
                dictionary2[plant2].Add(rating);
            }
            else
            {
                dictionary2[plant2].Add(rating);
            }
        }
        else
        {
            Console.WriteLine("error");
        }
    }

    else if (commandArray[0] == "Update")//Update Woodii 5
    {
        if (dictionary1.ContainsKey(plant2))
        {
            dictionary1[plant2] = int.Parse(commandArray[2]);//dictionary1["Woodii] = int.Parse(5])
        }
        else
        {
            Console.WriteLine("error");
        }

    }

    else if (commandArray[0] == "Reset")
    {
        if (dictionary1.ContainsKey(plant2))
        {
            dictionary2[plant2].Clear();
        }
        else
        {
            Console.WriteLine("error");
        }
    }
    command = Console.ReadLine();
}
//double average = dictionary2.Values.Average();
Console.WriteLine("Plants for the exhibition:");
foreach (var item in dictionary1)
{
    //double average = 0;
    string currentPlant = item.Key;
    double currentRarity = item.Value;
    if (dictionary2[currentPlant].Any())
    {
        average = dictionary2[currentPlant].Average();
    }
    Console.WriteLine($"- {currentPlant}; Rarity: {currentRarity}; Rating: {average:f2}");
}
//3
//Arnoldii <->4
//Woodii <->7
//Welwitschia <->2
//Rate: Woodii - 10
//Rate: Welwitschia - 7
//Rate: Arnoldii - 3
//Rate: Woodii - 5
//Update: Woodii - 5
//Reset: Arnoldii
//Exhibition