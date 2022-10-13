using System;
using System.Collections.Generic;
using System.Linq;

namespace _04ProductShop
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //04. Product Shop
            //Create a program that prints information about food shops in Sofia and the products they store. Until the "Revision" command is received, you will be receiving input in the format: "{shop}, {product}, {price}".  Keep in mind that if you receive a shop you already have received, you must collect its product information.
            //Your output must be ordered by shop name and must be in the format:
            //"{shop}->
            //Product: { product}, Price: { price}
            //"
            //Note: The price should not be rounded or formatted.

            Dictionary<string, Dictionary<string, double>> shopsDictionary = new Dictionary<string, Dictionary<string, double>>();

            ShopsProductPriceInformation(shopsDictionary);

            PrintShopsDicionary(shopsDictionary);

        }

        static void PrintShopsDicionary(Dictionary<string, Dictionary<string, double>> shopsDictionary)
        {
            shopsDictionary = shopsDictionary.OrderBy(x => x.Key).ToDictionary(x => x.Key, x => x.Value);

            foreach (var shop in shopsDictionary)
            {
                Console.WriteLine($"{shop.Key}->");

                foreach (var product in shop.Value)
                {
                    Console.WriteLine($"Product: {product.Key}, Price: {product.Value}");
                }
            }
        }

        static void ShopsProductPriceInformation(Dictionary<string, Dictionary<string, double>> shopsDictionary)
        {
            string[] shopProductPrice = Console.ReadLine().Split(", ").ToArray();
            while (true)
            {
                if (shopProductPrice[0] == "Revision")
                {
                    break;
                }

                string shopName = shopProductPrice[0];
                string productType = shopProductPrice[1];
                double price = double.Parse(shopProductPrice[2]);

                if (!shopsDictionary.ContainsKey(shopName))
                {
                    shopsDictionary.Add(shopName, new Dictionary<string, double>());
                }

                shopsDictionary[shopName].Add(productType, price);

                shopProductPrice = Console.ReadLine().Split(", ").ToArray();
            }
        }
    }
}
