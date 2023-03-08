int n = int.Parse(Console.ReadLine());
double totalPrice = 0;
for (int i = 1; i <= n; i++)
{
    double pricePerCapsule = double.Parse(Console.ReadLine());
    int daysInMonth = int.Parse(Console.ReadLine());
    int capsulesCount = int.Parse(Console.ReadLine());
    double price = pricePerCapsule * daysInMonth * capsulesCount;
    Console.WriteLine($"The price for the coffee is: ${price:f2}");
    totalPrice = totalPrice + price;
}

Console.WriteLine($"Total: ${totalPrice:f2}");