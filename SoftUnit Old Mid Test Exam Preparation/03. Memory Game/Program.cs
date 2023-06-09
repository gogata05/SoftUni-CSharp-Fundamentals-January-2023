using System.Xml.Linq;

List<string> elementsList = new List<string>(Console.ReadLine().Split());//1 1 2 2 3 3 4 4 5 5
//1 0
string command = Console.ReadLine();//1 0
int moves = 0;
while (command != "end")//1 0
{
    List<int> indexesList = command.Split(' ', StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToList();
    int index0 = indexesList[0];//1
    int index1 = indexesList[1];//0
    moves++;
    if (index0 == index1 || index0 < 0 || index1 < 0 || index0 >= elementsList.Count || index1 >= elementsList.Count)
    {
        int middleIndex = elementsList.Count / 2;
        elementsList.Insert(middleIndex, $"-{moves}a");
        elementsList.Insert(middleIndex, $"-{moves}a");
        Console.WriteLine("Invalid input! Adding additional elements to the board");
    }
    else if (elementsList[index0] == elementsList[index1])//1 0//?
    {
        Console.WriteLine($"Congrats! You have found matching elements - {elementsList[index0]}!");
        if (index0 > index1)
        {
            elementsList.RemoveAt(index0);
            elementsList.RemoveAt(index1);
        }
        else if (index0 < index1)
        {
            elementsList.RemoveAt(index1);
            elementsList.RemoveAt(index0);
        }
    }
    else if (elementsList[index0] != elementsList[index1])
    {
        Console.WriteLine("Try again!");
    }
    if (elementsList.Count == 0)
    {
        Console.WriteLine($"You have won in {moves} turns!");
        return;
    }
    command = Console.ReadLine();
}

if (elementsList.Count > 0)
{
    Console.WriteLine($"Sorry you lose :(");
    Console.WriteLine(string.Join(" ", elementsList));
}