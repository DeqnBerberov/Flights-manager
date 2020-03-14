using Database.Entities;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Tests
{
    [TestClass]
    public class PassengerDBTests
    {
        [TestMethod]
        public void TestPassengerID()
        {
            Passenger passenger = new Passenger(1, "Deyan", "Berberov", "Borislavov", "0123456789", "0877531812", "BLGN",
                "Passenger", 13);
            int expected = 1;

            Assert.AreEqual(expected,
                passenger.Id,
                "PassengerID must be int and is incorrectly set.");
        }
        [TestMethod]
        public void TestPassengerFN()
        {
            Passenger passenger = new Passenger(1, "Deyan", "Berberov", "Borislavov", "0123456789", "0877531812", "BLGN", 
                "Passenger", 13);
            string expected = "Deyan";

            Assert.AreEqual(expected,
                passenger.FirstName,
                "Passengers FirstName must be string and is incorrectly set.");
        }
        [TestMethod]
        public void TestPassengerSN()
        {
            Passenger passenger = new Passenger(1, "Deyan", "Berberov", "Borislavov", "0123456789", "0877531812", "BLGN", 
                "Passenger", 13);
            string expected = "Berberov";

            Assert.AreEqual(expected,
                passenger.Surname,
                "Passengers Surname must be string and is incorrectly set.");
        }
        [TestMethod]
        public void TestPassengerLN()
        {
            Passenger passenger = new Passenger(1, "Deyan", "Berberov", "Borislavov", "0123456789", "0877531812", "BLGN", 
                "Passenger", 13);
            string expected = "Borislavov";

            Assert.AreEqual(expected,
                passenger.Lastname,
                "Passengers Lastname must be string and is incorrectly set.");
        }
        [TestMethod]
        public void TestPassengerUSN()
        {
            Passenger passenger = new Passenger(1, "Deyan", "Berberov", "Borislavov", "0123456789", "0877531812", "BLGN", 
                "Passenger", 13);
            string expected = "0123456789";

            Assert.AreEqual(expected,
                passenger.USN,
                "Passengers USN must be string and is incorrectly set.");
        }
        [TestMethod]
        public void TestPassengerPN()
        {
            Passenger passenger = new Passenger(1, "Deyan", "Berberov", "Borislavov", "0123456789", "0877531812", "BLGN", 
                "Passenger", 13);
            string expected = "0877531812";

            Assert.AreEqual(expected,
                passenger.PhoneNumber,
                "Passengers PhoneNumber must be string and is incorrectly set.");
        }
        [TestMethod]
        public void TestPassengerNat()
        {
            Passenger passenger = new Passenger(1, "Deyan", "Berberov", "Borislavov", "0123456789", "0877531812", "BLGN",
                "Passenger", 13);
            string expected = "BLGN";

            Assert.AreEqual(expected,
                passenger.Nationality,
                "Passengers Nationality must be string and is incorrectly set.");
        }
        [TestMethod]
        public void TestPassengerTicketType()
        {
            Passenger passenger = new Passenger(1, "Deyan", "Berberov", "Borislavov", "0123456789", "0877531812", "BLGN",
                "Passenger", 13);
            string expected = "Passenger";

            Assert.AreEqual(expected,
                passenger.TicketType,
                "Passengers TicketType must be string and is incorrectly set.");
        }
        [TestMethod]
        public void TestPassengerResID()
        {
            Passenger passenger = new Passenger(1, "Deyan", "Berberov", "Borislavov", "0123456789", "0877531812", "BLGN", 
                "Passenger", 13);
            int expected = 13;

            Assert.AreEqual(expected,
                passenger.ReservationId,
                "Passengers ReservationID must be int and is incorrectly set.");
        }
    }
}