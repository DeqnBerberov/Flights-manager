using System;
using System.Collections.Generic;
using System.Text;

namespace Database.Entities
{
    /// <summary>
    /// This is class Passenger.
    /// </summary>
    public class Passenger
    {
        /// <summary>
        /// This represents the id of a passenger.
        /// </summary>
        public int Id { get; set; }
        /// <summary>
        /// This represents the first name of a passenger.
        /// </summary>
        public string FirstName { get; set; }
        /// <summary>
        /// This represents the surname of a passenger.
        /// </summary>
        public string Surname { get; set; }
        /// <summary>
        /// This represents the last name of a passenger.
        /// </summary>
        public string Lastname { get; set; }
        /// <summary>
        /// This represents the Unique Special Number of a passenger.
        /// </summary>
        public string USN { get; set; }
        /// <summary>
        /// This represents the phone number of a passenger.
        /// </summary>
        public string PhoneNumber { get; set; }
        /// <summary>
        /// This represents the nationality of a passenger.
        /// </summary>
        public string Nationality { get; set; }
        /// <summary>
        /// This represents the ticket type of a passenger.
        /// </summary>
        public string TicketType { get; set; }
        /// <summary>
        /// This represents the reservation id of a passenger.
        /// </summary>
        public int ReservationId { get; set; }
        /// <summary>
        /// This represents an empty constructor of passenger.
        /// </summary>
        public Passenger() { }
        /// <summary>
        /// This represents the full constructor of a passenger.
        /// </summary>
        /// <param name="id">Sets the id of a passenger.</param>
        /// <param name="fn">Sets the first name of a passenger.</param>
        /// <param name="surn">Sets the surname of a passenger.</param>
        /// <param name="ln">Sets the last name of a passenger.</param>
        /// <param name="usn">Sets the USN of a passenger.</param>
        /// <param name="phn">Sets the phone number of a passenger.</param>
        /// <param name="nat">Sets the nationality of a passenger.</param>
        /// <param name="ticket">Sets the ticket type of a passenger.</param>
        /// <param name="resid">Sets the reservation id of a passenger.</param>
        public Passenger(int id, string fn, string surn, string ln, string usn, string phn, string nat, string ticket, int resid) 
        {
            this.Id = id;
            this.FirstName = fn;
            this.Surname = surn;
            this.Lastname = ln;
            this.USN = usn;
            this.PhoneNumber = phn;
            this.Nationality = nat;
            this.TicketType = ticket;
            this.ReservationId = resid;
        }
    }
}
