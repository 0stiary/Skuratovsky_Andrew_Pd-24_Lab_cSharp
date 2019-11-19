using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_10
{
	static class ExtentionClass
	{
		public static void ExtensionMethod(this IntArray mass)
		{

			Console.WriteLine("\nElements by pair position -->");

			for(int i = 0; i < mass.GetSizeArray(); i++)
			{
				if(i  % 2 == 0)
				{
					mass.ShowByPos(i);
				}
			}

			Console.WriteLine("\nElements by NOT pair position -->");

			for(int i = 0; i < mass.GetSizeArray(); i++)
			{
				if(i % 2 != 0)
				{
					mass.ShowByPos(i);
				}
			}
		}
	}
}
