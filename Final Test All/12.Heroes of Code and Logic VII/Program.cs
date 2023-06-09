Dictionary<string,List<int>>dictionary  = new Dictionary<string,List<int>>();
int n = int.Parse(Console.ReadLine());//2
//Solmyr 85 120
//Kyrre 99 50

//Heal - Solmyr - 10
//Recharge - Solmyr - 50
//TakeDamage - Kyrre - 66 - Orc
//CastSpell - Kyrre - 15 - ViewEarth      //End
for (int i = 0; i < n; i++)
{
   string input = Console.ReadLine();
   string[] inputArray = input.Split();
   string heroName = inputArray[0];
   int hP = int.Parse(inputArray[1]);
   int mP = int.Parse(inputArray[2]);
   if (!dictionary.ContainsKey(heroName))
   {
        dictionary[heroName] = new List<int>() { };
        dictionary[heroName].Insert(0,hP);
        dictionary[heroName].Insert(1,mP);
   }
}
//HP Max 100
//MP Max 200
string command = Console.ReadLine();
while (command!="End")////Heal - Solmyr - 10
{
    string[] commandArray = command.Split(" - ",StringSplitOptions.RemoveEmptyEntries);
    string act = commandArray[0];
    if (act=="Heal")////Heal - Solmyr - 10
    {
        string heroName = commandArray[1];
        int HPRecover = int.Parse(commandArray[2]);
        int HP = dictionary[heroName][0];
        int currentHP = HP;
        dictionary[heroName][0] += HPRecover;
        if (dictionary[heroName][0]>100)
        {
            dictionary[heroName][0]=100;
        }
        int amountRecovered = dictionary[heroName][0] - currentHP;
        Console.WriteLine($"{heroName} healed for {amountRecovered} HP!");

    }
    else if (act=="Recharge")//Recharge - Solmyr - 50
    {
        string heroName = commandArray[1];
        int MPrecover = int.Parse(commandArray[2]);
        int MP = dictionary[heroName][1];
        int currentMP = MP;
        dictionary[heroName][1] += MPrecover;
        if (dictionary[heroName][1]>200)
        {
            dictionary[heroName][1]=200;
        }
        int amountRecovered = dictionary[heroName][1] - currentMP;
        Console.WriteLine($"{heroName} recharged for {amountRecovered} MP!");
    }
    else if (act== "TakeDamage")//TakeDamage - Kyrre - 66 - Orc
    {
        string heroName = commandArray[1];
        int damageHP = int.Parse(commandArray[2]);
        string attacker = commandArray[3];
        int HP = dictionary[heroName][0];//
        dictionary[heroName][0] -= damageHP;
        if (dictionary[heroName][0]>0)
        {
            Console.WriteLine($"{heroName} was hit for {damageHP} HP by {attacker} and now has {dictionary[heroName][0]} HP left!");
        }
        else //if (dictionary[heroName][0]<=0)
        {
            Console.WriteLine($"{heroName} has been killed by {attacker}!");
            dictionary.Remove(heroName);
        }
    }
    else if (act== "CastSpell")////CastSpell - Kyrre - 15 - ViewEarth
    {
        string heroName = commandArray[1];
        int MPNeeded = int.Parse(commandArray[2]);
        string spellName = commandArray[3];
        int MP = dictionary[heroName][1];
        if (dictionary[heroName][1]>=MPNeeded)
        {
            dictionary[heroName][1] -= MPNeeded;
            Console.WriteLine($"{heroName} has successfully cast {spellName} and now has {dictionary[heroName][1]} MP!");
        }
        else
        {
            Console.WriteLine($"{heroName} does not have enough MP to cast {spellName}!");
        }

    }
    command = Console.ReadLine();
}

foreach (var item in dictionary)
{
    string heroName = item.Key;
    int currentHP = item.Value[0];
    int currentMP = item.Value[1];
    Console.WriteLine($"{heroName}");
    Console.WriteLine($"  HP: {currentHP}");
    Console.WriteLine($"  MP: {currentMP}");
}
