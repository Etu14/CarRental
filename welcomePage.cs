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
        private const int AnimationInterval = 40; 
        private const int DistancePerTick = 100; 
        public welcomePage()
        {
            InitializeComponent();

            animationTimer = new System.Windows.Forms.Timer();
            animationTimer.Interval = AnimationInterval;
            animationTimer.Tick += animationTimer_Tick;
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            animationTimer.Enabled = true;
            guna2Button1.Enabled = false;
        }

        private void animationTimer_Tick(object sender, EventArgs e)
        {
            guna2Button1.Left += DistancePerTick;

            if (guna2Button1.Location.X >= Width)
            {
                animationTimer.Enabled = false;

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
