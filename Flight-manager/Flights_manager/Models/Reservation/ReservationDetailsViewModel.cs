using Flights_manager.Models.Passenger;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Flights_manager.Models.Reservation
{
    /// <summary>
    /// This is class ReservationDetailsViewModel.
    /// </summary>
    public class ReservationDetailsViewModel
    {
        /// <summary>
        /// Email is used to set email of the passenger that has booked a reservation.
        /// </summary>
        public string Email { get; set; }
        /// <summary>
        /// Passenger is a list full of passengers in the database.
        /// </summary>
        public List<SinglePassengerViewModel> Passengers { get; set; }
    }
}
