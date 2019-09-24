using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_6
{
    class Program
    {
        static void Main(string[] args)
        {
            
            List<int> list = new List<int>();

            Random rand = new Random();
            int count = 0;

            for (int i = 0; i < 50; i++)
			{
				bool prime = true;
				int number = rand.Next(2,150);
				for (int j = 2; j < number/2; j++)
				{
					if (number % j == 0)
					{
						prime = false;
						break;
					}
				}
				if (prime == true)
				{
					list.Add(number);
					count++;
				}
			}

            foreach (int i in list)
	        {
                Console.Write(i + " ");
	        }

			Console.WriteLine("\n");

			foreach (int val in list.Distinct())
			{
				Console.WriteLine("  {0} = {1}", val, list.Where(x => x == val).Count());
			}

			int [] mass = new int [list.Distinct().Count()]; 
			int cu = 0;

			foreach (int j in list.Distinct())
			{
				mass[cu] = j;
				cu++;
			}

			for (int i = 0; i < mass.Length; i++)
			{
				Console.Write("{0} ", mass[i]);
			}

        }
    }
}
