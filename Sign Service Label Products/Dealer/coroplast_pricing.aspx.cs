using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Sign_Service_Label_Products.dealer
{
    public partial class coroplast_pricing : System.Web.UI.Page
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
            //Side 1 Pricing
            //======================================================================================================

            //25 Quantity
            Double Side1_Size12x12_25Quantity = 245.00;
            Double Side1_Size12x24_25Quantity = 263.00;
            Double Side1_Size16x24_25Quantity = 290.00;
            Double Side1_Size18x24_25Quantity = 313.00;
            Double Side1_Size24x24_25Quantity = 323.00;
            Double Side1_Size24x32_25Quantity = 347.00;
            //Color, 25 Quantity.
            Double Side1_25Quantity_SmallPress_Color = 55.00;
            Double Side1_25Quantity_LargePress_Color = 105.00;
            

            //50 Quantity
            Double Side1_Size12x12_50Quantity = 269.00;
            Double Side1_Size12x24_50Quantity = 298.00;
            Double Side1_Size16x24_50Quantity = 339.00;
            Double Side1_Size18x24_50Quantity = 386.00;
            Double Side1_Size24x24_50Quantity = 425.00;
            Double Side1_Size24x32_50Quantity = 443.00;
            //Color, 50 Quantity.
            Double Side1_50Quantity_SmallPress_Color = 60.00;
            Double Side1_50Quantity_LargePress_Color = 115.00;

            //100 Quantity
            Double Side1_Size12x12_100Quantity = 352.00;
            Double Side1_Size12x24_100Quantity = 355.00;
            Double Side1_Size16x24_100Quantity = 423.00;
            Double Side1_Size18x24_100Quantity = 505.00;
            Double Side1_Size24x24_100Quantity = 543.00;
            Double Side1_Size24x32_100Quantity = 595.00;
            //Color, 100 Quantity.
            Double Side1_100Quantity_SmallPress_Color = 65.00;
            Double Side1_100Quantity_LargePress_Color = 125.00;

            //200 Quantity
            Double Side1_Size12x12_200Quantity = 415.00;
            Double Side1_Size12x24_200Quantity = 468.00;
            Double Side1_Size16x24_200Quantity = 591.00;
            Double Side1_Size18x24_200Quantity = 741.00;
            Double Side1_Size24x24_200Quantity = 779.00;
            Double Side1_Size24x32_200Quantity = 899.00;
            //Color, 200 Quantity.
            Double Side1_200Quantity_SmallPress_Color = 70.00;
            Double Side1_200Quantity_LargePress_Color = 140.00;

            //500 Quantity
            Double Side1_Size12x12_500Quantity = 680.00;
            Double Side1_Size12x24_500Quantity = 875.00;
            Double Side1_Size16x24_500Quantity = 1219.00;
            Double Side1_Size18x24_500Quantity = 1595.00;
            Double Side1_Size24x24_500Quantity = 1629.00;
            Double Side1_Size24x32_500Quantity = 1972.00;
            //Color, 500 Quantity.
            Double Side1_500Quantity_SmallPress_Color = 80.00;
            Double Side1_500Quantity_LargePress_Color = 155.00;

           
            //========================================================================================================
            //Number of Colours
            //========================================================================================================
            //Getting the number of colours
            Decimal NumberOfColors = Convert.ToDecimal(txtNumberOfColours.Text) - 1;


            //1 Sided If Statements
            //======================================================================================================
            if (ddlSideOption.SelectedValue == "1")
            {
                //12 x 12 If Statements
                //======================================================================================================

                //25 Quantity If Statements
                //======================================================================================================
                if (ddlLabelSize.SelectedValue == "1" && ddlLabelQuantities.SelectedValue == "25")
                {
                    Double Subtotal = 0;
                    Subtotal = Side1_Size12x12_25Quantity;

                    //Calculating the price for the colors.
                    Double ColorPrice = Side1_25Quantity_SmallPress_Color * Convert.ToDouble(NumberOfColors);

                    //Calculating the Total Cost.
                    Decimal Total = Convert.ToDecimal(Subtotal) + Convert.ToDecimal(ColorPrice);
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
                    Subtotal = Side1_Size12x12_50Quantity;

                    //Calculating the price for the colors.
                    Double ColorPrice = Side1_50Quantity_SmallPress_Color * Convert.ToDouble(NumberOfColors);

                    //Calculating the Total Cost.
                    Decimal Total = Convert.ToDecimal(Subtotal) + Convert.ToDecimal(ColorPrice);
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
                    Subtotal = Side1_Size12x12_100Quantity;

                    //Calculating the price for the colors.
                    Double ColorPrice = Side1_100Quantity_SmallPress_Color * Convert.ToDouble(NumberOfColors);

                    //Calculating the Total Cost.
                    Decimal Total = Convert.ToDecimal(Subtotal) + Convert.ToDecimal(ColorPrice);
                    //formating the numbers that are displays to .00, this is done so people will know that it's money. 
                    Total = Convert.ToDecimal(string.Format("{0:0.00}", Total));

                    //Displaying the Total Price.
                    lblTotal.Text = "Total:" + " " + "$" + Total.ToString() + "*";
                }

                //200 Quantity If Statements
                //======================================================================================================
                if (ddlLabelSize.SelectedValue == "1" && ddlLabelQuantities.SelectedValue == "200")
                {
                    Double Subtotal = 0;
                    Subtotal = Side1_Size12x12_200Quantity;

                    //Calculating the price for the colors.
                    Double ColorPrice = Side1_200Quantity_SmallPress_Color * Convert.ToDouble(NumberOfColors);

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
                    Subtotal = Side1_Size12x12_500Quantity;

                    //Calculating the price for the colors.
                    Double ColorPrice = Side1_500Quantity_SmallPress_Color * Convert.ToDouble(NumberOfColors);

                    //Calculating the Total Cost.
                    Decimal Total = Convert.ToDecimal(Subtotal) + Convert.ToDecimal(ColorPrice);
                    //formating the numbers that are displays to .00, this is done so people will know that it's money. 
                    Total = Convert.ToDecimal(string.Format("{0:0.00}", Total));

                    //Displaying the Total Price.
                    lblTotal.Text = "Total:" + " " + "$" + Total.ToString() + "*";
                }


                //12 x 24 If Statements
                //======================================================================================================

                //25 Quantity If Statements
                //======================================================================================================
                if (ddlLabelSize.SelectedValue == "2" && ddlLabelQuantities.SelectedValue == "25")
                {
                    Double Subtotal = 0;
                    Subtotal = Side1_Size12x24_25Quantity;

                    //Calculating the price for the colors.
                    Double ColorPrice = Side1_25Quantity_SmallPress_Color * Convert.ToDouble(NumberOfColors);

                    //Calculating the Total Cost.
                    Decimal Total = Convert.ToDecimal(Subtotal) + Convert.ToDecimal(ColorPrice);
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
                    Subtotal = Side1_Size12x24_50Quantity;

                    //Calculating the price for the colors.
                    Double ColorPrice = Side1_50Quantity_SmallPress_Color * Convert.ToDouble(NumberOfColors);

                    //Calculating the Total Cost.
                    Decimal Total = Convert.ToDecimal(Subtotal) + Convert.ToDecimal(ColorPrice);
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
                    Subtotal = Side1_Size12x24_100Quantity;

                    //Calculating the price for the colors.
                    Double ColorPrice = Side1_100Quantity_SmallPress_Color * Convert.ToDouble(NumberOfColors);

                    //Calculating the Total Cost.
                    Decimal Total = Convert.ToDecimal(Subtotal) + Convert.ToDecimal(ColorPrice);
                    //formating the numbers that are displays to .00, this is done so people will know that it's money. 
                    Total = Convert.ToDecimal(string.Format("{0:0.00}", Total));

                    //Displaying the Total Price.
                    lblTotal.Text = "Total:" + " " + "$" + Total.ToString() + "*";
                }

                //200 Quantity If Statements
                //======================================================================================================
                if (ddlLabelSize.SelectedValue == "2" && ddlLabelQuantities.SelectedValue == "200")
                {
                    Double Subtotal = 0;
                    Subtotal = Side1_Size12x24_200Quantity;

                    //Calculating the price for the colors.
                    Double ColorPrice = Side1_200Quantity_SmallPress_Color * Convert.ToDouble(NumberOfColors);

                    //Calculating the Total Cost.
                    Decimal Total = Convert.ToDecimal(Subtotal) + Convert.ToDecimal(ColorPrice);
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
                    Subtotal = Side1_Size12x24_500Quantity;

                    //Calculating the price for the colors.
                    Double ColorPrice = Side1_500Quantity_SmallPress_Color * Convert.ToDouble(NumberOfColors);

                    //Calculating the Total Cost.
                    Decimal Total = Convert.ToDecimal(Subtotal) + Convert.ToDecimal(ColorPrice);
                    //formating the numbers that are displays to .00, this is done so people will know that it's money. 
                    Total = Convert.ToDecimal(string.Format("{0:0.00}", Total));

                    //Displaying the Total Price.
                    lblTotal.Text = "Total:" + " " + "$" + Total.ToString() + "*";
                }

                //16 x 24 If Statements
                //======================================================================================================

                //25 Quantity If Statements
                //======================================================================================================
                if (ddlLabelSize.SelectedValue == "3" && ddlLabelQuantities.SelectedValue == "25")
                {
                    Double Subtotal = 0;
                    Subtotal = Side1_Size16x24_25Quantity;

                    //Calculating the price for the colors.
                    Double ColorPrice = Side1_25Quantity_LargePress_Color * Convert.ToDouble(NumberOfColors);

                    //Calculating the Total Cost.
                    Decimal Total = Convert.ToDecimal(Subtotal) + Convert.ToDecimal(ColorPrice);
                    //formating the numbers that are displays to .00, this is done so people will know that it's money. 
                    Total = Convert.ToDecimal(string.Format("{0:0.00}", Total));

                    //Displaying the Total Price.
                    lblTotal.Text = "Total:" + " " + "$" + Total.ToString() + "*";
                }

                //50 Quantity If Statements
                //======================================================================================================
                if (ddlLabelSize.SelectedValue == "3" && ddlLabelQuantities.SelectedValue == "50")
                {
                    Double Subtotal = 0;
                    Subtotal = Side1_Size16x24_50Quantity;

                    //Calculating the price for the colors.
                    Double ColorPrice = Side1_50Quantity_LargePress_Color * Convert.ToDouble(NumberOfColors);

                    //Calculating the Total Cost.
                    Decimal Total = Convert.ToDecimal(Subtotal) + Convert.ToDecimal(ColorPrice);
                    //formating the numbers that are displays to .00, this is done so people will know that it's money. 
                    Total = Convert.ToDecimal(string.Format("{0:0.00}", Total));

                    //Displaying the Total Price.
                    lblTotal.Text = "Total:" + " " + "$" + Total.ToString() + "*";
                }

                //100 Quantity If Statements
                //======================================================================================================
                if (ddlLabelSize.SelectedValue == "3" && ddlLabelQuantities.SelectedValue == "100")
                {
                    Double Subtotal = 0;
                    Subtotal = Side1_Size16x24_100Quantity;

                    //Calculating the price for the colors.
                    Double ColorPrice = Side1_100Quantity_LargePress_Color * Convert.ToDouble(NumberOfColors);

                    //Calculating the Total Cost.
                    Decimal Total = Convert.ToDecimal(Subtotal) + Convert.ToDecimal(ColorPrice);
                    //formating the numbers that are displays to .00, this is done so people will know that it's money. 
                    Total = Convert.ToDecimal(string.Format("{0:0.00}", Total));

                    //Displaying the Total Price.
                    lblTotal.Text = "Total:" + " " + "$" + Total.ToString() + "*";
                }

                //200 Quantity If Statements
                //======================================================================================================
                if (ddlLabelSize.SelectedValue == "3" && ddlLabelQuantities.SelectedValue == "200")
                {
                    Double Subtotal = 0;
                    Subtotal = Side1_Size16x24_200Quantity;

                    //Calculating the price for the colors.
                    Double ColorPrice = Side1_200Quantity_LargePress_Color * Convert.ToDouble(NumberOfColors);

                    //Calculating the Total Cost.
                    Decimal Total = Convert.ToDecimal(Subtotal) + Convert.ToDecimal(ColorPrice);
                    //formating the numbers that are displays to .00, this is done so people will know that it's money. 
                    Total = Convert.ToDecimal(string.Format("{0:0.00}", Total));

                    //Displaying the Total Price.
                    lblTotal.Text = "Total:" + " " + "$" + Total.ToString() + "*";
                }

                //500 Quantity If Statements
                //======================================================================================================
                if (ddlLabelSize.SelectedValue == "3" && ddlLabelQuantities.SelectedValue == "500")
                {
                    Double Subtotal = 0;
                    Subtotal = Side1_Size16x24_500Quantity;

                    //Calculating the price for the colors.
                    Double ColorPrice = Side1_500Quantity_LargePress_Color * Convert.ToDouble(NumberOfColors);

                    //Calculating the Total Cost.
                    Decimal Total = Convert.ToDecimal(Subtotal) + Convert.ToDecimal(ColorPrice);
                    //formating the numbers that are displays to .00, this is done so people will know that it's money. 
                    Total = Convert.ToDecimal(string.Format("{0:0.00}", Total));

                    //Displaying the Total Price.
                    lblTotal.Text = "Total:" + " " + "$" + Total.ToString() + "*";
                }

                //18 x 24 If Statements
                //======================================================================================================

                //25 Quantity If Statements
                //======================================================================================================
                if (ddlLabelSize.SelectedValue == "4" && ddlLabelQuantities.SelectedValue == "25")
                {
                    Double Subtotal = 0;
                    Subtotal = Side1_Size18x24_25Quantity;

                    //Calculating the price for the colors.
                    Double ColorPrice = Side1_25Quantity_LargePress_Color * Convert.ToDouble(NumberOfColors);

                    //Calculating the Total Cost.
                    Decimal Total = Convert.ToDecimal(Subtotal) + Convert.ToDecimal(ColorPrice);
                    //formating the numbers that are displays to .00, this is done so people will know that it's money. 
                    Total = Convert.ToDecimal(string.Format("{0:0.00}", Total));

                    //Displaying the Total Price.
                    lblTotal.Text = "Total:" + " " + "$" + Total.ToString() + "*";
                }

                //50 Quantity If Statements
                //======================================================================================================
                if (ddlLabelSize.SelectedValue == "4" && ddlLabelQuantities.SelectedValue == "50")
                {
                    Double Subtotal = 0;
                    Subtotal = Side1_Size18x24_50Quantity;

                    //Calculating the price for the colors.
                    Double ColorPrice = Side1_50Quantity_LargePress_Color * Convert.ToDouble(NumberOfColors);

                    //Calculating the Total Cost.
                    Decimal Total = Convert.ToDecimal(Subtotal) + Convert.ToDecimal(ColorPrice);
                    //formating the numbers that are displays to .00, this is done so people will know that it's money. 
                    Total = Convert.ToDecimal(string.Format("{0:0.00}", Total));

                    //Displaying the Total Price.
                    lblTotal.Text = "Total:" + " " + "$" + Total.ToString() + "*";
                }

                //100 Quantity If Statements
                //======================================================================================================
                if (ddlLabelSize.SelectedValue == "4" && ddlLabelQuantities.SelectedValue == "100")
                {
                    Double Subtotal = 0;
                    Subtotal = Side1_Size18x24_100Quantity;

                    //Calculating the price for the colors.
                    Double ColorPrice = Side1_100Quantity_LargePress_Color * Convert.ToDouble(NumberOfColors);

                    //Calculating the Total Cost.
                    Decimal Total = Convert.ToDecimal(Subtotal) + Convert.ToDecimal(ColorPrice);
                    //formating the numbers that are displays to .00, this is done so people will know that it's money. 
                    Total = Convert.ToDecimal(string.Format("{0:0.00}", Total));

                    //Displaying the Total Price.
                    lblTotal.Text = "Total:" + " " + "$" + Total.ToString() + "*";
                }

                //200 Quantity If Statements
                //======================================================================================================
                if (ddlLabelSize.SelectedValue == "4" && ddlLabelQuantities.SelectedValue == "200")
                {
                    Double Subtotal = 0;
                    Subtotal = Side1_Size18x24_200Quantity;

                    //Calculating the price for the colors.
                    Double ColorPrice = Side1_200Quantity_LargePress_Color * Convert.ToDouble(NumberOfColors);

                    //Calculating the Total Cost.
                    Decimal Total = Convert.ToDecimal(Subtotal) + Convert.ToDecimal(ColorPrice);
                    //formating the numbers that are displays to .00, this is done so people will know that it's money. 
                    Total = Convert.ToDecimal(string.Format("{0:0.00}", Total));

                    //Displaying the Total Price.
                    lblTotal.Text = "Total:" + " " + "$" + Total.ToString() + "*";
                }

                //500 Quantity If Statements
                //======================================================================================================
                if (ddlLabelSize.SelectedValue == "4" && ddlLabelQuantities.SelectedValue == "500")
                {
                    Double Subtotal = 0;
                    Subtotal = Side1_Size18x24_500Quantity;

                    //Calculating the price for the colors.
                    Double ColorPrice = Side1_500Quantity_LargePress_Color * Convert.ToDouble(NumberOfColors);

                    //Calculating the Total Cost.
                    Decimal Total = Convert.ToDecimal(Subtotal) + Convert.ToDecimal(ColorPrice);
                    //formating the numbers that are displays to .00, this is done so people will know that it's money. 
                    Total = Convert.ToDecimal(string.Format("{0:0.00}", Total));

                    //Displaying the Total Price.
                    lblTotal.Text = "Total:" + " " + "$" + Total.ToString() + "*";
                }

                //18 x 24 If Statements
                //======================================================================================================

                //25 Quantity If Statements
                //======================================================================================================
                if (ddlLabelSize.SelectedValue == "5" && ddlLabelQuantities.SelectedValue == "25")
                {
                    Double Subtotal = 0;
                    Subtotal = Side1_Size24x24_25Quantity;

                    //Calculating the price for the colors.
                    Double ColorPrice = Side1_25Quantity_LargePress_Color * Convert.ToDouble(NumberOfColors);

                    //Calculating the Total Cost.
                    Decimal Total = Convert.ToDecimal(Subtotal) + Convert.ToDecimal(ColorPrice);
                    //formating the numbers that are displays to .00, this is done so people will know that it's money. 
                    Total = Convert.ToDecimal(string.Format("{0:0.00}", Total));

                    //Displaying the Total Price.
                    lblTotal.Text = "Total:" + " " + "$" + Total.ToString() + "*";
                }

                //50 Quantity If Statements
                //======================================================================================================
                if (ddlLabelSize.SelectedValue == "5" && ddlLabelQuantities.SelectedValue == "50")
                {
                    Double Subtotal = 0;
                    Subtotal = Side1_Size24x24_50Quantity;

                    //Calculating the price for the colors.
                    Double ColorPrice = Side1_50Quantity_LargePress_Color * Convert.ToDouble(NumberOfColors);

                    //Calculating the Total Cost.
                    Decimal Total = Convert.ToDecimal(Subtotal) + Convert.ToDecimal(ColorPrice);
                    //formating the numbers that are displays to .00, this is done so people will know that it's money. 
                    Total = Convert.ToDecimal(string.Format("{0:0.00}", Total));

                    //Displaying the Total Price.
                    lblTotal.Text = "Total:" + " " + "$" + Total.ToString() + "*";
                }

                //100 Quantity If Statements
                //======================================================================================================
                if (ddlLabelSize.SelectedValue == "5" && ddlLabelQuantities.SelectedValue == "100")
                {
                    Double Subtotal = 0;
                    Subtotal = Side1_Size24x24_100Quantity;

                    //Calculating the price for the colors.
                    Double ColorPrice = Side1_100Quantity_LargePress_Color * Convert.ToDouble(NumberOfColors);

                    //Calculating the Total Cost.
                    Decimal Total = Convert.ToDecimal(Subtotal) + Convert.ToDecimal(ColorPrice);
                    //formating the numbers that are displays to .00, this is done so people will know that it's money. 
                    Total = Convert.ToDecimal(string.Format("{0:0.00}", Total));

                    //Displaying the Total Price.
                    lblTotal.Text = "Total:" + " " + "$" + Total.ToString() + "*";
                }

                //200 Quantity If Statements
                //======================================================================================================
                if (ddlLabelSize.SelectedValue == "5" && ddlLabelQuantities.SelectedValue == "200")
                {
                    Double Subtotal = 0;
                    Subtotal = Side1_Size24x24_200Quantity;

                    //Calculating the price for the colors.
                    Double ColorPrice = Side1_200Quantity_LargePress_Color * Convert.ToDouble(NumberOfColors);

                    //Calculating the Total Cost.
                    Decimal Total = Convert.ToDecimal(Subtotal) + Convert.ToDecimal(ColorPrice);
                    //formating the numbers that are displays to .00, this is done so people will know that it's money. 
                    Total = Convert.ToDecimal(string.Format("{0:0.00}", Total));

                    //Displaying the Total Price.
                    lblTotal.Text = "Total:" + " " + "$" + Total.ToString() + "*";
                }

                //500 Quantity If Statements
                //======================================================================================================
                if (ddlLabelSize.SelectedValue == "5" && ddlLabelQuantities.SelectedValue == "500")
                {
                    Double Subtotal = 0;
                    Subtotal = Side1_Size24x24_500Quantity;

                    //Calculating the price for the colors.
                    Double ColorPrice = Side1_500Quantity_LargePress_Color * Convert.ToDouble(NumberOfColors);

                    //Calculating the Total Cost.
                    Decimal Total = Convert.ToDecimal(Subtotal) + Convert.ToDecimal(ColorPrice);
                    //formating the numbers that are displays to .00, this is done so people will know that it's money. 
                    Total = Convert.ToDecimal(string.Format("{0:0.00}", Total));

                    //Displaying the Total Price.
                    lblTotal.Text = "Total:" + " " + "$" + Total.ToString() + "*";
                }


                //18 x 24 If Statements
                //======================================================================================================

                //25 Quantity If Statements
                //======================================================================================================
                if (ddlLabelSize.SelectedValue == "6" && ddlLabelQuantities.SelectedValue == "25")
                {
                    Double Subtotal = 0;
                    Subtotal = Side1_Size24x32_25Quantity;

                    //Calculating the price for the colors.
                    Double ColorPrice = Side1_25Quantity_LargePress_Color * Convert.ToDouble(NumberOfColors);

                    //Calculating the Total Cost.
                    Decimal Total = Convert.ToDecimal(Subtotal) + Convert.ToDecimal(ColorPrice);
                    //formating the numbers that are displays to .00, this is done so people will know that it's money. 
                    Total = Convert.ToDecimal(string.Format("{0:0.00}", Total));

                    //Displaying the Total Price.
                    lblTotal.Text = "Total:" + " " + "$" + Total.ToString() + "*";
                }

                //50 Quantity If Statements
                //======================================================================================================
                if (ddlLabelSize.SelectedValue == "6" && ddlLabelQuantities.SelectedValue == "50")
                {
                    Double Subtotal = 0;
                    Subtotal = Side1_Size24x32_50Quantity;

                    //Calculating the price for the colors.
                    Double ColorPrice = Side1_50Quantity_LargePress_Color * Convert.ToDouble(NumberOfColors);

                    //Calculating the Total Cost.
                    Decimal Total = Convert.ToDecimal(Subtotal) + Convert.ToDecimal(ColorPrice);
                    //formating the numbers that are displays to .00, this is done so people will know that it's money. 
                    Total = Convert.ToDecimal(string.Format("{0:0.00}", Total));

                    //Displaying the Total Price.
                    lblTotal.Text = "Total:" + " " + "$" + Total.ToString() + "*";
                }

                //100 Quantity If Statements
                //======================================================================================================
                if (ddlLabelSize.SelectedValue == "6" && ddlLabelQuantities.SelectedValue == "100")
                {
                    Double Subtotal = 0;
                    Subtotal = Side1_Size24x32_100Quantity;

                    //Calculating the price for the colors.
                    Double ColorPrice = Side1_100Quantity_LargePress_Color * Convert.ToDouble(NumberOfColors);

                    //Calculating the Total Cost.
                    Decimal Total = Convert.ToDecimal(Subtotal) + Convert.ToDecimal(ColorPrice);
                    //formating the numbers that are displays to .00, this is done so people will know that it's money. 
                    Total = Convert.ToDecimal(string.Format("{0:0.00}", Total));

                    //Displaying the Total Price.
                    lblTotal.Text = "Total:" + " " + "$" + Total.ToString() + "*";
                }

                //200 Quantity If Statements
                //======================================================================================================
                if (ddlLabelSize.SelectedValue == "6" && ddlLabelQuantities.SelectedValue == "200")
                {
                    Double Subtotal = 0;
                    Subtotal = Side1_Size24x32_200Quantity;

                    //Calculating the price for the colors.
                    Double ColorPrice = Side1_200Quantity_LargePress_Color * Convert.ToDouble(NumberOfColors);

                    //Calculating the Total Cost.
                    Decimal Total = Convert.ToDecimal(Subtotal) + Convert.ToDecimal(ColorPrice);
                    //formating the numbers that are displays to .00, this is done so people will know that it's money. 
                    Total = Convert.ToDecimal(string.Format("{0:0.00}", Total));

                    //Displaying the Total Price.
                    lblTotal.Text = "Total:" + " " + "$" + Total.ToString() + "*";
                }

                //500 Quantity If Statements
                //======================================================================================================
                if (ddlLabelSize.SelectedValue == "6" && ddlLabelQuantities.SelectedValue == "500")
                {
                    Double Subtotal = 0;
                    Subtotal = Side1_Size24x32_500Quantity;

                    //Calculating the price for the colors.
                    Double ColorPrice = Side1_500Quantity_LargePress_Color * Convert.ToDouble(NumberOfColors);

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
}