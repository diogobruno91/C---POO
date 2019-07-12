using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula211
{
    class Program
    {
        static void Main(string[] args)
        {
            //Especificar o Data Source(Fonte de dados).
            int[] numbers = new int[] { 2, 3, 4, 5 };

            //Definer a consulta
            var result = numbers.Where(x => x % 2 == 0).Select(x => x * 10);

            //Executar consulta
            foreach (int x in result) {
                Console.WriteLine(x);
            }
        }
    }
}
