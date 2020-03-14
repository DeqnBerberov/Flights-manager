using System;
using System.Collections.Generic;
using System.Text;

namespace Database.Entities
{
    public class Passenger
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string Surname { get; set; }
        public string Lastname { get; set; }
        public string USN { get; set; }
        public string PhoneNumber { get; set; }
        public string Nationality { get; set; }
        public string TicketType { get; set; }
        public int ReservationId { get; set; }

        public Passenger() { }

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
