using System;

namespace Static
{
    class NotStaticClass
    {
        private int Id;
        public static int field;

        // Конструктор.
        public NotStaticClass(int Id)
        {
            this.Id = Id;
        }

        public void Method()
        {
            Console.WriteLine("Instance{0}.field = {1}", Id, field);
        }

    }
}
