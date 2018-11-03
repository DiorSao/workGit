using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DAL;
using Models;
using System.Web;

namespace BLL
{
    public class SysAdminManager
    {
        private SysAdminService objAdminService = new SysAdminService();

        /// <summary>
        /// 根据登录账号和密码登录
        /// </summary>
        /// <param name="objAdmin"></param>
        /// <returns></returns>
        public SysAdmin AdminLogin(SysAdmin objAdmin)
        {
            objAdmin = objAdminService.AdminLogin(objAdmin);
            if (objAdmin != null)
            {
                //将登录对象保存Session
                HttpContext.Current.Session["CurrentAdmin"] = objAdmin;
            }
            return objAdmin;
        }
    }
}
