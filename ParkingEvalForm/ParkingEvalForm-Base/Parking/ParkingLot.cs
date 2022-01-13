using System;
using System.Collections.Generic;

namespace Parking
{
    public class ParkingLot
    {
        private double _capacity;
        private double _vacancy;
        private List<Valet> _valets;
        private List<Vehicle> _parkedVehicles;

        public ParkingLot(double capacity)
        {
            _capacity = capacity;
            _vacancy = capacity;
            _valets = new List<Valet>();
            _parkedVehicles = new List<Vehicle>();
        }

        public double Vacancy
        {
            get { return _vacancy; }
        }

        public void Park(Vehicle vehicle)
        {
            if (_vacancy - vehicle.Size < 0)
            {
                throw new NoVacancyException();
            }

            if (_parkedVehicles.Contains(vehicle))
            {
                throw new VehicleAlreadyParkedException();
            }

            ChooseValet(vehicle).Drive(vehicle);

            _vacancy -= vehicle.Size;
            _parkedVehicles.Add(vehicle);
        }

        public void Vacate(Vehicle vehicle)
        {
            if (!_parkedVehicles.Contains(vehicle))
            {
                throw new VehicleNotParkedException();
            }

            ChooseValet(vehicle).Drive(vehicle);

            _vacancy += vehicle.Size;
            _parkedVehicles.Remove(vehicle);
        }

        public void Hire(Valet valet)
        {
            if (_valets.Contains(valet))
            {
                throw new ValetAlreadyHiredException();
            }

            _valets.Add(valet);
        }

        public void Fire(Valet valet)
        {
            if (!_valets.Contains(valet))
            {
                throw new ValetNotHiredException();
            }

            _valets.Remove(valet);
        }

        private Valet ChooseValet(Vehicle vehicle)
        {
            foreach (Valet valet in _valets)
            {
                if (valet.Available && valet.CanDrive(vehicle))
                {
                    return valet;
                }
            }

            throw new NoValetsAvailableException();
        }

    }
}
