using Guna.UI2.WinForms;
using Org.BouncyCastle.Crypto.Utilities;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.AccessControl;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CarRentalSystem
{
    public partial class main_page : Form
    {
        public main_page()
        {
            InitializeComponent();
        }

        private void main_page_Load(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void guna2CirclePictureBox1_Click(object sender, EventArgs e)
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

        }

        private void linkLabel3_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();
            loginPage win2 = new loginPage();
            win2.Show();
            this.Dispose();

        }

        private void guna2HScrollBar1_Scroll(object sender, ScrollEventArgs e)
        {

        }

        private void guna2PictureBox8_Click(object sender, EventArgs e)
        {

        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {

        }

        private void guna2TextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void guna2Panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void guna2Panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void guna2Panel6_Paint(object sender, PaintEventArgs e)
        {

        }

        private void guna2PictureBox15_Click(object sender, EventArgs e)
        {

        }

        private void guna2PictureBox10_Click(object sender, EventArgs e)
        {
            int id = 1;
            this.Hide();
            CarDetails win2 = new CarDetails(id);
            win2.Show();
            this.Dispose();
        }

        private void linkLabel5_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            
            this.Hide();
            string brand = null;
            carCatalog win2 = new carCatalog(brand);
            win2.Show();
            this.Dispose();
        }

        private void linkLabel4_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();
            brandCatalog win2 = new brandCatalog();
            win2.Show();
            this.Dispose();
        }

        private void linkLabel3_LinkClicked_1(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();
            loginPage win2 = new loginPage();
            win2.Show();
            this.Dispose();
        }

        private void guna2Panel4_Paint(object sender, PaintEventArgs e)
        {

        }

        private void linkLabel1_LinkClicked_1(object sender, LinkLabelLinkClickedEventArgs e)
        {

        }

        private void guna2PictureBox2_Click(object sender, EventArgs e)
        {
            string brand = "bugatti";
            this.Hide();
            carCatalog win2 = new carCatalog(brand);
            win2.Show();
            this.Dispose();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void guna2PictureBox11_Click(object sender, EventArgs e)
        {
            int id = 2;
            this.Hide();
            CarDetails win2 = new CarDetails(id);
            win2.Show();
            this.Dispose();
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void guna2PictureBox14_Click(object sender, EventArgs e)
        {
            int id = 6;
            this.Hide();
            CarDetails win2 = new CarDetails(id);
            win2.Show();
            this.Dispose();
        }

        private void guna2PictureBox1_Click(object sender, EventArgs e)
        {
            string brand = "alfa-romeo";
            this.Hide();
            carCatalog win2 = new carCatalog(brand);
            win2.Show();
            this.Dispose();
        }
    }
}
