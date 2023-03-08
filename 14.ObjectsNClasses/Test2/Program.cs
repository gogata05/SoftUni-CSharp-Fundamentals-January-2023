using System.Numerics;

int n = int.Parse(Console.ReadLine());
BigInteger starter = 1;
for (int i = 1; i <= n; i++)
{
    starter *= i;
}

Console.WriteLine(starter);