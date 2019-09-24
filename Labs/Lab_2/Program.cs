using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_2
{
    class Program
    {
        static void Main(string[] args)
        {
            int nn, nk;
            double k, a = 0, E = 0;
            do
            {
                Console.Write("NN = ");
                nn = Convert.ToInt32(Console.ReadLine());
                Console.Write("NK = ");
                nk = Convert.ToInt32(Console.ReadLine());
            } while (0 > nn && nn > nk);

            for (k = nn; k <= nk; k++)
            {
                a = (Math.Pow(k, 2) - 1)
                / (Math.Pow(-1, k + 1) * Math.Pow(k, 2) + 7);

                E += a;

                Console.WriteLine("E = " + E);
            }
        }
    }
}
