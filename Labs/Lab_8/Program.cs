using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Lab_8
{
	class Program
	{
		static void Driving_Animation(){
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
		static void ShowList(Garage garage)
		{
			for(int i = 0; i < garage.cars.Count(); i++)
			{
				Console.WriteLine("{0} - {1}\n\tColor - {2}\n\tSpeed = {3}\n\tYear = {4}\n", i + 1, garage.cars[i].name, garage.cars[i].color, garage.cars[i].speed, garage.cars[i].year);
			}
		}
		static void Main(string[] args)
		{
			Garage garage = new Garage();
			while (true){ 
				Console.WriteLine("What do you want to do?\n" +
									"1 - Add car\n" +
									"2 - Remove Car\n" +
									"3 - Take car by position\n" +
									"4 - Take car by params\n" +
									"5 - Show list of cars\n" +
									"0 = Exit\n");
				int nof = Convert.ToInt32(Console.ReadLine());
				if(nof == 0){
					break;
				}
				switch(nof)
				{
					case 1:
						Car car = new Car();
						Console.Write("Name = ");
						car.name = Console.ReadLine();
						Console.Write("Color = ");
						car.color = Console.ReadLine();
						Console.Write("Speed = ");
						car.speed = Convert.ToInt32(Console.ReadLine());
						Console.Write("Year = ");
						car.year = Convert.ToInt32(Console.ReadLine());
						garage.cars.Add(car);
						break;
					case 2:
						ShowList(garage);
						Console.WriteLine("What car you would like to remove? (position) -> ");
						int rp = Convert.ToInt32(Console.ReadLine());
						garage.cars.RemoveAt(rp - 1);
						break;
					case 3:
						ShowList(garage);
						Console.WriteLine("What car you would like to take?) (position) -> ");
						int tp = Convert.ToInt32(Console.ReadLine());
						if(0 < tp && tp <= garage.cars.Count)
						{
							Driving_Animation();
						Console.SetCursorPosition(Console.BufferWidth, Console.BufferHeight);
						}
						break;
					case 4:
						Garage sort_garage = new Garage();
						ShowList(garage);
						int tbpa;
						do
						{
							Console.Write("How many params? ->");
							tbpa = Convert.ToInt32(Console.ReadLine());
						} while(tbpa > 4);

						for(int i = 0; i < tbpa; i++)
						{
							Console.Write("{0} param -> ", i+1);
							string param = Console.ReadLine();

							switch(param)
							{
								case "Name":
									Console.Write("Name ->");
									string nm = Console.ReadLine();
									for(int j = 0; j < sort_garage.cars.Count; j++)
									{
										if(garage.cars[j].name == nm)
										{
											sort_garage.cars.Add(garage.cars[j]);
										}
									}																				//Не доделано!!!(выбор по параметрам)
									break;
								case "Color":
									Console.Write("Color ->");
									string cl = Console.ReadLine();
									for(int j = 0; j < sort_garage.cars.Count; j++)
									{
										if(garage.cars[j].color == cl)
										{
											sort_garage.cars.Add(garage.cars[j]);
										}
									}
									break;
								case "Speed":
									Console.Write("Speed ->");
									int sp = Convert.ToInt32(Console.ReadLine());
									for(int j = 0; j < sort_garage.cars.Count; j++)
									{
										if(garage.cars[j].speed == sp)
										{
											sort_garage.cars.Add(garage.cars[j]);
										}
									}
									break;
								case "Year":
									Console.Write("Speed ->");
									int yr = Convert.ToInt32(Console.ReadLine());
									for(int j = 0; j < sort_garage.cars.Count; j++)
									{
										if(garage.cars[j].year == yr)
										{
											sort_garage.cars.Add(garage.cars[j]);
										}
									}
									break;
								default:
									break;
							}
						}
						for(int i = 0; i < sort_garage.cars.Count; i++)
						{
							for(int j = i+1; j < sort_garage.cars.Count; j++)
							{
								if(sort_garage.cars[i] == sort_garage.cars[j])
								{
									sort_garage.cars.RemoveAt(j);
								}
							}
						}
						ShowList(sort_garage);
						Console.WriteLine("What car you would like to take?) (position) -> ");
						int tbpat = Convert.ToInt32(Console.ReadLine());
						if(0 < tbpat && tbpat <= sort_garage.cars.Count)
						{
							Driving_Animation();
							Console.SetCursorPosition(Console.CursorLeft, Console.CursorTop + 3);
						}
						break;
					case 5:
						ShowList(garage);
						break;
					default:
						break;
				}
			}
		}
	}
}
