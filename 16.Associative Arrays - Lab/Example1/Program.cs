Dictionary<string, string> phoneNumbers = new Dictionary<string, string>();
//phoneNumbers["Stoyan Shopov"] = "0890905123";
phoneNumbers.Add("Stoyan Shopov", "0890905123");
foreach (var VARIABLE in phoneNumbers)
{
    Console.WriteLine(VARIABLE.Value);//or key
}
//SortedDictionary<string, string> phoneNumbers = new SortedDictionary<string, string>();
//SortedDictionary<> sort only the keys by exp: abc : 
if (!phoneNumbers.ContainsKey("Stoyan Shopov"))
{
    phoneNumbers.Add("Stoyan Shopov", "0890905123");
}
//Add(key,value)
//Remove(key)
//ContainsKey(key)
//ContainsValue(value)
//foreach (var VARIABLE in phoneNumbers)
//{
//    Console.WriteLine($"{VARIABLE.Key} - {VARIABLE.Value}");
//}

Console.WriteLine(phoneNumbers.ContainsValue("0890905123"));//true
