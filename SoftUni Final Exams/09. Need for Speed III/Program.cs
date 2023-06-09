Dictionary<string,List<int>>dictionary = new Dictionary<string,List<int>>();
int n = int.Parse(Console.ReadLine());//3
//Audi A6|38000|62
//Mercedes CLS|11000|35
//Volkswagen Passat CC|45678|5

//Drive : Audi A6 : 543 : 47
//Drive: Mercedes CLS : 94 : 11
//Drive: Volkswagen Passat CC : 69 : 8
//Refuel: Audi A6 : 50
//Revert: Mercedes CLS : 500
//Revert: Audi A6 : 30000    //Stop
for (int i = 0; i < n; i++)
{
    string input = Console.ReadLine();
    string[] inputArray = input.Split("|");
    string car = inputArray[0];///Audi A6
    int mileage = int.Parse(inputArray[1]);//38000
    int fuel = int.Parse(inputArray[2]);//35
    if (!dictionary.ContainsKey(car))
    {
        dictionary[car] = new List<int>() { }; //Audi A6
        dictionary[car].Insert(0,mileage);//38000
        dictionary[car].Insert(1,fuel);//35
    }
    //else
    //{
    //    dictionary[car][0] += mileage;
    //    dictionary[car][1] += fuel;
    //}
    //if the same
    //1
}
string command = Console.ReadLine();
while (command!="Stop")
{
    string[] commandArray = command.Split(" : ");
    string act = commandArray[0];
    if (act == "Drive")//Drive : Audi A6 : 543 : 47
    {
        string car = commandArray[1];
        int distanceAdded = int.Parse(commandArray[2]);
        int fuelCost = int.Parse(commandArray[3]);
        int mileage = dictionary[car][0];
        int fuel = dictionary[car][1];
        if (dictionary[car][1] >= fuelCost)
        {
            dictionary[car][0]+= distanceAdded;
            dictionary[car][1]-= fuelCost;
            Console.WriteLine($"{car} driven for {distanceAdded} kilometers. {fuelCost} liters of fuel consumed.");
        }
        else
        {
            Console.WriteLine($"Not enough fuel to make that ride");
        }

        if (dictionary[car][0] >= 100000)
        {
            Console.WriteLine($"Time to sell the {car}!");
            dictionary.Remove(car);
        }
    }
    else if (act=="Refuel")////Refuel: Audi A6 : 50
    {
        string car = commandArray[1];
        int fuelIncreased = int.Parse(commandArray[2]);
        dictionary[car][1]+= fuelIncreased;
        if (dictionary[car][1] > 75)
        {
            dictionary[car][1] = 75;
        }
        Console.WriteLine($"{car} refueled with {fuelIncreased} liters");
    }
    else if (act=="Revert")////Revert: Mercedes CLS : 500
    {
        string car = commandArray[1];
        int decreaseMileage = int.Parse(commandArray[2]);
        dictionary[car][0] -= decreaseMileage;
        //DO NOT print anything. 
        if (dictionary[car][0]<10000)
        {
            dictionary[car][0] = 10000;
        }
        else
        {
            Console.WriteLine($"{car} mileage decreased by {decreaseMileage} kilometers");
        }
    }
    command = Console.ReadLine();
}

if (dictionary.Count!=0)
{
    foreach (var item in dictionary)
    {
        string car = item.Key;
        int mileage = item.Value[0];
        int fuel = item.Value[1];

        Console.WriteLine($"{car} -> Mileage: {mileage} kms, Fuel in the tank: {fuel} lt.");
    }
}


