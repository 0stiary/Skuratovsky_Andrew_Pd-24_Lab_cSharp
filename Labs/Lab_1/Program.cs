using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Rez A = ");
            int RezA = Convert.ToInt32(Console.ReadLine());

            Console.Write("Rez B = ");
            int RezB = Convert.ToInt32(Console.ReadLine());

            int AllRez = (RezA * RezB) / (RezA + RezB);
            Console.WriteLine("Om of electric line = " + AllRez);

        }
    }
}
