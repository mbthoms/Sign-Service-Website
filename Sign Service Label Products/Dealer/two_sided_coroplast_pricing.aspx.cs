using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Sign_Service_Label_Products.dealer
{
    public partial class two_sided_coroplast_pricing : System.Web.UI.Page
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
            //Side 2 Pricing
            //======================================================================================================

            //25 Quantity
            Double Side2_Size12x12_25Quantity = 295.00;
            Double Side2_Size12x24_25Quantity = 313.00;
            Double Side2_Size16x24_25Quantity = 340.00;
            Double Side2_Size18x24_25Quantity = 363.00;
            Double Side2_Size24x24_25Quantity = 373.00;
            Double Side2_Size24x32_25Quantity = 397.00;
            //Color, 25 Quantity.
            Double Side2_25Quantity_SmallPress_Color = 105.00;
            Double Side2_25Quantity_LargePress_Color = 115.00;


            //50 Quantity
            Double Side2_Size12x12_50Quantity = 334.00;
            Double Side2_Size12x24_50Quantity = 363.00;
            Double Side2_Size16x24_50Quantity = 404.00;
            Double Side2_Size18x24_50Quantity = 451.00;
            Double Side2_Size24x24_50Quantity = 490.00;
            Double Side2_Size24x32_50Quantity = 508.00;
            //Color, 50 Quantity.
            Double Side2_50Quantity_SmallPress_Color = 130.00;
            Double Side2_50Quantity_LargePress_Color = 150.00;

            //100 Quantity
            Double Side2_Size12x12_100Quantity = 442.00;
            Double Side2_Size12x24_100Quantity = 445.00;
            Double Side2_Size16x24_100Quantity = 513.00;
            Double Side2_Size18x24_100Quantity = 595.00;
            Double Side2_Size24x24_100Quantity = 633.00;
            Double Side2_Size24x32_100Quantity = 685.00;
            //Color, 100 Quantity.
            Double Side2_100Quantity_SmallPress_Color = 150.00;
            Double Side2_100Quantity_LargePress_Color = 200.00;

            //200 Quantity
            Double Side2_Size12x12_200Quantity = 595.00;
            Double Side2_Size12x24_200Quantity = 648.00;
            Double Side2_Size16x24_200Quantity = 771.00;
            Double Side2_Size18x24_200Quantity = 921.00;
            Double Side2_Size24x24_200Quantity = 959.00;
            Double Side2_Size24x32_200Quantity = 1079.00;
            //Color, 200 Quantity.
            Double Side2_200Quantity_SmallPress_Color = 180.00;
            Double Side2_200Quantity_LargePress_Color = 270.00;

            //500 Quantity
            Double Side2_Size12x12_500Quantity = 995.00;
            Double Side2_Size12x24_500Quantity = 1180.00;
            Double Side2_Size16x24_500Quantity = 1524.00;
            Double Side2_Size18x24_500Quantity = 1900.00;
            Double Side2_Size24x24_500Quantity = 1934.00;
            Double Side2_Size24x32_500Quantity = 2277.00;
            //Color, 500 Quantity.
            Double Side2_500Quantity_SmallPress_Color = 305.00;
            Double Side2_500Quantity_LargePress_Color = 585.00;


            //========================================================================================================
            //Number of Colours
            //========================================================================================================
            //Getting the number of colours
            Decimal NumberOfColors = Convert.ToDecimal(txtNumberOfColours.Text) + Convert.ToDecimal(txtBackColours.Text) - 2;


            //2 Sided If Statements
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
                    Subtotal = Side2_Size12x12_25Quantity;

                    //Calculating the price for the colors.
                    Double ColorPrice = Side2_25Quantity_SmallPress_Color * Convert.ToDouble(NumberOfColors);

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
                    Subtotal = Side2_Size12x12_50Quantity;

                    //Calculating the price for the colors.
                    Double ColorPrice = Side2_50Quantity_SmallPress_Color * Convert.ToDouble(NumberOfColors);

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
                    Subtotal = Side2_Size12x12_100Quantity;

                    //Calculating the price for the colors.
                    Double ColorPrice = Side2_100Quantity_SmallPress_Color * Convert.ToDouble(NumberOfColors);

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
                    Subtotal = Side2_Size12x12_200Quantity;

                    //Calculating the price for the colors.
                    Double ColorPrice = Side2_200Quantity_SmallPress_Color * Convert.ToDouble(NumberOfColors);

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
                    Subtotal = Side2_Size12x12_500Quantity;

                    //Calculating the price for the colors.
                    Double ColorPrice = Side2_500Quantity_SmallPress_Color * Convert.ToDouble(NumberOfColors);

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
                    Subtotal = Side2_Size12x24_25Quantity;

                    //Calculating the price for the colors.
                    Double ColorPrice = Side2_25Quantity_SmallPress_Color * Convert.ToDouble(NumberOfColors);

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
                    Subtotal = Side2_Size12x24_50Quantity;

                    //Calculating the price for the colors.
                    Double ColorPrice = Side2_50Quantity_SmallPress_Color * Convert.ToDouble(NumberOfColors);

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
                    Subtotal = Side2_Size12x24_100Quantity;

                    //Calculating the price for the colors.
                    Double ColorPrice = Side2_100Quantity_SmallPress_Color * Convert.ToDouble(NumberOfColors);

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
                    Subtotal = Side2_Size12x24_200Quantity;

                    //Calculating the price for the colors.
                    Double ColorPrice = Side2_200Quantity_SmallPress_Color * Convert.ToDouble(NumberOfColors);

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
                    Subtotal = Side2_Size12x24_500Quantity;

                    //Calculating the price for the colors.
                    Double ColorPrice = Side2_500Quantity_SmallPress_Color * Convert.ToDouble(NumberOfColors);

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
                    Subtotal = Side2_Size16x24_25Quantity;

                    //Calculating the price for the colors.
                    Double ColorPrice = Side2_25Quantity_LargePress_Color * Convert.ToDouble(NumberOfColors);

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
                    Subtotal = Side2_Size16x24_50Quantity;

                    //Calculating the price for the colors.
                    Double ColorPrice = Side2_50Quantity_LargePress_Color * Convert.ToDouble(NumberOfColors);

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
                    Subtotal = Side2_Size16x24_100Quantity;

                    //Calculating the price for the colors.
                    Double ColorPrice = Side2_100Quantity_LargePress_Color * Convert.ToDouble(NumberOfColors);

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
                    Subtotal = Side2_Size16x24_200Quantity;

                    //Calculating the price for the colors.
                    Double ColorPrice = Side2_200Quantity_LargePress_Color * Convert.ToDouble(NumberOfColors);

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
                    Subtotal = Side2_Size16x24_500Quantity;

                    //Calculating the price for the colors.
                    Double ColorPrice = Side2_500Quantity_LargePress_Color * Convert.ToDouble(NumberOfColors);

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
                    Subtotal = Side2_Size18x24_25Quantity;

                    //Calculating the price for the colors.
                    Double ColorPrice = Side2_25Quantity_LargePress_Color * Convert.ToDouble(NumberOfColors);

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
                    Subtotal = Side2_Size18x24_50Quantity;

                    //Calculating the price for the colors.
                    Double ColorPrice = Side2_50Quantity_LargePress_Color * Convert.ToDouble(NumberOfColors);

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
                    Subtotal = Side2_Size18x24_100Quantity;

                    //Calculating the price for the colors.
                    Double ColorPrice = Side2_100Quantity_LargePress_Color * Convert.ToDouble(NumberOfColors);

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
                    Subtotal = Side2_Size18x24_200Quantity;

                    //Calculating the price for the colors.
                    Double ColorPrice = Side2_200Quantity_LargePress_Color * Convert.ToDouble(NumberOfColors);

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
                    Subtotal = Side2_Size18x24_500Quantity;

                    //Calculating the price for the colors.
                    Double ColorPrice = Side2_500Quantity_LargePress_Color * Convert.ToDouble(NumberOfColors);

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
                    Subtotal = Side2_Size24x24_25Quantity;

                    //Calculating the price for the colors.
                    Double ColorPrice = Side2_25Quantity_LargePress_Color * Convert.ToDouble(NumberOfColors);

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
                    Subtotal = Side2_Size24x24_50Quantity;

                    //Calculating the price for the colors.
                    Double ColorPrice = Side2_50Quantity_LargePress_Color * Convert.ToDouble(NumberOfColors);

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
                    Subtotal = Side2_Size24x24_100Quantity;

                    //Calculating the price for the colors.
                    Double ColorPrice = Side2_100Quantity_LargePress_Color * Convert.ToDouble(NumberOfColors);

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
                    Subtotal = Side2_Size24x24_200Quantity;

                    //Calculating the price for the colors.
                    Double ColorPrice = Side2_200Quantity_LargePress_Color * Convert.ToDouble(NumberOfColors);

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
                    Subtotal = Side2_Size24x24_500Quantity;

                    //Calculating the price for the colors.
                    Double ColorPrice = Side2_500Quantity_LargePress_Color * Convert.ToDouble(NumberOfColors);

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
                    Subtotal = Side2_Size24x32_25Quantity;

                    //Calculating the price for the colors.
                    Double ColorPrice = Side2_25Quantity_LargePress_Color * Convert.ToDouble(NumberOfColors);

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
                    Subtotal = Side2_Size24x32_50Quantity;

                    //Calculating the price for the colors.
                    Double ColorPrice = Side2_50Quantity_LargePress_Color * Convert.ToDouble(NumberOfColors);

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
                    Subtotal = Side2_Size24x32_100Quantity;

                    //Calculating the price for the colors.
                    Double ColorPrice = Side2_100Quantity_LargePress_Color * Convert.ToDouble(NumberOfColors);

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
                    Subtotal = Side2_Size24x32_200Quantity;

                    //Calculating the price for the colors.
                    Double ColorPrice = Side2_200Quantity_LargePress_Color * Convert.ToDouble(NumberOfColors);

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
                    Subtotal = Side2_Size24x32_500Quantity;

                    //Calculating the price for the colors.
                    Double ColorPrice = Side2_500Quantity_LargePress_Color * Convert.ToDouble(NumberOfColors);

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