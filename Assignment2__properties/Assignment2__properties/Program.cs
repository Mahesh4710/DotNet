namespace Assignment2__properties

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
            Console.WriteLine(o.empNo);
            Console.WriteLine(o.DeptNo);

            o.GetNetSalary();

            Employee o1 = new Employee();
            Console.WriteLine(o1.empNo);
        }
    }



    public class Employee
    {
        private static int nextEmpNo = 1;

        public Employee(string P1 = "", decimal P3 = 0, short P4 = 0)
        {
            this.Name = P1;
            this.empNo += nextEmpNo;

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
        public  int empNo=0;
        //public int EmpNo
        //{
        //    set
        //    {
                
        //            empNo= empNo+1;                    
        //    }
        //    get
        //    {
        //        return empNo;
        //    }
        //}


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

            Console.WriteLine("net salary is " + netSalary);
        }

    }

}
