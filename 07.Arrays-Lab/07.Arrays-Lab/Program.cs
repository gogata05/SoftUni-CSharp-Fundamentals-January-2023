//string[] arrayOfNames = { "Stoyan", "Petkan", "jivkov", "Dragan" };

//Console.WriteLine(arrayOfNames[arrayOfNames.Length - 1]);
//Console.WriteLine(arrayOfNames.Length);

//string[] numbers = new string[10];
//numbers[0] = "A";
//numbers[1] = "B";
//numbers[2] = "C";
//numbers[3] = "D";

//Create,Full,CW,change elements
//int[] numbers = new int[10];

//for (int i = 0; i < numbers.Length; i++) //10
//{
//    numbers[i] = i + 1;
//}
//numbers[0] = 23; u can change it
//Console.WriteLine(numbers[numbers.Length - 1]);

//int[] numbers2 = { 1, 2, 3 };       // =             int[] numbers3 = new int[3] { 1, 2, 3 };                // equal// same

string[] daysOfWeek = { "Monday", "Tuesday", "Wednesday", "Thursday", "Friday", "Saturday", "Sunday" };

int input = int.Parse(Console.ReadLine());

if (input >=1 && input <= 7)
{
    Console.WriteLine(daysOfWeek[input - 1]);
}
else
{
    Console.WriteLine("Invalid day!");
}