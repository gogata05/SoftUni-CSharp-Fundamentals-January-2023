int days = int.Parse(Console.ReadLine());//5
double dailyPLunder = int.Parse(Console.ReadLine());//40
double expectedPlunder = int.Parse(Console.ReadLine());//380

double totalPlunder = 0;

for (int i = 1; i <= days; i++)
{
    totalPlunder += dailyPLunder;
    if (i % 3 == 0)
    {
        double extraPlunder = dailyPLunder * 0.50;
        totalPlunder += extraPlunder;
    }

    if (i % 5 == 0)
    {
        totalPlunder *= 0.70;
    }
}
double procent = (totalPlunder / expectedPlunder) * 100;
if (totalPlunder >= expectedPlunder)
{
    Console.WriteLine($"Ahoy! {totalPlunder:f2} plunder gained.");
}
else
{
    Console.WriteLine($"Collected only {procent:f2}% of the plunder.");
}