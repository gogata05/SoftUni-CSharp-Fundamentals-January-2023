int num = int.Parse(Console.ReadLine());

while (num % 2 != 0)
{
    Console.WriteLine("Please write an even number.");
    num = int.Parse(Console.ReadLine());
}

	if (num < 0)
	{
		num = Math.Abs(num);
        Console.WriteLine($"The number is: {num}");
        return;
    }
    else
    {
        Console.WriteLine($"The number is: {num}");
        return;
    }