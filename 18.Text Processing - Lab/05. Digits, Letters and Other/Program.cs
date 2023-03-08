string text = Console.ReadLine();//Agd#53Dfg^&4F53
string nums = "";
string strings = "";
string chars = "";
foreach (var item in text)
{
    if (char.IsDigit(item))
    {
        nums += item;
       
    }
    else if (char.IsAsciiLetter(item))
    {
        strings += item;
    }
    else
    {
        chars += item;
    }
}

Console.WriteLine(nums);
Console.WriteLine(strings);
Console.WriteLine(chars);