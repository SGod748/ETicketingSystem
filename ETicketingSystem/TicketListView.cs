using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ETicketingSystem
{
    public partial class ticketListView : UserControl
    {
        public ticketListView()
        {
            InitializeComponent();
        }

        public void UpdateBookingInfo(string movie, string genre, string price, string quantity, string cinema)
        {


            lblMovie.Text = movie;
            lblGenre.Text = genre;
            lblPrice.Text = price;
            lblQuantity.Text = quantity;
            lblCinema.Text = cinema;
         
            
        }

    }
}
