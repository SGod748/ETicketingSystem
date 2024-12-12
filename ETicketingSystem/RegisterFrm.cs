using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data;
using Microsoft.Data.SqlClient;


namespace ETicketingSystem
{
    public partial class RegisterFrm : Form
    {
        string conn = @"Data Source=PC19\SQLEXPRESS;Initial Catalog=movie;Integrated Security=True;Trust Server Certificate=True";
        public RegisterFrm()
        {
            InitializeComponent();
        }

        private void login_Closebtn_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void signup_showPass_CheckedChanged(object sender, EventArgs e)
        {
            signup_passtxt.UseSystemPasswordChar = !signup_showPass.Checked;
            signup_cPasstxt.UseSystemPasswordChar = !signup_showPass.Checked; ;
        }

        private void signup_loginbtn_Click(object sender, EventArgs e)
        {
            LoginFrm loginFrm = new LoginFrm();
            loginFrm.Show();

            this.Hide();
        }

        private void signup_passtxt_TextChanged(object sender, EventArgs e)
        {
            string password = signup_passtxt.Text;
            string strengthMessage;
            Color strengthColor;

            if (password.Length < 8)
            {
                strengthMessage = "Password is too short (min 8 characters)";
                strengthColor = Color.Red;
            }
            else if (!HasUpperCase(password) || !HasLowerCase(password) || !HasDigit(password))
            {
                strengthMessage = "Password should include uppercase, lowercase, and a number";
                strengthColor = Color.Orange;
            }
            else
            {
                strengthMessage = "Strong password";
                strengthColor = Color.Green;
            }

            passwordStrengthLabel.Text = strengthMessage;
            passwordStrengthLabel.ForeColor = strengthColor;
        }

        private bool HasUpperCase(string input) => input.Any(char.IsUpper);
        private bool HasLowerCase(string input) => input.Any(char.IsLower);
        private bool HasDigit(string input) => input.Any(char.IsDigit);

        private void signupbtn_Click(object sender, EventArgs e)
        {
            if (signup_usernametxt.Text == "" || signup_passtxt.Text == "" || signup_cPasstxt.Text == "")
            {
                MessageBox.Show("Please fill all blank fields", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (signup_passtxt.Text != signup_cPasstxt.Text)
            {
                MessageBox.Show("Password does not match", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (signup_passtxt.Text.Length < 8)
            {
                MessageBox.Show("Password is too short (min 8 characters)", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                using (SqlConnection connect = new SqlConnection(conn))
                {
                    connect.Open();

                    string checkUsername = "SELECT * FROM users WHERE username = @usern";

                    using (SqlCommand checkUsern = new SqlCommand(checkUsername, connect))
                    {
                        checkUsern.Parameters.AddWithValue("@usern", signup_usernametxt.Text.Trim());

                        SqlDataAdapter adapter = new SqlDataAdapter(checkUsern);
                        DataTable table = new DataTable();

                        adapter.Fill(table);

                        if (table.Rows.Count > 0)
                        {
                            MessageBox.Show(signup_usernametxt.Text.Substring(1)
                                + " is already taken", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                        else
                        {
                            string insertData = "INSERT INTO users (username, password, date_reg)" +
                                "VALUES(@usern, @pass, @date)";

                            DateTime today = DateTime.Today;

                            using (SqlCommand cmd = new SqlCommand(insertData, connect))
                            {
                                cmd.Parameters.AddWithValue("@usern", signup_usernametxt.Text.Trim());
                                cmd.Parameters.AddWithValue("@pass", signup_passtxt.Text.Trim());
                                cmd.Parameters.AddWithValue("@date", today);

                                cmd.ExecuteNonQuery();

                                MessageBox.Show("Register Successful", "Information Message", MessageBoxButtons.OK, MessageBoxIcon.Information);

                                LoginFrm loginFrm = new LoginFrm();
                                loginFrm.Show();
                                this.Hide();
                            }
                        }
                    }
                }
            }
        }

    }
}