using System;
using System.Collections.Generic;
using System.Text;

namespace Rectangle
{
    internal class Rectangle
    {

        decimal high;
        decimal width;
        decimal area;
        public Rectangle(decimal high, decimal width)
        {

            this.high = high;
            this.width = width;

        }
        public decimal GetArea()
        {

            return high * width;

        }
        public decimal GetPerimeter()
        {

            return 2 * (high + width);

        }
    }
}
