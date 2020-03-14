using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Flights_manager.Models
{
    /// <summary>
    /// This is class SingleEmployeeViewModel.
    /// </summary>
    public class SingleEmployeeViewModel
    {
        /// <summary>
        /// Id is used to set Id to an employee model.
        /// </summary>
        public int Id { get; set; }
        /// <summary>
        /// Username is used to set a username to an employee model.
        /// </summary>
        public string Username { get; set; }
        /// <summary>
        /// Password is used to set a password to an employee model.
        /// </summary>
        public string Password { get; set; }
        /// <summary>
        /// Email is used to send an email to an employee model.
        /// </summary>
        public string Email { get; set; }
        /// <summary>
        /// Firstname is used to set the first name of an employee model.
        /// </summary>
        public string Firstname { get; set; }
        /// <summary>
        /// Lastname is used to set the last name of an employee model.
        /// </summary>
        public string Lastname { get; set; }
        /// <summary>
        /// USN is used to set the usn to an employee model.
        /// </summary>
        public string USN { get; set; }
        /// <summary>
        /// Address is used to set address of an employee model.
        /// </summary>
        public string Address { get; set; }
        /// <summary>
        /// PhoneNumber is used to set phone number of an employee model.
        /// </summary>
        public string PhoneNumber { get; set; }
        /// <summary>
        /// Role is used to set a role of an employee model.
        /// </summary>
        public string Role { get; set; }
    }
}
