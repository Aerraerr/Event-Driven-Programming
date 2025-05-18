namespace EDP_GymwithGUI
{
    partial class GymDashboard4
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
            button4 = new Button();
            button3 = new Button();
            button1 = new Button();
            button2 = new Button();
            dashboardbtn = new Button();
            pictureBox1 = new PictureBox();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.DarkCyan;
            panel1.Controls.Add(button4);
            panel1.Controls.Add(button3);
            panel1.Controls.Add(button1);
            panel1.Controls.Add(button2);
            panel1.Controls.Add(dashboardbtn);
            panel1.Controls.Add(pictureBox1);
            panel1.Dock = DockStyle.Left;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(200, 753);
            panel1.TabIndex = 1;
            // 
            // button4
            // 
            button4.FlatAppearance.BorderSize = 0;
            button4.FlatStyle = FlatStyle.Flat;
            button4.Font = new Font("Impact", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button4.ForeColor = Color.MintCream;
            button4.Location = new Point(0, 464);
            button4.Name = "button4";
            button4.Size = new Size(200, 56);
            button4.TabIndex = 10;
            button4.Text = "REGISTER MEMBER";
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click;
            // 
            // button3
            // 
            button3.FlatStyle = FlatStyle.Flat;
            button3.Font = new Font("Impact", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button3.ForeColor = Color.MintCream;
            button3.Location = new Point(0, 280);
            button3.Name = "button3";
            button3.Size = new Size(200, 56);
            button3.TabIndex = 3;
            button3.Text = "V I E W    M E M B E R";
            button3.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            button1.FlatAppearance.BorderSize = 0;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button1.ForeColor = Color.MintCream;
            button1.Location = new Point(0, 216);
            button1.Name = "button1";
            button1.Size = new Size(200, 56);
            button1.TabIndex = 2;
            button1.Text = "T R A N S A C T I O N S";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.FlatAppearance.BorderSize = 0;
            button2.FlatStyle = FlatStyle.Flat;
            button2.ForeColor = Color.MintCream;
            button2.Location = new Point(0, 152);
            button2.Name = "button2";
            button2.Size = new Size(200, 56);
            button2.TabIndex = 1;
            button2.Text = "M E M B E R S";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // dashboardbtn
            // 
            dashboardbtn.FlatAppearance.BorderSize = 0;
            dashboardbtn.FlatStyle = FlatStyle.Flat;
            dashboardbtn.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dashboardbtn.ForeColor = Color.MintCream;
            dashboardbtn.Location = new Point(0, 88);
            dashboardbtn.Name = "dashboardbtn";
            dashboardbtn.Size = new Size(200, 56);
            dashboardbtn.TabIndex = 0;
            dashboardbtn.Text = "D A S H B O A R D";
            dashboardbtn.UseVisualStyleBackColor = true;
            dashboardbtn.Click += dashboardbtn_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.Transparent;
            pictureBox1.BackgroundImage = Properties.Resources.Grey_and_White_Retro_Fitness_and_Gym_Emblem_Logo__2__removebg_preview;
            pictureBox1.BackgroundImageLayout = ImageLayout.Stretch;
            pictureBox1.Location = new Point(32, -16);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(136, 120);
            pictureBox1.TabIndex = 4;
            pictureBox1.TabStop = false;
            // 
            // GymDashboard4
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1382, 753);
            Controls.Add(panel1);
            Name = "GymDashboard4";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "GymDashboard4";
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
        private Button button4;
    }
}