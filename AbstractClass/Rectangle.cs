using System;
using System.Collections.Generic;
using System.Text;

namespace AbstractClass1
{
    public class Rectangle : Shape
    {
        public double Width { get; set; }
        public double Height { get; set; }
        public Rectangle(double width, double height)

        {
            Width = width;
            Height = height;
        }
        public override double Area => Width * Height;

    }
}
