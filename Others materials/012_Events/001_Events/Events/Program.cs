using System;

// События.

namespace Events
{
    public delegate void EventDelegate(string a);

    public class MyClass
    {
        public event EventDelegate myEvent = null;

        public void InvokeEvent(string a)
        {
            myEvent.Invoke(a);
        }
    }

    class Program
    {
        // Методы обработчики события.

        static private void Handler1(string aaa)
        {
            Console.WriteLine("Обработчик события 1");
        }

        static private void Handler2()
        {
            Console.WriteLine("Обработчик события 2");
        }

        static void Main()
        {
            MyClass instance = new MyClass(); 

            // Присоединение обработчиков событий. (Подписка на событие)
            instance.myEvent += new EventDelegate(Handler1);
            instance.myEvent += new EventDelegate(Handler2);

            // Метод который вызывает событие.
            instance.InvokeEvent("sasasasa");

            Console.WriteLine(new string('-', 20));

            // Открепляем Handler2().
            instance.myEvent -= new EventDelegate(Handler2);

            instance.InvokeEvent();

            // Delay.
            Console.ReadKey();
        }
    }
}
