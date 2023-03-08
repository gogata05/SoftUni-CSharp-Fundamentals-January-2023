string command = Console.ReadLine();//hello

while (command!="end")
{
    string reverseWord = "";
    for (int i = command.Length - 1; i >= 0; i--)
    {
        reverseWord += command[i];
    }
    Console.WriteLine($"{command} = {reverseWord}");
    command = Console.ReadLine();
}


