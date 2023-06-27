using System;

namespace AssignmentNo5
{
    class InvalidEmployeeNumberException : Exception
    {
        public InvalidEmployeeNumberException(string message) : base(message)
        {
        }
    }

    class InvalidDesignationException : Exception
    {
        public InvalidDesignationException(string message) : base(message)
        {
        }
    }

    interface IDbFunctions
    {
        void INSERT();
        void DELETE();
        void UPDATE();
    }

    public abstract class Employee : IDbFunctions
    {
        private static int empNo = 0;

        public Employee(string name, short deptNo)
        {
            Name = name;
            DeptNo = deptNo;
            EmpNo = ++empNo;
        }

        public string Name { get; set; }
        public int EmpNo { get; }
        public int DeptNo { get; set; }

        public abstract decimal Basic { get; set; }

        public abstract decimal CalcNetSalary();

        public virtual void INSERT()
        {
            Console.WriteLine("INSERT called");
        }

        public virtual void DELETE()
        {
            Console.WriteLine("DELETE called");
        }

        public virtual void UPDATE()
        {
            Console.WriteLine("UPDATE called");
        }
    }

    public class Manager : Employee
    {
        private string designation;
        private decimal basic;

        public Manager(string name, short deptNo, string designation, decimal basic) : base(name, deptNo)
        {
            Designation = designation;
            Basic = basic;
        }

        public override decimal Basic
        {
            get { return basic; }
            set
            {
                if (value > 0)
                {
                    basic = value;
                }
                else
                {
                    throw new InvalidEmployeeNumberException("Invalid basic salary. Must be greater than zero.");
                }
            }
        }

        public string Designation
        {
            get { return designation; }
            set
            {
                if (!string.IsNullOrWhiteSpace(value))
                {
                    designation = value;
                }
                else
                {
                    throw new InvalidDesignationException("Invalid designation. Cannot be empty or whitespace.");
                }
            }
        }

        public override decimal CalcNetSalary()
        {
            return Basic * 0.8m;
        }
    }

    public class GeneralManager : Manager
    {
        public GeneralManager(string name, short deptNo, string designation, decimal basic, string perks) : base(name, deptNo, designation, basic)
        {
            Perks = perks;
        }

        public string Perks { get; set; }

        public override decimal CalcNetSalary()
        {
            return Basic * 0.2m;
        }
    }

    public class CEO : Employee
    {
        public CEO(string name, short deptNo, decimal basic) : base(name, deptNo)
        {
            Basic = basic;
        }

        public override decimal Basic { get; set; }

        public sealed override decimal CalcNetSalary()
        {
            return Basic * 5;
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Let's see how my code works");
            Console.WriteLine("******************************************************");

            try
            {
                CEO ceo1 = new CEO("Mahesh", 5, 50000);

                Console.WriteLine();
                Console.WriteLine("*******************************************************");
                Console.WriteLine("Name of Employee is: " + ceo1.Name);
                Console.WriteLine("Employee ID of " + ceo1.Name + " is: " + ceo1.EmpNo);
                Console.WriteLine("Department Number of " + ceo1.Name + " is: " + ceo1.DeptNo);
                Console.WriteLine("Basic Pay of " + ceo1.Name + " is: " + ceo1.Basic);
                Console.WriteLine("Net Salary of " + ceo1.Name + " is: " + ceo1.CalcNetSalary());
                Console.WriteLine();
            }
            catch (Exception ex)
            {
                Console.WriteLine("Exception occurred: " + ex.Message);
            }

            try
            {
                GeneralManager gman = new GeneralManager("Gautam Adani", 3, "General-Manager", -18000, "Free Internet");

                Console.WriteLine();
                Console.WriteLine("*******************************************************");
                Console.WriteLine("Name of Employee is: " + gman.Name);
                Console.WriteLine("Employee ID of " + gman.Name + " is: " + gman.EmpNo);
                Console.WriteLine("Department Number of " + gman.Name + " is: " + gman.DeptNo);
                Console.WriteLine("Designation of " + gman.Name + " is: " + gman.Designation);
                Console.WriteLine("Net Salary of " + gman.Name + " is: " + gman.CalcNetSalary());
                Console.WriteLine("Additional perk benefit for " + gman.Designation + " " + gman.Name + " is: " + gman.Perks);
                Console.WriteLine();
            }
            catch (Exception ex)
            {
                Console.WriteLine("Exception occurred: " + ex.Message);
            }
        }
    }
}
