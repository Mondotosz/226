using NUnit.Framework;
using pkg;

namespace pkgTests
{
    public class ParkTest
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void TestParkAVehicleWithEnoughCapacity()
        {
            ParkingLot flon = new ParkingLot(10.0);
            Vehicle christine = new Vehicle(1.0);

            flon.Park(christine);

            Assert.AreEqual(9.0, flon.Vacancy);
        }

        [Test]
        public void TestParkAVehicleWithJustEnoughCapacity()
        {
            ParkingLot flon = new ParkingLot(1.0);
            Vehicle christine = new Vehicle(1.0);

            flon.Park(christine);

            Assert.AreEqual(0.0, flon.Vacancy);
        }

        [Test]
        public void TestParkAVehicleWithoutEnoughCapacity()
        {
            Assert.Throws<InsufficientVacancyException>(() =>
            {
                ParkingLot flon = new ParkingLot(0.5);
                Vehicle christine = new Vehicle(1.0);

                flon.Park(christine);

            });
        }

        [Test]
        public void TestParkSeveralVehicleUptoCapacity()
        {
            ParkingLot flon = new ParkingLot(10.0);

            for (int i = 0; i < 10; i++)
            {
                flon.Park(new Vehicle(1.0));
            }

            Assert.AreEqual(0.0, flon.Vacancy);
        }

        [Test]
        public void TestParkSeveralVehicleExceedingCapacity()
        {
            Assert.Throws<InsufficientVacancyException>(() =>
            {
                ParkingLot flon = new ParkingLot(10.0);

                for (int i = 0; i < 10; i++)
                {
                    flon.Park(new Vehicle(1.0));
                }

                Assert.AreEqual(0.0, flon.Vacancy);

                flon.Park(new Vehicle(1.0));
            });
        }
    }
}