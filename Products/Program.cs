using System;
using System.Globalization;
using System.Collections.Generic;
using Products.Entities;

namespace Products {
    class Program {
        static void Main(string[] args) {
            Console.Write("Enter the number of products: ");
            int n = int.Parse(Console.ReadLine());

            List<Product> list = new List<Product>();

            for (int i = 1; i <= n; i++) {

                Console.WriteLine($"Product #{i} data:");

                Console.Write("Common, used ou imported (c/u/i)? ");
                char ch = char.Parse(Console.ReadLine());

                Console.Write("Name: ");
                string name = Console.ReadLine();

                Console.Write("Price: ");
                double price = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                switch (ch) {
                    case 'c':
                        list.Add(new Product(name, price));
                        break;
                    case 'u':
                        Console.Write("Manufacture date (DD/MM/YYYY): ");
                        DateTime manufactureDate = DateTime.Parse(Console.ReadLine());
                        list.Add(new UsedProduct(name, price, manufactureDate));
                        break;
                    case 'i':
                        Console.Write("Customs fee: ");
                        Double customsFee = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                        list.Add(new ImportedProduct(name, price, customsFee));
                        break;
                    default:
                        break;
                }
            }

            Console.WriteLine("");
            Console.WriteLine("PRICE TAGS:");

            foreach (Product emp in list) {
                Console.WriteLine(emp.PriceTag());
            }

            Console.WriteLine("");

        }
    }
}
