using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace Aula70
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            Product[] vet = new Product[n];

             for (int i = 0; i < n; i++)
            {
                string name = Console.ReadLine();
                double price = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                vet[i] = new Product { Name = name, Price = price };
            }

            double soma = 0.0;
            for (int i = 0; i < n; i++)
            {
                soma += vet[i].Price;
            }
            double avg = soma / n;
            Console.WriteLine("Preço medio = " + avg.ToString("F2", CultureInfo.InvariantCulture));
        }
    }
}
