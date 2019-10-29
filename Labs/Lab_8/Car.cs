using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_8_1
{
	class Car
	{
		protected string name;
		protected string color;
		protected int speed;
		protected int year;

		public string Name { get { return name; }}
		public string Color { get { return color; }}
		public int Speed { get { return speed; }}
		public int Year { get { return year; }}

		public void NewCar(){
			Console.Write("Name = ");
			name = Console.ReadLine();
			Console.Write("Color = ");
			color = Console.ReadLine();
			Console.Write("Speed = ");
			speed = Convert.ToInt32(Console.ReadLine());
			Console.Write("Year = ");
			year = Convert.ToInt32(Console.ReadLine());
		}

	}
}	

