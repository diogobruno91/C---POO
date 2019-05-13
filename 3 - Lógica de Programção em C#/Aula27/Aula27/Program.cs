using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula27
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Qual a hora atual");
            int hora = int.Parse(Console.ReadLine());

            if (hora <= 12)
            {
                Console.WriteLine("Bom dia!");
            }
            else if (hora <= 18)
            {
                Console.WriteLine("Bom tarde!");
            }
            else
            {
                Console.WriteLine("Bom noite!");
            }


            //EXERCICIO IMPAR OU PAR 

            //Console.WriteLine("Entre com um número inteiro:");
            //int x = int.Parse(Console.ReadLine());

            //if(x % 2 == 0)
            //{
            //    Console.WriteLine("O numero e par!");
            //}
            //else
            //{
            //    Console.WriteLine("O numero e impar!");
            //}




            //int x = 10;

            //Console.WriteLine("Bom dia");

            //if (x > 5)
            //{
            //    Console.WriteLine("Boa tarde");
            //}

            //Console.WriteLine("Boa noite");
        }
    }
}
