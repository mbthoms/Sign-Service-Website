using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Sign_Service_Label_Products.dealer
{
    public partial class parking_hang_tags_two_sided : System.Web.UI.Page
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
            //Side 2 Pricing
            //======================================================================================================

            Double Side2_Size25x45_50Quantity = 290.00;
            Double Side2_Size275x65_50Quantity = 320.00;
            //Color, 50 Quantity.
            Double Side2_Stock50QuantityColor = 60.00;

            //100 Quantity
            Double Side2_Size25x45_100Quantity = 325.00;
            Double Side2_Size275x65_100Quantity = 355.00;
            //Color, 100 Quantity.
            Double Side2_Stock100QuantityColor = 65.00;

            //250 Quantity
            Double Side2_Size25x45_250Quantity = 250.00;
            Double Side2_Size275x65_250Quantity = 455.00;
            //Color, 250 Quantity.
            Double Side2_Stock250QuantityColor = 75.00;

            //500 Quantity
            Double Side2_Size25x45_500Quantity =  520.00;
            Double Side2_Size275x65_500Quantity = 610.00;
            //Color, 500 Quantity.
            Double Side2_Stock500QuantityColor = 80.00;

            //1000 Quantity
            Double Side2_Size25x45_1000Quantity = 765.00;
            Double Side2_Size275x65_1000Quantity = 1050.00;
            //Color, 1000 Quantity.
            Double Side2_Stock1000QuantityColor = 85.00;

            //2000 Quantity
            Double Side2_Size25x45_2000Quantity = 1295.00;
            Double Side2_Size275x65_2000Quantity = 1930.00;
            //Color, 2000 Quantity.
            Double Side2_Stock2000QuantityColor = 100.00;

            //2500 Quantity
            Double Side2_Size25x45_2500Quantity = 1570.00;
            Double Side2_Size275x65_2500Quantity = 2375.00;
            //Color, 2000 Quantity.
            Double Side2_Stock2500QuantityColor = 115.00;

            //5000 Quantity
            Double Side2_Size25x45_5000Quantity = 2845.00;
            Double Side2_Size275x65_5000Quantity = 4020.00;
            //Color, 5000 Quantity.
            Double Side2_Stock5000QuantityColor = 230.00;

            //10000 Quantity
            Double Side2_Size25x45_10000Quantity = 4855.00;
            Double Side2_Size275x65_10000Quantity = 6995.00;
            //Color, 10000 Quantity.
            Double Side2_Stock10000QuantityColor = 360.00;

            //========================================================================================================
            //Consecutive Number Pricing
            //========================================================================================================

            Double ConsectiveSetupFee = 0.00;

            //Checking to see if the Consective has been seleted, if so add Setup charge to the price.
            if (ddlConsecutiveNumber.SelectedValue == "0.00")
            {
                ConsectiveSetupFee = 0.00;
            }
            else if (Convert.ToDouble(ddlConsecutiveNumber.SelectedValue) > 0.00)
            {
                //Lamination Setup Charge.
                ConsectiveSetupFee = 10.00;
            }


            //Getting the Pricing of Consecutive Numbering
            Double ConsecutivePricing = Convert.ToDouble(ddlConsecutiveNumber.SelectedValue) * Convert.ToDouble(ddlLabelQuantities.SelectedValue) + ConsectiveSetupFee;


            //========================================================================================================
            //Number of Colours
            //========================================================================================================
            //Getting the number of colours
            Decimal NumberOfColors = Convert.ToDecimal(txtNumberOfColours.Text) + Convert.ToDecimal(txtBackColours.Text) - 2;

            //2 Sided If Statements
            //======================================================================================================
            if (ddlSideOption.SelectedValue == "2")
            {
                //2.5 x 4.5 If Statements
                //======================================================================================================

                //50 Quantity If Statements
                //======================================================================================================
                if (ddlLabelSize.SelectedValue == "1" && ddlLabelQuantities.SelectedValue == "50")
                {
                    Double Subtotal = 0;
                    Subtotal = Side2_Size25x45_50Quantity;

                    //Calculating the price for the colors.
                    Double ColorPrice = Side2_Stock50QuantityColor * Convert.ToDouble(NumberOfColors);

                    //Calculating the Total Cost.
                    Decimal Total = Convert.ToDecimal(Subtotal) + Convert.ToDecimal(ColorPrice) + Convert.ToDecimal(ConsecutivePricing);
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
                    Subtotal = Side2_Size25x45_100Quantity;

                    //Calculating the price for the colors.
                    Double ColorPrice = Side2_Stock100QuantityColor * Convert.ToDouble(NumberOfColors);

                    //Calculating the Total Cost.
                    Decimal Total = Convert.ToDecimal(Subtotal) + Convert.ToDecimal(ColorPrice) + Convert.ToDecimal(ConsecutivePricing);
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
                    Subtotal = Side2_Size25x45_250Quantity;

                    //Calculating the price for the colors.
                    Double ColorPrice = Side2_Stock250QuantityColor * Convert.ToDouble(NumberOfColors);

                    //Calculating the Total Cost.
                    Decimal Total = Convert.ToDecimal(Subtotal) + Convert.ToDecimal(ColorPrice) + Convert.ToDecimal(ConsecutivePricing);
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
                    Subtotal = Side2_Size25x45_500Quantity;

                    //Calculating the price for the colors.
                    Double ColorPrice = Side2_Stock500QuantityColor * Convert.ToDouble(NumberOfColors);

                    //Calculating the Total Cost.
                    Decimal Total = Convert.ToDecimal(Subtotal) + Convert.ToDecimal(ColorPrice) + Convert.ToDecimal(ConsecutivePricing);
                    //formating the numbers that are displays to .00, this is done so people will know that it's money. 
                    Total = Convert.ToDecimal(string.Format("{0:0.00}", Total));

                    //Displaying the Total Price.
                    lblTotal.Text = "Total:" + " " + "$" + Total.ToString() + "*";
                }

                //1000 Quantity If Statements
                //======================================================================================================
                if (ddlLabelSize.SelectedValue == "1" && ddlLabelQuantities.SelectedValue == "1000")
                {
                    Double Subtotal = 0;
                    Subtotal = Side2_Size25x45_1000Quantity;

                    //Calculating the price for the colors.
                    Double ColorPrice = Side2_Stock1000QuantityColor * Convert.ToDouble(NumberOfColors);

                    //Calculating the Total Cost.
                    Decimal Total = Convert.ToDecimal(Subtotal) + Convert.ToDecimal(ColorPrice) + Convert.ToDecimal(ConsecutivePricing);
                    //formating the numbers that are displays to .00, this is done so people will know that it's money. 
                    Total = Convert.ToDecimal(string.Format("{0:0.00}", Total));

                    //Displaying the Total Price.
                    lblTotal.Text = "Total:" + " " + "$" + Total.ToString() + "*";
                }

                //2000 Quantity If Statements
                //======================================================================================================
                if (ddlLabelSize.SelectedValue == "1" && ddlLabelQuantities.SelectedValue == "2000")
                {
                    Double Subtotal = 0;
                    Subtotal = Side2_Size25x45_2000Quantity;

                    //Calculating the price for the colors.
                    Double ColorPrice = Side2_Stock2000QuantityColor * Convert.ToDouble(NumberOfColors);

                    //Calculating the Total Cost.
                    Decimal Total = Convert.ToDecimal(Subtotal) + Convert.ToDecimal(ColorPrice) + Convert.ToDecimal(ConsecutivePricing);
                    //formating the numbers that are displays to .00, this is done so people will know that it's money. 
                    Total = Convert.ToDecimal(string.Format("{0:0.00}", Total));

                    //Displaying the Total Price.
                    lblTotal.Text = "Total:" + " " + "$" + Total.ToString() + "*";
                }

                //2500 Quantity If Statements
                //======================================================================================================
                if (ddlLabelSize.SelectedValue == "1" && ddlLabelQuantities.SelectedValue == "2500")
                {
                    Double Subtotal = 0;
                    Subtotal = Side2_Size25x45_2500Quantity;

                    //Calculating the price for the colors.
                    Double ColorPrice = Side2_Stock2500QuantityColor * Convert.ToDouble(NumberOfColors);

                    //Calculating the Total Cost.
                    Decimal Total = Convert.ToDecimal(Subtotal) + Convert.ToDecimal(ColorPrice) + Convert.ToDecimal(ConsecutivePricing);
                    //formating the numbers that are displays to .00, this is done so people will know that it's money. 
                    Total = Convert.ToDecimal(string.Format("{0:0.00}", Total));

                    //Displaying the Total Price.
                    lblTotal.Text = "Total:" + " " + "$" + Total.ToString() + "*";
                }

                //5000 Quantity If Statements
                //======================================================================================================
                if (ddlLabelSize.SelectedValue == "1" && ddlLabelQuantities.SelectedValue == "5000")
                {
                    Double Subtotal = 0;
                    Subtotal = Side2_Size25x45_5000Quantity;

                    //Calculating the price for the colors.
                    Double ColorPrice = Side2_Stock5000QuantityColor * Convert.ToDouble(NumberOfColors);

                    //Calculating the Total Cost.
                    Decimal Total = Convert.ToDecimal(Subtotal) + Convert.ToDecimal(ColorPrice) + Convert.ToDecimal(ConsecutivePricing);
                    //formating the numbers that are displays to .00, this is done so people will know that it's money. 
                    Total = Convert.ToDecimal(string.Format("{0:0.00}", Total));

                    //Displaying the Total Price.
                    lblTotal.Text = "Total:" + " " + "$" + Total.ToString() + "*";
                }

                //10000 Quantity If Statements
                //======================================================================================================
                if (ddlLabelSize.SelectedValue == "1" && ddlLabelQuantities.SelectedValue == "10000")
                {
                    Double Subtotal = 0;
                    Subtotal = Side2_Size25x45_10000Quantity;

                    //Calculating the price for the colors.
                    Double ColorPrice = Side2_Stock10000QuantityColor * Convert.ToDouble(NumberOfColors);

                    //Calculating the Total Cost.
                    Decimal Total = Convert.ToDecimal(Subtotal) + Convert.ToDecimal(ColorPrice) + Convert.ToDecimal(ConsecutivePricing);
                    //formating the numbers that are displays to .00, this is done so people will know that it's money. 
                    Total = Convert.ToDecimal(string.Format("{0:0.00}", Total));

                    //Displaying the Total Price.
                    lblTotal.Text = "Total:" + " " + "$" + Total.ToString() + "*";
                }

                //2.75 x 6.5 If Statements
                //======================================================================================================

                //50 Quantity If Statements
                //======================================================================================================
                if (ddlLabelSize.SelectedValue == "2" && ddlLabelQuantities.SelectedValue == "50")
                {
                    Double Subtotal = 0;
                    Subtotal = Side2_Size275x65_50Quantity;

                    //Calculating the price for the colors.
                    Double ColorPrice = Side2_Stock50QuantityColor * Convert.ToDouble(NumberOfColors);

                    //Calculating the Total Cost.
                    Decimal Total = Convert.ToDecimal(Subtotal) + Convert.ToDecimal(ColorPrice) + Convert.ToDecimal(ConsecutivePricing);
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
                    Subtotal = Side2_Size275x65_100Quantity;

                    //Calculating the price for the colors.
                    Double ColorPrice = Side2_Stock100QuantityColor * Convert.ToDouble(NumberOfColors);

                    //Calculating the Total Cost.
                    Decimal Total = Convert.ToDecimal(Subtotal) + Convert.ToDecimal(ColorPrice) + Convert.ToDecimal(ConsecutivePricing);
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
                    Subtotal = Side2_Size275x65_250Quantity;

                    //Calculating the price for the colors.
                    Double ColorPrice = Side2_Stock250QuantityColor * Convert.ToDouble(NumberOfColors);

                    //Calculating the Total Cost.
                    Decimal Total = Convert.ToDecimal(Subtotal) + Convert.ToDecimal(ColorPrice) + Convert.ToDecimal(ConsecutivePricing);
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
                    Subtotal = Side2_Size275x65_500Quantity;

                    //Calculating the price for the colors.
                    Double ColorPrice = Side2_Stock500QuantityColor * Convert.ToDouble(NumberOfColors);

                    //Calculating the Total Cost.
                    Decimal Total = Convert.ToDecimal(Subtotal) + Convert.ToDecimal(ColorPrice) + Convert.ToDecimal(ConsecutivePricing);
                    //formating the numbers that are displays to .00, this is done so people will know that it's money. 
                    Total = Convert.ToDecimal(string.Format("{0:0.00}", Total));

                    //Displaying the Total Price.
                    lblTotal.Text = "Total:" + " " + "$" + Total.ToString() + "*";
                }

                //1000 Quantity If Statements
                //======================================================================================================
                if (ddlLabelSize.SelectedValue == "2" && ddlLabelQuantities.SelectedValue == "1000")
                {
                    Double Subtotal = 0;
                    Subtotal = Side2_Size275x65_1000Quantity;

                    //Calculating the price for the colors.
                    Double ColorPrice = Side2_Stock1000QuantityColor * Convert.ToDouble(NumberOfColors);

                    //Calculating the Total Cost.
                    Decimal Total = Convert.ToDecimal(Subtotal) + Convert.ToDecimal(ColorPrice) + Convert.ToDecimal(ConsecutivePricing);
                    //formating the numbers that are displays to .00, this is done so people will know that it's money. 
                    Total = Convert.ToDecimal(string.Format("{0:0.00}", Total));

                    //Displaying the Total Price.
                    lblTotal.Text = "Total:" + " " + "$" + Total.ToString() + "*";
                }

                //2000 Quantity If Statements
                //======================================================================================================
                if (ddlLabelSize.SelectedValue == "2" && ddlLabelQuantities.SelectedValue == "2000")
                {
                    Double Subtotal = 0;
                    Subtotal = Side2_Size275x65_2000Quantity;

                    //Calculating the price for the colors.
                    Double ColorPrice = Side2_Stock2000QuantityColor * Convert.ToDouble(NumberOfColors);

                    //Calculating the Total Cost.
                    Decimal Total = Convert.ToDecimal(Subtotal) + Convert.ToDecimal(ColorPrice) + Convert.ToDecimal(ConsecutivePricing);
                    //formating the numbers that are displays to .00, this is done so people will know that it's money. 
                    Total = Convert.ToDecimal(string.Format("{0:0.00}", Total));

                    //Displaying the Total Price.
                    lblTotal.Text = "Total:" + " " + "$" + Total.ToString() + "*";
                }

                //2000 Quantity If Statements
                //======================================================================================================
                if (ddlLabelSize.SelectedValue == "2" && ddlLabelQuantities.SelectedValue == "2500")
                {
                    Double Subtotal = 0;
                    Subtotal = Side2_Size275x65_2500Quantity;

                    //Calculating the price for the colors.
                    Double ColorPrice = Side2_Stock2500QuantityColor * Convert.ToDouble(NumberOfColors);

                    //Calculating the Total Cost.
                    Decimal Total = Convert.ToDecimal(Subtotal) + Convert.ToDecimal(ColorPrice) + Convert.ToDecimal(ConsecutivePricing);
                    //formating the numbers that are displays to .00, this is done so people will know that it's money. 
                    Total = Convert.ToDecimal(string.Format("{0:0.00}", Total));

                    //Displaying the Total Price.
                    lblTotal.Text = "Total:" + " " + "$" + Total.ToString() + "*";
                }

                //5000 Quantity If Statements
                //======================================================================================================
                if (ddlLabelSize.SelectedValue == "2" && ddlLabelQuantities.SelectedValue == "5000")
                {
                    Double Subtotal = 0;
                    Subtotal = Side2_Size275x65_5000Quantity;

                    //Calculating the price for the colors.
                    Double ColorPrice = Side2_Stock5000QuantityColor * Convert.ToDouble(NumberOfColors);

                    //Calculating the Total Cost.
                    Decimal Total = Convert.ToDecimal(Subtotal) + Convert.ToDecimal(ColorPrice) + Convert.ToDecimal(ConsecutivePricing);
                    //formating the numbers that are displays to .00, this is done so people will know that it's money. 
                    Total = Convert.ToDecimal(string.Format("{0:0.00}", Total));

                    //Displaying the Total Price.
                    lblTotal.Text = "Total:" + " " + "$" + Total.ToString() + "*";
                }

                //10000 Quantity If Statements
                //======================================================================================================
                if (ddlLabelSize.SelectedValue == "2" && ddlLabelQuantities.SelectedValue == "10000")
                {
                    Double Subtotal = 0;
                    Subtotal = Side2_Size275x65_10000Quantity;

                    //Calculating the price for the colors.
                    Double ColorPrice = Side2_Stock10000QuantityColor * Convert.ToDouble(NumberOfColors);

                    //Calculating the Total Cost.
                    Decimal Total = Convert.ToDecimal(Subtotal) + Convert.ToDecimal(ColorPrice) + Convert.ToDecimal(ConsecutivePricing);
                    //formating the numbers that are displays to .00, this is done so people will know that it's money. 
                    Total = Convert.ToDecimal(string.Format("{0:0.00}", Total));

                    //Displaying the Total Price.
                    lblTotal.Text = "Total:" + " " + "$" + Total.ToString() + "*";
                }


            }
        }
    }
}