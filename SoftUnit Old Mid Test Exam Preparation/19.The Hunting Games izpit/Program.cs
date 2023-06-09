int days = int.Parse(Console.ReadLine());
int playersCount = int.Parse(Console.ReadLine());
double groupEnergy = double.Parse(Console.ReadLine());
double waterPerPersonPerDay = double.Parse(Console.ReadLine());
double foodPerPersonPerDay = double.Parse(Console.ReadLine());
double totalWater = days * playersCount * waterPerPersonPerDay;
double totalFood = days * playersCount * foodPerPersonPerDay;
for (int day = 1; day <= days; day++)
{
    double energyLoss = double.Parse(Console.ReadLine());
    groupEnergy -= energyLoss;
    if (groupEnergy <= 0)
    {
        Console.WriteLine($"You will run out of energy. You will be left with {totalFood:F2} food and {totalWater:F2} water.");
        return;
    }
    if (day % 2 == 0)
    {
        groupEnergy += groupEnergy * 0.05;
        totalWater -= totalWater * 0.3;
    }
    if (day % 3 == 0)
    {
        double foodEaten = totalFood / playersCount;
        totalFood -= foodEaten;
        groupEnergy += groupEnergy * 0.1;
    }
}
Console.WriteLine($"You are ready for the quest. You will be left with - {groupEnergy:F2} energy!");