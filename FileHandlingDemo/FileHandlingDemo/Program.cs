using System.Text;

namespace FileHandlingDemo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ////Writing in file using byte []array

            //string s = "My name is Mahesh Patil";

            //byte[] arr = Encoding.Default.GetBytes(s);

            ////DriveInfo drive = new DriveInfo("C");   

            //FileStream stream = File.Open("C:\\aaaa\\a.txt", FileMode.OpenOrCreate);

            //stream.Write(arr, 0, arr.Length);
            //stream.Close();


            //// Reading from file using byte []array

            //FileStream stream1 = File.Open("C:\\aaaa\\a.txt", FileMode.Open);
            //long size = stream1.Length;
            //byte[] arr1 = new byte[size];

            //stream.Read(arr1, 0, arr.Length);
            //string str = Encoding.UTF8.GetString(arr);
            //Console.WriteLine(str);
            //stream.Close(); 


            //Writing in file using StreamWriter class

            StreamWriter writer = File.CreateText("C:\\aaaa\\a1.txt");

            writer.WriteLine("Below text is written using StramWriter class ");
            writer.WriteLine("My name is Mahesh Patil");
            writer.Close();

            //Reading in file using StreamReader class
            StreamReader reader = File.OpenText("C:\\aaaa\\a1.txt");
            string line;
            while((line = reader.ReadLine()) != null)
            {
                Console.WriteLine(line);
            }
            reader.Close();
        }
    }
}