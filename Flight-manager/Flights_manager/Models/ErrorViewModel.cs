using System;

namespace Flights_manager.Models
{
    /// <summary>
    /// This is class ErrorViewModel.
    /// </summary>
    public class ErrorViewModel
    {
        /// <summary>
        /// RequestId is used to set the requested error.
        /// </summary>
        public string RequestId { get; set; }

        public bool ShowRequestId => !string.IsNullOrEmpty(RequestId);
    }
}
