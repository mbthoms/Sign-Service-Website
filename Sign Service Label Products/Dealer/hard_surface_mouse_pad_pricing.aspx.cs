using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Sign_Service_Label_Products.dealer
{
    public partial class hard_surface_mouse_pad_pricing : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            //Hides the Message if showing when you press the "Get Quote" button in the quote template.
            if (IsPostBack)
            {
                lblCustomQuoteMessage.Text = "";
            }
        }

        protected void btnFindPrices_Click(object sender, EventArgs e)
        {
            //======================================================================================================
            //Pricing
            //======================================================================================================

            Double Price_50Quantity = 280.00;
            Double Price_100Quantity = 370.00;
            Double Price_250Quantity = 765.00;
            Double Price_500Quantity = 1440.00;
            Double Price_1000Quantity = 2790.00;
            Double Price_2000_Quantity = 5415.00;

            //======================================================================================================
            // If Statements
            //======================================================================================================

            //50 Quantity If Statements
            //======================================================================================================

            Double Subtotal = 0;

            if (ddlLabelQuantities.SelectedValue == "50")
            {
                Subtotal = Price_50Quantity;
            }

            if (ddlLabelQuantities.SelectedValue == "100")
            {
                Subtotal = Price_100Quantity;
            }

            if (ddlLabelQuantities.SelectedValue == "250")
            {
                Subtotal = Price_250Quantity;
            }

            if (ddlLabelQuantities.SelectedValue == "500")
            {
                Subtotal = Price_500Quantity;
            }

            if (ddlLabelQuantities.SelectedValue == "1000")
            {
                Subtotal = Price_1000Quantity;
            }

            if (ddlLabelQuantities.SelectedValue == "2000")
            {
                Subtotal = Price_2000_Quantity;
            }

            //Calculating the Total Cost.
            Decimal Total = Convert.ToDecimal(Subtotal);
            //formating the numbers that are displays to .00, this is done so people will know that it's money. 
            Total = Convert.ToDecimal(string.Format("{0:0.00}", Total));

            //Displaying the Total Price.
            lblTotal.Text = "Total:" + " " + "$" + Total.ToString() + "*";

        }
    }
}