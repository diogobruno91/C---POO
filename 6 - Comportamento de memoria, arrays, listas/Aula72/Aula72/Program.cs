using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula72
{
    class Program
    {
        static void Main(string[] args)
        {
            int s1 = Calculator.Soma( 2, 3 );
            int s2 = Calculator.Soma( 2, 4, 3 );

            Console.WriteLine(s1);
            Console.WriteLine(s2);
        }
    }
}
