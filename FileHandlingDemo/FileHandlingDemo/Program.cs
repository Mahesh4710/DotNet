using System.Text;

namespace FileHandlingDemo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Writing in file 

            string s = "My name is Mahesh Patil";

            byte[] arr = Encoding.Default.GetBytes(s);

            //DriveInfo drive = new DriveInfo("C");

            FileStream stream = File.Open("C:\\aaaa\\a.txt", FileMode.OpenOrCreate);

            stream.Write(arr, 0, arr.Length);
            stream.Close();


            // Reading from file

            FileStream stream1 = File.Open("C:\\aaaa\\a.txt", FileMode.Open);
            long size = stream1.Length;
            byte[] arr1 = new byte[size];

            stream.Read(arr1, 0, arr.Length);
            string str = Encoding.UTF8.GetString(arr);
            Console.WriteLine(str);
            stream.Close(); 

        }
    }
}