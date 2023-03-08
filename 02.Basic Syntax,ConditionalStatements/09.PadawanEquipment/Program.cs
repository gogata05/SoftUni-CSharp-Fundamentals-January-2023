using System.Security.Cryptography;

double moneyJohnHas = double.Parse(Console.ReadLine());
int studentsNum = int.Parse(Console.ReadLine());
double lightsabers1Price = double.Parse(Console.ReadLine());
double robes1price = double.Parse(Console.ReadLine());
double belts1Price = double.Parse(Console.ReadLine());
double numLightsabers = 0;
double freeBelts = 0;
double numBelt = studentsNum;
double numRobes = studentsNum;
double totalPriceLightsabers = 0;
double totalPriceRobes = 0;
double totalPriceBelts = 0;
double totalPrice = 0;

numLightsabers = studentsNum;
numLightsabers = numLightsabers * 1.10;
numLightsabers = Math.Ceiling(numLightsabers);

if (numBelt >= 6)
{
    freeBelts = numBelt / 6;
    freeBelts= Math.Floor(freeBelts);
    numBelt = numBelt - freeBelts;
}

totalPriceLightsabers = lightsabers1Price * numLightsabers;
totalPriceRobes = robes1price * numRobes;
totalPriceBelts = belts1Price * numBelt;
totalPrice = totalPriceLightsabers + totalPriceRobes + totalPriceBelts;

if (totalPrice <= moneyJohnHas)
{
    Console.WriteLine($"The money is enough - it would cost {totalPrice:f2}lv.");
}
else
{
    double neededMoney = totalPrice - moneyJohnHas;
    Console.WriteLine($"John will need {neededMoney:f2}lv more.");
}


