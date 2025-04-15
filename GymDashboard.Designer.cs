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
            panel1 = new Panel();
            button3 = new Button();
            button1 = new Button();
            button2 = new Button();
            dashboardbtn = new Button();
            pictureBox1 = new PictureBox();
            dataGridView1 = new DataGridView();
            id = new DataGridViewTextBoxColumn();
            fullname = new DataGridViewTextBoxColumn();
            Gender = new DataGridViewTextBoxColumn();
            Birthday = new DataGridViewTextBoxColumn();
            weight_kg = new DataGridViewTextBoxColumn();
            height_cm = new DataGridViewTextBoxColumn();
            Membership = new DataGridViewTextBoxColumn();
            label1 = new Label();
            linkLabel1 = new LinkLabel();
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
            button3.Text = "P A N E L  4";
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
            button1.Text = "P A N E L  3";
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
            button2.Text = "P A N E L  2";
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
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { id, fullname, Gender, Birthday, weight_kg, height_cm, Membership });
            dataGridView1.Location = new Point(216, 408);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(952, 336);
            dataGridView1.TabIndex = 1;
            // 
            // id
            // 
            id.HeaderText = "ID";
            id.MinimumWidth = 6;
            id.Name = "id";
            id.Width = 125;
            // 
            // fullname
            // 
            fullname.HeaderText = "FullName";
            fullname.MinimumWidth = 6;
            fullname.Name = "fullname";
            fullname.Width = 125;
            // 
            // Gender
            // 
            Gender.HeaderText = "Gender";
            Gender.MinimumWidth = 6;
            Gender.Name = "Gender";
            Gender.Width = 125;
            // 
            // Birthday
            // 
            Birthday.HeaderText = "Birthday";
            Birthday.MinimumWidth = 6;
            Birthday.Name = "Birthday";
            Birthday.Width = 125;
            // 
            // weight_kg
            // 
            weight_kg.HeaderText = "W-kg";
            weight_kg.MinimumWidth = 6;
            weight_kg.Name = "weight_kg";
            weight_kg.Width = 125;
            // 
            // height_cm
            // 
            height_cm.HeaderText = "H-cm";
            height_cm.MinimumWidth = 6;
            height_cm.Name = "height_cm";
            height_cm.Width = 125;
            // 
            // Membership
            // 
            Membership.HeaderText = "Membership";
            Membership.MinimumWidth = 6;
            Membership.Name = "Membership";
            Membership.Width = 125;
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
            linkLabel1.Location = new Point(1056, 368);
            linkLabel1.Name = "linkLabel1";
            linkLabel1.Size = new Size(104, 28);
            linkLabel1.TabIndex = 3;
            linkLabel1.TabStop = true;
            linkLabel1.Text = "Show all >";
            // 
            // GymDashboard
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1182, 753);
            Controls.Add(linkLabel1);
            Controls.Add(label1);
            Controls.Add(dataGridView1);
            Controls.Add(panel1);
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
        private DataGridViewTextBoxColumn id;
        private DataGridViewTextBoxColumn fullname;
        private DataGridViewTextBoxColumn Gender;
        private DataGridViewTextBoxColumn Birthday;
        private DataGridViewTextBoxColumn weight_kg;
        private DataGridViewTextBoxColumn height_cm;
        private DataGridViewTextBoxColumn Membership;
        private Label label1;
        private LinkLabel linkLabel1;
    }
}