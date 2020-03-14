using System;
using System.Collections.Generic;
using System.Text;

namespace Database.Entities
{
    /// <summary>
    /// This is class Flight.
    /// </summary>
    public class Flight
    {
        /// <summary>
        /// This represents the id of a flight.
        /// </summary>
        public int Id { get; set; }
        /// <summary>
        /// This represents the take off location of a flight.
        /// </summary>
        public string TakeOffLocation { get; set; }
        /// <summary>
        /// This represents the ladning location of a flight.
        /// </summary>
        public string LandingLocation { get; set; }
        /// <summary>
        /// This represents the time of the take off of a flight.
        /// </summary>
        public DateTime TakeOff { get; set; }
        /// <summary>
        /// This represents the time of the landing of a flight.
        /// </summary>
        public DateTime Landing { get; set; }
        /// <summary>
        /// This represents the type of a plane.
        /// </summary>
        public string TypePlane { get; set; }
        /// <summary>
        /// This represents the id of a plane.
        /// </summary>
        public int PlaneId { get; set; }
        /// <summary>
        /// This represents the pilot name.
        /// </summary>
        public string PilotName { get; set; }
        /// <summary>
        /// This represents the available passenger seats of a flight.
        /// </summary>
        public int AvailablePassengerSeats { get; set; }
        /// <summary>
        /// This represents the available business class seats of a flight.
        /// </summary>
        public int AvailableBusinessClassSeats { get; set; }
        /// <summary>
        /// This represents an empty constructor of a flight.
        /// </summary>
        public Flight() { }
        /// <summary>
        /// This represents the full constructor of a flight.
        /// </summary>
        /// <param name="id">Sets the id of a flight.</param>
        /// <param name="from">Sets the take off location of a flight.</param>
        /// <param name="to">Sets the landing location of a flight.</param>
        /// <param name="takeoff">Sets the time of the take off for a flight.</param>
        /// <param name="landing">Sets the time of the landing for a flight.</param>
        /// <param name="typeplane">Sets the type of a plane.</param>
        /// <param name="pid">Sets the plane id.</param>
        /// <param name="pilotname">Sets the pilots name of a plane.</param>
        /// <param name="AvPassSeats">Sets the available passenger seats.</param>
        /// <param name="AvBusSeats">Sets the available business class seats.</param>
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
