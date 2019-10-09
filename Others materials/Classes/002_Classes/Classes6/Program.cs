using System;

// Самоассоциация (self-association).

namespace Classes
{
    class MyClass
    {
        MyClass instance;
		static int c = 0;

        public MyClass()  // StackOverflowException
        {
			c++;
            Console.WriteLine("Constructor MyClass, {0}", c);

            // Самоассоциация, после первой попытки инстанцирования приводит к цикличному инстанцированию.

            instance = new MyClass();
        }
    }

    class Program
    {
        static void Main()
        {
            // Попытка инстанцирования класса MyClass.

            MyClass instance = new MyClass();

            // Delay.
            Console.ReadKey();
        }
    }
}
