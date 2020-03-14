using System;
using System.Collections.Generic;
using System.Text;

namespace Database.Entities
{
    public class Flight
    {
        public int Id { get; set; }
        public string TakeOffLocation { get; set; }
        public string LandingLocation { get; set; }
        public DateTime TakeOff { get; set; }
        public DateTime Landing { get; set; }
        public string TypePlane { get; set; }
        public int PlaneId { get; set; }
        public string PilotName { get; set; }
        public int AvailablePassengerSeats { get; set; }
        public int AvailableBusinessClassSeats { get; set; }

        public Flight() { }
        public Flight(int id, string from, string to, DateTime takeoff, DateTime landing, string typeplane, int pid, 
            string pilotname, int AvPassSeats, int AvBusSeats)
        {
            this.Id = id;
            this.TakeOffLocation = from;
            this.LandingLocation = to;
            this.TakeOff = takeoff;
            this.Landing = landing;
            this.TypePlane = typeplane;
            this.PlaneId = pid;
            this.PilotName = pilotname;
            this.AvailablePassengerSeats = AvPassSeats;
            this.AvailableBusinessClassSeats = AvBusSeats;
        }
    }
}
