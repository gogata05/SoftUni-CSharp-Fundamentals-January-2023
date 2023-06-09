using System;

class Program
{
    static void Main(string[] args)
    {
        int peopleCount = int.Parse(Console.ReadLine());
        int[] wagons = Console.ReadLine().Split().Select(int.Parse).ToArray();

        for (int i = 0; i < wagons.Length; i++)
        {
            int availableSeats = 4 - wagons[i];
            if (peopleCount >= availableSeats)
            {
                peopleCount -= availableSeats;
                wagons[i] = 4;
            }
            else
            {
                wagons[i] += peopleCount;
                peopleCount = 0;
            }
            if (peopleCount == 0)
            {
                Console.WriteLine($"The lift has empty spots!\n{string.Join(' ', wagons)}");
                return;
            }
        }
        Console.WriteLine($"There isn't enough space! {peopleCount} people in a queue!\n{string.Join(' ', wagons)}");
    }
}