Dictionary<string, int> phoneNumbers = new Dictionary<string, int>();

phoneNumbers.Add("Stoyan", 10);
phoneNumbers.Add("Ivan", 10);
phoneNumbers.Add("Gosho", 10);
phoneNumbers.Add("Kiro", 10);

Console.WriteLine(phoneNumbers["Ivan"]);
Console.WriteLine(phoneNumbers.ContainsValue(10));//true//we can check a value if true
//We can uniquely print keys like that// 
