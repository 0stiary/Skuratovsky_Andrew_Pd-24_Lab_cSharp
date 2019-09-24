using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rectangle
{
    class Program
    {
        static void DrawRectangle(int x,int y)
        {
            for (int i = 0; i  < x; i ++)
            {
                for (int j = 0; j< y; j++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }
        } 

        static void Main(string[] args)
        {
            DrawRectangle(5, 10);


            DrawRectangle(5, 30);

            Console.ReadKey();

        }
    }
}
