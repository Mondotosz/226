using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Parking
{
    public class SuperValet : Valet
    {
        public SuperValet(string name) : base(name) { }
        public override bool CanDrive(Vehicle vehicle)
        {
            return (vehicle is Vehicle);//AKA return true;
        }
    }
}
