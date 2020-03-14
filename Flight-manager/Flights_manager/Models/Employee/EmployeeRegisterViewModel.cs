using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using Microsoft.AspNetCore.Mvc;


namespace Flights_manager.Models
{
    /// <summary>
    /// This is class EmployeeRegisterViewModel
    /// </summary>
    public class EmployeeRegisterViewModel
    {
        /// <summary>
        /// This error checks if the username is longer than 15 characters.
        /// </summary>
        [Required]
        [MaxLength(15, ErrorMessage = "Username cannot be longer than 15 characters!")]
        public string Username { get; set; }
        /// <summary>
        /// This error checks if the password is shorter than 8 characters.
        /// </summary>
        [Required]
        [MinLength(8, ErrorMessage = "Password cannot be shorter than 8 characters!")]
        public string Password { get; set; }

        [Required]
        [EmailAddress]
        public string Email { get; set; }
        /// <summary>
        /// This error checks if the first name is longer than 15 characters.
        /// </summary>
        [Required]
        [MaxLength(15, ErrorMessage = "First name cannot be longer than 15 characters!")]
        public string Firstname { get; set; }
        /// <summary>
        /// This error checks if the last name is longer than 15 characters.
        /// </summary>
        [Required]
        [MaxLength(15, ErrorMessage = "Last name cannot be longer than 15 characters!")]
        public string Lastname { get; set; }
        /// <summary>
        /// This error checks if the personal id is between 8-10 symbols.
        /// </summary>
        [Required]
        [MinLength(8, ErrorMessage = "Personal ID cannot be shorter than 8 numbers!")]
        [MaxLength(10, ErrorMessage = "Personal ID cannot be longer than 10 numbers!")]
        public string USN { get; set; }
        /// <summary>
        /// This error checks the description of an address.
        /// </summary>
        [Required]
        [MaxLength(30, ErrorMessage = "Address must be described more briefly.")]
        [MinLength(15, ErrorMessage = "Address must be described more thoroughly.")]
        public string Address { get; set; }

        [Required]
        [Phone]
        public string PhoneNumber { get; set; }

        public string Role { get; set; }
    }
}
