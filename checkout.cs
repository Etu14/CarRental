using Guna.UI2.WinForms;
using MySql.Data.MySqlClient;
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
    public partial class checkout : Form
    {
        private DateTime selectedDate1;
        private DateTime selectedDate3;
        public checkout(DateTime startDate, DateTime endDate)
        {
            InitializeComponent();
            selectedDate1 = startDate;
            selectedDate3 = endDate;
        }

        private void checkout_Load(object sender, EventArgs e)
        {

        }
        public static int parentX,parenY;
        static string constr = ("Data Source=localhost;port=3306;username=root;password=");
        static MySqlConnection con = new MySqlConnection(constr);
        private void guna2Button1_Click(object sender, EventArgs e)
        {
            // string query = "INSERT INTO car_rent.rent_dates (start, end) VALUES (@startDate, @endDate)";
            // MySqlCommand cmd = new MySqlCommand(query, con);
            // cmd.Parameters.AddWithValue("@startDate", selectedDate1);
            // cmd.Parameters.AddWithValue("@endDate", selectedDate3);

            // con.Open();
            // cmd.ExecuteNonQuery();
            // MessageBox.Show(" " + selectedDate1 + ", "+selectedDate3+" ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            //con.Close();


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
                }
            

        }


        private void guna2Panel4_Paint(object sender, PaintEventArgs e)
        {

        }

        private void guna2HtmlLabel7_Click(object sender, EventArgs e)
        {

        }

        private void guna2PictureBox9_Click(object sender, EventArgs e)
        {

        }

        private void guna2HtmlLabel10_Click(object sender, EventArgs e)
        {

        }

        private void guna2PictureBox7_Click(object sender, EventArgs e)
        {

        }

        private void guna2HtmlLabel9_Click(object sender, EventArgs e)
        {

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

        }

        private void guna2Panel9_Paint(object sender, PaintEventArgs e)
        {

        }

        private void guna2ComboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void guna2HtmlLabel3_Click(object sender, EventArgs e)
        {

        }
    }
}
