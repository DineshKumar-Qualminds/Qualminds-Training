using System;

namespace EmployeeSystem
{
    class Program
    {
        static void Main(string[] args)
        {

            // Create an instance of EmployeeDetails to manage employee data
            var employeeData = new EmployeeDetails();

            // Main loop to continuously prompt the user for operations
            while (true)
            {
                // Display the menu options
                Console.WriteLine("Choose an operation:");
                Console.WriteLine("1. Create Employee");
                Console.WriteLine("2. Read Employee");
                Console.WriteLine("3. Update Employee");
                Console.WriteLine("4. Delete Employee");
                Console.WriteLine("5. Display All Employees");
                Console.WriteLine("6. Exit");

                // Get user choice
                Console.Write("Enter your choice: ");
                int choice;
                if (!int.TryParse(Console.ReadLine(), out choice))
                {
                    Console.WriteLine("Invalid choice. Please enter a number.");
                    continue;
                }


                // Perform the selected operation
                switch (choice)
                {
                    case 1:
                        // Create Employee
                        Console.Write("Enter employee name: ");
                        string name = Console.ReadLine();
                        Console.Write("Enter department: ");
                        string department = Console.ReadLine();
                        Console.Write("Enter salary: ");
                        decimal salary;
                        if (!decimal.TryParse(Console.ReadLine(), out salary))
                        {
                            Console.WriteLine("Invalid salary. Please enter a valid number.");
                            break;
                        }
                        employeeData.CreateEmployee(name, department, salary);
                        Console.WriteLine("Employee created successfully.");
                        break;

                    case 2:
                        // Read Employee
                        Console.Write("Enter employee ID to read: ");
                        int idToRead;
                        if (!int.TryParse(Console.ReadLine(), out idToRead))
                        {
                            Console.WriteLine("Invalid ID. Please enter a valid number.");
                            break;
                        }
                        var employee = employeeData.GetEmployeeById(idToRead);
                        if (employee == null)
                        {
                            Console.WriteLine("Employee not found.");
                        }
                        else
                        {
                            Console.WriteLine($"ID: {employee.Id}, Name: {employee.Name}, Department: {employee.Department}, Salary: {employee.Salary}");
                        }
                        break;

                    case 3:
                        // Update Employee
                        Console.Write("Enter employee ID to update: ");
                        int idToUpdate;
                        if (!int.TryParse(Console.ReadLine(), out idToUpdate))
                        {
                            Console.WriteLine("Invalid ID. Please enter a valid number.");
                            break;
                        }
                        var employeeToUpdate = employeeData.GetEmployeeById(idToUpdate);
                        if (employeeToUpdate == null)
                        {
                            Console.WriteLine("Employee not found.");
                            break;
                        }

                        Console.WriteLine($"Selected employee: ID: {employeeToUpdate.Id}, Name: {employeeToUpdate.Name}, Department: {employeeToUpdate.Department}, Salary: {employeeToUpdate.Salary}");

                        Console.WriteLine("Select field to update:");
                        Console.WriteLine("1. Name");
                        Console.WriteLine("2. Department");
                        Console.WriteLine("3. Salary");
                        Console.Write("Enter your choice: ");
                        int fieldChoice;
                        if (!int.TryParse(Console.ReadLine(), out fieldChoice) || fieldChoice < 1 || fieldChoice > 3)
                        {
                            Console.WriteLine("Invalid choice. Please enter a number between 1 and 3.");
                            break;
                        }

                        switch (fieldChoice)
                        {
                            case 1: 
                                Console.Write("Enter new name: ");
                                string newName = Console.ReadLine();
                                employeeData.UpdateEmployee(idToUpdate, newName, employeeToUpdate.Department, employeeToUpdate.Salary);
                                Console.WriteLine("Name updated successfully.");
                                break;
                            case 2:
                                Console.Write("Enter new department: ");
                                string newDepartment = Console.ReadLine();
                                employeeData.UpdateEmployee(idToUpdate, employeeToUpdate.Name, newDepartment, employeeToUpdate.Salary);
                                Console.WriteLine("Department updated successfully.");
                                break;
                            case 3:
                                Console.Write("Enter new salary: ");
                                decimal newSalary;
                                if (!decimal.TryParse(Console.ReadLine(), out newSalary))
                                {
                                    Console.WriteLine("Invalid salary. Please enter a valid number.");
                                    break;
                                }
                                employeeData.UpdateEmployee(idToUpdate, employeeToUpdate.Name, employeeToUpdate.Department, newSalary);
                                Console.WriteLine("Salary updated successfully.");
                                break;
                            default:
                                Console.WriteLine("Invalid choice. Please enter a valid option.");
                                break;
                        }
                        break;

                    case 4:
                        // Delete Employee
                        Console.Write("Enter employee ID to delete: ");
                        int idToDelete;
                        if (!int.TryParse(Console.ReadLine(), out idToDelete))
                        {
                            Console.WriteLine("Invalid ID. Please enter a valid number.");
                            break;
                        }
                        employeeData.DeleteEmployee(idToDelete);
                        Console.WriteLine("Employee deleted successfully.");
                        break;

                    case 5:
                        // Display All Employees
                        // Define the column widths for tabular display
                        int idWidth = 5;
                        int nameWidth = 20;
                        int departmentWidth = 15;
                        var allEmployees = employeeData.GetAllEmployees();
                        Console.WriteLine("All Employees:");
                        Console.WriteLine($"{"ID".PadRight(idWidth)}{"Name".PadRight(nameWidth)}{"Department".PadRight(departmentWidth)}Salary");

                        // Output each employee
                        foreach (var emp in allEmployees)
                        {
                            Console.WriteLine($"{emp.Id.ToString().PadRight(idWidth)}{emp.Name.PadRight(nameWidth)}{emp.Department.PadRight(departmentWidth)}{emp.Salary}");
                        }
                        break;

                    case 6:
                        // Exit the program
                        Console.WriteLine("Exiting program.");
                        return;

                    default:
                        // Invalid choice
                        Console.WriteLine("Invalid choice. Please enter a valid option.");
                        break;
                }
            }
        }
    }

}
