using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Configuration;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Epicode_U4_W3_D2
{
    public partial class _default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Request.Cookies["User_Session"] != null)
                Response.Redirect("main.aspx");
        }

        protected void Login_Click(object sender, EventArgs e)
        {
            string Username = WebConfigurationManager.AppSettings["User"];
            string Password = WebConfigurationManager.AppSettings["Password"];

            string inputUser = User.Text;      //Alessio
            string inputPassword = Pass.Value; //alessio123

            if (Username == inputUser && Password == inputPassword)
            {
                HttpCookie cookie = new HttpCookie("User_Session");
                cookie.Values["Nome"] = Username;       
                cookie.Values["Password"] = Password;   
                cookie.Expires = DateTime.Now.AddDays(1);
                Response.Cookies.Add(cookie);

                Response.Redirect("main.aspx");
            }
            else
                Response.Redirect(Request.Url.ToString());
        }


        /*
        protected void Button2_Click(object sender, EventArgs e)
        {
            HttpCookie cookie = new HttpCookie("ASPNET_COOKIE");
            cookie.Values["nome"] = Nome.Text;
            cookie.Values["cognome"] = Cognome.Text;
            cookie.Expires = DateTime.Now.AddDays(10);
            Response.Cookies.Add(cookie);
        }

        protected void Button3_Click(object sender, EventArgs e)
        {
            if (Request.Cookies["ASPNET_COOKIE"] != null)
            {
                Request.Cookies["ASPNET_COOKIE"].Expires = DateTime.Now.AddDays(-1);
                Response.Cookies.Add(Request.Cookies["ASPNET_COOKIE"]);
            }
        }

        */

    }
}