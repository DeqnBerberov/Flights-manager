using Database.Entities;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Tests
{
    /// <summary>
    /// This is class PassengerDBTests.
    /// </summary>
    [TestClass]
    public class PassengerDBTests
    {
        /// <summary>
        /// This test checks if a passenger with a specific id is correctly registered to the database. 
        /// </summary>
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
        /// <summary>
        /// This test checks if a passenger with a specific first name is correctly registered to the database. 
        /// </summary>
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
        /// <summary>
        /// This test checks if a passenger with a specific surname is correctly registered to the database. 
        /// </summary>
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
        /// <summary>
        /// This test checks if a passenger with a specific last name is correctly registered to the database. 
        /// </summary>
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
        /// <summary>
        /// This test checks if a passenger with a specific USN is correctly registered to the database. 
        /// </summary>
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
        /// <summary>
        /// This test checks if a passenger with a specific phone number is correctly registered to the database. 
        /// </summary>
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
        /// <summary>
        /// This test checks if a passenger with a specific nationality is correctly registered to the database. 
        /// </summary>
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
        /// <summary>
        /// This test checks if a passenger with a specific ticket type is correctly registered to the database. 
        /// </summary>
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
        /// <summary>
        /// This test checks if a passenger with a specific reservation id is correctly registered to the database. 
        /// </summary>
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
