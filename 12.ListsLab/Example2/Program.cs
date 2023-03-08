using System.Globalization;

List<string> names = new List<string>();

names.Add("B");
names.Add("C");
names.Add("A");

//bool isRemoved = names.Remove("Shapov");
names.Sort();//Sort A,B,C
Console.WriteLine(string.Join(" ", names));
//Console.WriteLine(isRemoved);//true/false
//names.RemoveAt(0);
//names.Insert(0, "Georgi");
//int indexOfName = names.IndexOf("C");//dali e iztrito ne6to// index e dadeno ime
//Console.WriteLine(indexOfName);
//foreach (var item in names)
//{
//    Console.WriteLine(item);
//}

