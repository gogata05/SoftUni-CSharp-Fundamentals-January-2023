using System.Text.RegularExpressions;

string pattern = @"^\%(?<customer>[A-Z][a-z]+)\%[^\%\|\$\.]*?\<(?<product>\w+)\>[^\%\|\$\.]*?\|(?<count>\d+)\|[^\%\|\$\.]*?(?<price>\d+(\.\d+)?)\$[^\%\|\$\.]*?$";
string command = Console.ReadLine();
double totalIncome = 0;
Regex regex = new Regex(pattern);
while (command!="end of shift")
{
    Match match = regex.Match(command);
    if (match.Success)
    {
        string customer = match.Groups["customer"].Value;
        string product = match.Groups["product"].Value;
        int count = int.Parse(match.Groups["count"].Value);
        double price = double.Parse(match.Groups["price"].Value);
        double totalPrice = price * count;
        totalIncome += totalPrice;
        Console.WriteLine($"{customer}: {product} - {totalPrice:F2}");
    }


    command = Console.ReadLine();
}

Console.WriteLine($"Total income: {totalIncome:f2}");