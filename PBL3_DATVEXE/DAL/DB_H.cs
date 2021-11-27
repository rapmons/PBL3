using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace PBL3_DATVEXE.DAL
{
    class DB_H
    {
        SqlConnection conn;
        private static DB_H _Instance;
        public static DB_H Instance
        {
            get
            {
                if (_Instance == null)
                {
                    string s = @"Data Source=DESKTOP-1GG0LVP\SQLEXPRESS01;Initial Catalog=PBL3;Integrated Security=True";
                    _Instance = new DB_H(s);
                }
                return _Instance;
            }
            private set { }
        }
        private DB_H(string s)
        {
            conn = new SqlConnection(s);
        }
        public void Ex(string q)
        {
            SqlCommand cmd = new SqlCommand(q, conn);
            conn.Open();
            cmd.ExecuteNonQuery();
            conn.Close();
        }

        public DataTable get(string q)
        {
            DataTable data = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(q, conn);
            conn.Open();
            da.Fill(data);
            conn.Close();
            return data;
        }
    }
}
