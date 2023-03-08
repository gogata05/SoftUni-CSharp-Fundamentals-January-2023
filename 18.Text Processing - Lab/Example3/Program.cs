string card = "10C";
string power = card.Substring(0,2);//start from 0 and gets 1st 2 symbols
Console.WriteLine(power);//10

string text = "My name is John";
string extractWord = text.Substring(11);
Console.WriteLine(extractWord);//John

string names = "0123456789";
string result = names.Substring(0);//1,2,3...names.Length takes everything to the right of the num
//0,names.Length
//0,5
//2, names.Length-3 // we miss 1st 2 and we mist the last 1//2345678
Console.WriteLine(result);