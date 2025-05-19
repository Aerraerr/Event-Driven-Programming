using System;
using System.Data;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace EDP_GymwithGUI
{
    public partial class AfterLoginTrainer : Form
    {
        private string connectionString = "server=localhost;port=3306;database=gym;uid=root;pwd=root;";

        public AfterLoginTrainer()
        {
            InitializeComponent();
            InitializeListView(); // Set up columns
            LoadRandomMembers();  // Load members on form load
            LoadTrainerWorkouts(); // Load workouts 1-10
        }

        private void InitializeListView()
        {
            listView1.View = View.Details;
            listView1.FullRowSelect = true;
            listView1.GridLines = true;

            listView1.Columns.Clear();
            listView1.Columns.Add("Workout Name", 150);
            listView1.Columns.Add("Category", 100);
            listView1.Columns.Add("Duration (min)", 100);
            listView1.Columns.Add("Reps", 80);
        }

        private void LoadRandomMembers()
        {
            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                try
                {
                    conn.Open();
                    string query = "SELECT first_name, last_name FROM members ORDER BY RAND() LIMIT 5";

                    MySqlDataAdapter adapter = new MySqlDataAdapter(query, conn);
                    DataTable table = new DataTable();
                    adapter.Fill(table);

                    dataGridView1.DataSource = table;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error loading members: " + ex.Message);
                }
            }
        }

        private void LoadTrainerWorkouts()
        {
            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                try
                {
                    conn.Open();
                    string query = "SELECT name, category, duration_minutes, reps FROM workouts WHERE id BETWEEN 1 AND 10";

                    using (MySqlCommand cmd = new MySqlCommand(query, conn))
                    using (MySqlDataReader reader = cmd.ExecuteReader())
                    {
                        listView1.Items.Clear();

                        while (reader.Read())
                        {
                            ListViewItem item = new ListViewItem(reader["name"].ToString());
                            item.SubItems.Add(reader["category"].ToString());
                            item.SubItems.Add(reader["duration_minutes"].ToString());
                            item.SubItems.Add(reader["reps"].ToString());
                            listView1.Items.Add(item);
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error loading workouts: " + ex.Message);
                }
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            // Optional: You can call LoadRandomMembers() again if you want refresh-on-click
            LoadRandomMembers();
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Optional: You can call LoadTrainerWorkouts() if needed
        }
    }
}
