string[] textArray = Console.ReadLine().Split();
string result = "";
foreach (var item in textArray)
{
    for (int i = 0; i < item.Length; i++)
    {
        result += item;
    }
}
Console.WriteLine(result);