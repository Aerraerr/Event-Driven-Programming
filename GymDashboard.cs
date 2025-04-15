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
    public partial class GymDashboard : Form
    {
        public GymDashboard()
        {
            InitializeComponent();
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
    }
}
