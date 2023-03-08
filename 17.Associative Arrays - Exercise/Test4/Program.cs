Dictionary<string, string> dictionary = new Dictionary<string, string>();
int n = int.Parse(Console.ReadLine());
for (int i = 0; i < n; i++)//5
{
    string[] regNameNum = Console.ReadLine().Split(' ',StringSplitOptions.RemoveEmptyEntries);//register John CS1234JS 
    string regOrUnreg = regNameNum[0];
    string name = regNameNum[1];
    if (regOrUnreg=="register")
    {
        string number = regNameNum[2];
        if (!dictionary.ContainsKey(name))
        {
            dictionary.Add(name, number);
            Console.WriteLine($"{name} registered {number} successfully");
        }
        else
        {
            Console.WriteLine($"ERROR: already registered with plate number {number}");
        }
    }

    else if (regOrUnreg=="unregister")
    {
        if (dictionary.ContainsKey(name))
        {
            Console.WriteLine($"{name} unregistered successfully");
            dictionary.Remove(name);
           
        }
        else
        {
            Console.WriteLine($"ERROR: user {name} not found");
        }
    }
}

foreach (var item in dictionary)
{
    Console.WriteLine($"{item.Key} => {item.Value}");
}