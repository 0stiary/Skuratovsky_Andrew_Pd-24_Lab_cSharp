using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;


namespace Lab_PPPI_10_3
{
	class Program
	{
		static void Main(string[] args)
		{

			string str;
			Console.Write("String -> ");
			str = Console.ReadLine();

			char[] mass = str.ToCharArray();


			if(mass[0] == ' ' && mass[1] != ' ')
			{
				mass[0] = '%';
			}

			for(int i = 1; i < mass.Count()-1; i++)
			{
				
				if(mass[i-1]
				!= ' ' && mass[i] == ' ' && mass[i+1] != ' ')
				{
					mass[i] = '%';
				}
			}

			if(mass[mass.Count()-2] != ' ' && mass[mass.Count() - 1] == ' ')
			{
				mass[mass.Count() - 1] = '%';
			}

			str = new string(mass);
			str = Regex.Replace(str, "[ ]+", " ");
			Console.WriteLine(str);
		}
	}
}
