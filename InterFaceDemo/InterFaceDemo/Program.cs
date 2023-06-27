namespace InterFaceDemo
{
    interface Firstinterface : Second
    {
        public void method1();
        public void method2();
        public void method16()
        {
            Console.WriteLine("Im a complete method3()  in interface1");
        }
    }

    interface Second
    {
        public void method3()
        {
            Console.WriteLine("Im a complete method3()  in interface2");
        }
    }

    public class ImpClass : Firstinterface, Second
    {
        public void method1()
        {
            Console.WriteLine("Method1() Called from class ImpClass");
        }

        public void method2()
        {
            Console.WriteLine("Method2() Called from class ImpClass");
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {  
            ImpClass ref1 = new ImpClass();


           Firstinterface ref2 = new ImpClass();

            ref2.method3();
            ref2.method2();
            ref2.method1();

            Second ref3 = new ImpClass();
        }
    }
}