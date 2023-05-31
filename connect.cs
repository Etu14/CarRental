using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System;
using System.Data.SqlClient;

namespace CarRentalSystem
{
   

    public class Connection
    {
        static void connectDB()
        {
            // Connection string for connecting to the database on localhost
            string connectionString = "Data Source=localhost;Initial Catalog=users;Integrated Security=True";

            try
            {
                // Create a new SqlConnection object with the connection string
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    // Open the database connection
                    connection.Open();
                    Console.WriteLine("Connection to the database established.");

                    // Execute a simple query
                    string query = "SELECT * FROM users";
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        // Execute the query and retrieve the results
                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            // Process the retrieved data
                            while (reader.Read())
                            {
                                // Assuming you have a 'Name' column in your table
                                string name = reader.GetString(reader.GetOrdinal("Name"));
                                Console.WriteLine("Name: " + name);
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error: " + ex.Message);
            }

            Console.ReadLine();
        }
    }
}
