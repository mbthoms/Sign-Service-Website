using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Sign_Service_Label_Products.dealer
{
    public partial class vehicle_magnet_pricing : System.Web.UI.Page
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

            //2 Quantity
            Double Size12x14_2Quantity = 60.00;
            Double Size11x18_2Quantity = 75.00;
            //2 Quantity Colors
            Double Quantity2Color = 15.00;

            //4 Quantity
            Double Size12x14_4Quantity = 110.00;
            Double Size11x18_4Quantity = 120.00;
            //4 Quantity Colors
            Double Quantity4Color = 25.00;

            //6 Quantity
            Double Size12x14_6Quantity = 150.00;
            Double Size11x18_6Quantity = 160.00;
            //6 Quantity Colors
            Double Quantity6Color = 40.00;

            //8 Quantity
            Double Size12x14_8Quantity = 190.00;
            Double Size11x18_8Quantity = 200.00;
            //8 Quantity Colors
            Double Quantity8Color = 55.00;

            //10 Quantity
            Double Size12x14_10Quantity = 230.00;
            Double Size11x18_10Quantity = 240.00;
            //10 Quantity Colors
            Double Quantity10Color = 65.00;

            //Getting the number of colours
            Decimal NumberOfColors = Convert.ToDecimal(txtNumberOfColours.Text) - 1;


            //2 Quantity If Statements
            //======================================================================================================
            if (ddlLabelSize.SelectedValue == "1" && ddlLabelQuantities.SelectedValue == "2")
            {
                Double Subtotal = 0;
                Subtotal = Size12x14_2Quantity;

                //Calculating the price for the colors.
                Double ColorPrice = Quantity2Color * Convert.ToDouble(NumberOfColors);

                //Calculating the Total Cost.
                Decimal Total = Convert.ToDecimal(Subtotal) + Convert.ToDecimal(ColorPrice);
                //formating the numbers that are displays to .00, this is done so people will know that it's money. 
                Total = Convert.ToDecimal(string.Format("{0:0.00}", Total));

                //Displaying the Total Price.
                lblTotal.Text = "Total:" + " " + "$" + Total.ToString() + "*";
            }

            if (ddlLabelSize.SelectedValue == "2" && ddlLabelQuantities.SelectedValue == "2")
            {
                Double Subtotal = 0;
                Subtotal = Size11x18_2Quantity;

                //Calculating the price for the colors.
                Double ColorPrice = Quantity2Color * Convert.ToDouble(NumberOfColors);

                //Calculating the Total Cost.
                Decimal Total = Convert.ToDecimal(Subtotal) + Convert.ToDecimal(ColorPrice);
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

                //Calculating the price for the colors.
                Double ColorPrice = Quantity4Color * Convert.ToDouble(NumberOfColors);

                //Calculating the Total Cost.
                Decimal Total = Convert.ToDecimal(Subtotal) + Convert.ToDecimal(ColorPrice);
                //formating the numbers that are displays to .00, this is done so people will know that it's money. 
                Total = Convert.ToDecimal(string.Format("{0:0.00}", Total));

                //Displaying the Total Price.
                lblTotal.Text = "Total:" + " " + "$" + Total.ToString() + "*";
            }

            if (ddlLabelSize.SelectedValue == "2" && ddlLabelQuantities.SelectedValue == "4")
            {
                Double Subtotal = 0;
                Subtotal = Size11x18_4Quantity;

                //Calculating the price for the colors.
                Double ColorPrice = Quantity4Color * Convert.ToDouble(NumberOfColors);

                //Calculating the Total Cost.
                Decimal Total = Convert.ToDecimal(Subtotal) + Convert.ToDecimal(ColorPrice);
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

                //Calculating the price for the colors.
                Double ColorPrice = Quantity6Color * Convert.ToDouble(NumberOfColors);

                //Calculating the Total Cost.
                Decimal Total = Convert.ToDecimal(Subtotal) + Convert.ToDecimal(ColorPrice);
                //formating the numbers that are displays to .00, this is done so people will know that it's money. 
                Total = Convert.ToDecimal(string.Format("{0:0.00}", Total));

                //Displaying the Total Price.
                lblTotal.Text = "Total:" + " " + "$" + Total.ToString() + "*";
            }

            if (ddlLabelSize.SelectedValue == "2" && ddlLabelQuantities.SelectedValue == "6")
            {
                Double Subtotal = 0;
                Subtotal = Size11x18_6Quantity;

                //Calculating the price for the colors.
                Double ColorPrice = Quantity6Color * Convert.ToDouble(NumberOfColors);

                //Calculating the Total Cost.
                Decimal Total = Convert.ToDecimal(Subtotal) + Convert.ToDecimal(ColorPrice);
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

                //Calculating the price for the colors.
                Double ColorPrice = Quantity8Color * Convert.ToDouble(NumberOfColors);

                //Calculating the Total Cost.
                Decimal Total = Convert.ToDecimal(Subtotal) + Convert.ToDecimal(ColorPrice);
                //formating the numbers that are displays to .00, this is done so people will know that it's money. 
                Total = Convert.ToDecimal(string.Format("{0:0.00}", Total));

                //Displaying the Total Price.
                lblTotal.Text = "Total:" + " " + "$" + Total.ToString() + "*";
            }

            if (ddlLabelSize.SelectedValue == "2" && ddlLabelQuantities.SelectedValue == "8")
            {
                Double Subtotal = 0;
                Subtotal = Size11x18_8Quantity;

                //Calculating the price for the colors.
                Double ColorPrice = Quantity8Color * Convert.ToDouble(NumberOfColors);

                //Calculating the Total Cost.
                Decimal Total = Convert.ToDecimal(Subtotal) + Convert.ToDecimal(ColorPrice);
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

                //Calculating the price for the colors.
                Double ColorPrice = Quantity10Color * Convert.ToDouble(NumberOfColors);

                //Calculating the Total Cost.
                Decimal Total = Convert.ToDecimal(Subtotal) + Convert.ToDecimal(ColorPrice);
                //formating the numbers that are displays to .00, this is done so people will know that it's money. 
                Total = Convert.ToDecimal(string.Format("{0:0.00}", Total));

                //Displaying the Total Price.
                lblTotal.Text = "Total:" + " " + "$" + Total.ToString() + "*";
            }

            if (ddlLabelSize.SelectedValue == "2" && ddlLabelQuantities.SelectedValue == "10")
            {
                Double Subtotal = 0;
                Subtotal = Size11x18_10Quantity;

                //Calculating the price for the colors.
                Double ColorPrice = Quantity10Color * Convert.ToDouble(NumberOfColors);

                //Calculating the Total Cost.
                Decimal Total = Convert.ToDecimal(Subtotal) + Convert.ToDecimal(ColorPrice);
                //formating the numbers that are displays to .00, this is done so people will know that it's money. 
                Total = Convert.ToDecimal(string.Format("{0:0.00}", Total));

                //Displaying the Total Price.
                lblTotal.Text = "Total:" + " " + "$" + Total.ToString() + "*";
            }
        }
    }
}