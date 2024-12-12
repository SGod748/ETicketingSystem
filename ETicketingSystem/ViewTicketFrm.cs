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

namespace ETicketingSystem
{
    public partial class ViewTicketFrm : Form
    {
        string conn = @"Data Source=MSI\SQLEXPRESS;Initial Catalog=TicketDB;Integrated Security=True;Encrypt=False";    
        public ViewTicketFrm()
        {
            InitializeComponent();
            ticketListView listView = new ticketListView();
        }


        public void AddNewBooking(string movie, string genre, string price, string quantity, string cinema)
        {
            // Create a new instance of BookListView user control
            ticketListView newBookingControl = new ticketListView();

            // Update the labels with the booking details
            newBookingControl.UpdateBookingInfo( movie, genre,  price,  quantity, cinema);

            // Add the new control to the FlowLayoutPanel (Assume the FlowLayoutPanel is named flpBookingList)
            flowViewTicketPanel.Controls.Add(newBookingControl);

            // After adding, check if any booking exists and show/hide accordingly
            ToggleBookListViewVisibility();


        }

        // Method to toggle visibility of the BookListView based on the presence of bookings
        private void ToggleBookListViewVisibility()
        {
            // Check if there are any controls in the FlowLayoutPanel that are BookListView instances
            var anyBookings = flowViewTicketPanel.Controls.OfType<ticketListView>().Any();

            // Show or hide the BookListView based on whether any bookings are added
            foreach (Control control in flowViewTicketPanel.Controls)
            {
                if (control is ticketListView bookListView)
                {
                    bookListView.Visible = anyBookings; // Only visible if there are bookings
                }
            }
        }

    }
}
