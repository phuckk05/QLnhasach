using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using ET_QLNhaSach;

namespace DAL_QLNhaSach
{
    public class DAL_QLNhanVien
    {
        SqlConnection conn = new SqlConnection("Data Source=LAPTOP-9I5E70JL\\SQLEXPRESS;Initial Catalog=QLNS;Integrated Security=True");

        public DataTable LoadDSNV()
        {
            DataTable DSNV = new DataTable();
            try
            {

                conn.Open();

                SqlCommand cmd = new SqlCommand("sp_LayDSNV", conn);
                cmd.CommandType = CommandType.StoredProcedure;

                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                adapter.Fill(DSNV);

                return DSNV;

            }
            catch (Exception) { }


            finally
            {
                conn.Close();
            }
            return DSNV;
        }
        public bool ThemNhanVien(ET_NhanVien et)
        {
            bool flag = false;
            try
            {
                //mo ket noi
                conn.Open();
                SqlCommand cmd = new SqlCommand("sp_Themnhanvien", conn);
                cmd.CommandType = CommandType.StoredProcedure;

                SqlParameter prama = new SqlParameter("@manv", et.ID1);
                cmd.Parameters.Add(prama);

                SqlParameter praten = new SqlParameter("@tennv", et.TenNV1);
                cmd.Parameters.Add(praten);

                SqlParameter prangaysinh = new SqlParameter("@ngaysinh", et.NgaySinh1);
                cmd.Parameters.Add(prangaysinh);

                SqlParameter pragt = new SqlParameter("@gioitinh", et.GT1);
                cmd.Parameters.Add(pragt);

                SqlParameter pracccd = new SqlParameter("@cccd", et.CCCD1);
                cmd.Parameters.Add(pracccd);

                SqlParameter pradiachi = new SqlParameter("@diachi", et.DiaChi1);
                cmd.Parameters.Add(pradiachi);

                SqlParameter prasdt = new SqlParameter("@sodt", et.SDT1);
                cmd.Parameters.Add(prasdt);

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

        public bool XoaNhanVien(ET_NhanVien et)
        {
            bool flag = false;
            try
            {
                //mo ket noi
                conn.Open();
                SqlCommand cmd = new SqlCommand("sp_Xoanhanvien6", conn);
                cmd.CommandType = CommandType.StoredProcedure;

                SqlParameter prama = new SqlParameter("@manv", et.ID1);
                cmd.Parameters.Add(prama);
                

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

        public bool SuaNhanVien(ET_NhanVien et)
        {
            bool flag = false;
            try
            {
                //mo ket noi
                conn.Open();
                SqlCommand cmd = new SqlCommand("sp_Suanhanvien1", conn);
                cmd.CommandType = CommandType.StoredProcedure;

                SqlParameter prama = new SqlParameter("@manv", et.ID1);
                cmd.Parameters.Add(prama);

                SqlParameter praten = new SqlParameter("@tennv", et.TenNV1);
                cmd.Parameters.Add(praten);

                SqlParameter prangaysinh = new SqlParameter("@ngaysinh", et.NgaySinh1);
                cmd.Parameters.Add(prangaysinh);

                SqlParameter pragt = new SqlParameter("@gioitinh", et.GT1);
                cmd.Parameters.Add(pragt);

                SqlParameter pracccd = new SqlParameter("@cccd", et.CCCD1);
                cmd.Parameters.Add(pracccd);

                SqlParameter pradiachi = new SqlParameter("@diachi", et.DiaChi1);
                cmd.Parameters.Add(pradiachi);

                SqlParameter prasdt = new SqlParameter("@sodt", et.SDT1);
                cmd.Parameters.Add(prasdt);

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
