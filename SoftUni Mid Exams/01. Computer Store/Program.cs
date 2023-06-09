using System;

namespace Receipt
{
    class Program
    {
        static void Main(string[] args)
        {
            double priceWithoutTaxes = 0;
            double taxes = 0;
            double totalPrice = 0;
            string customerType = Console.ReadLine();

            while (customerType != "special" && customerType != "regular")
            {
                double price = double.Parse(customerType);
                if (price <= 0)
                {
                    Console.WriteLine("Invalid price!");
                }
                else
                {
                    priceWithoutTaxes += price;
                }

                customerType = Console.ReadLine();
            }

            taxes = priceWithoutTaxes * 0.20;
            totalPrice = priceWithoutTaxes + taxes;

            if (priceWithoutTaxes == 0)
            {
                Console.WriteLine("Invalid order!");
                return;
            }

            if (customerType == "special")
            {
                totalPrice -= totalPrice * 0.10;
            }

            Console.WriteLine("Congratulations you've just bought a new computer!");
            Console.WriteLine("Price without taxes: " + priceWithoutTaxes.ToString("F2") + "$");
            Console.WriteLine("Taxes: " + taxes.ToString("F2") + "$");
            Console.WriteLine("-----------");
            Console.WriteLine("Total price: " + totalPrice.ToString("F2") + "$");
        }
    }
}