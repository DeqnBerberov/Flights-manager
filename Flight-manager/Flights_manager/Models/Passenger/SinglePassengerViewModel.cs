using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Flights_manager.Models.Passenger
{
    /// <summary>
    /// This is class SinglePassengerViewModel.
    /// </summary>
    public class SinglePassengerViewModel
    {
        /// <summary>
        /// Id is used to set id of a passenger model.
        /// </summary>
        public int Id { get; set; }
        /// <summary>
        /// Firstname is used to set the first name of a passenger model.
        /// </summary>
        public string FirstName { get; set; }
        /// <summary>
        /// Firstname is used to set the surname of a passenger model.
        /// </summary>
        public string Surname { get; set; }
        /// <summary>
        /// Firstname is used to set the last name of a passenger model.
        /// </summary>
        public string LastName { get; set; }
        /// <summary>
        /// Firstname is used to set the first name of a passenger model.
        /// </summary>
        public string USN { get; set; }
        /// <summary>
        /// PhoneNumber is used to set phone number of a passenger model.
        /// </summary>
        public string PhoneNumber { get; set; }
        /// <summary>
        /// PhoneNumber is used to set the nationality of a passenger model.
        /// </summary>
        public string Nationality { get; set; }
        /// <summary>
        /// TicketType is used to set the type of the ticket of a passenger model.
        /// </summary>
        public string TicketType { get; set; }
        /// <summary>
        /// ReservationId is used to set reservation id of a passenger model.
        /// </summary>
        public int ReservationId { get; set; }

    }
}
