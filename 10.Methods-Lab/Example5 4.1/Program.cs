using System;

namespace Example5_4._1
{
    internal class Program
    {
        static void Main()
        {
            double wigth = double.Parse(Console.ReadLine());
            double height = double.Parse(Console.ReadLine());

            double area = GetArea(wigth, height);
        }

        private static double GetArea(double wigth, double height)
        {
            double result = wigth * height;
            return result;
        }

    }
}
