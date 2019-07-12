using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace Aula90
{
    class Program
    {
        static void Main(string[] args)
        {
            DateTime d1 = DateTime.ParseExact("2000-08-15", "yyyy-MM-dd", CultureInfo.InvariantCulture);

            DateTime d2 = DateTime.ParseExact("15/08/2000 13:05:50", "dd/MM/yyyy HH:mm:ss", CultureInfo.InvariantCulture);


            Console.WriteLine(d2);

            //DateTime d1 = DateTime.Parse("2000-08-15");
            //DateTime d2 = DateTime.Parse("2000-08-15 13:05:50");
            //DateTime d3 = DateTime.Parse("15/08/2000");

            //Console.WriteLine(d1);
            //Console.WriteLine(d2);
            //Console.WriteLine(d3);

            //DateTime d1 = new DateTime(2019, 06, 27);
            //DateTime d2 = new DateTime(2019, 06, 27, 15, 09, 03);             

            //Console.WriteLine(d1);
            //Console.WriteLine(d2);
        }
    }
}
