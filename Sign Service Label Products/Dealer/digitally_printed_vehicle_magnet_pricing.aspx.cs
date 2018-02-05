using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Sign_Service_Label_Products.dealer
{
    public partial class digitally_printed_vehicle_magnet_pricing : System.Web.UI.Page
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

            //2 Quantity
            Double Size12x14_2Quantity = 105.00;
            Double Size11x18_2Quantity = 120.00;

            //4 Quantity
            Double Size12x14_4Quantity = 150.00;
            Double Size11x18_4Quantity = 160.00;

            //6 Quantity
            Double Size12x14_6Quantity = 195.00;
            Double Size11x18_6Quantity = 200.00;

            //8 Quantity
            Double Size12x14_8Quantity = 240.00;
            Double Size11x18_8Quantity = 250.00;

            //10 Quantity
            Double Size12x14_10Quantity = 295.00;
            Double Size11x18_10Quantity = 300.00;


            //2 Quantity If Statements
            //======================================================================================================
            if (ddlLabelSize.SelectedValue == "1" && ddlLabelQuantities.SelectedValue == "2")
            {
                Double Subtotal = 0;
                Subtotal = Size12x14_2Quantity;
                
                //Calculating the Total Cost.
                Decimal Total = Convert.ToDecimal(Subtotal);
                //formating the numbers that are displays to .00, this is done so people will know that it's money. 
                Total = Convert.ToDecimal(string.Format("{0:0.00}", Total));

                //Displaying the Total Price.
                lblTotal.Text = "Total:" + " " + "$" + Total.ToString() + "*";
            }

            if (ddlLabelSize.SelectedValue == "2" && ddlLabelQuantities.SelectedValue == "2")
            {
                Double Subtotal = 0;
                Subtotal = Size11x18_2Quantity;

                //Calculating the Total Cost.
                Decimal Total = Convert.ToDecimal(Subtotal);
                //formating the numbers that are displays to .00, this is done so people will know that it's money. 
                Total = Convert.ToDecimal(string.Format("{0:0.00}", Total));

                //Displaying the Total Price.
                lblTotal.Text = "Total:" + " " + "$" + Total.ToString() + "*";
            }


            //4 Quantity If Statements
            //======================================================================================================
            if (ddlLabelSize.SelectedValue == "1" && ddlLabelQuantities.SelectedValue == "4")
            {
                Double Subtotal = 0;
                Subtotal = Size12x14_4Quantity;

                //Calculating the Total Cost.
                Decimal Total = Convert.ToDecimal(Subtotal);
                //formating the numbers that are displays to .00, this is done so people will know that it's money. 
                Total = Convert.ToDecimal(string.Format("{0:0.00}", Total));

                //Displaying the Total Price.
                lblTotal.Text = "Total:" + " " + "$" + Total.ToString() + "*";
            }

            if (ddlLabelSize.SelectedValue == "2" && ddlLabelQuantities.SelectedValue == "4")
            {
                Double Subtotal = 0;
                Subtotal = Size11x18_4Quantity;

                //Calculating the Total Cost.
                Decimal Total = Convert.ToDecimal(Subtotal);
                //formating the numbers that are displays to .00, this is done so people will know that it's money. 
                Total = Convert.ToDecimal(string.Format("{0:0.00}", Total));

                //Displaying the Total Price.
                lblTotal.Text = "Total:" + " " + "$" + Total.ToString() + "*";
            }

            //6 Quantity If Statements
            //======================================================================================================
            if (ddlLabelSize.SelectedValue == "1" && ddlLabelQuantities.SelectedValue == "6")
            {
                Double Subtotal = 0;
                Subtotal = Size12x14_6Quantity;

                //Calculating the Total Cost.
                Decimal Total = Convert.ToDecimal(Subtotal);
                //formating the numbers that are displays to .00, this is done so people will know that it's money. 
                Total = Convert.ToDecimal(string.Format("{0:0.00}", Total));

                //Displaying the Total Price.
                lblTotal.Text = "Total:" + " " + "$" + Total.ToString() + "*";
            }

            if (ddlLabelSize.SelectedValue == "2" && ddlLabelQuantities.SelectedValue == "6")
            {
                Double Subtotal = 0;
                Subtotal = Size11x18_6Quantity;

                //Calculating the Total Cost.
                Decimal Total = Convert.ToDecimal(Subtotal);
                //formating the numbers that are displays to .00, this is done so people will know that it's money. 
                Total = Convert.ToDecimal(string.Format("{0:0.00}", Total));

                //Displaying the Total Price.
                lblTotal.Text = "Total:" + " " + "$" + Total.ToString() + "*";
            }

            //8 Quantity If Statements
            //======================================================================================================
            if (ddlLabelSize.SelectedValue == "1" && ddlLabelQuantities.SelectedValue == "8")
            {
                Double Subtotal = 0;
                Subtotal = Size12x14_8Quantity;

                //Calculating the Total Cost.
                Decimal Total = Convert.ToDecimal(Subtotal);
                //formating the numbers that are displays to .00, this is done so people will know that it's money. 
                Total = Convert.ToDecimal(string.Format("{0:0.00}", Total));

                //Displaying the Total Price.
                lblTotal.Text = "Total:" + " " + "$" + Total.ToString() + "*";
            }

            if (ddlLabelSize.SelectedValue == "2" && ddlLabelQuantities.SelectedValue == "8")
            {
                Double Subtotal = 0;
                Subtotal = Size11x18_8Quantity;
                //Calculating the Total Cost.
                Decimal Total = Convert.ToDecimal(Subtotal);
                //formating the numbers that are displays to .00, this is done so people will know that it's money. 
                Total = Convert.ToDecimal(string.Format("{0:0.00}", Total));

                //Displaying the Total Price.
                lblTotal.Text = "Total:" + " " + "$" + Total.ToString() + "*";
            }

            //10 Quantity If Statements
            //======================================================================================================
            if (ddlLabelSize.SelectedValue == "1" && ddlLabelQuantities.SelectedValue == "10")
            {
                Double Subtotal = 0;
                Subtotal = Size12x14_10Quantity;

                //Calculating the Total Cost.
                Decimal Total = Convert.ToDecimal(Subtotal);
                //formating the numbers that are displays to .00, this is done so people will know that it's money. 
                Total = Convert.ToDecimal(string.Format("{0:0.00}", Total));

                //Displaying the Total Price.
                lblTotal.Text = "Total:" + " " + "$" + Total.ToString() + "*";
            }

            if (ddlLabelSize.SelectedValue == "2" && ddlLabelQuantities.SelectedValue == "10")
            {
                Double Subtotal = 0;
                Subtotal = Size11x18_10Quantity;

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