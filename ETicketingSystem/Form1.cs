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
    public partial class LoginFrm : Form
    {
        string conn = @"Data Source=MSI\SQLEXPRESS;Initial Catalog=TicketDB;Integrated Security=True;Encrypt=False";
        public LoginFrm()
        {
            InitializeComponent();
        }

        private void login_Closebtn_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void login_showPass_CheckedChanged(object sender, EventArgs e)
        {
            login_passtxt.UseSystemPasswordChar = !login_showPass.Checked;
        }

        private void login_signupbtn_Click(object sender, EventArgs e)
        {
            RegisterFrm registerFrm = new RegisterFrm();
            registerFrm.Show();

            this.Hide();
        }

        private void loginbtn_Click(object sender, EventArgs e)
        {
            if (login_usernametxt.Text == "" || login_showPass.Text == "")
            {
                MessageBox.Show("Please fill all blank fields", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            } 
            else
            {
                using (SqlConnection connect = new SqlConnection(conn))
                {
                    connect.Open();

                    string selectData = "SELECT * FROM Account WHERE usern = @usern AND pass = @pass";

                    using (SqlCommand cmd = new SqlCommand(selectData, connect))
                    {
                        cmd.Parameters.AddWithValue("@usern", login_usernametxt.Text.Trim());
                        cmd.Parameters.AddWithValue("@pass", login_passtxt.Text.Trim());

                        SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                        DataTable table = new DataTable();

                        adapter.Fill(table);

                        if (table.Rows.Count > 0)
                        {

                            MessageBox.Show("Login Successful", "Information Message", MessageBoxButtons.OK, MessageBoxIcon.Information);

                            CustomerFrm staffFrm = new CustomerFrm();
                            staffFrm.Show();

                            this.Hide();
                        }
                        else
                        {
                            MessageBox.Show("Incorrect username/password", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
            }
        }
    }
}
