using System;
using System.Collections.Generic;
using System.Text;

namespace Parking
{
    public class Motorcycle : Vehicle
    {
        private string _brand;

        public Motorcycle(string brand) : base(0.5)
        {
            _brand = brand;
        }

        public string Brand
        {
            get { return _brand; }
        }

        public override string ToString()
        {
            return $"Motorcycle {_brand} {Size}";
        }
    }
}
