using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pkg
{
    public class Truck : Vehicle
    {
        public Truck() : base(3)
        {

        }
        public override string ToString()
        {
            return $"Truck {Size}";
        }
    }
}
