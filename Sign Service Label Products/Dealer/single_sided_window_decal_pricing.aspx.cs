using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Sign_Service_Label_Products.Dealer
{
    public partial class window_decal_pricing : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            //Hides the Message if showing when you press the "Get Quote" button in the quote page template.
            if (IsPostBack)
            {
                lblCustomQuoteMessage.Text = "";
            }
        }

        protected void btnFindPrices_Click1(object sender, EventArgs e)
        {
            //Global Vars
            //======================================================================================================
            String CustomQuoteMessage = "<div class='alert alert-danger' role='alert'>Please call or email our sales desk for a custom quote at: <a href='tel:18007872382'>1 (800)-787-2382</a><br />or <a href='mailto:sales@signservice.com'>sales@signservice.com</a></div>";

            //======================================================================================================
            //Stock 1 Pricing
            //======================================================================================================

            //50 Quantity.
            Double Stock1_0_2_5SqIn_50Quantity = 196.00;
            Double Stock1_2_5_5SqIn_50Quantity = 197.00;
            Double Stock1_5_10SqIn_50Quantity = 200.00;
            Double Stock1_10_15SqIn_50Quantity = 203.00;
            Double Stock1_15_20SqIn_50Quantity = 205.00;
            Double Stock1_20_25SqIn_50Quantity = 208.00;
            Double Stock1_25_30SqIn_50Quantity = 211.00;
            Double Stock1_30_35SqIn_50Quantity = 214.00;
            Double Stock1_35_40SqIn_50Quantity = 217.00;
            //Color, 50 Quantity.
            Double Stock1Color_50Quantity = 60.00;

            //100 Quantity.
            Double Stock1_0_2_5SqIn_100Quantity = 210.00;
            Double Stock1_2_5_5SqIn_100Quantity = 210.00;
            Double Stock1_5_10SqIn_100Quantity = 215.00;
            Double Stock1_10_15SqIn_100Quantity = 220.00;
            Double Stock1_15_20SqIn_100Quantity = 224.00;
            Double Stock1_20_25SqIn_100Quantity = 229.00;
            Double Stock1_25_30SqIn_100Quantity = 234.00;
            Double Stock1_30_35SqIn_100Quantity = 471.00;
            Double Stock1_35_40SqIn_100Quantity = 244.00;
            //Color, 100 Quantity.
            Double Stock1Color_100Quantity = 65.00;

            //250 Quantity.
            Double Stock1_0_2_5SqIn_250Quantity = 245.00;
            Double Stock1_2_5_5SqIn_250Quantity = 246.00;
            Double Stock1_5_10SqIn_250Quantity = 255.00;
            Double Stock1_10_15SqIn_250Quantity = 267.00;
            Double Stock1_15_20SqIn_250Quantity = 274.00;
            Double Stock1_20_25SqIn_250Quantity = 285.00;
            Double Stock1_25_30SqIn_250Quantity = 296.00;
            Double Stock1_30_35SqIn_250Quantity = 303.00;
            Double Stock1_35_40SqIn_250Quantity = 371.00;
            //Color, 250 Quantity.
            Double Stock1Color_250Quantity = 75.00;

            //500 Quantity.
            Double Stock1_0_2_5SqIn_500Quantity = 264.00;
            Double Stock1_2_5_5SqIn_500Quantity = 272.00;
            Double Stock1_5_10SqIn_500Quantity = 292.00;
            Double Stock1_10_15SqIn_500Quantity = 313.00;
            Double Stock1_15_20SqIn_500Quantity = 330.00;
            Double Stock1_20_25SqIn_500Quantity = 356.00;
            Double Stock1_25_30SqIn_500Quantity = 358.00;
            Double Stock1_30_35SqIn_500Quantity = 392.00;
            Double Stock1_35_40SqIn_500Quantity = 410.00;
            //Color, 250 Quantity.
            Double Stock1Color_500Quantity = 80.00;

            //1000 Quantity.
            Double Stock1_0_2_5SqIn_1000Quantity = 308.00;
            Double Stock1_2_5_5SqIn_1000Quantity = 325.00;
            Double Stock1_5_10SqIn_1000Quantity = 383.00;
            Double Stock1_10_15SqIn_1000Quantity = 419.00;
            Double Stock1_15_20SqIn_1000Quantity = 440.00;
            Double Stock1_20_25SqIn_1000Quantity = 492.00;
            Double Stock1_25_30SqIn_1000Quantity = 494.00;
            Double Stock1_30_35SqIn_1000Quantity = 596.00;
            Double Stock1_35_40SqIn_1000Quantity = 601.00;
            //Color, 250 Quantity.
            Double Stock1Color_1000Quantity = 85.00;

            //2000 Quantity.
            Double Stock1_0_2_5SqIn_2000Quantity = 394.00;
            Double Stock1_2_5_5SqIn_2000Quantity = 427.00;
            Double Stock1_5_10SqIn_2000Quantity = 552.00;
            Double Stock1_10_15SqIn_2000Quantity = 598.00;
            Double Stock1_15_20SqIn_2000Quantity = 665.00;
            Double Stock1_20_25SqIn_2000Quantity = 769.00;
            Double Stock1_25_30SqIn_2000Quantity = 789.00;
            Double Stock1_30_35SqIn_2000Quantity = 924.00;
            Double Stock1_35_40SqIn_2000Quantity = 1032.00;
            //Color, 250 Quantity.
            Double Stock1Color_2000Quantity = 100.00;

            //2500 Quantity.
            Double Stock1_0_2_5SqIn_2500Quantity = 445.00;
            Double Stock1_2_5_5SqIn_2500Quantity = 485.00;
            Double Stock1_5_10SqIn_2500Quantity = 623.00;
            Double Stock1_10_15SqIn_2500Quantity = 699.00;
            Double Stock1_15_20SqIn_2500Quantity = 786.00;
            Double Stock1_20_25SqIn_2500Quantity = 908.00;
            Double Stock1_25_30SqIn_2500Quantity = 935.00;
            Double Stock1_30_35SqIn_2500Quantity = 1097.00;
            Double Stock1_35_40SqIn_2500Quantity = 1232.00;
            //Color, 250 Quantity.
            Double Stock1Color_2500Quantity = 115.00;

            //5000 Quantity.
            Double Stock1_0_2_5SqIn_5000Quantity = 742.00;
            Double Stock1_2_5_5SqIn_5000Quantity = 812.00;
            Double Stock1_5_10SqIn_5000Quantity = 1023.00;
            Double Stock1_10_15SqIn_5000Quantity = 1246.00;
            Double Stock1_15_20SqIn_5000Quantity = 1429.00;
            Double Stock1_20_25SqIn_5000Quantity = 1642.00;
            Double Stock1_25_30SqIn_5000Quantity = 1706.00;
            Double Stock1_30_35SqIn_5000Quantity = 1000.00;
            Double Stock1_35_40SqIn_5000Quantity = 2269.00;
            //Color, 250 Quantity.
            Double Stock1Color_5000Quantity = 230.00;

            //10000 Quantity.
            Double Stock1_0_2_5SqIn_10000Quantity = 1232.00;
            Double Stock1_2_5_5SqIn_10000Quantity = 1396.00;
            Double Stock1_5_10SqIn_10000Quantity = 1723.00;
            Double Stock1_10_15SqIn_10000Quantity = 2181.00;
            Double Stock1_15_20SqIn_10000Quantity = 2496.00;
            Double Stock1_20_25SqIn_10000Quantity = 2883.00;
            Double Stock1_25_30SqIn_10000Quantity = 3016.00;
            Double Stock1_30_35SqIn_10000Quantity = 3531.00;
            Double Stock1_35_40SqIn_10000Quantity = 4048.00;
            //Color, 250 Quantity.
            Double Stock1Color_10000Quantity = 360.00;

            //======================================================================================================
            //Stock 2 Pricing
            //======================================================================================================

            //50 Quantity.
            Double Stock2_0_2_5SqIn_50Quantity = 196.00;
            Double Stock2_2_5_5SqIn_50Quantity = 197.00;
            Double Stock2_5_10SqIn_50Quantity = 200.00;
            Double Stock2_10_15SqIn_50Quantity = 203.00;
            Double Stock2_15_20SqIn_50Quantity = 205.00;
            Double Stock2_20_25SqIn_50Quantity = 208.00;
            Double Stock2_25_30SqIn_50Quantity = 211.00;
            Double Stock2_30_35SqIn_50Quantity = 214.00;
            Double Stock2_35_40SqIn_50Quantity = 217.00;
            //Color, 50 Quantity.
            Double Stock2Color_50Quantity = 60.00;

            //100 Quantity.
            Double Stock2_0_2_5SqIn_100Quantity = 210.00;
            Double Stock2_2_5_5SqIn_100Quantity = 210.00;
            Double Stock2_5_10SqIn_100Quantity = 215.00;
            Double Stock2_10_15SqIn_100Quantity = 220.00;
            Double Stock2_15_20SqIn_100Quantity = 224.00;
            Double Stock2_20_25SqIn_100Quantity = 229.00;
            Double Stock2_25_30SqIn_100Quantity = 234.00;
            Double Stock2_30_35SqIn_100Quantity = 471.00;
            Double Stock2_35_40SqIn_100Quantity = 244.00;
            //Color, 100 Quantity.
            Double Stock2Color_100Quantity = 65.00;

            //250 Quantity.
            Double Stock2_0_2_5SqIn_250Quantity = 245.00;
            Double Stock2_2_5_5SqIn_250Quantity = 246.00;
            Double Stock2_5_10SqIn_250Quantity = 255.00;
            Double Stock2_10_15SqIn_250Quantity = 267.00;
            Double Stock2_15_20SqIn_250Quantity = 274.00;
            Double Stock2_20_25SqIn_250Quantity = 285.00;
            Double Stock2_25_30SqIn_250Quantity = 296.00;
            Double Stock2_30_35SqIn_250Quantity = 303.00;
            Double Stock2_35_40SqIn_250Quantity = 371.00;
            //Color, 250 Quantity.
            Double Stock2Color_250Quantity = 75.00;

            //500 Quantity.
            Double Stock2_0_2_5SqIn_500Quantity = 264.00;
            Double Stock2_2_5_5SqIn_500Quantity = 272.00;
            Double Stock2_5_10SqIn_500Quantity = 292.00;
            Double Stock2_10_15SqIn_500Quantity = 313.00;
            Double Stock2_15_20SqIn_500Quantity = 330.00;
            Double Stock2_20_25SqIn_500Quantity = 356.00;
            Double Stock2_25_30SqIn_500Quantity = 358.00;
            Double Stock2_30_35SqIn_500Quantity = 392.00;
            Double Stock2_35_40SqIn_500Quantity = 410.00;
            //Color, 250 Quantity.
            Double Stock2Color_500Quantity = 80.00;

            //1000 Quantity.
            Double Stock2_0_2_5SqIn_1000Quantity = 308.00;
            Double Stock2_2_5_5SqIn_1000Quantity = 325.00;
            Double Stock2_5_10SqIn_1000Quantity = 383.00;
            Double Stock2_10_15SqIn_1000Quantity = 419.00;
            Double Stock2_15_20SqIn_1000Quantity = 440.00;
            Double Stock2_20_25SqIn_1000Quantity = 492.00;
            Double Stock2_25_30SqIn_1000Quantity = 494.00;
            Double Stock2_30_35SqIn_1000Quantity = 596.00;
            Double Stock2_35_40SqIn_1000Quantity = 601.00;
            //Color, 250 Quantity.
            Double Stock2Color_1000Quantity = 85.00;

            //2000 Quantity.
            Double Stock2_0_2_5SqIn_2000Quantity = 394.00;
            Double Stock2_2_5_5SqIn_2000Quantity = 427.00;
            Double Stock2_5_10SqIn_2000Quantity = 552.00;
            Double Stock2_10_15SqIn_2000Quantity = 598.00;
            Double Stock2_15_20SqIn_2000Quantity = 665.00;
            Double Stock2_20_25SqIn_2000Quantity = 769.00;
            Double Stock2_25_30SqIn_2000Quantity = 789.00;
            Double Stock2_30_35SqIn_2000Quantity = 924.00;
            Double Stock2_35_40SqIn_2000Quantity = 1032.00;
            //Color, 250 Quantity.
            Double Stock2Color_2000Quantity = 100.00;

            //2500 Quantity.
            Double Stock2_0_2_5SqIn_2500Quantity = 445.00;
            Double Stock2_2_5_5SqIn_2500Quantity = 485.00;
            Double Stock2_5_10SqIn_2500Quantity = 623.00;
            Double Stock2_10_15SqIn_2500Quantity = 699.00;
            Double Stock2_15_20SqIn_2500Quantity = 786.00;
            Double Stock2_20_25SqIn_2500Quantity = 908.00;
            Double Stock2_25_30SqIn_2500Quantity = 935.00;
            Double Stock2_30_35SqIn_2500Quantity = 1097.00;
            Double Stock2_35_40SqIn_2500Quantity = 1232.00;
            //Color, 250 Quantity.
            Double Stock2Color_2500Quantity = 115.00;

            //5000 Quantity.
            Double Stock2_0_2_5SqIn_5000Quantity = 742.00;
            Double Stock2_2_5_5SqIn_5000Quantity = 812.00;
            Double Stock2_5_10SqIn_5000Quantity = 1023.00;
            Double Stock2_10_15SqIn_5000Quantity = 1246.00;
            Double Stock2_15_20SqIn_5000Quantity = 1429.00;
            Double Stock2_20_25SqIn_5000Quantity = 1642.00;
            Double Stock2_25_30SqIn_5000Quantity = 1706.00;
            Double Stock2_30_35SqIn_5000Quantity = 1000.00;
            Double Stock2_35_40SqIn_5000Quantity = 2269.00;
            //Color, 250 Quantity.
            Double Stock2Color_5000Quantity = 230.00;

            //10000 Quantity.
            Double Stock2_0_2_5SqIn_10000Quantity = 1232.00;
            Double Stock2_2_5_5SqIn_10000Quantity = 1396.00;
            Double Stock2_5_10SqIn_10000Quantity = 1723.00;
            Double Stock2_10_15SqIn_10000Quantity = 2181.00;
            Double Stock2_15_20SqIn_10000Quantity = 2496.00;
            Double Stock2_20_25SqIn_10000Quantity = 2883.00;
            Double Stock2_25_30SqIn_10000Quantity = 3016.00;
            Double Stock2_30_35SqIn_10000Quantity = 3531.00;
            Double Stock2_35_40SqIn_10000Quantity = 4048.00;
            //Color, 250 Quantity.
            Double Stock2Color_10000Quantity = 360.00;

            //======================================================================================================
            //Stock 3 Pricing
            //======================================================================================================

            //50 Quantity.
            Double Stock3_0_2_5SqIn_50Quantity = 195.00;
            Double Stock3_2_5_5SqIn_50Quantity = 195.00;
            Double Stock3_5_10SqIn_50Quantity = 199.00;
            Double Stock3_10_15SqIn_50Quantity = 201.00;
            Double Stock3_15_20SqIn_50Quantity = 203.00;
            Double Stock3_20_25SqIn_50Quantity = 205.00;
            Double Stock3_25_30SqIn_50Quantity = 206.00;
            Double Stock3_30_35SqIn_50Quantity = 210.00;
            Double Stock3_35_40SqIn_50Quantity = 213.00;
            //Color, 50 Quantity.
            Double Stock3Color_50Quantity = 60.00;

            //100 Quantity.
            Double Stock3_0_2_5SqIn_100Quantity = 207.00;
            Double Stock3_2_5_5SqIn_100Quantity = 207.00;
            Double Stock3_5_10SqIn_100Quantity = 212.00;
            Double Stock3_10_15SqIn_100Quantity = 216.00;
            Double Stock3_15_20SqIn_100Quantity = 219.00;
            Double Stock3_20_25SqIn_100Quantity = 223.00;
            Double Stock3_25_30SqIn_100Quantity = 224.00;
            Double Stock3_30_35SqIn_100Quantity = 229.00;
            Double Stock3_35_40SqIn_100Quantity = 234.00;
            //Color, 100 Quantity.
            Double Stock3Color_100Quantity = 65.00;

            //250 Quantity.
            Double Stock3_0_2_5SqIn_250Quantity = 229.00;
            Double Stock3_2_5_5SqIn_250Quantity = 230.00;
            Double Stock3_5_10SqIn_250Quantity = 241.00;
            Double Stock3_10_15SqIn_250Quantity = 250.00;
            Double Stock3_15_20SqIn_250Quantity = 257.00;
            Double Stock3_20_25SqIn_250Quantity = 267.00;
            Double Stock3_25_30SqIn_250Quantity = 271.00;
            Double Stock3_30_35SqIn_250Quantity = 283.00;
            Double Stock3_35_40SqIn_250Quantity = 293.00;
            //Color, 250 Quantity.
            Double Stock3Color_250Quantity = 75.00;

            //500 Quantity.
            Double Stock3_0_2_5SqIn_500Quantity = 260.00;
            Double Stock3_2_5_5SqIn_500Quantity = 261.00;
            Double Stock3_5_10SqIn_500Quantity = 280.00;
            Double Stock3_10_15SqIn_500Quantity = 285.00;
            Double Stock3_15_20SqIn_500Quantity = 307.00;
            Double Stock3_20_25SqIn_500Quantity = 318.00;
            Double Stock3_25_30SqIn_500Quantity = 328.00;
            Double Stock3_30_35SqIn_500Quantity = 330.00;
            Double Stock3_35_40SqIn_500Quantity = 365.00;
            //Color, 250 Quantity.
            Double Stock3Color_500Quantity = 80.00;

            //1000 Quantity.
            Double Stock3_0_2_5SqIn_1000Quantity = 297.00;
            Double Stock3_2_5_5SqIn_1000Quantity = 312.00;
            Double Stock3_5_10SqIn_1000Quantity = 253.00;
            Double Stock3_10_15SqIn_1000Quantity = 391.00;
            Double Stock3_15_20SqIn_1000Quantity = 395.00;
            Double Stock3_20_25SqIn_1000Quantity = 432.00;
            Double Stock3_25_30SqIn_1000Quantity = 437.00;
            Double Stock3_30_35SqIn_1000Quantity = 507.00;
            Double Stock3_35_40SqIn_1000Quantity = 511.00;
            //Color, 250 Quantity.
            Double Stock3Color_1000Quantity = 85.00;

            //2000 Quantity.
            Double Stock3_0_2_5SqIn_2000Quantity = 379.00;
            Double Stock3_2_5_5SqIn_2000Quantity = 404.00;
            Double Stock3_5_10SqIn_2000Quantity = 496.00;
            Double Stock3_10_15SqIn_2000Quantity = 567.00;
            Double Stock3_15_20SqIn_2000Quantity = 575.00;
            Double Stock3_20_25SqIn_2000Quantity = 650.00;
            Double Stock3_25_30SqIn_2000Quantity = 670.00;
            Double Stock3_30_35SqIn_2000Quantity = 765.00;
            Double Stock3_35_40SqIn_2000Quantity = 854.00;
            //Color, 250 Quantity.
            Double Stock3Color_2000Quantity = 100.00;

            //2500 Quantity.
            Double Stock3_0_2_5SqIn_2500Quantity = 428.00;
            Double Stock3_2_5_5SqIn_2500Quantity = 435.00;
            Double Stock3_5_10SqIn_2500Quantity = 556.00;
            Double Stock3_10_15SqIn_2500Quantity = 647.00;
            Double Stock3_15_20SqIn_2500Quantity = 655.00;
            Double Stock3_20_25SqIn_2500Quantity = 764.00;
            Double Stock3_25_30SqIn_2500Quantity = 792.00;
            Double Stock3_30_35SqIn_2500Quantity = 905.00;
            Double Stock3_35_40SqIn_2500Quantity = 1017.00;
            //Color, 250 Quantity.
            Double Stock3Color_2500Quantity = 115.00;

            //5000 Quantity.
            Double Stock3_0_2_5SqIn_5000Quantity = 135.00;
            Double Stock3_2_5_5SqIn_5000Quantity = 145.00;
            Double Stock3_5_10SqIn_5000Quantity = 150.00;
            Double Stock3_10_15SqIn_5000Quantity = 155.00;
            Double Stock3_15_20SqIn_5000Quantity = 160.00;
            Double Stock3_20_25SqIn_5000Quantity = 170.00;
            Double Stock3_25_30SqIn_5000Quantity = 175.00;
            Double Stock3_30_35SqIn_5000Quantity = 185.00;
            Double Stock3_35_40SqIn_5000Quantity = 195.00;
            //Color, 250 Quantity.
            Double Stock3Color_5000Quantity = 230.00;

            //10000 Quantity.
            Double Stock3_0_2_5SqIn_10000Quantity = 710.00;
            Double Stock3_2_5_5SqIn_10000Quantity = 777.00;
            Double Stock3_5_10SqIn_10000Quantity = 913.00;
            Double Stock3_10_15SqIn_10000Quantity = 1086.00;
            Double Stock3_15_20SqIn_10000Quantity = 1097.00;
            Double Stock3_20_25SqIn_10000Quantity = 1375.00;
            Double Stock3_25_30SqIn_10000Quantity = 1439.00;
            Double Stock3_30_35SqIn_10000Quantity = 1944.00;
            Double Stock3_35_40SqIn_10000Quantity = 1869.00;
            //Color, 250 Quantity.
            Double Stock3Color_10000Quantity = 360.00;

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
            if (ddlStock.SelectedValue == "1" && ddlLabelQuantities.SelectedValue == "50")
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
            if (ddlStock.SelectedValue == "1" && ddlLabelQuantities.SelectedValue == "100")
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
            if (ddlStock.SelectedValue == "1" && ddlLabelQuantities.SelectedValue == "250")
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
            if (ddlStock.SelectedValue == "1" && ddlLabelQuantities.SelectedValue == "500")
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
            if (ddlStock.SelectedValue == "1" && ddlLabelQuantities.SelectedValue == "1000")
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
            if (ddlStock.SelectedValue == "1" && ddlLabelQuantities.SelectedValue == "2000")
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
            if (ddlStock.SelectedValue == "1" && ddlLabelQuantities.SelectedValue == "2500")
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
            if (ddlStock.SelectedValue == "1" && ddlLabelQuantities.SelectedValue == "5000")
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
            if (ddlStock.SelectedValue == "1" && ddlLabelQuantities.SelectedValue == "10000")
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




            //======================================================================================================
            //Stock 2
            //======================================================================================================

            //50 Quantity If Statements
            //======================================================================================================

            //Finding out if the stock is and show the price for that stock.
            if (ddlStock.SelectedValue == "2" && ddlLabelQuantities.SelectedValue == "50")
            {
                Double Subtotal = 0;

                //Displaying the Subtotal.
                if (SqIn >= 0 && SqIn <= 2.5)
                {
                    Subtotal = Stock2_0_2_5SqIn_50Quantity;
                }
                else if (SqIn >= 2.5 && SqIn <= 5)
                {
                    Subtotal = Stock2_2_5_5SqIn_50Quantity;
                }
                else if (SqIn >= 5.1 && SqIn <= 10)
                {
                    Subtotal = Stock2_5_10SqIn_50Quantity;
                }
                else if (SqIn >= 10.1 && SqIn <= 15)
                {
                    Subtotal = Stock2_10_15SqIn_50Quantity;
                }
                else if (SqIn >= 15.1 && SqIn <= 20)
                {
                    Subtotal = Stock2_15_20SqIn_50Quantity;
                }
                else if (SqIn >= 20.1 && SqIn <= 25)
                {
                    Subtotal = Stock2_20_25SqIn_50Quantity;
                }
                else if (SqIn >= 25.1 && SqIn <= 30)
                {
                    Subtotal = Stock2_25_30SqIn_50Quantity;
                }
                else if (SqIn >= 30.1 && SqIn <= 35)
                {
                    Subtotal = Stock2_30_35SqIn_50Quantity;
                }
                else if (SqIn >= 35.1 && SqIn <= 40)
                {
                    Subtotal = Stock2_35_40SqIn_50Quantity;
                }
                else if (SqIn > 40.1)
                {
                    lblCustomQuoteMessage.Text = CustomQuoteMessage;
                }
                //Calculating the price for the colors.
                Double ColorPrice = Stock2Color_50Quantity * Convert.ToDouble(NumberOfColors);

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
            if (ddlStock.SelectedValue == "2" && ddlLabelQuantities.SelectedValue == "100")
            {
                Double Subtotal = 0;

                //Displaying the Subtotal.
                if (SqIn >= 0 && SqIn <= 2.5)
                {
                    Subtotal = Stock2_0_2_5SqIn_100Quantity;
                }
                else if (SqIn >= 2.5 && SqIn <= 5)
                {
                    Subtotal = Stock2_2_5_5SqIn_100Quantity;
                }
                else if (SqIn >= 5.1 && SqIn <= 10)
                {
                    Subtotal = Stock2_5_10SqIn_100Quantity;
                }
                else if (SqIn >= 10.1 && SqIn <= 15)
                {
                    Subtotal = Stock2_10_15SqIn_100Quantity;
                }
                else if (SqIn >= 15.1 && SqIn <= 20)
                {
                    Subtotal = Stock2_15_20SqIn_100Quantity;
                }
                else if (SqIn >= 20.1 && SqIn <= 25)
                {
                    Subtotal = Stock2_20_25SqIn_100Quantity;
                }
                else if (SqIn >= 25.1 && SqIn <= 30)
                {
                    Subtotal = Stock2_25_30SqIn_100Quantity;
                }
                else if (SqIn >= 30.1 && SqIn <= 35)
                {
                    Subtotal = Stock2_30_35SqIn_100Quantity;
                }
                else if (SqIn >= 35.1 && SqIn <= 40)
                {
                    Subtotal = Stock2_35_40SqIn_100Quantity;
                }
                else if (SqIn > 40.1)
                {
                    lblCustomQuoteMessage.Text = CustomQuoteMessage;
                }
                //Calculating the price for the colors.
                Double ColorPrice = Stock2Color_100Quantity * Convert.ToDouble(NumberOfColors);

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
            if (ddlStock.SelectedValue == "2" && ddlLabelQuantities.SelectedValue == "250")
            {
                Double Subtotal = 0;

                //Displaying the Subtotal.
                if (SqIn >= 0 && SqIn <= 2.5)
                {
                    Subtotal = Stock2_0_2_5SqIn_250Quantity;
                }
                else if (SqIn >= 2.5 && SqIn <= 5)
                {
                    Subtotal = Stock2_2_5_5SqIn_250Quantity;
                }
                else if (SqIn >= 5.1 && SqIn <= 10)
                {
                    Subtotal = Stock2_5_10SqIn_250Quantity;
                }
                else if (SqIn >= 10.1 && SqIn <= 15)
                {
                    Subtotal = Stock2_10_15SqIn_250Quantity;
                }
                else if (SqIn >= 15.1 && SqIn <= 20)
                {
                    Subtotal = Stock2_15_20SqIn_250Quantity;
                }
                else if (SqIn >= 20.1 && SqIn <= 25)
                {
                    Subtotal = Stock2_20_25SqIn_250Quantity;
                }
                else if (SqIn >= 25.1 && SqIn <= 30)
                {
                    Subtotal = Stock2_25_30SqIn_250Quantity;
                }
                else if (SqIn >= 30.1 && SqIn <= 35)
                {
                    Subtotal = Stock2_30_35SqIn_250Quantity;
                }
                else if (SqIn >= 35.1 && SqIn <= 40)
                {
                    Subtotal = Stock2_35_40SqIn_250Quantity;
                }
                else if (SqIn > 40.1)
                {
                    lblCustomQuoteMessage.Text = CustomQuoteMessage;
                }
                //Calculating the price for the colors.
                Double ColorPrice = Stock2Color_250Quantity * Convert.ToDouble(NumberOfColors);

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
            if (ddlStock.SelectedValue == "2" && ddlLabelQuantities.SelectedValue == "500")
            {
                Double Subtotal = 0;

                //Displaying the Subtotal.
                if (SqIn >= 0 && SqIn <= 2.5)
                {
                    Subtotal = Stock2_0_2_5SqIn_500Quantity;
                }
                else if (SqIn >= 2.5 && SqIn <= 5)
                {
                    Subtotal = Stock2_2_5_5SqIn_500Quantity;
                }
                else if (SqIn >= 5.1 && SqIn <= 10)
                {
                    Subtotal = Stock2_5_10SqIn_500Quantity;
                }
                else if (SqIn >= 10.1 && SqIn <= 15)
                {
                    Subtotal = Stock2_10_15SqIn_500Quantity;
                }
                else if (SqIn >= 15.1 && SqIn <= 20)
                {
                    Subtotal = Stock2_15_20SqIn_500Quantity;
                }
                else if (SqIn >= 20.1 && SqIn <= 25)
                {
                    Subtotal = Stock2_20_25SqIn_500Quantity;
                }
                else if (SqIn >= 25.1 && SqIn <= 30)
                {
                    Subtotal = Stock2_25_30SqIn_500Quantity;
                }
                else if (SqIn >= 30.1 && SqIn <= 35)
                {
                    Subtotal = Stock2_30_35SqIn_500Quantity;
                }
                else if (SqIn >= 35.1 && SqIn <= 40)
                {
                    Subtotal = Stock2_35_40SqIn_500Quantity;
                }
                else if (SqIn > 40.1)
                {
                    lblCustomQuoteMessage.Text = CustomQuoteMessage;
                }
                //Calculating the price for the colors.
                Double ColorPrice = Stock2Color_500Quantity * Convert.ToDouble(NumberOfColors);

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
            if (ddlStock.SelectedValue == "2" && ddlLabelQuantities.SelectedValue == "1000")
            {
                Double Subtotal = 0;

                //Displaying the Subtotal.
                if (SqIn >= 0 && SqIn <= 2.5)
                {
                    Subtotal = Stock2_0_2_5SqIn_1000Quantity;
                }
                else if (SqIn >= 2.5 && SqIn <= 5)
                {
                    Subtotal = Stock2_2_5_5SqIn_1000Quantity;
                }
                else if (SqIn >= 5.1 && SqIn <= 10)
                {
                    Subtotal = Stock2_5_10SqIn_1000Quantity;
                }
                else if (SqIn >= 10.1 && SqIn <= 15)
                {
                    Subtotal = Stock2_10_15SqIn_1000Quantity;
                }
                else if (SqIn >= 15.1 && SqIn <= 20)
                {
                    Subtotal = Stock2_15_20SqIn_1000Quantity;
                }
                else if (SqIn >= 20.1 && SqIn <= 25)
                {
                    Subtotal = Stock2_20_25SqIn_1000Quantity;
                }
                else if (SqIn >= 25.1 && SqIn <= 30)
                {
                    Subtotal = Stock2_25_30SqIn_1000Quantity;
                }
                else if (SqIn >= 30.1 && SqIn <= 35)
                {
                    Subtotal = Stock2_30_35SqIn_1000Quantity;
                }
                else if (SqIn >= 35.1 && SqIn <= 40)
                {
                    Subtotal = Stock2_35_40SqIn_1000Quantity;
                }
                else if (SqIn > 40.1)
                {
                    lblCustomQuoteMessage.Text = CustomQuoteMessage;
                }
                //Calculating the price for the colors.
                Double ColorPrice = Stock2Color_1000Quantity * Convert.ToDouble(NumberOfColors);

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
            if (ddlStock.SelectedValue == "2" && ddlLabelQuantities.SelectedValue == "2000")
            {
                Double Subtotal = 0;

                //Displaying the Subtotal.
                if (SqIn >= 0 && SqIn <= 2.5)
                {
                    Subtotal = Stock2_0_2_5SqIn_2000Quantity;
                }
                else if (SqIn >= 2.5 && SqIn <= 5)
                {
                    Subtotal = Stock2_2_5_5SqIn_2000Quantity;
                }
                else if (SqIn >= 5.1 && SqIn <= 10)
                {
                    Subtotal = Stock2_5_10SqIn_2000Quantity;
                }
                else if (SqIn >= 10.1 && SqIn <= 15)
                {
                    Subtotal = Stock2_10_15SqIn_2000Quantity;
                }
                else if (SqIn >= 15.1 && SqIn <= 20)
                {
                    Subtotal = Stock2_15_20SqIn_2000Quantity;
                }
                else if (SqIn >= 20.1 && SqIn <= 25)
                {
                    Subtotal = Stock2_20_25SqIn_2000Quantity;
                }
                else if (SqIn >= 25.1 && SqIn <= 30)
                {
                    Subtotal = Stock2_25_30SqIn_2000Quantity;
                }
                else if (SqIn >= 30.1 && SqIn <= 35)
                {
                    Subtotal = Stock2_30_35SqIn_2000Quantity;
                }
                else if (SqIn >= 35.1 && SqIn <= 40)
                {
                    Subtotal = Stock2_35_40SqIn_2000Quantity;
                }
                else if (SqIn > 40.1)
                {
                    lblCustomQuoteMessage.Text = CustomQuoteMessage;
                }
                //Calculating the price for the colors.
                Double ColorPrice = Stock2Color_2000Quantity * Convert.ToDouble(NumberOfColors);

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
            if (ddlStock.SelectedValue == "2" && ddlLabelQuantities.SelectedValue == "2500")
            {
                Double Subtotal = 0;

                //Displaying the Subtotal.
                if (SqIn >= 0 && SqIn <= 2.5)
                {
                    Subtotal = Stock2_0_2_5SqIn_2500Quantity;
                }
                else if (SqIn >= 2.5 && SqIn <= 5)
                {
                    Subtotal = Stock2_2_5_5SqIn_2500Quantity;
                }
                else if (SqIn >= 5.1 && SqIn <= 10)
                {
                    Subtotal = Stock2_5_10SqIn_2500Quantity;
                }
                else if (SqIn >= 10.1 && SqIn <= 15)
                {
                    Subtotal = Stock2_10_15SqIn_2500Quantity;
                }
                else if (SqIn >= 15.1 && SqIn <= 20)
                {
                    Subtotal = Stock2_15_20SqIn_2500Quantity;
                }
                else if (SqIn >= 20.1 && SqIn <= 25)
                {
                    Subtotal = Stock2_20_25SqIn_2500Quantity;
                }
                else if (SqIn >= 25.1 && SqIn <= 30)
                {
                    Subtotal = Stock2_25_30SqIn_2500Quantity;
                }
                else if (SqIn >= 30.1 && SqIn <= 35)
                {
                    Subtotal = Stock2_30_35SqIn_2500Quantity;
                }
                else if (SqIn >= 35.1 && SqIn <= 40)
                {
                    Subtotal = Stock2_35_40SqIn_2500Quantity;
                }
                else if (SqIn > 40.1)
                {
                    lblCustomQuoteMessage.Text = CustomQuoteMessage;
                }
                //Calculating the price for the colors.
                Double ColorPrice = Stock2Color_2500Quantity * Convert.ToDouble(NumberOfColors);

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
            if (ddlStock.SelectedValue == "2" && ddlLabelQuantities.SelectedValue == "5000")
            {
                Double Subtotal = 0;

                //Displaying the Subtotal.
                if (SqIn >= 0 && SqIn <= 2.5)
                {
                    Subtotal = Stock2_0_2_5SqIn_5000Quantity;
                }
                else if (SqIn >= 2.5 && SqIn <= 5)
                {
                    Subtotal = Stock2_2_5_5SqIn_5000Quantity;
                }
                else if (SqIn >= 5.1 && SqIn <= 10)
                {
                    Subtotal = Stock2_5_10SqIn_5000Quantity;
                }
                else if (SqIn >= 10.1 && SqIn <= 15)
                {
                    Subtotal = Stock2_10_15SqIn_5000Quantity;
                }
                else if (SqIn >= 15.1 && SqIn <= 20)
                {
                    Subtotal = Stock2_15_20SqIn_5000Quantity;
                }
                else if (SqIn >= 20.1 && SqIn <= 25)
                {
                    Subtotal = Stock2_20_25SqIn_5000Quantity;
                }
                else if (SqIn >= 25.1 && SqIn <= 30)
                {
                    Subtotal = Stock2_25_30SqIn_5000Quantity;
                }
                else if (SqIn >= 30.1 && SqIn <= 35)
                {
                    Subtotal = Stock2_30_35SqIn_5000Quantity;
                }
                else if (SqIn >= 35.1 && SqIn <= 40)
                {
                    Subtotal = Stock2_35_40SqIn_5000Quantity;
                }
                else if (SqIn > 40.1)
                {
                    lblCustomQuoteMessage.Text = CustomQuoteMessage;
                }
                //Calculating the price for the colors.
                Double ColorPrice = Stock2Color_5000Quantity * Convert.ToDouble(NumberOfColors);

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
            if (ddlStock.SelectedValue == "2" && ddlLabelQuantities.SelectedValue == "10000")
            {
                Double Subtotal = 0;

                //Displaying the Subtotal.
                if (SqIn >= 0 && SqIn <= 2.5)
                {
                    Subtotal = Stock2_0_2_5SqIn_10000Quantity;
                }
                else if (SqIn >= 2.5 && SqIn <= 5)
                {
                    Subtotal = Stock2_2_5_5SqIn_10000Quantity;
                }
                else if (SqIn >= 5.1 && SqIn <= 10)
                {
                    Subtotal = Stock2_5_10SqIn_10000Quantity;
                }
                else if (SqIn >= 10.1 && SqIn <= 15)
                {
                    Subtotal = Stock2_10_15SqIn_10000Quantity;
                }
                else if (SqIn >= 15.1 && SqIn <= 20)
                {
                    Subtotal = Stock2_15_20SqIn_10000Quantity;
                }
                else if (SqIn >= 20.1 && SqIn <= 25)
                {
                    Subtotal = Stock2_20_25SqIn_10000Quantity;
                }
                else if (SqIn >= 25.1 && SqIn <= 30)
                {
                    Subtotal = Stock2_25_30SqIn_10000Quantity;
                }
                else if (SqIn >= 30.1 && SqIn <= 35)
                {
                    Subtotal = Stock2_30_35SqIn_10000Quantity;
                }
                else if (SqIn >= 35.1 && SqIn <= 40)
                {
                    Subtotal = Stock2_35_40SqIn_10000Quantity;
                }
                else if (SqIn > 40.1)
                {
                    lblCustomQuoteMessage.Text = CustomQuoteMessage;
                }
                //Calculating the price for the colors.
                Double ColorPrice = Stock2Color_10000Quantity * Convert.ToDouble(NumberOfColors);

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





            //======================================================================================================
            //Stock 3
            //======================================================================================================

            //50 Quantity If Statements
            //======================================================================================================

            //Finding out if the stock is and show the price for that stock.
            if (ddlStock.SelectedValue == "3" && ddlLabelQuantities.SelectedValue == "50")
            {
                Double Subtotal = 0;

                //Displaying the Subtotal.
                if (SqIn >= 0 && SqIn <= 2.5)
                {
                    Subtotal = Stock3_0_2_5SqIn_50Quantity;
                }
                else if (SqIn >= 2.5 && SqIn <= 5)
                {
                    Subtotal = Stock3_2_5_5SqIn_50Quantity;
                }
                else if (SqIn >= 5.1 && SqIn <= 10)
                {
                    Subtotal = Stock3_5_10SqIn_50Quantity;
                }
                else if (SqIn >= 10.1 && SqIn <= 15)
                {
                    Subtotal = Stock3_10_15SqIn_50Quantity;
                }
                else if (SqIn >= 15.1 && SqIn <= 20)
                {
                    Subtotal = Stock3_15_20SqIn_50Quantity;
                }
                else if (SqIn >= 20.1 && SqIn <= 25)
                {
                    Subtotal = Stock3_20_25SqIn_50Quantity;
                }
                else if (SqIn >= 25.1 && SqIn <= 30)
                {
                    Subtotal = Stock3_25_30SqIn_50Quantity;
                }
                else if (SqIn >= 30.1 && SqIn <= 35)
                {
                    Subtotal = Stock3_30_35SqIn_50Quantity;
                }
                else if (SqIn >= 35.1 && SqIn <= 40)
                {
                    Subtotal = Stock3_35_40SqIn_50Quantity;
                }
                else if (SqIn > 40.1)
                {
                    lblCustomQuoteMessage.Text = CustomQuoteMessage;
                }
                //Calculating the price for the colors.
                Double ColorPrice = Stock3Color_50Quantity * Convert.ToDouble(NumberOfColors);

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
            if (ddlStock.SelectedValue == "3" && ddlLabelQuantities.SelectedValue == "100")
            {
                Double Subtotal = 0;

                //Displaying the Subtotal.
                if (SqIn >= 0 && SqIn <= 2.5)
                {
                    Subtotal = Stock3_0_2_5SqIn_100Quantity;
                }
                else if (SqIn >= 2.5 && SqIn <= 5)
                {
                    Subtotal = Stock3_2_5_5SqIn_100Quantity;
                }
                else if (SqIn >= 5.1 && SqIn <= 10)
                {
                    Subtotal = Stock3_5_10SqIn_100Quantity;
                }
                else if (SqIn >= 10.1 && SqIn <= 15)
                {
                    Subtotal = Stock3_10_15SqIn_100Quantity;
                }
                else if (SqIn >= 15.1 && SqIn <= 20)
                {
                    Subtotal = Stock3_15_20SqIn_100Quantity;
                }
                else if (SqIn >= 20.1 && SqIn <= 25)
                {
                    Subtotal = Stock3_20_25SqIn_100Quantity;
                }
                else if (SqIn >= 25.1 && SqIn <= 30)
                {
                    Subtotal = Stock3_25_30SqIn_100Quantity;
                }
                else if (SqIn >= 30.1 && SqIn <= 35)
                {
                    Subtotal = Stock3_30_35SqIn_100Quantity;
                }
                else if (SqIn >= 35.1 && SqIn <= 40)
                {
                    Subtotal = Stock3_35_40SqIn_100Quantity;
                }
                else if (SqIn > 40.1)
                {
                    lblCustomQuoteMessage.Text = CustomQuoteMessage;
                }
                //Calculating the price for the colors.
                Double ColorPrice = Stock3Color_100Quantity * Convert.ToDouble(NumberOfColors);

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
            if (ddlStock.SelectedValue == "3" && ddlLabelQuantities.SelectedValue == "250")
            {
                Double Subtotal = 0;

                //Displaying the Subtotal.
                if (SqIn >= 0 && SqIn <= 2.5)
                {
                    Subtotal = Stock3_0_2_5SqIn_250Quantity;
                }
                else if (SqIn >= 2.5 && SqIn <= 5)
                {
                    Subtotal = Stock3_2_5_5SqIn_250Quantity;
                }
                else if (SqIn >= 5.1 && SqIn <= 10)
                {
                    Subtotal = Stock3_5_10SqIn_250Quantity;
                }
                else if (SqIn >= 10.1 && SqIn <= 15)
                {
                    Subtotal = Stock3_10_15SqIn_250Quantity;
                }
                else if (SqIn >= 15.1 && SqIn <= 20)
                {
                    Subtotal = Stock3_15_20SqIn_250Quantity;
                }
                else if (SqIn >= 20.1 && SqIn <= 25)
                {
                    Subtotal = Stock3_20_25SqIn_250Quantity;
                }
                else if (SqIn >= 25.1 && SqIn <= 30)
                {
                    Subtotal = Stock3_25_30SqIn_250Quantity;
                }
                else if (SqIn >= 30.1 && SqIn <= 35)
                {
                    Subtotal = Stock3_30_35SqIn_250Quantity;
                }
                else if (SqIn >= 35.1 && SqIn <= 40)
                {
                    Subtotal = Stock3_35_40SqIn_250Quantity;
                }
                else if (SqIn > 40.1)
                {
                    lblCustomQuoteMessage.Text = CustomQuoteMessage;
                }
                //Calculating the price for the colors.
                Double ColorPrice = Stock3Color_250Quantity * Convert.ToDouble(NumberOfColors);

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
            if (ddlStock.SelectedValue == "3" && ddlLabelQuantities.SelectedValue == "500")
            {
                Double Subtotal = 0;

                //Displaying the Subtotal.
                if (SqIn >= 0 && SqIn <= 2.5)
                {
                    Subtotal = Stock3_0_2_5SqIn_500Quantity;
                }
                else if (SqIn >= 2.5 && SqIn <= 5)
                {
                    Subtotal = Stock3_2_5_5SqIn_500Quantity;
                }
                else if (SqIn >= 5.1 && SqIn <= 10)
                {
                    Subtotal = Stock3_5_10SqIn_500Quantity;
                }
                else if (SqIn >= 10.1 && SqIn <= 15)
                {
                    Subtotal = Stock3_10_15SqIn_500Quantity;
                }
                else if (SqIn >= 15.1 && SqIn <= 20)
                {
                    Subtotal = Stock3_15_20SqIn_500Quantity;
                }
                else if (SqIn >= 20.1 && SqIn <= 25)
                {
                    Subtotal = Stock3_20_25SqIn_500Quantity;
                }
                else if (SqIn >= 25.1 && SqIn <= 30)
                {
                    Subtotal = Stock3_25_30SqIn_500Quantity;
                }
                else if (SqIn >= 30.1 && SqIn <= 35)
                {
                    Subtotal = Stock3_30_35SqIn_500Quantity;
                }
                else if (SqIn >= 35.1 && SqIn <= 40)
                {
                    Subtotal = Stock3_35_40SqIn_500Quantity;
                }
                else if (SqIn > 40.1)
                {
                    lblCustomQuoteMessage.Text = CustomQuoteMessage;
                }
                //Calculating the price for the colors.
                Double ColorPrice = Stock3Color_500Quantity * Convert.ToDouble(NumberOfColors);

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
            if (ddlStock.SelectedValue == "3" && ddlLabelQuantities.SelectedValue == "1000")
            {
                Double Subtotal = 0;

                //Displaying the Subtotal.
                if (SqIn >= 0 && SqIn <= 2.5)
                {
                    Subtotal = Stock3_0_2_5SqIn_1000Quantity;
                }
                else if (SqIn >= 2.5 && SqIn <= 5)
                {
                    Subtotal = Stock3_2_5_5SqIn_1000Quantity;
                }
                else if (SqIn >= 5.1 && SqIn <= 10)
                {
                    Subtotal = Stock3_5_10SqIn_1000Quantity;
                }
                else if (SqIn >= 10.1 && SqIn <= 15)
                {
                    Subtotal = Stock3_10_15SqIn_1000Quantity;
                }
                else if (SqIn >= 15.1 && SqIn <= 20)
                {
                    Subtotal = Stock3_15_20SqIn_1000Quantity;
                }
                else if (SqIn >= 20.1 && SqIn <= 25)
                {
                    Subtotal = Stock3_20_25SqIn_1000Quantity;
                }
                else if (SqIn >= 25.1 && SqIn <= 30)
                {
                    Subtotal = Stock3_25_30SqIn_1000Quantity;
                }
                else if (SqIn >= 30.1 && SqIn <= 35)
                {
                    Subtotal = Stock3_30_35SqIn_1000Quantity;
                }
                else if (SqIn >= 35.1 && SqIn <= 40)
                {
                    Subtotal = Stock3_35_40SqIn_1000Quantity;
                }
                else if (SqIn > 40.1)
                {
                    lblCustomQuoteMessage.Text = CustomQuoteMessage;
                }
                //Calculating the price for the colors.
                Double ColorPrice = Stock3Color_1000Quantity * Convert.ToDouble(NumberOfColors);

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
            if (ddlStock.SelectedValue == "3" && ddlLabelQuantities.SelectedValue == "2000")
            {
                Double Subtotal = 0;

                //Displaying the Subtotal.
                if (SqIn >= 0 && SqIn <= 2.5)
                {
                    Subtotal = Stock3_0_2_5SqIn_2000Quantity;
                }
                else if (SqIn >= 2.5 && SqIn <= 5)
                {
                    Subtotal = Stock3_2_5_5SqIn_2000Quantity;
                }
                else if (SqIn >= 5.1 && SqIn <= 10)
                {
                    Subtotal = Stock3_5_10SqIn_2000Quantity;
                }
                else if (SqIn >= 10.1 && SqIn <= 15)
                {
                    Subtotal = Stock3_10_15SqIn_2000Quantity;
                }
                else if (SqIn >= 15.1 && SqIn <= 20)
                {
                    Subtotal = Stock3_15_20SqIn_2000Quantity;
                }
                else if (SqIn >= 20.1 && SqIn <= 25)
                {
                    Subtotal = Stock3_20_25SqIn_2000Quantity;
                }
                else if (SqIn >= 25.1 && SqIn <= 30)
                {
                    Subtotal = Stock3_25_30SqIn_2000Quantity;
                }
                else if (SqIn >= 30.1 && SqIn <= 35)
                {
                    Subtotal = Stock3_30_35SqIn_2000Quantity;
                }
                else if (SqIn >= 35.1 && SqIn <= 40)
                {
                    Subtotal = Stock3_35_40SqIn_2000Quantity;
                }
                else if (SqIn > 40.1)
                {
                    lblCustomQuoteMessage.Text = CustomQuoteMessage;
                }
                //Calculating the price for the colors.
                Double ColorPrice = Stock3Color_2000Quantity * Convert.ToDouble(NumberOfColors);

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
            if (ddlStock.SelectedValue == "3" && ddlLabelQuantities.SelectedValue == "2500")
            {
                Double Subtotal = 0;

                //Displaying the Subtotal.
                if (SqIn >= 0 && SqIn <= 2.5)
                {
                    Subtotal = Stock3_0_2_5SqIn_2500Quantity;
                }
                else if (SqIn >= 2.5 && SqIn <= 5)
                {
                    Subtotal = Stock3_2_5_5SqIn_2500Quantity;
                }
                else if (SqIn >= 5.1 && SqIn <= 10)
                {
                    Subtotal = Stock3_5_10SqIn_2500Quantity;
                }
                else if (SqIn >= 10.1 && SqIn <= 15)
                {
                    Subtotal = Stock3_10_15SqIn_2500Quantity;
                }
                else if (SqIn >= 15.1 && SqIn <= 20)
                {
                    Subtotal = Stock3_15_20SqIn_2500Quantity;
                }
                else if (SqIn >= 20.1 && SqIn <= 25)
                {
                    Subtotal = Stock3_20_25SqIn_2500Quantity;
                }
                else if (SqIn >= 25.1 && SqIn <= 30)
                {
                    Subtotal = Stock3_25_30SqIn_2500Quantity;
                }
                else if (SqIn >= 30.1 && SqIn <= 35)
                {
                    Subtotal = Stock3_30_35SqIn_2500Quantity;
                }
                else if (SqIn >= 35.1 && SqIn <= 40)
                {
                    Subtotal = Stock3_35_40SqIn_2500Quantity;
                }
                else if (SqIn > 40.1)
                {
                    lblCustomQuoteMessage.Text = CustomQuoteMessage;
                }
                //Calculating the price for the colors.
                Double ColorPrice = Stock3Color_2500Quantity * Convert.ToDouble(NumberOfColors);

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
            if (ddlStock.SelectedValue == "3" && ddlLabelQuantities.SelectedValue == "5000")
            {
                Double Subtotal = 0;

                //Displaying the Subtotal.
                if (SqIn >= 0 && SqIn <= 2.5)
                {
                    Subtotal = Stock3_0_2_5SqIn_5000Quantity;
                }
                else if (SqIn >= 2.5 && SqIn <= 5)
                {
                    Subtotal = Stock3_2_5_5SqIn_5000Quantity;
                }
                else if (SqIn >= 5.1 && SqIn <= 10)
                {
                    Subtotal = Stock3_5_10SqIn_5000Quantity;
                }
                else if (SqIn >= 10.1 && SqIn <= 15)
                {
                    Subtotal = Stock3_10_15SqIn_5000Quantity;
                }
                else if (SqIn >= 15.1 && SqIn <= 20)
                {
                    Subtotal = Stock3_15_20SqIn_5000Quantity;
                }
                else if (SqIn >= 20.1 && SqIn <= 25)
                {
                    Subtotal = Stock3_20_25SqIn_5000Quantity;
                }
                else if (SqIn >= 25.1 && SqIn <= 30)
                {
                    Subtotal = Stock3_25_30SqIn_5000Quantity;
                }
                else if (SqIn >= 30.1 && SqIn <= 35)
                {
                    Subtotal = Stock3_30_35SqIn_5000Quantity;
                }
                else if (SqIn >= 35.1 && SqIn <= 40)
                {
                    Subtotal = Stock3_35_40SqIn_5000Quantity;
                }
                else if (SqIn > 40.1)
                {
                    lblCustomQuoteMessage.Text = CustomQuoteMessage;
                }
                //Calculating the price for the colors.
                Double ColorPrice = Stock3Color_5000Quantity * Convert.ToDouble(NumberOfColors);

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
            if (ddlStock.SelectedValue == "3" && ddlLabelQuantities.SelectedValue == "10000")
            {
                Double Subtotal = 0;

                //Displaying the Subtotal.
                if (SqIn >= 0 && SqIn <= 2.5)
                {
                    Subtotal = Stock3_0_2_5SqIn_10000Quantity;
                }
                else if (SqIn >= 2.5 && SqIn <= 5)
                {
                    Subtotal = Stock3_2_5_5SqIn_10000Quantity;
                }
                else if (SqIn >= 5.1 && SqIn <= 10)
                {
                    Subtotal = Stock3_5_10SqIn_10000Quantity;
                }
                else if (SqIn >= 10.1 && SqIn <= 15)
                {
                    Subtotal = Stock3_10_15SqIn_10000Quantity;
                }
                else if (SqIn >= 15.1 && SqIn <= 20)
                {
                    Subtotal = Stock3_15_20SqIn_10000Quantity;
                }
                else if (SqIn >= 20.1 && SqIn <= 25)
                {
                    Subtotal = Stock3_20_25SqIn_10000Quantity;
                }
                else if (SqIn >= 25.1 && SqIn <= 30)
                {
                    Subtotal = Stock3_25_30SqIn_10000Quantity;
                }
                else if (SqIn >= 30.1 && SqIn <= 35)
                {
                    Subtotal = Stock3_30_35SqIn_10000Quantity;
                }
                else if (SqIn >= 35.1 && SqIn <= 40)
                {
                    Subtotal = Stock3_35_40SqIn_10000Quantity;
                }
                else if (SqIn > 40.1)
                {
                    lblCustomQuoteMessage.Text = CustomQuoteMessage;
                }
                //Calculating the price for the colors.
                Double ColorPrice = Stock3Color_10000Quantity * Convert.ToDouble(NumberOfColors);

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