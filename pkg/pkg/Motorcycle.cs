using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pkg
{
    public class Motorcycle : Vehicle
    {
        private string _brand;
        public Motorcycle(string brand) : base(0.5)
        {
            _brand = brand;
        }
        public Motorcycle(string brand, double size) : base(size)
        {
            _brand = brand;
        }
        public string Brand => _brand;

        public override string ToString()
        {
            return $"Motorcycle {_brand} {Size}";
        }
    }
}
