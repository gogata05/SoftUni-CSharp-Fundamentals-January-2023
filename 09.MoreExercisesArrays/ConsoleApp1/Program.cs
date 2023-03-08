using System;
using System.Linq;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = { 1, 2, 3, 4, 5 };

            // Sum all of the elements in the array

            int sum = Array.Sum(numbers);

            Console.WriteLine("The sum of the array is {0}", sum);
            
        }
    }
}

