using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;

class FoodInfo
{
    static void Main()
    {
        string pattern = @"(\||#)([A-Za-z ]+)\1(\d{2}/\d{2}/\d{2})\1(\d{1,5})\1";
        string input = Console.ReadLine();
        Regex regex = new Regex(pattern);
        MatchCollection matches = regex.Matches(input);
        int totalCalories = 0;

        // Process matches
        foreach (Match match in matches)
        {
            string food = match.Groups[2].Value;
            string date = match.Groups[3].Value;
            string productCalories = match.Groups[4].Value;
            totalCalories += int.Parse(productCalories);
        }

        // Calculate number of days
        int daysFood = totalCalories / 2000;
        Console.WriteLine($"You have food to last you for: {daysFood} days!");

        // Print food items
        foreach (Match match in matches)
        {
            string foodName = match.Groups[2].Value;
            string expirationDate = match.Groups[3].Value;
            string productCalories = match.Groups[4].Value;

            Console.WriteLine($"Item: {foodName}, Best before: {expirationDate}, Nutrition: {int.Parse(productCalories)}");
        }
    }
}