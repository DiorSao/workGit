<%@ Page Language="C#" Inherits="System.Web.Mvc.ViewPage<dynamic>" %>

<!DOCTYPE html>

<html>
<head>
    <meta name="viewport" content="width=device-width" />
    <title>管理员登录</title>
</head>
<body>
    <form method="post" action="/SysAdmin/AdminLogin">
        <div>
            用户名：<input name="loginId" type="text" />
            密码：<input  name="loginPwd" type="password" />
            <input  type="submit" value="登录" />
        </div>
        <br />
        <div>     
            <%=ViewData["info"] %>       
        </div>
        <br />
        <a href="#">学员管理</a>
    </form>
</body>
</html>
