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
        string conn = @"Data Source=PC19\SQLEXPRESS;Initial Catalog=movie;Integrated Security=True;Trust Server Certificate=True";
        public ViewTicketFrm()
        {
            InitializeComponent();
        }

        private void loadHistoryData()
        {
            
        }
    }
}
