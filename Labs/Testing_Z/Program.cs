using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Testing_Z
{
	public delegate void Event();
	class Program
	{
		static void Main(string[] args)
		{
			Car car = new Car();

			//car.MaxSize += () => { Console.WriteLine("Public Taxi is overfull =)"); };

			for(int i = 0; i < car.seats; i++)
			{
				Console.WriteLine("New passenger? (y / (other symbols))");
				if(Console.ReadLine() == "y")
				{
					Passenger passenger = new Passenger();
					do
					{
						Console.Write("Name -> ");
						passenger.name = Console.ReadLine();

					} while(passenger.name == string.Empty);
					car.AddPass(passenger);
				}
				else
				{
					car.Show();
					break;
				}
			}


			Console.ReadLine();
			Console.ReadLine();
		}
	}
}
