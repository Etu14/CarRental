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
        public Date()
        {
            InitializeComponent();
        }
        private void guna2CirclePictureBox1_Click(object sender, EventArgs e)
        {

        }



        private void guna2DateTimePicker2_ValueChanged(object sender, EventArgs e)
        {
            TimeSpan selectedTime2 = guna2DateTimePicker2.Value.TimeOfDay;
            TimeSpan selectedTime4 = guna2DateTimePicker4.Value.TimeOfDay;

            if (selectedTime2 >= selectedTime4 || selectedTime2.Add(TimeSpan.FromHours(1)) > selectedTime4)
            {

                guna2DateTimePicker4.Value = guna2DateTimePicker2.Value.AddHours(1);
            }
        }

        private void guna2DateTimePicker4_ValueChanged(object sender, EventArgs e)
        {
            TimeSpan selectedTime2 = guna2DateTimePicker2.Value.TimeOfDay;
            TimeSpan selectedTime4 = guna2DateTimePicker4.Value.TimeOfDay;

            if (selectedTime4 <= selectedTime2 || selectedTime4.Subtract(selectedTime2) < TimeSpan.FromHours(1))
            {

                guna2DateTimePicker2.Value = guna2DateTimePicker4.Value.AddHours(-1);
            }
        }
        private void guna2DateTimePicker1_ValueChanged_1(object sender, EventArgs e)
        {
            DateTime selectedDate1 = guna2DateTimePicker1.Value.Date;
            DateTime selectedDate3 = guna2DateTimePicker3.Value.Date;

            if (selectedDate1 >= selectedDate3 || selectedDate1.AddDays(1) > selectedDate3)
            {

                guna2DateTimePicker3.Value = guna2DateTimePicker1.Value.AddDays(1);
            }
        }

        private void guna2DateTimePicker3_ValueChanged(object sender, EventArgs e)
        {
            DateTime selectedDate1 = guna2DateTimePicker1.Value.Date;
            DateTime selectedDate3 = guna2DateTimePicker3.Value.Date;

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
            checkout win2 = new checkout(selectedDate1, selectedDate3);
            win2.Show();
        }

        private void guna2ComboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
 