using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pkg
{
    public class Vehicle
    {
        private double _size;
        public Vehicle(double size)
        {
            _size = size;
        }
        public double Size => _size;
    }
}
