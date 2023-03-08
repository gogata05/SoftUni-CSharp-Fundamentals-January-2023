using System.Diagnostics;

int.TryParse(Console.ReadLine(), out int numberOfPeople); // int.Parse(Console.ReadLine());
string type = Console.ReadLine();
string day = Console.ReadLine();

decimal pricePerPerson = 0;

if (type == "Students")
{
	if (day == "Friday")
	{
        pricePerPerson = 8.45m;
    }
	else if (day == "Saturday")
	{
        pricePerPerson = 9.80m;
    }
    else if (day == "Sunday")
    {
        pricePerPerson = 10.46m;
    }

    if (numberOfPeople >= 30)
    {
        pricePerPerson *= 0.85m;
    }
}
if (type == "Business")
{
    if (day == "Friday")
    {
        pricePerPerson = 10.90m;
    }
    else if (day == "Saturday")
    {
        pricePerPerson = 15.60m;
    }
    else if (day == "Sunday")
    {
        pricePerPerson = 16m;
    }

    if (numberOfPeople >= 100)
    {
        numberOfPeople-=10;
    }
}
if (type == "Regular")
{
    if (day == "Friday")
    {
        pricePerPerson = 15m;
    }
    else if (day == "Saturday")
    {
        pricePerPerson = 20.00m;
    }
    else if (day == "Sunday")
    {
        pricePerPerson = 22.50m;
    }

    if (numberOfPeople >= 10 && numberOfPeople <= 20)
    {
        pricePerPerson *= 0.95m;
    }
}

decimal totalPrice = pricePerPerson * numberOfPeople;
Console.WriteLine($"Total price: {totalPrice:f2}");