using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace Lab_7_6
{
	class Program
	{

		static string Reverse(char[] mass, int it)
		{

			//Console.WriteLine(n.ToString().Reverse().ToArray());

			if(it < mass.Length / 2)
			{
				char buff = mass[it];
				mass[it] = mass[mass.Length - it - 1];
				mass[mass.Length - it - 1] = buff;

				it++;

				Reverse(mass, it);
			}
			string g = new string(mass);
			return g;
		}
		static string Reverse(char[] s, char[] tmp, int it, int j)
		{

			//char[] s = str.ToCharArray();
			//Array.Reverse(s);
			//str = new string(s);
			//Console.WriteLine(str);
			if(it < s.Length)
			{
				tmp[it] = s[j];
				it++;
				j--;
				Reverse(s, tmp, it, j);
			}


			string str = new string(tmp);
			return str;
			//Array.Reverse(s);
		}
		static double Reverse(bool dot, string[] mass, int it)
		{

			if(it < mass.Length)
			{
				//mass[i] = mass[i].ToString().Reverse().ToArray();			почему не работает? -_-

				char[] s = mass[it].ToCharArray();                           //Перевод части числа в массив чаров
				char[] tmp = new char[s.Length];                            //Вспомогательный массив

				for(int p = 0, g = tmp.Length - 1; p < s.Length; p++, g--)
				{
					tmp[p] = s[g];                                          //Разворот 
				}

				mass[it] = new string(tmp);                                  //Перенос развёрнутой части
				it++;

				Reverse(dot, mass, it);
			}
			double dou = 0;
			if(dot == true)
			{
				string str = String.Join(".", mass);                            //Соеденение числа обратно через точку
				dou = Convert.ToDouble(str);
			}
			else if(dot == false)
			{
				string str = String.Join(",", mass);                            //Соеденение числа обратно через запятую
				dou = Convert.ToDouble(str);
			}

			return dou;
		}
		static string Reverse(string[] mass, string pattern, int it)
		{
			if(it < mass.Length)
			{

				char[] s = mass[it].ToCharArray();                           //Перевод части строки в массив чаров
				char[] tmp = new char[s.Length];                            //Вспомогательный массив

				for(int p = 0, j = tmp.Length - 1; p < s.Length; p++, j--)
				{
					tmp[p] = s[j];                                          //Разворот
				}

				mass[it] = new string(tmp);                                  //Перенос развёрнутой части

				//mass[it] = new string(mass[it].Reverse().ToArray());
				it++;
				Reverse(mass, pattern, it);

				//Console.WriteLine(mass[i]);
			}

			string go = String.Join(".", mass);

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
			int it = 0;
			string pattern;
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
					char[] int_mass = n.ToString().ToArray();
					it = 0;
					Console.WriteLine(Reverse(int_mass, it));
					break;
				case 2:
					Console.WriteLine("Enter your string \n");
					string str = Console.ReadLine();

					char[] s = str.ToCharArray();
					char[] tmp = new char[s.Length];
					it = 0;
					int j = tmp.Length - 1;
					Console.WriteLine(Reverse(s, tmp, it, j));
					break;
				case 3:
					Console.Write("Enter your double number, separate by - << . >> or << , >> (depends on system type of separeting symbol for double number) -> ");
					double dou = Convert.ToDouble(Console.ReadLine());

					bool dot = false;
					char[] vs = dou.ToString().ToCharArray();
					for(int i = 0; i < vs.Length; i++)
					{
						if(vs[i] == '.')
						{
							dot = true;
						}
						else if(vs[i] == ',')
						{
							dot = false;
						}
					}
					Console.WriteLine(dou);

					pattern = "[\\.\\,]";
					string stos = dou.ToString();

					string[] dou_mass = Regex.Split(stos, pattern, RegexOptions.IgnoreCase);                        //Разделить число на две части
					it = 0;


					Console.WriteLine(Reverse(dot, dou_mass, it));
					break;
				case 4:
					Console.WriteLine("Enter your string separate by magic symbol (all magic symbols will be replaced by << . >> \n");

					string g = Console.ReadLine();
					pattern = "\\W+";
					string[] str_mass = Regex.Split(g, pattern, RegexOptions.IgnoreCase);
					it = 0;

					Console.WriteLine(Reverse(str_mass, pattern, it));
					break;
				default:
					Console.WriteLine("You enter smth wrong =/");
					break;
			}
		}
	}
}
