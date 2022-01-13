using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Parking
{
    public class TruckValet : Valet
    {
        public TruckValet(string name) : base(name) { }

        public override bool CanDrive(Vehicle vehicle)
        {
            return (vehicle is Truck);
        }
    }
}
