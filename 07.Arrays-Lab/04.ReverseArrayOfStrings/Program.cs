using System.Data.Common;


//for (int i = 0; i < names.Length; i++)
//{
//    Console.WriteLine(names[i]);
//}
string[] names = Console.ReadLine().Split();

Array.Reverse(names);
Console.WriteLine(string.Join(" ", names));




