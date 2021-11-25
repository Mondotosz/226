using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pkg
{
    public class Car : Vehicle
    {
        private string _color;
        public Car(string color) : base(1)
        {
            _color = color;
        }
        public string Color => _color;

        public override string ToString()
        {
            throw new NotImplementedException();
        }
    }
}
