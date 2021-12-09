using System;
using System.Collections.Generic;
using System.Linq;

namespace pkg
{
    public class ParkingLot
    {
        private double _capacity;
        private List<Vehicle> _parkedVehicles;

        public ParkingLot(double capacity)
        {
            _capacity = capacity;
            _parkedVehicles = new List<Vehicle>();
        }

        public virtual void Park(Vehicle vehicle)
        {
            if (Vacancy < vehicle.Size) throw new InsufficientVacancyException();
            if (_parkedVehicles.Contains(vehicle)) throw new VehicleAlreadyParkedException();
            _parkedVehicles.Add(vehicle);
        }

        public virtual void Vacate(Vehicle vehicle)
        {
            if (!_parkedVehicles.Contains(vehicle)) throw new VehicleNotParkedException();
            _parkedVehicles.Remove(vehicle);
        }

        public double Vacancy => _capacity - _parkedVehicles.Sum(vehicle => vehicle.Size);
    }

    public class ParkingLotException : Exception
    {

    }
    public class InsufficientVacancyException : ParkingLotException { }
    public class VehicleNotParkedException : ParkingLotException { }
    public class VehicleAlreadyParkedException : ParkingLotException { }
}