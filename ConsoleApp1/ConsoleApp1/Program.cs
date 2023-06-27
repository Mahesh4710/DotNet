namespace ConsoleApp1
{
    internal class Program
    {
        static void Main1(string[] args)
        {
            AutoResetEvent  wh = new AutoResetEvent(false);
            Thread t5 = new Thread(delegate ()
            {
                for (int i = 0; i < 10; i++)
                {
                    Console.WriteLine("DEL :  "+i);
                    if (i == 5)
                    {
                        Console.WriteLine("WAITING");
                        wh.WaitOne();
                    }
                }
                    
            });
            t5.Start();

            Thread.Sleep(2000);
            Console.WriteLine("resuming");
            wh.Set();


            //Thread t1 = new Thread(new ThreadStart(Fun1));
            //Thread t2 = new Thread(new ThreadStart(Func2));

            //t2.Priority = ThreadPriority.Highest;
            //t1.Priority = ThreadPriority.Normal;

            //t1.Start();
            //Console.WriteLine("t1 Thread state : " + t1.ThreadState);

            ////t1.Start(); //System.Threading.ThreadStateException: 'Thread is running or terminated; it cannot restart.'


            //t2.Start();

            //Console.WriteLine("Id t1 : " + t1.ManagedThreadId);
            //Console.WriteLine("Id t2 :"  + t2.ManagedThreadId);

            //Console.WriteLine("t1 Thread state : " +  t1.ThreadState);

            ////t1.Join();
            ////Console.WriteLine("After t1");

            //for (int i = 21;i<= 30;i++)
            //{
            //    Console.WriteLine(i);
            //}

            

        }
        static void Main2(string[] args)
        {
           // Thread t1 = new Thread(new ParameterizedThreadStart(Fun1));

            //Thread t2 = new Thread(Func2);

            int a = 100;
            int b = 200;

            List<int> list = new List<int>();
            list.Add(a);
            list.Add(b);
            //t1.Start(list);
            //t2.Start("b");
            for (int i = 0;i < 10;i++) 
            {
                Console.WriteLine("Main "+i);
            }


        }



        //static void Main4()
        //{
        //    ThreadPool.QueueUserWorkItem(Fun1, "aaa");
        //    ThreadPool.QueueUserWorkItem(new WaitCallback(Func2));

        //    for (int i = 0; i<10; i++)
        //    {
        //        Console.WriteLine("Main "+ i.ToString());
        //    }

        //    int workerthreads, iothreads;

        //    ThreadPool.GetAvailableThreads(out workerthreads, out iothreads);

        //    Console.WriteLine(workerthreads);
        //    Console.WriteLine(iothreads);
        //}

        static  void Main()
        {
            Thread t3 = new Thread(Fun1);
            Thread t4 = new Thread(Fun2);

            t3.Start();

            t4.Start();

        }

            

        static void Fun1()
        {
            //lock()

            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine("FUn1 " + i);
            }

            //Thread.Sleep(5000);
            //Thread.SpinWait(2000);

        }
        static void Fun2( )
        {
            for (int i = 11; i < 20; i++)
            {
                Console.WriteLine("FUn2 " + i);
            }
        }
    }
}