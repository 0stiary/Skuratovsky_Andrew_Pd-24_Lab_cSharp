using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_11_2
{
	class Student
	{
		public string FirstName { get; set; }
		public string LastName { get; set; }
		public int Age { get; set; }

		public static bool ValidAge(Student student)
		{
			if(student.Age >= 18)
			{
				return true;
			}
			return false;
		}

		public static bool AName(Student student)
		{
			if(student.FirstName[0] == 'A')
			{
				return true;
			}
			return false;
		}

		public static bool SymblolsMore3LastName(Student student)
		{
			if(student.LastName.Length > 3)
			{
				return true;
			}
			return false;
		}
		public Student()
		{

		}
		public Student(string FirstName, string LastName, int Age)
		{
			this.FirstName = FirstName;
			this.LastName = LastName;
			this.Age = Age;
		}
	}
}
