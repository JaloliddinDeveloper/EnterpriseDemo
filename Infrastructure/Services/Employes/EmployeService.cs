using Domain.Models.Employees;

namespace Infrastructure.Services.Employes
{
    public class EmployeService
    {
        private Employee[] employees;
        private int count;

        public EmployeService()
        {
            count = 0;
            employees = new Employee[4];
        }

        public void AddEmployee(Employee employee)
        {
            employees[count++] = employee;
        }

        public Employee[] GetEmployees()
        {
            return employees;
        }

        public Employee GetEmployeeById(int id)
        {
            foreach (var employee in employees)
            {
                if (employee != null && employee.Id == id)
                {
                    return employee;
                }
            }
            return null;
        }

        public void UpdateEmployee(int id, Employee updatedEmployee)
        {
            for (int i = 0; i < count; i++)
            {
                if (employees[i].Id == id)
                {
                    employees[i] = updatedEmployee;
                    return;
                }
            }
        }

        public void DeleteEmployee(int id)
        {
            for (int i = 0; i < count; i++)
            {
                if (employees[i].Id == id)
                {
                    employees[i] = null;
                    return;
                }
            }
        }
    }
}
