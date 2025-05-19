namespace EDP_GymwithGUI
{
    partial class GymDashboard
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
            components = new System.ComponentModel.Container();
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            panel1 = new Panel();
            button3 = new Button();
            button1 = new Button();
            button2 = new Button();
            dashboardbtn = new Button();
            pictureBox1 = new PictureBox();
            button4 = new Button();
            dataGridView1 = new DataGridView();
            label1 = new Label();
            linkLabel1 = new LinkLabel();
            textBox1 = new TextBox();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            textBox2 = new TextBox();
            label5 = new Label();
            label6 = new Label();
            textBox3 = new TextBox();
            textBox4 = new TextBox();
            textBox5 = new TextBox();
            label7 = new Label();
            timer1 = new System.Windows.Forms.Timer(components);
            label8 = new Label();
            textBox6 = new TextBox();
            timer2 = new System.Windows.Forms.Timer(components);
            textBox7 = new TextBox();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.DarkCyan;
            panel1.Controls.Add(button3);
            panel1.Controls.Add(button1);
            panel1.Controls.Add(button2);
            panel1.Controls.Add(dashboardbtn);
            panel1.Controls.Add(pictureBox1);
            panel1.Dock = DockStyle.Left;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(200, 753);
            panel1.TabIndex = 0;
            // 
            // button3
            // 
            button3.FlatAppearance.BorderSize = 0;
            button3.FlatStyle = FlatStyle.Flat;
            button3.ForeColor = Color.MintCream;
            button3.Location = new Point(0, 280);
            button3.Name = "button3";
            button3.Size = new Size(200, 56);
            button3.TabIndex = 3;
            button3.Text = "V I E W   M E M B E R";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // button1
            // 
            button1.FlatAppearance.BorderSize = 0;
            button1.FlatStyle = FlatStyle.Flat;
            button1.ForeColor = Color.MintCream;
            button1.Location = new Point(0, 216);
            button1.Name = "button1";
            button1.Size = new Size(200, 56);
            button1.TabIndex = 2;
            button1.Text = "T R A I N E R S";
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
            dashboardbtn.FlatStyle = FlatStyle.Flat;
            dashboardbtn.Font = new Font("Impact", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dashboardbtn.ForeColor = Color.MintCream;
            dashboardbtn.Location = new Point(0, 88);
            dashboardbtn.Name = "dashboardbtn";
            dashboardbtn.Size = new Size(200, 56);
            dashboardbtn.TabIndex = 0;
            dashboardbtn.Text = "D A S H B O A R D";
            dashboardbtn.UseVisualStyleBackColor = true;
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
            // button4
            // 
            button4.BackColor = Color.DarkCyan;
            button4.FlatAppearance.BorderSize = 0;
            button4.Font = new Font("Impact", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button4.ForeColor = SystemColors.Control;
            button4.Location = new Point(1152, 288);
            button4.Name = "button4";
            button4.Size = new Size(200, 56);
            button4.TabIndex = 10;
            button4.Text = "REGISTER MEMBER";
            button4.UseVisualStyleBackColor = false;
            button4.Click += button4_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.BackgroundColor = SystemColors.ControlLight;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = SystemColors.Control;
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dataGridViewCellStyle1.ForeColor = Color.DarkCyan;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.GridColor = SystemColors.ScrollBar;
            dataGridView1.Location = new Point(216, 408);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(1136, 336);
            dataGridView1.TabIndex = 1;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick_1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(208, 368);
            label1.Name = "label1";
            label1.Size = new Size(161, 28);
            label1.TabIndex = 2;
            label1.Text = "Overall Members";
            // 
            // linkLabel1
            // 
            linkLabel1.AutoSize = true;
            linkLabel1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            linkLabel1.LinkColor = Color.DarkCyan;
            linkLabel1.Location = new Point(1248, 368);
            linkLabel1.Name = "linkLabel1";
            linkLabel1.Size = new Size(104, 28);
            linkLabel1.TabIndex = 3;
            linkLabel1.TabStop = true;
            linkLabel1.Text = "Show all >";
            linkLabel1.LinkClicked += linkLabel1_LinkClicked;
            // 
            // textBox1
            // 
            textBox1.BackColor = SystemColors.Control;
            textBox1.BorderStyle = BorderStyle.None;
            textBox1.Font = new Font("Segoe UI", 100.200005F, FontStyle.Bold, GraphicsUnit.Point, 0);
            textBox1.ForeColor = Color.DarkCyan;
            textBox1.Location = new Point(232, 80);
            textBox1.Name = "textBox1";
            textBox1.ReadOnly = true;
            textBox1.Size = new Size(208, 223);
            textBox1.TabIndex = 4;
            textBox1.TextChanged += textBox1_TextChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 24F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(216, 16);
            label2.Name = "label2";
            label2.Size = new Size(272, 54);
            label2.TabIndex = 5;
            label2.Text = "DASHBOARD";
            label2.Click += label2_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(224, 80);
            label3.Name = "label3";
            label3.Size = new Size(145, 28);
            label3.TabIndex = 6;
            label3.Text = "Total Members:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.Location = new Point(488, 80);
            label4.Name = "label4";
            label4.Size = new Size(40, 28);
            label4.TabIndex = 7;
            label4.Text = "VIP";
            // 
            // textBox2
            // 
            textBox2.BackColor = SystemColors.Control;
            textBox2.BorderStyle = BorderStyle.None;
            textBox2.Font = new Font("Segoe UI", 30F, FontStyle.Bold, GraphicsUnit.Point, 0);
            textBox2.ForeColor = Color.DarkCyan;
            textBox2.Location = new Point(488, 104);
            textBox2.Name = "textBox2";
            textBox2.ReadOnly = true;
            textBox2.Size = new Size(112, 67);
            textBox2.TabIndex = 8;
            textBox2.TextAlign = HorizontalAlignment.Center;
            textBox2.TextChanged += textBox2_TextChanged;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label5.Location = new Point(624, 80);
            label5.Name = "label5";
            label5.Size = new Size(90, 28);
            label5.TabIndex = 9;
            label5.Text = "Premium";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label6.Location = new Point(752, 80);
            label6.Name = "label6";
            label6.Size = new Size(55, 28);
            label6.TabIndex = 10;
            label6.Text = "Basic";
            // 
            // textBox3
            // 
            textBox3.BackColor = SystemColors.Control;
            textBox3.BorderStyle = BorderStyle.None;
            textBox3.Font = new Font("Segoe UI", 30F, FontStyle.Bold, GraphicsUnit.Point, 0);
            textBox3.ForeColor = Color.DarkCyan;
            textBox3.Location = new Point(624, 104);
            textBox3.Name = "textBox3";
            textBox3.ReadOnly = true;
            textBox3.Size = new Size(104, 67);
            textBox3.TabIndex = 11;
            textBox3.TextAlign = HorizontalAlignment.Center;
            textBox3.TextChanged += textBox3_TextChanged;
            // 
            // textBox4
            // 
            textBox4.BackColor = SystemColors.Control;
            textBox4.BorderStyle = BorderStyle.None;
            textBox4.Font = new Font("Segoe UI", 30F, FontStyle.Bold, GraphicsUnit.Point, 0);
            textBox4.ForeColor = Color.DarkCyan;
            textBox4.Location = new Point(752, 104);
            textBox4.Name = "textBox4";
            textBox4.ReadOnly = true;
            textBox4.Size = new Size(104, 67);
            textBox4.TabIndex = 12;
            textBox4.TextAlign = HorizontalAlignment.Center;
            // 
            // textBox5
            // 
            textBox5.BackColor = SystemColors.Control;
            textBox5.BorderStyle = BorderStyle.None;
            textBox5.Font = new Font("Segoe UI Semibold", 25.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            textBox5.ForeColor = Color.DarkCyan;
            textBox5.Location = new Point(880, 104);
            textBox5.Name = "textBox5";
            textBox5.ReadOnly = true;
            textBox5.Size = new Size(464, 56);
            textBox5.TabIndex = 13;
            textBox5.TextChanged += textBox5_TextChanged;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label7.Location = new Point(880, 80);
            label7.Name = "label7";
            label7.Size = new Size(53, 28);
            label7.TabIndex = 14;
            label7.Text = "Date";
            label7.Click += label7_Click;
            // 
            // timer1
            // 
            timer1.Tick += timer1_Tick;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label8.Location = new Point(880, 184);
            label8.Name = "label8";
            label8.Size = new Size(54, 28);
            label8.TabIndex = 15;
            label8.Text = "Time";
            // 
            // textBox6
            // 
            textBox6.BackColor = SystemColors.Control;
            textBox6.BorderStyle = BorderStyle.None;
            textBox6.Font = new Font("Segoe UI Semibold", 25.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            textBox6.ForeColor = Color.DarkCyan;
            textBox6.Location = new Point(880, 208);
            textBox6.Name = "textBox6";
            textBox6.ReadOnly = true;
            textBox6.Size = new Size(464, 56);
            textBox6.TabIndex = 16;
            textBox6.TextChanged += textBox6_TextChanged;
            // 
            // timer2
            // 
            timer2.Tick += timer2_Tick;
            // 
            // textBox7
            // 
            textBox7.BackColor = SystemColors.Control;
            textBox7.BorderStyle = BorderStyle.None;
            textBox7.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            textBox7.ForeColor = Color.DarkCyan;
            textBox7.Location = new Point(1032, 24);
            textBox7.Name = "textBox7";
            textBox7.Size = new Size(312, 23);
            textBox7.TabIndex = 17;
            textBox7.TextAlign = HorizontalAlignment.Right;
            textBox7.TextChanged += textBox7_TextChanged;
            // 
            // GymDashboard
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1382, 753);
            Controls.Add(textBox7);
            Controls.Add(textBox6);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(textBox5);
            Controls.Add(button4);
            Controls.Add(textBox4);
            Controls.Add(textBox3);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(linkLabel1);
            Controls.Add(label1);
            Controls.Add(dataGridView1);
            Controls.Add(panel1);
            Controls.Add(textBox1);
            Controls.Add(textBox2);
            ForeColor = Color.DarkCyan;
            Name = "GymDashboard";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "GymDashboard";
            Load += GymDashboard_Load;
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private Button button3;
        private Button button1;
        private Button button2;
        private Button dashboardbtn;
        private PictureBox pictureBox1;
        private DataGridView dataGridView1;
        private Label label1;
        private LinkLabel linkLabel1;
        private Button button4;
        private TextBox textBox1;
        private Label label2;
        private Label label3;
        private Label label4;
        private TextBox textBox2;
        private Label label5;
        private Label label6;
        private TextBox textBox3;
        private TextBox textBox4;
        private TextBox textBox5;
        private Label label7;
        private System.Windows.Forms.Timer timer1;
        private Label label8;
        private TextBox textBox6;
        private System.Windows.Forms.Timer timer2;
        private TextBox textBox7;
    }
}