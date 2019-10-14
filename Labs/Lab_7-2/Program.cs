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

			char[] s = str.ToCharArray();
			char[] tmp = new char[s.Length];
			for(int i = 0, j = tmp.Length - 1; i < s.Length; i++, j--)
			{
				tmp[i] = s[j];
			}
			//Array.Reverse(s);
			str = new string(tmp);
			Console.WriteLine(str);

			//Console.WriteLine(str.Reverse().ToArray());
		}
	}
}
