using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace Aula69
{
    class Program
    {
        static void Main(string[] args)
        {

            int n = int.Parse(Console.ReadLine());

            double[] vet = new double[n];

            for (int i = 0; i < n; i++)
            {
                vet[i] = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            }

            double soma = 0.0;
            for (int i=0; i < n; i++)
            {
                soma += vet[i];
            }

            double avg = soma / n;

            Console.WriteLine("Altura media = " + avg.ToString("F2", CultureInfo.InvariantCulture));
        }
    }
}
