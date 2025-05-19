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

namespace EDP_GymwithGUI
{
    public partial class GymDashboard3 : Form
    {
        private string connectionString = "server=localhost;port=3306;database=gym;uid=root;pwd=root;";
        public GymDashboard3()
        {
            InitializeComponent();
            LoadTrainers();
        }
        private void LoadTrainers()
        {
            using (MySqlConnection con = new MySqlConnection(connectionString))
            {
                string query = @"
            SELECT 
                id AS ID,
                CONCAT(first_name, ' ', last_name) AS FullName,
                specialization AS Specialization,
                years_experience AS Experience,
                email AS Email
            FROM trainers
            WHERE gym_id = 1";

                MySqlDataAdapter adapter = new MySqlDataAdapter(query, con);
                DataTable trainerTable = new DataTable();
                adapter.Fill(trainerTable);

                dataGridView1.DataSource = trainerTable;
            }
        }


        private void dashboardbtn_Click(object sender, EventArgs e)
        {
            GymDashboard dashboard1 = new GymDashboard();
            dashboard1.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            GymDashboard2 dashboard2 = new GymDashboard2();
            dashboard2.Show();
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            GymDashboard4 dashboard4 = new GymDashboard4();
            dashboard4.Show();
            this.Hide();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Register register = new Register();
            register.Show();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            // show here the list of trainers 
        }
    }
}
