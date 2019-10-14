using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_7_8
{
	class Program
	{
		static void Reverse_ref(ref char[] mass)
		{
			char[] tmp = new char[mass.Length];
			for(int i = 0, j = tmp.Length - 1; i < mass.Length; i++, j--)
			{
				tmp[i] = mass[j];
			}
			for(int i = 0; i < tmp.Length; i++)
			{
				mass[i] = tmp[i];
			}
		}

		static void Reverse_out(out char[] mass, string g)
		{
			mass = g.ToCharArray();
			char[] tmp = new char[mass.Length];
			for(int i = 0, j = tmp.Length - 1; i < mass.Length; i++, j--)
			{
				tmp[i] = mass[j];
			}
			for(int i = 0; i < tmp.Length; i++)
			{
				mass[i] = tmp[i];
			}
		}
		static void Main(string[] args)
		{

			int nof;

			Console.Write("Enter number of func 1 = ref / 2 = out -> ");
			try
			{
				nof = Convert.ToInt32(Console.ReadLine());
			}
			catch(Exception d)
			{
				Console.WriteLine("\n" + d.Message);
				throw d;
			}

			char[] mass;
			switch(nof)
			{
				case 1:
					mass = Console.ReadLine().ToCharArray();
					Reverse_ref(ref mass);
					Console.WriteLine(mass);
					break;
				case 2:
					string g = Console.ReadLine();	
					Reverse_out(out mass, g);
					Console.WriteLine(mass);
				break;
				default:
					break;
			}
		}
	}
}
