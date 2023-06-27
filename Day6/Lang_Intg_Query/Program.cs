namespace Lang_Intg_Query
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var i = 0;
            //var i = 6;

            var j = "Mahesh";

            var k = 3.3;

            Console.WriteLine(i);
            Console.WriteLine(k.GetType());

            var o = new { Id = 10, name = "mp" };
            Console.WriteLine(o.GetType());

            var o2= new { key=3 , value=5 };
            Console.WriteLine(o2.GetType());

            var o3 = new { key=3 , value=5 };

            var o4 = new { key = 3, Value = 5 };
            Console.WriteLine(o4.GetType());

            Class1 ob = new Class1();

            Console.WriteLine(ob.Id);

        }
    }

    public partial class Class1
    {
        public int id = 5;
        public   int Id
        { 
            get { return id; } private set { id = value; }
        }
        partial void me();
    }
    //public class Class1
    //{

    ////}
    //partial method1()
    //{

    //}
   


}