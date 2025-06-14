using Domain.Models.Departments;
using System;

namespace Domain.Models.Employees
{
    public class Employee
    {
        public int Id { get; set; }
        public string FullName { get; set; }
        public int Age { get; set; }

        public int DepartmentId { get; set; }
        public Department Department { get; set; }

        public void DisplayInfo()
        {
            Console.WriteLine($"Id: {Id}, Name: {FullName}, Age: {Age}, Department: {Department?.Name}");
        }
    }
}
