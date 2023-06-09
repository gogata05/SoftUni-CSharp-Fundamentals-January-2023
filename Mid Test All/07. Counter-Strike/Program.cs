﻿using System;

class Program
{
    static void Main(string[] args)
    {
        int initialEnergy = int.Parse(Console.ReadLine());
        int wonBattles = 0;

        while (true)
        {
            string input = Console.ReadLine();
            if (input == "End of battle")
            {
                Console.WriteLine($"Won battles: {wonBattles}. Energy left: {initialEnergy}");
                break;
            }

            int distance = int.Parse(input);
            if (initialEnergy < distance)
            {
                Console.WriteLine($"Not enough energy! Game ends with {wonBattles} won battles and {initialEnergy} energy");
                break;
            }

            initialEnergy -= distance;
            wonBattles++;
            if (wonBattles % 3 == 0)
            {
                initialEnergy += wonBattles;
            }
        }
    }
}