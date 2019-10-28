using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace Lab_8_1
{

	
	class Garage
	{
		static void Driving_Animation()
		{
			int speed = 116;
			int s = 116;
			string line = new string('~', s);
			Console.WriteLine(line + "\n");

			for(int i = 0; i < s; i++)
			{
				for(int j = 3; j <= i; j++)             //< 1st line
				{
					Console.Write('-');                     //first part
				}

				Console.Write("O--O");

				for(int j = i + 1; j < s; j++)
				{
					Console.Write('-');                     //second part
				}
				Console.WriteLine();                    // >



				for(int j = 3; j <= i; j++)             //< 2nd line
				{
					Console.Write(' ');                     //first part
				}

				Console.Write("[==|=]");

				for(int j = i + 1; j < s - 4; j++)
				{
					Console.Write(' ');                     //second part
				}
				Console.WriteLine();                    // >



				for(int j = 3; j <= i; j++)             //< last line
				{
					Console.Write('-');                     //first part
				}

				Console.Write("O--O");

				for(int j = i + 1; j < s; j++)
				{
					Console.Write('-');                     //second part
				}
				Console.WriteLine();                    // >


				if(i == 0)
				{
					Console.Write("\n" + line);
					Console.SetCursorPosition(Console.CursorLeft = 0, Console.CursorTop - 1);
				}



				Console.SetCursorPosition(Console.CursorLeft = 0, Console.CursorTop - 3);
				Thread.Sleep(speed);
				speed -= 1;

			}

		}

		public List<Car> cars = new List<Car>();
		public void ShowList()
		{
			for(int i = 0; i < cars.Count(); i++)
			{
				Console.WriteLine("{0} - {1}\n\tColor - {2}\n\tSpeed = {3}\n\tYear = {4}\n", i + 1, cars[i].Name, cars[i].Color, cars[i].Speed, cars[i].Year);
			}
		}
		public void AddCar(){
			Car car = new Car();
			car.NewCar();
			cars.Add(car);
		}
		public void RemoveCar(){
			ShowList();
			Console.WriteLine("What car you would like to remove? (position) -> ");
			int rp = Convert.ToInt32(Console.ReadLine());
			cars.RemoveAt(rp - 1);
		}
		public void TakeCarByPos(){
			ShowList();
			Console.WriteLine("What car you would like to take?) (position) -> ");
			int tp = Convert.ToInt32(Console.ReadLine());
			if(0 < tp && tp <= cars.Count())
			{
				Driving_Animation();
				Console.SetCursorPosition(Console.CursorLeft, Console.CursorTop + 5);
			}
		}

		public void TakeCarByProp(){
			List <Car> sort_cars = new List<Car>();
			sort_cars = cars;
			ShowList();
			int tbpa;
			do
			{
				Console.Write("How many params? ->");
				tbpa = Convert.ToInt32(Console.ReadLine());
			} while(tbpa > 4);

			for(int i = 0; i < tbpa; i++)
			{
				Console.Write("{0} param -> ", i + 1);
				string param = Console.ReadLine();

				switch(param)
				{
					case "Name":
						Console.Write("Name -> ");
						string nm = Console.ReadLine();
						for(int j = 0; j < sort_cars.Count; j++)
						{
							if(sort_cars[j].Name != nm)
							{
								sort_cars.RemoveAt(j);
							}
						}
						break;
					case "Color":
						Console.Write("Color -> ");
						string cl = Console.ReadLine();
						for(int j = 0; j < sort_cars.Count; j++)
						{
							if(sort_cars[j].Color != cl)
							{
								sort_cars.RemoveAt(j);
							}
						}
						break;
					case "Speed":
						Console.Write("Speed -> ");
						int sp = Convert.ToInt32(Console.ReadLine());
						for(int j = 0; j < sort_cars.Count; j++)
						{
							if(sort_cars[j].Speed != sp)
							{
								sort_cars.RemoveAt(j);
							}
						}
						break;
					case "Year":
						Console.Write("Year -> ");
						int yr = Convert.ToInt32(Console.ReadLine());
						for(int j = 0; j < sort_cars.Count; j++)
						{
							if(sort_cars[j].Year != yr)
							{
								sort_cars.RemoveAt(j);
							}
						}
						break;
					default:
						break;
				}
			}

			ShowList();
			Console.WriteLine("What car you would like to take?) (position) -> ");
			int tbpat = Convert.ToInt32(Console.ReadLine());
			if(0 < tbpat && tbpat <= sort_cars.Count)
			{
				Driving_Animation();
				Console.SetCursorPosition(Console.CursorLeft, Console.CursorTop + 5);
			}
		}
		
	}

}
