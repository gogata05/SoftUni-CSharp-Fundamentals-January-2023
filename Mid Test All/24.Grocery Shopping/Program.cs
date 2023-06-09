using System;
using System.Collections.Generic;
List<string> productList = new(Console.ReadLine().Split('|'));
while (true)
{
    string commandInput = Console.ReadLine();
    if (commandInput == "Shop!")
    {
        break;
    }
    string[] commandArray = commandInput.Split('%');
    string act = commandArray[0];
    string product = commandArray[1];
    if (act == "Important")
    {
        if (productList.Contains(product))
        {
            productList.Remove(product);
        }
        productList.Insert(0, product);
    }
    else if (act == "Add")
    {
        if (productList.Contains(product))
        {
            Console.WriteLine("The product is already in the list.");
        }
        else
        {
            productList.Add(product);
        }
    }
    else if (act == "Swap")
    {
        string product2 = commandArray[2];
        if (productList.Contains(product) && productList.Contains(product2))
        {
            int index1 = productList.IndexOf(product);
            int index2 = productList.IndexOf(product2);
            productList[index1] = product2;
            productList[index2] = product;
        }
        else
        {
            Console.WriteLine($"Product {product} missing!");
        }
    }
    else if (act == "Remove")
    {
        if (productList.Contains(product))
        {
            productList.Remove(product);
        }
        else
        {
            Console.WriteLine($"Product {product} isn't in the list.");
        }
    }
    else if (act == "Reversed")
    {
        productList.Reverse();
    }
}
for (int i = 0; i < productList.Count; i++)
{
    Console.WriteLine($"{i + 1}. {productList[i]}");
}