using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_7_3
{
	class Program
	{
		static void Main(string[] args)
		{
			double d = Convert.ToDouble(Console.ReadLine());

			Console.WriteLine(d);

			string[] mass = d.ToString().Split('.');

			Console.WriteLine(mass[0].GetType());

			for(int i = 0; i < mass.Length; i++)
			{
				//mass[i] = mass[i].ToString().Reverse().ToArray();			почему не работает? -_-
				mass[i] = new string(mass[i].Reverse().ToArray());

			}

			string j = String.Join(".", mass);
			d = Convert.ToDouble(j);
			Console.WriteLine(d);
		}
	}
}
