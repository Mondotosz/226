using NUnit.Framework;
using pkg;

namespace pkgTests
{
    public class ParkAndVacateTest
    {
        private ParkingLot flon;
        private Car christine;

        [SetUp]
        public void Setup()
        {
            flon = new ParkingLot(10.0);
            christine = new Car("red");
        }

        [Test]
        public void TestParkAndVacateSameVehicle()
        {
            flon.Park(christine);
            flon.Vacate(christine);
        }

        [Test]
        public void TestParkAndVacateSameVehicleMultipleTimes()
        {
            for (int i = 0; i < 10; i++)
            {
                flon.Park(christine);
                flon.Vacate(christine);
            }
        }

        [Test]
        public void TestParkSameVehicleTwice()
        {
            Assert.Throws<VehicleAlreadyParkedException>(() =>
            {
                flon.Park(christine);
                flon.Park(christine);

            });
        }

        [Test]
        public void TestVacateNotParkedVehicle()
        {
            Assert.Throws<VehicleNotParkedException>(() =>
            {
                flon.Vacate(christine);
            });
        }
    }
}
