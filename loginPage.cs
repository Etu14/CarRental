using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Guna.UI2.WinForms;
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

        static string constr = ("Data Source=localhost;port=3306;username=root;password=");
        static MySqlConnection con = new MySqlConnection(constr);
        private void guna2Button1_Click(object sender, EventArgs e)
        {

            try
            {
                if(guna2TextBox1.Text == "" && guna2TextBox2.Text == "")
                {
                    guna2TextBox1.PlaceholderText = "wrong name";
                    guna2TextBox2.PlaceholderText = "wrong password";
                }
                else
                {
                    if (con.State == ConnectionState.Closed)
                    {
                        con.Open();

                    }
                    string query = "SELECT name,password FROM car_rental.users WHERE name = '" + guna2TextBox1.Text + "'";
                    MySqlCommand cmd = new MySqlCommand(query, con);
                    MySqlDataReader sdr = cmd.ExecuteReader();

                    if (sdr.HasRows)
                    {
                        sdr.Read();

                        if (sdr["password"].Equals(guna2TextBox2.Text))
                        {
                            MessageBox.Show("Si registrovany", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                        else
                        {
                            guna2TextBox2.PlaceholderText = "Incorrect password";
                        }
                    }
                    else
                    {
                        guna2TextBox1.PlaceholderText = "Incorrect username!";
                        guna2TextBox1.Text = string.Empty;
                        guna2TextBox2.PlaceholderText = "Incorrect password!";
                        guna2TextBox2.Text = string.Empty;
                        
                    }

                    con.Close();

                }
            }
            catch (Exception ex)
            {

                con.Close();
                MessageBox.Show(" " + ex + " ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }


    }


}

