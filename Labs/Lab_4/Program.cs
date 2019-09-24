using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_4
{
    class Program
    {
        static void Main(string[] args)
        {

            int[] mass = new int [15];
            int d = 0, i1 = 0, i2 = 0;

            Random rand = new Random();

            Console.WriteLine();
            for (int i = 0; i < mass.Length; i++)
            {
                mass[i] = rand.Next(0,50);

                Console.Write(" " + mass[i] + " ");
            }

            d = Math.Abs(mass[0] - mass[1]);
            
            for (int i = 0; i < mass.Length - 1; i++)
			{
                if (Math.Abs(mass[i] - mass[i+1]) < d){
                    d = Math.Abs(mass[i] - mass[i+1]);
                    i1 = i;
                    i2 = i+1;
                }
			}

            Console.WriteLine("\n\ni = " + i1 + " I = " + i2 + " Diff = " + d + Environment.NewLine);
/*

            for (int i = 0; i < mass.Length; i++)
			{
                for (int j = i + 1; j < mass.Length; j++)
			    {
			        if (Math.Abs(mass[i] - mass[j]) <= d)
	                {
                        d = Math.Abs(mass[i] - mass[j]);
                        i1 = i;
                        i2 = j;
	                }
			    }
			}


            if (i2 - i1 == 1){
                Console.WriteLine("Elements are side by side");
            }else
	        {
                int[] mes = new int [i2 - i1 - 1];
                int k = 0;
                for (int i = i1+1; i < i2; i++)
			    {
                    mes[k] = mass[i];
                    Console.Write(" " + mes[k]);
			    }
	        }
*/




/*
            for (int i = 0; i < mass.Length; i++)
            {
                for (int j = i; j < mass.Length; j++)
                {
                    if (mass[i] == mass[j])
                    {
                        d++;
                    }
                }
                if (d > max)
                {
                    max = d;
                }
                d = 0;
            }

            Console.WriteLine();

            Console.WriteLine("Max count of the same number = " + max);*/



        }
    }
}
