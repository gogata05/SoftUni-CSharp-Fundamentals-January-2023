string text = Console.ReadLine();//abv>1>1>2>2asdasd
int boom = 0;
for (int i = 0; i < text.Length; i++)
{   
    char currentLetter= text[i];
                  
    if (boom>0 && text[i]!='>')
    {
        //string removeChar=text[i].ToString();
        text = text.Remove(i, 1);
        boom--;
        i--;
    }
    else if (text[i] == '>')
    {
        boom += int.Parse(text[i + 1].ToString());
    }
}

Console.WriteLine(text);
