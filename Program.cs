using System.Collections.Generic;
using System.Globalization;
using Principal.Entities;

namespace Principal
{
    class Program {
        static void Main(string[] args) {
            Console.Write("Enter the number of the products: ");
            int productsQty = int.Parse(Console.ReadLine());
            List<Product> products = new List<Product>();

            for (int i = 1; i <= productsQty; i++) {
                Console.WriteLine($"Product #{i} data:");
                Console.Write("Common, used or imported (c/u/i)? ");
                char productsType = char.Parse(Console.ReadLine());
                Console.Write("Name: ");
                string productsName = Console.ReadLine();
                Console.Write("Price: ");
                double productsPrice = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                if(productsType == 'u' || productsType == 'U') {
                    Console.Write("Manufactore date (DD/MM/YYYY): ");
                    DateTime productsManufactoreDate = DateTime.Parse(Console.ReadLine());

                    products.Add(new UsedProduct(productsName, productsPrice, productsManufactoreDate));
                }
                else if(productsType == 'i' || productsType == 'I') {
                    Console.Write("Custom Fee: ");
                    double productsCustomFee = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                    products.Add(new ImportedProduct(productsName, productsPrice, productsCustomFee));
                }
                else {
                    products.Add(new Product(productsName, productsPrice));
                }
            }
                Console.WriteLine();
                Console.WriteLine("PRICE TAGS: ");
                foreach(Product prod in products) {
                    Console.WriteLine(prod.PriceTag());
                }
        }
    }
}