using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Sign_Service_Label_Products
{
    public partial class admin_auth : System.Web.UI.UserControl
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["admin_user_id"] == null)
            {
                Response.Redirect("admin_logout.aspx");
            }
        }
    }
}