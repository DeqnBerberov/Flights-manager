using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Flights_manager.Models.Flight
{
    /// <summary>
    /// This is class FlightListViewModel.
    /// </summary>
    public class FlightListViewModel
    {
        /// <summary>
        /// This returns a list of all available flights in the database.
        /// </summary>
        public ICollection<SingleFlightViewModel> Flights { get; set; }
    }
}
