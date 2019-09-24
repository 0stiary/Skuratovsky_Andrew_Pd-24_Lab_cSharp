using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_7_2
{
	class Program
	{
		static void Main(string[] args)
		{
			string str = Console.ReadLine();

			//char[] s = str.ToCharArray();
			//Array.Reverse(s);
			//str = new string(s);
			//Console.WriteLine(str);

			Console.WriteLine(str.Reverse().ToArray());
		}
	}
}
