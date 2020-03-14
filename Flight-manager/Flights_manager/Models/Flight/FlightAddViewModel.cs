using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Flights_manager.Models.Flight
{
    public class FlightAddViewModel
    {
        [Required]
        public string TakeOffLocation { get; set; }

        [Required]
        public string LandingLocation { get; set; }

        [Required]
        public DateTime TakeOff { get; set; }

        [Required]
        public DateTime Landing { get; set; }

        [Required]
        public string TypePlane { get; set; }

        [Required]
        public int PlaneId { get; set; }

        [Required]
        public string PilotName { get; set; }

        [Required]
        public int AvailablePassengerSeats { get; set; }

        [Required]
        public int AvailableBusinessClassSeats { get; set; }
    }
}
