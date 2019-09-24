using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_3_Dop
{
    class Program
    {
        static void Main(string[] args)
        {
            int x, y, x1, y1;
            bool d = false;

            Console.Write("Where is your horse? \n x (1-8) = ");
            x = Convert.ToInt32(Console.ReadLine()) - 1;
            Console.Write(" y (1-8) = ");
            y = Convert.ToInt32(Console.ReadLine()) - 1;

            for (int i = 0; i < 8; i++)
            {
                for (int j = 0; j < 8; j++)
                {
                    if (i == x && j == y)
                    {
                        Console.Write(" K ");
                    }
                    else
                    {
                        Console.Write(" 1 ");
                    }
                }
                Console.WriteLine();
            }

            Console.Write("Where you want to go? \n x (1-8) = ");
            x1 = Convert.ToInt32(Console.ReadLine()) - 1;
            Console.Write(" y (1-8) = ");
            y1 = Convert.ToInt32(Console.ReadLine()) - 1;

            
            
 /*          if (x - 2 == x1 && y-1 == y1)
            {
                d = true;
            }
            else if(x - 2 == x1 && y + 1 == y1)
            {
                d = true;
            }

            else if (x + 2 == x1 && y - 1 == y1)
            {
                d = true;
            }
            else if (x + 2 == x1 && y + 1 == y1)
            {
                d = true;
            }

            else if (x - 1 == x1 && y - 2 == y1)
            {
                d = true;
            }
            else if (x + 1 == x1 && y - 2 == y1)
            {
                d = true;
            }

            else if (x - 1 == x1 && y + 2 == y1)
            {
                d = true;
            }
            else if (x + 1 == x1 && y + 2 == y1)
            {
                d = true;
            }
*/

            if (Math.Abs(x - x1) == 2 && Math.Abs(y - y1) == 1)
	        {
                d = true;
	        }
            else if (Math.Abs(x - x1) == 1 && Math.Abs(y - y1) == 2)
	        {
                d = true;
	        }
            else
            {
                d = false;
                Console.WriteLine("False");
            }

            if (d == true)
            {
                Console.WriteLine("true");

                for (int i = 0; i < 8; i++)
                {
                    for (int j = 0; j < 8; j++)
                    {
                        if (i == x1 && j == y1)
                        {
                            Console.Write(" K ");
                        }
                        else
                        {
                            Console.Write(" 1 ");
                        }
                    }
                    Console.WriteLine();
                }
            }


        }
    }
}
