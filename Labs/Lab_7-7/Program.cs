using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_7_7
{
	class Program
	{

		static char[] Reverse_char(char[] mass)
		{
			char[] tmp = new char[mass.Length];
			for(int i = 0, j = tmp.Length - 1; i < mass.Length; i++, j--)
			{
				tmp[i] = mass[j];
			}
			return tmp;
		}
		static void Main(string[] args)
		{
			char[] mass = Console.ReadLine().ToCharArray();

			Console.WriteLine(Reverse_char(mass));
		}
	}
}
