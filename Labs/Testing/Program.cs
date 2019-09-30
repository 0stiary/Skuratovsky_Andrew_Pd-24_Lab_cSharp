using System;
using System.Collections.Generic;

namespace Lab_6
{
	class Program
	{
		static void Main(string[] args)
		{
			/*
             6.Створити ліст інтових змінних, який може вміщати тільки 1 і 0,
             заповнити його з клавіатури. Порахувати кількість 1 і 0. Скопіювати
             отриманий ліст в масив.
             */
			int n;

			do
			{
				Console.Write("Enter number of elements in list: ");
				n = Convert.ToInt32(Console.ReadLine());
				if(n <= 0)
				{
					Console.WriteLine("Incorrect number of elements. Try again");
				}
			} while(n <= 0);
			List<int> myInts = new List<int>();
			int a;

			
			for(int i = 0; i < n; )
			{

				Console.Write("Enter {0} element = ", (i + 1));
				a = Convert.ToInt32(Console.ReadLine());

				if(a == 1 || a == 0)
				{
					myInts.Add(a);
					i++;
				}
				else
				{
					Console.WriteLine("Incorrect data. Might be only \"0\" or \"1\". Try again");
				}
			}

			int counterZero = myInts.BinarySearch(0);
			Console.WriteLine("In tris List are {0} \"0\" and {1} \"1\"", counterZero, n - counterZero);


			Console.ReadLine();
		}
	}
}