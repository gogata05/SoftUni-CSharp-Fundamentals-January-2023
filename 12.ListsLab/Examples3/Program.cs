List<string> names = new List<string>();

names.Add("A");
names.Add("B");

bool isRemoved = names.Remove("A");//true
bool isRemoved2 = names.Remove("B");//false

Console.WriteLine(names.Count);//1

names.Insert(1, "S");
names.RemoveAt(1);

int indexOfElements = names.IndexOf("S");

names.Sort();


Console.WriteLine(string.Join(" ", names));