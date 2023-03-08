Dictionary<char,int> dictionary = new Dictionary<char,int>();
string text = Console.ReadLine();
foreach (var item in text)
{
    if (item!=' ')
    {
        if (!dictionary.ContainsKey(item))//t
        {
            dictionary.Add(item, 0);
        }
        dictionary[item]++;
    }
}

foreach (var item in dictionary)
{
    Console.WriteLine($"{item.Key} -> {item.Value}");
}