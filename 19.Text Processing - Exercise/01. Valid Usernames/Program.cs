string[] usernames = Console.ReadLine().Split(", ");
//sh, too_long_username, !lleg@l ch@rs, jeffbutt 
foreach (string itemCurrentName in usernames)
{
    if (itemCurrentName.Length >= 3 && itemCurrentName.Length <= 16)//if between 3 & 16
    {
        bool isUsarnameValid = true;
        foreach (char itemLetterTest in itemCurrentName) // => charrArray = [s, h]
                                           // => [p, e, s, h, o]
        {
            if (!(char.IsLetterOrDigit(itemLetterTest) || itemLetterTest == '-' || itemLetterTest == '_'))
            {
                isUsarnameValid = false;
                break;
            }
        }
        if (isUsarnameValid)
        {
            Console.WriteLine(itemCurrentName); // pesho
        }
    }
}