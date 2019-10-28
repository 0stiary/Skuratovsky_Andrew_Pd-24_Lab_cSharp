using System;

// Статический конструктор.

namespace Static
{
    class Program
    {
        static void Main()
        {
            //Console.WriteLine(NotStaticClass.ReadonlyField);

            NotStaticClass a = new NotStaticClass();

            a.Method();

            // Delay.
            Console.ReadKey();
        }
    }
}
