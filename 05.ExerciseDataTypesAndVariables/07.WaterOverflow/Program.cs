using System.Diagnostics.CodeAnalysis;

int iterations = int.Parse(Console.ReadLine());
byte capacty = 255;
byte sum = 0;

for (int i = 0; i < iterations; i++)
{
    short liters = short.Parse(Console.ReadLine());
	if (liters <=capacty - sum)
	{
		sum += (byte)liters;
	}
	else
	{
		Console.WriteLine($"Insufficient capacity!");
	}
}
Console.WriteLine(sum);