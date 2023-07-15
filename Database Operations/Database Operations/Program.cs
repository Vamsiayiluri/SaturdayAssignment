using System;
using System.Data.SqlClient;

class DatabaseOperationsApp
{
    static void Main()
    {
        
        string connectionString = @"Data Source=192.168.0.30;Initial Catalog=vamsi;Persist Security Info=True;User ID=User5;Password=CDev005#8";
        try
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                
                string query = "SELECT * FROM Customers";
                Console.WriteLine(query);
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            
                            int customerName = reader.GetInt32(0);
                            string name = reader.GetString(1);

                            Console.WriteLine($"Customer: {customerName}, name: {name}");
                        }
                    }
                }

                Console.WriteLine("Database operations completed successfully!");
            }
        }
        catch (SqlException ex)
        {
            Console.WriteLine("A database error occurred: " + ex.Message);
           
        }
        catch (Exception ex)
        {
            Console.WriteLine("An error occurred: " + ex.Message);
        }

        Console.ReadLine();
    }
}
