using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_11_2
{
	static class Extension
	{
		public static List<Student> FindStudent(List<Student> students, StudentPredicateDelegate student_predicted)
		{

			List<Student> list = new List<Student>();

			foreach(var item in students)
			{
				if(student_predicted.Invoke(item) == true)
				{
					list.Add(item);
				}
			}
			return list;
		}
	}
}
