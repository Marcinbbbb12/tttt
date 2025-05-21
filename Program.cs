using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tttt
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Bank Bank = new Bank(1,100);
            Bank.wyplata(100);
          
            Bank.wplata(1000);

           
                double stanKonta = Bank.getStanKonta();
            Console.WriteLine("stan konta:");
            Console.WriteLine(stanKonta);
            Console.ReadLine();

            
            
        }
    }
}
