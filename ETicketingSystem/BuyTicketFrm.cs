using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Data.SqlClient;
using Microsoft.VisualBasic.Devices;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Button;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace ETicketingSystem
{
    public partial class BuyTicketFrm : Form
    {
        string conn = @"Data Source=JEYPI\SQLEXPRESS;Initial Catalog=movie;Integrated Security=True;Encrypt=False";

        private readonly ViewTicketFrm _parentForm;

        
        private string movie = "", genre = "", disclaimer = "";
        private int price = 0, cinema = 0;
        public BuyTicketFrm(ViewTicketFrm parentForm)
        {
            InitializeComponent();
            _parentForm = parentForm;
        }

        private void buyTicket_calculateBtn_Click(object sender, EventArgs e)
        {
            int quantity = 0;
            if (int.TryParse(txtQuantity.Text, out quantity) && quantity > 0)
            {
                int ticket_price = 0;
                if (int.TryParse(lblPrice.Text, out ticket_price))
                {
                    int totalPrice = ticket_price * quantity;

                    lblTotal.Text = $"₱{totalPrice}";  
                    lblQuantity.Text = $"{quantity}";
                    lblTicketPrice.Text = $"₱{ticket_price}";
                }
                else
                {
                    MessageBox.Show("Please make sure the price is valid.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Please enter a valid quantity.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

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
            else if (goTyme.Checked || payPal.Checked)
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
            else if (masterCard.Checked || debitCard.Checked)
            {
                bool hasMultipleNumbers = reference.Count(char.IsDigit) > 1;

                if (reference.Length == 12 && hasMultipleNumbers)
                {
                    validationLabel.Text = "Reference ID is valid.";
                    validationLabel.ForeColor = Color.Green;
                    isValid = true;
                }
                else
                {
                    validationLabel.Text = "Reference ID must be 12-digit long";
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


            string movie = lblMovieName.Text;
            string genre = lblGenre.Text;
            string disclaimer = lblDisclaimer.Text;

            int price = 0;
            int cinema = 0;
            
            if (!string.IsNullOrEmpty(movie) && !string.IsNullOrEmpty(genre) && !string.IsNullOrEmpty(disclaimer)
                && int.TryParse(lblPrice.Text, out price) && int.TryParse(lblCinema.Text, out cinema))
            {
                
                InsertMovieDetails(movie, genre, price, cinema, disclaimer);
            }
            else
            {
                MessageBox.Show("Please select a valid movie before purchasing a ticket.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void InsertMovieDetails(string movie, string genre, int price, int cinema, string disclaimer)
        {
            using (SqlConnection connection = new SqlConnection(conn))
            {
                try
                {
                    connection.Open();

                    string query = "INSERT INTO ticket_details(movie_name, genre, price, cinema_room) " +
                                   "VALUES (@Movie_Name, @Genre, @Price, @Cinema_Room)";

                    using (SqlCommand cmd = new SqlCommand(query, connection))
                    {
                        cmd.Parameters.AddWithValue("@Movie_Name", movie);
                        cmd.Parameters.AddWithValue("@Genre", genre);
                        cmd.Parameters.AddWithValue("@Price", price);
                        cmd.Parameters.AddWithValue("@Cinema_Room", cinema);

                        
                        int rowsAffected = cmd.ExecuteNonQuery();
                        
                        _parentForm.AddNewBooking(
                          lblMovieName.Text, lblGenre.Text, lblPrice.Text, lblGenre.Text, lblCinema.Text);

                        
                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("Movie details have been successfully inserted into the database.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        else
                        {
                            MessageBox.Show("Failed to insert movie details into the database.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("An error occurred: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
        

        private void buyTicket_printrecieptBtn_Click(object sender, EventArgs e)
        {
            MessageBox.Show("The receipt was sent to your email account.", "Information Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void cbMovieName_SelectedIndexChanged(object sender, EventArgs e)
        {
            string genre = "";
            string movie = "";
            int cinema = 0;
            int price = 0;
            string disclaimer = "";

            if (cbMovieName.SelectedItem != null)
            {
                switch (cbMovieName.SelectedItem.ToString())
                {
                    case "Moana 2":
                        movie = "Moana 2";
                        genre = "Animation/Adventure";
                        price = 350;
                        cinema = 1;
                        disclaimer = "This is an animated sequel with family-friendly content.";
                        break;
                    case "Gladiator 2":
                        movie = "Gladiator 2";
                        genre = "Action/Adventure";
                        price = 350;
                        cinema = 4;
                        disclaimer = "This film contains intense action and violence.";
                        break;
                    case "Hello, Love, Again":
                        movie = "Hello, Love, Again";
                        genre = "Romance/Comedy";
                        price = 350;
                        cinema = 2;
                        disclaimer = "A romantic comedy with mature themes.";
                        break;
                    case "Mufasa The Lion King":
                        movie = "Mufasa The Lion King";
                        genre = "Animation/Adventure";
                        price = 350;
                        cinema = 3;
                        disclaimer = "A new take on the classic Lion King tale with some emotional scenes.";
                        break;
                    case "Solo Leveling The Movie":
                        movie = "Solo Leveling The Movie";
                        genre = "Anime/Action";
                        price = 450;
                        cinema = 1;
                        disclaimer = "Action-packed anime with fantasy violence.";
                        break;
                    default:
                        disclaimer = "Please select a movie.";
                        break;
                }
                lblMovieName.Text = movie; 
                lblGenre.Text = genre;
                lblPrice.Text = $"₱{price}";
                lblCinema.Text = $"{cinema}";
                lblDisclaimer.Text = disclaimer;  
            }
            else
            {
                lblMovieName.Text = " Not movie Selected";
            }
        }
    }
}
