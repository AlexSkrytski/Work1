using System;
using System.Collections.Generic;
using System.Formats.Asn1;
using System.Text;

namespace Rectangle
{
    internal class Rectangle
    {

        public decimal high;
        public decimal width;
        decimal area;
        public Rectangle(decimal high, decimal width)
        {

            this.high = high;
            this.width = width;

        }
        public decimal GetArea
        {
            get
            {

                return this.high * this.width;

            }
        }
        public decimal GetPerimeter()
        {

            return 2 * (high + width);

        }
    }
}
