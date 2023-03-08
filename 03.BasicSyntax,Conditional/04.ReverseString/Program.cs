string username = Console.ReadLine();
string usernameReverse = "";

for (int i = username.Length - 1; i >= 0; i--)
{


    usernameReverse = usernameReverse + username[i];
}
Console.WriteLine($"{usernameReverse}");
//string enterPassword = Console.ReadLine();

//while (enterPassword != password)
//{
   
    
    
//        Console.WriteLine($"User {username} blocked!");
   
    
//    Console.WriteLine($"Incorrect password. Try again.");

//    enterPassword = Console.ReadLine();

//}

//Console.WriteLine($"User {username} logged in.");
