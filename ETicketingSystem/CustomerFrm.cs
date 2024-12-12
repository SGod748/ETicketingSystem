using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using Microsoft.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ETicketingSystem
{
    public partial class CustomerFrm : Form
    {
        public CustomerFrm()
        {
            InitializeComponent();

            LoadMovie();

        }

        private void closebtn_Click(object sender, EventArgs e)
        {
            if (DialogResult.Yes == MessageBox.Show("Are you sure you want to exit?", "Confirmation Message"
                , MessageBoxButtons.YesNo, MessageBoxIcon.Question))
            {
                Application.Exit();
            }
        }

        private void logout_btn_Click(object sender, EventArgs e)
        {
            if (DialogResult.Yes == MessageBox.Show("Are you sure you want to logout?", "Confirmation Message"
                , MessageBoxButtons.YesNo, MessageBoxIcon.Question))
            {
                LoginFrm loginFrm = new LoginFrm();
                loginFrm.Show();

                this.Hide();
            }
        }

        private void dashboard_btn_Click(object sender, EventArgs e)
        {
            openChildForm(new MovieDashboardFrm());
        }

        public void LoadMovie()
        {
            openChildForm(new MovieDashboardFrm());
        }

        private void buyTicket_btn_Click(object sender, EventArgs e)
        {
            //Dito ang may error
            //BuyTicketFrm buy = new BuyTicketFrm();
           // openChildForm(buy);
        }

        private Form activeForm = null;
        private void openChildForm(Form childForm)
        {
            if (activeForm != null)
                activeForm.Close();
            activeForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            userPanel.Controls.Add(childForm);
            userPanel.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
            this.userPanel.Dock = System.Windows.Forms.DockStyle.Fill;
        }

        private void viewTicket_btn_Click(object sender, EventArgs e)
        {
            openChildForm(new ViewTicketFrm());
        }
    }
}