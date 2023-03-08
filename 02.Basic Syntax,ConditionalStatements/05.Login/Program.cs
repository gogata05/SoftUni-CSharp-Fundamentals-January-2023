//string name, 
//Revname = "";

//Console.Write("Entert Your Name : ");

//name = Console.ReadLine();

//for (int i = name.Length - 1; i >= 0; i--)

//{

//    Revname = Revname + name[i];

//}

//Console.WriteLine("Reverse  String  Is  {0}", Revname);

//Console.ReadLine();




string username = Console.ReadLine();
string password = "";
int wrongAttempts = 0;
for (int i = username.Length - 1; i >= 0; i--)
{
    password = password + username[i];
}
string enterPassword = Console.ReadLine();

while (enterPassword != password)
{
    wrongAttempts++;
    if (wrongAttempts == 4)
    {
        Console.WriteLine($"User {username} blocked!");
        return;
    }
    Console.WriteLine($"Incorrect password. Try again.");

    enterPassword = Console.ReadLine();
    
}

Console.WriteLine($"User {username} logged in.");
