using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace Lab_7_3
{
	class Program
	{
		static void Main(string[] args)
		{
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

			string pattern = "[\\.\\,]";
			string stos = dou.ToString();
			
			string[] mass = Regex.Split(stos, pattern, RegexOptions.IgnoreCase);						//Разделить число на две части

			//string[] mass = dou.ToString().Split();						//Разделить число на две части
			//Console.WriteLine(mass[0].GetType());							//Получить тип части массива mass (Debug)

			for(int i = 0; i < mass.Length; i++)
			{
				//mass[i] = mass[i].ToString().Reverse().ToArray();			почему не работает? -_-

				char[] s = mass[i].ToCharArray();							//Перевод части числа в массив чаров
				char[] tmp = new char[s.Length];							//Вспомогательный массив

				for(int p = 0, g = tmp.Length - 1; p < s.Length; p++, g--)
				{
					tmp[p] = s[g];											//Разворот 
				}

				mass[i] = new string(tmp);									//Перенос развёрнутой части

			}

			if(dot == true)
			{
				string str = String.Join(".", mass);							//Соеденение числа обратно через точку
				dou = Convert.ToDouble(str);
			}
			else if(dot == false)
			{
				string str = String.Join(",", mass);                            //Соеденение числа обратно через запятую
				dou = Convert.ToDouble(str);
			}

			Console.WriteLine(dou);
		}
	}
}
