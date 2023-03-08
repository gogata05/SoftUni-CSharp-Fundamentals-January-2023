using System;

namespace Example3_3._1_ReturnToEndMethod
{
    internal class Program
    {
        static void Main()
        {
            
        }
        static int Test1()
        {
            Console.WriteLine("12");

            return 0;

            Console.WriteLine("13");
        }

        static void Test2()
        {
            Console.WriteLine("12");

            return;

            Console.WriteLine("13");
        }
    }
}
