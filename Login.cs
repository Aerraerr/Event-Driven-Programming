using System;
using MySql.Data.MySqlClient;
using System.Security.Cryptography;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace EDP_GymwithGUI
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }
        private string ComputeSha256Hash(string rawData)
        {
            using (SHA256 sha256Hash = SHA256.Create())
            {
                byte[] bytes = sha256Hash.ComputeHash(Encoding.UTF8.GetBytes(rawData));
                StringBuilder builder = new StringBuilder();
                for (int i = 0; i < bytes.Length; i++)
                {
                    builder.Append(bytes[i].ToString("x2"));
                }
                return builder.ToString();
            }
        }

        private void Login_Load(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            panel1.BackColor = Color.DarkCyan;
        }

        private void forPassword_TextChanged(object sender, EventArgs e)
        {
            forPassword.UseSystemPasswordChar = true;

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            MessageBox.Show("Please register or consult the gym owner or admin", "Notice", MessageBoxButtons.OK, MessageBoxIcon.Information);
            //Register register = new Register();
            //register.Show();
            //this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string email = forEmail.Text.Trim();
            string password = ComputeSha256Hash(forPassword.Text.Trim()); // Make sure this hashes correctly

            string connectionString = "server=localhost;port=3306;database=gym;uid=root;pwd=root;";

            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                try
                {
                    conn.Open();

                    bool isLoggedIn = false;

                    // Check in gym_owners
                    string queryOwner = "SELECT COUNT(*) FROM gym_owners WHERE email = @Email AND password = @Password";
                    using (MySqlCommand cmdOwner = new MySqlCommand(queryOwner, conn))
                    {
                        cmdOwner.Parameters.AddWithValue("@Email", email);
                        cmdOwner.Parameters.AddWithValue("@Password", password);

                        int countOwner = Convert.ToInt32(cmdOwner.ExecuteScalar());

                        if (countOwner > 0)
                        {
                            MessageBox.Show("Login successful! Welcome, Administrator.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            GymDashboard dashboard = new GymDashboard();
                            dashboard.Show();
                            this.Hide();
                            isLoggedIn = true;
                        }
                    }

                    if (!isLoggedIn)
                    {
                        // Check in members
                        string queryMember = "SELECT COUNT(*) FROM members WHERE email = @Email AND password = @Password";
                        using (MySqlCommand cmdMember = new MySqlCommand(queryMember, conn))
                        {
                            cmdMember.Parameters.AddWithValue("@Email", email);
                            cmdMember.Parameters.AddWithValue("@Password", password);

                            int countMember = Convert.ToInt32(cmdMember.ExecuteScalar());

if (countMember > 0)
{
    MessageBox.Show("Login successful! Welcome, Member.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
    AfterLogin memberDashboard = new AfterLogin(email); // Pass the email
    memberDashboard.Show();
    this.Hide();
    isLoggedIn = true;
}

                        }
                    }
                    if (!isLoggedIn)
                    {
                        string queryTrainer = "SELECT COUNT(*) FROM trainers WHERE email = @Email AND password = @Password";
                        using (MySqlCommand cmdTrainer = new MySqlCommand(queryTrainer, conn))
                        {
                            cmdTrainer.Parameters.AddWithValue("@Email", email);
                            cmdTrainer.Parameters.AddWithValue("@Password", password);

                            int countTrainer = Convert.ToInt32(cmdTrainer.ExecuteScalar());

                            if (countTrainer > 0)
                            {
                                MessageBox.Show("Login successful! Welcome, Trainer.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                AfterLoginTrainer trainerDashboard = new AfterLoginTrainer(); // Replace with your actual form
                                trainerDashboard.Show();
                                this.Hide();
                                isLoggedIn = true;
                            }
                        }
                    }

                    if (!isLoggedIn)
                    {
                        MessageBox.Show("Invalid email or password.", "Login Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error connecting to database: " + ex.Message, "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }


        private void forEmail_TextChanged(object sender, EventArgs e)
        {

        }

        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            forgotPassword newPass = new forgotPassword();
            newPass.Show();

        }
    }
}
