using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace UserLogin
{
    public partial class Login : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void BtnLogin_Click(object sender, EventArgs e)
        {
            HttpCookie cookie = new HttpCookie("UserLogin");
            cookie.Values["Username"] = TextUser.Text;
            cookie.Values["Password"] = TextPass.Text;
            cookie.Expires = DateTime.Now.AddDays(1);
            Response.Cookies.Add(cookie);
            Response.Redirect("Home.aspx");
        }
    }
}