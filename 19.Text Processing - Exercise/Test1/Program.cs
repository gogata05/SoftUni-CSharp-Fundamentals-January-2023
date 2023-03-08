string[] namesArray = Console.ReadLine().Split(", ");//sh, too_long_username, !lleg@l ch@rs, jeffbutt
foreach (string itemCurrentName in namesArray)
{
    if (itemCurrentName.Length>=3 && itemCurrentName.Length<=16)
    {
        bool isValid = true;
        foreach (char itemLetter in itemCurrentName)
        {
            if (!(char.IsLetterOrDigit(itemLetter) || itemLetter == '-' || itemLetter == '_'))
            {
                isValid = false;
                break;
            }
        }
        if (isValid)
        {
            Console.WriteLine(itemCurrentName);
        }
    }

    
}
