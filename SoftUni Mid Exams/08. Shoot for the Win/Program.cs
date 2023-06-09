List<int> targets = Console.ReadLine().Split().Select(int.Parse).ToList();//24 50 36 70 
//0   1  2  3
//24 50 36 70 -> -1 26 12 46 -> -1 72 58 -1 -> -1 -1 130 -1 
int counter = 0;
while (true)//0
{
    string command = Console.ReadLine();//0 4 3 1 End
    if (command == "End")
    {
        break;
    }
    int index = int.Parse(command);//0
    if (index > targets.Count - 1 || index < 0 || targets[index] == -1)
    {
        continue;
    }
    int value = targets[index];//24//46
    targets[index] = -1;//shoot
    counter++;

    for (int i = 0; i < targets.Count; i++)//0 3
    {

        if (targets[i] == -1)
        {
            continue;//skip to next i
        }
        if (value < targets[i])//24<50
        {
            targets[i] -= value;//50-24=26
        }
        else
        {
            targets[i] += value;
        }
    }
}
Console.WriteLine($"Shot targets: {counter} -> {string.Join(" ", targets)}");
//Shot targets 3 -> -1 -1 130 -1 
//Shot targets: 4 -> -1 120 -1 66 -1 -1 