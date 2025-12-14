using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using ET_QLNhaSach;
namespace DAL_QLNhaSach
{
    public class DAL_QLSach
    {
        SqlConnection conn = new SqlConnection("Data Source=PHUCKK\\SQLEXPRESS;Initial Catalog=QLNS;Integrated Security=True");



        public DataTable LoadTheLoai()
        {
            DataTable dt = new DataTable();
            try
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand("SP_TheLoai", conn);
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
        public DataTable LoadNhaxuatBan()
        {
            DataTable dt = new DataTable();
            try
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand("SP_Nhaxuatban", conn);
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
        public DataTable LoadDSsach()
        {
            DataTable dt = new DataTable();
            try
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand("SP_DSsach", conn);
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
        public bool LoadThem(ET_Sach et)
        {

            bool flag = false;



            try
            {
                conn.Open();

                SqlCommand sqlCommand = new SqlCommand("SP_ThemSach", conn);
                //(@masach varchar(50), @ten varchar(100), @tacgia varchar(100),@dongia int, @sl int, @theloai int, @nhaxb int)
                  sqlCommand.CommandType = CommandType.StoredProcedure;

                SqlParameter pra = new SqlParameter("@masach", et.IDSach1);
                sqlCommand.Parameters.Add(pra);
                SqlParameter praa = new SqlParameter("@ten", et.TenSach1);
                sqlCommand.Parameters.Add(praa);
                SqlParameter pra2 = new SqlParameter("@tacgia", et.TacGia1);
                sqlCommand.Parameters.Add(pra2);
                SqlParameter pra3 = new SqlParameter("@dongia", et.DonGia1);
                sqlCommand.Parameters.Add(pra3);
                SqlParameter pra4 = new SqlParameter("@sl", et.TongSL1);
                sqlCommand.Parameters.Add(pra4);
                SqlParameter pra5 = new SqlParameter("@theloai", et.TheLoaiId1);
                sqlCommand.Parameters.Add(pra5);
                SqlParameter pra6 = new SqlParameter("@nhaxb", et.NXBId1);
                sqlCommand.Parameters.Add(pra6);

                if(sqlCommand.ExecuteNonQuery() > 0)
                {
                    flag = true;
                }

            } catch (Exception) { }

            finally
            {
                conn.Close();
            }

            return flag;
        }
        public DataTable TimSach(ET_Sach et)
        {
          DataTable dt = new DataTable();
       
            try
            {
                conn.Open();

                SqlCommand cmd = new SqlCommand("SP_TimSach10", conn);
                cmd.CommandType = CommandType.StoredProcedure;

                SqlParameter pra = new SqlParameter("@masach", et.IDSach1);
                cmd.Parameters.Add(pra);
 

                SqlDataAdapter da = new SqlDataAdapter(cmd);
                    da.Fill(dt);
                
           
            
           

          

        

            }catch (Exception) { }

            finally
            {
                conn.Close( );
            }
            return dt;
        }

        public bool XoaSach(ET_Sach et)
        {
            bool flag = false;
            try
            {
                conn.Open();

                SqlCommand cmd = new SqlCommand("SP_XoaSach", conn);
                cmd.CommandType = CommandType.StoredProcedure;

                SqlParameter pra = new SqlParameter("@masach", et.IDSach1);
                cmd.Parameters.Add(pra);

                 if(cmd.ExecuteNonQuery()> 0)
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
        public bool LoadUpdate(ET_Sach et)
        {

            bool flag = false;



            try
            {
                conn.Open();

                SqlCommand sqlCommand = new SqlCommand("SP_SuaSach", conn);
                //(@masach varchar(50), @ten varchar(100), @tacgia varchar(100),@dongia int, @sl int, @theloai int, @nhaxb int)
                sqlCommand.CommandType = CommandType.StoredProcedure;

                SqlParameter pra = new SqlParameter("@masach", et.IDSach1);
                sqlCommand.Parameters.Add(pra);
                SqlParameter praa = new SqlParameter("@ten", et.TenSach1);
                sqlCommand.Parameters.Add(praa);
                SqlParameter pra2 = new SqlParameter("@tacgia", et.TacGia1);
                sqlCommand.Parameters.Add(pra2);
                SqlParameter pra3 = new SqlParameter("@dongia", et.DonGia1);
                sqlCommand.Parameters.Add(pra3);
                SqlParameter pra4 = new SqlParameter("@sl", et.TongSL1);
                sqlCommand.Parameters.Add(pra4);
                SqlParameter pra5 = new SqlParameter("@theloai", et.TheLoaiId1);
                sqlCommand.Parameters.Add(pra5);
                SqlParameter pra6 = new SqlParameter("@nhaxb", et.NXBId1);
                sqlCommand.Parameters.Add(pra6);

                if (sqlCommand.ExecuteNonQuery() > 0)
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
        public DataTable LoadAdenZ()
        {
            DataTable dt = new DataTable();
            try
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand("SP_XStang", conn);
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
        public DataTable LoadZdenA()
        {
            DataTable dt = new DataTable();
            try
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand("SP_XSgiam", conn);
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
        public bool UpdateSach(ET_Sach et)
        {
            bool flag = false;

            try
            {
                conn.Open();
                SqlCommand sqlCommand = new SqlCommand("SP_Update", conn);
                sqlCommand.CommandType = CommandType.StoredProcedure;

                SqlParameter pra = new SqlParameter("@masach", et.IDSach1);
                sqlCommand.Parameters.Add(pra);
                SqlParameter pra2 = new SqlParameter("@sl", et.TongSL1);
                sqlCommand.Parameters.Add(pra2);

                if(sqlCommand.ExecuteNonQuery() >  0)
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
    }

}
