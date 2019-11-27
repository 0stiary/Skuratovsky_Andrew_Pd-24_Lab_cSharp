using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_9
{
	class Program
	{
		public static void ListFunction(ref string oopt_list, ref int opt_list, ref Picture picture)
		{
			Console.WriteLine("What do you want to do?\n" +
									"1 - Add element\n" +
									"2 - Remove element by (name/type/more than square)\n" +
									"3 - Take element by pos\n" +
									"4 - Exit(Not availible if you entered length )");
			do
			{
				Console.Write("--> ");
				oopt_list = Console.ReadLine();
			} while(int.TryParse(oopt_list, out opt_list) != true && 1 > opt_list || opt_list > 4);
			switch(opt_list)
			{
				case 1:
				{
					Console.ForegroundColor = ConsoleColor.Red;
					Console.WriteLine(picture.Get_Count());
					Console.ResetColor();

					if(picture.length != default && picture.Get_Count() == picture.length)
					{
						Console.ForegroundColor = ConsoleColor.Red;
						Console.WriteLine("You reached max length of list!! = {0}",picture.Get_Count());
						Console.ResetColor();
						break;
					}
					int option;

					Console.Write("What type of figure do you want to create?\n" +
										"1 - Square\n" +
										"2 - Triangle\n" +
										"3 - Circle\n");
					string ooption;
					do
					{
						Console.Write("--> ");
						ooption = Console.ReadLine();
					} while(int.TryParse(ooption, out option) != true || (1 > option || option > 3));

					switch(option)
					{
						case 1:
						{
							Square square;
							Square.NewSquare(out square);
							picture.AddShape(square);
							
							Console.WriteLine("Show params? (y / (other symbols))");
							if(Console.ReadLine() == "y")
							{
								square.Draw();
								break;
							}
							else{
								break;
							}
						}
						case 2:
						{
							Triangle triangle;
							Triangle.NewTriangle(out triangle);
							picture.AddShape(triangle);
							Console.WriteLine("Show params? (y / (other symbols))");
							if(Console.ReadLine() == "y")
							{
								triangle.Draw();
								break;
							}
							else
							{
								break;
							}
						}

						case 3:
						{
							Circle circle;
							Circle.NewCircle(out circle);
							picture.AddShape(circle);
							Console.WriteLine("Show params? (y / (other symbols))");
							if(Console.ReadLine() == "y")
							{
								circle.Draw();
								break;
							}
							else
							{
								break;
							}
						}
						default:
						break;
					}

					break;
				}
				case 2:
				{
					picture.Show_List();
					picture.DeleteShape();
					break;	
				}
				case 3:
				{
					picture.Show_List();
					Console.WriteLine("What position from 0 to {0}", picture.Get_Count()-1);
					string ppos;
					int pos;
					do
					{
						Console.Write("--> ");
						ppos = Console.ReadLine();
					} while(int.TryParse(ppos, out pos) != true && (pos < 0 || pos > picture.Get_Count()));

					picture[pos].Show();
					break;
				}
				case 4:
				break;
				default:
				Console.WriteLine("Not availible function or number");
				break;
			}
		}

		static void Main(string[] args)
		{
			System.Threading.Thread.CurrentThread.CurrentCulture = new System.Globalization.CultureInfo("en-US");

			

			Console.Write("Do you want to set up length of list of shapes (y / (other symbols))? -->");
			string opt_l = Console.ReadLine(); ;

			string oopt_list = null;
			int opt_list = 0;

			if(opt_l == "y")
			{
				int size;
				do
				{
					Console.Write("Length--> ");
					opt_l = Console.ReadLine();
				} while(int.TryParse(opt_l, out size) != true || Convert.ToInt32(opt_l) <= 0);
				Console.WriteLine();
				Picture picture = new Picture(size);

				do
				{
					ListFunction(ref oopt_list, ref opt_list, ref picture);
				} while(opt_list != 4);
			}
			else 
			{
				Picture picture = new Picture();
				do
				{
					ListFunction(ref oopt_list, ref opt_list, ref picture);
				} while(opt_list != 4);
			}






			
		}
	}
}
