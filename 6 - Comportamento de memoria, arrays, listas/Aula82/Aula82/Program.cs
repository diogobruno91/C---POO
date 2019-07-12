using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.Generic;

namespace Aula82
{
    class Program
    {
        static void Main(string[] args)
        {
            HashSet<int> A = new HashSet<int>();
            HashSet<int> B = new HashSet<int>();

            A.Add(3);
            A.Add(5);
            A.Add(8);
            A.Add(9);

            B.Add(3);
            B.Add(4);
            B.Add(5);



            foreach (int x in B)
            {
                Console.WriteLine(x);
            }

            //Console.WriteLine("Digite um valor inteiro: ");
            //int N = int.Parse(Console.ReadLine());

            //if (B.Contains(N))
            //{
            //    Console.WriteLine(N + " pertence ao conjunto B");
            //}
            //else
            //{
            //    Console.WriteLine(N + " não pertence ao conjunto B");
            //}



            Console.ReadLine();
        }
    }
}
