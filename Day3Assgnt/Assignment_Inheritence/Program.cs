using System.Security.Cryptography.X509Certificates;

namespace Assignment_Inheritence
{
    internal class Program
    {
      
    public interface IDbFunctions
    {
        void Insert();
        void Update();
        void Delete();
    }

    public abstract class Employee : IDbFunctions
    {
        public string name;
        public string Name
        {
            get { return name; }
            set 
            { 
                if (! String.IsNullOrEmpty(value))
                    name = value;
                else
                    Console.WriteLine("Enter Valid name");
            }
        }

        public static int empNo=0;
        public int EmpNo { get { return empNo; } private set {  empNo = value; } }

        public short deptNo;
        public short DeptNo
        {
            get { return deptNo; }
            set
            {
                if(value > 0)
                {
                    deptNo = value;

                }
                else { Console.WriteLine("Enter valid deptno"); }
            }
        }

        
        public abstract decimal Basic
        {
          get; set;
        }

        public Employee(string name, short deptNo)
        {
            Name=name;
            DeptNo= deptNo;
            EmpNo= ++empNo;
        }

        public abstract decimal CalcNetSalary();
        public void Insert()
        {
            Console.WriteLine("Insert of Employee");
        }
        public void Update()
        {
            Console.WriteLine("Update of Employee");
        }
        public void Delete()
        {
            Console.WriteLine("Delete of Employee");
        }
    }

    public class Manager : Employee
    {
        public decimal basic;
        public override decimal Basic 
        { 
            get { return basic; }
            set { 
                if (value > 0)
                    basic = value;  
                else { Console.WriteLine("Enter valid Basic Pay"); }
                    
                }
        }

       
        public string designation;
        public string Designation
        {
            get { return designation; }
            set
            {
                if (! String.IsNullOrEmpty(value))
                    designation = value;
                else
                    Console.WriteLine("Enter the valid Designation");

            }
        }

        

        public Manager(string name, short deptNo, string designation, decimal basic) : base(name, deptNo)
        {
            Designation = designation;
            Basic = basic;
            
        }

        public Manager(string name, short deptNo, string designation) : base(name, deptNo)
        {
        }

        public override decimal CalcNetSalary()
        {
            return basic * 0.8m;           
        }

        //public void Insert()
        //{
        //    Console.WriteLine("Insert of Manager");
        //}

        //public void Update()
        //{
        //    Console.WriteLine("Update of Manager");
        //}

        //public void Delete()
        //{
        //    Console.WriteLine("Delete of Manager");
        //}
    }

    public class GeneralManager :Manager
    {
        public string Perks { get; set; }
        public GeneralManager(string name, short deptNo, string designation, decimal basic, string perks) : base(name, deptNo, designation)
        {
            Basic = basic;
            Perks = perks;
        }


        public override decimal CalcNetSalary()
        {
            return basic * 0.9m;
        }
    }

    public class CEO : Employee
    {
        public decimal basic;
        public override decimal Basic 
        {
            get { return basic; }
            set
            {
                if(value > 0)
                    basic = value;
                else { Console.WriteLine("Enter Valid basic of CEO"); }
            }
        }

        public decimal netsalary;

        public CEO(string name, short deptNo, decimal basic) : base(name, deptNo)
        {
            Basic= basic;
        }

        public override decimal CalcNetSalary()
        {
            return basic * 0.7m;
        }

        //public  void Insert()
        //{
        //    Console.WriteLine("Insert of CEO");
        //}

        //public void Update()
        //{
        //    Console.WriteLine("Update of CEO");
        //}

        //public void Delete()
        //{
        //    Console.WriteLine("Delete of CEO");
        //}
    }
        static void Main(string[] args)
        {
            Console.WriteLine("Lets see how my code  works");
            Console.WriteLine("******************************************************");
            Console.WriteLine();

            CEO ceo = new CEO("Mahesh", 1, 50000);
            ceo.Insert();

            Console.WriteLine();
            Console.WriteLine("*******************************************************");
            Console.WriteLine("Name of Employee is : " + ceo.Name);
            Console.WriteLine("Employee ID of " + ceo.Name + " is : " + ceo.EmpNo);
            Console.WriteLine("Department Num of " + ceo.Name + " is : " + ceo.DeptNo);
            Console.WriteLine("Basic Pay of " + ceo.name + " is : " + ceo.Basic);
            Console.WriteLine("NetSalary of " + ceo.name + " is : " + ceo.CalcNetSalary());
            Console.WriteLine();
            Console.WriteLine("*******************************************************");
            Console.WriteLine();

            Manager manager = new Manager("Mukesh Ambani", 2, "Assistant-Manager", 25000);
            manager.Insert();
            Console.WriteLine();

            Console.WriteLine("Name of Employee is : " + manager.Name);
            Console.WriteLine("Employee Id of " + manager.Name + " is :" + manager.EmpNo);
            Console.WriteLine("Department Num of " + manager.Name + " is : " + manager.DeptNo);
            Console.WriteLine("Designation of " + manager.name + " is : " + manager.Designation);
            Console.WriteLine("NetSalary of " + manager.name + " is : " + manager.CalcNetSalary());
            Console.WriteLine();
            Console.WriteLine("********************************************************");
            Console.WriteLine();

            GeneralManager gman = new GeneralManager("Gautam Adani", 3, "General-Manager", 18000, "Free Internet");
            gman.Insert();
            Console.WriteLine();

            Console.WriteLine("Name of Employee is : " + gman.Name);
            Console.WriteLine("Employee Id of " + gman.Name + " is :" + gman.EmpNo);
            Console.WriteLine("Department Num of " + gman.Name + " is : " + gman.DeptNo);
            Console.WriteLine("Designation of " + gman.name + " is : " + gman.Designation);
            Console.WriteLine("NetSalary of " + gman.name + " is : " + gman.CalcNetSalary());
            Console.WriteLine("Additonal perk benifit for " + gman.Designation + " " + gman.Name + " is : " + gman.Perks);
            Console.WriteLine();
            Console.WriteLine("********************************************************");

        }
    }
}