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

			Console.Write(n % 10);

			while((n /= 10) != 0)
			{
				Console.Write(n % 10);
			}
		}
		static void Reverse(string str){

			//char[] s = str.ToCharArray();
			//Array.Reverse(s);
			//str = new string(s);
			//Console.WriteLine(str);

			char[] s = str.ToCharArray();
			char[] tmp = new char[s.Length];
			for(int i = 0, j = tmp.Length - 1; i < s.Length; i++, j--)
			{
				tmp[i] = s[j];
			}
			//Array.Reverse(s);
			str = new string(tmp);
			Console.WriteLine(str);
		}
		static void Reverse(double dou){

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

			string pattern = "[\\.\\,]";
			string stos = dou.ToString();

			string[] mass = Regex.Split(stos, pattern, RegexOptions.IgnoreCase);                        //Разделить число на две части

			//string[] mass = dou.ToString().Split();						//Разделить число на две части
			//Console.WriteLine(mass[0].GetType());							//Получить тип части массива mass (Debug)

			for(int i = 0; i < mass.Length; i++)
			{
				//mass[i] = mass[i].ToString().Reverse().ToArray();			почему не работает? -_-

				char[] s = mass[i].ToCharArray();                           //Перевод части числа в массив чаров
				char[] tmp = new char[s.Length];                            //Вспомогательный массив

				for(int p = 0, g = tmp.Length - 1; p < s.Length; p++, g--)
				{
					tmp[p] = s[g];                                          //Разворот 
				}

				mass[i] = new string(tmp);                                  //Перенос развёрнутой части

			}

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

			Console.WriteLine(dou);

		}
		static string Reverse(string g, string pattern){
			string[] mass = Regex.Split(g, pattern, RegexOptions.IgnoreCase);

			for(int i = 0; i < mass.Length; i++)
			{

				char[] s = mass[i].ToCharArray();                           //Перевод части строки в массив чаров
				char[] tmp = new char[s.Length];                            //Вспомогательный массив

				for(int p = 0, j = tmp.Length - 1; p < s.Length; p++, j--)
				{
					tmp[p] = s[j];                                          //Разворот
				}

				mass[i] = new string(tmp);                                  //Перенос развёрнутой части

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

			Console.Write("Enter number of func -> ");
			try
			{
				nof = Convert.ToInt32(Console.ReadLine());
			}
			catch(Exception d)
			{
				Console.WriteLine("\n"+ d.Message);
				throw d;
			}
			
			switch(nof)
			{
				case 1:
					Console.Write("Enter your int number -> ");
					long n = Convert.ToInt64(Console.ReadLine());
					Reverse(n);
					break;
				case 2:
					Console.WriteLine("Enter your string \n");
					string str = Console.ReadLine();
					Reverse(str);
					break;
				case 3:
					Console.Write("Enter your double number, separate by - << . >> or << , >> (depends on system type of separeting symbol for double number) -> ");
					double dou = Convert.ToDouble(Console.ReadLine());
					Reverse(dou);
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
