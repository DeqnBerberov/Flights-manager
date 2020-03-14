using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Flights_manager.Models.Reservation
{
    /// <summary>
    /// Tgus us class ReservationListViewModel.
    /// </summary>
    public class ReservationListViewModel
    {
        /// <summary>
        /// Reservation is a list full of reservations in the database.
        /// </summary>
        public ICollection<SingleReservationViewModel> Reservations { get; set; }
    }
}
