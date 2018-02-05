using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Sign_Service_Label_Products.dealer
{
    public partial class reflective_vinyl_pricing : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            //Hides the Message if showing when you press the "Get Quote" button the quote template.
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
            Double Stock1_2_5_5SqIn_50Quantity = 148.00;
            Double Stock1_5_10SqIn_50Quantity = 158.00;
            Double Stock1_10_15SqIn_50Quantity = 167.00;
            Double Stock1_15_20SqIn_50Quantity = 176.00;
            Double Stock1_20_25SqIn_50Quantity = 184.00;
            Double Stock1_25_30SqIn_50Quantity = 194.00;
            Double Stock1_30_35SqIn_50Quantity = 201.00;
            Double Stock1_35_40SqIn_50Quantity = 220.00;
            //Color, 50 Quantity.
            Double Stock1Color_50Quantity = 60.00;

            //100 Quantity.
            Double Stock1_0_2_5SqIn_100Quantity = 167.00;
            Double Stock1_2_5_5SqIn_100Quantity = 169.00;
            Double Stock1_5_10SqIn_100Quantity = 187.00;
            Double Stock1_10_15SqIn_100Quantity = 203.00;
            Double Stock1_15_20SqIn_100Quantity = 222.00;
            Double Stock1_20_25SqIn_100Quantity = 236.00;
            Double Stock1_25_30SqIn_100Quantity = 255.00;
            Double Stock1_30_35SqIn_100Quantity = 268.00;
            Double Stock1_35_40SqIn_100Quantity = 304.00;
            //Color, 100 Quantity.
            Double Stock1Color_100Quantity = 65.00;

            //250 Quantity.
            Double Stock1_0_2_5SqIn_250Quantity = 225.00;
            Double Stock1_2_5_5SqIn_250Quantity = 226.00;
            Double Stock1_5_10SqIn_250Quantity = 273.00;
            Double Stock1_10_15SqIn_250Quantity = 312.00;
            Double Stock1_15_20SqIn_250Quantity = 357.00;
            Double Stock1_20_25SqIn_250Quantity = 391.00;
            Double Stock1_25_30SqIn_250Quantity = 438.00;
            Double Stock1_30_35SqIn_250Quantity = 496.00;
            Double Stock1_35_40SqIn_250Quantity = 557.00;
            //Color, 250 Quantity.
            Double Stock1Color_250Quantity = 75.00;

            //500 Quantity.
            Double Stock1_0_2_5SqIn_500Quantity = 248.00;
            Double Stock1_2_5_5SqIn_500Quantity = 308.00;
            Double Stock1_5_10SqIn_500Quantity = 402.00;
            Double Stock1_10_15SqIn_500Quantity = 450.00;
            Double Stock1_15_20SqIn_500Quantity = 570.00;
            Double Stock1_20_25SqIn_500Quantity = 637.00;
            Double Stock1_25_30SqIn_500Quantity = 731.00;
            Double Stock1_30_35SqIn_500Quantity = 794.00;
            Double Stock1_35_40SqIn_500Quantity = 971.00;
            //Color, 250 Quantity.
            Double Stock1Color_500Quantity = 80.00;

            //1000 Quantity.
            Double Stock1_0_2_5SqIn_1000Quantity = 352.00;
            Double Stock1_2_5_5SqIn_1000Quantity = 472.00;
            Double Stock1_5_10SqIn_1000Quantity = 660.00;
            Double Stock1_10_15SqIn_1000Quantity = 756.00;
            Double Stock1_15_20SqIn_1000Quantity = 897.00;
            Double Stock1_20_25SqIn_1000Quantity = 1130.00;
            Double Stock1_25_30SqIn_1000Quantity = 1318.00;
            Double Stock1_30_35SqIn_1000Quantity = 1597.00;
            Double Stock1_35_40SqIn_1000Quantity = 1601.00;
            //Color, 250 Quantity.
            Double Stock1Color_1000Quantity = 85.00;

            //2000 Quantity.
            Double Stock1_0_2_5SqIn_2000Quantity = 496.00;
            Double Stock1_2_5_5SqIn_2000Quantity = 708.00;
            Double Stock1_5_10SqIn_2000Quantity = 1175.00;
            Double Stock1_10_15SqIn_2000Quantity = 1397.00;
            Double Stock1_15_20SqIn_2000Quantity = 1650.00;
            Double Stock1_20_25SqIn_2000Quantity = 2117.00;
            Double Stock1_25_30SqIn_2000Quantity = 2748.00;
            Double Stock1_30_35SqIn_2000Quantity = 2754.00;
            Double Stock1_35_40SqIn_2000Quantity = 3104.00;
            //Color, 250 Quantity.
            Double Stock1Color_2000Quantity = 100.00;

            //2500 Quantity.
            Double Stock1_0_2_5SqIn_2500Quantity = 574.00;
            Double Stock1_2_5_5SqIn_2500Quantity = 795.00;
            Double Stock1_5_10SqIn_2500Quantity = 1409.00;
            Double Stock1_10_15SqIn_2500Quantity = 1633.00;
            Double Stock1_15_20SqIn_2500Quantity = 2007.00;
            Double Stock1_20_25SqIn_2500Quantity = 2540.00;
            Double Stock1_25_30SqIn_2500Quantity = 3305.00;
            Double Stock1_30_35SqIn_2500Quantity = 3311.00;
            Double Stock1_35_40SqIn_2500Quantity = 3738.00;
            //Color, 250 Quantity.
            Double Stock1Color_2500Quantity = 115.00;

            //5000 Quantity.
            Double Stock1_0_2_5SqIn_5000Quantity = 968.00;
            Double Stock1_2_5_5SqIn_5000Quantity = 1250.00;
            Double Stock1_5_10SqIn_5000Quantity = 2579.00;
            Double Stock1_10_15SqIn_5000Quantity = 2965.00;
            Double Stock1_15_20SqIn_5000Quantity = 3797.00;
            Double Stock1_20_25SqIn_5000Quantity = 4660.00;
            Double Stock1_25_30SqIn_5000Quantity = 6094.00;
            Double Stock1_30_35SqIn_5000Quantity = 6100.00;
            Double Stock1_35_40SqIn_5000Quantity = 6911.00;
            //Color, 250 Quantity.
            Double Stock1Color_5000Quantity = 230.00;

            //10000 Quantity.
            Double Stock1_0_2_5SqIn_10000Quantity = 1565.00;
            Double Stock1_2_5_5SqIn_10000Quantity = 2186.00;
            Double Stock1_5_10SqIn_10000Quantity = 4610.00;
            Double Stock1_10_15SqIn_10000Quantity = 5271.00;
            Double Stock1_15_20SqIn_10000Quantity = 6737.00;
            Double Stock1_20_25SqIn_10000Quantity = 8274.00;
            Double Stock1_25_30SqIn_10000Quantity = 10832.00;
            Double Stock1_30_35SqIn_10000Quantity = 10838.00;
            Double Stock1_35_40SqIn_10000Quantity = 12314.00;
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



            //======================================================================================================
            //Stock 1
            //======================================================================================================

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