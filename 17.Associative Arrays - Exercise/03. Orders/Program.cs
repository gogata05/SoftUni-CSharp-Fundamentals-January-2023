//Beer 2.20 100
//IceTea 1.50 50
//NukaCola 3.30 80
//Water 1.00 500
//buy
Dictionary<string,double> dictionary = new Dictionary<string,double>();
string command = Console.ReadLine();//Beer 2.40 350
double totalPrice = 0;//where to put this
while (command!="buy")
{
    string[] commandArray = command.Split();////Beer 2.40 350//Beer 1.20 200
    string productName = commandArray[0];//Beer
    double price = double.Parse(commandArray[1]);//1.20
    double quantity = double.Parse(commandArray[2]);//200
    totalPrice = price*quantity;//220.00
    if (!dictionary.ContainsKey(productName))//beer
    {
        dictionary.Add(productName, 0);//840
    }
    else
    {
        dictionary[productName] = totalPrice;//660.00
       
        //productName += productName;
        //totalPrice += totalPrice;
    }

    dictionary[productName] = totalPrice;
    command = Console.ReadLine();
}

foreach (var item in dictionary)
{
    string productName = item.Key;//beer..
    totalPrice = item.Value;//220.00
    Console.WriteLine($"{productName} -> {totalPrice:f2}");
}

