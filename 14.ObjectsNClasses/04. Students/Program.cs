//John Smith 15 Sofia
//Peter Ivanov 14 Plovdiv
//Linda Bridge 16 Sofia
//Simon Stone 12 Varna
//end
//Sofia
List<Student> students = new List<Student>() { };
string info = Console.ReadLine();
while (info!= "end")
{
    //John Smith 15 Sofia
    string[] inforArray = info.Split();
    string firstName = inforArray[0];
    string lastName = inforArray[1];
    int age = int.Parse(inforArray[2]);
    string town = inforArray[3];
    Student student = new Student
    {
        FirstName = firstName,
        LastName = lastName,
        Age = age,
        HomeTown = town,
    };
    students.Add(student);
    info = Console.ReadLine();
}
string homeTown = Console.ReadLine();
foreach (Student currentStudent in students)
{
    if (currentStudent.HomeTown == homeTown)
    {
        Console.WriteLine($"{currentStudent.FirstName} {currentStudent.LastName} is {currentStudent.Age} years old.");
    }
}
class Student
{
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public int Age { get; set; }
    public string HomeTown { get; set; }
}