using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;

namespace _03_AsyncEmployee.Entities
{
    static class DataLayer
    {
        public static List<Employee> GetEmployees()
        {
            Thread.Sleep(5000);

            return new List<Employee>() {
                new Employee() { EmployeeId = 1,  FirstName = "Igor", LastName = "Krivonos",  DateBirthday = new DateTime(1958,8,15), INN="111111111"},
                new Employee() { EmployeeId = 2,  FirstName = "Ivan", LastName = "Darada",  DateBirthday = new DateTime(1980,4,22), INN="222222222"},
                new Employee() { EmployeeId = 3,  FirstName = "Petr", LastName = "Sivoy",  DateBirthday = new DateTime(1989,3,17), INN="333333333"},
                new Employee() { EmployeeId = 4,  FirstName = "Dasha", LastName = "Sejneko",  DateBirthday = new DateTime(1991,2,21), INN="777777777"},
                new Employee() { EmployeeId = 6,  FirstName = "Semen", LastName = "Rakov",  DateBirthday = new DateTime(1998,2,21), INN="999999999"} ,
                new Employee() { EmployeeId = 12,  FirstName = "Yulia", LastName = "Gumenuk",  DateBirthday = new DateTime(1995,5,5), INN="1212121212"}
            };
        }

        public static Task<List<Employee>> GetEmployeesAsync()
        {
            return Task.Run(() => GetEmployees());
        }
    }

}