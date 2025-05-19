namespace EDP_GymwithGUI
{
    partial class AfterLoginTrainer
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
            label2 = new Label();
            dataGridView1 = new DataGridView();
            label1 = new Label();
            label3 = new Label();
            listView1 = new ListView();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.DarkCyan;
            label2.Location = new Point(56, 8);
            label2.Name = "label2";
            label2.Size = new Size(154, 38);
            label2.TabIndex = 3;
            label2.Text = "Hi! Trainer";
            label2.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // dataGridView1
            // 
            dataGridView1.BackgroundColor = SystemColors.Window;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.GridColor = SystemColors.Window;
            dataGridView1.Location = new Point(56, 120);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(304, 304);
            dataGridView1.TabIndex = 4;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            label1.ForeColor = Color.DarkCyan;
            label1.Location = new Point(56, 88);
            label1.Name = "label1";
            label1.Size = new Size(121, 28);
            label1.TabIndex = 6;
            label1.Text = "Student list";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            label3.ForeColor = Color.DarkCyan;
            label3.Location = new Point(408, 88);
            label3.Name = "label3";
            label3.Size = new Size(129, 28);
            label3.TabIndex = 7;
            label3.Text = "Workout list";
            label3.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // listView1
            // 
            listView1.Location = new Point(408, 120);
            listView1.Name = "listView1";
            listView1.Size = new Size(320, 304);
            listView1.TabIndex = 8;
            listView1.UseCompatibleStateImageBehavior = false;
            listView1.SelectedIndexChanged += listView1_SelectedIndexChanged;
            // 
            // AfterLoginTrainer
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(771, 450);
            Controls.Add(listView1);
            Controls.Add(label3);
            Controls.Add(label1);
            Controls.Add(dataGridView1);
            Controls.Add(label2);
            Name = "AfterLoginTrainer";
            Text = "Trainer";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label2;
        private DataGridView dataGridView1;
        private Label label1;
        private Label label3;
        private ListView listView1;
    }
}