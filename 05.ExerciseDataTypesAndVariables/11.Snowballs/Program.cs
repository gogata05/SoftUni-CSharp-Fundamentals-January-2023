//int baseNumber = int.Parse(Console.ReadLine());
//int power = int.Parse(Console.ReadLine());

//int result = 1;
//for (int i = 0; i < power; i++)
//{
//    result *= baseNumber;

//}
//Console.WriteLine($"{baseNumber} to the power of {power} is {result}");

//using System.Numerics;

//BigInteger one = BigInteger.One;
//BigInteger minusOne = BigInteger.MinusOne;
//BigInteger result = BigInteger.Add(one, minusOne);

//Console.WriteLine(result);

using System.Numerics;

int numberOfballs = int.Parse(Console.ReadLine());

BigInteger maxValue = 0;
int bestSnow = 0;
int bestTime = 0;
int bestQuality = 0;

for (int i = 0; i < numberOfballs; i++)
{
    int snow = int.Parse(Console.ReadLine());
    int time = int.Parse(Console.ReadLine());
    int quality = int.Parse(Console.ReadLine());

    BigInteger value = BigInteger.Pow(snow/time, quality);

    if (value>maxValue)
    {
        maxValue = value;
        bestSnow = snow;
        bestQuality = quality;
        bestTime= time;
    }
}
Console.WriteLine($"{bestSnow} : {bestTime} = {maxValue} ({bestQuality})");
