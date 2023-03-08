SortedDictionary<double, int> numbers = new SortedDictionary<double, int>();
double[] inputNums = Console.ReadLine().Split().Select(double.Parse).ToArray();//8 2 2 8 2
foreach (var VARIABLE in inputNums)
{
    if (!numbers.ContainsKey(VARIABLE))
    {
        numbers.Add(VARIABLE,0);
    }
    numbers[VARIABLE] += 1;
}

foreach (var VARIABLE in numbers)
{
    Console.WriteLine($"{VARIABLE.Key} -> {VARIABLE.Value}");
}
//foreach (var (key,value)VARIABLE) in numbers)
//{
//    Console.WriteLine($"{key} -> {value}");
//}


