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
using System.Web.UI.WebControls.WebParts;
using System.Windows.Forms;


namespace CarRentalSystem
{
    public partial class carCatalog : Form
    {
        public carCatalog()
        {
            InitializeComponent();
            LoadCarGallery();
        }
        public static class SharedData
        {
            public static int CarId { get; set; }
        }
        private void guna2Panel4_Paint(object sender, PaintEventArgs e)
        {
           
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

        private void LoadCarGallery()
        {
            MySqlConnection connection = new MySqlConnection("datasource=localhost;port=3306;username=root;password=;database=car_rent");
            connection.Open();
            string query = "SELECT id, car_img_path, brand, model FROM car_rent.cars";
            MySqlCommand command = new MySqlCommand(query, connection);
            MySqlDataAdapter adapter = new MySqlDataAdapter(command);
            DataTable dataTable = new DataTable();
            adapter.Fill(dataTable);

            MySqlDataReader reader = command.ExecuteReader();
            reader.Read();
            int id = reader.GetInt32("id");
            string car_id = id.ToString();
            guna2Panel4.Controls.Clear(); 

            int y = 25;
            int x = 100;
            int columnCount = 0;
            int pictureCount = 0;

            foreach (DataRow row in dataTable.Rows)
            {

                pictureCount++; 
                string picturePath = row["car_img_path"].ToString();
                string image = Path.Combine("../../", "Resources", picturePath);

                Image img = Image.FromFile(image);
                Image resizedImage = ResizeImage(img, 350, 175);
                img.Dispose();

                int row_count = 0;
                columnCount++;

                x += 425;
                if (columnCount >= 3)
                {
                    y += 250;
                    x = 100;
                    columnCount = 0;
                    row_count++;
                }
                if (columnCount == 1)
                {
                    x = 100;
                }
                if (row_count == 2)
                {
                    x = 100;
                }


                Guna2PictureBox pb = new Guna2PictureBox();
                pb.Image = resizedImage;
                pb.SizeMode = PictureBoxSizeMode.Zoom;
                pb.Size = new Size(350, 175);
                pb.BorderStyle = BorderStyle.FixedSingle;

                pb.Tag = row["brand"].ToString() + " " + row["model"].ToString();
                pb.Name = "pictureBox_" + row["id"].ToString();

                pb.MouseClick += (sender, e) =>
                {
                    Guna2PictureBox pictureBox = (Guna2PictureBox)sender;

                    // Retrieve the id from the PictureBox's unique identifier
                    string pictureBoxId = pictureBox.Name.Replace("pictureBox_", "");
                    int id = int.Parse(pictureBoxId);
                    SharedData.CarId = id;

                    this.Hide();
                    CarDetails win2 = new CarDetails(id);
                    win2.Show();
                    this.Dispose();
                };



                pb.Location = new Point(x, y);
                guna2Panel4.Controls.Add(pb);

                Label lblBrandModel = new Label();
                lblBrandModel.Text = row["brand"].ToString() + " " + row["model"].ToString();
                lblBrandModel.AutoSize = false;
                lblBrandModel.Width = pb.Width;
                lblBrandModel.Font = new Font("Arial", 10, FontStyle.Bold);
                lblBrandModel.Location = new Point(x, y + pb.Height + 5);
                lblBrandModel.BackColor = Color.DarkGray;
                lblBrandModel.BorderStyle = BorderStyle.FixedSingle;
                guna2Panel4.Controls.Add(lblBrandModel);
            }

            connection.Close();
        }

        

        private Image ResizeImage(Image image, int width, int height)
        {
            Bitmap resizedImage = new Bitmap(width, height);
            using (Graphics graphics = Graphics.FromImage(resizedImage))
            {
                graphics.DrawImage(image, 0, 0, width, height);
            }
            return resizedImage;
        }

        private void guna2TextBox2_TextChanged(object sender, EventArgs e)
        {

        }
    }


}
