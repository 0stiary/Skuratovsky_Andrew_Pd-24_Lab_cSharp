using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Testing_Z
{
	class Car
	{
		public int seats { get; set; }
		public List<Passenger> passengers = new List<Passenger>();
		public event Event MaxSize = () => { Console.WriteLine("Public Taxi is overfull =)"); };

		public Car() {
			Random rand = new Random();
			//seats = rand.Next(12, 33);
			seats = 4;
		}

		public void AddPass(Passenger passenger) {
			passengers.Add(passenger);
			if(passengers.Count() == seats)
			{
				MaxSize.Invoke();
				ShowLast3Pass();
			}
		}

		private void ShowLast3Pass()
		{
			Console.WriteLine(	"Passenger {0} \t Name = {1}\n" +
								"Passenger {2} \t Name = {3}\n" +
								"Passenger {4} \t Name = {5}",
								passengers.Count - 2, passengers[passengers.Count - 3].name,
								passengers.Count - 1, passengers[passengers.Count - 2].name,
								passengers.Count, passengers[passengers.Count - 1].name);
		}

		public void Show(){
			for(int i = 0; i < passengers.Count(); i++)
			{
				Console.WriteLine("Passenger {0} \t Name = {1}", i+1, passengers[i].name);
			}
		}
	}
}
