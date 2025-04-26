using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Data;
using System.Text;
using System.Threading.Tasks;

namespace DAL_QLNhaSach
{
    public class DAL_TaiKhoan
    {
        SqlConnection conn = new SqlConnection("Data Source=DESKTOP-7IFDIQJ;Initial Catalog=QLNS1;Integrated Security=True");

         public bool ThemTK(string a, string b)
        {
            bool flag = false;

            try
            {
                conn.Open();

                SqlCommand cmd = new SqlCommand("SP_ThemTKkk",conn);
                cmd.CommandType = CommandType.StoredProcedure;

                SqlParameter pra = new SqlParameter("@ten", a);
                cmd.Parameters.Add(pra);
                SqlParameter sqlParameter = new SqlParameter("@mk", b);
                cmd.Parameters.Add(sqlParameter);

                if(cmd.ExecuteNonQuery() > 0)
                {
                    flag = true;
                }

            }catch (Exception) { }

            finally
            {
                conn.Close();
            }


            return flag;
        }

        public bool KiểmTraTK(string a, string b)
        {

            bool flag = false;

            try
            {
                conn.Open();

                SqlCommand cmd = new SqlCommand("DS_TKed", conn);
                cmd.CommandType = CommandType.StoredProcedure;

                SqlParameter pra = new SqlParameter("@ten", a);
                cmd.Parameters.Add(pra);
                SqlParameter sqlParameter = new SqlParameter("@mk", b);
                cmd.Parameters.Add(sqlParameter);
                 
                if(cmd.ExecuteNonQuery() > 0)
                {
                    flag = true;
                }
           

            }
            catch (Exception) { }

            finally
            {
                conn.Close();
            }


            return flag;
        }
    }
}
