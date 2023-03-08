//Input:
//Beer 2.40 350
//Water 1.25 200
//IceTea 5.20 100
//Beer 1.20 200
//IceTea 0.50 120
//buy
Dictionary<string, List<double>> dictionary1 = new Dictionary<string, List<double>>();
string command = Console.ReadLine();//Beer 2.40 350
double totalPrice = 0;//where to put this
string productName = "";
while (command != "buy")
{
    string[] commandArray = command.Split();////Beer 2.40 350//Beer 1.20 200
    productName = commandArray[0];//Beer
    double price = double.Parse(commandArray[1]);//1.20
    double quantity = double.Parse(commandArray[2]);//200
    if (!dictionary1.ContainsKey(productName))//beer
    {
        dictionary1[productName] = new List<double>() { };//beer list
        dictionary1[productName].Add(price); //840
        dictionary1[productName].Add(quantity);

        totalPrice = price * quantity;//220.00
        dictionary1[productName].Add(totalPrice);
    }
    else
    {
        dictionary1[productName].RemoveAt(0);//remove old price
        dictionary1[productName].Insert(0,price);//add new price
        dictionary1[productName][1] +=quantity;//350+200=550
        totalPrice = dictionary1[productName][0] * dictionary1[productName][1];
        dictionary1[productName].RemoveAt(2);
        dictionary1[productName].Add(totalPrice);
    }
    command = Console.ReadLine();
}
foreach (var item in dictionary1)
{
    productName = item.Key;//Beer water icetea
    totalPrice = item.Value[2];
    Console.WriteLine($"{productName} -> {totalPrice:f2}");
}
