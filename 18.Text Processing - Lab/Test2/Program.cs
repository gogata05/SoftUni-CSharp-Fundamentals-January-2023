string[] textArray = Console.ReadLine().Split();//hi abc add 
string end = "";
foreach (var item in textArray)//hi abc add 
{
    for (int i = 0; i < item.Length; i++)
    {
        end += item;
    }
}
Console.WriteLine(end);