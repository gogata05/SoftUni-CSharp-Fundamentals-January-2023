using System;
    internal class Program
    {
    static void Main()
    {
        PrintNumbers(1, 20);//2
        PrintNumbers(100, 120);//7
        PrintNumbers(1000, 1020);//9
    }

    static void PrintNumbers(int start, int end)//int step(да прескача)
    {
        for (int i = start; i <= end; i++)//i+=step
        {
            Console.WriteLine(i);
        }
        Console.WriteLine();
    }
    }
    

