using System;
using System.Collections.Generic;
using System.Threading;
using System.Drawing;
using System.Linq;

namespace Testing
{
	class Program
	{
		static void Main(string[] args)
		{
			Console.Clear();
			Random rd = new Random();

			double r;

			do
			{
				Console.Write("Enter radius of circle : ");
				if(!double.TryParse(Console.ReadLine(), out r) || r <= 0)
				{
					Console.WriteLine("Invalid radius, try again");
				}
			}
			while(r <= 0);

			Console.WriteLine();
			bool fill = false;
			string input;

			do
			{
				Console.Write("Do you want to fill the circle  y/n : ");
				input = Console.ReadLine().ToLower();
				if(input != "y" && input != "n")
				{
					Console.WriteLine("Invalid reply, try again");
				}
				else if(input == "y")
				{
					fill = true;
				}
			}
			while(input != "y" && input != "n");

			Console.WriteLine();





			
			double r_in = r - 0.4;
			double r_out = r + 0.4;

			Console.ForegroundColor = (ConsoleColor)rd.Next(16);
			for(double y = r; y >= -r; --y)
			{




				for(double x = -r; x < r_out; x += 0.5)
				{
					double value = x * x + y * y;

					if(value >= r_in * r_in && value <= r_out * r_out)
					{

						Console.Write("*");
					}
					else if(fill && value < r_in * r_in && value < r_out * r_out)
					{
						Console.Write("*");
					}
					else
					{
						Console.Write(" ");
					}
				}

				Console.WriteLine();
			}

			Console.ReadKey();
		}
	}
}