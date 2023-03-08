Dictionary<string,List<string>>dictionary = new Dictionary<string,List<string>>();
string command = Console.ReadLine();
//companyName = "";
while (command!="End")
{
    string[] commandArray = command.Split(" -> ");
    string companyName = commandArray[0];
    string employeeId = commandArray[1];
    if (!dictionary.ContainsKey(companyName))
    {
        dictionary[companyName] = new List<string>() { }; //softuni 
    }
    if (!dictionary[companyName].Contains(employeeId))
    {
        dictionary[companyName].Add(employeeId);//AA12345
    }
    command = Console.ReadLine();
}

foreach (var item in dictionary)
{
    string companyName = item.Key;
    List<string> employeeId = item.Value;
    Console.WriteLine($"{companyName}");
    foreach (var item2 in employeeId)
    {
        Console.WriteLine($"-- {item2}");
    }
}