using System;
internal class Program
{
    static void Main()
    {
        PrintNumbers();

        PrintNumbers(10, 20);

        PrintNumbers(start: 50);

        PrintNumbers(end: 40);
    }

    static void PrintNumbers(int start = 1, int end = 100)
    {
        for (int i = start; i <= end; i++)//i+=step
        {
            Console.WriteLine(i+" ");
        }
        Console.WriteLine();
    }
}

