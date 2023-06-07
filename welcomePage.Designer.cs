
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
            this.LetsGo = new Guna.UI2.WinForms.Guna2Button();
            this.SuspendLayout();
            // 
            // LetsGo
            // 
            this.LetsGo.Animated = true;
            this.LetsGo.AnimatedGIF = true;
            this.LetsGo.AutoRoundedCorners = true;
            this.LetsGo.BackColor = System.Drawing.Color.Transparent;
            this.LetsGo.BorderColor = System.Drawing.Color.Transparent;
            this.LetsGo.BorderRadius = 26;
            this.LetsGo.BorderStyle = System.Drawing.Drawing2D.DashStyle.Dash;
            this.LetsGo.BorderThickness = 2;
            this.LetsGo.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.LetsGo.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.LetsGo.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.LetsGo.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.LetsGo.FillColor = System.Drawing.Color.Red;
            this.LetsGo.Font = new System.Drawing.Font("Verdana", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LetsGo.ForeColor = System.Drawing.Color.White;
            this.LetsGo.Location = new System.Drawing.Point(344, 618);
            this.LetsGo.Name = "LetsGo";
            this.LetsGo.Size = new System.Drawing.Size(411, 55);
            this.LetsGo.TabIndex = 2;
            this.LetsGo.Text = "Let´s Go";
            this.LetsGo.Click += new System.EventHandler(this.guna2Button1_Click);
            // 
            // welcomePage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::CarRentalSystem.Properties.Resources.mainBg_1;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1065, 712);
            this.Controls.Add(this.LetsGo);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "welcomePage";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion
        private Guna.UI2.WinForms.Guna2Button LetsGo;
    }
}

