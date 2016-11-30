using System;

namespace _03_AsyncEmployee.Entities
{
    class Employee
    {
        public int EmployeeId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public DateTime DateBirthday { get; set; }
        public string INN { get; set; }
    }
}