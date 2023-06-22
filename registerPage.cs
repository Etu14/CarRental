using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CarRentalSystem
{
    public partial class registerPage : Form
    {
        private static string constr = "datasource=localhost;port=3306;username=root;password=";
        private static MySqlConnection con = new MySqlConnection(constr);

        public registerPage()
        {
            InitializeComponent();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();
            loginPage win2 = new loginPage();
            win2.Show();
            this.Dispose();
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            string username = guna2TextBox1.Text;
            string password = guna2TextBox2.Text;
            string repeatPassword = guna2TextBox3.Text;

            if (password != repeatPassword)
            {
                MessageBox.Show("Passwords do not match. Please try again.");
                return;
            }

            if (string.IsNullOrWhiteSpace(username) || string.IsNullOrWhiteSpace(password))
            {
                MessageBox.Show("Please enter a username and password.");
                return;
            }

            try
            {
                con.Open();
                string query = "INSERT INTO car_rent.user_info (user_username, user_password) VALUES (@username, @password)";
                MySqlCommand cmd = new MySqlCommand(query, con);
                cmd.Parameters.AddWithValue("@username", username);
                cmd.Parameters.AddWithValue("@password", password);
                cmd.ExecuteNonQuery();

                MessageBox.Show("Registration successful!");

                this.Hide();
                loginPage win2 = new loginPage();
                win2.Show();
                this.Dispose();

                // Clear the input fields
                guna2TextBox1.Clear();
                guna2TextBox2.Clear();
                guna2TextBox3.Clear();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error occurred: " + ex.Message);
            }
            finally
            {
                con.Close();
            }
        }

        private void guna2TextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void guna2TextBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void guna2TextBox3_TextChanged(object sender, EventArgs e)
        {

        }
    }
}

