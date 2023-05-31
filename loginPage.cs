using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace CarRentalSystem
{
    public partial class loginPage : Form
    {
        public loginPage()
        {
            InitializeComponent();
        }

        private void loginPage_Load(object sender, EventArgs e)
        {

        }

        private void guna2TextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void guna2TextBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

        }

        private void guna2Panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            // Connection string for connecting to the database on localhost
            string connectionString = "Data Source=localhost;Initial Catalog=users;";

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
                                string name = reader.GetString(reader.GetOrdinal("username"));
                                Console.WriteLine("Username: " + name);
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
