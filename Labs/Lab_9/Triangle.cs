using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_9
{
	class Triangle : Shape , IDraw
	{
		double side = 0;
		public override double Shape_Square()
		{
			square = (Math.Sqrt(3) / 4) * Math.Pow(side, 2.0);
			return square;
		}
		public override double Shape_Per()
		{
			per = side * 3;
			return per;
		}

		protected Triangle(string name) : base(name, 3)
		{
			Random rand = new Random();
			side = rand.NextDouble() * rand.Next(1, 100);
		}
		protected Triangle(string name, double side) : base(name, 3)
		{
			this.side = side;
		}
		protected Triangle(string name, double side, string color) : base(name, 3, color)
		{
			this.side = side;
		}

		static public Triangle NewTriangle(out Triangle triangle)
		{

			bool isSide = false;
			bool isColor = false;
			double side = 0;
			string name;
			string color = null;


			Console.Write("Do you want to set up side length? (y / n(other symbols)) -> ");
			if(Console.ReadLine() == "y")
				isSide = true;

			Console.Write("Do you want to set up color? (y / n(other symbols)) -> ");
			if(Console.ReadLine() == "y")
				isColor = true;

			Console.WriteLine();

			do
			{
				Console.Write("Triangle name -> ");
				name = Console.ReadLine();
			} while(name == string.Empty);


			if(isSide)
			{
				string sside;
				do
				{
					Console.Write("Length of side = ");
					sside = Console.ReadLine();
				} while(Double.TryParse(sside, out side) != true);
			}

			if(isColor)
			{
				do
				{
					Console.Write("Color -> ");
					color = Console.ReadLine();
				} while(color == string.Empty);
			}

			if(isSide)
			{
				if(isColor)
				{
					triangle = new Triangle(name, side, color);
					return triangle;
				}

				triangle = new Triangle(name, side);
				return triangle;
			}

			triangle = new Triangle(name);
			return triangle;
		}

		public void Show()
		{
			Console.WriteLine("Name - {0}\n" +
								"Number of dots = {1}\n" +
								"Side length = {2}\n" +
								"Color - {3}\n" +
								"Perimetr = {4}\n" +
								"Triangle of shape = {5}\n",
								name, num_dots, side, color, Shape_Per(), Shape_Square());
		}

		public void Draw()
		{
			;
			LetterColor(color);
			Show();
			Console.ResetColor();
		}
	}
}
