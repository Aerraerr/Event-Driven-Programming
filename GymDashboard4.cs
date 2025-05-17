using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EDP_GymwithGUI
{
    public partial class GymDashboard4 : Form
    {
        public GymDashboard4()
        {
            InitializeComponent();
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

        private void button1_Click(object sender, EventArgs e)
        {
            GymDashboard3 dashboard3 = new GymDashboard3();
            dashboard3.Show();
            this.Hide();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            Register register = new Register();
            register.Show();
        }
    }
}
