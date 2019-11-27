using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_9
{
	class Picture
	{
		private List<Shape> list_of_shapes { get; set; }
		public int length{ get; set; }

		public Picture()
		{
			list_of_shapes = new List<Shape>();
		}
		public Picture(int length)
		{
			this.length = length;
			list_of_shapes = new List<Shape>(this.length);
		}

		public void AddShape(Shape shape)
		{
			list_of_shapes.Add(shape);
		}

		public void DeleteShape()
		{
			Console.WriteLine("\tBy what do you want to delete?\n" +
								"\t1) Name\n" +
								"\t2) Type\n" +
								"\t3) By square that more than you want to\n");
			Console.Write("--> ");
			string oopt;
			int opt;
			do
			{
				oopt = Console.ReadLine();
			} while(int.TryParse(oopt, out opt) != true || (opt < 0 || opt > 3));

			switch(opt)
			{
				case 1:
				{
					Console.Write("Name --> ");
					string no_name = Console.ReadLine();
					for(int i = 0; i < list_of_shapes.Count(); i++)
					{
						if(list_of_shapes[i].name == no_name)
						{
							list_of_shapes.RemoveAt(i);
						}
					}
					break;
				}
				case 2:
				{
					for(int i = 0; i < list_of_shapes.Count(); i++)
					{
						Console.WriteLine("----------> {0} = {1}", i, list_of_shapes[i].GetType().ToString());
					}
					Console.Write("Type --> ");
					string no_type = Console.ReadLine();
					for(int i = 0; i < list_of_shapes.Count(); i++)
					{
						if(list_of_shapes[i].GetType().ToString() == "Lab_9."+no_type)
						{
							list_of_shapes.RemoveAt(i);
						}
					}
					break;
				}
				case 3:
				{
					double no_square;
					string non_square;
					do
					{
						Console.Write("Square -->  ");
						non_square = Console.ReadLine();
					} while(Double.TryParse(non_square, out no_square) != true && no_square < 0);

					for(int i = 0; i < list_of_shapes.Count(); i++)
					{
						if(list_of_shapes[i].square > no_square)
						{
							list_of_shapes.RemoveAt(i);
						}
					}
					break;
				}
				default:
					break;
			}
		}

		public int Get_Count()
		{
			return list_of_shapes.Count();
		}
		public Shape this[int index]
		{
			get
			{
				return list_of_shapes[index];
			}
		}
		public void Show_List()
		{
			Console.Write("\n\nList of shapes\n\n");
			for(int i = 0; i < list_of_shapes.Count(); i++)
			{
				list_of_shapes[i].Show();
				Console.WriteLine();
			}
			Console.Write("\n\n\n");
		}
	}
}
