using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;
using System.Data.SqlClient;

namespace DuongVanTrongDai_2906
{
    public class xuly
    {
        SqlConnection con;
        private void connect()
        {
            con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=D:\ThuongmaiDienTu\OnTap\DuongVanTrongDai_2906\DuongVanTrongDai_2906\App_Data\Database1.mdf;Integrated Security=True");
            con.Open();
        }
        private void close_connect()
        {
            if (con.State == ConnectionState.Open)
                con.Close();
        }
        public DataTable GetData(String q)
        {
            DataTable dt = new DataTable();
            try
            {
                connect();
                SqlDataAdapter da = new SqlDataAdapter(q, con);
                da.Fill(dt);

            }
            catch
            {
                dt = null;
            }
            finally
            {
                close_connect();
            }
            return dt;
        }
    }
}
