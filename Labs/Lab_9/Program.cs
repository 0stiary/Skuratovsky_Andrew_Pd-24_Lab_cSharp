using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_9
{
	class Program
	{
		static void Main(string[] args)
		{
			System.Threading.Thread.CurrentThread.CurrentCulture = new System.Globalization.CultureInfo("en-US");
			int option;

			Console.Write("What type of figure do you want to create?\n" +
								"1 - Square\n" +
								"2 - Triangle\n" +
								"3 - Circle\n");
			string ooption;
			do
			{
				Console.Write("--> ");
				ooption = Console.ReadLine();
			} while(int.TryParse(ooption, out option) != true && 1 > option || option > 3);

			switch(option)
			{
				case 1:
				{
					Square square;
					Square.NewSquare(out square);
					square.Draw();
					break;
				}
				case 2:
				{
					Triangle triangle;
					Triangle.NewTriangle(out triangle);
					triangle.Draw();
					break;
				}

				case 3:
				{
					Circle circle;
					Circle.NewCircle(out circle);
					circle.Draw();
					break;
				}
				default:
				break;
			}
		}
	}
}
