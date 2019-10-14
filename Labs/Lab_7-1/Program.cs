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
			Console.Write("Enter your number to reverse -> ");
			long n = Convert.ToInt64(Console.ReadLine());

			Console.Write(n % 10);

			while((n /= 10) != 0)
			{
				Console.Write(n % 10);
			}

			//Console.WriteLine(n.ToString().Reverse().ToArray());



		}
	}
}
