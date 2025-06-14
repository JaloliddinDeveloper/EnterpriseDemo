using Domain.Models.Departments;

namespace Infrastructure.Services.Departments
{
    public class DepartmentService
    {
        private Department[] departments;
        private int count;

        public DepartmentService()
        {
            count = 0;
            departments = new Department[4];
        }

        public void AddDepartment(Department department)
        {
            departments[count++] = department;
        }

        public Department[] GetDepartments()
        {
            return departments;
        }

        public Department GetDepartmentById(int id)
        {
            foreach (var department in departments)
            {
                if (department != null && department.Id == id)
                {
                    return department;
                }
            }
            return null;
        }

        public void UpdateDepartment(int id, Department updatedDepartment)
        {
            for (int i = 0; i<departments.Length; i++)
            {
                if (departments[i].Id == id)
                {
                    departments[i] = updatedDepartment;
                    return;
                }
            }
        }

        public void DeleteDepartment(int id)
        {
            for (int i = 0; i < count; i++)
            {
                if (departments[i].Id == id)
                {
                    departments[i] = null;
                    return;
                }
            }
        }
    }
}
