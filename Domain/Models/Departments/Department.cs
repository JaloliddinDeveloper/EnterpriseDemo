using Domain.Models.Employees;
using System.Collections.Generic;

namespace Domain.Models.Departments
{
    public class Department
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public List<Employee> Employees { get; set; }
    }
}
