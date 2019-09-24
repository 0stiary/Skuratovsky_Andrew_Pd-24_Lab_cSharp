using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace Lab_7_4
{
	class Program
	{
		static void Main(string[] args)
		{
			string g = Console.ReadLine();
			string pattern = "\\W+";
			string[] mass = Regex.Split(g, pattern, RegexOptions.IgnoreCase);
			for(int i = 0; i < mass.Length; i++)
			{
				mass[i] = new string(mass[i].Reverse().ToArray());

				//Console.WriteLine(mass[i]);
			}
			string go = String.Join(".", mass);
			//string pp2 = "\\s+";
			//string dd = Regex.Replace(go, pp2, ".");

			Console.WriteLine(go);
		}
	}
}
