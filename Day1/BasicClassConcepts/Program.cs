//using BasicClassConcepts.MyOwnNamespace;

using MyOwnNamespace;

namespace BasicClassConcepts
{
    namespace Day1Project
    {
        internal class Program
        {
            static void Main1()
            {
                System.Console.WriteLine("Gunj");
                Display();
            }

            static void Main()
            {
                System.Console.WriteLine("Hello World.!!");
                Class1 c = new Class1();
                c.Display();

                Main1(); // Call Main1() to execute it
            }

            static void Display()
            {
                System.Console.WriteLine("Display OF MAIN");
            }
        }
    }

 }
namespace MyOwnNamespace
{
    public class Class1
    {
        public void Display()
        {
            System.Console.WriteLine("Class1 Display");
        }
    }
}