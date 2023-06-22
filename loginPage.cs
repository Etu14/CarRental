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
using MySql.Data.MySqlClient;
using CarRentalSystem;

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
            this.Hide();
            registerPage win2 = new registerPage();
            win2.Show();
            this.Dispose();
        }

        private void guna2Panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        static string constr = ("Data Source=localhost;port=3306;username=root;password=");
        static MySqlConnection con = new MySqlConnection(constr);
        private void guna2Button1_Click(object sender, EventArgs e)
        {

            Color deafault_c = Color.FromArgb(64, 64, 64);
            Color wrong_c = Color.FromArgb(253, 87, 87);


            guna2TextBox1.BorderColor = deafault_c;
            guna2TextBox2.BorderColor = deafault_c;
            guna2TextBox1.PlaceholderForeColor = deafault_c;
            guna2TextBox2.PlaceholderForeColor = deafault_c;
            guna2TextBox1.PlaceholderText = "Username";
            guna2TextBox2.PlaceholderText = "Password";
            guna2TextBox1.HoverState.BorderColor = deafault_c;
            guna2TextBox2.HoverState.BorderColor = deafault_c;
            guna2TextBox1.HoverState.ForeColor = deafault_c;
            guna2TextBox2.HoverState.ForeColor = deafault_c;

            try
            {
                if (guna2TextBox1.Text == "" && guna2TextBox2.Text == "")
                {
                    guna2TextBox1.BorderColor = wrong_c;
                    guna2TextBox2.BorderColor = wrong_c;
                    guna2TextBox1.PlaceholderForeColor = wrong_c;
                    guna2TextBox2.PlaceholderForeColor = wrong_c;
                    guna2TextBox1.PlaceholderText = "Enter your username!";
                    guna2TextBox2.PlaceholderText = "Enter your password!";
                    guna2TextBox1.HoverState.BorderColor = wrong_c;
                    guna2TextBox2.HoverState.BorderColor = wrong_c;
                    guna2TextBox1.HoverState.PlaceholderForeColor = wrong_c;
                    guna2TextBox2.HoverState.PlaceholderForeColor = wrong_c;
                }
                else
                {
                    if (con.State == ConnectionState.Closed)
                    {
                        con.Open();

                    }
                    string query = "SELECT user_username, user_password FROM car_rent.user_info WHERE user_username = '" + guna2TextBox1.Text + "'";
                    MySqlCommand cmd = new MySqlCommand(query, con);
                    MySqlDataReader sdr = cmd.ExecuteReader();

                    if (sdr.HasRows)
                    {
                        sdr.Read();

                        if (sdr["user_password"].Equals(guna2TextBox2.Text))
                        {
                            this.Hide();
                            userProfile win2 = new userProfile();
                            win2.Show();
                            this.Dispose();
                            SharedData.username = guna2TextBox1.Text;
                        }
                        else
                        {
                            guna2TextBox2.BorderColor = wrong_c;
                            guna2TextBox2.PlaceholderForeColor = wrong_c;
                            guna2TextBox2.PlaceholderText = "Incorrect password";
                            guna2TextBox2.HoverState.BorderColor = wrong_c;
                            guna2TextBox2.HoverState.PlaceholderForeColor = wrong_c;
                        }
                    }
                    else
                    {
                        guna2TextBox1.BorderColor = wrong_c;
                        guna2TextBox1.PlaceholderForeColor = wrong_c;
                        guna2TextBox1.PlaceholderText = "Incorrect username!";
                        guna2TextBox1.HoverState.BorderColor = wrong_c;
                        guna2TextBox1.Text = string.Empty;
                        guna2TextBox1.HoverState.PlaceholderForeColor = wrong_c;
                        if (guna2TextBox2.Text == "")
                        {
                            guna2TextBox2.BorderColor = wrong_c;
                            guna2TextBox2.PlaceholderForeColor = wrong_c;
                            guna2TextBox2.PlaceholderText = "Enter your password!";
                            guna2TextBox2.HoverState.BorderColor = wrong_c;
                            guna2TextBox2.HoverState.PlaceholderForeColor = wrong_c;
                        }
                    }

                    con.Close();


                }
            }
            catch (Exception ex)
            {

                con.Close();
                
            }
        }


    }


}

