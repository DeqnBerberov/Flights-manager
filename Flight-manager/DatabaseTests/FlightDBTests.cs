﻿using Database.Entities;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace Tests
{
    [TestClass]
    public class FlightDBTests
    {
        [TestMethod]
        public void TestFlightID()
        {
            Flight flight = new Flight(1, "Sofia", "Burgas", new DateTime (2020,03,13), new DateTime (2020, 03, 14), 
                "Boing", 10, "DeyanB", 13, 13);
            int expected = 1;

            Assert.AreEqual(expected,
                flight.Id,
                "FlightID must be int and is incorrectly set.");
        }
        [TestMethod]
        public void TestFlightTakeOffLoc()
        {
            Flight flight = new Flight(1, "Sofia", "Burgas", new DateTime(2020, 03, 13), new DateTime(2020, 03, 14), 
                "Boing", 10, "DeyanB", 13, 13);
            string expected = "Sofia";

            Assert.AreEqual(expected,
                flight.TakeOffLocation,
                "Flight TakeOffLocation must be string and is incorrectly set.");
        }
        [TestMethod]
        public void TestFlightLandingLoc()
        {
            Flight flight = new Flight(1, "Sofia", "Burgas", new DateTime(2020, 03, 13), new DateTime(2020, 03, 14), 
                "Boing", 10, "DeyanB", 13, 13);
            string expected = "Burgas";

            Assert.AreEqual(expected,
                flight.LandingLocation,
                "Flight LandingLocation  must be string and is incorrectly set.");
        }
        [TestMethod]
        public void TestFlightTakeOff()
        {
            Flight flight = new Flight(1, "Sofia", "Burgas", new DateTime(2020, 03, 13), new DateTime(2020, 03, 14), 
                "Boing", 10, "DeyanB", 13, 13);
            DateTime expectedtime = new DateTime(2020,03,13);

            Assert.AreEqual(expectedtime,
                flight.TakeOff,
                "Flight TakeOff  must be DateTime(Y/M/D) and is incorrectly set.");
        }
        [TestMethod]
        public void TestFlightLanding()
        {
            Flight flight = new Flight(1, "Sofia", "Burgas", new DateTime(2020, 03, 13), new DateTime(2020, 03, 14), 
                "Boing", 10, "DeyanB", 13, 13);
            DateTime expectedtime = new DateTime(2020, 03, 14);

            Assert.AreEqual(expectedtime,
                flight.Landing,
                "Flight Landing must be DateTime(Y/M/D) and is incorrectly set.");
        }
        [TestMethod]
        public void TestFlightPlaneType()
        {
            Flight flight = new Flight(1, "Sofia", "Burgas", new DateTime(2020, 03, 13), new DateTime(2020, 03, 14), 
                "Boing", 10, "DeyanB", 13, 13);
            string expected = "Boing";

            Assert.AreEqual(expected,
                flight.TypePlane,
                "Flight TypePlane must be string and is incorrectly set.");
        }
        [TestMethod]
        public void TestFlightPlaneID()
        {
            Flight flight = new Flight(1, "Sofia", "Burgas", new DateTime(2020, 03, 13), new DateTime(2020, 03, 14),
                "Boing", 10, "DeyanB", 13, 13);
            int expected = 10;

            Assert.AreEqual(expected,
                flight.PlaneId,
                "Flight PlaneID must be int and is incorrectly set.");
        }
        [TestMethod]
        public void TestFlightPilotName()
        {
            Flight flight = new Flight(1, "Sofia", "Burgas", new DateTime(2020, 03, 13), new DateTime(2020, 03, 14),
                "Boing", 10, "DeyanB", 13, 13);
            string expected = "DeyanB";

            Assert.AreEqual(expected,
                flight.PilotName,
                "Flight PilotName must be string and is incorrectly set.");
        }
        [TestMethod]
        public void TestFlightAvPassSeats()
        {
            Flight flight = new Flight(1, "Sofia", "Burgas", new DateTime(2020, 03, 13), new DateTime(2020, 03, 14),
                "Boing", 10, "DeyanB", 13, 13);
            int expected = 13;

            Assert.AreEqual(expected,
                flight.AvailablePassengerSeats,
                "Flight AvailablePassengerSeats must be int and is incorrectly set.");
        }
        [TestMethod]
        public void TestFlightAvBusSeats()
        {
            Flight flight = new Flight(1, "Sofia", "Burgas", new DateTime(2020, 03, 13), new DateTime(2020, 03, 14),
                "Boing", 10, "DeyanB", 13, 13);
            int expected = 13;

            Assert.AreEqual(expected,
                flight.AvailableBusinessClassSeats,
                "Flight AvailableBusinessClassSeats must be int and is incorrectly set.");
        }
    }
}
