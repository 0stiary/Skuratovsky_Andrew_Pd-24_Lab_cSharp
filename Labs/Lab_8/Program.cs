using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Lab_8_1
{
	class Program
	{
		
		
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
				Console.Write("-> ");
				int nof = Convert.ToInt32(Console.ReadLine());
				Console.WriteLine();
				if(nof == 0){
					break;
				}
				switch(nof)
				{
					case 1:
						garage.AddCar();
						break;
					case 2:
						garage.RemoveCar();
						break;
					case 3:
					garage.TakeCarByPos();
						break;
					case 4:
						garage.TakeCarByProp();
						break;
					case 5:
						garage.ShowList();
						break;
					default:
						break;
				}
			}
		}
	}
}
