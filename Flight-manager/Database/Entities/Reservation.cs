using Database.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Database
{
    /// <summary>
    /// This is class Reservation.
    /// </summary>
    public class Reservation
    {
        /// <summary>
        /// This represents the id of a reservation.
        /// </summary>
        public int Id { get; set; }
        /// <summary>
        /// This represents the email of a reservation.
        /// </summary>
        public string Email { get; set; }
        /// <summary>
        /// This represents the list of a passenger that booked a reservation.
        /// </summary>
        public List<Passenger> Passengers { get; set; }
    }
}
