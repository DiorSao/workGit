using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Models;
using BLL;

namespace WebLearn.Controllers
{
    public class SysAdminController : Controller
    {
        // GET: SysAdmin
        public ActionResult Index()
        {
            return View("AdminLogin");
        }
        public ActionResult AdminLogin()
        {
            SysAdmin sysAdmin = new SysAdmin()
            {
                LoginId = Convert.ToInt16(Request.Params["loginId"]),
                AdminPwd = Request.Params["loginPwd"].ToString()
            };
            //调用业务逻辑
            sysAdmin = new SysAdminManager().AdminLogin(sysAdmin);
            if (sysAdmin != null)
            {
                ViewData["info"] = "欢迎您：" + sysAdmin.AdminName;
            }
            else
            {
                ViewData["info"] = "用户名或密码错误！";
            }
            return View();
        }
    }
}