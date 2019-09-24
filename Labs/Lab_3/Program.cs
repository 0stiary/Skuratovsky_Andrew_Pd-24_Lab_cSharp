using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_3
{
    class Program
    {
        static void Main(string[] args)
        {

            int x1, y1, x2, y2, x, y;

            Console.Write("Enter x1 = ");
            x1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter y1 = ");
            y1 = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter x2 = ");
            x2 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter y2 = ");
            y2 = Convert.ToInt32(Console.ReadLine());

            
                Console.Write("Write your dot (x,y) \n x = ");    
                x = Convert.ToInt32(Console.ReadLine());
                Console.Write(" y = ");
                y = Convert.ToInt32(Console.ReadLine());

                if ((x > x1 && x < x2 && y < y1 && y > y2) ||
					(x < x1 && x > x2 && y > y1 && y < y2))
	            {
                    Console.WriteLine("Dot is valid");
	            }else
	            {
                    Console.WriteLine("Dot is not valid");
	            }
	        

            

        }
    }
}
