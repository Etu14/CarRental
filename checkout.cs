using Guna.UI2.WinForms;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CarRentalSystem
{
    public partial class checkout : Form
    {
        private string brand;
        private DateTime selectedDate1;
        private DateTime selectedDate3;
        private string location;
        private int CarId;
        public checkout(DateTime SelectedDate1, DateTime SelectedDate3, string location, int carId)
        {
            InitializeComponent();
            selectedDate1 = SelectedDate1;
            selectedDate3 = SelectedDate3;
            this.location = location;
            this.CarId = carId;
        }

        private void checkout_Load(object sender, EventArgs e)
        {
            string query = "SELECT * FROM car_rent.cars WHERE id  = @carId";
            MySqlCommand cmd = new MySqlCommand(query, con);
            cmd.Parameters.AddWithValue("@carId", CarId);

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


                guna2HtmlLabel10.Text = doors.ToString() + " doors";
                guna2HtmlLabel10.AutoSize = true;

                guna2HtmlLabel9.Text = gearbox;
                guna2HtmlLabel9.AutoSize = true;

                guna2HtmlLabel7.Text = seats.ToString() + " seats";
                guna2HtmlLabel7.AutoSize = true;

                guna2HtmlLabel1.Text = carName;
                guna2HtmlLabel1.AutoSize = true;

                Guna2PictureBox pb = new Guna2PictureBox();
                string picturePath = reader["car_img_path"].ToString();
                string image = Path.Combine("../../", "Resources", picturePath);
                pb.Image = Image.FromFile(image);
                pb.SizeMode = PictureBoxSizeMode.Zoom;
                pb.Size = new Size(450, 300);
                pb.Location = new Point(50, 40);
                pb.BackColor = Color.LightGray;

                guna2Panel4.Controls.Add(pb);


            }
            con.Close();
        }
        public static class SharedData
        {
            public static int CarId { get; set; }
        }

        public static int parentX,parenY;
        static string constr = ("Data Source=localhost;port=3306;username=root;password=");
        static MySqlConnection con = new MySqlConnection(constr);
        private void guna2Button1_Click(object sender, EventArgs e)
        {
            string username = "Guest";
            


                if (guna2ComboBox1.SelectedItem != null)
                {
                    string selectedPaymentMethod = guna2ComboBox1.SelectedItem.ToString();

                    if (selectedPaymentMethod == "Visa Card")
                    {
                    modalError modalForm = new modalError();
                    modalForm.ShowDialog();

                }
                    else if (selectedPaymentMethod == "Cash")
                    {

                    ModalSuc modalForm = new ModalSuc();
                    modalForm.ShowDialog();
                    }
               
                string query = "INSERT INTO car_rent.rents (user, car_id, start, end, payment, location) VALUES (@username, @CarId, @startDate, @endDate, @payment, @location)";
                MySqlCommand cmd = new MySqlCommand(query, con);
                cmd.Parameters.AddWithValue("@username", username);
                cmd.Parameters.AddWithValue("@CarId", CarId);
                cmd.Parameters.AddWithValue("@startDate", selectedDate1);
                cmd.Parameters.AddWithValue("@endDate", selectedDate3);
                cmd.Parameters.AddWithValue("@payment", selectedPaymentMethod);
                cmd.Parameters.AddWithValue("@location", location);
                con.Open();
                cmd.ExecuteNonQuery();
                con.Close();
            }
        }


        private void guna2Panel4_Paint(object sender, PaintEventArgs e)
        {

        }

        private void guna2HtmlLabel7_Click(object sender, EventArgs e)
        {
            //seats
        }

        private void guna2PictureBox9_Click(object sender, EventArgs e)
        {

        }

        private void guna2HtmlLabel10_Click(object sender, EventArgs e)
        {
            //doors
        }

        private void guna2PictureBox7_Click(object sender, EventArgs e)
        {

        }

        private void guna2HtmlLabel9_Click(object sender, EventArgs e)
        {
            //gearbox
        }

        private void guna2PictureBox6_Click(object sender, EventArgs e)
        {

        }

        private void guna2HtmlLabel8_Click(object sender, EventArgs e)
        {

        }

        private void guna2PictureBox5_Click(object sender, EventArgs e)
        {

        }

        private void guna2PictureBox8_Click(object sender, EventArgs e)
        {

        }

        private void guna2HtmlLabel1_Click(object sender, EventArgs e)
        {
            //car name
        }

        private void guna2Panel9_Paint(object sender, PaintEventArgs e)
        {

        }

        private void guna2ComboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void guna2PictureBox4_Click(object sender, EventArgs e)
        {

        }

        private void guna2Panel6_Paint(object sender, PaintEventArgs e)
        {

        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();
            main_page win2 = new main_page();
            win2.Show();
            this.Dispose();

        }

        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            
            this.Hide();
            carCatalog win2 = new carCatalog(brand);
            win2.Show();
            this.Dispose();
        }

        private void linkLabel3_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();
            loginPage win2 = new loginPage();
            win2.Show();
            this.Dispose();

        }

        private void guna2Panel5_Paint(object sender, PaintEventArgs e)
        {

        }

        private void guna2Panel7_Paint(object sender, PaintEventArgs e)
        {
            if (selectedDate1 != null)
            {
                // Create a Label control to display the selected date
                Label lblSelectedDate = new Label();
                lblSelectedDate.Text = selectedDate1.ToString("dd-MM-yyyy") ;
                lblSelectedDate.Font = new Font("Arial", 12, FontStyle.Bold);
                lblSelectedDate.AutoSize = true;
                lblSelectedDate.Location = new Point(50, 10); // Adjust the location as needed

                // Add the Label control to the panel
                guna2Panel7.Controls.Add(lblSelectedDate);
            }
        }

        private void guna2Panel8_Paint(object sender, PaintEventArgs e)
        {
            if (selectedDate3 != null)
            {
                // Create a Label control to display the selected date
                Label lblSelectedDate = new Label();
                lblSelectedDate.Text = selectedDate3.ToString("dd-MM-yyyy");
                lblSelectedDate.Font = new Font("Arial", 12, FontStyle.Bold);
                lblSelectedDate.AutoSize = true;
                lblSelectedDate.Location = new Point(50, 10); // Adjust the location as needed

                // Add the Label control to the panel
                guna2Panel8.Controls.Add(lblSelectedDate);
            }
        }

        private void label12_Click(object sender, EventArgs e)
        {

        }

        private void guna2Panel10_Paint(object sender, PaintEventArgs e)
        {
            if (location != null)
            {
                // Create a Label control to display the selected date
                Label lbllocation = new Label();
                lbllocation.Text = location.ToString();
                lbllocation.Font = new Font("Arial", 12, FontStyle.Bold);
                lbllocation.AutoSize = true;
                lbllocation.Location = new Point(50, 10); // Adjust the location as needed

                // Add the Label control to the panel
                guna2Panel10.Controls.Add(lbllocation);
            }
        }

        private void guna2PictureBox10_Click(object sender, EventArgs e)
        {
            //car image
        }

        private void guna2HtmlLabel3_Click(object sender, EventArgs e)
        {

        }
    }
}
