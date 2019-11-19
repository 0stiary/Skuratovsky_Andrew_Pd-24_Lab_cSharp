using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{


    delegate void MyDelegate();

    class Program
    {
        static void Method()
        {
            Console.WriteLine("Hello World!");
        }

        static void Main(string[] args)
        {
            MyDelegate myDelegate = new MyDelegate(Method);

            myDelegate.Invoke();

            myDelegate();
        }
    }




}
