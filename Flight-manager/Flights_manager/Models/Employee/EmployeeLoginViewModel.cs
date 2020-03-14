using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using Microsoft.AspNetCore.Mvc;

namespace Flights_manager.Models
{
    /// <summary>
    /// This is class EmployeeLoginViewModel.
    /// </summary>
    public class EmployeeLoginViewModel
    {   
        /// <summary>
        /// Username is used to set a username to a user.
        /// </summary>
        [Required]
        public string Username { get; set; }
        /// <summary>
        /// Password is used to set a passowrd to a user.
        /// </summary>
        [Required]
        public string Password { get; set; }
    }
}
