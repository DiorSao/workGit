using Microsoft.Analytics.Interfaces;
using Microsoft.Analytics.Types.Sql;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using DAL;
using Models;
using System.Web;

namespace BLL
{
    public class SysAdminManager
    {
        SysAdminService sysAdminService = new SysAdminService();
        /// <summary>
        /// Admin用户登录
        /// </summary>
        /// <param name="objAdmin"></param>
        /// <returns></returns>
        public SysAdmin AdminLogin(SysAdmin objAdmin)
        {
            objAdmin = sysAdminService.GetAdminName(objAdmin);
            if (objAdmin != null)
            {
                //保存登录信息
                HttpContext.Current.Session["currentAdmin"] = objAdmin;
            }
            return objAdmin;
        }
    }
}