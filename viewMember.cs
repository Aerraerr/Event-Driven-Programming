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
        private string connectionString = "server=localhost;port=3306;database=gym;uid=root;pwd=root;";
        private int memberId; // Add this to your class-level variables

        public viewMember(DataRow memberData)
        {
            InitializeComponent();

            // Store the member ID
            memberId = Convert.ToInt32(memberData["id"]);

            // Populate fields
            textBox1.Text = memberData["first_name"] + " " + memberData["last_name"];
            textBox2.Text = Convert.ToDateTime(memberData["birth_date"]).ToString("yyyy-MM-dd");
            textBox3.Text = memberData["gender"].ToString();
            textBox4.Text = memberData["weight_kg"].ToString();
            textBox5.Text = memberData["height_cm"].ToString();
            textBox6.Text = memberData["membership_type"].ToString();
            textBox7.Text = Convert.ToDateTime(memberData["membership_start"]).ToString("yyyy-MM-dd");
            textBox8.Text = memberData["email"].ToString();
            textBox9.Text = memberData["expiration"].ToString();

            // Set initial values in ComboBox and DateTimePicker
            comboBox1.Text = memberData["membership_type"].ToString();
            dateTimePicker1.Value = Convert.ToDateTime(memberData["expiration"]);
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

        private void textBox9_TextChanged(object sender, EventArgs e)
        {
            //show expiration
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            //edit membership type
            DateTime startDate = DateTime.Today; // Or use the membership start date if needed

            switch (comboBox1.SelectedItem.ToString())
            {
                case "VIP":
                    dateTimePicker1.Value = startDate.AddMonths(5);
                    break;
                case "Premium":
                    dateTimePicker1.Value = startDate.AddMonths(1);
                    break;
                case "Basic":
                    dateTimePicker1.Value = startDate.AddDays(3);
                    break;
                default:
                    break;
            }
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            //extend expiration
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string newMembershipType = comboBox1.Text;
            DateTime newExpirationDate = dateTimePicker1.Value;

            using (MySql.Data.MySqlClient.MySqlConnection conn = new MySql.Data.MySqlClient.MySqlConnection(connectionString))
            {
                try
                {
                    conn.Open();

                    string query = "UPDATE members SET membership_type = @type, expiration = @expiration WHERE id = @id";

                    using (MySql.Data.MySqlClient.MySqlCommand cmd = new MySql.Data.MySqlClient.MySqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@type", newMembershipType);
                        cmd.Parameters.AddWithValue("@expiration", newExpirationDate.ToString("yyyy-MM-dd"));
                        cmd.Parameters.AddWithValue("@id", memberId);

                        int result = cmd.ExecuteNonQuery();

                        if (result > 0)
                        {
                            MessageBox.Show("Membership updated successfully!");
                            this.Hide();
                        }
                        else
                        {
                            MessageBox.Show("Update failed.");
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                }
            }
        }
    }
}
