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
    public partial class Date : Form
    {

        private DateTime selectedDate1;
        private DateTime selectedDate3;
        private string location;
        private int carId;
        public Date(int CarId)
        {
            this.carId = CarId;
            InitializeComponent();
        }
        private void guna2CirclePictureBox1_Click(object sender, EventArgs e)
        {

        }

        public void guna2DateTimePicker1_ValueChanged_1(object sender, EventArgs e)
        {
            selectedDate1 = guna2DateTimePicker1.Value.Date;
            selectedDate3 = guna2DateTimePicker3.Value.Date;

            if (selectedDate1 >= selectedDate3 || selectedDate1.AddDays(1) > selectedDate3)
            {

                guna2DateTimePicker3.Value = guna2DateTimePicker1.Value.AddDays(1);
            }
        }

        private void guna2DateTimePicker3_ValueChanged(object sender, EventArgs e)
        {
            selectedDate1 = guna2DateTimePicker1.Value.Date;
            selectedDate3 = guna2DateTimePicker3.Value.Date;

            if (selectedDate3 <= selectedDate1 || selectedDate3.Subtract(selectedDate1).Days < 1)
            {

                guna2DateTimePicker1.Value = guna2DateTimePicker3.Value.AddDays(-1);
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void LetsGo_Click(object sender, EventArgs e)
        {
            this.Hide();
            checkout win2 = new checkout(selectedDate1, selectedDate3, location, carId);
            win2.Show();
            this.Dispose();
        }

        private void guna2ComboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            Guna.UI2.WinForms.Guna2ComboBox comboBox = (Guna.UI2.WinForms.Guna2ComboBox)sender;

            if (comboBox.SelectedItem != null)
            {
                string selectedValue = comboBox.SelectedItem.ToString();
                location = selectedValue; // Assign the selected value to the location variable
            }
        }

        private void linkLabel3_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();
            userProfile win2 = new userProfile();
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

        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {   
            string brand = "null";
            this.Hide();
            carCatalog win2 = new carCatalog(brand);
            win2.Show();
            this.Dispose();
        }

        private void guna2Panel4_Paint(object sender, PaintEventArgs e)
        {

        }

        private void guna2ToggleSwitch1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void guna2Panel2_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
 