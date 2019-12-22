using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_11_1
{
	class Program
	{
		delegate void myEvent(Visitor visitor);
		static void Main(string[] args)
		{
			Park park = new Park();
			Visitor visitor = new Visitor();
			myEvent eeeeevent = default;


			Console.WriteLine("Roller coater? (y / (other symbols))");
			if(Console.ReadLine() == "y")
				eeeeevent += park.RoolCoaster;

			Console.WriteLine("Fire room? (y / (other symbols))");
			if(Console.ReadLine() == "y")
				eeeeevent += park.ShootTir;

			Console.WriteLine("Fear room? (y / (other symbols))");
			if(Console.ReadLine() == "y")
				eeeeevent += park.Fear;

			Console.WriteLine("Mirror room? (y / (other symbols))");
			if(Console.ReadLine() == "y")
				eeeeevent += park.Mirror;

			Console.WriteLine("Eat popcorn? (y / (other symbols))");
			if(Console.ReadLine() == "y")
				eeeeevent += park.Ckushatcb;

			Console.WriteLine("Ferris wheel? (y / (other symbols))");
			if(Console.ReadLine() == "y")
				eeeeevent += park.Devil;

			eeeeevent.Invoke(visitor);

			Console.WriteLine("Show data? (y / (other symbols))");
			if(Console.ReadLine() == "y")
				visitor.Show();
		}
	}
}
