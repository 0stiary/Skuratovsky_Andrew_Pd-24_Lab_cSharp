using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_11_2
{
	delegate bool StudentPredicateDelegate(Student student);
	class Program
	{
		static void Main()
		{
			Student student = new Student();
			List<Student> students = new List<Student>
			{
				new Student("Andrew", "Popov", 18),
				new Student("Grisha", "Koval", 12),
				new Student("Kirko", "Rov", 16),
				new Student("Andrew", "Troelsen", 25),
				new Student("Medyak", "D", 19),
				new Student("Dyadya", "Invead", 17),
				new Student("Maks", "Vaflya", 31),
				new Student("Andrew", "Troelsen", 22),
				new Student("Vasya", "R", 18),
				new Student("Arina", "Op", 27)
			};

			Console.WriteLine("Students with Age => 18\n");

			List<Student> list_age = Extension.FindStudent(students, Student.ValidAge);

			for(int i = 0; i < list_age.Count; i++)
			{
				Console.WriteLine("Student #{0}\n" +
									"\tFist name - {1}\n" +
									"\tLast name - {2}\n" +
									"\tAge - {3}\n", i + 1, list_age[i].FirstName, list_age[i].LastName, list_age[i].Age);
			}



			Console.WriteLine("Students with FirstName first letter \"A\"\n");

			List<Student> list_letter_A = Extension.FindStudent(students, Student.AName);

			for(int i = 0; i < list_letter_A.Count; i++)
			{
				Console.WriteLine(	"Student #{0}\n" +
									"\tFist name - {1}\n" +
									"\tLast name - {2}\n" +
									"\tAge - {3}\n", i+1, list_letter_A[i].FirstName, list_letter_A[i].LastName, list_letter_A[i].Age);
			}



			Console.WriteLine("Students with LastName number of letters > 3\n");

			List<Student> list_numbers = Extension.FindStudent(students, Student.SymblolsMore3LastName);

			for(int i = 0; i < list_numbers.Count; i++)
			{
				Console.WriteLine("Student #{0}\n" +
									"\tFist name - {1}\n" +
									"\tLast name - {2}\n" +
									"\tAge - {3}\n", i + 1, list_numbers[i].FirstName, list_numbers[i].LastName, list_numbers[i].Age);
			}

			// -----------------------------------------------------------------------------------List of anonymus---------------------------------------------------------------------------------------------------------------------------------------

			Console.WriteLine("Students with Age (Anon) => 18\n");

			List<Student> list_age_anon = Extension.FindStudent(students, st => st.Age >= 18);

			for(int i = 0; i < list_age_anon.Count; i++)
			{
				Console.WriteLine("Student #{0}\n" +
									"\tFist name - {1}\n" +
									"\tLast name - {2}\n" +
									"\tAge - {3}\n", i + 1, list_age_anon[i].FirstName, list_age_anon[i].LastName, list_age_anon[i].Age);
			}



			Console.WriteLine("Students with FirstName first letter \"A\" \n");

			List<Student> list_letter_A_anon = Extension.FindStudent(students, st => st.FirstName[0] == 'A');

			for(int i = 0; i < list_letter_A_anon.Count; i++)
			{
				Console.WriteLine("Student #{0}\n" +
									"\tFist name - {1}\n" +
									"\tLast name - {2}\n" +
									"\tAge - {3}\n", i + 1, list_letter_A_anon[i].FirstName, list_letter_A_anon[i].LastName, list_letter_A_anon[i].Age);
			}



			Console.WriteLine("Students with LastName number of letters > 3\n");

			List<Student> list_numbers_anon = Extension.FindStudent(students, st => st.LastName.Length > 3);

			for(int i = 0; i < list_numbers_anon.Count; i++)
			{
				Console.WriteLine("Student #{0}\n" +
									"\tFist name - {1}\n" +
									"\tLast name - {2}\n" +
									"\tAge - {3}\n", i + 1, list_numbers_anon[i].FirstName, list_numbers_anon[i].LastName, list_numbers_anon[i].Age);
			}



			Console.WriteLine("Students with 20 <= Age <= 25, First Name = \"Andrew\" and Last Name = \"Troelsen\"\n");

			List<Student> list_anonymus = Extension.FindStudent(students, st => 20 <= st.Age && st.Age <= 25);
			list_anonymus = Extension.FindStudent(list_anonymus, st => st.FirstName == "Andrew");
			list_anonymus = Extension.FindStudent(list_anonymus, st => st.LastName == "Troelsen");

			for(int i = 0; i < list_anonymus.Count; i++)
			{
				Console.WriteLine("Student #{0}\n" +
									"\tFist name - {1}\n" +
									"\tLast name - {2}\n" +
									"\tAge - {3}\n", i + 1, list_anonymus[i].FirstName, list_anonymus[i].LastName, list_anonymus[i].Age);
			}
		}
	}
}
