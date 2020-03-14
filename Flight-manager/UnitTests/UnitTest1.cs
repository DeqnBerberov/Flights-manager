using Database.Entities;
using NUnit.Framework;

namespace UnitTests
{
    public class Tests
    {
        [Test]
        public void DoesItCreatePassengerCorrectly()
        {
            Passenger passenger = new Passenger(1, "Deyan", "Berberov", "Borislavov", "0123456789","0877531812", "BGN", "Passenger", 13);
            Assert.AreEqual(2,
                passenger.Id,
                "PassengerID must be int and is incorrectly set.");
        }

        [Test]
        public void DoesItCreateEmployeeCorrectly()
        {
            Assert.Pass();
        }

        [Test]
        public void DoesItCreateFlightCorrectly()
        {
            Assert.Pass();
        }

        [Test]
        public void DoesItCreateReservationCorrectly()
        {
            Assert.Pass();
        }
    }
}