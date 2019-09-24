using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            double vodka = 10;
            double beer = 30;
            int tea = 5;
            int mineral  = 2;
            int kumis = 3;

            string coctail = "";

            coctail = MadeCoctail(out vodka, out beer);

            Console.WriteLine(coctail);

            Console.WriteLine("Vodka {0} Beer {1}", vodka, beer);

            coctail = MadeCoctail(tea, mineral, kumis);

            Console.WriteLine(coctail);

            Console.ReadKey();
        }

        private static string MadeCoctail(int tea, int mineral, int kumis)
        {
            return "Opochmel";
        }

        private static string MadeCoctail(out double vodka, out double beer)
        {
            vodka -= 0.2;
            beer -= 1;
            return "Yursh";
        }
    }
}
