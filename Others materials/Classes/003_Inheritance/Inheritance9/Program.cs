﻿using System;

// Операторы is и as.

namespace Inheritance
{
    class ClassA { /* ... */ }

    class ClassB : ClassA { /* ... */ }

    class Program
    {
        static void Main()
        {
            ClassB b = new ClassB();
            ClassA a = null;

            //--------------------------------------------- is --------------------------------------------- 
            // Оператор is - проверяет совместимость объекта с заданным типом. 
            // Если предоставленный объект может быть приведен к предоставленному типу не вызывая исключение,
            // выражение is принимает значение true.

            // Например, в следующем коде определяется, является ли объект экземпляром типа A или типа, производного от A:

            if (b is ClassA)
            {
                a = (ClassA)b;
            }
            else
            {
                a = null;
            }

            //--------------------------------------------- as---------------------------------------------  
            // Оператор as используется для выполнения преобразований между совместимыми ссылочными типами.
            // Оператор as подобен оператору приведения. Однако, если преобразование невозможно,
            // as возвращает значение null, а не вызывает исключение.

            // В общем виде логика работы оператора as представляет собой механизм использования оператора is
            // (пример на 25 строке), только в сокращенном виде.

            a = b as ClassA;

            // Delay.

            Console.WriteLine(a.ToString());
            Console.WriteLine(b.ToString());
            Console.ReadKey();
        }
    }
}
