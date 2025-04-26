using System;
using System.Data;
using System.Data.SqlClient;
using ET_QLNhaSach;

namespace DAL_QLNhaSach
{
    public class DAL_QLKhachHang
    {
        SqlConnection conn = new SqlConnection("Data Source=LAPTOP-9I5E70JL\\SQLEXPRESS;Initial Catalog=QLNS;Integrated Security=True");

        public bool ThemKhachHang(ET_KhachHang et)
        {
            try
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand("SP_ThemKhachHang", conn);
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue("@makh", et.ID1);
                cmd.Parameters.AddWithValue("@tenkh", et.TenKH1);
                cmd.Parameters.AddWithValue("@ngay", et.NgaySinh1);
                cmd.Parameters.AddWithValue("@gt", et.GT1);
                cmd.Parameters.AddWithValue("@cccd", et.CCCD1);
                cmd.Parameters.AddWithValue("@sdt", et.SDT1);

                return cmd.ExecuteNonQuery() > 0;
            }
            catch (Exception)
            {
                return false;
            }
            finally
            {
                conn.Close();
            }
        }
        public DataTable LoadKhachHang()
        {
            try
            {
                SqlDataAdapter da = new SqlDataAdapter("SELECT * FROM KhachHang", conn);
                DataTable dt = new DataTable();
                da.Fill(dt);
                return dt;
            }
            catch (Exception)
            {
                return null;
            }
        }

        public bool XoaKhachHang(ET_KhachHang et)
        {
            try
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand("SP_XoaKhachHang", conn);
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue("@makh", et.ID1);

                return cmd.ExecuteNonQuery() > 0;
            }
            catch (Exception)
            {
                return false;
            }
            finally
            {
                conn.Close();
            }
        }

        public bool SuaKhachHang(ET_KhachHang et)
        {
            try
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand("SP_SuaKhachHang", conn);
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue("@makh", et.ID1);
                cmd.Parameters.AddWithValue("@tenkh", et.TenKH1);
                cmd.Parameters.AddWithValue("@ngay", et.NgaySinh1);
                cmd.Parameters.AddWithValue("@gt", et.GT1);
                cmd.Parameters.AddWithValue("@cccd", et.CCCD1);
                cmd.Parameters.AddWithValue("@sdt", et.SDT1);

                return cmd.ExecuteNonQuery() > 0;
            }
            catch (Exception)
            {
                return false;
            }
            finally
            {
                conn.Close();
            }
        }
    }
}
