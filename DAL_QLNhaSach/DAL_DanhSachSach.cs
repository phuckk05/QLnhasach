using ET_QLNhaSach;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL_QLNhaSach
{
    public class DAL_DanhSachSach
    {
        SqlConnection conn = new SqlConnection("Data Source=PHUCKK\\SQLEXPRESS;Initial Catalog=QLNS;Integrated Security=True");

        public DataTable LoadDSsach()
        { 
        
        DataTable dt = new DataTable();
            try
            {
                conn.Open();

                SqlCommand cmd = new SqlCommand("SP_Dsach2", conn);
                cmd.CommandType = CommandType.StoredProcedure;

                SqlDataAdapter adp = new SqlDataAdapter(cmd);

                adp.Fill(dt);


               return dt;

            }catch (Exception) { }

            finally { conn.Close(); }

            return dt;

        }

        public DataTable LoadTimMa(ET_Sach et)
        {
            DataTable dt = new DataTable();


            try
            {

                conn.Open();


                SqlCommand comd = new SqlCommand("SP_TimDsSach", conn);
                comd.CommandType = CommandType.StoredProcedure;

                SqlParameter pra = new SqlParameter("@masach" ,et.IDSach1);
                comd.Parameters.Add(pra);

                SqlDataAdapter adp = new SqlDataAdapter(comd);
                adp.Fill(dt);


            }catch(Exception) { }


            finally
            {
                conn.Close();
            }

            return dt;
        }

        public DataTable LoadTimTen(ET_Sach et)
        {
            DataTable dt = new DataTable();


            try
            {

                conn.Open();


                SqlCommand comd = new SqlCommand("SP_TimSachBangTen", conn);
                comd.CommandType = CommandType.StoredProcedure;

                SqlParameter pra = new SqlParameter("@tensach", et.TenSach1);
                comd.Parameters.Add(pra);

                SqlDataAdapter adp = new SqlDataAdapter(comd);
                adp.Fill(dt);


            }
            catch (Exception) { }


            finally
            {
                conn.Close();
            }

            return dt;
        }
    }
}
