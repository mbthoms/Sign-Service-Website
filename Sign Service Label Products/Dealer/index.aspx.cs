using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Sign_Service_Label_Products.Dealer
{
    public partial class dealer_index : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            lblDealerIndexTitle.Text = "Thank-you " + Session["contact_name"] + " " + "for Entering our Dealer Section!";
        }
    }
}