string[] arrayNum = Console.ReadLine().Split('|', StringSplitOptions.RemoveEmptyEntries);
//rat 10|bat 20|potion 10|rat 10|chest 100|boss 70|chest 1000 
int healthMax = 100;
int healthCurrent = 100;
int bitcoin = 0;
int room = 0;
for (int i = 0; i < arrayNum.Length; i++)
{
    string command = arrayNum[i]; //potion 10
    string[] commandArray = command.Split();
    string act = commandArray[0];
    if (act== "potion")//potion 30
    {
        room++;
        int healthAdded = int.Parse(commandArray[1]);//30
        int healthRemember = healthCurrent;//90
        healthCurrent += healthAdded;//90+30=120
        if (healthCurrent>healthMax)
        {
            healthCurrent=healthMax;
        }
        int healedAmount = healthCurrent - healthRemember;
        Console.WriteLine($"You healed for {healedAmount} hp.");
        Console.WriteLine($"Current health: {healthCurrent} hp.");
    }
    else if (act=="chest")//chest 100
    {
        room++;
        int bitcoinFound = int.Parse(commandArray[1]);
        Console.WriteLine($"You found {bitcoinFound} bitcoins.");
        bitcoin += bitcoinFound;
    }
    else
    {
        room++;
        string monster = commandArray[0]; 
        int monsterDMG = int.Parse(commandArray[1]);
        healthCurrent-=monsterDMG;
        if (healthCurrent>0)
        {
            Console.WriteLine($"You slayed {monster}.");
        }
        else
        {
            Console.WriteLine($"You died! Killed by {monster}.");
            Console.WriteLine($"Best room: {room}");
            return;
        }
    }
}
Console.WriteLine($"You've made it!");
Console.WriteLine($"Bitcoins: {bitcoin}");
Console.WriteLine($"Health: {healthCurrent}");

