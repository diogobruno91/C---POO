using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Aula132.Entities;
using System.Globalization;

namespace Aula132
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Product> list = new List<Product>();

            Console.Write("Enter the number of products: ");
            int n = int.Parse(Console.ReadLine());

            for(int i = 1; i <= n; i++)
            {
                Console.WriteLine($"Product #{i} date:");
                Console.Write("Commin, used or imported (c/u/i)? ");
                char type = char.Parse(Console.ReadLine());
                Console.Write("Name: ");
                string name = Console.ReadLine();
                Console.Write("Price: ");
                double price = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                if(type == 'c')
                {
                    list.Add(new Product(name, price));
                }
                else if (type == 'u') {
                    Console.Write("Manufacture date (DD/MM/YYYY)");
                    DateTime date = DateTime.Parse(Console.ReadLine());
                    list.Add(new UserProduct(name, price, date));
                }
                else
                {
                    Console.Write("Customs fee: ");
                    double customsFee = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                    list.Add(new ImportedProduct(name, price, customsFee));
                }
            }
            Console.WriteLine();
            Console.WriteLine("PRICE TAGS");
            foreach(Product pro in list)
            {
                Console.WriteLine(pro.PriceTag());
            }
        }
    }
}
