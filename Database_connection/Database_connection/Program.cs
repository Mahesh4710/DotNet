
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;

namespace Database_connection
{
    //internal class Program
    //{
    //    static void Main(string[] args)
    //    {
    //        Console.WriteLine("Hello, World!");
    //    }
    //}
    
public class Customer
    {
        public int CustID { get; set; }
        public string Name { get; set; }
        public string Address { get; set; }
        public string Email { get; set; }
        public string Mobile { get; set; }
    }

    public class Program
    {
        // Replace the connection string with your own database connection string
        private static string connectionString = "Your_Connection_String";

        public static void Main(string[] args)
        {
            InsertCustomer(new Customer
            {
                Name = "John Doe",
                Address = "123 Main St",
                Email = "johndoe@example.com",
                Mobile = "1234567890"
            });

            List<Customer> customers = GetCustomers();

            foreach (Customer customer in customers)
            {
                Console.WriteLine($"Name: {customer.Name}, Email: {customer.Email}");
            }
        }

        public static void InsertCustomer(Customer customer)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string query = "INSERT INTO Customers (Name, Address, Email, Mobile) " +
                               "VALUES (@Name, @Address, @Email, @Mobile)";

                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@Name", customer.Name);
                command.Parameters.AddWithValue("@Address", customer.Address);
                command.Parameters.AddWithValue("@Email", customer.Email);
                command.Parameters.AddWithValue("@Mobile", customer.Mobile);

                connection.Open();
                command.ExecuteNonQuery();
            }
        }

        public static List<Customer> GetCustomers()
        {
            List<Customer> customers = new List<Customer>();

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string query = "SELECT Name, Email FROM Customers";

                SqlCommand command = new SqlCommand(query, connection);

                connection.Open();
                SqlDataReader reader = command.ExecuteReader();

                while (reader.Read())
                {
                    Customer customer = new Customer
                    {
                        Name = reader.GetString(0),
                        Email = reader.GetString(1)
                    };

                    customers.Add(customer);
                }

                reader.Close();
            }

            return customers;
        }
    }

}