using System.Collections;

namespace Nullable
{
    internal class Program
    {
        static void Main1()
        {
            int? i = null;
            int j = 10;

            j=i.GetValueOrDefault();
            j = i.GetValueOrDefault(5);

            j = i ?? 10;

            Console.WriteLine(j);


        }

        static void Main2() 
        {
            Console.WriteLine("Hello");
            //string? s;
            //s=Console.ReadLine();
            //Console.WriteLine(s);

            //int[] arr = new int[3];
            //for (int i = 0; i < arr.Length; i++)
            //{
            //    Console.WriteLine("Enter element at index "+i);
            //    arr[i] = int.Parse(Console.ReadLine());

            //}
            //foreach(int x in arr)
            //{
            //    Console.WriteLine(x);
            //}

            int[] arr = new int[] { 1, 2, 3, 4, 5 };

            int pos = Array.IndexOf(arr, 2, arr.Length);

            pos = Array.BinarySearch(arr, 7);

            Console.WriteLine(pos);


            foreach (int x in arr)
            {
                Console.WriteLine(x);
            }
        }

        static void Main_Araylist()
        {
            ArrayList objArrayList = new ArrayList();

            objArrayList.Add(1);
            objArrayList.Add("Mahesh");
            objArrayList.Add(true);

            //objArrayList.AddRange(objArrayList2);

            objArrayList.Insert(0, "new item");
            //objArrayList.InsertRange(0, objArrayList2);
            objArrayList.RemoveRange(0, 3);
            //objArrayList.Remove("Mahesh");
            objArrayList.RemoveAt(1);

            objArrayList.Clear();
            //objArrayList.Capacity;
            objArrayList.TrimToSize();


            foreach (object obj in objArrayList)
            {
                Console.WriteLine(obj);
            }
        }


        static void MainDict()
        {
            Hashtable oj = new Hashtable();
            SortedList oj1 = new SortedList();
            oj1.Add(1, "Mahesh");
            oj1.Add(2, "Mukesh");
            oj1.Add(3, "Gautam");
            
            
            //oj1.Add(3, "TATA");

            //oj1[3] = "TATA"; //update and  add in one



            foreach (object obj in oj1)
            {
                Console.WriteLine(obj);
            }
            
        }
        static void Maingneric()
        {
            //gneric collections
            List<int> list = new List<int>();
            list.Add(1);
            
            List<string> list2 = new List<string>();
            list2.Add("2");

            foreach(object obj in list)
            {
                Console.WriteLine(obj);
            }

            foreach(object obj in list2)
            {
                Console.WriteLine(obj);
            }

            SortedList<int,  string> obj1 = new SortedList<int, string>();
            obj1.Add(1, "Mahi");

            foreach(object obj in obj1)
            { Console.WriteLine(obj); }
        }

        static void Main()
        {
           //SortedList <int,Employee> keyValuePairs = new SortedList<int,Employee>();

            //keyValuePairs.Add(1, new Employee { EmpNo = 1 }) ;

        }
    }
}