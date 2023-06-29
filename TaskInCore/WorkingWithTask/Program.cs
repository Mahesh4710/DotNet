namespace WorkingWithTask
{
    internal class Program

    {

        static void Main2()
        {
            //TPL_ParallelExamples

            int[] arr = new int[10];
            //for(int i=0; i<arr.Length; i++)
            //{
            //    arr[i] = i*10;
            //}

            Parallel.For(0,10,new Action<int>(i => arr[i]=i*10));

            //foreach(var  i in arr)
            //{
            //    Console.WriteLine(i);
            //}
            Parallel.ForEach<int>(arr, new Action<int>(item => { Console.WriteLine(item); }));

            Parallel.Invoke(Func1,Func2);

        }
      
        static async Task Main1()
        {
            ////Task t1 = new Task(Func1);    //ok
            ////Task t2 = new Task(Func2);    //ok

            ////Task t1 = Task.Factory.StartNew(Func1); //direct start the  task

            ////Task t2 = Task.Run(Func2);      //direct start the  task

            //Task t3 = Task.Factory.StartNew(Func3, "C#");
            //Task t4 = Task.Run(() =>
            //{
            //    for (int i = 0; i < 10; i++)
            //    {
            //        Console.WriteLine("Anonomous  " + i + "     Thread id is :" + Thread.CurrentThread.ManagedThreadId);
            //    }
            //});

            ////t1.Start();
            ////t2.Start();

            ////Task t5 = new Task(Func4);    //not ok due to  return type

            //Task<int> t5 = new Task<int>(Func4);    //ok
            //Task<int> t6 = Task.Run<int>(Func4);    //ok
            //Task<int> t7 = Task.Factory.StartNew<int>(Func4);   //ok

            //Task<string> t8 = Task.Factory.StartNew<string>(Func5,"C#");  //ok

            //if (!t8.IsCompleted)
            //    t8.Wait();
            //Console.WriteLine("Returned value : " + t8.Result);

            Console.WriteLine("************************************************************************************************");

            Console.WriteLine("Before Async Call :  ");

            //string message = DoWork();

            string message = await DoWorkAsync();

            Console.WriteLine("After ");

            

            Console.WriteLine(message);


            Console.ReadLine();
        }


        static async Task<string> DoWorkAsync()
        {
            return await Task.Run(() =>
            {
                Thread.Sleep(2000);
                return "Task Done Async";
            });
        }

        static string DoWork()
        {
            Thread.Sleep(2000);
            return "Work  Done";
        }








        static void Func1()
        {
            for(int i = 0; i < 10; i++)
            {
                Console.WriteLine("Func1  "+i  + "     Thread id is :" + Thread.CurrentThread.ManagedThreadId);
            }
        }
        static void Func2()
        {
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine("Func2  " + i + "     Thread id is :" + Thread.CurrentThread.ManagedThreadId);

            }
        }

        static void Func3(Object  obj)
        {
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine("Func3  " + i + "     Thread id is :" + Thread.CurrentThread.ManagedThreadId);

            }
        }

        static int Func4()
        {
            Console.WriteLine("Returning something :");
            return 0;
        }

        static string Func5(Object obj)
        {
            Console.WriteLine("Returning something :");
            return "retunedString from Func5";
        }
    }
}