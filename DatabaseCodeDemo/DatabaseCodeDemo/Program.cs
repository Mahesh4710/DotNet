using Microsoft.Data.SqlClient;
using System.ComponentModel;
using System.ComponentModel.Design.Serialization;
using System.Data.Common;
using System.Data;
using System.Threading.Channels;

namespace DatabaseCodeDemo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Connect();
            //Insert1();

            Employee employee = new Employee();
            employee.GetEmployee();
            //Insert(employee);  //stored procedure

            //Update(employee);

            Select(employee);

            //Delete1();
        }
        static void Connect()
        {
            SqlConnection conn = new SqlConnection();

            //conn.ConnectionString = "Data Source=NameOfSqlServer";Initial Catlog = DbMetaDataCollectionNames;UserId = RootDesignerSerializerAttribute;PasswordPropertyTextAttribute = pwd;

            conn.ConnectionString = @"Data Source =(localdb)\MSSqlLocalDb;Initial Catalog=KTjune23;Integrated Security=true";
            conn.Open();
            Console.WriteLine("Open");
            conn.Close();
            Console.WriteLine("Close"); 
        }

        static void Insert1()
        {
            SqlConnection conn = new SqlConnection();
            conn.ConnectionString = @"Data Source =(localdb)\MSSqlLocalDb;Initial Catalog=KTjune23;Integrated Security=true";
            conn.Open();

            try
            {
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = conn;
                cmd.CommandType = CommandType.Text;

                cmd.CommandText = "Insert  into Employees values(4,'Tata',1234,30)";


                cmd.ExecuteNonQuery();
            }
            catch(Exception ex) 
            {
                Console.WriteLine( ex.Message);
            }

            finally
            {
                conn.Close();
            }
           

        }
        static void Delete1()
        {
            SqlConnection conn = new SqlConnection();
            conn.ConnectionString = @"Data Source =(localdb)\MSSqlLocalDb;Initial Catalog=KTjune23;Integrated Security=true";
            conn.Open();

            try
            {
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = conn;
                cmd.CommandType = CommandType.Text;

                cmd.CommandText = "Delete from employees where EmpNo=25";


                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

            finally
            {
                conn.Close();
            }


        }

        static void Insert(Employee obj)
        {
            SqlConnection conn = new SqlConnection();
            conn.ConnectionString = @"Data Source =(localdb)\MSSqlLocalDb;Initial Catalog=KTjune23;Integrated Security=true";
            conn.Open();

            try
            {
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = conn;
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.CommandText = "InsertEmployee";

                cmd.Parameters.AddWithValue("@EmpNo", obj.EmpNo);
                cmd.Parameters.AddWithValue("@Name", obj.Name);
                cmd.Parameters.AddWithValue("@Basic", obj.Basic);
                cmd.Parameters.AddWithValue("@DeptNo", obj.DeptNo);


                Console.WriteLine("LEts see!");
                cmd.ExecuteNonQuery();
                Console.WriteLine("Done!");
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

            finally
            {
                conn.Close();
            }


        }

        static void Insert5(Employee obj)
        {
            SqlConnection conn = new SqlConnection();
            conn.ConnectionString = @"Data Source =(localdb)\MSSqlLocalDb;Initial Catalog=KTjune23;Integrated Security=true";
            conn.Open();

            try
            {
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = conn;
                cmd.CommandType = CommandType.Text;

                cmd.CommandText = $"Insert  into Employees values(@EmpNo,@Name,@Basic,@DeptNo)";

                cmd.Parameters.AddWithValue("@EmpNo", obj.EmpNo);
                cmd.Parameters.AddWithValue("@Name", obj.Name);
                cmd.Parameters.AddWithValue("@Basic", obj.Basic);
                cmd.Parameters.AddWithValue("@DeptNo", obj.DeptNo);


                Console.WriteLine("LEts see!");
                cmd.ExecuteNonQuery();
                Console.WriteLine("Done!");
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

            finally
            {
                conn.Close();
            }


        }

        static void Update(Employee obj)
        {
            SqlConnection conn = new SqlConnection();
            conn.ConnectionString = @"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=KTjune23;Integrated Security=True;Connect Timeout=30;Encrypt=False;Trust Server Certificate=False;Application Intent=ReadWrite;Multi Subnet Failover=False";
            conn.Open();

            try
            {
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = conn;
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.CommandText = "UpdateRec";

                cmd.Parameters.AddWithValue("@EmpNo", obj.EmpNo);
                cmd.Parameters.AddWithValue("@Name",obj.Name);
                cmd.Parameters.AddWithValue("@Basic", obj.Basic);
                cmd.Parameters.AddWithValue("@DeptNo", obj.DeptNo);

                cmd.ExecuteNonQuery ();

            }
            catch(Exception exe)
            {
                Console.WriteLine(exe.Message);
            }

        }
        static void Delete()
        {
            SqlConnection conn = new SqlConnection();

            conn.ConnectionString = @"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=KTjune23;Integrated Security=True;Connect Timeout=30;Encrypt=False;Trust Server Certificate=False;Application Intent=ReadWrite;Multi Subnet Failover=False";
            conn.Open();

            try
            {
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = conn;
                cmd.CommandType = CommandType.Text;
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        static void Select(Employee obj)
        {
            SqlConnection conn = new SqlConnection();
            conn.ConnectionString = @"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=KTjune23;Integrated Security=True;Connect Timeout=30;Encrypt=False;Trust Server Certificate=False;Application Intent=ReadWrite;Multi Subnet Failover=False";
            conn.Open();

            try
            {
                SqlCommand cmd = new SqlCommand ();
                cmd.Connection = conn;
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.CommandText = "SelectRec";

                cmd.Parameters.AddWithValue("@EmpNo", obj.EmpNo);

                SqlDataReader dr =cmd.ExecuteReader();
                while(dr.Read())
                {
                    for(int i=0; i<dr.FieldCount;i++)
                    {
                        Console.WriteLine(dr[i]);
                    }
                    //Console.WriteLine(dr[0]);
                    //Console.WriteLine(dr[1]);
                    //Console.WriteLine(dr[2]);
                    //Console.WriteLine(dr[3]);
                    //Console.WriteLine(dr[4]);
                    //Console.WriteLine(dr[5]);
                }
            }
            catch(Exception ex) {
                Console.WriteLine(ex.Message);
            }
            finally
            {
                conn.Close();
            }
        
        }

    }




    class Employee
    {
        public int EmpNo { get; set; }
        public string Name { get; set; }
        public decimal Basic { get; set; }
        public int DeptNo { get; set; }

        public void GetEmployee()
        {
            Console.WriteLine("Enter the Employee No");
            string val = Console.ReadLine();
            EmpNo = Convert.ToInt32(val);

            Console.WriteLine("Enter the Name");
            Name = Console.ReadLine();
           

            Console.WriteLine("Enter the Employee Basic");
            val = Console.ReadLine();
            Basic = Convert.ToDecimal(val);


            Console.WriteLine("Enter the Employee DeptNo");
            val = Console.ReadLine();
            DeptNo = Convert.ToInt32(val);
        }

    }
}