using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Sign_Service_Label_Products.admin
{
    public partial class admin_logout : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            //kill the session
            Session["admin_user_id"] = null;
            Session.Abandon();

            //redirect to landing page.
            Response.Redirect("admin_login.aspx");
        }
    }
}