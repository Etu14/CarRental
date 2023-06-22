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
    public partial class carCatalog : Form
    {
        public carCatalog()
        {
            InitializeComponent();
        }

        private void guna2Panel4_Paint(object sender, PaintEventArgs e)
        {
            MySqlConnection connection = new MySqlConnection("datasource=localhost;port=3306;username=root;password=; database=car_rent");
            connection.Open();
            string query = "SELECT car_img_path FROM car_rent.cars";
            MySqlCommand command = new MySqlCommand(query, connection);
            MySqlDataReader reader = command.ExecuteReader();
            int y = 80;
            int x = 80;
            int column_count = 0;
            while (reader.Read())
            {
                column_count++;
                if (column_count == 2)
                {
                    y += 80;
                    column_count = 0;
                }
                if (column_count == 1)
                {
                    x = 80;
                }
                else
                {
                    x += 250;
                }
                string picturePath = reader["car_img_path"].ToString();
                string image = Path.Combine("../../", "Resources", picturePath);

                Image img = Image.FromFile(image);

                //styles
                Guna2PictureBox pb = new Guna2PictureBox();
                pb.Image = img;
                pb.SizeMode = PictureBoxSizeMode.Zoom;
                pb.Size = new Size(300, 150);
                pb.Location = new Point(x, y);
                pb.BorderStyle = BorderStyle.FixedSingle;

                pb.MouseClick += PictureBox_MouseClick;

                guna2Panel4.Controls.Add(pb);



            }
            reader.Close();
            connection.Close();
        }

        private void guna2ContainerControl1_Click(object sender, EventArgs e)
        {

        }
        private void PictureBox_MouseClick(object sender, MouseEventArgs e)
        {

        }

        private void linkLabel3_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();
            userProfile win2 = new userProfile();
            win2.Show();
            this.Dispose();
        }

        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();
            main_page win2 = new main_page();
            win2.Show();
            this.Dispose();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();
            main_page win2 = new main_page();
            win2.Show();
            this.Dispose();
        }
    }

}
