int[] houseArray = Console.ReadLine().Split('@').Select(int.Parse).ToArray();
string command = Console.ReadLine();
int currentIndex = 0;
int count = 0;
//10@10@10@2 
//Jump 1 
//Jump 2 
//Love! 
while (command!="Love!")
{
    string[] commandArray = command.Split();
    string jump = commandArray[0];
    int lenth = int.Parse(commandArray[1]);
    currentIndex += lenth;
    if (currentIndex>houseArray.Length-1)//-1?
    {
        currentIndex = 0;
    }
    if (houseArray[currentIndex] == 0)
    {
        Console.WriteLine($"Place {currentIndex} already had Valentine's day.");
    }
    else
    {
        houseArray[currentIndex] -= 2;
        if (houseArray[currentIndex] == 0)
        {
            Console.WriteLine($"Place {currentIndex} has Valentine's day.");
        } 
    }
    command = Console.ReadLine();
}

Console.WriteLine($"Cupid's last position was {currentIndex}.");
int sum = houseArray.Sum();
if (sum==0)
{
    Console.WriteLine($"Mission was successful.");
}
else
{
    for (int i = 0; i < houseArray.Length; i++)
    {
        int check = houseArray[i];
        if (check != 0)
        {
            count++;
        }
    }
    Console.WriteLine($"Cupid has failed {count} places.");
}