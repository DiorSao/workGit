using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Models;
using BLL;

namespace StudentManagerMVC.Controllers
{
    public class SysAdminController : Controller
    {
        //
        // GET: /SysAdmin/

        public ActionResult Index()
        {
            return View("AdminLogin");
        }
        /// <summary>
        /// 用户登录动作方法
        /// </summary>
        /// <returns></returns>
        public ActionResult AdminLogin()
        {
            //获取用户输入的数据
            SysAdmin objAdmin = new SysAdmin()
            {
                LoginId = Convert.ToInt32(Request.Params["loginId"]),
                LoginPwd = Request.Params["loginPwd"]
            };
            //调用业务逻辑
            objAdmin = new SysAdminManager().AdminLogin(objAdmin);
            if (objAdmin != null)
            {
                ViewData["info"] = "欢迎您：" + objAdmin.AdminName;
            }
            else
            {
                ViewData["info"] = "用户名或密码错误！";
            }
            return View();
        }

    }
}
