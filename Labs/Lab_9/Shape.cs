using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_9
{
	abstract class Shape
	{
		public string color { get; set; }
		public int num_dots { get; }
		public string name { get; }
		public double per { get; set; }
		public double square { get; set; }
		public abstract double Shape_Square();
		public abstract double Shape_Per();
		public abstract void Show();

		string[] colors = { "Black", "Blue", "Cyan", "DarkBlue", "DarkCyan", "DarkGray", "DarkGreen", "DarkMagenta", "DarkRed", "DarkYellow",
			"Gray","Green","Magenta","Red","White","Yellow"};
		protected Shape(string name, int num_dots)
		{
			this.name = name;
			this.num_dots = num_dots;
			Random rndm = new Random();
			color = colors[rndm.Next(0, colors.Length)];
		}
		protected Shape(string name, int num_dots, string color)
		{
			this.name = name;
			this.num_dots = num_dots;
			this.color = color;
		}

		protected void LetterColor(string color)
		{
			switch(color)
			{
				case "Black":
				{
					Console.ForegroundColor = ConsoleColor.Black;
					Console.BackgroundColor = ConsoleColor.White;
					break;
				}
				case "Blue":
				{
					Console.ForegroundColor = ConsoleColor.Blue;
					break;
				}
				case "Cyan":
				{
					Console.ForegroundColor = ConsoleColor.Cyan;
					break;
				}
				case "DarkBlue":
				{
					Console.ForegroundColor = ConsoleColor.DarkBlue;
					break;
				}
				case "DarkCyan":
				{
					Console.ForegroundColor = ConsoleColor.DarkCyan;
					break;
				}
				case "DarkGray":
				{
					Console.ForegroundColor = ConsoleColor.DarkGray;
					break;
				}
				case "DarkGreen":
				{
					Console.ForegroundColor = ConsoleColor.DarkGreen;
					break;
				}
				case "DarkMagenta":
				{
					Console.ForegroundColor = ConsoleColor.DarkMagenta;
					break;
				}
				case "DarkRed":
				{
					Console.ForegroundColor = ConsoleColor.DarkRed;
					break;
				}
				case "DarkYellow":
				{
					Console.ForegroundColor = ConsoleColor.DarkYellow;
					break;
				}
				case "Gray":
				{
					Console.ForegroundColor = ConsoleColor.Gray;
					break;
				}
				case "Green":
				{
					Console.ForegroundColor = ConsoleColor.Green;
					break;
				}
				case "Magenta":
				{
					Console.ForegroundColor = ConsoleColor.Magenta;
					break;
				}
				case "Red":
				{
					Console.ForegroundColor = ConsoleColor.Red;
					break;
				}
				case "White":
				{
					Console.ForegroundColor = ConsoleColor.White;
					break;
				}
				case "Yellow":
				{
					Console.ForegroundColor = ConsoleColor.Yellow;
					break;
				}

				default:
				{
					Console.WriteLine("There is no such color in lib of C# =). Will be set up standart color)))");
					Console.ForegroundColor = ConsoleColor.White;
					break;
				}
			}

		}

	}
}
