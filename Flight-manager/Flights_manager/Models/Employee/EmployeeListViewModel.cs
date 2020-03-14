using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Flights_manager.Models;
using Flights_manager.Models.Shared;

namespace Flights_manager
{
    /// <summary>
    /// This is class EmployeeListViewModel.
    /// </summary>
    public class EmployeeListViewModel
    {
        /// <summary>
        /// Pager is used for getting the current web page.
        /// </summary>
        public PagerViewModel Pager { get; set; }
        /// <summary>
        /// RegisteredEmployees is used for getting a full list of all available employees in the database.
        /// </summary>
        public ICollection<SingleEmployeeViewModel> RegisteredEmployees { get; set; }
    }
}
