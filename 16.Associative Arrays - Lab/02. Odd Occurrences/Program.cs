string[] words = Console.ReadLine().Split();
Dictionary<string,int> counts = new Dictionary<string,int>();

foreach (string word in words)
{
    string wordInLowerCase = word.ToLower();//little words//each word//Java=>java
    if (counts.ContainsKey(wordInLowerCase))//if contains java ++
    {
        counts[wordInLowerCase]++;
    }
    else
    {
        counts.Add(wordInLowerCase, 1);
    }
}
foreach (var item in counts)
{
    if (item.Value%2 !=0)
    {
        Console.Write(item.Key+ " ");
    }
}