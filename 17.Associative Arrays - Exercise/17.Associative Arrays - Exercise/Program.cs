
Dictionary<char, int> dictionary = new Dictionary<char, int>();//Count 0
string text = Console.ReadLine();//text
foreach (char item in text)
{
    if (item != ' ')
    {
        if (!dictionary.ContainsKey(item))//if doesnt containsKey t
        {
            dictionary[item] = 0;//
        }
        dictionary[item]++;
    }
}
foreach (var item in dictionary)
{
    Console.WriteLine($"{item.Key} -> {item.Value}");
}

