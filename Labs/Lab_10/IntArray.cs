using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_10
{
	class IntArray
	{

		protected int[] mass;
		public void NewIntArray()
		{
			List<int> list = new List<int>();

			int d, s = 1;
			string sd;

			Console.WriteLine("\nEnter numbers to int array (-606 = exit for input)");

			do
			{
				do
				{
					Console.Write("{0} -->", s);
					sd = Console.ReadLine();
				} while(int.TryParse(sd, out d) != true);
				list.Add(d);
				s++;
			} while(d != -606);

			mass = list.ToArray();
		}

		public void ShowArray()
		{
			Console.WriteLine("\nArray --> ");

			for(int i = 0; i < mass.Length; i++)
			{
				Console.Write(" {0} ", mass[i]);
			}
		}
		public void ShowByPos(int i)
		{
			Console.Write(" {0} ", mass[i]);
		}

		public int GetSizeArray(){
			return mass.Length;
		}
	}
}
