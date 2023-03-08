using System;

namespace Example7_3._1
{
    static void Main()
    {
        double number = double.Parse(Console.ReadLine());
        double power = double.Parse(Console.ReadLine());

        double result = MathPower(number, power);
        Console.WriteLine(result);
    }

    private static double MathPower(double n, double power)
    {
        double result = 1;
        for (int i = 0; i < power; i++)
        {
            result *= n;
        }
        return result;
    }

}
