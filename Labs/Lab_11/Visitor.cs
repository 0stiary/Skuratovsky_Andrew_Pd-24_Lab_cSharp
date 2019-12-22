using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_11_1
{
	class Visitor
	{
		public bool american { get; set; }
		public bool fired { get; set; }
		public bool fear_room { get; set; }
		public bool mirror_room { get; set; }
		public bool popcorn { get; set; }
		public bool ferris_wheel { get; set; }

		public void Show()
		{
			Console.WriteLine("Rooller Coater - {0}\n" +
							   "Fire room - {1}\n" +
							   "Fear room - {2}\n" +
							   "Mirror room - {3}\n" +
							   "Eat popcorn - {4}\n" +
							   "Ferris wheel - {5}\n", american, fired, fear_room, mirror_room, popcorn, ferris_wheel);	
		}

	}
}
