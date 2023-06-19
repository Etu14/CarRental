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
    public partial class brandCatalog : Form
    {
        public brandCatalog()
        {
            InitializeComponent();
        }

        private void brandCatalog_Load(object sender, EventArgs e)
        {

        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

        }

        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

        }

        private void linkLabel3_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

        }

        
        private void guna2PictureBox1_Click(object sender, EventArgs e)
        {
            
        }

        private void guna2Panel4_Paint(object sender, PaintEventArgs e)
        {
            MySqlConnection connection = new MySqlConnection("datasource=localhost;port=3306;username=root;password=; database=car_rent");
            connection.Open();
            string query = "SELECT img_path FROM car_rent.brands";
            MySqlCommand command = new MySqlCommand(query, connection);
            MySqlDataReader reader = command.ExecuteReader();
            int y = 20;
            int x = 80;
            int column_count = 0;
            while (reader.Read())
            {
                column_count++;
                if (column_count == 5)
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
                string picturePath = reader["img_path"].ToString();
                string image = Path.Combine("../../", "Resources",picturePath);

                Image img = Image.FromFile(image);

                //styles
                Guna2PictureBox pb = new Guna2PictureBox();
                pb.Image = img;
                pb.SizeMode = PictureBoxSizeMode.StretchImage;
                pb.Size = new Size(200, 100);
                pb.Location = new Point(x, y);
                pb.BorderStyle = BorderStyle.FixedSingle;

                pb.MouseClick += PictureBox_MouseClick;

                guna2Panel4.Controls.Add(pb);

                
                
            }
            reader.Close();
            connection.Close();
        }
        private void PictureBox_MouseClick(object sender, MouseEventArgs e)
        {
            
        }

        private void guna2TextBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}

