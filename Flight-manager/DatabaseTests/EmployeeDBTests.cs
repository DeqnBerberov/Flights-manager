using Database.Entities;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Tests
{
    [TestClass]
    public class EmployeeDBTests
    {
        [TestMethod]
        public void TestEmployeeID()
        {
            Employee employee = new Employee(1,"Deyan", "deqndeqn", "deqnberberov@gmail.com", "Berberov", "Borislavov", 
                "0123456789", "Sofia", "0877531812", "Administrator");
            int expected = 1;

            Assert.AreEqual(expected,
                employee.Id,
                "EmployeeID must be int and is incorrectly set.");
        }
        [TestMethod]
        public void TestEmployeeUsername()
        {
            Employee employee = new Employee(1, "Deyan", "deqndeqn", "deqnberberov@gmail.com", "Berberov", "Borislavov",
                "0123456789", "Sofia", "0877531812", "Administrator");
            string expected= "Deyan";

            Assert.AreEqual(expected,
                employee.Username,
                "Employees username must be string and is incorrectly set.");
        }
        [TestMethod]
        public void TestEmployeePassword()
        {
            Employee employee = new Employee(1, "Deyan", "deqndeqn", "deqnberberov@gmail.com", "Berberov", "Borislavov",
                "0123456789", "Sofia", "0877531812", "Administrator");
            string expected = "deqndeqn";

            Assert.AreEqual(expected,
                employee.Password,
                "Employees password must be string and is incorrectly set.");
        }
        [TestMethod]
        public void TestEmployeeEmail()
        {
            Employee employee = new Employee(1, "Deyan", "deqndeqn", "deqnberberov@gmail.com", "Berberov", "Borislavov",
                "0123456789", "Sofia", "0877531812", "Administrator");
            string expected = "deqnberberov@gmail.com";

            Assert.AreEqual(expected,
                employee.Email,
                "Employees email must be string and is incorrectly set.");
        }
        [TestMethod]
        public void TestEmployeeFN()
        {
            Employee employee = new Employee(1, "Deyan", "deqndeqn", "deqnberberov@gmail.com", "Berberov", "Borislavov",
                "0123456789", "Sofia", "0877531812", "Administrator");
            string expected = "Berberov";

            Assert.AreEqual(expected,
                employee.Firstname,
                "Employees Firstname must be string and is incorrectly set.");
        }
        [TestMethod]
        public void TestEmployeeLN()
        {
            Employee employee = new Employee(1, "Deyan", "deqndeqn", "deqnberberov@gmail.com", "Berberov", "Borislavov",
                "0123456789", "Sofia", "0877531812", "Administrator");
            string expected = "Borislavov";

            Assert.AreEqual(expected,
                employee.Lastname,
                "Employees Lastname must be string and is incorrectly set.");
        }
        [TestMethod]
        public void TestEmployeeUSN()
        {
            Employee employee = new Employee(1, "Deyan", "deqndeqn", "deqnberberov@gmail.com", "Berberov", "Borislavov",
                "0123456789", "Sofia", "0877531812", "Administrator");
            string expected = "0123456789";

            Assert.AreEqual(expected,
                employee.USN,
                "Employees USN must be string and is incorrectly set.");
        }
        [TestMethod]
        public void TestEmployeeAddress()
        {
            Employee employee = new Employee(1, "Deyan", "deqndeqn", "deqnberberov@gmail.com", "Berberov", "Borislavov",
                "0123456789", "Sofia", "0877531812", "Administrator");
            string expected = "Sofia";

            Assert.AreEqual(expected,
                employee.Address,
                "Employees Address must be string and is incorrectly set.");
        }
        [TestMethod]
        public void TestEmployeePN()
        {
            Employee employee = new Employee(1, "Deyan", "deqndeqn", "deqnberberov@gmail.com", "Berberov", "Borislavov",
                "0123456789", "Sofia", "0877531812", "Administrator");
            string expected = "0877531812";

            Assert.AreEqual(expected,
                employee.PhoneNumber,
                "Employees PhoneNumber must be string and is incorrectly set.");
        }
        [TestMethod]
        public void TestEmployeeRole()
        {
            Employee employee = new Employee(1, "Deyan", "deqndeqn", "deqnberberov@gmail.com", "Berberov", "Borislavov",
                "0123456789", "Sofia", "0877531812", "Administrator");
            string expected = "Administrator";

            Assert.AreEqual(expected,
                employee.Role,
                "Employees Role must be string and is incorrectly set.");
        }
    }
}
