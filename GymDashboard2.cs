using System;
using System.Data;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace EDP_GymwithGUI
{
    public partial class GymDashboard2 : Form
    {
        private DataTable membersTable;

        private string connectionString = "server=localhost;port=3306;database=gym;uid=root;pwd=root;";

        public GymDashboard2()
        {
            InitializeComponent();
            LoadMembers();
        }

        private void LoadMembers()
        {
            using (MySqlConnection con = new MySqlConnection(connectionString))
            {
                string query = @"
SELECT 
    id AS ID,
    CONCAT(first_name, ' ', last_name) AS fullname,
    gender AS Gender,
    birth_date AS Birthday,
    weight_kg AS weight_kg,
    height_cm AS height_cm,
    membership_type AS Membership,
    membership_start AS Start
FROM members
WHERE gym_id = 1";

                MySqlDataAdapter adapter = new MySqlDataAdapter(query, con);
                membersTable = new DataTable();
                adapter.Fill(membersTable);
                dataGridView1.DataSource = membersTable;

                // Add View button column if not already added
                if (!dataGridView1.Columns.Contains("View"))
                {
                    DataGridViewButtonColumn btnView = new DataGridViewButtonColumn();
                    btnView.Name = "View";
                    btnView.HeaderText = "View";
                    btnView.Text = "View";
                    btnView.UseColumnTextForButtonValue = true;
                    dataGridView1.Columns.Add(btnView);
                }

                // Add Delete button column if not already added
                if (!dataGridView1.Columns.Contains("Delete"))
                {
                    DataGridViewButtonColumn btnDelete = new DataGridViewButtonColumn();
                    btnDelete.Name = "Delete";
                    btnDelete.HeaderText = "Delete";
                    btnDelete.Text = "Delete";
                    btnDelete.UseColumnTextForButtonValue = true;
                    dataGridView1.Columns.Add(btnDelete);
                }

                // Reorder button columns
                dataGridView1.Columns["View"].DisplayIndex = 8;
                dataGridView1.Columns["Delete"].DisplayIndex = 9;
            }
        }

        private void DeleteMember(int memberId)
        {
            using (MySqlConnection con = new MySqlConnection(connectionString))
            {
                string query = "DELETE FROM members WHERE id = @id";
                MySqlCommand cmd = new MySqlCommand(query, con);
                cmd.Parameters.AddWithValue("@id", memberId);

                con.Open();
                cmd.ExecuteNonQuery();
                con.Close();
            }
        }

        private void ViewMember(int memberId)
        {
            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                conn.Open();
                string query = "SELECT * FROM members WHERE id = @id";
                MySqlCommand cmd = new MySqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@id", memberId);

                MySqlDataAdapter adapter = new MySqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                adapter.Fill(dt);

                if (dt.Rows.Count > 0)
                {
                    viewMember viewForm = new viewMember(dt.Rows[0]);
                    viewForm.ShowDialog(); // Open form with member data
                }
                else
                {
                    MessageBox.Show("Member not found.");
                }
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;

            int id = Convert.ToInt32(dataGridView1.Rows[e.RowIndex].Cells["ID"].Value);

            if (dataGridView1.Columns[e.ColumnIndex].Name == "Delete")
            {
                var confirmResult = MessageBox.Show("Are you sure to delete this member?",
                                                    "Confirm Delete",
                                                    MessageBoxButtons.YesNo);
                if (confirmResult == DialogResult.Yes)
                {
                    DeleteMember(id);
                    LoadMembers(); // refresh grid
                }
            }
            else if (dataGridView1.Columns[e.ColumnIndex].Name == "View")
            {
                ViewMember(id);
                LoadMembers(); // optional refresh
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            if (membersTable == null) return;

            string filterText = textBox1.Text.Trim().Replace("'", "''");
            DataView dv = new DataView(membersTable);
            dv.RowFilter = $"fullname LIKE '%{filterText}%'";
            dataGridView1.DataSource = dv;
        }

        // Other navigation buttons
        private void dashboardbtn_Click(object sender, EventArgs e)
        {
            GymDashboard dashboard1 = new GymDashboard();
            dashboard1.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            GymDashboard3 dashboard3 = new GymDashboard3();
            dashboard3.Show();
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            GymDashboard4 dashboard4 = new GymDashboard4();
            dashboard4.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e) { }

        private void button4_Click(object sender, EventArgs e)
        {
            Register register = new Register();
            register.Show();
        }

        private void GymDashboard2_Load(object sender, EventArgs e) { }

        private void label2_Click(object sender, EventArgs e) { }
    }
}
