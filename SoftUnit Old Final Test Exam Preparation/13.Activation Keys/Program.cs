using System.Linq;
using System.Text;
string text = Console.ReadLine();
//abcdefghijklmnopqrstuvwxyz
StringBuilder sb = new StringBuilder();
sb.Append(text);
string command = Console.ReadLine(); 
//Slice>>>2>>>6//Flip>>>Upper>>>3>>>14//
//Flip>>>Lower>>>5>>>7Contains>>>def//Contains>>>deF//Generate
while (command!= "Generate")
{
    string[] commandArray = command.Split(">>>",StringSplitOptions.RemoveEmptyEntries);
    string act = commandArray[0];
    if (act=="Slice")//Slice>>>2>>>6
    {
        int startIndex = int.Parse(commandArray[1]);//2
        int finalIndex = int.Parse(commandArray[2]);//6
        //Both indices will be valid. 
        int removeCount = finalIndex - startIndex;//6-2=4
        sb.Remove(startIndex, removeCount);//2//4
        Console.WriteLine(sb.ToString());//abghijklmnopqrstuvwxyz//to g
    }
    
    else if (act=="Flip") //Flip >>> Upper >>> 3 >>> 14
    {
        string upperOrLower = commandArray[1];//Upper
        int startIndexFlip = int.Parse(commandArray[2]);//3
        int finalIndexFlip = int.Parse(commandArray[3]);//14
        int IndexDifference = finalIndexFlip - startIndexFlip;//14-3=11
        if (upperOrLower == "Upper")
        {
            string substring = sb.ToString();//copy//abghijklmnopqrstuvwxyz
            string sbCopy = substring.Substring(startIndexFlip, IndexDifference);//hijklmnopqr
            char[]chars = sbCopy.ToCharArray();//hijklmnopqr
            for (int i = 0; i < chars.Length; i++)
            {
                chars[i] = char.ToUpper(chars[i]);
            }
            string newString = new string(chars);
            sb.Remove(startIndexFlip, IndexDifference);//abgstuvwxyz
            sb.Insert(startIndexFlip, newString);//abgHIJKLMNOPQRstuavwxyz
            Console.WriteLine(sb.ToString());//abgHIJKLMNOPQRstuavwxyz
        }
        else if (upperOrLower =="Lower")
        {
            string substring = sb.ToString();//copy//abghijklmnopqrstuvwxyz
            string sbCopy = substring.Substring(startIndexFlip, IndexDifference);//hijklmnopqr
            char[] chars = sbCopy.ToCharArray();//hijklmnopqr
            for (int i = 0; i < chars.Length; i++)
            {
                chars[i] = char.ToLower(chars[i]);
            }
            string newString = new string(chars);
            sb.Remove(startIndexFlip, IndexDifference);//abgstuvwxyz
            sb.Insert(startIndexFlip, newString);//abgHIjkLMNOPQRstuvwxyz
            Console.WriteLine(sb.ToString()); // abgHIjkLMNOPQRstuvwxyz
        }
    }
    else if (act=="Contains")//Contains>>>def 
    {
        string contains = commandArray[1];
        if (sb.ToString().Contains(contains))
        {
            Console.WriteLine($"{sb.ToString()} contains {contains}");//if
        }
        else
        {
            Console.WriteLine("Substring not found!");
        }
    }
    command = Console.ReadLine();
}

Console.WriteLine($"Your activation key is: {sb.ToString()}");//abgHIjkLMNOPQRstuvwxyz
