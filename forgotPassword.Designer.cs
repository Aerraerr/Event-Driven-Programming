namespace EDP_GymwithGUI
{
    partial class forgotPassword
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
            textBox1 = new TextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            dateTimePicker1 = new DateTimePicker();
            label4 = new Label();
            textBox2 = new TextBox();
            label5 = new Label();
            label6 = new Label();
            textBox3 = new TextBox();
            button1 = new Button();
            SuspendLayout();
            // 
            // textBox1
            // 
            textBox1.Location = new Point(48, 136);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(320, 27);
            textBox1.TabIndex = 0;
            textBox1.TextChanged += textBox1_TextChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.DarkCyan;
            label1.Location = new Point(112, 24);
            label1.Name = "label1";
            label1.Size = new Size(217, 38);
            label1.TabIndex = 1;
            label1.Text = "Reset Password";
            label1.TextAlign = ContentAlignment.TopCenter;
            label1.Click += label1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.ForeColor = Color.DarkCyan;
            label2.Location = new Point(24, 64);
            label2.Name = "label2";
            label2.Size = new Size(382, 40);
            label2.TabIndex = 2;
            label2.Text = "To reset your password, please enter your email address \r\nand your birth date below.";
            label2.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.ForeColor = Color.DarkCyan;
            label3.Location = new Point(48, 112);
            label3.Name = "label3";
            label3.Size = new Size(188, 20);
            label3.TabIndex = 3;
            label3.Text = "Enter your registered email";
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.CalendarForeColor = Color.DarkCyan;
            dateTimePicker1.CalendarTitleForeColor = Color.DarkCyan;
            dateTimePicker1.Format = DateTimePickerFormat.Short;
            dateTimePicker1.Location = new Point(48, 304);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(320, 27);
            dateTimePicker1.TabIndex = 4;
            dateTimePicker1.Value = new DateTime(2025, 5, 18, 17, 43, 6, 0);
            dateTimePicker1.ValueChanged += dateTimePicker1_ValueChanged;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.ForeColor = Color.DarkCyan;
            label4.Location = new Point(48, 280);
            label4.Name = "label4";
            label4.Size = new Size(231, 20);
            label4.TabIndex = 5;
            label4.Text = "Enter you birthday for verification";
            label4.Click += label4_Click;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(48, 192);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(320, 27);
            textBox2.TabIndex = 6;
            textBox2.TextChanged += textBox2_TextChanged;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.ForeColor = Color.DarkCyan;
            label5.Location = new Point(48, 168);
            label5.Name = "label5";
            label5.Size = new Size(174, 20);
            label5.TabIndex = 7;
            label5.Text = "Enter your new password";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.ForeColor = Color.DarkCyan;
            label6.Location = new Point(50, 224);
            label6.Name = "label6";
            label6.Size = new Size(160, 20);
            label6.TabIndex = 9;
            label6.Text = "Confirm new password";
            // 
            // textBox3
            // 
            textBox3.Location = new Point(50, 248);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(320, 27);
            textBox3.TabIndex = 8;
            textBox3.TextChanged += textBox3_TextChanged;
            // 
            // button1
            // 
            button1.BackColor = Color.DarkCyan;
            button1.ForeColor = SystemColors.ButtonHighlight;
            button1.Location = new Point(48, 352);
            button1.Name = "button1";
            button1.Size = new Size(320, 40);
            button1.TabIndex = 10;
            button1.Text = "Reset Password";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // forgotPassword
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(421, 433);
            Controls.Add(button1);
            Controls.Add(label6);
            Controls.Add(textBox3);
            Controls.Add(label5);
            Controls.Add(textBox2);
            Controls.Add(label4);
            Controls.Add(dateTimePicker1);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(textBox1);
            Name = "forgotPassword";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Reset Password";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBox1;
        private Label label1;
        private Label label2;
        private Label label3;
        private DateTimePicker dateTimePicker1;
        private Label label4;
        private TextBox textBox2;
        private Label label5;
        private Label label6;
        private TextBox textBox3;
        private Button button1;
    }
}