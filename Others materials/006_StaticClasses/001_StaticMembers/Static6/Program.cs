using System;

// Статические члены в нестатических классах.

namespace Static
{
    class Program
    {
        static void Main()
        {
            NotStaticClass instance = new NotStaticClass();
            instance.NotStaticMethod();

            NotStaticClass instance2 = new NotStaticClass();
            instance2.NotStaticMethod();



            //NotStaticClass.Property = 2;
            // Console.WriteLine(NotStaticClass.Property);

            //NotStaticClass.Method();
            //NotStaticClass.Method(3);

            // Delay.
            Console.ReadKey();
        }
    }
}
