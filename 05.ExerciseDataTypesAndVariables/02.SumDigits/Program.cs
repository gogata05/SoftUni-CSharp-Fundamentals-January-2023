int num = int.Parse(Console.ReadLine());

int sum = 0;
while (num > 0)
{
    int digir = num % 10;
    num /= 10;
    sum += digir;
}

Console.WriteLine(sum);
