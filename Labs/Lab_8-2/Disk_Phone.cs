using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_8_2
{
	class Disk_Phone
	{
		protected string device_name;

		public void Get_Name()
		{
			Console.WriteLine("Name of device - {0}", device_name);
		}

		public Disk_Phone(string device_name)
		{
			this.device_name = device_name;
		}
	}
}
