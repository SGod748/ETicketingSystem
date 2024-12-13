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
            ticketListView newBookingControl = new ticketListView();
            
            newBookingControl.UpdateBookingInfo( movie, genre,  price,  quantity, cinema);
            flowViewTicketPanel.Controls.Add(newBookingControl);

            ToggleBookListViewVisibility();
        }
        
        private void ToggleBookListViewVisibility()
        {   
            var anyBookings = flowViewTicketPanel.Controls.OfType<ticketListView>().Any();
            

            foreach (Control control in flowViewTicketPanel.Controls)
            {
                if (control is ticketListView bookListView)
                {
                    bookListView.Visible = anyBookings; 
                }
            }
        }

    }
}
