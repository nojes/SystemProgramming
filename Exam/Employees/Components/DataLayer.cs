using System;
using System.Threading;
using System.Threading.Tasks;
using Employees.Models;

namespace Employees.Components
{
    static class DataLayer
    {
        public static Employee GetEmployee()
        {
            Thread.Sleep(4000);

            Random r = new Random();
            int id = r.Next(1, 100);

            return new Employee() {
                EmployeeId = id,
                FirstName = "FirstName" + id,
                LastName = "LastName" + id
            };
        }

        public static Task<Employee> GetEmployeeAsync()
        {
            return Task.Run(() => GetEmployee());
        }
    }

}