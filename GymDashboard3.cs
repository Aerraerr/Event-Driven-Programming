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
    public partial class GymDashboard3 : Form
    {
        public GymDashboard3()
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
    }
}
