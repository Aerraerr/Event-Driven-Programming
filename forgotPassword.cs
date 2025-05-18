using System;
using System.Data;
using System.Text;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using System.Security.Cryptography;

namespace EDP_GymwithGUI
{
    public partial class forgotPassword : Form
    {
        private string connectionString = "server=localhost;port=3306;database=gym;uid=root;pwd=root;";

        public forgotPassword()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e) { }
        private void textBox2_TextChanged(object sender, EventArgs e) { }
        private void textBox3_TextChanged(object sender, EventArgs e) { }
        private void dateTimePicker1_ValueChanged(object sender, EventArgs e) { }
        private void label4_Click(object sender, EventArgs e) { }

        private void button1_Click(object sender, EventArgs e)
        {
            string email = textBox1.Text.Trim();
            string newPassword = textBox2.Text;
            string confirmPassword = textBox3.Text;
            string birthDate = dateTimePicker1.Value.ToString("yyyy-MM-dd");

            if (string.IsNullOrWhiteSpace(email) || string.IsNullOrWhiteSpace(newPassword) || string.IsNullOrWhiteSpace(confirmPassword))
            {
                MessageBox.Show("Please fill in all fields.");
                return;
            }

            if (newPassword != confirmPassword)
            {
                MessageBox.Show("Passwords do not match!");
                return;
            }

            using (MySqlConnection con = new MySqlConnection(connectionString))
            {
                con.Open();

                string checkQuery = "SELECT COUNT(*) FROM members WHERE email = @Email AND birth_date = @BirthDate";
                MySqlCommand checkCmd = new MySqlCommand(checkQuery, con);
                checkCmd.Parameters.AddWithValue("@Email", email);
                checkCmd.Parameters.AddWithValue("@BirthDate", birthDate);

                int exists = Convert.ToInt32(checkCmd.ExecuteScalar());

                if (exists == 1)
                {
                    string hashedPassword = HashPassword(newPassword);
                    string updateQuery = "UPDATE members SET password = @Password WHERE email = @Email AND birth_date = @BirthDate";
                    MySqlCommand updateCmd = new MySqlCommand(updateQuery, con);
                    updateCmd.Parameters.AddWithValue("@Password", hashedPassword);
                    updateCmd.Parameters.AddWithValue("@Email", email);
                    updateCmd.Parameters.AddWithValue("@BirthDate", birthDate);

                    updateCmd.ExecuteNonQuery();
                    MessageBox.Show("Password reset successful!");
                    this.Close(); // Optionally close the form after success
                }
                else
                {
                    MessageBox.Show("Email and birthday do not match any account.");
                }

                con.Close();
            }
        }

        private string HashPassword(string password)
        {
            using (SHA256 sha256 = SHA256.Create())
            {
                byte[] bytes = sha256.ComputeHash(Encoding.UTF8.GetBytes(password));
                StringBuilder builder = new StringBuilder();
                foreach (byte b in bytes)
                    builder.Append(b.ToString("x2"));
                return builder.ToString();
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
