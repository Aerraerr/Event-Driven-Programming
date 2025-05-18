namespace EDP_GymwithGUI
{
    partial class Login
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login));
            pictureBox1 = new PictureBox();
            label1 = new Label();
            forEmail = new TextBox();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            panel1 = new Panel();
            panel2 = new Panel();
            forPassword = new TextBox();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            linkLabel1 = new LinkLabel();
            linkLabel2 = new LinkLabel();
            linkLabel3 = new LinkLabel();
            loginbtn = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.Grey_and_White_Retro_Fitness_and_Gym_Emblem_Logo__1__removebg_preview;
            pictureBox1.Location = new Point(232, 3);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(204, 186);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 1;
            pictureBox1.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Impact", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.DarkCyan;
            label1.ImageAlign = ContentAlignment.TopCenter;
            label1.Location = new Point(280, 166);
            label1.Name = "label1";
            label1.Size = new Size(106, 37);
            label1.TabIndex = 2;
            label1.Text = "L O G I N";
            // 
            // forEmail
            // 
            forEmail.BackColor = SystemColors.Window;
            forEmail.BorderStyle = BorderStyle.None;
            forEmail.Font = new Font("Segoe UI", 13.2000008F, FontStyle.Regular, GraphicsUnit.Point, 0);
            forEmail.ForeColor = Color.DarkCyan;
            forEmail.Location = new Point(146, 258);
            forEmail.Name = "forEmail";
            forEmail.PlaceholderText = " Enter your email";
            forEmail.Size = new Size(386, 30);
            forEmail.TabIndex = 3;
            forEmail.TextChanged += forEmail_TextChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.DarkCyan;
            label2.Location = new Point(137, 229);
            label2.Name = "label2";
            label2.Size = new Size(126, 20);
            label2.TabIndex = 4;
            label2.Text = "Email / Username";
            label2.Click += label2_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.DarkCyan;
            label3.Location = new Point(136, 304);
            label3.Name = "label3";
            label3.Size = new Size(70, 20);
            label3.TabIndex = 6;
            label3.Text = "Password";
            label3.Click += label3_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.Transparent;
            label4.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.ForeColor = Color.DarkCyan;
            label4.Location = new Point(408, 376);
            label4.Name = "label4";
            label4.Size = new Size(0, 20);
            label4.TabIndex = 7;
            // 
            // panel1
            // 
            panel1.BackColor = Color.DarkCyan;
            panel1.BorderStyle = BorderStyle.FixedSingle;
            panel1.ForeColor = Color.MintCream;
            panel1.Location = new Point(144, 256);
            panel1.Name = "panel1";
            panel1.Size = new Size(390, 36);
            panel1.TabIndex = 8;
            panel1.Paint += panel1_Paint;
            // 
            // panel2
            // 
            panel2.BackColor = Color.DarkCyan;
            panel2.BorderStyle = BorderStyle.FixedSingle;
            panel2.ForeColor = Color.DarkCyan;
            panel2.Location = new Point(146, 328);
            panel2.Name = "panel2";
            panel2.Size = new Size(390, 36);
            panel2.TabIndex = 9;
            // 
            // forPassword
            // 
            forPassword.BackColor = SystemColors.Window;
            forPassword.BorderStyle = BorderStyle.None;
            forPassword.Font = new Font("Segoe UI", 13.2000008F, FontStyle.Regular, GraphicsUnit.Point, 0);
            forPassword.ForeColor = Color.DarkCyan;
            forPassword.Location = new Point(148, 330);
            forPassword.Name = "forPassword";
            forPassword.PlaceholderText = " Enter your password";
            forPassword.Size = new Size(386, 30);
            forPassword.TabIndex = 10;
            forPassword.TextChanged += forPassword_TextChanged;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = Color.Transparent;
            label5.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label5.ForeColor = Color.Black;
            label5.Location = new Point(272, 416);
            label5.Name = "label5";
            label5.Size = new Size(124, 20);
            label5.TabIndex = 11;
            label5.Text = "- Or sign in with -";
            label5.Click += label5_Click;
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
            label6.TabIndex = 12;
            label6.Text = resources.GetString("label6.Text");
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.BackColor = Color.Transparent;
            label7.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label7.ForeColor = Color.Black;
            label7.Location = new Point(200, 576);
            label7.Name = "label7";
            label7.Size = new Size(163, 20);
            label7.TabIndex = 13;
            label7.Text = "Don't have an account?";
            label7.Click += label7_Click;
            // 
            // linkLabel1
            // 
            linkLabel1.AutoSize = true;
            linkLabel1.LinkColor = Color.DarkCyan;
            linkLabel1.Location = new Point(368, 576);
            linkLabel1.Name = "linkLabel1";
            linkLabel1.Size = new Size(108, 20);
            linkLabel1.TabIndex = 14;
            linkLabel1.TabStop = true;
            linkLabel1.Text = "Create account";
            linkLabel1.TextAlign = ContentAlignment.TopCenter;
            linkLabel1.LinkClicked += linkLabel1_LinkClicked;
            // 
            // linkLabel2
            // 
            linkLabel2.AutoSize = true;
            linkLabel2.LinkColor = Color.DarkCyan;
            linkLabel2.Location = new Point(416, 368);
            linkLabel2.Name = "linkLabel2";
            linkLabel2.Size = new Size(127, 20);
            linkLabel2.TabIndex = 15;
            linkLabel2.TabStop = true;
            linkLabel2.Text = "Forgot password?";
            linkLabel2.TextAlign = ContentAlignment.TopCenter;
            linkLabel2.LinkClicked += linkLabel2_LinkClicked;
            // 
            // linkLabel3
            // 
            linkLabel3.AutoSize = true;
            linkLabel3.LinkBehavior = LinkBehavior.HoverUnderline;
            linkLabel3.LinkColor = Color.DarkGray;
            linkLabel3.Location = new Point(72, 24);
            linkLabel3.Name = "linkLabel3";
            linkLabel3.Size = new Size(60, 20);
            linkLabel3.TabIndex = 16;
            linkLabel3.TabStop = true;
            linkLabel3.Text = "< BACK";
            // 
            // loginbtn
            // 
            loginbtn.BackColor = Color.DarkCyan;
            loginbtn.ForeColor = Color.Transparent;
            loginbtn.Location = new Point(144, 504);
            loginbtn.Name = "loginbtn";
            loginbtn.Size = new Size(387, 40);
            loginbtn.TabIndex = 17;
            loginbtn.Text = "L O G I N";
            loginbtn.UseVisualStyleBackColor = false;
            loginbtn.Click += button1_Click;
            // 
            // Login
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(682, 653);
            Controls.Add(loginbtn);
            Controls.Add(linkLabel3);
            Controls.Add(linkLabel2);
            Controls.Add(linkLabel1);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(forPassword);
            Controls.Add(forEmail);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(pictureBox1);
            Controls.Add(panel1);
            Controls.Add(panel2);
            Name = "Login";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Login";
            Load += Login_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private PictureBox pictureBox1;
        private Label label1;
        private TextBox forEmail;
        private Label label2;
        private Label label3;
        private Label label4;
        private Panel panel1;
        private Panel panel2;
        private TextBox forPassword;
        private Label label5;
        private Label label6;
        private Label label7;
        private LinkLabel linkLabel1;
        private LinkLabel linkLabel2;
        private LinkLabel linkLabel3;
        private Button loginbtn;
    }
}