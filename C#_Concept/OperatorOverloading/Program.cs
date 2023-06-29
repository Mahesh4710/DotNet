namespace OperatorOverloading
{
    internal class Program
    {

        static void Main(string[] args)
        {
            //Operator  Overloading
            Class1  o1 =new Class1();
            o1.i = 100;

            o1 = o1 + 5;     //work only after writing operator overloaded function
            //o1 = Class1.operator+(o,5);    //Internally compilation

            Console.WriteLine(o1.i);

            Class1 o2 = new Class1();
            //o2.i = 1000;
            o2 = o2 - 5;
            Console.WriteLine(o2.i);

        }
    }
    public class Class1
    {
        public int i;

        public static Class1 operator +(Class1 obj, int a)
            {
                Class1  retval = new Class1();
                retval.i = obj.i +a;
                
                return retval;
            }
        public static Class1 operator -(Class1 obj, int a)
        {
            Class1 retval = new Class1();
            retval.i = obj.i -a;
            return retval;
        }

    }
}