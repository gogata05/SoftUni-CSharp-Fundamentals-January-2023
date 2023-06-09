using System;

double moneyPerSearch = double.Parse(Console.ReadLine());
int numberOfUsers = int.Parse(Console.ReadLine());
double totalMoney = 0;

for (int i = 1; i <= numberOfUsers; i++)
{
    int searches = int.Parse(Console.ReadLine());
    if (searches == 1)
    {
        continue;
    }
    double currentMoney = moneyPerSearch * searches;
    if (searches > 5)
    {
        currentMoney *= 2;
    }
    if (i % 3 == 0)
    {
        currentMoney *= 3;
    }
    totalMoney += currentMoney;
}
Console.WriteLine($"Total money earned: {totalMoney:F2}");
