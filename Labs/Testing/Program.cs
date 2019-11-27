using System;
using System.Collections.Generic;
using System.Threading;
using System.Drawing;
using System.Linq;

namespace Testing
{
	public delegate void PressKeyEventHandler();
	class Program
	{
		static void Main(string[] args)
		{
			Keyboard keyboard = new Keyboard();
			List <Player> field = new List<Player>();

			for(int i = 0; i < 2; i++)
			{
				Player player = new Player(i);
				field.Add(player);
				Console.WriteLine(player.name + " : ");
			}

			keyboard.PressKey1 += () => { Console.SetCursorPosition(11, 0); string s = new string('#', field[0].count++); Console.Write(s); Console.SetCursorPosition(0, 2); };
			keyboard.PressKey2 += () => { Console.SetCursorPosition(11, 1); string s = new string('#', field[1].count++); Console.Write(s); Console.SetCursorPosition(0, 2); };

			keyboard.Start();
		}
	}
}