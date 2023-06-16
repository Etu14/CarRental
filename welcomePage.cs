using CarRentalSystem;
using Guna.UI2.WinForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;





namespace CarRentalSystem
{
    public partial class welcomePage : Form
    {
        private System.Windows.Forms.Timer animationTimer;
        private const int AnimationInterval = 40; // Adjust this value for smoother animation
        private const int DistancePerTick = 100; // Adjust this value for smoother animation
        public welcomePage()
        {
            InitializeComponent();

            // Initialize the timer
            animationTimer = new System.Windows.Forms.Timer();
            animationTimer.Interval = AnimationInterval;
            animationTimer.Tick += animationTimer_Tick;
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            // Start the animation timer
            animationTimer.Enabled = true;
            guna2Button1.Enabled = false;
        }

        private void animationTimer_Tick(object sender, EventArgs e)
        {
            guna2Button1.Left += DistancePerTick;

            // Check if the button has moved far enough
            if (guna2Button1.Location.X >= Width)
            {
                // Stop the timer
                animationTimer.Enabled = false;

                // Hide Form1
                Hide();
                main_page win2 = new main_page();
                win2.Show();
            }
        }
        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
    }

}
