using System;
using System.Collections.Generic;
using System.Text;

namespace AbstractClass1
{
    internal class Circle : Shape
    {
        public double Radius { get; set; }

        public Circle(double radius)
        
        {
            Radius = radius;
        }
        public override double Area => Math.PI * Radius * Radius;

    }
}
