using System.Diagnostics;

namespace ActionFuncPredecate
{
    internal class Program
    {
        static void Main1(string[] args)
        {
            Action o1 = Display;
            o1();

            //Action<string> o2 = show;
            
            //o2 ("Show called :"); 

        }

        static void Main()
        {
            Console.WriteLine("Hello");
            Func<string> o1 = GetCurrentTime;
            o1();
        }

        static  string GetCurrentTime()
        {
            return System.DateTime.Now.ToLongTimeString();
        }

        static void Display()
        {
            Console.WriteLine("Display  called");
        }
        static void show(string message)
        {
            Console.WriteLine(message);
        }
    }
}