using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_PPPI_10_2
{
	class Program
	{
		static void Main(string[] args)
		{
			string str;

			Console.Write("String -> ");
			str = Console.ReadLine();

			int c = 0;

			for(int i = 0; i < str.Length; i++)
			{
				if(str[i] != ' ')
				{
					c++;
				}
			}


			Console.WriteLine("In this string {0} symbols(not spaces)", c);
		}
	}
}
