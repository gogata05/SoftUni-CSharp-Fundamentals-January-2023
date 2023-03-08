Dictionary<string, string> dictionary = new Dictionary<string, string>();//empty 0// usually John & Num
int n = int.Parse(Console.ReadLine());//5
//register John CS1234JS
//register George JAVA123S
//register Andy AB4142CD
//register Jesica VR1223EE
//unregister Andy
for (int i = 0; i < n; i++)//5
{
    //Apart from Split() almost all other LINQ Functions require ToArray() after them
    //After Where(), Select(), OrderBy()... we write ToArray()
    string[] array1RegNameNum = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries);//command reg name number
    string regOrUnreg = array1RegNameNum[0];
    string username = array1RegNameNum[1]; 
    if (regOrUnreg == "register")
    {
        string number = array1RegNameNum[2];
        if (!dictionary.ContainsKey(username))//John
        {
            dictionary.Add(username,number);//John/CS1234JS
            Console.WriteLine($"{username} registered {number} successfully");
        }
        else
        {
            //string registeredPlateNumber = register[username];
            Console.WriteLine($"ERROR: already registered with plate number {dictionary[username]}");
        }
    }
    else if (regOrUnreg == "unregister")
    {
        if (!dictionary.ContainsKey(username))
        {
            Console.WriteLine($"ERROR: user {username} not found");
        }
        else
        {
            dictionary.Remove(username);
            Console.WriteLine($"{username} unregistered successfully");
        }
    }
}
foreach (var item in dictionary)
{
    Console.WriteLine($"{item.Key} => {item.Value}");
}