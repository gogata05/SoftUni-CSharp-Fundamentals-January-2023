string textField = Console.ReadLine();//abv>1>1>2>2asdasd
int bomb = 0;

for (int i = 0; i < textField.Length; i++)//17/abv>1>1>2>2asdasd
{
    char currentLetter = textField[i];
    if (bomb > 0 && textField[i] != '>') //if bomb+0 and digit ! or >
    {
        textField = textField.Remove(i, 1);
        bomb--;
        i--;
    }
    //Step 4.1 if the index the current char == > than we have an explosion and
    //then we add the power of that exlosion that we have 
    else if (textField[i] == '>')
    {
        bomb += int.Parse(textField[i + 1].ToString());
    }
}
Console.WriteLine(textField);