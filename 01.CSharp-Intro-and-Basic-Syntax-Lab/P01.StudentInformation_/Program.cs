//string name = "stosho";
//int age = 27;

//console.writeline($"my name is: {name}, age: {age}");

//int num = int.Parse(Console.ReadLine());
//int.TryParse(Console.ReadLine(), out int number);

string studentName = Console.ReadLine();    
int age = int.Parse(Console.ReadLine());
double averageGrade = double.Parse(Console.ReadLine());

Console.Write($"Name: {studentName}, Age: {age}, Grade: {averageGrade:f2}");