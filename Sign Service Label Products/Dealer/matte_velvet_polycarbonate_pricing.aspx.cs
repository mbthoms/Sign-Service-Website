using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Sign_Service_Label_Products.dealer
{
    public partial class matte_velvet_polycarbonate_pricing : System.Web.UI.Page
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
            //Global Vars
            //======================================================================================================
            String CustomQuoteMessage = "<div class='alert alert-danger' role='alert'>Please call or email our sales desk for a custom quote at: <a href='tel:18007872382'>1 (800)-787-2382</a><br />or <a href='mailto:sales@signservice.com'>sales@signservice.com</a></div>";

            //======================================================================================================
            //Pricing
            //======================================================================================================

            //50 Quantity.
            Double Stock1_0_2_5SqIn_50Quantity = 137.00;
            Double Stock1_2_5_5SqIn_50Quantity = 138.00;
            Double Stock1_5_10SqIn_50Quantity = 141.00;
            Double Stock1_10_15SqIn_50Quantity = 144.00;
            Double Stock1_15_20SqIn_50Quantity = 148.00;
            Double Stock1_20_25SqIn_50Quantity = 150.00;
            Double Stock1_25_30SqIn_50Quantity = 155.00;
            Double Stock1_30_35SqIn_50Quantity = 156.00;
            Double Stock1_35_40SqIn_50Quantity = 162.00;
            //Color, 50 Quantity.
            Double Stock1Color_50Quantity = 60.00;

            //100 Quantity.
            Double Stock1_0_2_5SqIn_100Quantity = 146.00;
            Double Stock1_2_5_5SqIn_100Quantity = 147.00;
            Double Stock1_5_10SqIn_100Quantity = 153.00;
            Double Stock1_10_15SqIn_100Quantity = 157.00;
            Double Stock1_15_20SqIn_100Quantity = 164.00;
            Double Stock1_20_25SqIn_100Quantity = 167.00;
            Double Stock1_25_30SqIn_100Quantity = 176.00;
            Double Stock1_30_35SqIn_100Quantity = 177.00;
            Double Stock1_35_40SqIn_100Quantity = 189.00;
            //Color, 100 Quantity.
            Double Stock1Color_100Quantity = 65.00;

            //250 Quantity.
            Double Stock1_0_2_5SqIn_250Quantity = 175.00;
            Double Stock1_2_5_5SqIn_250Quantity = 177.00;
            Double Stock1_5_10SqIn_250Quantity = 187.00;
            Double Stock1_10_15SqIn_250Quantity = 198.00;
            Double Stock1_15_20SqIn_250Quantity = 212.00;
            Double Stock1_20_25SqIn_250Quantity = 220.00;
            Double Stock1_25_30SqIn_250Quantity = 240.00;
            Double Stock1_30_35SqIn_250Quantity = 241.00;
            Double Stock1_35_40SqIn_250Quantity = 268.00;
            //Color, 250 Quantity.
            Double Stock1Color_250Quantity = 75.00;

            //500 Quantity.
            Double Stock1_0_2_5SqIn_500Quantity = 190.00;
            Double Stock1_2_5_5SqIn_500Quantity = 204.00;
            Double Stock1_5_10SqIn_500Quantity = 224.00;
            Double Stock1_10_15SqIn_500Quantity = 252.00;
            Double Stock1_15_20SqIn_500Quantity = 270.00;
            Double Stock1_20_25SqIn_500Quantity = 295.00;
            Double Stock1_25_30SqIn_500Quantity = 336.00;
            Double Stock1_30_35SqIn_500Quantity = 338.00;
            Double Stock1_35_40SqIn_500Quantity = 372.00;
            //Color, 250 Quantity.
            Double Stock1Color_500Quantity = 80.00;

            //1000 Quantity.
            Double Stock1_0_2_5SqIn_1000Quantity = 231.00;
            Double Stock1_2_5_5SqIn_1000Quantity = 255.00;
            Double Stock1_5_10SqIn_1000Quantity = 295.00;
            Double Stock1_10_15SqIn_1000Quantity = 361.00;
            Double Stock1_15_20SqIn_1000Quantity = 417.00;
            Double Stock1_20_25SqIn_1000Quantity = 447.00;
            Double Stock1_25_30SqIn_1000Quantity = 529.00;
            Double Stock1_30_35SqIn_1000Quantity = 533.00;
            Double Stock1_35_40SqIn_1000Quantity = 692.00;
            //Color, 250 Quantity.
            Double Stock1Color_1000Quantity = 85.00;

            //2000 Quantity.
            Double Stock1_0_2_5SqIn_2000Quantity = 312.00;
            Double Stock1_2_5_5SqIn_2000Quantity = 353.00;
            Double Stock1_5_10SqIn_2000Quantity = 445.00;
            Double Stock1_10_15SqIn_2000Quantity = 578.00;
            Double Stock1_15_20SqIn_2000Quantity = 648.00;
            Double Stock1_20_25SqIn_2000Quantity = 750.00;
            Double Stock1_25_30SqIn_2000Quantity = 925.00;
            Double Stock1_30_35SqIn_2000Quantity = 931.00;
            Double Stock1_35_40SqIn_2000Quantity = 1145.00;
            //Color, 250 Quantity.
            Double Stock1Color_2000Quantity = 100.00;

            //2500 Quantity.
            Double Stock1_0_2_5SqIn_2500Quantity = 354.00;
            Double Stock1_2_5_5SqIn_2500Quantity = 402.00;
            Double Stock1_5_10SqIn_2500Quantity = 537.00;
            Double Stock1_10_15SqIn_2500Quantity = 704.00;
            Double Stock1_15_20SqIn_2500Quantity = 727.00;
            Double Stock1_20_25SqIn_2500Quantity = 890.00;
            Double Stock1_25_30SqIn_2500Quantity = 1105.00;
            Double Stock1_30_35SqIn_2500Quantity = 1111.00;
            Double Stock1_35_40SqIn_2500Quantity = 1367.00;
            //Color, 250 Quantity.
            Double Stock1Color_2500Quantity = 115.00;

            //5000 Quantity.
            Double Stock1_0_2_5SqIn_5000Quantity = 568.00;
            Double Stock1_2_5_5SqIn_5000Quantity = 651.00;
            Double Stock1_5_10SqIn_5000Quantity = 1001.00;
            Double Stock1_10_15SqIn_5000Quantity = 1334.00;
            Double Stock1_15_20SqIn_5000Quantity = 1344.00;
            Double Stock1_20_25SqIn_5000Quantity = 1594.00;
            Double Stock1_25_30SqIn_5000Quantity = 2005.00;
            Double Stock1_30_35SqIn_5000Quantity = 2012.00;
            Double Stock1_35_40SqIn_5000Quantity = 2482.00;
            //Color, 250 Quantity.
            Double Stock1Color_5000Quantity = 230.00;

            //10000 Quantity.
            Double Stock1_0_2_5SqIn_10000Quantity = 931.00;
            Double Stock1_2_5_5SqIn_10000Quantity = 1180.00;
            Double Stock1_5_10SqIn_10000Quantity = 1492.00;
            Double Stock1_10_15SqIn_10000Quantity = 2383.00;
            Double Stock1_15_20SqIn_10000Quantity = 2395.00;
            Double Stock1_20_25SqIn_10000Quantity = 2845.00;
            Double Stock1_25_30SqIn_10000Quantity = 3593.00;
            Double Stock1_30_35SqIn_10000Quantity = 3600.00;
            Double Stock1_35_40SqIn_10000Quantity = 4428.00;
            //Color, 250 Quantity.
            Double Stock1Color_10000Quantity = 360.00;





            //======================================================================================================
            //Adhesive Pricing
            //======================================================================================================

            //Calculating the Square Inches from the form values.
            Double SelectedHeight = Convert.ToDouble(txtLabelHeight.Text);
            Double SelectedWidth = Convert.ToDouble(txtLabelWidth.Text);
            Double SqIn = Convert.ToDouble(txtLabelHeight.Text) * Convert.ToDouble(txtLabelWidth.Text);

            //Adhesive price is the value of the dropdown items.********
            Double AdhesiveSetupCharge = 0.00;


            //Checking to see if the Adhesive has been selected, if it has then add the setup charge to the price.
            if (Convert.ToDouble(ddlAdhesive.SelectedValue) > 0 && SelectedWidth > 0 && SelectedHeight > 0 && SqIn < 40.1)
            {
                //Adhesive Setup Charge.
                AdhesiveSetupCharge = 20.00;
            }
            else
            {
                AdhesiveSetupCharge = 0.00;
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

                //Geting the Adhesive price from form.
                //Adhesive price is the value of the dropdpwn items.
                Double AdhesivePrice = Convert.ToDouble(ddlAdhesive.SelectedValue);


                //Calculating Adhesive.
                //Calculating the TotalSqIn
                Double TotalSqIn = SqIn * Convert.ToDouble(ddlLabelQuantities.SelectedValue);
                //Calculating the TotalAdhesivePrice
                Double TotalAdhesivePrice = TotalSqIn * AdhesivePrice;
                //Calculating the TotalAdhesiveWithMinPrice
                Decimal TotalAdhesiveWithMinPrice = Convert.ToDecimal(TotalAdhesivePrice) + Convert.ToDecimal(AdhesiveSetupCharge);
                //formating the numbers that are displays to .00, this is done so people will know that it's money. 
                TotalAdhesiveWithMinPrice = Convert.ToDecimal(string.Format("{0:0.00}", TotalAdhesiveWithMinPrice));
                //Displaying the Price of Adhesive.
                lblAdhesive.Text = "Adhesive:" + " " + "$" + TotalAdhesiveWithMinPrice.ToString();

                //Caluclating the Total without Adhesive.
                Decimal TotalPricewithoutAdhesive = Convert.ToDecimal(Subtotal) + Convert.ToDecimal(ColorPrice);
                //formating the numbers that are displays to .00, this is done so people will know that it's money. 
                TotalPricewithoutAdhesive = Convert.ToDecimal(string.Format("{0:0.00}", TotalPricewithoutAdhesive));

                //Displaying the Subtotal.
                lblPriceWithoutAdhesive.Text = "Total Price Without Adhesive:" + " " + "$" + TotalPricewithoutAdhesive.ToString();

                //Calculating the Total Cost.
                Decimal Total = Convert.ToDecimal(Subtotal) + Convert.ToDecimal(ColorPrice) + Convert.ToDecimal(TotalAdhesiveWithMinPrice);
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

                //Geting the Adhesive price from form.
                //Adhesive price is the value of the dropdpwn items.
                Double AdhesivePrice = Convert.ToDouble(ddlAdhesive.SelectedValue);


                //Calculating Adhesive.
                //Calculating the TotalSqIn
                Double TotalSqIn = SqIn * Convert.ToDouble(ddlLabelQuantities.SelectedValue);
                //Calculating the TotalAdhesivePrice
                Double TotalAdhesivePrice = TotalSqIn * AdhesivePrice;
                //Calculating the TotalAdhesiveWithMinPrice
                Decimal TotalAdhesiveWithMinPrice = Convert.ToDecimal(TotalAdhesivePrice) + Convert.ToDecimal(AdhesiveSetupCharge);
                //formating the numbers that are displays to .00, this is done so people will know that it's money. 
                TotalAdhesiveWithMinPrice = Convert.ToDecimal(string.Format("{0:0.00}", TotalAdhesiveWithMinPrice));
                //Displaying the Price of Adhesive.
                lblAdhesive.Text = "Adhesive:" + " " + "$" + TotalAdhesiveWithMinPrice.ToString();

                //Caluclating the Total without Adhesive.
                Decimal TotalPricewithoutAdhesive = Convert.ToDecimal(Subtotal) + Convert.ToDecimal(ColorPrice);
                //formating the numbers that are displays to .00, this is done so people will know that it's money. 
                TotalPricewithoutAdhesive = Convert.ToDecimal(string.Format("{0:0.00}", TotalPricewithoutAdhesive));

                //Displaying the Subtotal.
                lblPriceWithoutAdhesive.Text = "Total Price Without Adhesive:" + " " + "$" + TotalPricewithoutAdhesive.ToString();

                //Calculating the Total Cost.
                Decimal Total = Convert.ToDecimal(Subtotal) + Convert.ToDecimal(ColorPrice) + Convert.ToDecimal(TotalAdhesiveWithMinPrice);
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

                //Geting the Adhesive price from form.
                //Adhesive price is the value of the dropdpwn items.
                Double AdhesivePrice = Convert.ToDouble(ddlAdhesive.SelectedValue);


                //Calculating Adhesive.
                //Calculating the TotalSqIn
                Double TotalSqIn = SqIn * Convert.ToDouble(ddlLabelQuantities.SelectedValue);
                //Calculating the TotalAdhesivePrice
                Double TotalAdhesivePrice = TotalSqIn * AdhesivePrice;
                //Calculating the TotalAdhesiveWithMinPrice
                Decimal TotalAdhesiveWithMinPrice = Convert.ToDecimal(TotalAdhesivePrice) + Convert.ToDecimal(AdhesiveSetupCharge);
                //formating the numbers that are displays to .00, this is done so people will know that it's money. 
                TotalAdhesiveWithMinPrice = Convert.ToDecimal(string.Format("{0:0.00}", TotalAdhesiveWithMinPrice));
                //Displaying the Price of Adhesive.
                lblAdhesive.Text = "Adhesive:" + " " + "$" + TotalAdhesiveWithMinPrice.ToString();

                //Caluclating the Total without Adhesive.
                Decimal TotalPricewithoutAdhesive = Convert.ToDecimal(Subtotal) + Convert.ToDecimal(ColorPrice);
                //formating the numbers that are displays to .00, this is done so people will know that it's money. 
                TotalPricewithoutAdhesive = Convert.ToDecimal(string.Format("{0:0.00}", TotalPricewithoutAdhesive));

                //Displaying the Subtotal.
                lblPriceWithoutAdhesive.Text = "Total Price Without Adhesive:" + " " + "$" + TotalPricewithoutAdhesive.ToString();

                //Calculating the Total Cost.
                Decimal Total = Convert.ToDecimal(Subtotal) + Convert.ToDecimal(ColorPrice) + Convert.ToDecimal(TotalAdhesiveWithMinPrice);
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

                //Geting the Adhesive price from form.
                //Adhesive price is the value of the dropdpwn items.
                Double AdhesivePrice = Convert.ToDouble(ddlAdhesive.SelectedValue);


                //Calculating Adhesive.
                //Calculating the TotalSqIn
                Double TotalSqIn = SqIn * Convert.ToDouble(ddlLabelQuantities.SelectedValue);
                //Calculating the TotalAdhesivePrice
                Double TotalAdhesivePrice = TotalSqIn * AdhesivePrice;
                //Calculating the TotalAdhesiveWithMinPrice
                Decimal TotalAdhesiveWithMinPrice = Convert.ToDecimal(TotalAdhesivePrice) + Convert.ToDecimal(AdhesiveSetupCharge);
                //formating the numbers that are displays to .00, this is done so people will know that it's money. 
                TotalAdhesiveWithMinPrice = Convert.ToDecimal(string.Format("{0:0.00}", TotalAdhesiveWithMinPrice));
                //Displaying the Price of Adhesive.
                lblAdhesive.Text = "Adhesive:" + " " + "$" + TotalAdhesiveWithMinPrice.ToString();

                //Caluclating the Total without Adhesive.
                Decimal TotalPricewithoutAdhesive = Convert.ToDecimal(Subtotal) + Convert.ToDecimal(ColorPrice);
                //formating the numbers that are displays to .00, this is done so people will know that it's money. 
                TotalPricewithoutAdhesive = Convert.ToDecimal(string.Format("{0:0.00}", TotalPricewithoutAdhesive));

                //Displaying the Subtotal.
                lblPriceWithoutAdhesive.Text = "Total Price Without Adhesive:" + " " + "$" + TotalPricewithoutAdhesive.ToString();

                //Calculating the Total Cost.
                Decimal Total = Convert.ToDecimal(Subtotal) + Convert.ToDecimal(ColorPrice) + Convert.ToDecimal(TotalAdhesiveWithMinPrice);
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

                //Geting the Adhesive price from form.
                //Adhesive price is the value of the dropdpwn items.
                Double AdhesivePrice = Convert.ToDouble(ddlAdhesive.SelectedValue);


                //Calculating Adhesive.
                //Calculating the TotalSqIn
                Double TotalSqIn = SqIn * Convert.ToDouble(ddlLabelQuantities.SelectedValue);
                //Calculating the TotalAdhesivePrice
                Double TotalAdhesivePrice = TotalSqIn * AdhesivePrice;
                //Calculating the TotalAdhesiveWithMinPrice
                Decimal TotalAdhesiveWithMinPrice = Convert.ToDecimal(TotalAdhesivePrice) + Convert.ToDecimal(AdhesiveSetupCharge);
                //formating the numbers that are displays to .00, this is done so people will know that it's money. 
                TotalAdhesiveWithMinPrice = Convert.ToDecimal(string.Format("{0:0.00}", TotalAdhesiveWithMinPrice));
                //Displaying the Price of Adhesive.
                lblAdhesive.Text = "Adhesive:" + " " + "$" + TotalAdhesiveWithMinPrice.ToString();

                //Caluclating the Total without Adhesive.
                Decimal TotalPricewithoutAdhesive = Convert.ToDecimal(Subtotal) + Convert.ToDecimal(ColorPrice);
                //formating the numbers that are displays to .00, this is done so people will know that it's money. 
                TotalPricewithoutAdhesive = Convert.ToDecimal(string.Format("{0:0.00}", TotalPricewithoutAdhesive));

                //Displaying the Subtotal.
                lblPriceWithoutAdhesive.Text = "Total Price Without Adhesive:" + " " + "$" + TotalPricewithoutAdhesive.ToString();

                //Calculating the Total Cost.
                Decimal Total = Convert.ToDecimal(Subtotal) + Convert.ToDecimal(ColorPrice) + Convert.ToDecimal(TotalAdhesiveWithMinPrice);
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

                //Geting the Adhesive price from form.
                //Adhesive price is the value of the dropdpwn items.
                Double AdhesivePrice = Convert.ToDouble(ddlAdhesive.SelectedValue);


                //Calculating Adhesive.
                //Calculating the TotalSqIn
                Double TotalSqIn = SqIn * Convert.ToDouble(ddlLabelQuantities.SelectedValue);
                //Calculating the TotalAdhesivePrice
                Double TotalAdhesivePrice = TotalSqIn * AdhesivePrice;
                //Calculating the TotalAdhesiveWithMinPrice
                Decimal TotalAdhesiveWithMinPrice = Convert.ToDecimal(TotalAdhesivePrice) + Convert.ToDecimal(AdhesiveSetupCharge);
                //formating the numbers that are displays to .00, this is done so people will know that it's money. 
                TotalAdhesiveWithMinPrice = Convert.ToDecimal(string.Format("{0:0.00}", TotalAdhesiveWithMinPrice));
                //Displaying the Price of Adhesive.
                lblAdhesive.Text = "Adhesive:" + " " + "$" + TotalAdhesiveWithMinPrice.ToString();

                //Caluclating the Total without Adhesive.
                Decimal TotalPricewithoutAdhesive = Convert.ToDecimal(Subtotal) + Convert.ToDecimal(ColorPrice);
                //formating the numbers that are displays to .00, this is done so people will know that it's money. 
                TotalPricewithoutAdhesive = Convert.ToDecimal(string.Format("{0:0.00}", TotalPricewithoutAdhesive));

                //Displaying the Subtotal.
                lblPriceWithoutAdhesive.Text = "Total Price Without Adhesive:" + " " + "$" + TotalPricewithoutAdhesive.ToString();

                //Calculating the Total Cost.
                Decimal Total = Convert.ToDecimal(Subtotal) + Convert.ToDecimal(ColorPrice) + Convert.ToDecimal(TotalAdhesiveWithMinPrice);
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

                //Geting the Adhesive price from form.
                //Adhesive price is the value of the dropdpwn items.
                Double AdhesivePrice = Convert.ToDouble(ddlAdhesive.SelectedValue);


                //Calculating Adhesive.
                //Calculating the TotalSqIn
                Double TotalSqIn = SqIn * Convert.ToDouble(ddlLabelQuantities.SelectedValue);
                //Calculating the TotalAdhesivePrice
                Double TotalAdhesivePrice = TotalSqIn * AdhesivePrice;
                //Calculating the TotalAdhesiveWithMinPrice
                Decimal TotalAdhesiveWithMinPrice = Convert.ToDecimal(TotalAdhesivePrice) + Convert.ToDecimal(AdhesiveSetupCharge);
                //formating the numbers that are displays to .00, this is done so people will know that it's money. 
                TotalAdhesiveWithMinPrice = Convert.ToDecimal(string.Format("{0:0.00}", TotalAdhesiveWithMinPrice));
                //Displaying the Price of Adhesive.
                lblAdhesive.Text = "Adhesive:" + " " + "$" + TotalAdhesiveWithMinPrice.ToString();

                //Caluclating the Total without Adhesive.
                Decimal TotalPricewithoutAdhesive = Convert.ToDecimal(Subtotal) + Convert.ToDecimal(ColorPrice);
                //formating the numbers that are displays to .00, this is done so people will know that it's money. 
                TotalPricewithoutAdhesive = Convert.ToDecimal(string.Format("{0:0.00}", TotalPricewithoutAdhesive));

                //Displaying the Subtotal.
                lblPriceWithoutAdhesive.Text = "Total Price Without Adhesive:" + " " + "$" + TotalPricewithoutAdhesive.ToString();

                //Calculating the Total Cost.
                Decimal Total = Convert.ToDecimal(Subtotal) + Convert.ToDecimal(ColorPrice) + Convert.ToDecimal(TotalAdhesiveWithMinPrice);
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

                //Geting the Adhesive price from form.
                //Adhesive price is the value of the dropdpwn items.
                Double AdhesivePrice = Convert.ToDouble(ddlAdhesive.SelectedValue);


                //Calculating Adhesive.
                //Calculating the TotalSqIn
                Double TotalSqIn = SqIn * Convert.ToDouble(ddlLabelQuantities.SelectedValue);
                //Calculating the TotalAdhesivePrice
                Double TotalAdhesivePrice = TotalSqIn * AdhesivePrice;
                //Calculating the TotalAdhesiveWithMinPrice
                Decimal TotalAdhesiveWithMinPrice = Convert.ToDecimal(TotalAdhesivePrice) + Convert.ToDecimal(AdhesiveSetupCharge);
                //formating the numbers that are displays to .00, this is done so people will know that it's money. 
                TotalAdhesiveWithMinPrice = Convert.ToDecimal(string.Format("{0:0.00}", TotalAdhesiveWithMinPrice));
                //Displaying the Price of Adhesive.
                lblAdhesive.Text = "Adhesive:" + " " + "$" + TotalAdhesiveWithMinPrice.ToString();

                //Caluclating the Total without Adhesive.
                Decimal TotalPricewithoutAdhesive = Convert.ToDecimal(Subtotal) + Convert.ToDecimal(ColorPrice);
                //formating the numbers that are displays to .00, this is done so people will know that it's money. 
                TotalPricewithoutAdhesive = Convert.ToDecimal(string.Format("{0:0.00}", TotalPricewithoutAdhesive));

                //Displaying the Subtotal.
                lblPriceWithoutAdhesive.Text = "Total Price Without Adhesive:" + " " + "$" + TotalPricewithoutAdhesive.ToString();

                //Calculating the Total Cost.
                Decimal Total = Convert.ToDecimal(Subtotal) + Convert.ToDecimal(ColorPrice) + Convert.ToDecimal(TotalAdhesiveWithMinPrice);
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

                //Geting the Adhesive price from form.
                //Adhesive price is the value of the dropdpwn items.
                Double AdhesivePrice = Convert.ToDouble(ddlAdhesive.SelectedValue);


                //Calculating Adhesive.
                //Calculating the TotalSqIn
                Double TotalSqIn = SqIn * Convert.ToDouble(ddlLabelQuantities.SelectedValue);
                //Calculating the TotalAdhesivePrice
                Double TotalAdhesivePrice = TotalSqIn * AdhesivePrice;
                //Calculating the TotalAdhesiveWithMinPrice
                Decimal TotalAdhesiveWithMinPrice = Convert.ToDecimal(TotalAdhesivePrice) + Convert.ToDecimal(AdhesiveSetupCharge);
                //formating the numbers that are displays to .00, this is done so people will know that it's money. 
                TotalAdhesiveWithMinPrice = Convert.ToDecimal(string.Format("{0:0.00}", TotalAdhesiveWithMinPrice));
                //Displaying the Price of Adhesive.
                lblAdhesive.Text = "Adhesive:" + " " + "$" + TotalAdhesiveWithMinPrice.ToString();

                //Caluclating the Total without Adhesive.
                Decimal TotalPricewithoutAdhesive = Convert.ToDecimal(Subtotal) + Convert.ToDecimal(ColorPrice);
                //formating the numbers that are displays to .00, this is done so people will know that it's money. 
                TotalPricewithoutAdhesive = Convert.ToDecimal(string.Format("{0:0.00}", TotalPricewithoutAdhesive));

                //Displaying the Subtotal.
                lblPriceWithoutAdhesive.Text = "Total Price Without Adhesive:" + " " + "$" + TotalPricewithoutAdhesive.ToString();

                //Calculating the Total Cost.
                Decimal Total = Convert.ToDecimal(Subtotal) + Convert.ToDecimal(ColorPrice) + Convert.ToDecimal(TotalAdhesiveWithMinPrice);
                //formating the numbers that are displays to .00, this is done so people will know that it's money. 
                Total = Convert.ToDecimal(string.Format("{0:0.00}", Total));

                //Displaying the Total Price.
                lblTotal.Text = "Total:" + " " + "$" + Total.ToString() + "*";

            }
        }
    }
}