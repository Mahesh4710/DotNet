namespace Assignment_4
{
    internal class Program
    {
        static void Main1(string[] args)
        {
            Console.WriteLine("Enter the number of batches in Cdac Kochi");
            int batches = int.Parse(Console.ReadLine());
            Console.WriteLine("___________________________________________________________");
            Console.WriteLine();
            int[][] marks = new int[batches][];
            //int totalStudents=0;

            for (int i = 0; i < batches; i++)
            {
                Console.WriteLine($"Enter the number of the students in batch {i+1} : ");
                int totalStudents = int.Parse(Console.ReadLine());
                marks[i] = new int[totalStudents];   
                
                for (int j = 0; j < totalStudents; j++)
                {
                    Console.WriteLine($"Enter the Marks of student {j+1} from batch {i+1}");
                    marks[i][j] = int.Parse(Console.ReadLine()); 
                }
                Console.WriteLine();
            }
            Console.WriteLine("___________________________________________________________");

            Console.WriteLine();
            Console.WriteLine("Marks for each student is as follows :");
            for (int i = 0;i < batches; i++)
            {
                for (int j = 0;j < marks[i].Length; j++)
                {
                    Console.WriteLine($"Student {j+1} from batch {i + 1} got marks {marks[i][j]}");
                }
                Console.WriteLine();
            }
            Console.WriteLine("____________________________________________________________");

        }
        static void Main()
        {
            Dictionary <int,Employee> keyValuePairs = new Dictionary<int,Employee>();
            string input;

            do
            {
                Employee employee = new Employee();

                Console.WriteLine("Enter the Employee Name :");
                employee.EmployeeName = Console.ReadLine();

                Console.WriteLine("Enter the SAlary of Employee");
                employee.EmployeeSalary  = decimal.Parse(Console.ReadLine());

                keyValuePairs.Add(employee.EmployeeNo,employee);

                Console.WriteLine("Do you want to add another record of employee ?");
                input = Console.ReadLine();

            } while (input.ToUpper() == "YES");
            Console.WriteLine();
            Console.WriteLine("___________________________________-_____________________________");
            Console.WriteLine();

            Console.WriteLine("Entered details of Employees as  follows :  ");
            foreach (Employee employee in keyValuePairs.Values) 
            {
                Console.WriteLine(employee.EmployeeNo);
                Console.WriteLine(employee.EmployeeName);
                Console.WriteLine(employee.EmployeeSalary);

            }
            Console.WriteLine();
            Console.WriteLine("_____________________________________________________________");
            Console.WriteLine();

            //Highest salary employee
            static Employee GetHighestSal(  Dictionary<int,Employee> keyValuePairs)
            {
                decimal highestSal = decimal.MinValue;

                Employee highestSalEmp = null;

                foreach (Employee emp in keyValuePairs.Values)
                {
                    if(emp.EmployeeSalary > highestSal)
                    {
                        highestSal = emp.EmployeeSalary;
                        highestSalEmp = emp;
                    }

                }

                return highestSalEmp;

            }

            Employee highestSalarEmployee = GetHighestSal( keyValuePairs );

            Console.WriteLine("Employee who is having highest salary is :");

            Console.WriteLine("Employee Number is " + highestSalarEmployee.EmployeeNo);
            Console.WriteLine("Employee Name is " + highestSalarEmployee.EmployeeName);
            Console.WriteLine("Employee Salary is " + highestSalarEmployee.EmployeeSalary);

            Console.WriteLine();
            Console.WriteLine("_____________________________________________________________");
            Console.WriteLine();

            //search employee with Employee  number
            Console.WriteLine("search employee with Employee  number");
            Console.WriteLine("Enter the Employee Number :");
            int empno = int.Parse(Console.ReadLine());

            if (keyValuePairs.ContainsKey(empno))
            {
                Console.WriteLine("Record Exists DB");
                Console.WriteLine("Name of employee is "+ keyValuePairs[empno].EmployeeName);
                Console.WriteLine("SAlary  of emploee  is" + keyValuePairs[empno].EmployeeSalary);
            }
            else
            { Console.WriteLine($"No employee present with with employee number{empno}"); }


            Console.WriteLine();
            Console.WriteLine("_____________________________________________________________");
            Console.WriteLine();

            // Displaying details for the Nth Employee
            Console.WriteLine("Displaying details for the Nth Employee ");
            Console.Write("Enter the value of N: ");
            int n = int.Parse(Console.ReadLine());
            if (n >= 1 && n <= keyValuePairs.Count)
            {
                Employee nthEmployee = keyValuePairs.Values.ElementAt(n - 1);

                Console.WriteLine("Details of the Nth Employee:");
                Console.WriteLine($"Employee No: {nthEmployee.EmployeeNo}");
                Console.WriteLine($"Employee Name: {nthEmployee.EmployeeName}");
                Console.WriteLine($"Employee Salary: {nthEmployee.EmployeeSalary}");

            }
            else
            {
                Console.WriteLine("\nInvalid input for N.");
            }
        }
    }
    class Employee
    {
        public static int empNo=0;
        public  int EmployeeNo { get; private set; }
        public string EmployeeName { get; set; }
        public decimal EmployeeSalary { get; set; }

        public Employee() 
        {
            EmployeeNo = ++empNo;
        }

    }
}       