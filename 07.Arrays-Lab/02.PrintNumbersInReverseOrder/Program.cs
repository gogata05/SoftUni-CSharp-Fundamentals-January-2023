//string input = Console.ReadLine();//"12 20 30 40"
//string[] numbersAsString = input.Split();//razdelqme masiwa s ne6toto w skobite
//int[] integers = new int[numbersAsString.Length];

//for (int i = 0; i < numbersAsString.Length; i++)
//{
//    integers[i] = int.Parse(numbersAsString[i]) + 1;
//    Console.WriteLine(integers[i]);
//}

//string input = Console.ReadLine(); ;//"12 20 30 40" // string input = Console.ReadLine().Split(",").Select(int.Parse).ToArray();
//string[] inputArray = input.Split(",");//StringSplitOptions.RemoveEmptyEntries
//int[] numbers= inputArray.Select(int.Parse).ToArray();

//for (int i = 0; i < numbers.Length; i++)
//{
//    Console.WriteLine(numbers[i]);
//}




//int[] a = Console.ReadLine()                     //otlqwo i otdqsno ednakuw tip danni w array
//.Split()
//.Select(int.Parse)
//.ToArray();

//double[] b = Console.ReadLine()
//.Split()
//.Select(double.Parse)
//.ToArray();

//string[] c = Console.ReadLine()
//.Split();

int n = int.Parse(Console.ReadLine());
int[] numbers= new int[n];

for (int i = 0; i < numbers.Length; i++)
{
    int currentNum = int.Parse(Console.ReadLine());
    numbers[i] = currentNum;
}
//int[] reverseNum = numbers.Reverse().ToArray(); // Reverse за обръщане на array //4 5 6 -> 6 5 4 

for (int i = numbers.Length - 1; i >= 0 ; i--)                           //for (int i = 0; i < numbers.Length / 2; i++)
{
    Console.Write(numbers[i] + " ");                                                                   
}
//{
//    int firstNumber = numbers[i];
//    int lastNumber = numbers[numbers.Length - 1 - i];

//    numbers[i] = lastNumber;
//    numbers[numbers.Length - 1 - i] = firstNumber;  
//}





//string[] names = { "40", "30", "20", "10" };

////4 different way to solve the 

////1.
//for (int i = 0; i < names.Length / 2; i++) 
//{
//    string firstElements = names[i];
//    string lastElements = names[names.Length - 1 - i];

//    names[i] = lastElements;
//    names[names.Length - 1 - i] = firstElements;
//}

////2.
//names = names.Reverse().ToArray();

////3.
//names = names.OrderBy(x => x).ToArray();

////4.
//Array.Sort(names);

//Console.WriteLine(string.Join("", names));

