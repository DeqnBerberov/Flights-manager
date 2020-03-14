using System;
using System.Collections.Generic;
using System.Text;

namespace Database.Entities
{
    /// <summary>
    /// This is class Employee.
    /// </summary>
    public class Employee
    {
        /// <summary>
        /// This represents the id of an employee.
        /// </summary>
        public int Id { get; set; }
        /// <summary>
        /// This represents the username of an employee.
        /// </summary>
        public string Username { get; set; }
        /// <summary>
        /// This represents the password of an employee.
        /// </summary>
        public string Password { get; set; }
        /// <summary>
        /// This represents the email of an employee.
        /// </summary>
        public string Email { get; set; }
        /// <summary>
        /// This represents the firstname of an employee.
        /// </summary>
        public string Firstname { get; set; }
        /// <summary>
        /// This represents the lastname of an employee.
        /// </summary>
        public string Lastname { get; set; }
        /// <summary>
        /// This represents the Unique Special Number of an employee.
        /// </summary>
        public string USN { get; set; }
        /// <summary>
        /// This represents the address of an employee.
        /// </summary>
        public string Address { get; set; }
        /// <summary>
        /// This represents the phone number of an employee.
        /// </summary>
        public string PhoneNumber { get; set; }
        /// <summary>
        /// This represents the role of an employee.
        /// </summary>
        public string Role { get;  set; }
        /// <summary>
        /// This represents an empty constructor of employee.
        /// </summary>
        public Employee() { }
        /// <summary>
        /// This represents the full constructor of an employee
        /// </summary>
        /// <param name="id">Sets the id of an employee.</param>
        /// <param name="un">Sets the username of an employee.</param>
        /// <param name="pass">Sets the password of an employee.</param>
        /// <param name="email">Sets the email of an employee.</param>
        /// <param name="fn">Sets the first name of an employee.</param>
        /// <param name="ln">Sets the last name of an employee.</param>
        /// <param name="usn">Sets the USN of an employee.</param>
        /// <param name="address">Sets the address of an employee.</param>
        /// <param name="pn">Sets the phone number of an employee.</param>
        /// <param name="role">Sets the role of an employee.</param>
        public Employee(int id, string un, string pass, string email, string fn, string ln, string usn, string address, string pn, string role)
        {
            this.Id = id;
            this.Username = un;
            this.Password = pass;
            this.Email = email;
            this.Firstname = fn;
            this.Lastname = ln;
            this.USN = usn;
            this.Address = address;
            this.PhoneNumber = pn;
            this.Role = role;
        }
    }
}
