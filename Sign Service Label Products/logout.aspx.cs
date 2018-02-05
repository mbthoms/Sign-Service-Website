using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Sign_Service_Label_Products
{
    public partial class logout : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            //kill the session
            Session["user_id"] = null;
            Session.Abandon();

            //redirect to landing page.
            Response.Redirect("login.aspx");
        }
    }
}