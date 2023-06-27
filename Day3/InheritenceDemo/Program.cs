namespace InheritenceDemo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Class1 o1 = new Class1();
            //Class1 o2 = new Class1();

            // o1.i = 100;
            // o2.i= 200;

            //o2=o1;

            //o2.i= 300;

            //Console.WriteLine(o1.i);
            //Console.WriteLine(o2.i);


            //Class1 o1 = new Class1();
            //Class1 o2 = new Class1();
            string o1, o2;
            o1 = "100";
            o2 = "200";

            o1=o2;

            o2 = "300";

           // o2 = 300;

            Console.WriteLine(o1);
            Console.WriteLine(o2);
        }
        void DataTypes()
        {

        }
    }

    public class Class1
    {
        byte b;
        sbyte s;

        ushort us;
        
        short sh;
        uint ui;
        int i;
        long l;
        ulong ul;
    }
    public abstract class AbstractBase { 
        public void Display()
        {
            Console.WriteLine("Display");
        }
    }
    public abstract class AbstractBase2
    {
        public abstract void Display2();

        public abstract void Display3();
        
    }

    public class Class2 : AbstractBase2
    {
        public override void Display2()
        {
            
        }

        public override void Display3()
        {
            
        }
    }

    public abstract class Class3 : AbstractBase2
    {
        public override void Display2()
        {

        }
    }
}