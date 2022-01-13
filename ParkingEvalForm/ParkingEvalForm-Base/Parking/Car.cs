using System;
using System.Collections.Generic;
using System.Text;

namespace Parking
{
    public class Car : Vehicle
    {
        private string _color;

        public Car(string color) : base(1.0)
        {
            _color = color;
        }

        public string Color
        {
            get { return _color; }
        }

        public override string ToString()
        {
            return $"Car {_color} {Size}";
        }
    }
}
