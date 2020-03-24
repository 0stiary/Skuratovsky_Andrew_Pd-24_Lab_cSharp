using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Testing_Trans_From_Java
{
	class Program
	{
		static void Main(string[] args)
		{
			int maxp = 0;
			int n = 0;
			int g = 0;
			for(int i = 100; i < 1000; i++)
			{
				for(int j = 100; j < 1000; j++)
				{
					int chislo = j * i;
					int m = pal(chislo);
					//System.out.println(chislo);
					if(maxp < m)
					{
						maxp = m;
						n = i;
						g = j;
					}

				}
			}

			Console.WriteLine(maxp);

		}

		static int pal(int chislo)
		{
			int n1 = chislo / 100000;
			// System.out.println(n1);
			int n2 = (chislo % 100000) / 10000;
			// System.out.println(n2);
			int n3 = ((chislo % 100000) % 10000) / 1000;
			// System.out.println(n3);
			int n4 = (((chislo % 100000) % 10000) % 1000) / 100;
			// System.out.println(n4);
			int n5 = ((((chislo % 100000) % 10000) % 1000) % 100) / 10;
			// System.out.println(n5);
			int n6 = (((((chislo % 100000) % 10000) % 1000) % 100) % 10) / 1;
			// System.out.println(n6);
			if(n1 == n6 && n2 == n5 && n3 == n4)
			{
				return chislo;
			}
			else
				return chislo = 0;
		}
	}
}
