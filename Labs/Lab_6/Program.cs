using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_6
{
	class Program
	{
		static void Main(string[] args)
		{

			List<int> list = new List<int>();

			Random rand = new Random();
			int count = 0;

			for(int i = 0; i < 50; i++)
			{
				bool prime = true;
				int number = rand.Next(2, 150);
				for(int j = 2; j < number / 2; j++)
				{
					if(number % j == 0)
					{
						prime = false;
						break;
					}
				}
				if(prime == true)
				{
					list.Add(number);
					count++;
				}
			}

			/*           foreach (int i in list)
					   {
						   Console.Write(i + " ");
					   }
		   */
			for(int i = 0; i < list.Count; i++)
			{
				Console.Write(list[i] + " ");
			}
			Console.WriteLine("\n");

			//foreach(int val in list.Distinct())
			//{
			//	Console.WriteLine("  {0} = {1}", val, list.Where(x => x == val).Count());
			//}

			Console.WriteLine();

			for(int i = 0; i < list.Count; i++)
			{
				for(int j = i + 1; j < list.Count; j++)
				{
					if(list[i] > list[j])
					{
						int tmp = list[i];                          //Сортировка массива по возростанию
						list[i] = list[j];
						list[j] = tmp;
					}
				}
			}

			for(int i = 0; i < list.Count; i++)
			{
				Console.Write(list[i] + " ");
			}

			Console.WriteLine();
			for(int i = 0; i < list.Count; i++)
			{
				int c = 0;
				for(int j = 0; j < list.Count; j++)
				{
					if(list[i] == list[j])
					{
						c++;
					}
				}
				Console.WriteLine("  {0} = {1}", list[i], c);       //Вывод сколько одинаковых элементов в массиве
			}

			for(int i = 0; i < list.Count - 1; i++)
			{
				if(list[i] == list[i + 1])
				{
					list.RemoveAt(i + 1);
				}
			}


			//int[] mass = new int[list.Distinct().Count()];
			//int cu = 0;


			//foreach(int j in list.Distinct())
			//{
			//	mass[cu] = j;
			//	cu++;
			//}
			int[] mass = new int[list.Count];
			for(int i = 0; i < list.Count; i++)
			{
				mass[i] = list[i];
				Console.Write("{0} ", mass[i]);
			}

		}
	}
}
