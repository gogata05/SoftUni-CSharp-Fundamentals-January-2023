using System.Text.RegularExpressions;
double totalIncome = 0;
//Using interpolation can create dynamic patterns
//string randomChPattern = @"[^\%\|\$\.]*?";
string pattern = @"^\%(?<customer>[A-Z][a-z]+)\%[^\%\|\$\.]*?\<(?<product>\w+)\>[^\%\|\$\.]*?\|(?<count>\d+)\|[^\%\|\$\.]*?(?<price>\d+(\.\d+)?)\$[^\%\|\$\.]*?$";
Regex regex = new Regex(pattern);
string inputLine = Console.ReadLine();
while (inputLine != "end of shift")
{
    Match match = regex.Match(inputLine);
    if (match.Success)
    {
        string customer = match.Groups["customer"].Value;
        string product = match.Groups["product"].Value;
        int count = int.Parse(match.Groups["count"].Value);
        double price = double.Parse(match.Groups["price"].Value);

        double totalPrice = count * price;
        totalIncome += totalPrice;

        Console.WriteLine($"{customer}: {product} - {totalPrice:f2}");
    }
    inputLine = Console.ReadLine();
}
Console.WriteLine($"Total income: {totalIncome:f2}");