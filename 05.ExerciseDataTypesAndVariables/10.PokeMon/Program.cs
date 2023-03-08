int pokePower = int.Parse(Console.ReadLine());
int distance = int.Parse(Console.ReadLine());
int exhaustionFactor = int.Parse(Console.ReadLine());
int pokedTimes = 0;
int originalValue = 0;
originalValue = pokePower;
int originalValue50Procent = originalValue / 2;

while (pokePower > distance)
{
    pokePower = pokePower - distance; // pokePower -= distance;
    pokedTimes++;
    if (pokePower == originalValue50Procent)
    {
        while (pokePower == 0 || exhaustionFactor == 0)
        {
          //check not possible
            break;
        }

        if (pokePower != 0 || exhaustionFactor != 0)
        {
            pokePower = pokePower / exhaustionFactor;  //pokePower /= exhaustionFactor;
        }
        
    }
}
Console.WriteLine(pokePower);
Console.WriteLine(pokedTimes);