namespace EDP_GymwithGUI
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            pictureBox1 = new PictureBox();
            LoginBtn = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.Transparent;
            pictureBox1.BackgroundImage = Properties.Resources.Grey_and_White_Retro_Fitness_and_Gym_Emblem_Logo__1__removebg_preview;
            pictureBox1.BackgroundImageLayout = ImageLayout.Stretch;
            pictureBox1.Location = new Point(54, 12);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(480, 514);
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            // 
            // LoginBtn
            // 
            LoginBtn.BackColor = Color.DarkCyan;
            LoginBtn.FlatAppearance.BorderColor = Color.DarkCyan;
            LoginBtn.FlatAppearance.BorderSize = 5;
            LoginBtn.FlatStyle = FlatStyle.Flat;
            LoginBtn.Font = new Font("Impact", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            LoginBtn.ForeColor = SystemColors.ButtonHighlight;
            LoginBtn.Location = new Point(56, 568);
            LoginBtn.Name = "LoginBtn";
            LoginBtn.Size = new Size(479, 40);
            LoginBtn.TabIndex = 1;
            LoginBtn.Text = "Login";
            LoginBtn.UseVisualStyleBackColor = false;
            LoginBtn.Click += LoginBtn_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.LightGray;
            BackgroundImage = Properties.Resources.gymrat_removebg_preview;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(582, 653);
            Controls.Add(LoginBtn);
            Controls.Add(pictureBox1);
            DoubleBuffered = true;
            MaximizeBox = false;
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Palong-palo Fitness & Gym";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private PictureBox pictureBox1;
        private Button LoginBtn;
    }
}
