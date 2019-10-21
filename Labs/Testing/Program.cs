using System;
using System.Collections.Generic;
using System.Threading;

namespace Testing
{
	class Program
	{
		static void Main(string[] args)
		{

			int speed = 116;
			int s = 116;
			string line = new string('~', s);
			Console.WriteLine(line + "\n");

			for(int i = 0; i < s; i++)
			{
				//for(int j = 3; j <= i; j++)             //< 1st line
				//{
				//	Console.Write('-');                     //first part
				//}

				Console.Write(new string('-', i));

				Console.Write("O--O");

				Console.Write(new string('-', s-i-1));
				//for(int j = i + 1; j < s; j++)
				//{
				//	Console.Write('-');                     //second part
				//}
				Console.WriteLine();                    // >



				//for(int j = 3; j <= i; j++)             //< 2nd line
				//{
				//	Console.Write(' ');                     //first part
				//}
				Console.Write(new string('-', i));
				Console.Write("[==|=]");
				Console.Write(new string('-', s-i-3));
				//for(int j = i + 1; j < s - 4; j++)
				//{
				//	Console.Write(' ');                     //second part
				//}
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
	}
}