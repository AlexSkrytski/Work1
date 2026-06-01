using System;
using System.Collections.Generic;
using System.Text;

namespace Vehicle
{
    internal class Car
    {
        private double _maxSpeed;

        public double MaxSpeed
        {
            get { return _maxSpeed; }
            set
            {
                if (value < 0)
                {
                    _maxSpeed = 0;
                    return;
                }
                if (value > 400)
                {
                    _maxSpeed = 400;
                    return;
                }

                _maxSpeed = value;

            }
        }

        public void PrintSpeed()
        {
            Console.WriteLine($"Speed is {_maxSpeed}.");
        }

    }
}
