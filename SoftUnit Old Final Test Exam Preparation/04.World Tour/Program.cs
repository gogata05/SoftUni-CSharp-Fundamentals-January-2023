using System.Text;
using System.Windows.Input;

string text = Console.ReadLine();//Hawai::Cyprys-Greece
StringBuilder sb = new StringBuilder();//empty
string command = Console.ReadLine();
//Add Stop:7:Rome//Remove Stop:11:16//Switch:Hawai:Bulgaria//Travel
sb.Append(text);//Hawai::Cyprys-Greece
while (command!= "Travel")
{
    string[] commandArray = command.Split(":",StringSplitOptions.RemoveEmptyEntries);
    string act = commandArray[0];
    
    if (act=="Add Stop")//Add Stop:7:Rome
    {
        int indexAdd = int.Parse(commandArray[1]);//7
        if (sb.Length >= indexAdd)//if 20>=7
        {
            string wordAdd = commandArray[2];//Rome
            sb.Insert(indexAdd, wordAdd);//Hawai::Cyprys-Greece+
        }
        Console.WriteLine(sb.ToString());//Hawai::RomeCyprys-Greece 
    }
    else if (act=="Remove Stop")//Remove Stop:11:16
    {
        int startIndex = int.Parse(commandArray[1]);//11
        int endIndex = int.Parse(commandArray[2]);//16
        int lengthToRemove = (endIndex - startIndex) +1;//5
        if (startIndex<sb.Length && endIndex<=sb.Length)//11 16
        {
            sb.Remove(startIndex, lengthToRemove);//11//16
        }
        Console.WriteLine(sb.ToString());//Hawai::Rome-Greece 
    }
    else if (act=="Switch")//Switch:Hawai:Bulgaria//Travel
    {
        string oldWord = commandArray[1];//Hawai
        string newWord = commandArray[2];//Bulgaria
        if (sb.ToString().Contains(oldWord))
        {
            sb.Replace(oldWord, newWord);//Hawai//Bulgaria//all?
        }
        Console.WriteLine(sb.ToString());//Bulgaria::Rome-Greece 
    }
    command = Console.ReadLine();
}

Console.WriteLine($"Ready for world tour! Planned stops: {sb.ToString()}");
