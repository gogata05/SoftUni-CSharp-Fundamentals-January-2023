List<int> listNum = Console.ReadLine().Split().Select(int.Parse).ToList();
string command = Console.ReadLine();
while (command!="End")
{
    string[] commandArray = command.Split();
    string act = commandArray[0];

        if (act == "Shoot")
        {
            int index = int.Parse(commandArray[1]);
            int power = int.Parse(commandArray[2]);
            if (listNum.Count >= index && power>=0 && index>=0)
            {
                if (listNum[index] > power)//110>10
                {
                    listNum[index] -= power;
                }
                else
                {
                    listNum.RemoveAt(index);
                }
            }
        }
        else if (act == "Add")
        {
            int index = int.Parse(commandArray[1]);
            int value = int.Parse(commandArray[2]);
            if (listNum.Count >= index && value>0 && index>=0)
            {
                listNum.Insert(index, value);
            }
            else
            {
                Console.WriteLine($"Invalid placement!");
            }
        }
        else if (act == "Strike")//Strike 2 1 
        {
            int index = int.Parse(commandArray[1]);
            int radius = int.Parse(commandArray[2]);

            if (listNum.Count >= index + radius && index - radius >= 0 && index>0 && radius>0)
            {
                for (int i = 0; i < radius; i++)
                {
                    listNum.RemoveAt(index + 1);
                }

                for (int i = 0; i < radius; i++)
                {
                    listNum.RemoveAt(index - 1);
                    index--;
                }
                listNum.RemoveAt(index);
            }
            else
            {
                Console.WriteLine($"Strike missed!");
            }
        }
        command = Console.ReadLine();
}
Console.Write(string.Join("|", listNum));