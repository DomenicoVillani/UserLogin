using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace UserLogin
{
    public partial class Home : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Request.Cookies["UserLogin"] != null)
            {
                Show.Text = $"{Request.Cookies["UserLogin"]["Username"]}, {Request.Cookies["UserLogin"]["Password"]}";
            }
        }

        protected void BtnLogout_Click(object sender, EventArgs e)
        {
            if (Request.Cookies["UserLogin"] != null)
            {
                HttpCookie cookie = new HttpCookie("UserLogin");
                cookie.Expires = DateTime.Now.AddDays(-1);
                Response.Cookies.Add(cookie);
                Response.Redirect("Login.aspx");
            }
        }
    }
}