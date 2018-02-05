using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Sign_Service_Label_Products.dealer
{
    public partial class parking_hang_tag_pricing : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            //Hides the Message if showing when you press the "Get Quote" button.
            if (IsPostBack)
            {
                lblCustomQuoteMessage.Text = "";
            }
        }

        protected void btnFindPrices_Click(object sender, EventArgs e)
        {
            //======================================================================================================
            //Side 1 Pricing
            //======================================================================================================

            //50 Quantity
            Double Side1_Size25x45_50Quantity = 230.00;
            Double Side1_Size275x65_50Quantity = 245.00;
            //Color, 50 Quantity.
            Double Side1_Stock50QuantityColor = 95.00;

            //100 Quantity
            Double Side1_Size25x45_100Quantity = 260.00;
            Double Side1_Size275x65_100Quantity = 290.00;
            //Color, 100 Quantity.
            Double Side1_Stock100QuantityColor = 95.00;

            //250 Quantity
            Double Side1_Size25x45_250Quantity = 335.00;
            Double Side1_Size275x65_250Quantity = 380.00;
            //Color, 250 Quantity.
            Double Side1_Stock250QuantityColor = 105.00;

            //500 Quantity
            Double Side1_Size25x45_500Quantity = 440.00;
            Double Side1_Size275x65_500Quantity = 260.00;
            //Color, 500 Quantity.
            Double Side1_Stock500QuantityColor = 125.00;

            //1000 Quantity
            Double Side1_Size25x45_1000Quantity = 680.00;
            Double Side1_Size275x65_1000Quantity = 975.00;
            //Color, 1000 Quantity.
            Double Side1_Stock1000QuantityColor = 185.00;

            //2000 Quantity
            Double Side1_Size25x45_2000Quantity = 1195.00;
            Double Side1_Size275x65_2000Quantity = 1830.00;
            //Color, 2000 Quantity.
            Double Side1_Stock2000QuantityColor = 245.00;

            //2000 Quantity
            Double Side1_Size25x45_2500Quantity = 1455.00;
            Double Side1_Size275x65_2500Quantity = 2260.00;
            //Color, 2000 Quantity.
            Double Side1_Stock2500QuantityColor = 245.00;

            //5000 Quantity
            Double Side1_Size25x45_5000Quantity = 2615.00;
            Double Side1_Size275x65_5000Quantity = 3790.00;
            //Color, 5000 Quantity.
            Double Side1_Stock5000QuantityColor = 300.00;

            //10000 Quantity
            Double Side1_Size25x45_10000Quantity = 4495.00;
            Double Side1_Size275x65_10000Quantity = 6635.00;
            //Color, 10000 Quantity.
            Double Side1_Stock10000QuantityColor = 245.00;

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
            Decimal NumberOfColors = Convert.ToDecimal(txtNumberOfColours.Text) - 1;

            

   
            //1 Sided If Statements
            //======================================================================================================
            if (ddlSideOption.SelectedValue == "1")
            {
                //2.5 x 4.5 If Statements
                //======================================================================================================

                //50 Quantity If Statements
                //======================================================================================================
                if (ddlLabelSize.SelectedValue == "1" && ddlLabelQuantities.SelectedValue == "50")
                {
                    Double Subtotal = 0;
                    Subtotal = Side1_Size25x45_50Quantity;

                    //Calculating the price for the colors.
                    Double ColorPrice = Side1_Stock50QuantityColor * Convert.ToDouble(NumberOfColors);

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
                        Subtotal = Side1_Size25x45_100Quantity;

                        //Calculating the price for the colors.
                        Double ColorPrice = Side1_Stock100QuantityColor * Convert.ToDouble(NumberOfColors);

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
                    Subtotal = Side1_Size25x45_250Quantity;

                    //Calculating the price for the colors.
                    Double ColorPrice = Side1_Stock250QuantityColor * Convert.ToDouble(NumberOfColors);

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
                    Subtotal = Side1_Size25x45_500Quantity;

                    //Calculating the price for the colors.
                    Double ColorPrice = Side1_Stock500QuantityColor * Convert.ToDouble(NumberOfColors);

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
                    Subtotal = Side1_Size25x45_1000Quantity;

                    //Calculating the price for the colors.
                    Double ColorPrice = Side1_Stock1000QuantityColor * Convert.ToDouble(NumberOfColors);

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
                    Subtotal = Side1_Size25x45_2000Quantity;

                    //Calculating the price for the colors.
                    Double ColorPrice = Side1_Stock2000QuantityColor * Convert.ToDouble(NumberOfColors);

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
                    Subtotal = Side1_Size25x45_2500Quantity;

                    //Calculating the price for the colors.
                    Double ColorPrice = Side1_Stock2500QuantityColor * Convert.ToDouble(NumberOfColors);

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
                    Subtotal = Side1_Size25x45_5000Quantity;

                    //Calculating the price for the colors.
                    Double ColorPrice = Side1_Stock5000QuantityColor * Convert.ToDouble(NumberOfColors);

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
                    Subtotal = Side1_Size25x45_10000Quantity;

                    //Calculating the price for the colors.
                    Double ColorPrice = Side1_Stock10000QuantityColor * Convert.ToDouble(NumberOfColors);

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
                    Subtotal = Side1_Size275x65_50Quantity;

                    //Calculating the price for the colors.
                    Double ColorPrice = Side1_Stock50QuantityColor * Convert.ToDouble(NumberOfColors);

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
                    Subtotal = Side1_Size275x65_100Quantity;

                    //Calculating the price for the colors.
                    Double ColorPrice = Side1_Stock100QuantityColor * Convert.ToDouble(NumberOfColors);

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
                    Subtotal = Side1_Size275x65_250Quantity;

                    //Calculating the price for the colors.
                    Double ColorPrice = Side1_Stock250QuantityColor * Convert.ToDouble(NumberOfColors);

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
                    Subtotal = Side1_Size275x65_500Quantity;

                    //Calculating the price for the colors.
                    Double ColorPrice = Side1_Stock500QuantityColor * Convert.ToDouble(NumberOfColors);

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
                    Subtotal = Side1_Size275x65_1000Quantity;

                    //Calculating the price for the colors.
                    Double ColorPrice = Side1_Stock1000QuantityColor * Convert.ToDouble(NumberOfColors);

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
                    Subtotal = Side1_Size275x65_2000Quantity;

                    //Calculating the price for the colors.
                    Double ColorPrice = Side1_Stock2000QuantityColor * Convert.ToDouble(NumberOfColors);

                    //Calculating the Total Cost.
                    Decimal Total = Convert.ToDecimal(Subtotal) + Convert.ToDecimal(ColorPrice) + Convert.ToDecimal(ConsecutivePricing);
                    //formating the numbers that are displays to .00, this is done so people will know that it's money. 
                    Total = Convert.ToDecimal(string.Format("{0:0.00}", Total));

                    //Displaying the Total Price.
                    lblTotal.Text = "Total:" + " " + "$" + Total.ToString() + "*";
                }

                //2500 Quantity If Statements
                //======================================================================================================
                if (ddlLabelSize.SelectedValue == "2" && ddlLabelQuantities.SelectedValue == "2500")
                {
                    Double Subtotal = 0;
                    Subtotal = Side1_Size275x65_2500Quantity;
                    
                    //Calculating the price for the colors.
                    Double ColorPrice = Side1_Stock2500QuantityColor * Convert.ToDouble(NumberOfColors);

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
                    Subtotal = Side1_Size275x65_5000Quantity;

                    //Calculating the price for the colors.
                    Double ColorPrice = Side1_Stock5000QuantityColor * Convert.ToDouble(NumberOfColors);

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
                    Subtotal = Side1_Size275x65_10000Quantity;

                    //Calculating the price for the colors.
                    Double ColorPrice = Side1_Stock10000QuantityColor * Convert.ToDouble(NumberOfColors);

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