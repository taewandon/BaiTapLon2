using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PTUD_với_CSDL
{
    internal class SqlConnect
    {
        public SqlConnect()
        {
        }

        SqlConnection conn = new SqlConnection(@"Data Source=DESKTOP-10L7UMH\SQLEXPRESS;Initial Catalog=QUANLYNHANSU;Integrated Security=True");

        public DataTable table(string query)
        {
            conn.Open();
            SqlDataAdapter adapter = new SqlDataAdapter(query, conn);
            DataTable dt = new DataTable();
            adapter.Fill(dt);
            conn.Close();
            return dt;
        }

        public void command(string query)
        {
            conn.Open();
            SqlCommand cmd = new SqlCommand(query, conn);
            cmd.ExecuteNonQuery();
            conn.Close();
        }

        public int kiemtra(string query)
        {
            conn.Open();
            SqlCommand cmd = new SqlCommand(query, conn);
            int count = (int)cmd.ExecuteScalar();
            conn.Close();
            return count;
        }
    }
}
