using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Testing
{
	class Keyboard
	{
		public event PressKeyEventHandler PressKey1 = null;
		public event PressKeyEventHandler PressKey2 = null;

		public void PressKey1Event()
		{
			if(PressKey1 != null)
			{
				PressKey1.Invoke(); // вызываем метод Invoke на событии
			}
		}
		public void PressKey2Event()
		{
			if(PressKey2 != null)
			{
				PressKey2.Invoke(); // вызываем метод Invoke на событии
			}
		}
		public void Start()
		{
			while(true)
			{
				string s = Console.ReadLine();

				switch(s)
				{
					case "1":
						PressKey1Event();
						break;
					case "2":
						PressKey2Event();
						break;
					case "e":
						Console.WriteLine("Exit!");
						return;
					default:
						Console.WriteLine("Нет обработчика нажатия на клавишу {0}", s);
						break;
				}
			}
		}
	}
}
