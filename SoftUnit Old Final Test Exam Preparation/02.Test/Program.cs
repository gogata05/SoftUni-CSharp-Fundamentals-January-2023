using System.Text.RegularExpressions;

Dictionary<string,string>dictionary = new Dictionary<string,string>();
string pattern = @"(\||#)([A-Za-z ]+)\1(\d{2}/\d{2}/\d{2})\1(\d{1,5})\1";
string input = Console.ReadLine();
Regex regex = new Regex(pattern);
MatchCollection matches = regex.Matches(input);
int totalCalories = 0;
foreach (Match match in matches)
{
    string food = match.Groups[2].Value;//Bread
    string date = match.Groups[3].Value;
    string productCalories = match.Groups[4].Value;
    totalCalories += int.Parse(productCalories);
    string dateAndPrCalories = $"{date}:{productCalories}";
    if (!dictionary.ContainsKey(food))
    {
        
       dictionary.Add(food, dateAndPrCalories);
        
    }
    else
    {
        string dateAndPrCaloriess = dictionary[food];
        string[] array = dateAndPrCalories.Split(":");
        string expirationDatee = array[0];
        int currentCarories = int.Parse(array[1]);
        currentCarories += int.Parse(productCalories);
        string dateAndPrCalories2 = $"{expirationDatee}:{currentCarories}";

        dictionary[food] = dateAndPrCalories2;

    }
}

if (totalCalories == 0)
{
    Console.WriteLine($"You have food to last you for: 0 days!");
    return;
}
int daysFood = totalCalories / 2000;//2 days
Console.WriteLine($"You have food to last you for: {daysFood} days!");
if (daysFood > 0)
{
    foreach (var item in dictionary)//?
    {
        string foodName = item.Key;
        string dateAndPrCalories = item.Value;
        string[] array = dateAndPrCalories.Split(":");
        string expirationDate = array[0];
        string productCalories = array[1];
        
        Console.WriteLine($"Item: {foodName}, Best before: {expirationDate}, Nutrition: {int.Parse(productCalories)}");
    }
}