double currentBalance = double.Parse(Console.ReadLine());
string validGames = Console.ReadLine();
double totalSpent = 0;
while (validGames != "Game Time")
{
    if (validGames == "OutFall 4")
    {
        if (currentBalance >= 39.99)
        {
            currentBalance -= 39.99; //Check
            totalSpent+= 39.99;
            Console.WriteLine($"Bought {validGames}");
        }
        else
        {
            Console.WriteLine("Too Expensive");
        }
    }
    else if (validGames == "CS: OG")
    {
        if (currentBalance >= 15.99)
        {
            currentBalance -= 15.99;
            totalSpent += 15.99;
            Console.WriteLine($"Bought {validGames}");
        }
        else
        {
            Console.WriteLine("Too Expensive");
        }
    }
    else if (validGames == "Zplinter Zell")
    {

        if (currentBalance >= 19.99)
        {
            currentBalance -= 19.99;
            totalSpent += 19.99;
            Console.WriteLine($"Bought {validGames}");
        }
        else
        {
            Console.WriteLine("Too Expensive");
        }
    }
    else if (validGames == "Honored 2")
    {
        if (currentBalance >= 59.99)
        {
            currentBalance -= 59.99;
            totalSpent += 59.99;
            Console.WriteLine($"Bought {validGames}");
        }
        else
        {
            Console.WriteLine("Too Expensive");
        }
    }
    else if (validGames == "RoverWatch")
    {
        if (currentBalance >= 29.99)
        {
            currentBalance -= 29.99;
            totalSpent += 29.99;
            Console.WriteLine($"Bought {validGames}");
        }
        else
        {
            Console.WriteLine("Too Expensive");
        }
    }
    else if (validGames == "RoverWatch Origins Edition")
    {
        if (currentBalance >= 39.99)
        {
            currentBalance -= 39.99;
            totalSpent += 39.99;
            Console.WriteLine($"Bought {validGames}");
        }
        else
        {
            Console.WriteLine("Too Expensive");
        }  
    }
    else
    {
        Console.WriteLine($"Not Found");
    }

    if (currentBalance == 0)
    {
        Console.WriteLine("Out of money");
        return;
    }

    validGames = Console.ReadLine();
}

Console.WriteLine($"Total spent: ${totalSpent:f2}. Remaining: ${currentBalance:f2}");
