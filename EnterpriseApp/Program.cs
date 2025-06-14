using Domain.Models.Departments;
using Domain.Models.Employees;
using Infrastructure.Services.Departments;
using Infrastructure.Services.Employes;
using System;

var department1 = new Department
{
    Id = 1,
    Name = "Bank",
    Description = "Buxgalter"
};

var department2 = new Department
{
    Id = 2,
    Name = "IT",
    Description = "Information Technology"
};

var department3 = new Department
{
    Id = 3,
    Name = "Taxsi",
    Description = "Yandex"
};

var department4 = new Department
{
    Id = 4,
    Name = "Marketing",
    Description = "Marketing Department"
};

var employee1 = new Employee
{
    Id = 1,
    FullName = "Ali",
    Age = 30,
    Department = department1
};

var employee2 = new Employee
{
    Id = 2,
    FullName = "Vali",
    Age = 25,
    Department = department2
};

var employee3 = new Employee
{
    Id = 3,
    FullName = "Sami",
    Age = 28,
    Department = department3
};

var employerServise = new EmployeService();
var departmentService = new DepartmentService();

departmentService.AddDepartment(department1);
employerServise.AddEmployee(employee1);

departmentService.AddDepartment(department2);
employerServise.AddEmployee(employee2);

departmentService.AddDepartment(department3);
employerServise.AddEmployee(employee3);

Console.WriteLine("Departments and Employees added successfully.");

var departments = departmentService.GetDepartments();
foreach (var department in departments)
{
    if (department != null)
    {
        Console.WriteLine($"Department ID: {department.Id}, Name: {department.Name}, Description: {department.Description}");
    }
}

var employees = employerServise.GetEmployees();

foreach (var employee in employees)
{
    if (employee != null)
    {
        Console.WriteLine($"Employee ID: {employee.Id}, Name: {employee.FullName}, Age: {employee.Age}, Department: {employee.Department.Name}");
    }
}

Console.WriteLine("Update Department ");

var updatedDepartment = new Department
{
    Id = 1,
    Name = "Finance",
    Description = "Financial Department"
};

departmentService.UpdateDepartment(1, updatedDepartment);

Console.WriteLine("Updated Department 1 to Finance.");

Console.WriteLine("Delete Department ");

departmentService.DeleteDepartment(4);

Console.WriteLine("Deleted Department 4.");

Console.WriteLine("Update Employee ");
var updatedEmployees = employerServise.GetEmployees();
foreach (var employee in updatedEmployees)
{
    if (employee != null)
    {
        Console.WriteLine($"Employee ID: {employee.Id}, Name: {employee.FullName}, Age: {employee.Age}, Department: {employee.Department.Name}");
    }
}

Console.WriteLine("Update Employee");

var updatedEmployee = new Employee
{
    Id = 1,
    FullName = "Ali Reza",
    Age = 31,
    Department = department1
};

employerServise.UpdateEmployee(1, updatedEmployee);

var updatedEmployeesAfter = employerServise.GetEmployees();

foreach (var employee in updatedEmployeesAfter)
{
    if (employee != null)
    {
        Console.WriteLine($"Employee ID: {employee.Id}, Name: {employee.FullName}, Age: {employee.Age}, Department: {employee.Department.Name}");
    }
}

Console.WriteLine("Delete Employee");
var employeeToDelete = 2;
employerServise.DeleteEmployee(employeeToDelete);

var employeesAfterDelete = employerServise.GetEmployees();
foreach (var employee in employeesAfterDelete)
{
    if (employee != null)
    {
        Console.WriteLine($"Employee ID: {employee.Id}, Name: {employee.FullName}, Age: {employee.Age}, Department: {employee.Department.Name}");
    }
}

Console.WriteLine("Update Department");

var departmentToUpdate = new Department
{
    Id = 2,
    Name = "Taxi Service",
    Description = "Taxi Department"
};

departmentService.UpdateDepartment(2, departmentToUpdate);

var updatedDepartmentsAfter = departmentService.GetDepartments();
foreach (var department in updatedDepartmentsAfter)
{
    if (department != null)
    {
        Console.WriteLine($"Department ID: {department.Id}, Name: {department.Name}, Description: {department.Description}");
    }
}
