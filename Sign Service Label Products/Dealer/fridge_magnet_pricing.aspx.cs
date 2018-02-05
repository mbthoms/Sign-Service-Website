using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Sign_Service_Label_Products.dealer
{
    public partial class fridge_magnet_pricing : System.Web.UI.Page
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
            
            //100 Quantity
            Double Size2x2_100Quantity = 193.00;
            Double Size2x3_100Quantity = 194.00;
            Double Size2x35_100Quantity = 196.00;
            //Color, 100 Quantity.
            Double Stock100QuantityColor = 65.00;

            //250 Quantity
            Double Size2x2_250Quantity = 198.00;
            Double Size2x3_250Quantity = 201.00;
            Double Size2x35_250Quantity = 205.00;
            //Color, 250 Quantity.
            Double Stock250QuantityColor = 75.00;

            //500 Quantity
            Double Size2x2_500Quantity = 245.00;
            Double Size2x3_500Quantity = 252.00;
            Double Size2x35_500Quantity = 260.00;
            //Color, 500 Quantity.
            Double Stock500QuantityColor = 80.00;

            //1000 Quantity
            Double Size2x2_1000Quantity = 284.00;
            Double Size2x3_1000Quantity = 306.00;
            Double Size2x35_1000Quantity = 334.00;
            //Color, 1000 Quantity.
            Double Stock1000QuantityColor = 85.00;

            //2000 Quantity
            Double Size2x2_2000Quantity = 371.00;
            Double Size2x3_2000Quantity = 411.00;
            Double Size2x35_2000Quantity = 466.00;
            //Color, 2000 Quantity.
            Double Stock2000QuantityColor = 90.00;

            //2500 Quantity
            Double Size2x2_2500Quantity = 410.00;
            Double Size2x3_2500Quantity = 467.00;
            Double Size2x35_2500Quantity = 536.00;
            //Color, 2500 Quantity.
            Double Stock2500QuantityColor = 90.00;

            //5000 Quantity
            Double Size2x2_5000Quantity = 700.00;
            Double Size2x3_5000Quantity = 800.00;
            Double Size2x35_5000Quantity = 950.00;
            //Color, 5000 Quantity.
            Double Stock5000QuantityColor = 145.00;

            //10000 Quantity
            Double Size2x2_10000Quantity = 1122.00;
            Double Size2x3_10000Quantity = 1418.00;
            Double Size2x35_10000Quantity = 1685.00;
            //Color, 10000 Quantity.
            Double Stock10000QuantityColor = 200.00;


            //Getting the number of colours
            Decimal NumberOfColors = Convert.ToDecimal(txtNumberOfColours.Text) - 1;
            


            //100 Quantity If Statements
            //======================================================================================================
            if (ddlLabelSize.SelectedValue == "1" && ddlLabelQuantities.SelectedValue =="100")
            {
                Double Subtotal = 0;
                Subtotal = Size2x2_100Quantity;

                //Calculating the price for the colors.
                Double ColorPrice = Stock100QuantityColor * Convert.ToDouble(NumberOfColors);

                //Calculating the Total Cost.
                Decimal Total = Convert.ToDecimal(Subtotal) + Convert.ToDecimal(ColorPrice);
                //formating the numbers that are displays to .00, this is done so people will know that it's money. 
                Total = Convert.ToDecimal(string.Format("{0:0.00}", Total));

                //Displaying the Total Price.
                lblTotal.Text = "Total:" + " " + "$" + Total.ToString() + "*";
            }


            if (ddlLabelSize.SelectedValue == "2" && ddlLabelQuantities.SelectedValue == "100")
            {
                Double Subtotal = 0;
                Subtotal = Size2x3_100Quantity;

                //Calculating the price for the colors.
                Double ColorPrice = Stock100QuantityColor * Convert.ToDouble(NumberOfColors);

                //Calculating the Total Cost.
                Decimal Total = Convert.ToDecimal(Subtotal) + Convert.ToDecimal(ColorPrice);
                //formating the numbers that are displays to .00, this is done so people will know that it's money. 
                Total = Convert.ToDecimal(string.Format("{0:0.00}", Total));

                //Displaying the Total Price.
                lblTotal.Text = "Total:" + " " + "$" + Total.ToString() + "*";
            }

            if (ddlLabelSize.SelectedValue == "3" && ddlLabelQuantities.SelectedValue == "100")
            {
                Double Subtotal = 0;
                Subtotal = Size2x35_100Quantity;

                //Calculating the price for the colors.
                Double ColorPrice = Stock100QuantityColor * Convert.ToDouble(NumberOfColors);

                //Calculating the Total Cost.
                Decimal Total = Convert.ToDecimal(Subtotal) + Convert.ToDecimal(ColorPrice);
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
                Subtotal = Size2x2_250Quantity;

                //Calculating the price for the colors.
                Double ColorPrice = Stock250QuantityColor * Convert.ToDouble(NumberOfColors);

                //Calculating the Total Cost.
                Decimal Total = Convert.ToDecimal(Subtotal) + Convert.ToDecimal(ColorPrice);
                //formating the numbers that are displays to .00, this is done so people will know that it's money. 
                Total = Convert.ToDecimal(string.Format("{0:0.00}", Total));

                //Displaying the Total Price.
                lblTotal.Text = "Total:" + " " + "$" + Total.ToString() + "*";
            }


            if (ddlLabelSize.SelectedValue == "2" && ddlLabelQuantities.SelectedValue == "250")
            {
                Double Subtotal = 0;
                Subtotal = Size2x3_250Quantity;

                //Calculating the price for the colors.
                Double ColorPrice = Stock250QuantityColor * Convert.ToDouble(NumberOfColors);

                //Calculating the Total Cost.
                Decimal Total = Convert.ToDecimal(Subtotal) + Convert.ToDecimal(ColorPrice);
                //formating the numbers that are displays to .00, this is done so people will know that it's money. 
                Total = Convert.ToDecimal(string.Format("{0:0.00}", Total));

                //Displaying the Total Price.
                lblTotal.Text = "Total:" + " " + "$" + Total.ToString() + "*";
            }

            if (ddlLabelSize.SelectedValue == "3" && ddlLabelQuantities.SelectedValue == "250")
            {
                Double Subtotal = 0;
                Subtotal = Size2x35_250Quantity;

                //Calculating the price for the colors.
                Double ColorPrice = Stock250QuantityColor * Convert.ToDouble(NumberOfColors);

                //Calculating the Total Cost.
                Decimal Total = Convert.ToDecimal(Subtotal) + Convert.ToDecimal(ColorPrice);
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
                Subtotal = Size2x2_500Quantity;

                //Calculating the price for the colors.
                Double ColorPrice = Stock500QuantityColor * Convert.ToDouble(NumberOfColors);

                //Calculating the Total Cost.
                Decimal Total = Convert.ToDecimal(Subtotal) + Convert.ToDecimal(ColorPrice);
                //formating the numbers that are displays to .00, this is done so people will know that it's money. 
                Total = Convert.ToDecimal(string.Format("{0:0.00}", Total));

                //Displaying the Total Price.
                lblTotal.Text = "Total:" + " " + "$" + Total.ToString() + "*";
            }


            if (ddlLabelSize.SelectedValue == "2" && ddlLabelQuantities.SelectedValue == "500")
            {
                Double Subtotal = 0;
                Subtotal = Size2x3_500Quantity;

                //Calculating the price for the colors.
                Double ColorPrice = Stock500QuantityColor * Convert.ToDouble(NumberOfColors);

                //Calculating the Total Cost.
                Decimal Total = Convert.ToDecimal(Subtotal) + Convert.ToDecimal(ColorPrice);
                //formating the numbers that are displays to .00, this is done so people will know that it's money. 
                Total = Convert.ToDecimal(string.Format("{0:0.00}", Total));

                //Displaying the Total Price.
                lblTotal.Text = "Total:" + " " + "$" + Total.ToString() + "*";
            }

            if (ddlLabelSize.SelectedValue == "3" && ddlLabelQuantities.SelectedValue == "500")
            {
                Double Subtotal = 0;
                Subtotal = Size2x35_500Quantity;

                //Calculating the price for the colors.
                Double ColorPrice = Stock500QuantityColor * Convert.ToDouble(NumberOfColors);

                //Calculating the Total Cost.
                Decimal Total = Convert.ToDecimal(Subtotal) + Convert.ToDecimal(ColorPrice);
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
                Subtotal = Size2x2_1000Quantity;

                //Calculating the price for the colors.
                Double ColorPrice = Stock1000QuantityColor * Convert.ToDouble(NumberOfColors);

                //Calculating the Total Cost.
                Decimal Total = Convert.ToDecimal(Subtotal) + Convert.ToDecimal(ColorPrice);
                //formating the numbers that are displays to .00, this is done so people will know that it's money. 
                Total = Convert.ToDecimal(string.Format("{0:0.00}", Total));

                //Displaying the Total Price.
                lblTotal.Text = "Total:" + " " + "$" + Total.ToString() + "*";
            }


            if (ddlLabelSize.SelectedValue == "2" && ddlLabelQuantities.SelectedValue == "1000")
            {
                Double Subtotal = 0;
                Subtotal = Size2x3_1000Quantity;

                //Calculating the price for the colors.
                Double ColorPrice = Stock1000QuantityColor * Convert.ToDouble(NumberOfColors);

                //Calculating the Total Cost.
                Decimal Total = Convert.ToDecimal(Subtotal) + Convert.ToDecimal(ColorPrice);
                //formating the numbers that are displays to .00, this is done so people will know that it's money. 
                Total = Convert.ToDecimal(string.Format("{0:0.00}", Total));

                //Displaying the Total Price.
                lblTotal.Text = "Total:" + " " + "$" + Total.ToString() + "*";
            }

            if (ddlLabelSize.SelectedValue == "3" && ddlLabelQuantities.SelectedValue == "1000")
            {
                Double Subtotal = 0;
                Subtotal = Size2x35_1000Quantity;

                //Calculating the price for the colors.
                Double ColorPrice = Stock1000QuantityColor * Convert.ToDouble(NumberOfColors);

                //Calculating the Total Cost.
                Decimal Total = Convert.ToDecimal(Subtotal) + Convert.ToDecimal(ColorPrice);
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
                Subtotal = Size2x2_2000Quantity;

                //Calculating the price for the colors.
                Double ColorPrice = Stock2000QuantityColor * Convert.ToDouble(NumberOfColors);

                //Calculating the Total Cost.
                Decimal Total = Convert.ToDecimal(Subtotal) + Convert.ToDecimal(ColorPrice);
                //formating the numbers that are displays to .00, this is done so people will know that it's money. 
                Total = Convert.ToDecimal(string.Format("{0:0.00}", Total));

                //Displaying the Total Price.
                lblTotal.Text = "Total:" + " " + "$" + Total.ToString() + "*";
            }


            if (ddlLabelSize.SelectedValue == "2" && ddlLabelQuantities.SelectedValue == "2000")
            {
                Double Subtotal = 0;
                Subtotal = Size2x3_2000Quantity;

                //Calculating the price for the colors.
                Double ColorPrice = Stock2000QuantityColor * Convert.ToDouble(NumberOfColors);

                //Calculating the Total Cost.
                Decimal Total = Convert.ToDecimal(Subtotal) + Convert.ToDecimal(ColorPrice);
                //formating the numbers that are displays to .00, this is done so people will know that it's money. 
                Total = Convert.ToDecimal(string.Format("{0:0.00}", Total));

                //Displaying the Total Price.
                lblTotal.Text = "Total:" + " " + "$" + Total.ToString() + "*";
            }

            if (ddlLabelSize.SelectedValue == "3" && ddlLabelQuantities.SelectedValue == "2000")
            {
                Double Subtotal = 0;
                Subtotal = Size2x35_2000Quantity;

                //Calculating the price for the colors.
                Double ColorPrice = Stock2000QuantityColor * Convert.ToDouble(NumberOfColors);

                //Calculating the Total Cost.
                Decimal Total = Convert.ToDecimal(Subtotal) + Convert.ToDecimal(ColorPrice);
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
                Subtotal = Size2x2_2500Quantity;

                //Calculating the price for the colors.
                Double ColorPrice = Stock2500QuantityColor * Convert.ToDouble(NumberOfColors);

                //Calculating the Total Cost.
                Decimal Total = Convert.ToDecimal(Subtotal) + Convert.ToDecimal(ColorPrice);
                //formating the numbers that are displays to .00, this is done so people will know that it's money. 
                Total = Convert.ToDecimal(string.Format("{0:0.00}", Total));

                //Displaying the Total Price.
                lblTotal.Text = "Total:" + " " + "$" + Total.ToString() + "*";
            }


            if (ddlLabelSize.SelectedValue == "2" && ddlLabelQuantities.SelectedValue == "2500")
            {
                Double Subtotal = 0;
                Subtotal = Size2x3_2500Quantity;

                //Calculating the price for the colors.
                Double ColorPrice = Stock2500QuantityColor * Convert.ToDouble(NumberOfColors);

                //Calculating the Total Cost.
                Decimal Total = Convert.ToDecimal(Subtotal) + Convert.ToDecimal(ColorPrice);
                //formating the numbers that are displays to .00, this is done so people will know that it's money. 
                Total = Convert.ToDecimal(string.Format("{0:0.00}", Total));

                //Displaying the Total Price.
                lblTotal.Text = "Total:" + " " + "$" + Total.ToString() + "*";
            }

            if (ddlLabelSize.SelectedValue == "3" && ddlLabelQuantities.SelectedValue == "2500")
            {
                Double Subtotal = 0;
                Subtotal = Size2x35_2500Quantity;

                //Calculating the price for the colors.
                Double ColorPrice = Stock2500QuantityColor * Convert.ToDouble(NumberOfColors);

                //Calculating the Total Cost.
                Decimal Total = Convert.ToDecimal(Subtotal) + Convert.ToDecimal(ColorPrice);
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
                Subtotal = Size2x2_5000Quantity;

                //Calculating the price for the colors.
                Double ColorPrice = Stock5000QuantityColor * Convert.ToDouble(NumberOfColors);

                //Calculating the Total Cost.
                Decimal Total = Convert.ToDecimal(Subtotal) + Convert.ToDecimal(ColorPrice);
                //formating the numbers that are displays to .00, this is done so people will know that it's money. 
                Total = Convert.ToDecimal(string.Format("{0:0.00}", Total));

                //Displaying the Total Price.
                lblTotal.Text = "Total:" + " " + "$" + Total.ToString() + "*";
            }


            if (ddlLabelSize.SelectedValue == "2" && ddlLabelQuantities.SelectedValue == "5000")
            {
                Double Subtotal = 0;
                Subtotal = Size2x3_5000Quantity;

                //Calculating the price for the colors.
                Double ColorPrice = Stock5000QuantityColor * Convert.ToDouble(NumberOfColors);

                //Calculating the Total Cost.
                Decimal Total = Convert.ToDecimal(Subtotal) + Convert.ToDecimal(ColorPrice);
                //formating the numbers that are displays to .00, this is done so people will know that it's money. 
                Total = Convert.ToDecimal(string.Format("{0:0.00}", Total));

                //Displaying the Total Price.
                lblTotal.Text = "Total:" + " " + "$" + Total.ToString() + "*";
            }

            if (ddlLabelSize.SelectedValue == "3" && ddlLabelQuantities.SelectedValue == "5000")
            {
                Double Subtotal = 0;
                Subtotal = Size2x35_5000Quantity;

                //Calculating the price for the colors.
                Double ColorPrice = Stock5000QuantityColor * Convert.ToDouble(NumberOfColors);

                //Calculating the Total Cost.
                Decimal Total = Convert.ToDecimal(Subtotal) + Convert.ToDecimal(ColorPrice);
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
                Subtotal = Size2x2_10000Quantity;

                //Calculating the price for the colors.
                Double ColorPrice = Stock10000QuantityColor * Convert.ToDouble(NumberOfColors);

                //Calculating the Total Cost.
                Decimal Total = Convert.ToDecimal(Subtotal) + Convert.ToDecimal(ColorPrice);
                //formating the numbers that are displays to .00, this is done so people will know that it's money. 
                Total = Convert.ToDecimal(string.Format("{0:0.00}", Total));

                //Displaying the Total Price.
                lblTotal.Text = "Total:" + " " + "$" + Total.ToString() + "*";
            }


            if (ddlLabelSize.SelectedValue == "2" && ddlLabelQuantities.SelectedValue == "10000")
            {
                Double Subtotal = 0;
                Subtotal = Size2x3_10000Quantity;

                //Calculating the price for the colors.
                Double ColorPrice = Stock1000QuantityColor * Convert.ToDouble(NumberOfColors);

                //Calculating the Total Cost.
                Decimal Total = Convert.ToDecimal(Subtotal) + Convert.ToDecimal(ColorPrice);
                //formating the numbers that are displays to .00, this is done so people will know that it's money. 
                Total = Convert.ToDecimal(string.Format("{0:0.00}", Total));

                //Displaying the Total Price.
                lblTotal.Text = "Total:" + " " + "$" + Total.ToString() + "*";
            }

            if (ddlLabelSize.SelectedValue == "3" && ddlLabelQuantities.SelectedValue == "10000")
            {
                Double Subtotal = 0;
                Subtotal = Size2x35_10000Quantity;

                //Calculating the price for the colors.
                Double ColorPrice = Stock10000QuantityColor * Convert.ToDouble(NumberOfColors);

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