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
    public class DAL_ThanhToan
    {
        
        SqlConnection conn = new SqlConnection("Data Source=LAPTOP-9I5E70JL\\SQLEXPRESS;Initial Catalog=QLNS;Integrated Security=True");





        
        public string LoadMaTheoTen(ET_NhanVien et)
        {

            string tennv = "";

            try
            {
                conn.Open();


                SqlCommand cmd = new SqlCommand("SP_LayMaNVTheoTent", conn);
                cmd.CommandType = CommandType.StoredProcedure;


                SqlParameter pra = new SqlParameter("@ten", et.TenNV1);
                cmd.Parameters.Add(pra);


                using (SqlDataReader reader = cmd.ExecuteReader())
                {
                    if (reader.Read())
                    {
                       tennv = reader.GetString(0);

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
            return tennv;
        }
        public DataTable LoadTebNV()
        {

            DataTable dataTable = new DataTable();

            try
            {
                conn.Open();


                SqlCommand cmd = new SqlCommand("SP_DSTenNhanVien", conn);
                cmd.CommandType = CommandType.StoredProcedure;


                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                adapter.Fill(dataTable);



            }
            catch (Exception)
            {

            }

            finally
            {
                conn.Close();
            }
            return dataTable;
        }
        public DataTable LoadMaNV()
        {
            DataTable dataTable = new DataTable();

            try
            {
                conn.Open();


                SqlCommand cmd = new SqlCommand("SP_DSMaNhanV", conn);
                cmd.CommandType = CommandType.StoredProcedure;


                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                adapter.Fill(dataTable);



            }catch (Exception)
            {
                
            }

            finally
            {
                conn.Close();
            }
            return dataTable;

            
        }
        public string LoadMaHDNEW()
        {

            string MaHD = "";
            try
            {
                conn.Open();


                SqlCommand cmd = new SqlCommand("SP_GetLast3DigitsOfMaxMaHDdddd", conn);
                cmd.CommandType = CommandType.StoredProcedure;

                using (SqlDataReader reader = cmd.ExecuteReader())
                {
                    if (reader.Read())
                    {
                        MaHD = reader.GetString(0);
                     
                    }
                }

                return MaHD;

             
            }
            catch (Exception)
            {

            }

            finally
            {
                conn.Close();
            }

            return MaHD;    
          
        }
        public string LoadTenKH(ET_KhachHang et)
        {

            string TenKH = "";
            try
            {
                conn.Open();


                SqlCommand cmd = new SqlCommand("SP_TenKH", conn);
                cmd.CommandType = CommandType.StoredProcedure;
                SqlParameter pra = new SqlParameter("@sdt", et.SDT1);
                cmd.Parameters.Add(pra);

                using (SqlDataReader reader = cmd.ExecuteReader())
                {
                    if (reader.Read())
                    {
                        TenKH = reader.GetString(0);

                    }
                }

                return TenKH;


         


            }
            catch (Exception)
            {

            }

            finally
            {
                conn.Close();
            }

            return TenKH;

        }
        public string LoadMAKH(ET_KhachHang et)
        {

            string MaKH = "";
            try
            {
                conn.Open();


                SqlCommand cmd = new SqlCommand("SP_MaKH1", conn);
                cmd.CommandType = CommandType.StoredProcedure;
                SqlParameter pra = new SqlParameter("@sdt", et.SDT1);
                cmd.Parameters.Add(pra);

                using (SqlDataReader reader = cmd.ExecuteReader())
                {
                    if (reader.Read())
                    {
                        MaKH = reader.GetString(0);

                    }
                }

                return MaKH;





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
        public string LoadTenSach(ET_Sach et)
        {

            string MaS = "";
            try
            {
                conn.Open();


                SqlCommand cmd = new SqlCommand("SP_TenSach", conn);
                cmd.CommandType = CommandType.StoredProcedure;
                SqlParameter pra = new SqlParameter("@masach", et.IDSach1);
                cmd.Parameters.Add(pra);

                using (SqlDataReader reader = cmd.ExecuteReader())
                {
                    if (reader.Read())
                    {
                        MaS = reader.GetString(0);

                    }
                }

                return MaS;





            }
            catch (Exception)
            {

            }

            finally
            {
                conn.Close();
            }

            return MaS;

        }

        public int LoadDonGia(ET_Sach et)
        {

            int DonGia = 0;
            try
            {
                conn.Open();


                SqlCommand cmd = new SqlCommand("SP_TenDonGia", conn);
                cmd.CommandType = CommandType.StoredProcedure;
                SqlParameter pra = new SqlParameter("@masach", et.IDSach1);
                cmd.Parameters.Add(pra);

                using (SqlDataReader reader = cmd.ExecuteReader())
                {
                    if (reader.Read())
                    {
                        DonGia = reader.GetInt32(0);

                    }
                }

                return DonGia;





            }
            catch (Exception)
            {

            }

            finally
            {
                conn.Close();
            }

            return DonGia;

        }

        public int LoadSOluong(ET_Sach et)
        {

            int soLuong = 0;
            try
            {
                conn.Open();


                SqlCommand cmd = new SqlCommand("SP_TongSLSach", conn);
                cmd.CommandType = CommandType.StoredProcedure;
                SqlParameter pra = new SqlParameter("@masach", et.IDSach1);
                cmd.Parameters.Add(pra);

                using (SqlDataReader reader = cmd.ExecuteReader())
                {
                    if (reader.Read())
                    {
                        soLuong = reader.GetInt32(0);

                    }
                }

                return soLuong;





            }
            catch (Exception)
            {

            }

            finally
            {
                conn.Close();
            }

            return soLuong;

        }
        public int LoadHoaDon()
        {


            int Mahdct = 0;
            try
            {
                conn.Open();


                SqlCommand cmd = new SqlCommand("SP_GetMDCT", conn);
                cmd.CommandType = CommandType.StoredProcedure;
           

                using (SqlDataReader reader = cmd.ExecuteReader())
                {
                    if (reader.Read())
                    {
                        Mahdct = reader.GetInt32(0);

                    }
                }

                return Mahdct;





            }
            catch (Exception)
            {

            }

            finally
            {
                conn.Close();
            }

            return Mahdct;

        }
        public bool LoadHoaDonChiTet1(ET_HoaDonChiTiet et)
        {
            bool flag = false;

         
            try
            {
                conn.Open();


                SqlCommand cmd = new SqlCommand("SP_HoaDon", conn);
                cmd.CommandType = CommandType.StoredProcedure;
                SqlParameter pra = new SqlParameter("@mahdct", et.ID1);
                cmd.Parameters.Add(pra);

                SqlParameter praa = new SqlParameter("@masach", et.MaSach1);
                cmd.Parameters.Add(praa);
                SqlParameter praaa = new SqlParameter("@sl", et.SL1);
                cmd.Parameters.Add(praaa);

                SqlParameter praaaa = new SqlParameter("@thanhtien", et.ThanhTien1);
                cmd.Parameters.Add(praaaa);

                SqlParameter praaaaa = new SqlParameter("@mahd", et.MaHD1);
                cmd.Parameters.Add(praaaaa);

                if(cmd.ExecuteNonQuery() > 0)
                {
                    flag = true;
                }
         

             





            }
            catch (Exception)
            {

            }

            finally
            {
                conn.Close();
            }

     return flag;

        }

        public bool LoadlayMHDtrong(ET_HoaDon et)
        {
            bool flag = false;


            try
            {
                conn.Open();


                SqlCommand cmd = new SqlCommand("SP_ThemHoaDOnn", conn);
                cmd.CommandType = CommandType.StoredProcedure;
                SqlParameter pra = new SqlParameter("@mahd", et.ID1);
                cmd.Parameters.Add(pra);

                SqlParameter praa = new SqlParameter("@ngaylap", et.NgayLap1);
                cmd.Parameters.Add(praa);
                SqlParameter praaa = new SqlParameter("@makh", et.MaKH1);
                cmd.Parameters.Add(praaa);                                          

                SqlParameter praaaa = new SqlParameter("@manv", et.MaNV1);
                cmd.Parameters.Add(praaaa);

                SqlParameter praaaaa = new SqlParameter("@tongtien", et.TongTien1);
                cmd.Parameters.Add(praaaaa);

                if (cmd.ExecuteNonQuery() > 0)
                {
                    flag = true;
                }








            }
            catch (Exception)
            {

            }

            finally
            {
                conn.Close();
            }

            return flag;

        }
        public DataTable LoadHoaDonChiTiet(ET_HoaDonChiTiet et)
        {
            DataTable dataTable = new DataTable();

            try
            {
                conn.Open();


                SqlCommand cmd = new SqlCommand("SP_InhoaDonchiteit", conn);
                cmd.CommandType = CommandType.StoredProcedure;

                SqlParameter para = new SqlParameter("@mahd", et.MaHD1);
                cmd.Parameters.Add(para);

                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                adapter.Fill(dataTable);



            }
            catch (Exception)
            {

            }

            finally
            {
                conn.Close();
            }
            return dataTable;


        }
        public bool LoadUpdateTongTien(ET_HoaDon et)
        {
            bool flag = false;

            try
            {
                conn.Open();


                SqlCommand cmd = new SqlCommand("SP_UpdateTongTien", conn);
                cmd.CommandType = CommandType.StoredProcedure;

                SqlParameter para = new SqlParameter("@mahd", et.ID1);
                cmd.Parameters.Add(para);

                SqlParameter paraa = new SqlParameter("@tongtien", et.TongTien1);
                cmd.Parameters.Add(paraa);
                 
                if(cmd.ExecuteNonQuery() > 0)
                {

                    flag = true;
                }


            }
            catch (Exception)
            {

            }

            finally
            {
                conn.Close();
            }
          

            return flag;
        }
    }
}
