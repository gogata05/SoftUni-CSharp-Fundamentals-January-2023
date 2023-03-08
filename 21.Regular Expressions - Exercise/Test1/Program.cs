using System.Text.RegularExpressions;

string pattern = @"^>>(?<furnitureName>[A-Za-z]+)<<(?<price>\d+(\.\d+)?)!(?<quantity>\d+)(\.\d+)?$";
List<string> productList = new List<string>() { };//empty
string command = Console.ReadLine();//>>Sofa<<312.23!3 
double totalMoney = 0;
Regex regex = new Regex(pattern);
while (command!= "Purchase")
{
    Match match = regex.Match(command);
    if (match.Success)
    {
        string product = match.Groups["furnitureName"].Value;
        double price = double.Parse(match.Groups["price"].Value);
        int quantity = int.Parse(match.Groups["quantity"].Value.ToString());
        productList.Add(product);
        totalMoney += price * quantity;
    }

    command = Console.ReadLine();
}

Console.WriteLine("Bought furniture:");
foreach (var item in productList)
{
    Console.WriteLine(string.Join(Environment.NewLine, item));
}

Console.WriteLine($"Total money spend: {totalMoney:f2}");