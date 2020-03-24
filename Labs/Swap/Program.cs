using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Swap
{
	class Program
	{
		static void Main(string[] args)
		{
			int[] mass = { 156, 876 };
			int[] prev = { 000076454545, 1245646, 087625 };


			(prev[1], mass[0]) = (mass[0], prev[1]);

			Console.WriteLine("\n\nmass - {0}\t{1}\nprev - {2}\t{3}\t{4}", mass[0], mass[1], prev[0], prev[1], prev[2]);
		}
	}
}
