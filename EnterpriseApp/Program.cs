using Domain.Models.Departments;
using Domain.Models.Employees;
using Infrastructure.Services.Departments;
using Infrastructure.Services.Employes;
using System.Collections.Generic;

var department1 = new Department
{
    Id = 1,
    Name = "Engineering",
    Description = "Handles all engineering tasks and projects.",
    Employees = new List<Employee>
    {
        new Employee { Id = 1, FullName = "Alice Smith", Age = 30, DepartmentId = 1 },
        new Employee { Id = 2, FullName = "Bob Johnson", Age = 25, DepartmentId = 1 }
    }
};


var employee1 = new Employee
{
    Id = 1,
    FullName = "Alice Smith",
    Age = 30,
    DepartmentId = 1,
    Department = department1
};

var employerServise = new EmployeService();
var departmentService = new DepartmentService();

departmentService.AddDepartment(department1);

employerServise.AddEmployee(employee1);

foreach(var employee in employerServise.GetEmployees())
{
    employee.DisplayInfo();
}