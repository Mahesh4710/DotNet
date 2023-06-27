using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace AsynchCodeUSingDeligate
{
    internal class Program
    {
        static void Main1(string[] args)
        {
            Action del1 = Display;
            Console.WriteLine("before");
            //del1();
            del1.BeginInvoke(null, null);
            Console.WriteLine("after");
            Console.ReadLine();
        }
        static  void Display() {
            Console.WriteLine("Display");
            Thread.Sleep(3000);

        }
        static void Main2(string[] args)
        {
            Action<string> del1 = Display1;
            Console.WriteLine("before");
            //del1();
            del1.BeginInvoke("MAhesh", null, null);
            Console.WriteLine("after");
            Console.ReadLine();
        }
        static void Display1(string s)
        {
            Thread.Sleep(5000);
            Console.WriteLine("Display");
            

        }

        static void Main(string[] args)
        {
            Func<string,string> del1 = Display2;
            Console.WriteLine("before");
            //del1();
            IAsyncResult ar1 = del1.BeginInvoke("MAhesh", delegate(IAsyncResult ar)
        {
                Console.WriteLine("Call back fun called");


                string retval = del1.EndInvoke(ar);

                Console.WriteLine(retval);
            }, null);
            
            
            
            Console.WriteLine("after");
            Console.ReadLine();
        }
        static string Display2(string s)
        {
            Thread.Sleep(1000);
            Console.WriteLine("Display");

            return s.ToUpper();
        }
        
    }
}
