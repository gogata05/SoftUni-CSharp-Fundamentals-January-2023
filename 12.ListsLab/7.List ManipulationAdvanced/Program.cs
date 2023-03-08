using static System.Runtime.InteropServices.JavaScript.JSType;
using System.Collections.Generic;
using System;

List<int> numbers = Console.ReadLine().Split().Select(int.Parse).ToList();
string command = Console.ReadLine();
bool hasChanges = false;

while (command != "end")
{
    //Add { number}: add a number to the end of the list.
    //Remove { number}: remove a number from the list. 
    //RemoveAt { index}: remove a number at a given index.
    //Insert { number} { index}: insert a number at a given index.
    string[] commandInfo = command.Split();//["Add","3"]

    if (commandInfo[0] == "Add")
    {
        int number = int.Parse(commandInfo[1]);
        numbers.Add(number);
        hasChanges = true;
    }
    else if (commandInfo[0] == "Remove")
    {
        int number = int.Parse(commandInfo[1]);
        numbers.Remove(number);
        hasChanges = true;
    }
    else if (commandInfo[0] == "RemoveAt")
    {
        int index = int.Parse(commandInfo[1]);
        numbers.RemoveAt(index);
        hasChanges = true;
    }
    else if (commandInfo[0] == "Insect")
    {
        int number = int.Parse(commandInfo[1]);
        int index = int.Parse(commandInfo[2]);
        numbers.Insert(index, number);

        hasChanges = true;
    }
    else if (commandInfo[0] == "Contains")
    {
        int number = int.Parse(commandInfo[1]);
        if (numbers.Contains(number)) 
        {
            Console.WriteLine("Yes");
        }
        else
        {
            Console.WriteLine("No such number");
        }
    }
    else if (commandInfo[0]== "PrintEven")
    {
        for (int i = 0; i < numbers.Count; i++)
        {
            if (numbers[i] %2==0)
            {
                Console.Write(numbers[i]+ " ");
            }
        }
        Console.WriteLine();
    }
    else if (commandInfo[0] == "PrintOdd")
    {
        for (int i = 0; i < numbers.Count; i++)
        {
            if (numbers[i] % 2 != 0)
            {
                Console.Write(numbers[i] + " ");
            }
        }
        Console.WriteLine();
    }
    else if (commandInfo[0] == "GetSum")
    {
        int sum = 0;

        foreach (var item in numbers)
        {
            sum += item;
        }
        Console.WriteLine(sum);
    }
    else if (commandInfo[0] == "Filter")
    {
        string condition = commandInfo[1];
        int number = int.Parse(commandInfo[2]);

        if (condition == "<")
        {
            foreach (var item in numbers)
            {
                if (item <number)
                {
                    Console.Write(item + " ");
                }
            }
        }
        else if (condition == ">")
        {
            foreach (var item in numbers)
            {
                if (item > number)
                {
                    Console.Write(item + " ");
                }
            }
        }
        else if (condition == ">=")
        {
            foreach (var item in numbers)
            {
                if (item >= number)
                {
                    Console.Write(item + " ");
                }
            }
        }
        else if (condition == "<=")
        {
            foreach (var item in numbers)
            {
                if (item <= number)
                {
                    Console.Write(item + " ");
                }
            }
        }
    }
    command = Console.ReadLine();
}
if (hasChanges)
{
    Console.WriteLine(string.Join(" ", numbers));
}


//Contains
//{ number} – check if the list contains the number and if so - print "Yes", otherwise print "No such number". 

//PrintEven – print all the even numbers, separated by a space. 

//PrintOdd – print all the odd numbers, separated by a space. 

//GetSum – print the sum of all the numbers. 

//Filter {condition} { number} – print all the numbers that fulfill the given condition. The condition will be either '<', '>', ">=", "<=". 
