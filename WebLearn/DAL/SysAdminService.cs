using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Models;
using System.Data;
using System.Data.SqlClient;

namespace DAL
{
    public class SysAdminService
    {
        /// <summary>
        /// 根据账号密码登录
        /// </summary>
        /// <param name="objAdmin"></param>
        /// <returns></returns>
        public SysAdmin GetAdminName(SysAdmin objAdmin)
        {
            string sql = "SELECT AdminName FROM SMDBWeb.dbo.Admins WHERE  LoinId = '{0}' AND LoginPwd = '{1}'";
            string.Format(sql, objAdmin.LoginId, objAdmin.AdminPwd);
            try
            {
                SqlDataReader objReader = SQLHelper.GetReader(sql);
                if (objReader.Read())
                {
                    objAdmin.AdminName = objReader["AdminName"].ToString();
                    objReader.Close();
                }
                else
                {
                    objAdmin = null;
                }
            }
            catch (Exception ex)
            {

                throw ex;
            }
            return objAdmin;
        }
    }
}
