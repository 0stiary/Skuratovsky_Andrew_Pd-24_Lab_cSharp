using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_9
{
	class Square : Shape, IDraw
	{
		double side = 0;
		public override double Shape_Square()
		{
			square = side * side;
			return square;
		}
		public override double Shape_Per()
		{
			per = side * 4;
			return per;
		}

		protected Square(string name) : base(name, 4)
		{
			Random rand = new Random();
			side = rand.NextDouble() * rand.Next(1, 100);
		}
		protected Square(string name, double side) : base(name, 4)
		{
			this.side = side;
		}
		protected Square(string name, double side, string color) : base(name, 4, color)
		{
			this.side = side;
		}

		static public Square NewSquare(out Square square)
		{

			bool isSide = false;
			bool isColor = false;
			double side = 0;
			string name;
			string color = null;


			Console.Write("Do you want to set up side length? (y / n(other symbols)) -> ");
			if(Console.ReadLine() == "y")
				isSide = true;

			if(isSide)
			{
				Console.Write("Do you want to set up color? (y / n(other symbols)) -> ");
				if(Console.ReadLine() == "y")
					isColor = true;
			}

			Console.WriteLine();
			do
			{
				Console.Write("Square name -> ");
				name = Console.ReadLine();
			} while(name == string.Empty);


			if(isSide)
			{
				string sside;
				do
				{
					Console.Write("Length of side = ");
					sside = Console.ReadLine();
				} while(Double.TryParse(sside, out side) != true || Convert.ToDouble(sside) < 0);
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
					square = new Square(name, side, color);
					return square;
				}

				square = new Square(name, side);
				return square;
			}

			square = new Square(name);
			return square;
		}

		public override void Show()
		{
			Console.WriteLine(	"Name - {0}\n" +
								"Number of dots = {1}\n" +
								"Side length = {2}\n" +
								"Color - {3}\n" +
								"Perimetr = {4}\n" +
								"Square of shape = {5}\n",
								name, num_dots, side, color, Shape_Per(), Shape_Square()) ;
		}

		public void Draw()
		{
			LetterColor(color);
			Show();
			Console.ResetColor();
		}
	}
}

