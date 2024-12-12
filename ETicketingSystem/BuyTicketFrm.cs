using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Button;

namespace ETicketingSystem
{
    public partial class BuyTicketFrm : Form
    {
        string conn = @"Data Source=PC19\SQLEXPRESS;Initial Catalog=movie;Integrated Security=True;Trust Server Certificate=True";

        public BuyTicketFrm()
        {
            InitializeComponent();
        }

        //ajygda
        private void buyTicket_selectmovieBtn_Click(object sender, EventArgs e)
        {
            SelectMovieFrm selectMovieFrm = new SelectMovieFrm();
            selectMovieFrm.Show();
        }

        private void buyTicket_calculateBtn_Click(object sender, EventArgs e)
        {

        }

        private void gCash_CheckedChanged(object sender, EventArgs e)
        {
            validationLabel.Text = string.Empty;
            ValidateRadioButtonSelection();
        }

        private void payMaya_CheckedChanged(object sender, EventArgs e)
        {
            validationLabel.Text = string.Empty;
            ValidateRadioButtonSelection();
        }

        private void maya_CheckedChanged(object sender, EventArgs e)
        {
            validationLabel.Text = string.Empty;
            ValidateRadioButtonSelection();
        }

        private void goTyme_CheckedChanged(object sender, EventArgs e)
        {
            validationLabel.Text = string.Empty;
            ValidateRadioButtonSelection();
        }

        private void payPal_CheckedChanged(object sender, EventArgs e)
        {
            validationLabel.Text = string.Empty;
            ValidateRadioButtonSelection();
        }

        private void masterCard_CheckedChanged(object sender, EventArgs e)
        {
            validationLabel.Text = string.Empty;
            ValidateRadioButtonSelection();
        }

        private void debitCard_CheckedChanged(object sender, EventArgs e)
        {
            validationLabel.Text = string.Empty;
            ValidateRadioButtonSelection();
        }

        private void ValidateRadioButtonSelection()
        {
            if (!gCash.Checked && !payMaya.Checked && !maya.Checked &&
            !goTyme.Checked && !payPal.Checked && !masterCard.Checked &&
                !debitCard.Checked)
            {
                validationBtn.Text = "Please select a payment method or option.";
                validationBtn.ForeColor = Color.Red;
            }
            else
            {
                validationBtn.Text = "Selection is valid.";
                validationBtn.ForeColor = Color.Green;
            }
        }

        private void buyTicket_reference_TextChanged(object sender, EventArgs e)
        {
            string reference = buyTicket_reference.Text;
            bool isValid = false;

            if (gCash.Checked || payMaya.Checked || maya.Checked)
            {
                if (reference.Length == 11 && reference.StartsWith("09") && long.TryParse(reference, out _))
                {
                    validationLabel.Text = "Reference ID is valid.";
                    validationLabel.ForeColor = Color.Green;
                    isValid = true;
                }
                else
                {
                    validationLabel.Text = "Reference ID must be 11 digits and start with '09'.";
                    validationLabel.ForeColor = Color.Red;
                }
            }
            else if (goTyme.Checked || payPal.Checked || masterCard.Checked || debitCard.Checked)
            {
                bool hasUppercase = reference.Any(char.IsUpper);
                bool hasMultipleNumbers = reference.Count(char.IsDigit) > 1;

                if (reference.Length == 17 && hasUppercase && hasMultipleNumbers)
                {
                    validationLabel.Text = "Reference ID is valid.";
                    validationLabel.ForeColor = Color.Green;
                    isValid = true;
                }
                else
                {
                    validationLabel.Text = "Reference ID must be 17 characters long, contain uppercase letters, and multiple numbers.";
                    validationLabel.ForeColor = Color.Red;
                }
            }
            else
            {
                validationLabel.Text = string.Empty;
            }
            buyTicket_Btn.Enabled = isValid;
        }


        private void buyTicket_Btn_Click(object sender, EventArgs e)
        {

        }
    }
}
