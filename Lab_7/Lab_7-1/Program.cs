using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_7_1
{
	class Program
	{
		static void Main(string[] args)
		{
			int n =Convert.ToInt32(Console.ReadLine()); ;

			Console.WriteLine(n.ToString().Reverse().ToArray());

		}
	}
}
