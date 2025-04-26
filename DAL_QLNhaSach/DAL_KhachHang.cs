using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using ET_QLNhaSach;

namespace DAL_QLNhaSach
{
    public class DAL_KhachHang
    {
        SqlConnection conn = new SqlConnection("Data Source=LAPTOP-9I5E70JL\\SQLEXPRESS;Initial Catalog=QLNS;Integrated Security=True");

        public string LoadMaHD()
        {
            string MaKH = "";

            try
            {
                conn.Open();

                SqlCommand cmd = new SqlCommand("SP_MaKHAuTO", conn);
                cmd.CommandType = CommandType.StoredProcedure;

                using (SqlDataReader reader = cmd.ExecuteReader())
                {
                    if (reader.Read())
                    {
                        MaKH = reader.GetString(0);

                    }
                }

            }


            catch (Exception)
            {

            }

            finally
            {
                conn.Close();
            }

         return MaKH;

        }
        public DataTable LoadDSKH()
        {
            DataTable DSKH = new DataTable();
            try
            {

                conn.Open();

                SqlCommand cmd = new SqlCommand("SP_DSKhachHang", conn);
                cmd.CommandType = CommandType.StoredProcedure;

                SqlDataAdapter adapter = new SqlDataAdapter();
                adapter.Fill(DSKH);

                return DSKH;

            }catch (Exception) { }


            finally
            {
                conn.Close();
            }
            return DSKH;
        }
        public bool ThemKH(ET_KhachHang et)
        {
            bool flag = false;
            try
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand("SP_ThemKhachHang", conn);
                cmd.CommandType = CommandType.StoredProcedure;

                SqlParameter pra = new SqlParameter("@makh", et.ID1);
                cmd.Parameters.Add(pra);
                SqlParameter praa = new SqlParameter("@tenkh", et.TenKH1);
                cmd.Parameters.Add(praa);
                SqlParameter praaa = new SqlParameter("@ngay", et.NgaySinh1);
                cmd.Parameters.Add(praaa);
                SqlParameter praaaa = new SqlParameter("@gt", et.GT1);
                cmd.Parameters.Add(praaaa);
                SqlParameter praaaaa = new SqlParameter("@cccd", et.CCCD1);
                cmd.Parameters.Add(praaaaa);
                SqlParameter prabb = new SqlParameter("@sdt", et.SDT1);
                cmd.Parameters.Add(prabb);

                if (cmd.ExecuteNonQuery() > 0)
                {
                    return flag = true;
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
