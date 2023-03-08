Dictionary<string, List<double>> dictionary1 = new Dictionary<string, List<double>>();
string command = Console.ReadLine();
while (command != "buy")
{
    string[] commandArray = command.Split();
    string productName = commandArray[0];
    double price = double.Parse(commandArray[1]);
    double quantity = double.Parse(commandArray[2]);

    if (!dictionary1.ContainsKey(productName))
    {
        dictionary1[productName] = new List<double>() { price, quantity, price * quantity };
    }
    else
    {
        dictionary1[productName][2] += price * quantity;
        if (dictionary1[productName][0] != price)
        {
            dictionary1[productName][0] = price;
        }
        dictionary1[productName][1] += quantity;
    }

    command = Console.ReadLine();
}

foreach (var item in dictionary1)
{
    string productName = item.Key;
    double totalPrice = item.Value[2];
    Console.WriteLine($"{productName} -> {totalPrice.ToString("F2")}");
}