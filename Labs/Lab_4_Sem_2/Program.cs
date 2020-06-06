using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading;
using System.Threading.Tasks;

namespace Lab_4_Sem_2
{
	class Program
	{
		/*static void Main(string[] args)
		{
			
		}*/

		static void Creating_Deliting_Folders()
		{
			string dirName = "\\\\?\\" + Directory.GetCurrentDirectory() + "_T_T_T";
			DirectoryInfo parent_dir = new DirectoryInfo(dirName);
			DirectoryInfo dirInfo = new DirectoryInfo(dirName);

			if(!dirInfo.Exists)
			{
				dirInfo.Create();
			}

			string path = dirName, subfolder;

			for(int i = 0; i < 100; i++)
			{
				try
				{
					subfolder = "" + i;
					dirInfo.CreateSubdirectory(subfolder);
					path += @"\" + subfolder;
					dirInfo = new DirectoryInfo(path);
				}
				catch(Exception) { }
				
			}

			Console.ReadLine();
			parent_dir.Delete(true);
		}

		static void Search_RootFolder(DirectoryInfo root_folder, Regex file_name)
		{
			DirectoryInfo[] root_folders = root_folder.GetDirectories();

			FileInfo[] root_files = root_folder.GetFiles();				//Файлы в корневой папке

			foreach(FileInfo root_file in root_files)					//Поиск по всем файлам в корне папке
			{
				if(file_name.IsMatch(root_file.Name))						
				{
					Console.ForegroundColor = ConsoleColor.Green;
					Console.WriteLine(root_file.FullName);				//вывести совпадение по имени файла
					Console.ResetColor();
				}
			}

			foreach(DirectoryInfo root_sub_folder  in root_folders)
			{
				if(root_sub_folder.Name.ToCharArray()[0] == 160)				//Проверка на опасный символ (у меня папка на рабочем столе есть с именем - символ 160 в юникоде)
					continue;										//Пропуск папки ибо на ней ошибка и бесконечный цикл 

				try
				{
					Search_SubFolders(root_sub_folder, file_name);				//Поиск по вложенным папкам
				}
				catch(Exception) { }
			}



		}

		static void Search_SubFolders(DirectoryInfo ko, Regex file_name)			//Поиск по вложенным папкам
		{
			FileInfo[] sub_files = ko.GetFiles();									//Все файлы в родительской папке

			foreach(FileInfo file in sub_files)										//Поиск по всем файлам в папке
			{
				if(file_name.IsMatch(file.Name))
				{
					Console.ForegroundColor = ConsoleColor.Green;
					Console.WriteLine(file.FullName);								//Вывести совпадение по имени
					Console.ResetColor();
				}
			}

			try
			{
				DirectoryInfo[] sub_folders = ko.GetDirectories();					//Все вложенные папки в родительской папке
				foreach(DirectoryInfo folder in sub_folders)						//Поиск по всем подпапкам в родительской папке
				{
					if(folder.Name.ToCharArray()[0] == 160)							//Проверка на опасный символ (у меня папка на рабочем столе есть с именем - символ 160 в юникоде)
						continue;													//Пропуск папки ибо на ней ошибка и бесконечный цикл 
					//Console.WriteLine(folder.FullName);
					try
					{
						Search_SubFolders(folder, file_name);						//Поиск по следущей вложенной папке
					}
					catch(Exception)
					{}
					
				}
			}
			catch(Exception) {
			}
		}
		

		static void Main()
		{
			DirectoryInfo root_path = new DirectoryInfo(@"C:\Users\User");	//Путь корневой папки для поиска в ней
			Regex file_name = new Regex("input_logins.txt");                //Имя файла для поиска
			Creating_Deliting_Folders();
			//Search_RootFolder(root_path, file_name);						//Поиск в корневой папке
		}
	}
}
