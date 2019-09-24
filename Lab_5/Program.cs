using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_5
{
    class Program
    {
        static void Main(string[] args)
        {
            int[,] mass = new int[10, 5];

            Random rand = new Random();
            for (int i = 0; i < 10; i++)
            {
                for (int j = 0; j < 5; j++)
                {
                    mass[i, j] = rand.Next(-1000,1000);
                }

            }
/*
            mass[5,0] = 1;                    Тесты
            mass[5,1] = 6;
            mass[5,2] = 10;
            mass[5,3] = 21;
            mass[5,4] = 44;

            mass[2,0] = 50;
            mass[2,1] = 33;
            mass[2,2] = -19;
            mass[2,3] = -40;
            mass[2,4] = -56;

            mass[0,4] = -156;
            mass[1,4] = -105;
            mass[2,4] = -56;
            mass[3,4] = 4;
            mass[4,4] = 13;
            mass[5,4] = 44;
            mass[6,4] = 52;
            mass[7,4] = 77;
            mass[8,4] = 93;
            mass[9,4] = 100;

            mass[0,1] = 67;
            mass[1,1] = 55;
            mass[2,1] = 33;
            mass[3,1] = 11;
            mass[4,1] = 7;
            mass[5,1] = 6;
            mass[6,1] = 0;
            mass[7,1] = -87;
            mass[8,1] = -120;
            mass[9,1] = -1000;
*/

            for (int i = 0; i < 10; i++)
            {
                for (int j = 0; j < 5; j++)
                {
                    Console.Write(mass[i,j] + "\t");
                }

                Console.WriteLine();
            }

            Console.WriteLine();
            
            
            Console.WriteLine("Rows that increase = ");

            for (int i = 0; i < 10; i++)
			{
                int tr = 1;

                for (int j = 0; j < 5 - 1; j++)
			    {
			        if (mass[i,j] < mass[i, j+1])
                    {
                        tr ++;
                    }else{
                        tr = 1;
                    }
			    }

                if (tr == 5)
	            {
                    for (int z = 0; z < 5; z++)
			        {
                        Console.Write("\t" + mass[i,z]);
			        }
                    Console.WriteLine();
	            }
			}


            Console.WriteLine("Rows that decrease = ");

            for (int i = 0; i < 10; i++)
			{
                int tr = 1;

                for (int j = 0; j < 5 - 1; j++)
			    {
			        if (mass[i,j] > mass[i, j+1])
                    {
                        tr ++;
                    }else{
                        tr = 1;
                    }
			    }

                if (tr == 5)
	            {
                    for (int z = 0; z < 5; z++)
			        {
                        Console.Write("\t" + mass[i,z]);
			        }
                    Console.WriteLine();
	            }
			}

            Console.WriteLine("Columns that increase = ");

            for (int i = 0; i < 5; i++)
			{
                int tr = 1;

                for (int j = 0; j < 10-1; j++)
			    {
			        if (mass[j,i] < mass[j+1,i])
	                {
                        tr++;
	                }else{
                        tr = 1;
                    }
			    }

                if (tr == 10)
	            {
                    for (int z = 0; z < 10; z++)
			        {
                        Console.Write("\t" + mass[z,i]);
			        }
                    Console.WriteLine();
	            }
			}

            Console.WriteLine("Columns that decrease = ");

            for (int i = 0; i < 5; i++)
			{
                int tr = 1;

                for (int j = 0; j < 10-1; j++)
			    {
			        if (mass[j,i] > mass[j+1,i])
	                {
                        tr++;
	                }else{
                        tr = 1;
                    }
			    }

                if (tr == 10)
	            {
                    for (int z = 0; z < 10; z++)
			        {
                        Console.Write("\t" + mass[z,i]);
			        }
                    Console.WriteLine();
	            }
			}

            //Не дороблено!
        }
    }
}
