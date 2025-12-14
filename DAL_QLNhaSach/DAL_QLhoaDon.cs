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
    public class DAL_QLhoaDon
    {

        SqlConnection conn = new SqlConnection("Data Source=PHUCKK\\SQLEXPRESS;Initial Catalog=QLNS;Integrated Security=True");

        // Hàm tải danh sách hóa đơn


        public DataTable LayMaKH()
        {
            DataTable dt = new DataTable();
            try
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand("SP_LayMaKH", conn);
                cmd.CommandType = CommandType.StoredProcedure;

                SqlDataAdapter adapter = new SqlDataAdapter(cmd);

                adapter.Fill(dt);


                return dt;
            }
            catch (Exception) { }

            finally
            {
                conn.Close();
            }
            return dt;
        }
        public DataTable LayMaNV()
        {
            DataTable dt = new DataTable();
            try
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand("SP_LayMaNV", conn);
                cmd.CommandType = CommandType.StoredProcedure;

                SqlDataAdapter adapter = new SqlDataAdapter(cmd);

                adapter.Fill(dt);


                return dt;
            }
            catch (Exception) { }

            finally
            {
                conn.Close();
            }
            return dt;
        }
        //
        public DataTable LoadDSHoaDon()
        {
            DataTable dt = new DataTable();
            try
            {
                conn.Open();
                SqlCommand sqlCommand = new SqlCommand("SELECT * FROM HoaDon", conn);
                SqlDataAdapter ad = new SqlDataAdapter(sqlCommand);
                ad.Fill(dt);
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error: " + ex.Message);
            }
            finally
            {
                conn.Close();
            }
            return dt;
        }

        // Hàm tìm kiếm hóa đơn theo ngày
        public DataTable TimHoaDonTheoNgay(DateTime ngayLap)
        {
            DataTable dt = new DataTable();
            try
            {
                conn.Open();
                SqlCommand sqlCommand = new SqlCommand("SP_TimHoaDonTheoNgay", conn);
                sqlCommand.CommandType = CommandType.StoredProcedure;
                sqlCommand.Parameters.AddWithValue("@NgayLap", ngayLap);
                SqlDataAdapter ad = new SqlDataAdapter(sqlCommand);
                ad.Fill(dt);
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error: " + ex.Message);
            }
            finally
            {
                conn.Close();
            }
            return dt;
        }

        // Hàm thêm hóa đơn
        public void ThemHoaDon(string maHD, DateTime ngayLap, string maKH, string maNV, decimal tongTien)
        {
            try
            {
                conn.Open();
                SqlCommand sqlCommand = new SqlCommand("SP_ThemHoaDon", conn);
                sqlCommand.CommandType = CommandType.StoredProcedure;
                sqlCommand.Parameters.AddWithValue("@MaHD", maHD);
                sqlCommand.Parameters.AddWithValue("@NgayLap", ngayLap);
                sqlCommand.Parameters.AddWithValue("@MaKH", maKH);
                sqlCommand.Parameters.AddWithValue("@MaNV", maNV);
                sqlCommand.Parameters.AddWithValue("@TongTien", tongTien);
                sqlCommand.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error: " + ex.Message);
            }
            finally
            {
                conn.Close();
            }
        }

        // Hàm sửa hóa đơn
        public void SuaHoaDon(string maHD, DateTime ngayLap, string maKH, string maNV, decimal tongTien)
        {
            try
            {
                conn.Open();
                SqlCommand sqlCommand = new SqlCommand("SP_SuaHoaDon", conn);
                sqlCommand.CommandType = CommandType.StoredProcedure;
                sqlCommand.Parameters.AddWithValue("@MaHD", maHD);
                sqlCommand.Parameters.AddWithValue("@NgayLap", ngayLap);
                sqlCommand.Parameters.AddWithValue("@MaKH", maKH);
                sqlCommand.Parameters.AddWithValue("@MaNV", maNV);
                sqlCommand.Parameters.AddWithValue("@TongTien", tongTien);
                sqlCommand.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error: " + ex.Message);
            }
            finally
            {
                conn.Close();
            }
        }

        // Hàm xóa hóa đơn
        public void XoaHoaDon(string maHD)
        {
            try
            {
                conn.Open();
                SqlCommand sqlCommand = new SqlCommand("SP_XoaHoaDon", conn);
                sqlCommand.CommandType = CommandType.StoredProcedure;
                sqlCommand.Parameters.AddWithValue("@MaHD", maHD);
                sqlCommand.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error: " + ex.Message);
            }
            finally
            {
                conn.Close();
            }
        }

    }
}
