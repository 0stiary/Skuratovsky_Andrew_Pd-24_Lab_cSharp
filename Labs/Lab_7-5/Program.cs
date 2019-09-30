using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace Lab_7_5
{
	class Program
	{

		static void Reverse(int n){

			Console.WriteLine(n.ToString().Reverse().ToArray());
		}
		static void Reverse(string str){

			//char[] s = str.ToCharArray();
			//Array.Reverse(s);
			//str = new string(s);
			//Console.WriteLine(str);

			Console.WriteLine(str.Reverse().ToArray());
		}
		static void Reverse(double d){

			Console.WriteLine(d);

			string[] mass = d.ToString().Split('.');

//			Console.WriteLine(mass[0].GetType());

			for(int i = 0; i < mass.Length; i++)
			{
				//mass[i] = mass[i].ToString().Reverse().ToArray();			почему не работает? -_-
				mass[i] = new string(mass[i].Reverse().ToArray());

			}

			string j = String.Join(".", mass);
			d = Convert.ToDouble(j);
			Console.WriteLine(d);

		}
		static string Reverse(string g, string pattern){
			string[] mass = Regex.Split(g, pattern, RegexOptions.IgnoreCase);
			for(int i = 0; i < mass.Length; i++)
			{
				mass[i] = new string(mass[i].Reverse().ToArray());

				//Console.WriteLine(mass[i]);
			}
			string go = String.Join(".", mass);
			//string pp2 = "\\s+";
			//string dd = Regex.Replace(go, pp2, ".");

			return go;
		}
		static void Main(string[] args)
		{

			Console.WriteLine("What do you want to reverse?\n" +
								"1 - Only int numbers (1234->4321) ?\n" +
								"2 - Any string?\n" +
								"3 - Separate reverse parts of double number (694.326->496.623)?\n" +
								"4 - Separate reverse parts of any string that separate by magic symbol?\n");
			int nof;
			try
			{
				nof = Convert.ToInt32(Console.ReadLine());
			}
			catch(Exception d)
			{
				throw d;
			}
			
			switch(nof)
			{
				case 1:
					Console.Write("Enter your int number -> ");
					int n = Convert.ToInt32(Console.ReadLine());
					Reverse(n);
					break;
				case 2:
					Console.WriteLine("Enter your string \n");
					string str = Console.ReadLine();
					Reverse(str);
					break;
				case 3:
					Console.Write("Enter your double number, separate by - << . >> or << , >> (depends on system type of separeting symbol for double number) -> ");
					double d = Convert.ToDouble(Console.ReadLine());
					Reverse(d);
					break;
				case 4:
					Console.WriteLine("Enter your string separate by magic symbol (all magic symbols will be replaced by << . >> \n");
					string g = Console.ReadLine();
					string pattern = "\\W+";
					Console.WriteLine(Reverse(g,pattern)); 
					break;
				default:
					Console.WriteLine("You enter smth wrong =/");
					break;
			}
		}
	}
}
