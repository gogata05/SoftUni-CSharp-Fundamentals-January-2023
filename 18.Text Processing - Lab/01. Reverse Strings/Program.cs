string command = Console.ReadLine();
while (command!="end")
{
    string reversed = "";
    for (int i = command.Length-1; i >= 0; i--)
    {
        reversed += command[i];
    }
    Console.WriteLine($"{command} = {reversed}");
    command = Console.ReadLine();
}

