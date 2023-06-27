namespace AnonomousMethodLambda
{
    internal class Program
    {

        static void Main2(string[] args)
        {
            Action action = () => {
                Console.WriteLine("Display called");
            };
            action();

            Func<string> o5 =() => System.DateTime.Now.ToLongTimeString();
            Console.WriteLine(o5());

            Func<int,int>  o2 = a => a*2;
            Console.WriteLine(o2(2));

            Func<int,int,int> o3 = (a, b) => { return a+b; };
            Console.WriteLine(o3(10,20));

            //Predicate<int> o4 = a  => 
            //{ 
            //    if(a%2 == 0)
            //        return true;
            //    return false;
            //};

            Predicate<int> o4 = a => a%2==0 ;
            Console.WriteLine(o4(10));
        }

        static void Main1(string[] args)
        {
            int i = 100;
            Action o1 = delegate ()
            {
                Console.WriteLine($" i ={i}");
                Console.WriteLine("Display Called");
            };

            o1 ();

            Func<int,int,int> o2 = delegate(int a, int b)
            { return a+b; };

            Console.WriteLine(o2(10,20));
        }



        //static  int Add(int x , int y)  
        //{
        //return x + y;
        //}
        //static void Display()
        //{
        //    Console.WriteLine("Display called");
        //}
        static void Main()
        {
            Employee employee = new Employee();

            Predicate<Employee> o1 = obj => obj.Basic > 20000 ;
            Console.WriteLine(o1(new Employee { Basic=20001}));
            Console.WriteLine(o1(new Employee { Basic=3000}));
        }
    }



    public class Employee
    {
        public int EmpNo { get; set; }
        public string? Name { get; set; }

        public decimal Basic { get; set; }
    }
}