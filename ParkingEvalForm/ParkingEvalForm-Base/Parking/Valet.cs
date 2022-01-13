using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Parking
{
    public class Valet
    {
        private string _name;
        private bool _available;

        public Valet(string name)
        {
            _name = name;
            _available = true;
        }

        public bool Available
        {
            get { return _available; }
        }

        public void Drive(Vehicle vehicle)
        {
            if (!_available)
            {
                throw new BusyValetException();
            }

            if (!CanDrive(vehicle)) throw new UnqualifiedDrivingValetException();

            _available = false;
            vehicle.TurnOn();

            vehicle.TurnOff();
            _available = true;
        }

        public virtual bool CanDrive(Vehicle vehicle)
        {
            throw new NotImplementedException();
        }
    }
}
