using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Sign_Service_Label_Products.dealer
{
    public partial class solid_silver_foil_pricing : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            //Hides the Message if showing when you press the "Get Quote" button the quote page template.
            if (IsPostBack)
            {
                lblCustomQuoteMessage.Text = "";
            }
        }

        protected void btnFindPrices_Click(object sender, EventArgs e)
        {
            //Global Vars
            //======================================================================================================
            String CustomQuoteMessage = "<div class='alert alert-danger' role='alert'>Please call or email our sales desk for a custom quote at: <a href='tel:18007872382'>1 (800)-787-2382</a><br />or <a href='mailto:sales@signservice.com'>sales@signservice.com</a></div>";

            //======================================================================================================
            //Pricing
            //======================================================================================================

            //50 Quantity.
            Double Stock1_0_2_5SqIn_50Quantity = 147.00;
            Double Stock1_2_5_5SqIn_50Quantity = 147.00;
            Double Stock1_5_10SqIn_50Quantity = 157.00;
            Double Stock1_10_15SqIn_50Quantity = 166.00;
            Double Stock1_15_20SqIn_50Quantity = 174.00;
            Double Stock1_20_25SqIn_50Quantity = 187.00;
            Double Stock1_25_30SqIn_50Quantity = 204.00;
            Double Stock1_30_35SqIn_50Quantity = 205.00;
            Double Stock1_35_40SqIn_50Quantity = 215.00;
            //Color, 50 Quantity.
            Double Stock1Color_50Quantity = 60.00;

            //100 Quantity.
            Double Stock1_0_2_5SqIn_100Quantity = 166.00;
            Double Stock1_2_5_5SqIn_100Quantity = 166.00;
            Double Stock1_5_10SqIn_100Quantity = 184.00;
            Double Stock1_10_15SqIn_100Quantity = 201.00;
            Double Stock1_15_20SqIn_100Quantity = 216.00;
            Double Stock1_20_25SqIn_100Quantity = 241.00;
            Double Stock1_25_30SqIn_100Quantity = 275.00;
            Double Stock1_30_35SqIn_100Quantity = 276.00;
            Double Stock1_35_40SqIn_100Quantity = 293.00;
            //Color, 100 Quantity.
            Double Stock1Color_100Quantity = 65.00;

            //250 Quantity.
            Double Stock1_0_2_5SqIn_250Quantity = 222.00;
            Double Stock1_2_5_5SqIn_250Quantity = 222.00;
            Double Stock1_5_10SqIn_250Quantity = 267.00;
            Double Stock1_10_15SqIn_250Quantity = 305.00;
            Double Stock1_15_20SqIn_250Quantity = 343.00;
            Double Stock1_20_25SqIn_250Quantity = 404.00;
            Double Stock1_25_30SqIn_250Quantity = 486.00;
            Double Stock1_30_35SqIn_250Quantity = 487.00;
            Double Stock1_35_40SqIn_250Quantity = 529.00;
            //Color, 250 Quantity.
            Double Stock1Color_250Quantity = 75.00;

            //500 Quantity.
            Double Stock1_0_2_5SqIn_500Quantity = 239.00;
            Double Stock1_2_5_5SqIn_500Quantity = 279.00;
            Double Stock1_5_10SqIn_500Quantity = 367.00;
            Double Stock1_10_15SqIn_500Quantity = 466.00;
            Double Stock1_15_20SqIn_500Quantity = 541.00;
            Double Stock1_20_25SqIn_500Quantity = 664.00;
            Double Stock1_25_30SqIn_500Quantity = 666.00;
            Double Stock1_30_35SqIn_500Quantity = 911.00;
            Double Stock1_35_40SqIn_500Quantity = 913.00;
            //Color, 250 Quantity.
            Double Stock1Color_500Quantity = 80.00;

            //1000 Quantity.
            Double Stock1_0_2_5SqIn_1000Quantity = 334.00;
            Double Stock1_2_5_5SqIn_1000Quantity = 405.00;
            Double Stock1_5_10SqIn_1000Quantity = 565.00;
            Double Stock1_10_15SqIn_1000Quantity = 788.00;
            Double Stock1_15_20SqIn_1000Quantity = 937.00;
            Double Stock1_20_25SqIn_1000Quantity = 1184.00;
            Double Stock1_25_30SqIn_1000Quantity = 1188.00;
            Double Stock1_30_35SqIn_1000Quantity = 1677.00;
            Double Stock1_35_40SqIn_1000Quantity = 1681.00;
            //Color, 250 Quantity.
            Double Stock1Color_1000Quantity = 85.00;

            //2000 Quantity.
            Double Stock1_0_2_5SqIn_2000Quantity = 488.00;
            Double Stock1_2_5_5SqIn_2000Quantity = 613.00;
            Double Stock1_5_10SqIn_2000Quantity = 986.00;
            Double Stock1_10_15SqIn_2000Quantity = 1721.00;
            Double Stock1_15_20SqIn_2000Quantity = 1730.00;
            Double Stock1_20_25SqIn_2000Quantity = 2237.00;
            Double Stock1_25_30SqIn_2000Quantity = 2243.00;
            Double Stock1_30_35SqIn_2000Quantity = 3258.00;
            Double Stock1_35_40SqIn_2000Quantity = 3262.00;
            //Color, 250 Quantity.
            Double Stock1Color_2000Quantity = 100.00;

            //2500 Quantity.
            Double Stock1_0_2_5SqIn_2500Quantity = 549.00;
            Double Stock1_2_5_5SqIn_2500Quantity = 727.00;
            Double Stock1_5_10SqIn_2500Quantity = 1186.00;
            Double Stock1_10_15SqIn_2500Quantity = 1952.00;
            Double Stock1_15_20SqIn_2500Quantity = 2075.00;
            Double Stock1_20_25SqIn_2500Quantity = 2690.00;
            Double Stock1_25_30SqIn_2500Quantity = 2696.00;
            Double Stock1_30_35SqIn_2500Quantity = 3925.00;
            Double Stock1_35_40SqIn_2500Quantity = 3929.00;
            //Color, 250 Quantity.
            Double Stock1Color_2500Quantity = 115.00;

            //5000 Quantity.
            Double Stock1_0_2_5SqIn_5000Quantity = 855.00;
            Double Stock1_2_5_5SqIn_5000Quantity = 1298.00;
            Double Stock1_5_10SqIn_5000Quantity = 2184.00;
            Double Stock1_10_15SqIn_5000Quantity = 3107.00;
            Double Stock1_15_20SqIn_5000Quantity = 3802.00;
            Double Stock1_20_25SqIn_5000Quantity = 4954.00;
            Double Stock1_25_30SqIn_5000Quantity = 4961.00;
            Double Stock1_30_35SqIn_5000Quantity = 7262.00;
            Double Stock1_35_40SqIn_5000Quantity = 7266.00;
            //Color, 250 Quantity.
            Double Stock1Color_5000Quantity = 230.00;

            //10000 Quantity.
            Double Stock1_0_2_5SqIn_10000Quantity = 1489.00;
            Double Stock1_2_5_5SqIn_10000Quantity = 2270.00;
            Double Stock1_5_10SqIn_10000Quantity = 5370.00;
            Double Stock1_10_15SqIn_10000Quantity = 5522.00;
            Double Stock1_15_20SqIn_10000Quantity = 6761.00;
            Double Stock1_20_25SqIn_10000Quantity = 8819.00;
            Double Stock1_25_30SqIn_10000Quantity = 8825.00;
            Double Stock1_30_35SqIn_10000Quantity = 12938.00;
            Double Stock1_35_40SqIn_10000Quantity = 12942.00;
            //Color, 250 Quantity.
            Double Stock1Color_10000Quantity = 360.00;

            //======================================================================================================
            //Lamination Pricing
            //======================================================================================================

            //Calculating the Square Inches from the form values.
            Double SelectedHeight = Convert.ToDouble(txtLabelHeight.Text);
            Double SelectedWidth = Convert.ToDouble(txtLabelWidth.Text);
            Double SqIn = Convert.ToDouble(txtLabelHeight.Text) * Convert.ToDouble(txtLabelWidth.Text);

            //Lamination price is the value of the dropdown items.********
            Double LaminationSetupCharge = 0.00;


            //Checking to see if the lamination has been selected, if it has then add the setup charge to the price.
            if (Convert.ToDouble(ddlLamination.SelectedValue) > 0 && SelectedWidth > 0 && SelectedHeight > 0 && SqIn < 40.1)
            {
                //Lamination Setup Charge.
                LaminationSetupCharge = 20.00;
            }
            else
            {
                LaminationSetupCharge = 0.00;
            }

            //======================================================================================================
            //Number of Colours
            //======================================================================================================

            //Getting the number of colours
            Decimal NumberOfColors = Convert.ToDecimal(txtNumberOfColours.Text) - 1;
            //Calculating the price for the colors.


            //50 Quantity If Statements
            //======================================================================================================

            //Finding out if the stock is and show the price for that stock.
            if (ddlLabelQuantities.SelectedValue == "50")
            {
                Double Subtotal = 0;

                //Displaying the Subtotal.
                if (SqIn >= 0 && SqIn <= 2.5)
                {
                    Subtotal = Stock1_0_2_5SqIn_50Quantity;
                }
                else if (SqIn >= 2.5 && SqIn <= 5)
                {
                    Subtotal = Stock1_2_5_5SqIn_50Quantity;
                }
                else if (SqIn >= 5.1 && SqIn <= 10)
                {
                    Subtotal = Stock1_5_10SqIn_50Quantity;
                }
                else if (SqIn >= 10.1 && SqIn <= 15)
                {
                    Subtotal = Stock1_10_15SqIn_50Quantity;
                }
                else if (SqIn >= 15.1 && SqIn <= 20)
                {
                    Subtotal = Stock1_15_20SqIn_50Quantity;
                }
                else if (SqIn >= 20.1 && SqIn <= 25)
                {
                    Subtotal = Stock1_20_25SqIn_50Quantity;
                }
                else if (SqIn >= 25.1 && SqIn <= 30)
                {
                    Subtotal = Stock1_25_30SqIn_50Quantity;
                }
                else if (SqIn >= 30.1 && SqIn <= 35)
                {
                    Subtotal = Stock1_30_35SqIn_50Quantity;
                }
                else if (SqIn >= 35.1 && SqIn <= 40)
                {
                    Subtotal = Stock1_35_40SqIn_50Quantity;
                }
                else if (SqIn > 40.1)
                {
                    lblCustomQuoteMessage.Text = CustomQuoteMessage;
                }
                //Calculating the price for the colors.
                Double ColorPrice = Stock1Color_50Quantity * Convert.ToDouble(NumberOfColors);

                //Geting the Lamination price from form.
                //Lamination price is the value of the dropdpwn items.
                Double LaminationPrice = Convert.ToDouble(ddlLamination.SelectedValue);


                //Calculating Lamination.
                //Calculating the TotalSqIn
                Double TotalSqIn = SqIn * Convert.ToDouble(ddlLabelQuantities.SelectedValue);
                //Calculating the TotalLaminationPrice
                Double TotalLaminationPrice = TotalSqIn * LaminationPrice;
                //Calculating the TotalLaminationWithMinPrice
                Decimal TotalLaminationWithMinPrice = Convert.ToDecimal(TotalLaminationPrice) + Convert.ToDecimal(LaminationSetupCharge);
                //formating the numbers that are displays to .00, this is done so people will know that it's money. 
                TotalLaminationWithMinPrice = Convert.ToDecimal(string.Format("{0:0.00}", TotalLaminationWithMinPrice));
                //Displaying the Price of Lamination.
                lblOverlamination.Text = "Overlamination:" + " " + "$" + TotalLaminationWithMinPrice.ToString();

                //Caluclating the Total without Lamination.
                Decimal TotalPricewithoutLamination = Convert.ToDecimal(Subtotal) + Convert.ToDecimal(ColorPrice);
                //formating the numbers that are displays to .00, this is done so people will know that it's money. 
                TotalPricewithoutLamination = Convert.ToDecimal(string.Format("{0:0.00}", TotalPricewithoutLamination));

                //Displaying the Subtotal.
                lblPriceWithoutLamination.Text = "Total Price Without Lamination:" + " " + "$" + TotalPricewithoutLamination.ToString();

                //Calculating the Total Cost.
                Decimal Total = Convert.ToDecimal(Subtotal) + Convert.ToDecimal(ColorPrice) + Convert.ToDecimal(TotalLaminationWithMinPrice);
                //formating the numbers that are displays to .00, this is done so people will know that it's money. 
                Total = Convert.ToDecimal(string.Format("{0:0.00}", Total));

                //Displaying the Total Price.
                lblTotal.Text = "Total:" + " " + "$" + Total.ToString() + "*";

            }

            //100 Quantity If Statements
            //======================================================================================================

            //Finding out if the stock is and show the price for that stock.
            if (ddlLabelQuantities.SelectedValue == "100")
            {
                Double Subtotal = 0;

                //Displaying the Subtotal.
                if (SqIn >= 0 && SqIn <= 2.5)
                {
                    Subtotal = Stock1_0_2_5SqIn_100Quantity;
                }
                else if (SqIn >= 2.5 && SqIn <= 5)
                {
                    Subtotal = Stock1_2_5_5SqIn_100Quantity;
                }
                else if (SqIn >= 5.1 && SqIn <= 10)
                {
                    Subtotal = Stock1_5_10SqIn_100Quantity;
                }
                else if (SqIn >= 10.1 && SqIn <= 15)
                {
                    Subtotal = Stock1_10_15SqIn_100Quantity;
                }
                else if (SqIn >= 15.1 && SqIn <= 20)
                {
                    Subtotal = Stock1_15_20SqIn_100Quantity;
                }
                else if (SqIn >= 20.1 && SqIn <= 25)
                {
                    Subtotal = Stock1_20_25SqIn_100Quantity;
                }
                else if (SqIn >= 25.1 && SqIn <= 30)
                {
                    Subtotal = Stock1_25_30SqIn_100Quantity;
                }
                else if (SqIn >= 30.1 && SqIn <= 35)
                {
                    Subtotal = Stock1_30_35SqIn_100Quantity;
                }
                else if (SqIn >= 35.1 && SqIn <= 40)
                {
                    Subtotal = Stock1_35_40SqIn_100Quantity;
                }
                else if (SqIn > 40.1)
                {
                    lblCustomQuoteMessage.Text = CustomQuoteMessage;
                }
                //Calculating the price for the colors.
                Double ColorPrice = Stock1Color_100Quantity * Convert.ToDouble(NumberOfColors);

                //Geting the Lamination price from form.
                //Lamination price is the value of the dropdpwn items.
                Double LaminationPrice = Convert.ToDouble(ddlLamination.SelectedValue);


                //Calculating Lamination.
                //Calculating the TotalSqIn
                Double TotalSqIn = SqIn * Convert.ToDouble(ddlLabelQuantities.SelectedValue);
                //Calculating the TotalLaminationPrice
                Double TotalLaminationPrice = TotalSqIn * LaminationPrice;
                //Calculating the TotalLaminationWithMinPrice
                Decimal TotalLaminationWithMinPrice = Convert.ToDecimal(TotalLaminationPrice) + Convert.ToDecimal(LaminationSetupCharge);
                //formating the numbers that are displays to .00, this is done so people will know that it's money. 
                TotalLaminationWithMinPrice = Convert.ToDecimal(string.Format("{0:0.00}", TotalLaminationWithMinPrice));
                //Displaying the Price of Lamination.
                lblOverlamination.Text = "Overlamination:" + " " + "$" + TotalLaminationWithMinPrice.ToString();

                //Caluclating the Total without Lamination.
                Decimal TotalPricewithoutLamination = Convert.ToDecimal(Subtotal) + Convert.ToDecimal(ColorPrice);
                //formating the numbers that are displays to .00, this is done so people will know that it's money. 
                TotalPricewithoutLamination = Convert.ToDecimal(string.Format("{0:0.00}", TotalPricewithoutLamination));

                //Displaying the Subtotal.
                lblPriceWithoutLamination.Text = "Total Price Without Lamination:" + " " + "$" + TotalPricewithoutLamination.ToString();

                //Calculating the Total Cost.
                Decimal Total = Convert.ToDecimal(Subtotal) + Convert.ToDecimal(ColorPrice) + Convert.ToDecimal(TotalLaminationWithMinPrice);
                //formating the numbers that are displays to .00, this is done so people will know that it's money. 
                Total = Convert.ToDecimal(string.Format("{0:0.00}", Total));

                //Displaying the Total Price.
                lblTotal.Text = "Total:" + " " + "$" + Total.ToString() + "*";

            }


            //250 Quantity If Statements
            //======================================================================================================

            //Finding out if the stock is and show the price for that stock.
            if (ddlLabelQuantities.SelectedValue == "250")
            {
                Double Subtotal = 0;

                //Displaying the Subtotal.
                if (SqIn >= 0 && SqIn <= 2.5)
                {
                    Subtotal = Stock1_0_2_5SqIn_250Quantity;
                }
                else if (SqIn >= 2.5 && SqIn <= 5)
                {
                    Subtotal = Stock1_2_5_5SqIn_250Quantity;
                }
                else if (SqIn >= 5.1 && SqIn <= 10)
                {
                    Subtotal = Stock1_5_10SqIn_250Quantity;
                }
                else if (SqIn >= 10.1 && SqIn <= 15)
                {
                    Subtotal = Stock1_10_15SqIn_250Quantity;
                }
                else if (SqIn >= 15.1 && SqIn <= 20)
                {
                    Subtotal = Stock1_15_20SqIn_250Quantity;
                }
                else if (SqIn >= 20.1 && SqIn <= 25)
                {
                    Subtotal = Stock1_20_25SqIn_250Quantity;
                }
                else if (SqIn >= 25.1 && SqIn <= 30)
                {
                    Subtotal = Stock1_25_30SqIn_250Quantity;
                }
                else if (SqIn >= 30.1 && SqIn <= 35)
                {
                    Subtotal = Stock1_30_35SqIn_250Quantity;
                }
                else if (SqIn >= 35.1 && SqIn <= 40)
                {
                    Subtotal = Stock1_35_40SqIn_250Quantity;
                }
                else if (SqIn > 40.1)
                {
                    lblCustomQuoteMessage.Text = CustomQuoteMessage;
                }
                //Calculating the price for the colors.
                Double ColorPrice = Stock1Color_250Quantity * Convert.ToDouble(NumberOfColors);

                //Geting the Lamination price from form.
                //Lamination price is the value of the dropdpwn items.
                Double LaminationPrice = Convert.ToDouble(ddlLamination.SelectedValue);


                //Calculating Lamination.
                //Calculating the TotalSqIn
                Double TotalSqIn = SqIn * Convert.ToDouble(ddlLabelQuantities.SelectedValue);
                //Calculating the TotalLaminationPrice
                Double TotalLaminationPrice = TotalSqIn * LaminationPrice;
                //Calculating the TotalLaminationWithMinPrice
                Decimal TotalLaminationWithMinPrice = Convert.ToDecimal(TotalLaminationPrice) + Convert.ToDecimal(LaminationSetupCharge);
                //formating the numbers that are displays to .00, this is done so people will know that it's money. 
                TotalLaminationWithMinPrice = Convert.ToDecimal(string.Format("{0:0.00}", TotalLaminationWithMinPrice));
                //Displaying the Price of Lamination.
                lblOverlamination.Text = "Overlamination:" + " " + "$" + TotalLaminationWithMinPrice.ToString();

                //Caluclating the Total without Lamination.
                Decimal TotalPricewithoutLamination = Convert.ToDecimal(Subtotal) + Convert.ToDecimal(ColorPrice);
                //formating the numbers that are displays to .00, this is done so people will know that it's money. 
                TotalPricewithoutLamination = Convert.ToDecimal(string.Format("{0:0.00}", TotalPricewithoutLamination));

                //Displaying the Subtotal.
                lblPriceWithoutLamination.Text = "Total Price Without Lamination:" + " " + "$" + TotalPricewithoutLamination.ToString();

                //Calculating the Total Cost.
                Decimal Total = Convert.ToDecimal(Subtotal) + Convert.ToDecimal(ColorPrice) + Convert.ToDecimal(TotalLaminationWithMinPrice);
                //formating the numbers that are displays to .00, this is done so people will know that it's money. 
                Total = Convert.ToDecimal(string.Format("{0:0.00}", Total));

                //Displaying the Total Price.
                lblTotal.Text = "Total:" + " " + "$" + Total.ToString() + "*";

            }

            //500 Quantity If Statements
            //======================================================================================================

            //Finding out if the stock is and show the price for that stock.
            if (ddlLabelQuantities.SelectedValue == "500")
            {
                Double Subtotal = 0;

                //Displaying the Subtotal.
                if (SqIn >= 0 && SqIn <= 2.5)
                {
                    Subtotal = Stock1_0_2_5SqIn_500Quantity;
                }
                else if (SqIn >= 2.5 && SqIn <= 5)
                {
                    Subtotal = Stock1_2_5_5SqIn_500Quantity;
                }
                else if (SqIn >= 5.1 && SqIn <= 10)
                {
                    Subtotal = Stock1_5_10SqIn_500Quantity;
                }
                else if (SqIn >= 10.1 && SqIn <= 15)
                {
                    Subtotal = Stock1_10_15SqIn_500Quantity;
                }
                else if (SqIn >= 15.1 && SqIn <= 20)
                {
                    Subtotal = Stock1_15_20SqIn_500Quantity;
                }
                else if (SqIn >= 20.1 && SqIn <= 25)
                {
                    Subtotal = Stock1_20_25SqIn_500Quantity;
                }
                else if (SqIn >= 25.1 && SqIn <= 30)
                {
                    Subtotal = Stock1_25_30SqIn_500Quantity;
                }
                else if (SqIn >= 30.1 && SqIn <= 35)
                {
                    Subtotal = Stock1_30_35SqIn_500Quantity;
                }
                else if (SqIn >= 35.1 && SqIn <= 40)
                {
                    Subtotal = Stock1_35_40SqIn_500Quantity;
                }
                else if (SqIn > 40.1)
                {
                    lblCustomQuoteMessage.Text = CustomQuoteMessage;
                }
                //Calculating the price for the colors.
                Double ColorPrice = Stock1Color_500Quantity * Convert.ToDouble(NumberOfColors);

                //Geting the Lamination price from form.
                //Lamination price is the value of the dropdpwn items.
                Double LaminationPrice = Convert.ToDouble(ddlLamination.SelectedValue);


                //Calculating Lamination.
                //Calculating the TotalSqIn
                Double TotalSqIn = SqIn * Convert.ToDouble(ddlLabelQuantities.SelectedValue);
                //Calculating the TotalLaminationPrice
                Double TotalLaminationPrice = TotalSqIn * LaminationPrice;
                //Calculating the TotalLaminationWithMinPrice
                Decimal TotalLaminationWithMinPrice = Convert.ToDecimal(TotalLaminationPrice) + Convert.ToDecimal(LaminationSetupCharge);
                //formating the numbers that are displays to .00, this is done so people will know that it's money. 
                TotalLaminationWithMinPrice = Convert.ToDecimal(string.Format("{0:0.00}", TotalLaminationWithMinPrice));
                //Displaying the Price of Lamination.
                lblOverlamination.Text = "Overlamination:" + " " + "$" + TotalLaminationWithMinPrice.ToString();

                //Caluclating the Total without Lamination.
                Decimal TotalPricewithoutLamination = Convert.ToDecimal(Subtotal) + Convert.ToDecimal(ColorPrice);
                //formating the numbers that are displays to .00, this is done so people will know that it's money. 
                TotalPricewithoutLamination = Convert.ToDecimal(string.Format("{0:0.00}", TotalPricewithoutLamination));

                //Displaying the Subtotal.
                lblPriceWithoutLamination.Text = "Total Price Without Lamination:" + " " + "$" + TotalPricewithoutLamination.ToString();

                //Calculating the Total Cost.
                Decimal Total = Convert.ToDecimal(Subtotal) + Convert.ToDecimal(ColorPrice) + Convert.ToDecimal(TotalLaminationWithMinPrice);
                //formating the numbers that are displays to .00, this is done so people will know that it's money. 
                Total = Convert.ToDecimal(string.Format("{0:0.00}", Total));

                //Displaying the Total Price.
                lblTotal.Text = "Total:" + " " + "$" + Total.ToString() + "*";

            }


            //1000 Quantity If Statements
            //======================================================================================================

            //Finding out if the stock is and show the price for that stock.
            if (ddlLabelQuantities.SelectedValue == "1000")
            {
                Double Subtotal = 0;

                //Displaying the Subtotal.
                if (SqIn >= 0 && SqIn <= 2.5)
                {
                    Subtotal = Stock1_0_2_5SqIn_1000Quantity;
                }
                else if (SqIn >= 2.5 && SqIn <= 5)
                {
                    Subtotal = Stock1_2_5_5SqIn_1000Quantity;
                }
                else if (SqIn >= 5.1 && SqIn <= 10)
                {
                    Subtotal = Stock1_5_10SqIn_1000Quantity;
                }
                else if (SqIn >= 10.1 && SqIn <= 15)
                {
                    Subtotal = Stock1_10_15SqIn_1000Quantity;
                }
                else if (SqIn >= 15.1 && SqIn <= 20)
                {
                    Subtotal = Stock1_15_20SqIn_1000Quantity;
                }
                else if (SqIn >= 20.1 && SqIn <= 25)
                {
                    Subtotal = Stock1_20_25SqIn_1000Quantity;
                }
                else if (SqIn >= 25.1 && SqIn <= 30)
                {
                    Subtotal = Stock1_25_30SqIn_1000Quantity;
                }
                else if (SqIn >= 30.1 && SqIn <= 35)
                {
                    Subtotal = Stock1_30_35SqIn_1000Quantity;
                }
                else if (SqIn >= 35.1 && SqIn <= 40)
                {
                    Subtotal = Stock1_35_40SqIn_1000Quantity;
                }
                else if (SqIn > 40.1)
                {
                    lblCustomQuoteMessage.Text = CustomQuoteMessage;
                }
                //Calculating the price for the colors.
                Double ColorPrice = Stock1Color_1000Quantity * Convert.ToDouble(NumberOfColors);

                //Geting the Lamination price from form.
                //Lamination price is the value of the dropdpwn items.
                Double LaminationPrice = Convert.ToDouble(ddlLamination.SelectedValue);


                //Calculating Lamination.
                //Calculating the TotalSqIn
                Double TotalSqIn = SqIn * Convert.ToDouble(ddlLabelQuantities.SelectedValue);
                //Calculating the TotalLaminationPrice
                Double TotalLaminationPrice = TotalSqIn * LaminationPrice;
                //Calculating the TotalLaminationWithMinPrice
                Decimal TotalLaminationWithMinPrice = Convert.ToDecimal(TotalLaminationPrice) + Convert.ToDecimal(LaminationSetupCharge);
                //formating the numbers that are displays to .00, this is done so people will know that it's money. 
                TotalLaminationWithMinPrice = Convert.ToDecimal(string.Format("{0:0.00}", TotalLaminationWithMinPrice));
                //Displaying the Price of Lamination.
                lblOverlamination.Text = "Overlamination:" + " " + "$" + TotalLaminationWithMinPrice.ToString();

                //Caluclating the Total without Lamination.
                Decimal TotalPricewithoutLamination = Convert.ToDecimal(Subtotal) + Convert.ToDecimal(ColorPrice);
                //formating the numbers that are displays to .00, this is done so people will know that it's money. 
                TotalPricewithoutLamination = Convert.ToDecimal(string.Format("{0:0.00}", TotalPricewithoutLamination));

                //Displaying the Subtotal.
                lblPriceWithoutLamination.Text = "Total Price Without Lamination:" + " " + "$" + TotalPricewithoutLamination.ToString();

                //Calculating the Total Cost.
                Decimal Total = Convert.ToDecimal(Subtotal) + Convert.ToDecimal(ColorPrice) + Convert.ToDecimal(TotalLaminationWithMinPrice);
                //formating the numbers that are displays to .00, this is done so people will know that it's money. 
                Total = Convert.ToDecimal(string.Format("{0:0.00}", Total));

                //Displaying the Total Price.
                lblTotal.Text = "Total:" + " " + "$" + Total.ToString() + "*";

            }


            //2000 Quantity If Statements
            //======================================================================================================

            //Finding out if the stock is and show the price for that stock.
            if (ddlLabelQuantities.SelectedValue == "2000")
            {
                Double Subtotal = 0;

                //Displaying the Subtotal.
                if (SqIn >= 0 && SqIn <= 2.5)
                {
                    Subtotal = Stock1_0_2_5SqIn_2000Quantity;
                }
                else if (SqIn >= 2.5 && SqIn <= 5)
                {
                    Subtotal = Stock1_2_5_5SqIn_2000Quantity;
                }
                else if (SqIn >= 5.1 && SqIn <= 10)
                {
                    Subtotal = Stock1_5_10SqIn_2000Quantity;
                }
                else if (SqIn >= 10.1 && SqIn <= 15)
                {
                    Subtotal = Stock1_10_15SqIn_2000Quantity;
                }
                else if (SqIn >= 15.1 && SqIn <= 20)
                {
                    Subtotal = Stock1_15_20SqIn_2000Quantity;
                }
                else if (SqIn >= 20.1 && SqIn <= 25)
                {
                    Subtotal = Stock1_20_25SqIn_2000Quantity;
                }
                else if (SqIn >= 25.1 && SqIn <= 30)
                {
                    Subtotal = Stock1_25_30SqIn_2000Quantity;
                }
                else if (SqIn >= 30.1 && SqIn <= 35)
                {
                    Subtotal = Stock1_30_35SqIn_2000Quantity;
                }
                else if (SqIn >= 35.1 && SqIn <= 40)
                {
                    Subtotal = Stock1_35_40SqIn_2000Quantity;
                }
                else if (SqIn > 40.1)
                {
                    lblCustomQuoteMessage.Text = CustomQuoteMessage;
                }
                //Calculating the price for the colors.
                Double ColorPrice = Stock1Color_2000Quantity * Convert.ToDouble(NumberOfColors);

                //Geting the Lamination price from form.
                //Lamination price is the value of the dropdpwn items.
                Double LaminationPrice = Convert.ToDouble(ddlLamination.SelectedValue);


                //Calculating Lamination.
                //Calculating the TotalSqIn
                Double TotalSqIn = SqIn * Convert.ToDouble(ddlLabelQuantities.SelectedValue);
                //Calculating the TotalLaminationPrice
                Double TotalLaminationPrice = TotalSqIn * LaminationPrice;
                //Calculating the TotalLaminationWithMinPrice
                Decimal TotalLaminationWithMinPrice = Convert.ToDecimal(TotalLaminationPrice) + Convert.ToDecimal(LaminationSetupCharge);
                //formating the numbers that are displays to .00, this is done so people will know that it's money. 
                TotalLaminationWithMinPrice = Convert.ToDecimal(string.Format("{0:0.00}", TotalLaminationWithMinPrice));
                //Displaying the Price of Lamination.
                lblOverlamination.Text = "Overlamination:" + " " + "$" + TotalLaminationWithMinPrice.ToString();

                //Caluclating the Total without Lamination.
                Decimal TotalPricewithoutLamination = Convert.ToDecimal(Subtotal) + Convert.ToDecimal(ColorPrice);
                //formating the numbers that are displays to .00, this is done so people will know that it's money. 
                TotalPricewithoutLamination = Convert.ToDecimal(string.Format("{0:0.00}", TotalPricewithoutLamination));

                //Displaying the Subtotal.
                lblPriceWithoutLamination.Text = "Total Price Without Lamination:" + " " + "$" + TotalPricewithoutLamination.ToString();

                //Calculating the Total Cost.
                Decimal Total = Convert.ToDecimal(Subtotal) + Convert.ToDecimal(ColorPrice) + Convert.ToDecimal(TotalLaminationWithMinPrice);
                //formating the numbers that are displays to .00, this is done so people will know that it's money. 
                Total = Convert.ToDecimal(string.Format("{0:0.00}", Total));

                //Displaying the Total Price.
                lblTotal.Text = "Total:" + " " + "$" + Total.ToString() + "*";

            }



            //2500 Quantity If Statements
            //======================================================================================================

            //Finding out if the stock is and show the price for that stock.
            if (ddlLabelQuantities.SelectedValue == "2500")
            {
                Double Subtotal = 0;

                //Displaying the Subtotal.
                if (SqIn >= 0 && SqIn <= 2.5)
                {
                    Subtotal = Stock1_0_2_5SqIn_2500Quantity;
                }
                else if (SqIn >= 2.5 && SqIn <= 5)
                {
                    Subtotal = Stock1_2_5_5SqIn_2500Quantity;
                }
                else if (SqIn >= 5.1 && SqIn <= 10)
                {
                    Subtotal = Stock1_5_10SqIn_2500Quantity;
                }
                else if (SqIn >= 10.1 && SqIn <= 15)
                {
                    Subtotal = Stock1_10_15SqIn_2500Quantity;
                }
                else if (SqIn >= 15.1 && SqIn <= 20)
                {
                    Subtotal = Stock1_15_20SqIn_2500Quantity;
                }
                else if (SqIn >= 20.1 && SqIn <= 25)
                {
                    Subtotal = Stock1_20_25SqIn_2500Quantity;
                }
                else if (SqIn >= 25.1 && SqIn <= 30)
                {
                    Subtotal = Stock1_25_30SqIn_2500Quantity;
                }
                else if (SqIn >= 30.1 && SqIn <= 35)
                {
                    Subtotal = Stock1_30_35SqIn_2500Quantity;
                }
                else if (SqIn >= 35.1 && SqIn <= 40)
                {
                    Subtotal = Stock1_35_40SqIn_2500Quantity;
                }
                else if (SqIn > 40.1)
                {
                    lblCustomQuoteMessage.Text = CustomQuoteMessage;
                }
                //Calculating the price for the colors.
                Double ColorPrice = Stock1Color_2500Quantity * Convert.ToDouble(NumberOfColors);

                //Geting the Lamination price from form.
                //Lamination price is the value of the dropdpwn items.
                Double LaminationPrice = Convert.ToDouble(ddlLamination.SelectedValue);


                //Calculating Lamination.
                //Calculating the TotalSqIn
                Double TotalSqIn = SqIn * Convert.ToDouble(ddlLabelQuantities.SelectedValue);
                //Calculating the TotalLaminationPrice
                Double TotalLaminationPrice = TotalSqIn * LaminationPrice;
                //Calculating the TotalLaminationWithMinPrice
                Decimal TotalLaminationWithMinPrice = Convert.ToDecimal(TotalLaminationPrice) + Convert.ToDecimal(LaminationSetupCharge);
                //formating the numbers that are displays to .00, this is done so people will know that it's money. 
                TotalLaminationWithMinPrice = Convert.ToDecimal(string.Format("{0:0.00}", TotalLaminationWithMinPrice));
                //Displaying the Price of Lamination.
                lblOverlamination.Text = "Overlamination:" + " " + "$" + TotalLaminationWithMinPrice.ToString();

                //Caluclating the Total without Lamination.
                Decimal TotalPricewithoutLamination = Convert.ToDecimal(Subtotal) + Convert.ToDecimal(ColorPrice);
                //formating the numbers that are displays to .00, this is done so people will know that it's money. 
                TotalPricewithoutLamination = Convert.ToDecimal(string.Format("{0:0.00}", TotalPricewithoutLamination));

                //Displaying the Subtotal.
                lblPriceWithoutLamination.Text = "Total Price Without Lamination:" + " " + "$" + TotalPricewithoutLamination.ToString();

                //Calculating the Total Cost.
                Decimal Total = Convert.ToDecimal(Subtotal) + Convert.ToDecimal(ColorPrice) + Convert.ToDecimal(TotalLaminationWithMinPrice);
                //formating the numbers that are displays to .00, this is done so people will know that it's money. 
                Total = Convert.ToDecimal(string.Format("{0:0.00}", Total));

                //Displaying the Total Price.
                lblTotal.Text = "Total:" + " " + "$" + Total.ToString() + "*";

            }



            //5000 Quantity If Statements
            //======================================================================================================

            //Finding out if the stock is and show the price for that stock.
            if (ddlLabelQuantities.SelectedValue == "5000")
            {
                Double Subtotal = 0;

                //Displaying the Subtotal.
                if (SqIn >= 0 && SqIn <= 2.5)
                {
                    Subtotal = Stock1_0_2_5SqIn_5000Quantity;
                }
                else if (SqIn >= 2.5 && SqIn <= 5)
                {
                    Subtotal = Stock1_2_5_5SqIn_5000Quantity;
                }
                else if (SqIn >= 5.1 && SqIn <= 10)
                {
                    Subtotal = Stock1_5_10SqIn_5000Quantity;
                }
                else if (SqIn >= 10.1 && SqIn <= 15)
                {
                    Subtotal = Stock1_10_15SqIn_5000Quantity;
                }
                else if (SqIn >= 15.1 && SqIn <= 20)
                {
                    Subtotal = Stock1_15_20SqIn_5000Quantity;
                }
                else if (SqIn >= 20.1 && SqIn <= 25)
                {
                    Subtotal = Stock1_20_25SqIn_5000Quantity;
                }
                else if (SqIn >= 25.1 && SqIn <= 30)
                {
                    Subtotal = Stock1_25_30SqIn_5000Quantity;
                }
                else if (SqIn >= 30.1 && SqIn <= 35)
                {
                    Subtotal = Stock1_30_35SqIn_5000Quantity;
                }
                else if (SqIn >= 35.1 && SqIn <= 40)
                {
                    Subtotal = Stock1_35_40SqIn_5000Quantity;
                }
                else if (SqIn > 40.1)
                {
                    lblCustomQuoteMessage.Text = CustomQuoteMessage;
                }
                //Calculating the price for the colors.
                Double ColorPrice = Stock1Color_5000Quantity * Convert.ToDouble(NumberOfColors);

                //Geting the Lamination price from form.
                //Lamination price is the value of the dropdpwn items.
                Double LaminationPrice = Convert.ToDouble(ddlLamination.SelectedValue);


                //Calculating Lamination.
                //Calculating the TotalSqIn
                Double TotalSqIn = SqIn * Convert.ToDouble(ddlLabelQuantities.SelectedValue);
                //Calculating the TotalLaminationPrice
                Double TotalLaminationPrice = TotalSqIn * LaminationPrice;
                //Calculating the TotalLaminationWithMinPrice
                Decimal TotalLaminationWithMinPrice = Convert.ToDecimal(TotalLaminationPrice) + Convert.ToDecimal(LaminationSetupCharge);
                //formating the numbers that are displays to .00, this is done so people will know that it's money. 
                TotalLaminationWithMinPrice = Convert.ToDecimal(string.Format("{0:0.00}", TotalLaminationWithMinPrice));
                //Displaying the Price of Lamination.
                lblOverlamination.Text = "Overlamination:" + " " + "$" + TotalLaminationWithMinPrice.ToString();

                //Caluclating the Total without Lamination.
                Decimal TotalPricewithoutLamination = Convert.ToDecimal(Subtotal) + Convert.ToDecimal(ColorPrice);
                //formating the numbers that are displays to .00, this is done so people will know that it's money. 
                TotalPricewithoutLamination = Convert.ToDecimal(string.Format("{0:0.00}", TotalPricewithoutLamination));

                //Displaying the Subtotal.
                lblPriceWithoutLamination.Text = "Total Price Without Lamination:" + " " + "$" + TotalPricewithoutLamination.ToString();

                //Calculating the Total Cost.
                Decimal Total = Convert.ToDecimal(Subtotal) + Convert.ToDecimal(ColorPrice) + Convert.ToDecimal(TotalLaminationWithMinPrice);
                //formating the numbers that are displays to .00, this is done so people will know that it's money. 
                Total = Convert.ToDecimal(string.Format("{0:0.00}", Total));

                //Displaying the Total Price.
                lblTotal.Text = "Total:" + " " + "$" + Total.ToString() + "*";

            }



            //10000 Quantity If Statements
            //======================================================================================================

            //Finding out if the stock is and show the price for that stock.
            if (ddlLabelQuantities.SelectedValue == "10000")
            {
                Double Subtotal = 0;

                //Displaying the Subtotal.
                if (SqIn >= 0 && SqIn <= 2.5)
                {
                    Subtotal = Stock1_0_2_5SqIn_10000Quantity;
                }
                else if (SqIn >= 2.5 && SqIn <= 5)
                {
                    Subtotal = Stock1_2_5_5SqIn_10000Quantity;
                }
                else if (SqIn >= 5.1 && SqIn <= 10)
                {
                    Subtotal = Stock1_5_10SqIn_10000Quantity;
                }
                else if (SqIn >= 10.1 && SqIn <= 15)
                {
                    Subtotal = Stock1_10_15SqIn_10000Quantity;
                }
                else if (SqIn >= 15.1 && SqIn <= 20)
                {
                    Subtotal = Stock1_15_20SqIn_10000Quantity;
                }
                else if (SqIn >= 20.1 && SqIn <= 25)
                {
                    Subtotal = Stock1_20_25SqIn_10000Quantity;
                }
                else if (SqIn >= 25.1 && SqIn <= 30)
                {
                    Subtotal = Stock1_25_30SqIn_10000Quantity;
                }
                else if (SqIn >= 30.1 && SqIn <= 35)
                {
                    Subtotal = Stock1_30_35SqIn_10000Quantity;
                }
                else if (SqIn >= 35.1 && SqIn <= 40)
                {
                    Subtotal = Stock1_35_40SqIn_10000Quantity;
                }
                else if (SqIn > 40.1)
                {
                    lblCustomQuoteMessage.Text = CustomQuoteMessage;
                }
                //Calculating the price for the colors.
                Double ColorPrice = Stock1Color_10000Quantity * Convert.ToDouble(NumberOfColors);

                //Geting the Lamination price from form.
                //Lamination price is the value of the dropdpwn items.
                Double LaminationPrice = Convert.ToDouble(ddlLamination.SelectedValue);


                //Calculating Lamination.
                //Calculating the TotalSqIn
                Double TotalSqIn = SqIn * Convert.ToDouble(ddlLabelQuantities.SelectedValue);
                //Calculating the TotalLaminationPrice
                Double TotalLaminationPrice = TotalSqIn * LaminationPrice;
                //Calculating the TotalLaminationWithMinPrice
                Decimal TotalLaminationWithMinPrice = Convert.ToDecimal(TotalLaminationPrice) + Convert.ToDecimal(LaminationSetupCharge);
                //formating the numbers that are displays to .00, this is done so people will know that it's money. 
                TotalLaminationWithMinPrice = Convert.ToDecimal(string.Format("{0:0.00}", TotalLaminationWithMinPrice));
                //Displaying the Price of Lamination.
                lblOverlamination.Text = "Overlamination:" + " " + "$" + TotalLaminationWithMinPrice.ToString();

                //Caluclating the Total without Lamination.
                Decimal TotalPricewithoutLamination = Convert.ToDecimal(Subtotal) + Convert.ToDecimal(ColorPrice);
                //formating the numbers that are displays to .00, this is done so people will know that it's money. 
                TotalPricewithoutLamination = Convert.ToDecimal(string.Format("{0:0.00}", TotalPricewithoutLamination));

                //Displaying the Subtotal.
                lblPriceWithoutLamination.Text = "Total Price Without Lamination:" + " " + "$" + TotalPricewithoutLamination.ToString();

                //Calculating the Total Cost.
                Decimal Total = Convert.ToDecimal(Subtotal) + Convert.ToDecimal(ColorPrice) + Convert.ToDecimal(TotalLaminationWithMinPrice);
                //formating the numbers that are displays to .00, this is done so people will know that it's money. 
                Total = Convert.ToDecimal(string.Format("{0:0.00}", Total));

                //Displaying the Total Price.
                lblTotal.Text = "Total:" + " " + "$" + Total.ToString() + "*";

            }

        }
    }
}