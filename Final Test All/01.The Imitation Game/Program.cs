using System.Text;

string text = Console.ReadLine();
StringBuilder sb = new StringBuilder();
sb.Append(text);
string command = Console.ReadLine();
while (command != "Decode")
{
    string[] commandArray = command.Split('|');
    if (commandArray[0] == "Move")//Move|3 //lloHe → Hello 
    {
        int removeIndexes = int.Parse(commandArray[1]);//3//llo
        string sbCopy = sb.ToString();
        //string newstring = sbCopy.Substring(0, 3);//llo
        string newStr = sbCopy.Substring(removeIndexes) + sbCopy.Substring(0, removeIndexes);
        //sb.Remove(0, 3);
        //sb.Append(newstring);//Hello
        sb.Clear();
        sb.Append(newStr);
    }
    else if (commandArray[0] == "Insert")//Insert|2|o //llHe → lloHe 
    {
        int indexToBeAdded = int.Parse(commandArray[1]);//2
        string toBeAdded = commandArray[2];//o
        sb.Insert(indexToBeAdded, toBeAdded);
    }
    else if (commandArray[0] == "ChangeAll")//ChangeAll|z|l 
    {

        sb.Replace(commandArray[1], commandArray[2]);
    }
    command = Console.ReadLine();
}

string final = sb.ToString();
Console.WriteLine($"The decrypted message is: {final}");