List<int> listP = Console.ReadLine().Split('>').Select(int.Parse).ToList();
List<int> listW = Console.ReadLine().Split('>').Select(int.Parse).ToList();
int maxHealth = int.Parse(Console.ReadLine());
string command = Console.ReadLine();
int count = 0;
while (command!= "Retire")
{
    string[] commandArray = command.Split();
    string act = commandArray[0];
    if (act=="Fire")
    {
        int index = int.Parse(commandArray[1]);
        int dmg = int.Parse(commandArray[2]);
        if (listW.Count>=index && index>=0 & dmg>=0)
        {
            listW[index] -= dmg;
            if (listW[index] <= 0)
            {
                Console.WriteLine($"You won! The enemy ship has sunken.");
                return;
            }
        }
    }
    else if (act=="Defend")//Defend 0 3 5
    {
        int startIndex = int.Parse(commandArray[1]);
        int endIndex = int.Parse(commandArray[2]);
        int dmg = int.Parse(commandArray[3]);
        if (startIndex>=0 && endIndex>=0 && dmg>=0 && startIndex<=listP.Count && endIndex<=listP.Count)
        {
            for (int i = startIndex; i <= endIndex; i++)
            {
                listP[i] -= dmg;
                if (listP[i] <= 0)
                {
                    Console.WriteLine($"You lost! The pirate ship has sunken.");
                    return;
                }
            }
        }
    }
    else if (act=="Repair")
    {
        int index = int.Parse(commandArray[1]);
        int health = int.Parse(commandArray[2]);
        if (index>=0 && health>=0 && index<=listP.Count)//0?
        {
            listP[index] += health;
            if (listP[index] >maxHealth)
            {
                listP[index]=maxHealth;
            }
        }
    }
    else if (act=="Status")
    {
        double minNumberCount = (double)maxHealth * 0.20;//
        for (int i = 0; i < listP.Count; i++)
        {
            if (listP[i]<minNumberCount)
            {
                count++;
            }
        }

        if (count>0)
        {
            Console.WriteLine($"{count} sections need repair.");
            count = 0 ;
        }
    }
    command = Console.ReadLine();
}

int pirateShipSum = listP.Sum();
int warshipSum = listW.Sum();
Console.WriteLine($"Pirate ship status: {pirateShipSum}");
Console.WriteLine($"Warship status: {warshipSum}");