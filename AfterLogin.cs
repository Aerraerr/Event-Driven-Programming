using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace EDP_GymwithGUI
{
    public partial class AfterLogin : Form
    {
        private string userEmail;
        private string connectionString = "server=localhost;port=3306;database=gym;uid=root;pwd=root;";

        public AfterLogin(string email)
        {
            InitializeComponent();
            userEmail = email;

            LoadUserData();
            LoadRandomWorkout();
            LoadRandomTrainer();
        }

        private void LoadUserData()
        {
            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                try
                {
                    conn.Open();
                    string query = "SELECT first_name, last_name, weight_kg, height_cm, gender, membership_type FROM members WHERE email = @Email";

                    using (MySqlCommand cmd = new MySqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@Email", userEmail);
                        using (MySqlDataReader reader = cmd.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                // Concatenate first and last name
                                textBox1.Text = reader["first_name"].ToString() + " " + reader["last_name"].ToString();
                                textBox2.Text = reader["weight_kg"].ToString();
                                textBox3.Text = reader["height_cm"].ToString();
                                textBox4.Text = reader["gender"].ToString();
                                textBox5.Text = reader["membership_type"].ToString();

                                if (double.TryParse(reader["weight_kg"].ToString(), out double weightKg) &&
    double.TryParse(reader["height_cm"].ToString(), out double heightCm) &&
    heightCm > 0)
                                {
                                    double bmi = weightKg / Math.Pow(heightCm / 100.0, 2);
                                    textBox7.Text = bmi.ToString("0.00"); // rounded to 2 decimal places
                                }
                                else
                                {
                                    textBox7.Text = "Invalid data";
                                }
                            }
                            else
                            {
                                MessageBox.Show("User data not found.");
                            }
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error loading user data: " + ex.Message);
                }
            }
        }

        private void LoadRandomWorkout()
        {
            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                try
                {
                    conn.Open();
                    string query = "SELECT name, category, duration_minutes, reps FROM workouts ORDER BY RAND() LIMIT 6";

                    using (MySqlCommand cmd = new MySqlCommand(query, conn))
                    using (MySqlDataReader reader = cmd.ExecuteReader())
                    {
                        listView1.Items.Clear();

                        if (reader.HasRows)
                        {
                            while (reader.Read())
                            {
                                ListViewItem item = new ListViewItem(reader["name"].ToString());
                                item.SubItems.Add(reader["category"].ToString());
                                item.SubItems.Add(reader["duration_minutes"].ToString());
                                item.SubItems.Add(reader["reps"].ToString());
                                listView1.Items.Add(item);
                            }
                        }
                        else
                        {
                            ListViewItem item = new ListViewItem("No workout found.");
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



        private void LoadRandomTrainer()
        {
            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                try
                {
                    conn.Open();
                    string query = "SELECT first_name, last_name FROM trainers ORDER BY RAND() LIMIT 1";

                    using (MySqlCommand cmd = new MySqlCommand(query, conn))
                    using (MySqlDataReader reader = cmd.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            string firstName = reader["first_name"].ToString();
                            string lastName = reader["last_name"].ToString();
                            textBox6.Text = $"{firstName} {lastName}";
                        }
                        else
                        {
                            textBox6.Text = "No trainer found.";
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error loading trainer: " + ex.Message);
                }
            }
        }


        // These event handlers can be removed or kept for future features
        private void label1_Click(object sender, EventArgs e) { }
        private void textBox1_TextChanged(object sender, EventArgs e) { }
        private void textBox2_TextChanged(object sender, EventArgs e) { }
        private void textBox3_TextChanged(object sender, EventArgs e) { }
        private void textBox4_TextChanged(object sender, EventArgs e) { }
        private void textBox5_TextChanged(object sender, EventArgs e) { }
        private void textBox6_TextChanged(object sender, EventArgs e) { }
        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {
            listView1.View = View.Details;
            listView1.FullRowSelect = true;
            listView1.GridLines = true;

            listView1.Columns.Clear(); // Just in case

            listView1.Columns.Add("Workout Name", 150);
            listView1.Columns.Add("Category", 100);
            listView1.Columns.Add("Duration (min)", 100);
            listView1.Columns.Add("Reps", 80);

        }

        private void textBox7_TextChanged(object sender, EventArgs e)
        {

        }
    }
}