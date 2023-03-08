//Programming Fundamentals : John Smith// Programming Fundamentals : Linda Johnson// JS Core : Will Wilson// Java Advanced : Harrison White// end
Dictionary<string, List<string>> dictionary = new Dictionary<string, List<string>>();
string command = Console.ReadLine();//Programming Fundamentals : John Smith
while (command!= "end")
{
    string[] commandArray = command.Split(" : ",StringSplitOptions.RemoveEmptyEntries);//Programming Fundamentals John Smith
    string courseName = commandArray[0];//Programming Fundamentals
    string studentName = commandArray[1];//John Smith
    if (!dictionary.ContainsKey(courseName))//Programming Fundamentals
    {
        dictionary[courseName] = new List<string>() { };//new list
    }
    dictionary[courseName].Add(studentName);//John Smith
    command = Console.ReadLine();
}

foreach (var item in dictionary)//Programming Fundamentals John Smith Linda
{
    string courseName = item.Key;//Programming Fundamentals
    List<string> studentList = item.Value;//John Smith Linda
    int registeredStudents = studentList.Count;//2
    Console.WriteLine($"{courseName}: {registeredStudents}");
    foreach (var item2 in studentList)//John Smith Linda
    {
        Console.WriteLine($"-- {item2}");
    }
}



