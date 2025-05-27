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
            string tekst;
            string kwota = "";
            string kwota1 = "";
            Bank Bank = new Bank(1, 100);
            Bank.wyplata(100);

            Bank.wplata(1000);


            double stanKonta = Bank.getStanKonta();
            Console.WriteLine("stan konta:" + stanKonta);
            

            Console.WriteLine("czy chcesz wyplacic pieniadze? tak/nie");
            tekst = Console.ReadLine();

            if (tekst == "tak")
            {
                Console.WriteLine("jaka kwote chcesz wyplacic?");
                kwota = Console.ReadLine();
            }
            if (double.Parse(kwota) > 0)
            {
                Bank.wyplata(double.Parse(kwota));
                Console.WriteLine(kwota);
                Console.ReadLine() ;    
            }
            else
            {
                Console.WriteLine("bledna wkota");
                Console.ReadLine() ;
            }

            Console.WriteLine("aktualny stan konta" + (Bank.getStanKonta()));
            Console.ReadLine();
            Console.WriteLine("chcesz dokonać wpłaty? tak/nie");
            kwota1=Console.ReadLine();
            if (kwota1 == "tak")
            {
                Console.WriteLine("jaka kwote chcesz wplacic?");
                kwota1 = Console.ReadLine();


            }
            else
            {
                Console.WriteLine("zakonczono operacje");
                     Console.ReadLine() ;
                    }

            if (double.Parse(kwota1) > 0)
            {
                Bank.wplata(double.Parse(kwota1));
            }
            Console.WriteLine("aktualny stan konta" + (Bank.getStanKonta()));
            Console.ReadLine();

        }

            

            
            
        
    }
}
