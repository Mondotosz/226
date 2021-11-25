using System;

namespace pkg
{
    public class ParkingLot
    {
        private double _capacity;
        private double _vacancy;
        public ParkingLot(double capacity)
        {
            _capacity = capacity;
            _vacancy = _capacity;
        }
        public void Park(Vehicle vehicle)
        {
            if (_vacancy - vehicle.Size < 0) throw new ParkingLotException();
            _vacancy -= vehicle.Size;
        }
        public double Vacancy => _vacancy;
    }

    public class ParkingLotException : Exception
    {

    }
}
