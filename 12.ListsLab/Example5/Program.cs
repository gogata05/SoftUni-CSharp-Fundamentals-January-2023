List<string> list1 = new List<string>() { "1","2","3" };

List<int> list2 = new List<int>() { };

foreach (var item in list1)
{
    list2.Add(int.Parse(item));
}