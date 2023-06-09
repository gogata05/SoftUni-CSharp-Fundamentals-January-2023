using System.Text;
string text = Console.ReadLine();//heVVodar!gniV 
StringBuilder sb = new StringBuilder();
sb.Append(text);
string command = Console.ReadLine();//ChangeAll:|:V:|:l//Reverse:|:!gnil//InsertSpace:|:5//Reveal
while (command!="Reveal")
{
    string[] commandArray = command.Split(":|:",StringSplitOptions.RemoveEmptyEntries);
    string act = commandArray[0];//InsertSpace
    if (act== "InsertSpace")// InsertSpace:|:5
    {
        int indexInterval = int.Parse(commandArray[1]);//5//The given index will always be valid. 
        sb.Insert(indexInterval, ' ');
        Console.WriteLine(sb.ToString());//hello darling!
    }
    else if (act == "Reverse")//Reverse:|:!gnil 
    {
        string substring = commandArray[1];//!gnil
        if (sb.ToString().Contains(substring))
        {
            //sb="hellodar!gnil"
            int startIndex = sb.ToString().IndexOf(substring);//8//!gnil
            int lastIndex = startIndex + substring.Length -1; //12//!gnil
            int removeIndexes = (lastIndex - startIndex)+1;//5
            sb.Remove(startIndex,removeIndexes);//
            string reversedString = new string(substring.Reverse().ToArray());//ling!
            sb.Append(reversedString);//hellodarling!
            //This operation should replace only the first occurrence of the given substring
            //if there are two or more occurrences. 
            Console.WriteLine(sb.ToString());//hellodarling!
        }
        else
        {
            Console.WriteLine("error");
        }
    }
    else if (act == "ChangeAll")//ChangeAll:|:V:|:l 
    {
        string oldWord = commandArray[1];//V
        string newWord = commandArray[2];//l
        sb.Replace(oldWord, newWord);
        Console.WriteLine(sb.ToString()); //hellodar!gnil
    }
    command = Console.ReadLine();
}
Console.WriteLine($"You have a new text message: {sb.ToString()}");
