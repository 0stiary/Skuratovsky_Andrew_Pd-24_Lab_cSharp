using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_PPPI_10_1
{
	class Program
	{
		static void Main(string[] args)
		{

			int[] mass = new int[10];
			int temp;

			Console.WriteLine("Set up 10 integer numbers to sort them ascending");

			for(int i = 0; i < mass.Length; i++)
			{
				string iint;
				do
				{
					Console.Write("{0} = ", i+1);
					iint= Console.ReadLine();
				} while(int.TryParse(iint, out mass[i]) != true);
			}

			for(int i = 0; i < mass.Length - 1; i++)
			{
				for(int j = 0; j < mass.Length - i - 1; j++)
				{
					if(mass[j + 1] < mass[j])
					{
						temp = mass[j + 1];
						mass[j + 1] = mass[j];
						mass[j] = temp;
					}
				}
			}

			for(int i = 0; i < mass.Length; i++)
			{
				Console.Write("   {0}  |", mass[i]);
			}
		}
	}
}
