//Programming Fundamentals : John Smith// Programming Fundamentals : Linda Johnson// JS Core : Will Wilson// Java Advanced : Harrison White// end 
Dictionary<string, List<string>> dictionary = new Dictionary<string, List<string>>();//Programming Fundamentals,
string command = Console.ReadLine();//Programming Fundamentals : John Smith
while (command != "end")//Programming Fundamentals : John Smith
{
    string[] commandArray = command.Split(" : ", StringSplitOptions.RemoveEmptyEntries);//Programming Fundamentals John Smith
    string courseName = commandArray[0];//Programming Fundamentals
    string studentName = commandArray[1];//John Smith
    if (!dictionary.ContainsKey(courseName))//Programming Fundamentals
    {                       
        dictionary[courseName] = new List<string>();//Programming Fundamentals
    }
    dictionary[courseName].Add(studentName);//John Smith
    command = Console.ReadLine();
}
foreach (var item in dictionary)
{
    string courseName = item.Key; //Programming Fundamentals
    List<string> students = item.Value;//John Smith, Linda Johnson
    Console.WriteLine($"{courseName}: {students.Count}");//Programming Fundamentals
    foreach (string studentName in students)
    {
        Console.WriteLine($"-- {studentName}");
    }
}
//Programming Fundamentals: 2
//-- John Smith
//-- Linda Johnson
//JS Core: 1
//-- Will Wilson
//Java Advanced: 1
//-- Harrison White
