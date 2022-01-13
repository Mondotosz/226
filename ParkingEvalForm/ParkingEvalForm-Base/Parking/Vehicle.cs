using System;
using System.Collections.Generic;
using System.Text;

namespace Parking
{
    public class Vehicle
    {
        private double _size;
        private bool _isTurnedOn;

        public Vehicle(double size)
        {
            _size = size;
            _isTurnedOn = false;
        }

        public double Size
        {
            get { return _size; }
        }

        public void TurnOn()
        {
            _isTurnedOn = true;
            Console.WriteLine($"Turning {ToString()} on");
        }

        public void TurnOff()
        {
            _isTurnedOn = false;
            Console.WriteLine($"Turning {ToString()} off");
        }
    }
}
