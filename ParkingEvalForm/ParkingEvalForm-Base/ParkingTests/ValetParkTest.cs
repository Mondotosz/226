using System;
using NUnit.Framework;
using Parking;

namespace ParkingTests
{
    public class ValetParkTest
    {
        private ParkingLot _flon;
        private CarValet _carValet;
        private SuperValet _superValet;
        private MotorcycleValet _motorcycleValet;
        private TruckValet _truckValet;


        [SetUp]
        public void Setup()
        {
            _flon = new(50);
            _carValet = new("toto");
            _superValet = new("fonfon");
            _motorcycleValet = new("biker");
            _truckValet = new("gabi");
        }

        [Test]
        public void TestParkACarWithCorrectValet()
        {
            Vehicle vehicle = new Car("white");
            _flon.Hire(_carValet);
            _flon.Park(vehicle);
        }

        [Test]
        public void TestParkATruckWithCorrectValet()
        {
            Vehicle vehicle = new Truck();
            _flon.Hire(_truckValet);
            _flon.Park(vehicle);
        }

        [Test]
        public void TestParkATruckWithWrongValet()
        {
            Vehicle vehicle = new Truck();
            _flon.Hire(_carValet);
            Assert.Throws<NoValetsAvailableException>(delegate
            {
                _flon.Park(vehicle);
            });
        }

        [Test]
        public void TestParkAMotorcycleWithCorrectValet()
        {
            Vehicle vehicle = new Motorcycle("suzuki");
            _flon.Hire(_motorcycleValet);
            _flon.Park(vehicle);
        }

        [Test]
        public void TestParkAMotorcycleWithWrongValet()
        {
            Vehicle vehicle = new Motorcycle("suzuki");
            _flon.Hire(_carValet);
            Assert.Throws<NoValetsAvailableException>(delegate
            {
                _flon.Park(vehicle);
            });
        }

        [Test]
        public void TestParkAllVehicleWithCorrectValet()
        {
            _flon.Hire(_superValet);
            _flon.Park(new Car("white"));
            _flon.Park(new Truck());
            _flon.Park(new Motorcycle("suzuki"));
        }

    }
}
