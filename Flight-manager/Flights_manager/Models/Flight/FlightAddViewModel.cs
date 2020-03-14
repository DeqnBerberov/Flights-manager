using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Flights_manager.Models.Flight
{
    /// <summary>
    /// This is class FlightAddViewModel.
    /// </summary>
    public class FlightAddViewModel
    {
        /// <summary>
        /// TakeOffLocation is used to set a take off location of a flight model.
        /// </summary>
        [Required]
        public string TakeOffLocation { get; set; }
        /// <summary>
        /// LandingLocation is used to set a landing location of a flight model.
        /// </summary>
        [Required]
        public string LandingLocation { get; set; }
        /// <summary>
        /// TakeOff is used to set a take off time of a flight model.
        /// </summary>
        [Required]
        public DateTime TakeOff { get; set; }
        /// <summary>
        /// Landing is used to set a landing time of a flight model.
        /// </summary>
        [Required]
        public DateTime Landing { get; set; }
        /// <summary>
        /// TypePlane is used to set the type of a flight model.
        /// </summary>
        [Required]
        public string TypePlane { get; set; }
        /// <summary>
        /// Plane id is used to set id of a plane of a flight model.
        /// </summary>
        [Required]
        public int PlaneId { get; set; }
        /// <summary>
        /// PilotName is used to set a name of a pilot of a flight model.
        /// </summary>
        [Required]
        public string PilotName { get; set; }
        /// <summary>
        /// AvailablePassengerSeats is used to set a specific number of available passenger seats of a flight model.
        /// </summary>
        [Required]
        public int AvailablePassengerSeats { get; set; }
        /// <summary>
        /// AvailableBusinessClassSeats is used to set a specific number of available business class seats of a flight model.
        /// </summary>
        [Required]
        public int AvailableBusinessClassSeats { get; set; }
    }
}
