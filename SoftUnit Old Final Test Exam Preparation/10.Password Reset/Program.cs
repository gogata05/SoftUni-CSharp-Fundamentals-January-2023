using System.Text;

string text = Console.ReadLine();//Siiceercaroetavm!:?:ahsott.:i:nstupmomceqr
StringBuilder  sb = new StringBuilder();
sb.Append(text);
string textOdd = "";
StringBuilder sbOdd = new StringBuilder();
sbOdd.Append(text);
int count = 0;
StringBuilder backUp = new StringBuilder();

string command = Console.ReadLine();//TakeOdd//Cut 15 3//Substitute :: -//Substitute | ^//Done
while (command!="Done")
{
    string[] commandArray = command.Split();//TakeOdd
    string act = commandArray[0];////TakeOdd//Cut 15 3//Substitute :: -//Substitute | ^//Done
    if (act== "TakeOdd")
    {
        if (count==0)
        {
            string remember = sbOdd.ToString();
            backUp.Append(remember);
            sb = backUp;
            sbOdd.Clear();
            count++;
        }
        
        for (int i = 1; i < sb.ToString().Length; i+=2)
                              //Siiceercaroetavm!:?:ahsott.:i:nstupmomceqr
        {
            textOdd += sb.ToString()[i];
        }
        sbOdd.Append(textOdd);//icecream::hot::summer
        Console.WriteLine(sbOdd.ToString()); //icecream::hot::summer
    }
    else if (act =="Cut")
    {
        int startIndex = int.Parse(commandArray[1]);//15
        int finalIndex = int.Parse(commandArray[2]);//3
        //int indexToRemove = (finalIndex - startIndex)+1;
        sbOdd.Remove(startIndex, finalIndex);//15//3//sum
        Console.WriteLine(sbOdd.ToString());//icecream::hot::mer 
    }
    else if (act== "Substitute")
    {
        string oldWord = commandArray[1];//:://|
        string newWord = commandArray[2];//-//^
        if (sbOdd.ToString().Contains(oldWord))
        {
            sbOdd.Replace(oldWord, newWord);
            Console.WriteLine(sbOdd.ToString());//icecream-hot-mer
            //all of its occurrences
        }
        else
        {
            Console.WriteLine("Nothing to replace!");
        }
    }
    command = Console.ReadLine();
}

Console.WriteLine($"Your password is: {sbOdd.ToString()}");