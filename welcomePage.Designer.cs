
using System;

namespace CarRentalSystem
{
    partial class welcomePage
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.guna2Button1 = new Guna.UI2.WinForms.Guna2Button();
            this.SuspendLayout();
            // 
            // guna2Button1
            // 
            this.guna2Button1.Animated = true;
            this.guna2Button1.BackColor = System.Drawing.Color.Transparent;
            this.guna2Button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.guna2Button1.BorderColor = System.Drawing.Color.Transparent;
            this.guna2Button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.guna2Button1.DisabledState.BorderColor = System.Drawing.Color.Transparent;
            this.guna2Button1.DisabledState.CustomBorderColor = System.Drawing.Color.Transparent;
            this.guna2Button1.DisabledState.FillColor = System.Drawing.Color.Transparent;
            this.guna2Button1.DisabledState.ForeColor = System.Drawing.Color.Transparent;
            this.guna2Button1.DisabledState.Image = global::CarRentalSystem.Properties.Resources.sport_car;
            this.guna2Button1.FillColor = System.Drawing.Color.Transparent;
            this.guna2Button1.FocusedColor = System.Drawing.Color.Transparent;
            this.guna2Button1.Font = new System.Drawing.Font("Microsoft YaHei", 20.25F, System.Drawing.FontStyle.Bold);
            this.guna2Button1.ForeColor = System.Drawing.Color.Transparent;
            this.guna2Button1.HoverState.BorderColor = System.Drawing.Color.Transparent;
            this.guna2Button1.HoverState.CustomBorderColor = System.Drawing.Color.Transparent;
            this.guna2Button1.HoverState.FillColor = System.Drawing.Color.Transparent;
            this.guna2Button1.HoverState.ForeColor = System.Drawing.Color.Transparent;
            this.guna2Button1.Image = global::CarRentalSystem.Properties.Resources.sport_car;
            this.guna2Button1.ImageSize = new System.Drawing.Size(200, 200);
            this.guna2Button1.Location = new System.Drawing.Point(444, 563);
            this.guna2Button1.Name = "guna2Button1";
            this.guna2Button1.PressedColor = System.Drawing.Color.Transparent;
            this.guna2Button1.PressedDepth = 0;
            this.guna2Button1.ShadowDecoration.Color = System.Drawing.Color.Transparent;
            this.guna2Button1.Size = new System.Drawing.Size(248, 137);
            this.guna2Button1.TabIndex = 2;
            this.guna2Button1.UseTransparentBackground = true;
            this.guna2Button1.Click += new System.EventHandler(this.guna2Button1_Click);
            // 
            // welcomePage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::CarRentalSystem.Properties.Resources.mainBg_11;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1065, 712);
            this.Controls.Add(this.guna2Button1);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "welcomePage";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion
        private Guna.UI2.WinForms.Guna2Button guna2Button1;
    }
}

