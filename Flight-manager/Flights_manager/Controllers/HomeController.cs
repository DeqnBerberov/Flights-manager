using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Flights_manager.Models;
using Database;
using Database.Entities;
using Flights_manager.Models.Shared;
using Microsoft.EntityFrameworkCore;
using Flights_manager.Models.Flight;
using Flights_manager.Models.Passenger;
using Flights_manager.Models.Reservation;
using System.Net.Mail;

namespace Flights_manager.Controllers
{
    /// <summary>
    /// This is class HomeController. It controls all functions for the database.
    /// </summary>
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly Flights_manager_DB _context;
        private const int PageSize = 10;
        private int reservationsCount;
        /// <summary>
        /// This function is used to connect with the web page.
        /// </summary>
        /// <param name="logger"> Connects web page parameters with C#.</param>
        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
            _context = new Flights_manager_DB();
            reservationsCount = _context.Reservations.Count();
        }
        /// <summary>
        /// This function is used to represent the web page.
        /// </summary>
        /// <returns> Returns the view of the current page.</returns>
        public IActionResult Index()
        {
            return View();
        }
        /// <summary>
        /// This function creates a list full of all the current available flights.
        /// </summary>
        /// <param name="model"> Uses the parameters of a flight.</param>
        /// <returns> Returns the user to the current web page.</returns>
        [HttpGet]
        public async Task<IActionResult> Index(FlightListViewModel model)
        {
            List<SingleFlightViewModel> items = await _context.Flights.Select(f => new SingleFlightViewModel()
            {
                Id = f.Id,
                TakeOffLocation = f.TakeOffLocation,
                LandingLocation = f.LandingLocation,
                TakeOff = f.TakeOff,
                Landing = f.Landing,
                TypePlane = f.TypePlane,
                PlaneId = f.PlaneId,
                PilotName = f.PilotName,
                AvailablePassengerSeats = f.AvailablePassengerSeats,
                AvailableBusinessClassSeats = f.AvailableBusinessClassSeats
            }).ToListAsync();
            model.Flights = items;
            return View(model);
        }
        /// <summary>
        /// This function is used to represent the login web page.
        /// </summary>
        /// <returns>Returns the user to the login page.</returns>
        public IActionResult Login()
        {
            return View();
        }
        /// <summary>
        /// This function is used for login.
        /// </summary>
        /// <param name="model"> Uses the parameters of an employee.</param>
        /// <returns> Returns the user to a specific web page. Admins-> List of employees. Employees-> List of flights </returns>
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Login(EmployeeLoginViewModel model)
        {
            if (_context.Employees.Any(e => e.Username == model.Username))
            {
                if (_context.Employees.Any(e => e.Password == model.Password))
                {
                    if (_context.Employees.Any(e => e.Username == model.Username && e.Role == "Administrator"))
                    {
                        return RedirectToAction(nameof(ListEmployees));                                             
                    }
                    else if (_context.Employees.Any(e => e.Username == model.Username && e.Role == "Employee"))
                    {
                        return RedirectToAction(nameof(ListFlights));  
                    }
                }
            }
            return View();
        }
        /// <summary>
        /// This function is used to register a user.
        /// </summary>
        /// <param name="model"> Uses a parameters of an employee.</param>
        /// <returns> Returns the user to a specific web page.</returns>
        public async Task<IActionResult> Register(EmployeeRegisterViewModel model)
        {
            if(ModelState.IsValid)
            {
                Employee employee = new Employee();
                if(_context.Employees.Count()==0)
                {
                    employee.Role = "Administrator";
                }
                else
                {
                    employee.Role = "Employee";
                }
                employee.Username = model.Username;
                employee.Password = model.Password;
                employee.Email = model.Email;
                employee.Firstname = model.Firstname;
                employee.Lastname = model.Lastname;
                employee.USN = model.USN;
                employee.Address = model.Address;
                employee.PhoneNumber = model.PhoneNumber;
                _context.Add(employee);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(ListEmployees));
            }
            return View(model);
        }
        /// <summary>
        /// This function creates a list full of all the current employees.
        /// </summary>
        /// <param name="model"> Uses a parameters of an employee.</param>
        /// <returns> Returns a web page with a list full all the registered employees.</returns>
        [HttpGet]
        public async Task<IActionResult> ListEmployees(EmployeeListViewModel model)
        {
            model.Pager ??= new PagerViewModel();
            model.Pager.CurrentPage = model.Pager.CurrentPage <= 0 ? 1 : model.Pager.CurrentPage;

            List<SingleEmployeeViewModel> items = await _context.Employees.Skip((model.Pager.CurrentPage - 1) * PageSize).Take(PageSize).Select(e => new SingleEmployeeViewModel()
            {
                Id = e.Id,
                Username = e.Username,
                Password = e.Password,
                Email = e.Email,
                Firstname = e.Firstname,
                Lastname = e.Lastname,
                USN = e.USN,
                Address = e.Address,
                PhoneNumber = e.PhoneNumber,
                Role = e.Role
            }).ToListAsync();
            model.RegisteredEmployees = items;
            model.Pager.PagesCount = (int)Math.Ceiling(await _context.Employees.CountAsync() / (double)PageSize);

            return View(model);
        }
        /// <summary>
        /// This function is used to edit employees.
        /// </summary>
        /// <param name="id"> Represents id of the employee we want to edit. It is int? because it can be null.</param>
        /// <returns> Returns a web page with a list full all the registered employees.</returns>
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Employee employee = await _context.Employees.FindAsync(id);
            if (employee == null)
            {
                return NotFound();
            }

            EmployeeEditViewModel model = new EmployeeEditViewModel
            {
                Id = employee.Id,
                Username = employee.Username,
                Password = employee.Password,
                Email = employee.Email,
                Firstname = employee.Firstname,
                Lastname = employee.Lastname,
                USN = employee.USN,
                Address = employee.Address,
                PhoneNumber = employee.PhoneNumber,
                Role = employee.Role
            };

            return View(model);
        }
        /// <summary>
        /// This function saves the changes of an edited employee to the database.
        /// </summary>
        /// <param name="model"> Uses parameters of an employee.</param>
        /// <returns> Returns a web page with a list full all the registered employees.</returns>
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(EmployeeEditViewModel model)
        {
            if (ModelState.IsValid)
            {
                Employee employee = new Employee
                {
                    Id = model.Id,
                    Username = model.Username,
                    Password = model.Password,
                    Email = model.Email,
                    Firstname = model.Firstname,
                    Lastname = model.Lastname,
                    USN = model.USN,
                    Address = model.Address,
                    PhoneNumber = model.PhoneNumber,
                    Role = model.Role
                };

                try
                {
                    _context.Update(employee);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!EmployeeExists(employee.Id))
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }
                }

                return RedirectToAction(nameof(ListEmployees));
            }

            return View(model);
        }
        /// <summary>
        /// This function is used to delete an employee.
        /// </summary>
        /// <param name="id"> Represents id of the employee we want to edit.</param>
        /// <returns> Returns a web page with a list full all the registered employees.</returns>
        public async Task<IActionResult> Delete(int id)
        {
            Employee employee = await _context.Employees.FindAsync(id);
            _context.Employees.Remove(employee);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(ListEmployees));
        }
        /// <summary>
        /// This function is used to add a flight.
        /// </summary>
        /// <param name="model"> Uses parameters of a flight.</param>
        /// <returns> Returns the user to a specific web page.</returns>
        public async Task<IActionResult> AddFlight(FlightAddViewModel model)
        {
            if (ModelState.IsValid)
            {
                if (model.Landing < model.TakeOff)
                {
                    return View(model);
                }
                Flight flight = new Flight();
                flight.TakeOffLocation = model.TakeOffLocation;
                flight.LandingLocation = model.LandingLocation;
                flight.TakeOff = model.TakeOff;
                flight.Landing = model.Landing;
                flight.TypePlane = model.TypePlane;
                flight.PlaneId = model.PlaneId;
                flight.PilotName = model.PilotName;
                flight.AvailablePassengerSeats = model.AvailablePassengerSeats;
                flight.AvailableBusinessClassSeats = model.AvailableBusinessClassSeats;
                _context.Add(flight);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(ListFlights));
            }
            return View(model);
        }
        /// <summary>
        /// This function creates a list of all the available flights.
        /// </summary>
        /// <param name="model"> Uses parameters of a flight.</param>
        /// <returns> Returns the user to a specific web page.</returns>
        [HttpGet]
        public async Task<IActionResult> ListFlights(FlightListViewModel model)
        {
            List<SingleFlightViewModel> items = await _context.Flights.Select(f => new SingleFlightViewModel()
            {
                Id = f.Id,
                TakeOffLocation = f.TakeOffLocation,
                LandingLocation = f.LandingLocation,
                TakeOff = f.TakeOff,
                Landing = f.Landing,
                TypePlane = f.TypePlane,
                PlaneId = f.PlaneId,
                PilotName = f.PilotName,
                AvailablePassengerSeats = f.AvailablePassengerSeats,
                AvailableBusinessClassSeats = f.AvailableBusinessClassSeats
            }).ToListAsync();
            model.Flights = items;
            return View(model);
        }
        /// <summary>
        /// This function is used to edit a flight.
        /// </summary>
        /// <param name="id"> Represents id of the flight we want to edit. It is int? because it can be null.</param>
        /// <returns> Returns a web page with a list full of all the available flights.</returns>
        public async Task<IActionResult> EditFlight(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Flight flight = await _context.Flights.FindAsync(id);
            if (flight == null)
            {
                return NotFound();
            }

            FlightEditViewModel model = new FlightEditViewModel
            {
                Id = flight.Id,
                TakeOffLocation = flight.TakeOffLocation,
                LandingLocation = flight.LandingLocation,
                TakeOff = flight.TakeOff,
                Landing = flight.Landing,
                TypePlane = flight.TypePlane,
                PlaneId = flight.PlaneId,
                PilotName = flight.PilotName,
                AvailablePassengerSeats = flight.AvailablePassengerSeats,
                AvailableBusinessClassSeats = flight.AvailableBusinessClassSeats
            };

            return View(model);
        }
        /// <summary>
        /// This function updates the edited flight.
        /// </summary>
        /// <param name="model"> Uses parameters of flight.</param>
        /// <returns> Returns the user to a specific web page.</returns>
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> EditFlight(FlightEditViewModel model)
        {
            if (ModelState.IsValid)
            {
                Flight flight = new Flight
                {
                    Id = model.Id,
                    TakeOffLocation = model.TakeOffLocation,
                    LandingLocation = model.LandingLocation,
                    TakeOff = model.TakeOff,
                    Landing = model.Landing,
                    TypePlane = model.TypePlane,
                    PlaneId = model.PlaneId,
                    PilotName = model.PilotName,
                    AvailablePassengerSeats = model.AvailablePassengerSeats,
                    AvailableBusinessClassSeats = model.AvailableBusinessClassSeats
                };

                try
                {
                    _context.Update(flight);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!EmployeeExists(flight.Id))
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }
                }

                return RedirectToAction(nameof(ListFlights));
            }

            return View(model);
        }
        /// <summary>
        /// This function is used to delete flight.
        /// </summary>
        /// <param name="id"> Represents id of the flight we want to delete.</param>
        /// <returns> Returns updates list of all flights.</returns>
        public async Task<IActionResult> DeleteFlight(int id)
        {
            Flight flight = await _context.Flights.FindAsync(id);
            _context.Flights.Remove(flight);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(ListFlights));
        }
        /// <summary>
        /// This function is used to add a passenger to a flight.
        /// </summary>
        /// <param name="model"> Uses parameters of a passenger.</param>
        /// <returns> Returns updated passnegers of a flight. Also returns user to a specific web page.</returns>
        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> AddPassenger(PassengerAddViewModel model)
        {
            if (ModelState.IsValid)
            {
                Passenger passenger = new Passenger
                {
                    FirstName = model.FirstName,
                    Surname = model.Surname,
                    Lastname = model.LastName,
                    USN = model.USN,
                    PhoneNumber = model.PhoneNumber,
                    Nationality = model.Nationality,
                    TicketType = model.TicketType,
                    ReservationId = reservationsCount
                };
                _context.Add(passenger);             
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(AddPassenger));
            }
            return View(model);
        }
        /// <summary>
        /// This function is used to add a passenger.
        /// </summary>
        /// <returns> Returns a view of the updated passenger.</returns>
        public IActionResult AddPassenger()
        {
            PassengerAddViewModel passenger = new PassengerAddViewModel();
            return View(passenger);
        }
        /// <summary>
        /// This function is used to make a reservation. 
        /// </summary>
        /// <param name="model"> Uses parameters of a reservation.</param>
        /// <returns></returns>
        public async Task<IActionResult> MakeReservation(ReservationMakeViewModel model)
        {
            if (ModelState.IsValid)
            {
                Reservation reservation = new Reservation()
                {
                    Email = model.Email
                };
                string receivermail = model.Email;
                SendEmail(receivermail);
                _context.Add(reservation);
                reservationsCount++;
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(AddPassenger));
            }
            return View(model);
        }

        /// <summary>
        /// This function is used to send email to user for a reservation.
        /// </summary>
        /// <param name="receiver"> The receiver is an email of the user that has made a reservation.</param>
        void SendEmail(string receivermail)
        {
            MailMessage mail = new MailMessage();
            Reservation reservation = new Reservation();
            mail.From = new MailAddress("suflightmanager@gmail.com");
            mail.To.Add(receivermail);
            mail.Subject = "Confirmed reservation";
            mail.Body = mail.Body = $"Your flight has been booked! Below are your details:\n" +
                        $"Reservation ID:{reservation.Id}\n" +
                        $"Confirmation email:{reservation.Email}\n" +
                        $""; 
            SmtpClient SmtpServer = new SmtpClient();
            SmtpServer.Host = "smtp.gmail.com";
            SmtpServer.Credentials = new System.Net.NetworkCredential("suflightmanager@gmail.com", "Flight_manager");
            SmtpServer.Port = 587;
            SmtpServer.EnableSsl = true;

            SmtpServer.Send(mail);
        }
        /// <summary>
        /// This function is used to display all the available reservations.
        /// </summary>
        /// <param name="model"> Uses parameters of a reservation.</param>
        /// <returns> Returns the user to a specific web page.</returns>
        public async Task<IActionResult> ListReservations(ReservationListViewModel model)
        {
            List<SingleReservationViewModel> items = await _context.Reservations.Select(r => new SingleReservationViewModel()
            {
                Id = r.Id,
                Email = r.Email,
                Passengers = PassengerConvertor(r.Passengers)
            }).ToListAsync();
            model.Reservations = items;
            return View(model);
        }
        /// <summary>
        /// This function is used to edit passengers ticket type.
        /// </summary>
        /// <param name="passengers"> All available passengers.</param>
        /// <returns> Returns updated list.</returns>
        private static List<SinglePassengerViewModel> PassengerConvertor(List<Passenger> passengers)
        {
            var converted = new List<SinglePassengerViewModel>();
            foreach(var item in passengers)
            {
                var model = new SinglePassengerViewModel
                {
                    Id = item.Id,
                    FirstName = item.FirstName,
                    Surname = item.Surname,
                    LastName = item.Lastname,
                    USN = item.USN,
                    PhoneNumber = item.PhoneNumber,
                    Nationality = item.Nationality,
                    TicketType = item.TicketType,
                    ReservationId = item.ReservationId
                };
                converted.Add(model);
            }
            return converted;
        }
        /// <summary>
        /// This function is used to display details about a reservation.
        /// </summary>
        /// <param name="id"> </param>
        /// <return> Returns the user to a specific web page.</returns>
        public IActionResult ReservationDetails(int? id)
        {
            var model = new ReservationDetailsViewModel();
            model.Email = _context.Reservations.Find(id).Email;
            var passengers = new List<SinglePassengerViewModel>();
            foreach(var item in _context.Passengers.Where(p => p.ReservationId == id))
            {
                var passenger = new SinglePassengerViewModel
                {
                    Id = item.Id,
                    FirstName = item.FirstName,
                    Surname = item.Surname,
                    LastName = item.Lastname,
                    USN = item.USN,
                    PhoneNumber = item.PhoneNumber,
                    Nationality = item.Nationality,
                    TicketType = item.TicketType,
                    ReservationId = item.ReservationId
                };
                passengers.Add(passenger);
            }
            model.Passengers = passengers;
            return View(model);
        }
        /// <summary>
        /// This function is used when an  Error occures.
        /// </summary>
        /// <returns> Returns a web page with a specific error.</returns>
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
        /// <summary>
        /// This function is used to verify that an employee exists in the database.
        /// </summary>
        /// <param name="id"> Represents the id of the user we want to verify.</param>
        /// <returns> Returns if the user exists.</returns>
        private bool EmployeeExists(int id)
        {
            return _context.Employees.Any(e => e.Id == id);
        }
    }
}