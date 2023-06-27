using System;

namespace Assignment1_Properties
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Employee o = new Employee("abcd", 1, 28500,5);

            //Console.WriteLine(o.Name);
            //Console.WriteLine(o.EmpNo);           
            //Console.WriteLine(o.DeptNo);

            //o.GetNetSalary();


            //Employee o = new Employee("abcd", 2, 28500 );

            //Console.WriteLine(o.Name);
            //Console.WriteLine(o.EmpNo);
            //Console.WriteLine(o.DeptNo);

            //o.GetNetSalary();

            //Employee o = new Employee("abcd");

            //Console.WriteLine(o.Name);
            //Console.WriteLine(o.EmpNo);
            //Console.WriteLine(o.DeptNo);

            //o.GetNetSalary();


            Employee o = new Employee();

            Console.WriteLine(o.Name);
            Console.WriteLine(o.EmpNo);
            Console.WriteLine(o.DeptNo);

            o.GetNetSalary();

        }
    }



    public class Employee
    {
        public Employee(string P1="", int P2=0, decimal P3=0, short P4 = 0)
        {
            this.Name = P1;
            this.empNo = P2;
            this.Basic = P3;
            this.DeptNo = P4;
        }

        private string name;
        public string Name
        {
            set
            {
                if (value == "abcd")
                    name = value;
                else
                    Console.WriteLine("invalid Name");
            }
            get
            {
                return name;
            }
        }
        private int empNo;
        public int EmpNo
        {
            set
            {
                if (value > 0)
                    empNo = value;
                else
                    Console.WriteLine("invalid empno");
            }
            get
            {
                return empNo;
            }
        }

        private decimal basic;
        public decimal Basic
        {
            set
            {
                if (value > 20000 && value < 40000)
                    basic = value;
                else
                    Console.WriteLine("invalid salary");
            }
            get
            {
                return basic;
            }
        }
        private short deptNo;
        public short DeptNo
        {
            set
            {
                if (value > 0)
                    deptNo = value;
                else
                    Console.WriteLine("invalid DeptNo");
            }
            get
            {
                return deptNo;
            }
        }
        public void GetNetSalary()
        {
            decimal netSalary = Basic * (decimal)12 * (decimal)0.5;

            Console.WriteLine("net salary is "+ netSalary);
        }

    }

}
