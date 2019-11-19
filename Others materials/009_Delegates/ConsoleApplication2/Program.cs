using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication2
{
    class Program
    {


        delegate int MyDelegate(int i);

        static void Main(string[] args)
        {
            MyDelegate myDelegate = x => { Console.WriteLine("Hello World!");  x* x; };
            int j = myDelegate(5); // Hello World! j = 25
        }




    }
}
