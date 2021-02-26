using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DuBaoGiaDT
{
    public class DBConnect
    {
        static  string connectionString = "Data Source=DESKTOP-FNK1E3U;Initial Catalog=KTDL_DT;Integrated Security=True";
        public static DataTable loadChip()
        {
            SqlConnection conn = new SqlConnection(connectionString);
            DataTable dt = new DataTable();
            try
            {
                conn.Open();
                string sql = "select * from dbo.CHIP";
                SqlCommand cmd = new SqlCommand(sql,conn);
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(dt);
                return dt;
            }
            catch { }
            finally { conn.Close(); }
            return dt;
        }
        public static DataTable loadSanPham()
        {
            SqlConnection conn = new SqlConnection(connectionString);
            DataTable dt = new DataTable();
            try
            {
                conn.Open();
                string sql = "select * from dbo.GiaDT";
                SqlCommand cmd = new SqlCommand(sql, conn);
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(dt);
                return dt;
            }
            catch { }
            finally { conn.Close(); }
            return dt;
        }
        public static DataTable loadHang()
        {
            SqlConnection conn = new SqlConnection(connectionString);
            DataTable dt = new DataTable();
            try
            {
                conn.Open();
                string sql = "select * from dbo.HANG";
                SqlCommand cmd = new SqlCommand(sql, conn);
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(dt);
                return dt;
            }
            catch { }
            finally { conn.Close(); }
            return dt;
        }
        public static DataTable loadLoaiMH()
        {
            SqlConnection conn = new SqlConnection(connectionString);
            DataTable dt = new DataTable();
            try
            {
                conn.Open();
                string sql = "select * from dbo.LOAIMH";
                SqlCommand cmd = new SqlCommand(sql, conn);
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(dt);
                return dt;
            }
            catch { }
            finally { conn.Close(); }
            return dt;
        }
        public static double MaxPin()
        {
            SqlConnection conn = new SqlConnection(connectionString);
            try
            {
                conn.Open();
                string sql = "SELECT MAX(Pin) FROM dbo.GiaDT";
                SqlCommand cmd = new SqlCommand(sql,conn);
                return (double)cmd.ExecuteScalar();
            }
            catch { return 0; }
            finally { conn.Close(); }
        }
        public static double MinPin()
        {
            SqlConnection conn = new SqlConnection(connectionString);
            try
            {
                conn.Open();
                string sql = "SELECT MIN(Pin) FROM dbo.GiaDT";
                SqlCommand cmd = new SqlCommand(sql, conn);
                return (double)cmd.ExecuteScalar();
            }
            catch { return 0; }
            finally { conn.Close(); }
        }
        public static double MaxRam()
        {
            SqlConnection conn = new SqlConnection(connectionString);
            try
            {
                conn.Open();
                string sql = "SELECT MAX(Ram) FROM dbo.GiaDT";
                SqlCommand cmd = new SqlCommand(sql, conn);
                return (double)cmd.ExecuteScalar();
            }
            catch { return 0; }
            finally { conn.Close(); }
        }
        public static double MinRam()
        {
            SqlConnection conn = new SqlConnection(connectionString);
            try
            {
                conn.Open();
                string sql = "SELECT MIN(Ram) FROM dbo.GiaDT";
                SqlCommand cmd = new SqlCommand(sql, conn);
                return (double)cmd.ExecuteScalar();
            }
            catch { return 0; }
            finally { conn.Close(); }
        }
        public static double MaxRom()
        {
            SqlConnection conn = new SqlConnection(connectionString);
            try
            {
                conn.Open();
                string sql = "SELECT MAX(Rom) FROM dbo.GiaDT";
                SqlCommand cmd = new SqlCommand(sql, conn);
                return (double)cmd.ExecuteScalar();
            }
            catch { return 0; }
            finally { conn.Close(); }
        }
        public static double MinRom()
        {
            SqlConnection conn = new SqlConnection(connectionString);
            try
            {
                conn.Open();
                string sql = "SELECT MIN(Rom) FROM dbo.GiaDT";
                SqlCommand cmd = new SqlCommand(sql, conn);
                return (double)cmd.ExecuteScalar();
            }
            catch { return 0; }
            finally { conn.Close(); }
        }
        public static double MaxWeight()
        {
            SqlConnection conn = new SqlConnection(connectionString);
            try
            {
                conn.Open();
                string sql = "SELECT MAX(Weight) FROM dbo.GiaDT";
                SqlCommand cmd = new SqlCommand(sql, conn);
                return (double)cmd.ExecuteScalar();
            }
            catch { return 0; }
            finally { conn.Close(); }
        }
        public static double MinWeight()
        {
            SqlConnection conn = new SqlConnection(connectionString);
            try
            {
                conn.Open();
                string sql = "SELECT MIN(Weight) FROM dbo.GiaDT";
                SqlCommand cmd = new SqlCommand(sql, conn);
                return (double)cmd.ExecuteScalar();
            }
            catch { return 0; }
            finally { conn.Close(); }
        }
        public static double MaxScreen()
        {
            SqlConnection conn = new SqlConnection(connectionString);
            try
            {
                conn.Open();
                string sql = "SELECT MAX(Screen) FROM dbo.GiaDT";
                SqlCommand cmd = new SqlCommand(sql, conn);
                return (double)cmd.ExecuteScalar();
            }
            catch { return 0; }
            finally { conn.Close(); }
        }
        public static double MinScreen()
        {
            SqlConnection conn = new SqlConnection(connectionString);
            try
            {
                conn.Open();
                string sql = "SELECT MIN(Screen) FROM dbo.GiaDT";
                SqlCommand cmd = new SqlCommand(sql, conn);
                return (double)cmd.ExecuteScalar();
            }
            catch { return 0; }
            finally { conn.Close(); }
        }
        public static double MaxWidth()
        {
            SqlConnection conn = new SqlConnection(connectionString);
            try
            {
                conn.Open();
                string sql = "SELECT MAX(Width) FROM dbo.GiaDT";
                SqlCommand cmd = new SqlCommand(sql, conn);
                return (double)cmd.ExecuteScalar();
            }
            catch { return 0; }
            finally { conn.Close(); }
        }
        public static double MinWidth()
        {
            SqlConnection conn = new SqlConnection(connectionString);
            try
            {
                conn.Open();
                string sql = "SELECT MIN(Width) FROM dbo.GiaDT";
                SqlCommand cmd = new SqlCommand(sql, conn);
                return (double)cmd.ExecuteScalar();
            }
            catch { return 0; }
            finally { conn.Close(); }
        }
        public static double MaxHeight()
        {
            SqlConnection conn = new SqlConnection(connectionString);
            try
            {
                conn.Open();
                string sql = "SELECT MAX(Height) FROM dbo.GiaDT";
                SqlCommand cmd = new SqlCommand(sql, conn);
                return (double)cmd.ExecuteScalar();
            }
            catch { return 0; }
            finally { conn.Close(); }
        }
        public static double MinHeight()
        {
            SqlConnection conn = new SqlConnection(connectionString);
            try
            {
                conn.Open();
                string sql = "SELECT MIN(Height) FROM dbo.GiaDT";
                SqlCommand cmd = new SqlCommand(sql, conn);
                return (double)cmd.ExecuteScalar();
            }
            catch { return 0; }
            finally { conn.Close(); }
        }
        public static DataTable Luong2()
        {
            SqlConnection conn = new SqlConnection(connectionString);
            DataTable dt = new DataTable();
            try
            {
                conn.Open();
                string sql = "SELECT * FROM dbo.GiaDT WHERE STT BETWEEN 80 AND (SELECT MAX(STT) FROM dbo.GiaDT)";
                SqlCommand cmd = new SqlCommand(sql, conn);
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(dt);
                return dt;
            }
            catch { }
            finally { conn.Close(); }
            return dt;
        }
        public static DataTable Luong1()
        {
            SqlConnection conn = new SqlConnection(connectionString);
            DataTable dt = new DataTable();
            try
            {
                conn.Open();
                string sql = "SELECT * FROM dbo.GiaDT WHERE STT BETWEEN 1 AND 79";
                SqlCommand cmd = new SqlCommand(sql, conn);
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(dt);
                return dt;
            }
            catch { }
            finally { conn.Close(); }
            return dt;
        }
    }
}
