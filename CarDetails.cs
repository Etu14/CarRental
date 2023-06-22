using Guna.UI2.WinForms;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CarRentalSystem;

namespace CarRentalSystem
{
    public partial class CarDetails : Form
    {
        static string constr = ("Data Source=localhost;port=3306;username=root;password=");
        static MySqlConnection con = new MySqlConnection(constr);

        private int car_id;
        public int carId { get; set; }
        public CarDetails(int id)
        {   
            car_id = id;
            InitializeComponent();
            this.Load += CarDetails_Load;

        }

        private void CarDetails_Load(object sender, EventArgs e)
        {

            string query = "SELECT * FROM car_rent.cars WHERE id  = @carId";
            MySqlCommand cmd = new MySqlCommand(query, con);
            cmd.Parameters.AddWithValue("@carId", car_id);

            con.Open();
            MySqlDataReader reader = cmd.ExecuteReader();

            if (reader.Read())
            {

                string brand = reader.GetString("brand");
                string model = reader.GetString("model");
                string carName = $"{brand} {model}";
                int top_speed = reader.GetInt32("top_speed");
                float acceleration = reader.GetFloat("acceleration");
                int power = reader.GetInt32("power");
                int doors = reader.GetInt32("doors");
                string gearbox = reader.GetString("gearbox");
                int seats = reader.GetInt32("seats");

                // Example: Assigning values to labels
                guna2HtmlLabel14.Text = top_speed.ToString();
                guna2HtmlLabel14.AutoSize = true;

                guna2HtmlLabel15.Text = acceleration.ToString();
                guna2HtmlLabel15.AutoSize = true;

                guna2HtmlLabel18.Text = power.ToString();
                guna2HtmlLabel18.AutoSize = true;

                guna2HtmlLabel10.Text = doors.ToString()+ " doors";
                guna2HtmlLabel10.AutoSize = true;

                guna2HtmlLabel9.Text = gearbox;
                guna2HtmlLabel9.AutoSize = true;

                guna2HtmlLabel7.Text = seats.ToString()+" seats";
                guna2HtmlLabel7.AutoSize = true;

                guna2HtmlLabel1.Text = carName;
                guna2HtmlLabel1.AutoSize = true;

                Guna2PictureBox pb = new Guna2PictureBox();
                string picturePath = reader["car_img_path"].ToString();
                string image = Path.Combine("../../", "Resources", picturePath);
                pb.Image = Image.FromFile(image);
                pb.SizeMode = PictureBoxSizeMode.Zoom;
                pb.Size = new Size(500, 350);
                pb.Location = new Point(50, 40);
                pb.BackColor = Color.LightGray;

                guna2Panel4.Controls.Add(pb);

                guna2Panel4.Paint += (paintSender, paintArgs) =>
                {

                };
            }

            reader.Close();
            con.Close();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();
            main_page win2 = new main_page();
            win2.Show();
        }

        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

        }

        private void linkLabel3_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();
            loginPage win2 = new loginPage();
            win2.Show();
        }

        private void guna2HtmlLabel1_Click(object sender, EventArgs e)
        {
            //car name
        }

        private void guna2Panel4_Paint(object sender, PaintEventArgs e)
        {

        }

        private void guna2HtmlLabel7_Click(object sender, EventArgs e)
        {
            //seats
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Date win2 = new Date(car_id);
            win2.Show();
        }

        private void guna2PictureBox10_Click(object sender, EventArgs e)
        {

        }

        private void guna2HtmlLabel14_Click(object sender, EventArgs e)
        {
            //top speed
        }

        private void guna2HtmlLabel15_Click(object sender, EventArgs e)
        {
            //acceleration
        }

        private void guna2HtmlLabel18_Click(object sender, EventArgs e)
        {
            //power
        }

        private void guna2HtmlLabel10_Click(object sender, EventArgs e)
        {
            //doors
        }

        private void guna2HtmlLabel9_Click(object sender, EventArgs e)
        {
            //gearbox
        }

        private void guna2PictureBox4_Click(object sender, EventArgs e)
        {

        }
    }
}
