using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using Microsoft.Data.SqlClient;

namespace ETicketingSystem
{
    class customerData
    {
        string conn = @"Data Source=MSI\SQLEXPRESS;Initial Catalog=TicketDB;Integrated Security=True;Encrypt=False";
        public string Username { get; set; } // 0
        public string Password { get; set; } // 1

        public List<customerData> staffDataListData()
        {
            List<customerData> listData = new List<customerData>();

            using (SqlConnection connect = new SqlConnection(conn))
            {
                connect.Open();

                string selectData = "SELECT * FROM Account";

                using (SqlCommand cmd = new SqlCommand(selectData, connect))
                {
                    SqlDataReader reader = cmd.ExecuteReader();

                    while (reader.Read())
                    {
                        customerData sData = new customerData();

                        sData.Username = reader[0].ToString();
                        sData.Password = reader[1].ToString();

                        listData.Add(sData);
                    }
                }
            }

            return listData;
        }
    }
}
