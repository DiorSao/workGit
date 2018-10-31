using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;
namespace DAL
{
    /// <summary>
    /// 通用数据访问类
    /// </summary>
    class SQLHelper
    {
        private static readonly string connString = ConfigurationManager.ConnectionStrings["connString"].ToString();
        /// <summary>
        /// 对数据进行赠删改
        /// </summary>
        /// <param name="sql">T-SQL语句</param>
        /// <returns></returns>
        public static int Update(string sql)
        {
            int result = 0;
            SqlConnection conn = new SqlConnection(connString);
            SqlCommand cmd = new SqlCommand(sql,conn);
            try
            {
                conn.Open();
                result = cmd.ExecuteNonQuery();
                return result;
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                conn.Close();
            }
        }
        /// <summary>
        /// 得到单一结果
        /// </summary>
        /// <param name="sql"></param>
        /// <returns></returns>
        public static object GetSingleResult(string sql)
        {
            SqlConnection conn = new SqlConnection(connString);
            SqlCommand cmd = new SqlCommand(sql, conn);
            try
            {
                conn.Open();
                return cmd.ExecuteScalar();
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                conn.Close();
            }
        }
        /// <summary>
        /// 得到结果集
        /// </summary>
        /// <param name="sql"></param>
        /// <returns></returns>
        public static SqlDataReader GetReader(string sql)
        {
            SqlConnection conn = new SqlConnection();
            SqlCommand cmd = new SqlCommand(sql,conn);
            try
            {
                return cmd.ExecuteReader(CommandBehavior.CloseConnection);
            }
            catch (Exception)
            {
                conn.Close();
                throw;
            }
        }
    }
}
