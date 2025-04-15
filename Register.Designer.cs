namespace EDP_GymwithGUI
{
    partial class Register
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Register));
            linkLabel3 = new LinkLabel();
            label4 = new Label();
            pictureBox1 = new PictureBox();
            linkLabel1 = new LinkLabel();
            label7 = new Label();
            label6 = new Label();
            button1 = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // linkLabel3
            // 
            linkLabel3.AutoSize = true;
            linkLabel3.LinkBehavior = LinkBehavior.HoverUnderline;
            linkLabel3.LinkColor = Color.DarkGray;
            linkLabel3.Location = new Point(78, 21);
            linkLabel3.Name = "linkLabel3";
            linkLabel3.Size = new Size(60, 20);
            linkLabel3.TabIndex = 20;
            linkLabel3.TabStop = true;
            linkLabel3.Text = "< BACK";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.Transparent;
            label4.Font = new Font("Impact", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.ForeColor = Color.Azure;
            label4.ImageAlign = ContentAlignment.TopCenter;
            label4.Location = new Point(200, 168);
            label4.Name = "label4";
            label4.Size = new Size(284, 37);
            label4.TabIndex = 19;
            label4.Text = "C R E A T E   A C C O U N T";
            label4.Click += label4_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.Transparent;
            pictureBox1.Image = Properties.Resources.Grey_and_White_Retro_Fitness_and_Gym_Emblem_Logo__1__removebg_preview;
            pictureBox1.Location = new Point(232, 0);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(204, 186);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 18;
            pictureBox1.TabStop = false;
            // 
            // linkLabel1
            // 
            linkLabel1.AutoSize = true;
            linkLabel1.LinkColor = Color.White;
            linkLabel1.Location = new Point(400, 576);
            linkLabel1.Name = "linkLabel1";
            linkLabel1.Size = new Size(46, 20);
            linkLabel1.TabIndex = 23;
            linkLabel1.TabStop = true;
            linkLabel1.Text = "Login";
            linkLabel1.TextAlign = ContentAlignment.TopCenter;
            linkLabel1.LinkClicked += linkLabel1_LinkClicked;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.BackColor = Color.Transparent;
            label7.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label7.ForeColor = Color.FromArgb(224, 224, 224);
            label7.Location = new Point(232, 576);
            label7.Name = "label7";
            label7.Size = new Size(178, 20);
            label7.TabIndex = 22;
            label7.Text = "Already have an account?";
            label7.Click += label7_Click;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.BackColor = Color.Gainsboro;
            label6.Font = new Font("Segoe UI", 1.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label6.ForeColor = Color.LightGray;
            label6.Location = new Point(152, 560);
            label6.Name = "label6";
            label6.Size = new Size(378, 3);
            label6.TabIndex = 21;
            label6.Text = resources.GetString("label6.Text");
            // 
            // button1
            // 
            button1.Location = new Point(144, 520);
            button1.Name = "button1";
            button1.Size = new Size(390, 29);
            button1.TabIndex = 24;
            button1.Text = "C R E A T E    A C C O U N T";
            button1.UseVisualStyleBackColor = true;
            // 
            // Register
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.DarkCyan;
            ClientSize = new Size(682, 653);
            Controls.Add(button1);
            Controls.Add(linkLabel1);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(linkLabel3);
            Controls.Add(label4);
            Controls.Add(pictureBox1);
            Name = "Register";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Register";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private LinkLabel linkLabel3;
        private Label label4;
        private PictureBox pictureBox1;
        private LinkLabel linkLabel1;
        private Label label7;
        private Label label6;
        private Button button1;
    }
}