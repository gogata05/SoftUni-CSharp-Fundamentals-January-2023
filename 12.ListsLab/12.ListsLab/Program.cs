List<string> names = new List<string>();
//List<string> values = new() { "Ivan", "Kiro", "ddz" };

names.Add("Ivan");
names.Add("Kiro");
names.Add("ddz");

//for (int i = 0; i < names.Count; i++)
//{
//    Console.WriteLine(names[i]);
//}
Console.WriteLine(string.Join(" ", names));
//Console.WriteLine(names[0]);
//Console.WriteLine(names[names.Count - 1]);
//names.Remove("Ivan");//we remove index
//names.Insert(1, "Georgiev");//wmukwame w index 1 towa i wsi4ko otiwa nadqsno
Console.WriteLine(names.Contains("Ivan"));//pitame sudurja li na console test/true/false



