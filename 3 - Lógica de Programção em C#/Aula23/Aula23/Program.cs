using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace Aula23
{
    class Program
    {
        static void Main(string[] args)
        {
            //Exercicio 

            Console.WriteLine("Entre com seu nome Completo:");
            string nome = Console.ReadLine();
            Console.WriteLine("Quantos quartos tem na sua casa?");
            int quartos = int.Parse(Console.ReadLine());
            Console.WriteLine("Entre com o preco de um produto:");
            double preco = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.WriteLine("Entre seu último nome, idade e altura");
            string[] vet = Console.ReadLine().Split(' ');
            string ultimoNome = vet[0];
            int idade= int.Parse(vet[1]);
            double altura = double.Parse(vet[2], CultureInfo.InvariantCulture);


            Console.WriteLine(nome);
            Console.WriteLine(quartos);
            Console.WriteLine(preco.ToString("F2", CultureInfo.InvariantCulture));
            Console.WriteLine(ultimoNome);
            Console.WriteLine(idade);
            Console.WriteLine(altura.ToString("F2", CultureInfo.InvariantCulture));






            //int n1 = int.Parse(Console.ReadLine());
            //char ch = char.Parse(Console.ReadLine());
            //double n2 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            //string[] vet = Console.ReadLine().Split(' ');
            //string nome = vet[0];
            //char sexo = char.Parse(vet[1]);
            //int idade = int.Parse(vet[2]);
            //double altura = double.Parse(vet[3], CultureInfo.InvariantCulture);

            //Console.WriteLine("Você Digitou:");
            //Console.WriteLine(n1);
            //Console.WriteLine(ch);
            //Console.WriteLine(n2.ToString("F2", CultureInfo.InvariantCulture));
            //Console.WriteLine(nome);
            //Console.WriteLine(sexo);
            //Console.WriteLine(idade);
            //Console.WriteLine(altura.ToString("F2", CultureInfo.InvariantCulture));
        }
    }
}
