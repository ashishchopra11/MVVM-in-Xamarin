using MVVMPart1.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace MVVMPart1.Services
{
    class EmployeesServices
    {
        public List<Employee> GetEmployees()
        {
            var List = new List<Employee>
            {
                new Employee
                {
                    Name = "Mohamed",
                    Department = "Marketing"
                },
                new Employee
                {
                    Name = "SHah",
                    Department = "HR"
                },
                new Employee
                {
                    Name = "Ashish",
                    Department = "Development"
                },
                new Employee
                {
                    Name = "Modi",
                    Department = "PM"
                },
                new Employee
                {
                    Name = "Mohamed",
                    Department = "Marketing"
                },
            };
            return List;
        }

    }
}
