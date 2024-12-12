using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using Microsoft.Data.SqlClient;
using System.Web;

namespace ETicketingSystem
{
    class movieData
    {
        string conn = @"Data Source=PC19\SQLEXPRESS;Initial Catalog=movie;Integrated Security=True;Trust Server Certificate=True";

        public string MovieName { set; get; } // 0
        public string Genre { set; get; } // 1
        public string Price { set; get; } // 2
        public string Cinema { set; get; } // 3
        public string CinemaHours { set; get; } // 4
        public string Image {  set; get; } // 5
        public string Date {  set; get; } // 6

        public List<movieData> movieListData()
        {
            List<movieData> listData = new List<movieData>();

            using (SqlConnection connect  = new SqlConnection(conn))
            {
                connect.Open();

                string selectData = "SELECT * FROM movies";

                using (SqlCommand cmd = new SqlCommand(selectData, connect))
                {
                    SqlDataReader reader = cmd.ExecuteReader();

                    while (reader.Read())
                    {
                        movieData mData = new movieData();

                        mData.MovieName = reader["movie_name"].ToString();
                        mData.Genre = reader["genre"].ToString();
                        mData.Price = reader["price"].ToString();
                        mData.Cinema = reader["cinema"].ToString();
                        mData.CinemaHours = reader["cinema_hours"].ToString();
                        mData.Image = reader["movie_image"].ToString();
                        mData.Date = reader["created_at"].ToString();

                        listData.Add(mData);
                    }
                }
            }
            return listData;
        }

        public List<movieData> movieAvailableListData()
        {
            List<movieData> listData = new List<movieData>();

            using (SqlConnection connect = new SqlConnection(conn))
            {
                connect.Open();

                string selectData = "SELECT * FROM movies";

                using (SqlCommand cmd = new SqlCommand(selectData, connect))
                {
                    SqlDataReader reader = cmd.ExecuteReader();

                    while (reader.Read())
                    {
                        movieData mData = new movieData();

                        mData.MovieName = reader["movie_name"].ToString();
                        mData.Genre = reader["genre"].ToString();
                        mData.Price = reader["price"].ToString();
                        mData.Cinema = reader["cinema"].ToString();
                        mData.CinemaHours = reader["cinema_hours"].ToString();
                        mData.Image = reader["movie_image"].ToString();
                        mData.Date = reader["created_at"].ToString();

                        listData.Add(mData);
                    }
                }
            }
            return listData;
        }
    }
}
