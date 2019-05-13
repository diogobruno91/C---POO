using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula25
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 10;
            bool c1 = a < 10;
            bool c2 = a < 20;

            Console.WriteLine(c1);
            Console.WriteLine(c2);
            Console.WriteLine("---------------------------");

            bool c3 = a <= 10;
            bool c4 = a >= 10;

            Console.WriteLine(c3);
            Console.WriteLine(c4);

        }
    }
}
