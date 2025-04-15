namespace EDP_GymwithGUI
{
    partial class GymDashboard2
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
            panel1 = new Panel();
            dashboardbtn = new Button();
            button3 = new Button();
            button1 = new Button();
            button2 = new Button();
            pictureBox1 = new PictureBox();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.DarkCyan;
            panel1.Controls.Add(dashboardbtn);
            panel1.Controls.Add(button3);
            panel1.Controls.Add(button1);
            panel1.Controls.Add(button2);
            panel1.Controls.Add(pictureBox1);
            panel1.Dock = DockStyle.Left;
            panel1.Location = new Point(0, 0);
            panel1.Margin = new Padding(4);
            panel1.Name = "panel1";
            panel1.Size = new Size(200, 753);
            panel1.TabIndex = 1;
            // 
            // dashboardbtn
            // 
            dashboardbtn.FlatAppearance.BorderSize = 0;
            dashboardbtn.FlatStyle = FlatStyle.Flat;
            dashboardbtn.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dashboardbtn.ForeColor = Color.MintCream;
            dashboardbtn.Location = new Point(0, 88);
            dashboardbtn.Margin = new Padding(4);
            dashboardbtn.Name = "dashboardbtn";
            dashboardbtn.Size = new Size(200, 56);
            dashboardbtn.TabIndex = 0;
            dashboardbtn.Text = "D A S H B O A R D";
            dashboardbtn.UseVisualStyleBackColor = true;
            dashboardbtn.Click += dashboardbtn_Click;
            // 
            // button3
            // 
            button3.FlatAppearance.BorderSize = 0;
            button3.FlatStyle = FlatStyle.Flat;
            button3.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button3.ForeColor = Color.MintCream;
            button3.Location = new Point(0, 280);
            button3.Margin = new Padding(4);
            button3.Name = "button3";
            button3.Size = new Size(200, 56);
            button3.TabIndex = 3;
            button3.Text = "P A N E L  4";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // button1
            // 
            button1.FlatAppearance.BorderSize = 0;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button1.ForeColor = Color.MintCream;
            button1.Location = new Point(0, 216);
            button1.Margin = new Padding(4);
            button1.Name = "button1";
            button1.Size = new Size(200, 56);
            button1.TabIndex = 2;
            button1.Text = "P A N E L  3";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.FlatAppearance.BorderColor = Color.White;
            button2.FlatStyle = FlatStyle.Flat;
            button2.Font = new Font("Impact", 11F);
            button2.ForeColor = Color.MintCream;
            button2.Location = new Point(0, 152);
            button2.Margin = new Padding(4);
            button2.Name = "button2";
            button2.Size = new Size(200, 56);
            button2.TabIndex = 1;
            button2.Text = "P A N E L  2";
            button2.UseVisualStyleBackColor = true;
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.Transparent;
            pictureBox1.BackgroundImage = Properties.Resources.Grey_and_White_Retro_Fitness_and_Gym_Emblem_Logo__2__removebg_preview;
            pictureBox1.BackgroundImageLayout = ImageLayout.Stretch;
            pictureBox1.Location = new Point(32, -16);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(136, 120);
            pictureBox1.TabIndex = 5;
            pictureBox1.TabStop = false;
            // 
            // GymDashboard2
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1182, 753);
            Controls.Add(panel1);
            Font = new Font("Impact", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Margin = new Padding(4);
            Name = "GymDashboard2";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "GymDashboard2";
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Button button3;
        private Button button1;
        private Button button2;
        private Button dashboardbtn;
        private PictureBox pictureBox1;
    }
}