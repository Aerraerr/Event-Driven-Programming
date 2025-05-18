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
    public partial class viewMember : Form
    {
        public viewMember(DataRow memberData)
        {
            InitializeComponent();

            // Populate fields with data from the DataRow
            textBox1.Text = memberData["first_name"] + " " + memberData["last_name"];
            textBox2.Text = Convert.ToDateTime(memberData["birth_date"]).ToString("yyyy-MM-dd");
            textBox3.Text = memberData["gender"].ToString();
            textBox4.Text = memberData["weight_kg"].ToString();
            textBox5.Text = memberData["height_cm"].ToString();
            textBox6.Text = memberData["membership_type"].ToString();
            textBox7.Text = Convert.ToDateTime(memberData["membership_start"]).ToString("yyyy-MM-dd");
            textBox8.Text = memberData["email"].ToString();
        }


        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            //show member name
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            //show birthday

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            //show gender
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {
            //show weight
        }

        private void viewMember_Load(object sender, EventArgs e)
        {

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {
            //show height
        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {
            //show membership type
        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void textBox8_TextChanged(object sender, EventArgs e)
        {
            //show email
        }

        private void textBox7_TextChanged(object sender, EventArgs e)
        {
            //show membership start
        }
    }
}
