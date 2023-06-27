namespace ExceptionHandling
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
            Claass1 obj = new Claass1();
            obj.InvalidP1 += obj_InvalidP1;
            obj.P1 = 1000;

        }

    static void obj_InvalidP1()
        {
            Console.WriteLine("My Event Raised");
        }

    

    }
    //step1
    public delegate void InvalidP1Handler();
    public class Claass1
    {
        //step2
        public event InvalidP1Handler InvalidP1;

        private int p1;
        public int P1
        {
            get { return  p1; } 
            set { 
                  if(value<100)
                     p1 = value; 
                  else
                     {
                    //step3
                    InvalidP1();
                     }
            }   

        }
        
    }
}