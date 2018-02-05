using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Sign_Service_Label_Products.dealer
{
    public partial class digitally_printed_magnets_pricing : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            //Hides the Message if showing when you press the "Get Quote" button in the quote page template.
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

            Double Size35x2_100Quantity = 110.00;
            Double Size35x2_250Quantity = 130.00;
            Double Size35x2_500Quantity = 160.00;
            Double Size35x2_1000Quantity = 235.00;
            Double Size35x2_2500Quantity = 488.00;
            Double Size35x2_5000Quantity = 900.00;
            Double Size35x2_10000Quantity = 1600.00;

            //100 Quantity
            if (ddlLabelSize.SelectedValue == "1" && ddlLabelQuantities.SelectedValue == "100")
            {
                Double Subtotal = 0;
                Subtotal = Size35x2_100Quantity;

                //Calculating the Total Cost.
                Decimal Total = Convert.ToDecimal(Subtotal);
                //formating the numbers that are displays to .00, this is done so people will know that it's money. 
                Total = Convert.ToDecimal(string.Format("{0:0.00}", Total));

                //Displaying the Total Price.
                lblTotal.Text = "Total:" + " " + "$" + Total.ToString() + "*";
            }
            //250 Quantity
            if (ddlLabelSize.SelectedValue == "1" && ddlLabelQuantities.SelectedValue == "250")
            {
                Double Subtotal = 0;
                Subtotal = Size35x2_250Quantity;

                //Calculating the Total Cost.
                Decimal Total = Convert.ToDecimal(Subtotal);
                //formating the numbers that are displays to .00, this is done so people will know that it's money. 
                Total = Convert.ToDecimal(string.Format("{0:0.00}", Total));

                //Displaying the Total Price.
                lblTotal.Text = "Total:" + " " + "$" + Total.ToString() + "*";
            }

            //500 Quantity
            if (ddlLabelSize.SelectedValue == "1" && ddlLabelQuantities.SelectedValue == "500")
            {
                Double Subtotal = 0;
                Subtotal = Size35x2_500Quantity;

                //Calculating the Total Cost.
                Decimal Total = Convert.ToDecimal(Subtotal);
                //formating the numbers that are displays to .00, this is done so people will know that it's money. 
                Total = Convert.ToDecimal(string.Format("{0:0.00}", Total));

                //Displaying the Total Price.
                lblTotal.Text = "Total:" + " " + "$" + Total.ToString() + "*";
            }

            //1000 Quantity
            if (ddlLabelSize.SelectedValue == "1" && ddlLabelQuantities.SelectedValue == "1000")
            {
                Double Subtotal = 0;
                Subtotal = Size35x2_1000Quantity;

                //Calculating the Total Cost.
                Decimal Total = Convert.ToDecimal(Subtotal);
                //formating the numbers that are displays to .00, this is done so people will know that it's money. 
                Total = Convert.ToDecimal(string.Format("{0:0.00}", Total));

                //Displaying the Total Price.
                lblTotal.Text = "Total:" + " " + "$" + Total.ToString() + "*";
            }

            //2500 Quantity
            if (ddlLabelSize.SelectedValue == "1" && ddlLabelQuantities.SelectedValue == "2500")
            {
                Double Subtotal = 0;
                Subtotal = Size35x2_2500Quantity;

                //Calculating the Total Cost.
                Decimal Total = Convert.ToDecimal(Subtotal);
                //formating the numbers that are displays to .00, this is done so people will know that it's money. 
                Total = Convert.ToDecimal(string.Format("{0:0.00}", Total));

                //Displaying the Total Price.
                lblTotal.Text = "Total:" + " " + "$" + Total.ToString() + "*";
            }

            //5000 Quantity
            if (ddlLabelSize.SelectedValue == "1" && ddlLabelQuantities.SelectedValue == "5000")
            {
                Double Subtotal = 0;
                Subtotal = Size35x2_5000Quantity;

                //Calculating the Total Cost.
                Decimal Total = Convert.ToDecimal(Subtotal);
                //formating the numbers that are displays to .00, this is done so people will know that it's money. 
                Total = Convert.ToDecimal(string.Format("{0:0.00}", Total));

                //Displaying the Total Price.
                lblTotal.Text = "Total:" + " " + "$" + Total.ToString() + "*";
            }

            //10000 Quantity
            if (ddlLabelSize.SelectedValue == "1" && ddlLabelQuantities.SelectedValue == "10000")
            {
                Double Subtotal = 0;
                Subtotal = Size35x2_10000Quantity;

                //Calculating the Total Cost.
                Decimal Total = Convert.ToDecimal(Subtotal);
                //formating the numbers that are displays to .00, this is done so people will know that it's money. 
                Total = Convert.ToDecimal(string.Format("{0:0.00}", Total));

                //Displaying the Total Price.
                lblTotal.Text = "Total:" + " " + "$" + Total.ToString() + "*";
            }
        }
    }
}