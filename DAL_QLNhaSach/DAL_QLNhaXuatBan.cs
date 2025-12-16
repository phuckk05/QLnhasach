using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using ET_QLNhaSach;
using System.Web;

namespace DAL_QLNhaSach
{
    public class DAL_QLNhaXuatBan
    {
        SqlConnection conn = new SqlConnection("Data Source=PHUCKK\\SQLEXPRESS;Initial Catalog=QLNS;Integrated Security=True");


        public DataTable LayTenSB()
        {
            DataTable dataTable = new DataTable();

            try
            {
                conn.Open();

                SqlCommand cmd = new SqlCommand("SP_LayNXB2",conn);
                cmd.CommandType = CommandType.StoredProcedure;


                SqlDataAdapter dap = new SqlDataAdapter(cmd);
                dap.Fill(dataTable);
            

            }catch (Exception) { }

            finally { conn.Close(); }

            return dataTable;
        }
        public DataTable LoadDSNXB()
        {
            DataTable DSNXB = new DataTable();
            try
            {

                conn.Open();

                SqlCommand cmd = new SqlCommand("sp_LayDSNXB", conn);
                cmd.CommandType = CommandType.StoredProcedure;

                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                adapter.Fill(DSNXB);

                return DSNXB;

            }
            catch (Exception) { }


            finally
            {
                conn.Close();
            }
            return DSNXB;
        }
        public bool ThemNhaXuatBan(ET_NhaXuatBan et)
        {
            bool flag = false;
            try
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand("sp_Themnhaxuatban", conn);
                cmd.CommandType = CommandType.StoredProcedure;

                SqlParameter prama = new SqlParameter("@nhaxbid", et.ID1);
                cmd.Parameters.Add(prama);

                SqlParameter pratennxb = new SqlParameter("@tennxb", et.TenNXB1);
                cmd.Parameters.Add(pratennxb);

                SqlParameter praemail = new SqlParameter("@email", et.Email1);
                cmd.Parameters.Add(praemail);

                SqlParameter pradiachi = new SqlParameter("@diachi", et.DiaChi1);
                cmd.Parameters.Add(pradiachi);

                SqlParameter prasodt = new SqlParameter("@sodt", et.SDT1);
                cmd.Parameters.Add(prasodt);

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

        public bool XoaNhaXuatBan(ET_NhaXuatBan et)
        {
            bool flag = false;
            try
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand("sp_Xoanhaxuatban", conn);
                cmd.CommandType = CommandType.StoredProcedure;

                SqlParameter prama = new SqlParameter("@nhaxbid", et.ID1);
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

        public bool SuaNhaXuatBan(ET_NhaXuatBan et)
        {
            bool flag = false;
            try
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand("sp_Suanhaxuatban", conn);
                cmd.CommandType = CommandType.StoredProcedure;

                SqlParameter prama = new SqlParameter("@nhaxbid", et.ID1);
                cmd.Parameters.Add(prama);

                SqlParameter pratennxb = new SqlParameter("@tennxb", et.TenNXB1);
                cmd.Parameters.Add(pratennxb);

                SqlParameter praemail = new SqlParameter("@email", et.Email1);
                cmd.Parameters.Add(praemail);

                SqlParameter pradiachi = new SqlParameter("@diachi", et.DiaChi1);
                cmd.Parameters.Add(pradiachi);

                SqlParameter prasodt = new SqlParameter("@sodt", et.SDT1);
                cmd.Parameters.Add(prasodt);

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
        public DataTable TimNhaXuatBan(ET_NhaXuatBan et)
        {
            DataTable dt = new DataTable();
            DataTable dt2 = new DataTable("0");
            try
            {
                conn.Open();

                SqlCommand cmd = new SqlCommand("SP_TimNXBBB", conn);
                cmd.CommandType = CommandType.StoredProcedure;

                SqlParameter prama = new SqlParameter("@nhaxbid", et.ID1);
                cmd.Parameters.Add(prama);


                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(dt);









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
