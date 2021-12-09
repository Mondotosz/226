using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pkg
{
    public class ValetParkingLot : ParkingLot
    {
        private List<Valet> _valets;

        public ValetParkingLot(double vacancy) : base(vacancy)
        {
            _valets = new List<Valet>();
        }

        public void Hire(Valet valet)
        {
            if (_valets.Contains(valet)) throw new ValetAlreadyHiredException();
            _valets.Add(valet);
        }

        public void Fire(Valet valet)
        {
            if(!_valets.Contains(valet)) throw new UnknownValetException();
            _valets.Remove(valet);
        }

        public override void Park(Vehicle vehicle)
        {
            base.Park(vehicle);
            ChooseValet().Drive(vehicle);
        }

        public override void Vacate(Vehicle vehicle)
        {
            base.Vacate(vehicle);
            ChooseValet().Drive(vehicle);
        }

        private Valet ChooseValet()
        {
            if(_valets.Find(valet =>valet.Available) is null) throw new NoValetAvailableException();
            return _valets.Find(valet => valet.Available);
        }
    }

    public class ValetparkingLotException : ParkingLotException { }
    public class ValetAlreadyHiredException : ValetparkingLotException { }
    public class UnknownValetException : ValetparkingLotException { }
    public class NoValetAvailableException : ValetparkingLotException { }
}
