using System;
using System.Collections.Generic;
using System.Text;

namespace AbstractClass1
{
    public abstract class Shape()
    {
        public abstract double Area { get; }
        public void PrintInfo()

        {

            Console.WriteLine($"Name {GetType().Name}, Area = {Area:F2}"); //F2 - округление до 2х знаков
                                                                           //GetType().Name — метод из базового класса object, который возвращает имя типа самого объекта в рантайме (в примере выше — "Circle")
        }
    }

}
