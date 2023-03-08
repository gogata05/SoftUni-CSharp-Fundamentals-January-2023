using System;

namespace Example_3_3._1// заместване на defaulta с други - @
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("test test");

            PrintHeader();

            Console.WriteLine("test test");

            PrintHeader("@");
        }
        static void PrintHeader(string defaultValue = "-")
        {
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine(defaultValue);
            }
            Console.WriteLine();
        }
    }
}
