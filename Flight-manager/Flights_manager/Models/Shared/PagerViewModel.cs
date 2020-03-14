using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Flights_manager.Models.Shared
{
    /// <summary>
    /// This is class PagerViewModel.
    /// </summary>
    public class PagerViewModel
    {
        /// <summary>
        /// CurrentPage is used to set the current page.
        /// </summary>
        public int CurrentPage { get; set; }
        /// <summary>
        /// PagesCount is used to count all the existing web pages.
        /// </summary>
        public int PagesCount { get; set; }
    }
}
