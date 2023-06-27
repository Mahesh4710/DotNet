namespace DelegateDemo
{
    //step1 create class
    public delegate void Del1();

    public delegate int Del2(int a, int b);

    internal class Program 
    {
        static void Main1(string[] args)
        {
            //step2 create  an obj of delegate class and pass fun as param

            //Del1 obj =new Del1 (Display);
            Del1 obj = Display;// directly
            obj += show;

            obj();                        
            obj += Display;
            obj += show;

            Console.WriteLine();
            obj();
            //Display();
        }
        static void Main2(string[] args)
        {
            //step2 create  an obj of delegate class and pass fun as param

            //Del1 obj =new Del1 (Display);
            Del1 obj = Display;// directly
            obj();

            obj = show;
            obj();


            //Display();
        }

        static void Main3()
        {
            Del2 objDel2 = Add;

            //Console.WriteLine( objDel2(10,20));

            objDel2 += Subtract;
            objDel2 += Add;
            Console.WriteLine(objDel2(10, 20));
        }

        static void Display()
        {
            Console.WriteLine("Display Called");
        }
        static void show()
        {
            Console.WriteLine("show called");
        } 
        static  int  Add(int a, int b)
        {
            return a + b;
        }
        static int Subtract(int a, int b)
        {
            return a - b;
        }
        static void Main6()
        {
            //Del1 objdel1 = Class1.Display;
            //objdel1 += Class1.show;
            //objdel1();
            
        }
        
    }


    public class Class1
    {

        public static void Display()
        {
            Console.WriteLine("class1   Display Called");
        }
        public static void show()
        {
            Console.WriteLine("class1  show called");
        }
        public static int Add(int a, int b)
        {
            return a + b;
        }
    }
}