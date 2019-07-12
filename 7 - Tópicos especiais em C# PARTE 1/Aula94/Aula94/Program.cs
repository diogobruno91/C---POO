using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula94
{
    class Program
    {
        static void Main(string[] args)
        {
            DateTime d1 = DateTime.Parse("2000-08-15 13:05:50");
            DateTime d2 = DateTime.Parse("2000-08-15T13:05:50Z");

            Console.WriteLine(d1);
            Console.WriteLine(d2);


            //DateTime d1 = new DateTime(2000, 8, 15, 13, 5, 50, DateTimeKind.Local);

            //DateTime d2 = new DateTime(2000, 8, 15, 13, 5, 50, DateTimeKind.Utc);

            //DateTime d3 = new DateTime(2000, 8, 15, 13, 5, 50);

            //Console.WriteLine(d1);
            //Console.WriteLine(d2);
            //Console.WriteLine(d3);

        }
    }
}
