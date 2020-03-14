using Database.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace Database
{
    /// <summary>
    /// This is class Flights_manager_DB. It contains the database connection string.
    /// </summary>
    public class Flights_manager_DB : DbContext
    {
        /// <summary>
        /// This represents a list of an employees that can be used for CRUD operations.
        /// </summary>
        public DbSet<Employee> Employees { get; set; }
        /// <summary>
        /// This represents a list of a flights that can be used for CRUD operations.
        /// </summary>
        public DbSet<Flight> Flights { get; set; }
        /// <summary>
        /// This represents a list of a passengers that can be used for CRUD operations.
        /// </summary>
        public DbSet<Passenger> Passengers { get; set; }
        /// <summary>
        /// This represents a list of a reservations that can be used for CRUD operations.
        /// </summary>
        public DbSet<Reservation> Reservations { get; set; }
        /// <summary>
        /// This function contains the database string.
        /// </summary>
        /// <param name="optionsBuilder">Builds the database with a given connection string.</param>
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server=.\SQLEXPRESS;Database=FlightsManagerDB;Trusted_Connection=True;Integrated Security = True;");
        }
    }
}
