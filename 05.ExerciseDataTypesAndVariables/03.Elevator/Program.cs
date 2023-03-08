double people = double.Parse(Console.ReadLine());
double capacity = double.Parse(Console.ReadLine());
double courses = 0; //1 maybe?

courses = people / capacity;
courses = Math.Ceiling(courses);

Console.WriteLine(courses);