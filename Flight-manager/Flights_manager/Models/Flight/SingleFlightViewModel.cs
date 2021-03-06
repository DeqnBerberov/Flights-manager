﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Flights_manager.Models.Flight
{
    /// <summary>
    /// This is class SingleFlightViewModel.
    /// </summary>
    public class SingleFlightViewModel
    {
        /// <summary>
        /// Id is used to set an id of a flight model.
        /// </summary>
        public int Id { get; set; }
        /// <summary>
        /// TakeOffLocation is used to set a take off location of a flight model.
        /// </summary>
        public string TakeOffLocation { get; set; }
        /// <summary>
        /// LandingLocation is used to set a landing location of a flight model.
        /// </summary>
        public string LandingLocation { get; set; }
        /// <summary>
        /// TakeOff is used to set a take off time of a flight model.
        /// </summary>
        public DateTime TakeOff { get; set; }
        /// <summary>
        /// Landing is used to set a landing time of a flight model.
        /// </summary>
        public DateTime Landing { get; set; }
        /// <summary>
        /// TypePlane is used to set the type of a flight model.
        /// </summary>
        public string TypePlane { get; set; }
        /// <summary>
        /// PlaneId is used to set an id to a plane of a flight model.
        /// </summary>
        public int PlaneId { get; set; }
        /// <summary>
        /// PilotName is used to set a name of a pilot of a flight model.
        /// </summary>
        public string PilotName { get; set; }
        /// <summary>
        /// AvailablePassengerSeats is used to set a specific number of available passenger seats of a flight model.
        /// </summary>
        public int AvailablePassengerSeats { get; set; }
        /// <summary>
        /// AvailableBusinessClassSeats is used to set a specific number of available business class seats of a flight model.
        /// </summary>
        public int AvailableBusinessClassSeats { get; set; }
    }
}
