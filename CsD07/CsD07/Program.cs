using System;
namespace CsD07
{


    class Program
    {
        static void Main()
        {
            Console.Write("Enter the number of employees: ");
            int employeeCount;
            while (!int.TryParse(Console.ReadLine(), out employeeCount) || employeeCount <= 0)
            {
                Console.WriteLine("Invalid input. Please enter a positive integer.");
            }

            Employee[] employees = new Employee[employeeCount];

            for (int i = 0; i < employeeCount; i++)
            {
                Console.WriteLine($"\nEnter details for Employee {i + 1}:");

                int id;
                Console.Write("Enter Employee ID: ");
                while (!int.TryParse(Console.ReadLine(), out id) || id <= 0)
                {
                    Console.WriteLine("Invalid input. Please enter a positive integer.");
                }

                Console.Write("Enter Employee Name: ");
                string name = Console.ReadLine();

                Console.Write("Enter Gender (M/F): ");
                Gender gender;
                while (!Enum.TryParse(Console.ReadLine(), true, out gender) || (gender != Gender.M && gender != Gender.F))
                {
                    Console.WriteLine("Invalid input. Please enter M for Male or F for Female.");
                }

                decimal salary;
                Console.Write("Enter Employee Salary: ");
                while (!decimal.TryParse(Console.ReadLine(), out salary) || salary < 0)
                {
                    Console.WriteLine("Invalid input. Please enter a positive decimal number.");
                }

                Console.WriteLine("Enter Hire Date:");

                int day;
                Console.Write("  Day (1-31): ");
                while (!int.TryParse(Console.ReadLine(), out day) || day < 1 || day > 31)
                {
                    Console.WriteLine("Invalid input. Please enter a day between 1 and 31.");
                }

                int month;
                Console.Write("  Month (1-12): ");
                while (!int.TryParse(Console.ReadLine(), out month) || month < 1 || month > 12)
                {
                    Console.WriteLine("Invalid input. Please enter a month between 1 and 12.");
                }

                int year;
                Console.Write("  Year (e.g., 2000): ");
                while (!int.TryParse(Console.ReadLine(), out year) || year < 1900 || year > DateTime.Now.Year)
                {
                    Console.WriteLine($"Invalid input. Please enter a year between 1900 and {DateTime.Now.Year}.");
                }

                SecurityPrivileges privileges;
                Console.WriteLine("Select Security Privileges (Enter number):");
                Console.WriteLine("1. Guest");
                Console.WriteLine("2. Developer");
                Console.WriteLine("3. Secretary");
                Console.WriteLine("4. DBA");
                Console.WriteLine("5. Full Access");
                string privilegesInput = Console.ReadLine();
                while (!int.TryParse(privilegesInput, out int privilegeChoice) || privilegeChoice < 1 || privilegeChoice > 5)
                {
                    Console.WriteLine("Invalid input. Please enter a number between 1 and 5.");
                    privilegesInput = Console.ReadLine();
                }
                privileges = (SecurityPrivileges)(1 << (int.Parse(privilegesInput) - 1));

                employees[i] = new Employee(id, name, gender, salary, new HireDate(day, month, year), privileges);
            }

            
            Array.Sort(employees);

            
            Console.WriteLine("\nSorted Employee List:");
            foreach (var employee in employees)
            {
                Console.WriteLine(employee);
            }
        }
    }

}