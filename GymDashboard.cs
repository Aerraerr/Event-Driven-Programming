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
using System.Data.SqlClient;
using Mysqlx.Crud;


namespace EDP_GymwithGUI
{
    public partial class GymDashboard : Form
    {
        private string connectionString = "server=localhost;port=3306;database=gym;uid=root;pwd=root;";
        public GymDashboard()
        {
            InitializeComponent();
            LoadMembers();
            CountTotalMembers();
            CountVIPMembers();
            CountPremiumMembers();
            CountBasicMembers();
            timer1.Start();
            timer2.Start();
            showBranch();
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
            WHERE gym_id = 1
            LIMIT 10";

                MySqlDataAdapter adapter = new MySqlDataAdapter(query, con);
                DataTable dt = new DataTable();
                adapter.Fill(dt);
                dataGridView1.DataSource = dt;
            }
        }
        private void CountTotalMembers()
        {
            using (MySqlConnection con = new MySqlConnection(connectionString))
            {
                string query = "SELECT COUNT(*) FROM members WHERE gym_id = 1";
                MySqlCommand cmd = new MySqlCommand(query, con);
                con.Open();
                object result = cmd.ExecuteScalar();
                textBox1.Text = result.ToString(); // Display count in textBox1
            }
        }
        private void CountVIPMembers()
        {
            using (MySqlConnection con = new MySqlConnection(connectionString))
            {
                string query = "SELECT COUNT(*) FROM members WHERE gym_id = 1 AND membership_type = 'VIP'";
                MySqlCommand cmd = new MySqlCommand(query, con);
                con.Open();
                object result = cmd.ExecuteScalar();
                textBox2.Text = result.ToString(); // Show VIP count in textBox2
            }
        }
        private void CountPremiumMembers()
        {
            using (MySqlConnection con = new MySqlConnection(connectionString))
            {
                string query = "SELECT COUNT(*) FROM members WHERE gym_id = 1 AND membership_type = 'Premium'";
                MySqlCommand cmd = new MySqlCommand(query, con);
                con.Open();
                object result = cmd.ExecuteScalar();
                textBox3.Text = result.ToString(); // Show VIP count in textBox2
            }
        }
        private void CountBasicMembers()
        {
            using (MySqlConnection con = new MySqlConnection(connectionString))
            {
                string query = "SELECT COUNT(*) FROM members WHERE gym_id = 1 AND membership_type = 'Basic'";
                MySqlCommand cmd = new MySqlCommand(query, con);
                con.Open();
                object result = cmd.ExecuteScalar();
                textBox4.Text = result.ToString(); // Show VIP count in textBox2
            }
        }
        private void showBranch()
        {
            using (MySqlConnection con = new MySqlConnection(connectionString))
            {
                string query = "SELECT location FROM gymbranch WHERE id = 1";
                MySqlCommand cmd = new MySqlCommand(query, con);
                con.Open();
                object result = cmd.ExecuteScalar();

                if (result != null)
                {
                    textBox7.Text = result.ToString() + " Branch";
                }
                else
                {
                    textBox7.Text = "Unknown branch";
                }
            }
        }


        private void toolStripComboBox1_Click(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void gYMBRNAHCToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void toolStripContainer1_TopToolStripPanel_Click(object sender, EventArgs e)
        {

        }

        private void GymDashboard_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            GymDashboard2 dashboard2 = new GymDashboard2();
            dashboard2.Show();
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

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridView1_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            textBox5.Text = DateTime.Now.ToString("dddd, MMMM dd yyyy ");
        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            Register register = new Register();
            register.Show();
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            textBox6.Text = DateTime.Now.ToString("hh:mm:ss tt");
        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox7_TextChanged(object sender, EventArgs e)
        {

        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            GymDashboard2 dashboard2 = new GymDashboard2();
            dashboard2.Show();
            this.Hide();
        }
    }
}
