using Flights_manager.Models.Passenger;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Flights_manager.Models.Reservation
{
    /// <summary>
    /// This is class SingleReservationViewModel.
    /// </summary>
    public class SingleReservationViewModel
    {
        /// <summary>
        /// Id is used to set the id of a reservation model.
        /// </summary>
        public int Id { get; set; }
        /// <summary>
        /// Email is used to set the email of the passenger who booked a reservation.
        /// </summary>
        public string Email { get; set; }
        /// <summary>
        /// Passengers is a list full of passengers in the database.
        /// </summary>
        public List<SinglePassengerViewModel> Passengers { get; set; }
    }
}
