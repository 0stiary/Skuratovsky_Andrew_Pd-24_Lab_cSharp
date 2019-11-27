using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_9
{
	class Circle : Shape, IDraw
	{

		double rad = 0;
		public override double Shape_Square()
		{
			square = Math.PI * (Math.Pow(rad, 2.0));
			return square;
		}
		public override double Shape_Per()
		{
			per = 2 * Math.PI * rad;
			return per;
		}

		protected Circle(string name) : base(name, 0)
		{
			Random rand = new Random();
			rad = rand.NextDouble() * rand.Next(1, 50);
		}
		protected Circle(string name, double rad) : base(name, 0)
		{
			this.rad = rad;
		}
		protected Circle(string name, double rad, string color) : base(name, 0, color)
		{
			this.rad = rad;
		}

		static public Circle NewCircle(out Circle circle)
		{

			bool isRad = false;
			bool isColor = false;
			double rad = 0;
			string name;
			string color = null;


			Console.Write("Do you want to set up radius? (y / n(other symbols)) -> ");
			if(Console.ReadLine() == "y")
				isRad = true;


			if (isRad){
				Console.Write("Do you want to set up color? (y / n(other symbols)) -> ");
				if(Console.ReadLine() == "y")
					isColor = true;
			}
			

			Console.WriteLine();

			do
			{
				Console.Write("Name -> ");
				name = Console.ReadLine();
			} while(name == string.Empty);


			if(isRad)
			{
				string sside;
				do
				{
					Console.Write("Radius = ");
					sside = Console.ReadLine();
				} while(Double.TryParse(sside, out rad) != true || Convert.ToDouble(sside) < 0);
			}

			if(isColor)
			{
				do
				{
					Console.Write("Color -> ");
					color = Console.ReadLine();
				} while(color == string.Empty);
			}

			if(isRad)
			{
				if(isColor)
				{
					circle = new Circle(name, rad, color);
					return circle;
				}

				circle = new Circle(name, rad);
				return circle;
			}

			circle = new Circle(name);
			return circle;
		}

		public override void Show()
		{
			Console.WriteLine("Name - {0}\n" +
								"Number of dots = {1}\n" +
								"Radius = {2}\n" +
								"Color - {3}\n" +
								"Perimetr = {4}\n" +
								"Square of shape = {5}\n",
								name, num_dots, rad, color, Shape_Per(), Shape_Square());
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
