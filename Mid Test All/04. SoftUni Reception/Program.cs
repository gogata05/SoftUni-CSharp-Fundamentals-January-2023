int first = int.Parse(Console.ReadLine());
int second = int.Parse(Console.ReadLine());
int thurd = int.Parse(Console.ReadLine());
int studentsCount = int.Parse(Console.ReadLine());//45
int countTotalHours = 0;
int countHours = 0;
int studentsPerHour = first+ second+ thurd;//6
if (studentsCount == 0)
{
    Console.WriteLine($"Time needed: {countTotalHours}h.");
    return;
}

while (true)
{
    countHours++;
    if (countHours == 4)
    {
        countHours = 0;
        countTotalHours++;
        continue;
    }
    if (studentsCount>= studentsPerHour)//if 45>6
    {
        studentsCount -= studentsPerHour;//45-6
        countTotalHours++;
        if (studentsCount == 0)
        {
            Console.WriteLine($"Time needed: {countTotalHours}h.");
            return;
        }
    }
    else 
    {
        countTotalHours++;
        Console.WriteLine($"Time needed: {countTotalHours}h.");
        return;
    }

    
}