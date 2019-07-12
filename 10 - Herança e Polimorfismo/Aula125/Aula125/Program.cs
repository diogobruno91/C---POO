using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Aula125.Entities;

namespace Aula125
{
    class Program
    {
        static void Main(string[] args)
        {
            BussinessAccount account = new BussinessAccount(100, "Diogo Rondao", 100.0, 500.0);

            Console.WriteLine(account.Balance);

            //account.Balance = 200.0;
        }
    }
}
