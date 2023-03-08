using System.Xml.Linq;
Dictionary<string,List<double>> dictionary = new Dictionary<string,List<double>>(); //5 John//5.5//John//4.5//Alice//6//Alice//3//George//5
int n = int.Parse(Console.ReadLine());
for (int i = 0; i < n; i++)
{
    string name = Console.ReadLine();
    double grade = double.Parse(Console.ReadLine());
    if (!dictionary.ContainsKey(name))
    {
        dictionary[name] = new List<double>() { };
    }

    dictionary[name].Add(grade);
}
foreach (var item in dictionary)
{
    string name = item.Key;
    double averageGrade = item.Value.Average();
    if (averageGrade>=4.50)
    {
        Console.WriteLine($"{name} -> {averageGrade:f2}");
    }
    
}
//.Select(x => x >= 4.50)