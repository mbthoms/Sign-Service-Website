using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Sign_Service_Label_Products.dealer
{
    public partial class floor_graphics_pricing : System.Web.UI.Page
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

            //5 Quantity
            Double Size12x12_5Quantity = 95.00;
            Double Size12x24_5Quantity = 131.00;

            //10 Quantity
            Double Size12x12_10Quantity = 132.00;
            Double Size12x24_10Quantity = 205.00;

            //25 Quantity
            Double Size12x12_25Quantity = 232.00;
            Double Size12x24_25Quantity = 376.00;

            //50 Quantity
            Double Size12x12_50Quantity = 380.00;
            Double Size12x24_50Quantity = 591.00;

            //100 Quantity
            Double Size12x12_100Quantity = 600.00;
            Double Size12x24_100Quantity = 1028.00;

            //250 Quantity
            Double Size12x12_250Quantity = 1292.00;
            Double Size12x24_250Quantity = 2103.00;

            //500 Quantity
            Double Size12x12_500Quantity = 2135.00;
            Double Size12x24_500Quantity = 3633.00;

            //======================================================================================================
            //12 x 12 Size If Statments
            //======================================================================================================

            //5 Quantity If Statements
            //======================================================================================================
            if (ddlLabelSize.SelectedValue == "1" && ddlLabelQuantities.SelectedValue == "5")
            {
                Double Subtotal = 0;
                Subtotal = Size12x12_5Quantity;

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
                Subtotal = Size12x12_10Quantity;

                //Calculating the Total Cost.
                Decimal Total = Convert.ToDecimal(Subtotal);
                //formating the numbers that are displays to .00, this is done so people will know that it's money. 
                Total = Convert.ToDecimal(string.Format("{0:0.00}", Total));

                //Displaying the Total Price.
                lblTotal.Text = "Total:" + " " + "$" + Total.ToString() + "*";
            }

            //25 Quantity If Statements
            //======================================================================================================
            if (ddlLabelSize.SelectedValue == "1" && ddlLabelQuantities.SelectedValue == "25")
            {
                Double Subtotal = 0;
                Subtotal = Size12x12_25Quantity;

                //Calculating the Total Cost.
                Decimal Total = Convert.ToDecimal(Subtotal);
                //formating the numbers that are displays to .00, this is done so people will know that it's money. 
                Total = Convert.ToDecimal(string.Format("{0:0.00}", Total));

                //Displaying the Total Price.
                lblTotal.Text = "Total:" + " " + "$" + Total.ToString() + "*";
            }

            //50 Quantity If Statements
            //======================================================================================================
            if (ddlLabelSize.SelectedValue == "1" && ddlLabelQuantities.SelectedValue == "50")
            {
                Double Subtotal = 0;
                Subtotal = Size12x12_50Quantity;

                //Calculating the Total Cost.
                Decimal Total = Convert.ToDecimal(Subtotal);
                //formating the numbers that are displays to .00, this is done so people will know that it's money. 
                Total = Convert.ToDecimal(string.Format("{0:0.00}", Total));

                //Displaying the Total Price.
                lblTotal.Text = "Total:" + " " + "$" + Total.ToString() + "*";
            }

            //100 Quantity If Statements
            //======================================================================================================
            if (ddlLabelSize.SelectedValue == "1" && ddlLabelQuantities.SelectedValue == "100")
            {
                Double Subtotal = 0;
                Subtotal = Size12x12_100Quantity;

                //Calculating the Total Cost.
                Decimal Total = Convert.ToDecimal(Subtotal);
                //formating the numbers that are displays to .00, this is done so people will know that it's money. 
                Total = Convert.ToDecimal(string.Format("{0:0.00}", Total));

                //Displaying the Total Price.
                lblTotal.Text = "Total:" + " " + "$" + Total.ToString() + "*";
            }

            //250 Quantity If Statements
            //======================================================================================================
            if (ddlLabelSize.SelectedValue == "1" && ddlLabelQuantities.SelectedValue == "250")
            {
                Double Subtotal = 0;
                Subtotal = Size12x12_250Quantity;

                //Calculating the Total Cost.
                Decimal Total = Convert.ToDecimal(Subtotal);
                //formating the numbers that are displays to .00, this is done so people will know that it's money. 
                Total = Convert.ToDecimal(string.Format("{0:0.00}", Total));

                //Displaying the Total Price.
                lblTotal.Text = "Total:" + " " + "$" + Total.ToString() + "*";
            }

            //500 Quantity If Statements
            //======================================================================================================
            if (ddlLabelSize.SelectedValue == "1" && ddlLabelQuantities.SelectedValue == "500")
            {
                Double Subtotal = 0;
                Subtotal = Size12x12_500Quantity;

                //Calculating the Total Cost.
                Decimal Total = Convert.ToDecimal(Subtotal);
                //formating the numbers that are displays to .00, this is done so people will know that it's money. 
                Total = Convert.ToDecimal(string.Format("{0:0.00}", Total));

                //Displaying the Total Price.
                lblTotal.Text = "Total:" + " " + "$" + Total.ToString() + "*";
            }

            //======================================================================================================
            //12 x 24 Size If Statments
            //======================================================================================================



            //5 Quantity If Statements
            //======================================================================================================
            if (ddlLabelSize.SelectedValue == "2" && ddlLabelQuantities.SelectedValue == "5")
            {
                Double Subtotal = 0;
                Subtotal = Size12x24_5Quantity;

                //Calculating the Total Cost.
                Decimal Total = Convert.ToDecimal(Subtotal);
                //formating the numbers that are displays to .00, this is done so people will know that it's money. 
                Total = Convert.ToDecimal(string.Format("{0:0.00}", Total));

                //Displaying the Total Price.
                lblTotal.Text = "Total:" + " " + "$" + Total.ToString() + "*";
            }

            //10 Quantity If Statements
            //======================================================================================================
            if (ddlLabelSize.SelectedValue == "2" && ddlLabelQuantities.SelectedValue == "10")
            {
                Double Subtotal = 0;
                Subtotal = Size12x24_10Quantity;

                //Calculating the Total Cost.
                Decimal Total = Convert.ToDecimal(Subtotal);
                //formating the numbers that are displays to .00, this is done so people will know that it's money. 
                Total = Convert.ToDecimal(string.Format("{0:0.00}", Total));

                //Displaying the Total Price.
                lblTotal.Text = "Total:" + " " + "$" + Total.ToString() + "*";
            }

            //25 Quantity If Statements
            //======================================================================================================
            if (ddlLabelSize.SelectedValue == "2" && ddlLabelQuantities.SelectedValue == "25")
            {
                Double Subtotal = 0;
                Subtotal = Size12x24_25Quantity;

                //Calculating the Total Cost.
                Decimal Total = Convert.ToDecimal(Subtotal);
                //formating the numbers that are displays to .00, this is done so people will know that it's money. 
                Total = Convert.ToDecimal(string.Format("{0:0.00}", Total));

                //Displaying the Total Price.
                lblTotal.Text = "Total:" + " " + "$" + Total.ToString() + "*";
            }

            //50 Quantity If Statements
            //======================================================================================================
            if (ddlLabelSize.SelectedValue == "2" && ddlLabelQuantities.SelectedValue == "50")
            {
                Double Subtotal = 0;
                Subtotal = Size12x24_50Quantity;

                //Calculating the Total Cost.
                Decimal Total = Convert.ToDecimal(Subtotal);
                //formating the numbers that are displays to .00, this is done so people will know that it's money. 
                Total = Convert.ToDecimal(string.Format("{0:0.00}", Total));

                //Displaying the Total Price.
                lblTotal.Text = "Total:" + " " + "$" + Total.ToString() + "*";
            }

            //100 Quantity If Statements
            //======================================================================================================
            if (ddlLabelSize.SelectedValue == "2" && ddlLabelQuantities.SelectedValue == "100")
            {
                Double Subtotal = 0;
                Subtotal = Size12x24_100Quantity;

                //Calculating the Total Cost.
                Decimal Total = Convert.ToDecimal(Subtotal);
                //formating the numbers that are displays to .00, this is done so people will know that it's money. 
                Total = Convert.ToDecimal(string.Format("{0:0.00}", Total));

                //Displaying the Total Price.
                lblTotal.Text = "Total:" + " " + "$" + Total.ToString() + "*";
            }

            //250 Quantity If Statements
            //======================================================================================================
            if (ddlLabelSize.SelectedValue == "2" && ddlLabelQuantities.SelectedValue == "250")
            {
                Double Subtotal = 0;
                Subtotal = Size12x24_250Quantity;

                //Calculating the Total Cost.
                Decimal Total = Convert.ToDecimal(Subtotal);
                //formating the numbers that are displays to .00, this is done so people will know that it's money. 
                Total = Convert.ToDecimal(string.Format("{0:0.00}", Total));

                //Displaying the Total Price.
                lblTotal.Text = "Total:" + " " + "$" + Total.ToString() + "*";
            }

            //500 Quantity If Statements
            //======================================================================================================
            if (ddlLabelSize.SelectedValue == "2" && ddlLabelQuantities.SelectedValue == "500")
            {
                Double Subtotal = 0;
                Subtotal = Size12x24_500Quantity;

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