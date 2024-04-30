using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeSystem
{
    class EmployeeDetails
    {
        // List to store all employees
        private List<Employee> employees = new List<Employee>();

        // Variable to track the next available ID for new employees
        private static int nextId = 1;

        // Method to create a new employee
        public Employee CreateEmployee(string name, string department, decimal salary)
        {
            var employee = new Employee
            {
                Id = nextId++,
                Name = name,
                Department = department,
                Salary = salary
            };
            employees.Add(employee);
            return employee;
        }

        // Method to retrieve an employee by ID
        public Employee GetEmployeeById(int id)
        {
            return employees.FirstOrDefault(e => e.Id == id);
        }

        // Method to retrieve all employees
        public List<Employee> GetAllEmployees()
        {
            return employees;
        }

        // Method to update an employee's information
        public void UpdateEmployee(int id, string name, string department, decimal salary)
        {
            var employee = GetEmployeeById(id);
            if (employee != null)
            {
                employee.Name = name;
                employee.Department = department;
                employee.Salary = salary;
            }
        }

        // Method to delete an employee
        public void DeleteEmployee(int id)
        {
            var employee = GetEmployeeById(id);
            if (employee != null)
            {
                employees.Remove(employee);
            }
        }
        
          
    }
}
