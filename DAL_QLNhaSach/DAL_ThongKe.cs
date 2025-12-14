using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ET_QLNhaSach;

namespace DAL_QLNhaSach
{
    public class DAL_ThongKe
    {
        SqlConnection conn = new SqlConnection("Data Source=PHUCKK\\SQLEXPRESS;Initial Catalog=QLNS;Integrated Security=True");

        public DataTable LoadDL(string a, string b)
        {
            DataTable dt = new DataTable();

            try
            {
                conn.Open();

                SqlCommand cmd = new SqlCommand("SP_ThongKeTheoThanggh", conn);
                cmd.CommandType = CommandType.StoredProcedure;

                SqlParameter pra = new SqlParameter("@thang", a);
                cmd.Parameters.Add(pra);
                SqlParameter praa = new SqlParameter("@nam",b);
                cmd.Parameters.Add(praa);


                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                 adapter.Fill(dt);




            }catch (Exception) { }
            finally
            {
                conn.Close();
            }

            return dt;
        
        }
    }
}
