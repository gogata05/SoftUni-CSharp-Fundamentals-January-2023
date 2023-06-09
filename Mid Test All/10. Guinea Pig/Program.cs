double food = double.Parse(Console.ReadLine());//for 30
double slama = double.Parse(Console.ReadLine());
double pokriwka = double.Parse(Console.ReadLine());
double pigKG = double.Parse(Console.ReadLine());

food *= 1000;
slama *= 1000;
double foodFor1feeding = 0;
double slamaFor1feeding = 0;
double pokriwkaFor1Feeding = 0;
double slamaGiven = 0;
double pokriwkaGiven = 0;

for (int day = 1; day <= 30; day++)
{
    food -= 300;
    if (day % 2 == 0)
    {
        slamaGiven = food * 0.05;
        slama -= slamaGiven;
    }

    if (day % 3 == 0)
    {
        pokriwkaGiven = pigKG / 3;
        pokriwka -= pokriwkaGiven;
    }

    if (food < 0 || slama < 0 || pokriwka < 0)
    {
        Console.WriteLine($"Merry must go to the pet store!");
        return;
    }
}
food /= 1000;
slama /= 1000;


Console.WriteLine($"Everything is fine! Puppy is happy! Food: {food:f2}, Hay: {slama:f2}, Cover: {pokriwka:f2}.");