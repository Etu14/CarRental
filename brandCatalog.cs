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

        private async void guna2Panel4_Paint(object sender, PaintEventArgs e)
        {
            MySqlConnection connection = new MySqlConnection("datasource=localhost;port=3306;username=root;password=; database=car_rent");
            connection.Open();
            string query = "SELECT img_path FROM car_rent.brands";
            MySqlCommand command = new MySqlCommand(query, connection);
            MySqlDataReader reader = command.ExecuteReader();

            int y = 25;
            int x = 75;
            int column_count = 0;
            int row_count = 0;

            while (reader.Read())
            {
                column_count++;
                if (column_count > 6)
                {   
                    row_count++;
                    if(row_count == 4)
                    {
                        y += 0;
                    }
                    else
                    {
                        y += 125;
                        column_count = 1;
                    }
                }
                if (column_count == 1)
                {
                    x = 75;
                }
                else
                {
                    x += 150;
                }
                string picturePath = reader["img_path"].ToString();
                string image = Path.Combine("../../", "Resources", picturePath);

                // Check if the image file exists before attempting to load it
                if (File.Exists(image))
                {
                    using (FileStream fs = new FileStream(image, FileMode.Open, FileAccess.Read))
                    {
                        // Load the image asynchronously
                        Image originalImage = await Task.Run(() => Image.FromStream(fs));

                        // Resize the image while maintaining the aspect ratio
                        Image resizedImage = ResizeImage(originalImage, 125, 125);

                        // Dispose the original image to free up memory
                        originalImage.Dispose();

                        //styles
                        Guna2PictureBox pb = new Guna2PictureBox();
                        pb.Image = resizedImage;
                        pb.SizeMode = PictureBoxSizeMode.Zoom;
                        pb.Size = new Size(100, 100);
                        pb.Location = new Point(x, y);
                        pb.BorderStyle = BorderStyle.FixedSingle;

                        pb.MouseClick += PictureBox_MouseClick;

                        guna2Panel4.Controls.Add(pb);
                    }
                }
            }

            reader.Close();
            connection.Close();
        }

        private Image ResizeImage(Image image, int width, int height)
        {
            // Calculate the new width and height while maintaining the aspect ratio
            int newWidth;
            int newHeight;
            double aspectRatio = (double)image.Width / image.Height;

            if (aspectRatio > 1)
            {
                newWidth = width;
                newHeight = (int)(width / aspectRatio);
            }
            else
            {
                newWidth = (int)(height * aspectRatio);
                newHeight = height;
            }

            // Create a new bitmap with the resized dimensions
            Bitmap resizedImage = new Bitmap(newWidth, newHeight);

            // Draw the original image onto the resized bitmap
            using (Graphics graphics = Graphics.FromImage(resizedImage))
            {
                graphics.DrawImage(image, 0, 0, newWidth, newHeight);
            }

            return resizedImage;
        }



        private void PictureBox_MouseClick(object sender, MouseEventArgs e)
        {

        }

        private void guna2TextBox1_TextChanged(object sender, EventArgs e)
        {

        }

    }
}

