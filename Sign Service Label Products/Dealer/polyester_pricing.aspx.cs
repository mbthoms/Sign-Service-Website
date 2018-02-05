using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Sign_Service_Label_Products.Dealer
{
    public partial class polyester_pricing : System.Web.UI.Page
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
            //Stock 1 Pricing
            //======================================================================================================

            //50 Quantity.
            Double Stock1_0_2_5SqIn_50Quantity = 137.00;
            Double Stock1_2_5_5SqIn_50Quantity = 137.00;
            Double Stock1_5_10SqIn_50Quantity = 141.00;
            Double Stock1_10_15SqIn_50Quantity = 143.00;
            Double Stock1_15_20SqIn_50Quantity = 146.00;
            Double Stock1_20_25SqIn_50Quantity = 150.00;
            Double Stock1_25_30SqIn_50Quantity = 155.00;
            Double Stock1_30_35SqIn_50Quantity = 156.00;
            Double Stock1_35_40SqIn_50Quantity = 159.00;
            //Color, 50 Quantity.
            Double Stock1Color_50Quantity = 60.00;

            //100 Quantity.
            Double Stock1_0_2_5SqIn_100Quantity = 146.00;
            Double Stock1_2_5_5SqIn_100Quantity = 146.00;
            Double Stock1_5_10SqIn_100Quantity = 151.00;
            Double Stock1_10_15SqIn_100Quantity = 156.00;
            Double Stock1_15_20SqIn_100Quantity = 160.00;
            Double Stock1_20_25SqIn_100Quantity = 167.00;
            Double Stock1_25_30SqIn_100Quantity = 176.00;
            Double Stock1_30_35SqIn_100Quantity = 177.00;
            Double Stock1_35_40SqIn_100Quantity = 182.00;
            //Color, 100 Quantity.
            Double Stock1Color_100Quantity = 65.00;

            //250 Quantity.
            Double Stock1_0_2_5SqIn_250Quantity = 172.00;
            Double Stock1_2_5_5SqIn_250Quantity = 173.00;
            Double Stock1_5_10SqIn_250Quantity = 184.00;
            Double Stock1_10_15SqIn_250Quantity = 194.00;
            Double Stock1_15_20SqIn_250Quantity = 203.00;
            Double Stock1_20_25SqIn_250Quantity = 219.00;
            Double Stock1_25_30SqIn_250Quantity = 238.00;
            Double Stock1_30_35SqIn_250Quantity = 240.00;
            Double Stock1_35_40SqIn_250Quantity = 250.00;
            //Color, 250 Quantity.
            Double Stock1Color_250Quantity = 75.00;

            //500 Quantity.
            Double Stock1_0_2_5SqIn_500Quantity = 186.00;
            Double Stock1_2_5_5SqIn_500Quantity = 198.00;
            Double Stock1_5_10SqIn_500Quantity = 218.00;
            Double Stock1_10_15SqIn_500Quantity = 243.00;
            Double Stock1_15_20SqIn_500Quantity = 262.00;
            Double Stock1_20_25SqIn_500Quantity = 293.00;
            Double Stock1_25_30SqIn_500Quantity = 295.00;
            Double Stock1_30_35SqIn_500Quantity = 353.00;
            Double Stock1_35_40SqIn_500Quantity = 356.00;
            //Color, 250 Quantity.
            Double Stock1Color_500Quantity = 80.00;

            //1000 Quantity.
            Double Stock1_0_2_5SqIn_1000Quantity = 228.00;
            Double Stock1_2_5_5SqIn_1000Quantity = 246.00;
            Double Stock1_5_10SqIn_1000Quantity = 287.00;
            Double Stock1_10_15SqIn_1000Quantity = 342.00;
            Double Stock1_15_20SqIn_1000Quantity = 380.00;
            Double Stock1_20_25SqIn_1000Quantity = 441.00;
            Double Stock1_25_30SqIn_1000Quantity = 558.00;
            Double Stock1_30_35SqIn_1000Quantity = 562.00;
            Double Stock1_35_40SqIn_1000Quantity = 567.00;
            //Color, 250 Quantity.
            Double Stock1Color_1000Quantity = 85.00;

            //2000 Quantity.
            Double Stock1_0_2_5SqIn_2000Quantity = 303.00;
            Double Stock1_2_5_5SqIn_2000Quantity = 335.00;
            Double Stock1_5_10SqIn_2000Quantity = 429.00;
            Double Stock1_10_15SqIn_2000Quantity = 607.00;
            Double Stock1_15_20SqIn_2000Quantity = 616.00;
            Double Stock1_20_25SqIn_2000Quantity = 751.00;
            Double Stock1_25_30SqIn_2000Quantity = 757.00;
            Double Stock1_30_35SqIn_2000Quantity = 1029.00;
            Double Stock1_35_40SqIn_2000Quantity = 1034.00;
            //Color, 250 Quantity.
            Double Stock1Color_2000Quantity = 100.00;

            //2500 Quantity.
            Double Stock1_0_2_5SqIn_2500Quantity = 340.00;
            Double Stock1_2_5_5SqIn_2500Quantity = 384.00;
            Double Stock1_5_10SqIn_2500Quantity = 499.00;
            Double Stock1_10_15SqIn_2500Quantity = 691.00;
            Double Stock1_15_20SqIn_2500Quantity = 801.00;
            Double Stock1_20_25SqIn_2500Quantity = 892.00;
            Double Stock1_25_30SqIn_2500Quantity = 902.00;
            Double Stock1_30_35SqIn_2500Quantity = 1235.00;
            Double Stock1_35_40SqIn_2500Quantity = 1240.00;
            //Color, 250 Quantity.
            Double Stock1Color_2500Quantity = 115.00;

            //5000 Quantity.
            Double Stock1_0_2_5SqIn_5000Quantity = 522.00;
            Double Stock1_2_5_5SqIn_5000Quantity = 631.00;
            Double Stock1_5_10SqIn_5000Quantity = 861.00;
            Double Stock1_10_15SqIn_5000Quantity = 1108.00;
            Double Stock1_15_20SqIn_5000Quantity = 1727.00;
            Double Stock1_20_25SqIn_5000Quantity = 1622.00;
            Double Stock1_25_30SqIn_5000Quantity = 1629.00;
            Double Stock1_30_35SqIn_5000Quantity = 2264.00;
            Double Stock1_35_40SqIn_5000Quantity = 2268.00;
            //Color, 250 Quantity.
            Double Stock1Color_5000Quantity = 230.00;

            //10000 Quantity.
            Double Stock1_0_2_5SqIn_10000Quantity = 989.00;
            Double Stock1_2_5_5SqIn_10000Quantity = 1270.00;
            Double Stock1_5_10SqIn_10000Quantity = 1831.00;
            Double Stock1_10_15SqIn_10000Quantity = 1983.00;
            Double Stock1_15_20SqIn_10000Quantity = 3071.00;
            Double Stock1_20_25SqIn_10000Quantity = 2919.00;
            Double Stock1_25_30SqIn_10000Quantity = 2926.00;
            Double Stock1_30_35SqIn_10000Quantity = 4089.00;
            Double Stock1_35_40SqIn_10000Quantity = 4093.00;
            //Color, 250 Quantity.
            Double Stock1Color_10000Quantity = 360.00;

            //======================================================================================================
            //Stock 2 Pricing
            //======================================================================================================

            //50 Quantity.
            Double Stock2_0_2_5SqIn_50Quantity = 138.00;
            Double Stock2_2_5_5SqIn_50Quantity = 139.00;
            Double Stock2_5_10SqIn_50Quantity = 143.00;
            Double Stock2_10_15SqIn_50Quantity = 146.00;
            Double Stock2_15_20SqIn_50Quantity = 149.00;
            Double Stock2_20_25SqIn_50Quantity = 154.00;
            Double Stock2_25_30SqIn_50Quantity = 161.00;
            Double Stock2_30_35SqIn_50Quantity = 162.00;
            Double Stock2_35_40SqIn_50Quantity = 165.00;
            //Color, 50 Quantity.
            Double Stock2Color_50Quantity = 60.00;

            //100 Quantity.
            Double Stock2_0_2_5SqIn_100Quantity = 148.00;
            Double Stock2_2_5_5SqIn_100Quantity = 149.00;
            Double Stock2_5_10SqIn_100Quantity = 155.00;
            Double Stock2_10_15SqIn_100Quantity = 161.00;
            Double Stock2_15_20SqIn_100Quantity = 167.00;
            Double Stock2_20_25SqIn_100Quantity = 176.00;
            Double Stock2_25_30SqIn_100Quantity = 187.00;
            Double Stock2_30_35SqIn_100Quantity = 188.00;
            Double Stock2_35_40SqIn_100Quantity = 194.00;
            //Color, 100 Quantity.
            Double Stock2Color_100Quantity = 65.00;

            //250 Quantity.
            Double Stock2_0_2_5SqIn_250Quantity = 178.00;
            Double Stock2_2_5_5SqIn_250Quantity = 117.00;
            Double Stock2_5_10SqIn_250Quantity = 193.00;
            Double Stock2_10_15SqIn_250Quantity = 207.00;
            Double Stock2_15_20SqIn_250Quantity = 219.00;
            Double Stock2_20_25SqIn_250Quantity = 240.00;
            Double Stock2_25_30SqIn_250Quantity = 267.00;
            Double Stock2_30_35SqIn_250Quantity = 268.00;
            Double Stock2_35_40SqIn_250Quantity = 282.00;
            //Color, 250 Quantity.
            Double Stock2Color_250Quantity = 75.00;

            //500 Quantity.
            Double Stock2_0_2_5SqIn_500Quantity = 192.00;
            Double Stock2_2_5_5SqIn_500Quantity = 208.00;
            Double Stock2_5_10SqIn_500Quantity = 235.00;
            Double Stock2_10_15SqIn_500Quantity = 269.00;
            Double Stock2_15_20SqIn_500Quantity = 294.00;
            Double Stock2_20_25SqIn_500Quantity = 335.00;
            Double Stock2_25_30SqIn_500Quantity = 337.00;
            Double Stock2_30_35SqIn_500Quantity = 417.00;
            Double Stock2_35_40SqIn_500Quantity = 419.00;
            //Color, 250 Quantity.
            Double Stock2Color_500Quantity = 80.00;

            //1000 Quantity.
            Double Stock2_0_2_5SqIn_1000Quantity = 240.00;
            Double Stock2_2_5_5SqIn_1000Quantity = 264.00;
            Double Stock2_5_10SqIn_1000Quantity = 319.00;
            Double Stock2_10_15SqIn_1000Quantity = 393.00;
            Double Stock2_15_20SqIn_1000Quantity = 444.00;
            Double Stock2_20_25SqIn_1000Quantity = 526.00;
            Double Stock2_25_30SqIn_1000Quantity = 530.00;
            Double Stock2_30_35SqIn_1000Quantity = 690.00;
            Double Stock2_35_40SqIn_1000Quantity = 694.00;
            //Color, 250 Quantity.
            Double Stock2Color_1000Quantity = 85.00;

            //2000 Quantity.
            Double Stock2_0_2_5SqIn_2000Quantity = 324.00;
            Double Stock2_2_5_5SqIn_2000Quantity = 367.00;
            Double Stock2_5_10SqIn_2000Quantity = 493.00;
            Double Stock2_10_15SqIn_2000Quantity = 735.00;
            Double Stock2_15_20SqIn_2000Quantity = 743.00;
            Double Stock2_20_25SqIn_2000Quantity = 921.00;
            Double Stock2_25_30SqIn_2000Quantity = 927.00;
            Double Stock2_30_35SqIn_2000Quantity = 1284.00;
            Double Stock2_35_40SqIn_2000Quantity = 1289.00;
            //Color, 250 Quantity.
            Double Stock2Color_2000Quantity = 100.00;

            //2500 Quantity.
            Double Stock2_0_2_5SqIn_2500Quantity = 363.00;
            Double Stock2_2_5_5SqIn_2500Quantity = 424.00;
            Double Stock2_5_10SqIn_2500Quantity = 578.00;
            Double Stock2_10_15SqIn_2500Quantity = 876.00;
            Double Stock2_15_20SqIn_2500Quantity = 884.00;
            Double Stock2_20_25SqIn_2500Quantity = 1101.00;
            Double Stock2_25_30SqIn_2500Quantity = 1108.00;
            Double Stock2_30_35SqIn_2500Quantity = 1543.00;
            Double Stock2_35_40SqIn_2500Quantity = 1548.00;
            //Color, 250 Quantity.
            Double Stock2Color_2500Quantity = 115.00;

            //5000 Quantity.
            Double Stock2_0_2_5SqIn_5000Quantity = 560.00;
            Double Stock2_2_5_5SqIn_5000Quantity = 707.00;
            Double Stock2_5_10SqIn_5000Quantity = 1003.00;
            Double Stock2_10_15SqIn_5000Quantity = 1580.00;
            Double Stock2_15_20SqIn_5000Quantity = 1589.00;
            Double Stock2_20_25SqIn_5000Quantity = 2003.00;
            Double Stock2_25_30SqIn_5000Quantity = 2010.00;
            Double Stock2_30_35SqIn_5000Quantity = 2836.00;
            Double Stock2_35_40SqIn_5000Quantity = 2840.00;
            //Color, 250 Quantity.
            Double Stock2Color_5000Quantity = 230.00;

            //10000 Quantity.
            Double Stock2_0_2_5SqIn_10000Quantity = 1091.00;
            Double Stock2_2_5_5SqIn_10000Quantity = 1472.00;
            Double Stock2_5_10SqIn_10000Quantity = 2236.00;
            Double Stock2_10_15SqIn_10000Quantity = 2834.00;
            Double Stock2_15_20SqIn_10000Quantity = 2842.00;
            Double Stock2_20_25SqIn_10000Quantity = 3594.00;
            Double Stock2_25_30SqIn_10000Quantity = 3601.00;
            Double Stock2_30_35SqIn_10000Quantity = 5101.00;
            Double Stock2_35_40SqIn_10000Quantity = 5105.00;
            //Color, 250 Quantity.
            Double Stock2Color_10000Quantity = 360.00;

            //======================================================================================================
            //Stock 3 Pricing
            //======================================================================================================

            //50 Quantity.
            Double Stock3_0_2_5SqIn_50Quantity = 137.00;
            Double Stock3_2_5_5SqIn_50Quantity = 138.00;
            Double Stock3_5_10SqIn_50Quantity = 141.00;
            Double Stock3_10_15SqIn_50Quantity = 145.00;
            Double Stock3_15_20SqIn_50Quantity = 148.00;
            Double Stock3_20_25SqIn_50Quantity = 152.00;
            Double Stock3_25_30SqIn_50Quantity = 158.00;
            Double Stock3_30_35SqIn_50Quantity = 159.00;
            Double Stock3_35_40SqIn_50Quantity = 162.00;
            //Color, 50 Quantity.
            Double Stock3Color_50Quantity = 60.00;

            //100 Quantity.
            Double Stock3_0_2_5SqIn_100Quantity = 147.00;
            Double Stock3_2_5_5SqIn_100Quantity = 147.00;
            Double Stock3_5_10SqIn_100Quantity = 153.00;
            Double Stock3_10_15SqIn_100Quantity = 158.00;
            Double Stock3_15_20SqIn_100Quantity = 163.00;
            Double Stock3_20_25SqIn_100Quantity = 171.00;
            Double Stock3_25_30SqIn_100Quantity = 181.00;
            Double Stock3_30_35SqIn_100Quantity = 182.00;
            Double Stock3_35_40SqIn_100Quantity = 188.00;
            //Color, 100 Quantity.
            Double Stock3Color_100Quantity = 65.00;

            //250 Quantity.
            Double Stock3_0_2_5SqIn_250Quantity = 175.00;
            Double Stock3_2_5_5SqIn_250Quantity = 175.00;
            Double Stock3_5_10SqIn_250Quantity = 188.00;
            Double Stock3_10_15SqIn_250Quantity = 200.00;
            Double Stock3_15_20SqIn_250Quantity = 211.00;
            Double Stock3_20_25SqIn_250Quantity = 228.00;
            Double Stock3_25_30SqIn_250Quantity = 252.00;
            Double Stock3_30_35SqIn_250Quantity = 253.00;
            Double Stock3_35_40SqIn_250Quantity = 265.00;
            //Color, 250 Quantity.
            Double Stock3Color_250Quantity = 75.00;

            //500 Quantity.
            Double Stock3_0_2_5SqIn_500Quantity = 189.00;
            Double Stock3_2_5_5SqIn_500Quantity = 200.00;
            Double Stock3_5_10SqIn_500Quantity = 226.00;
            Double Stock3_10_15SqIn_500Quantity = 255.00;
            Double Stock3_15_20SqIn_500Quantity = 277.00;
            Double Stock3_20_25SqIn_500Quantity = 312.00;
            Double Stock3_25_30SqIn_500Quantity = 314.00;
            Double Stock3_30_35SqIn_500Quantity = 383.00;
            Double Stock3_35_40SqIn_500Quantity = 385.00;
            //Color, 250 Quantity.
            Double Stock3Color_500Quantity = 80.00;

            //1000 Quantity.
            Double Stock3_0_2_5SqIn_1000Quantity = 233.00;
            Double Stock3_2_5_5SqIn_1000Quantity = 254.00;
            Double Stock3_5_10SqIn_1000Quantity = 301.00;
            Double Stock3_10_15SqIn_1000Quantity = 365.00;
            Double Stock3_15_20SqIn_1000Quantity = 409.00;
            Double Stock3_20_25SqIn_1000Quantity = 480.00;
            Double Stock3_25_30SqIn_1000Quantity = 484.00;
            Double Stock3_30_35SqIn_1000Quantity = 621.00;
            Double Stock3_35_40SqIn_1000Quantity = 625.00;
            //Color, 250 Quantity.
            Double Stock3Color_1000Quantity = 85.00;

            //2000 Quantity.
            Double Stock3_0_2_5SqIn_2000Quantity = 312.00;
            Double Stock3_2_5_5SqIn_2000Quantity = 350.00;
            Double Stock3_5_10SqIn_2000Quantity = 458.00;
            Double Stock3_10_15SqIn_2000Quantity = 666.00;
            Double Stock3_15_20SqIn_2000Quantity = 674.00;
            Double Stock3_20_25SqIn_2000Quantity = 829.00;
            Double Stock3_25_30SqIn_2000Quantity = 835.00;
            Double Stock3_30_35SqIn_2000Quantity = 1146.00;
            Double Stock3_35_40SqIn_2000Quantity = 1151.00;
            //Color, 250 Quantity.
            Double Stock3Color_2000Quantity = 100.00;

            //2500 Quantity.
            Double Stock3_0_2_5SqIn_2500Quantity = 350.00;
            Double Stock3_2_5_5SqIn_2500Quantity = 403.00;
            Double Stock3_5_10SqIn_2500Quantity = 535.00;
            Double Stock3_10_15SqIn_2500Quantity = 757.00;
            Double Stock3_15_20SqIn_2500Quantity = 801.00;
            Double Stock3_20_25SqIn_2500Quantity = 991.00;
            Double Stock3_25_30SqIn_2500Quantity = 997.00;
            Double Stock3_30_35SqIn_2500Quantity = 1376.00;
            Double Stock3_35_40SqIn_2500Quantity = 1381.00;
            //Color, 250 Quantity.
            Double Stock3Color_2500Quantity = 115.00;

            //5000 Quantity.
            Double Stock3_0_2_5SqIn_5000Quantity = 539.00;
            Double Stock3_2_5_5SqIn_5000Quantity = 666.00;
            Double Stock3_5_10SqIn_5000Quantity = 921.00;
            Double Stock3_10_15SqIn_5000Quantity = 1213.00;
            Double Stock3_15_20SqIn_5000Quantity = 1434.00;
            Double Stock3_20_25SqIn_5000Quantity = 1798.00;
            Double Stock3_25_30SqIn_5000Quantity = 1804.00;
            Double Stock3_30_35SqIn_5000Quantity = 2527.00;
            Double Stock3_35_40SqIn_5000Quantity = 2531.00;
            //Color, 250 Quantity.
            Double Stock3Color_5000Quantity = 230.00;

            //10000 Quantity.
            Double Stock3_0_2_5SqIn_10000Quantity = 1039.00;
            Double Stock3_2_5_5SqIn_10000Quantity = 1363.00;
            Double Stock3_5_10SqIn_10000Quantity = 1639.00;
            Double Stock3_10_15SqIn_10000Quantity = 2169.00;
            Double Stock3_15_20SqIn_10000Quantity = 2569.00;
            Double Stock3_20_25SqIn_10000Quantity = 3230.00;
            Double Stock3_25_30SqIn_10000Quantity = 3236.00;
            Double Stock3_30_35SqIn_10000Quantity = 4554.00;
            Double Stock3_35_40SqIn_10000Quantity = 4559.00;
            //Color, 250 Quantity.
            Double Stock3Color_10000Quantity = 360.00;

            //======================================================================================================
            //Stock 4 Pricing
            //======================================================================================================

            //50 Quantity.
            Double Stock4_0_2_5SqIn_50Quantity = 141.00;
            Double Stock4_2_5_5SqIn_50Quantity = 142.00;
            Double Stock4_5_10SqIn_50Quantity = 148.00;
            Double Stock4_10_15SqIn_50Quantity = 153.00;
            Double Stock4_15_20SqIn_50Quantity = 158.00;
            Double Stock4_20_25SqIn_50Quantity = 166.00;
            Double Stock4_25_30SqIn_50Quantity = 176.00;
            Double Stock4_30_35SqIn_50Quantity = 177.00;
            Double Stock4_35_40SqIn_50Quantity = 183.00;
            //Color, 50 Quantity.
            Double Stock4Color_50Quantity = 60.00;

            //100 Quantity.
            Double Stock4_0_2_5SqIn_100Quantity = 154.00;
            Double Stock4_2_5_5SqIn_100Quantity = 155.00;
            Double Stock4_5_10SqIn_100Quantity = 166.00;
            Double Stock4_10_15SqIn_100Quantity = 175.00;
            Double Stock4_15_20SqIn_100Quantity = 184.00;
            Double Stock4_20_25SqIn_100Quantity = 199.00;
            Double Stock4_25_30SqIn_100Quantity = 218.00;
            Double Stock4_30_35SqIn_100Quantity = 219.00;
            Double Stock4_35_40SqIn_100Quantity = 229.00;
            //Color, 100 Quantity.
            Double Stock4Color_100Quantity = 65.00;

            //250 Quantity.
            Double Stock4_0_2_5SqIn_250Quantity = 193.00;
            Double Stock4_2_5_5SqIn_250Quantity = 194.00;
            Double Stock4_5_10SqIn_250Quantity = 219.00;
            Double Stock4_10_15SqIn_250Quantity = 242.00;
            Double Stock4_15_20SqIn_250Quantity = 263.00;
            Double Stock4_20_25SqIn_250Quantity = 298.00;
            Double Stock4_25_30SqIn_250Quantity = 344.00;
            Double Stock4_30_35SqIn_250Quantity = 346.00;
            Double Stock4_35_40SqIn_250Quantity = 369.00;
            //Color, 250 Quantity.
            Double Stock4Color_250Quantity = 75.00;

            //500 Quantity.
            Double Stock4_0_2_5SqIn_500Quantity = 209.00;
            Double Stock4_2_5_5SqIn_500Quantity = 236.00;
            Double Stock4_5_10SqIn_500Quantity = 282.00;
            Double Stock4_10_15SqIn_500Quantity = 339.00;
            Double Stock4_15_20SqIn_500Quantity = 381.00;
            Double Stock4_20_25SqIn_500Quantity = 452.00;
            Double Stock4_25_30SqIn_500Quantity = 454.00;
            Double Stock4_30_35SqIn_500Quantity = 592.00;
            Double Stock4_35_40SqIn_500Quantity = 594.00;
            //Color, 250 Quantity.
            Double Stock4Color_500Quantity = 80.00;

            //1000 Quantity.
            Double Stock4_0_2_5SqIn_1000Quantity = 273.00;
            Double Stock4_2_5_5SqIn_1000Quantity = 314.00;
            Double Stock4_5_10SqIn_1000Quantity = 406.00;
            Double Stock4_10_15SqIn_1000Quantity = 533.00;
            Double Stock4_15_20SqIn_1000Quantity = 618.00;
            Double Stock4_20_25SqIn_1000Quantity = 759.00;
            Double Stock4_25_30SqIn_1000Quantity = 763.00;
            Double Stock4_30_35SqIn_1000Quantity = 1039.00;
            Double Stock4_35_40SqIn_1000Quantity = 1044.00;
            //Color, 250 Quantity.
            Double Stock4Color_1000Quantity = 85.00;

            //2000 Quantity.
            Double Stock4_0_2_5SqIn_2000Quantity = 382.00;
            Double Stock4_2_5_5SqIn_2000Quantity = 455.00;
            Double Stock4_5_10SqIn_2000Quantity = 667.00;
            Double Stock4_10_15SqIn_2000Quantity = 1084.00;
            Double Stock4_15_20SqIn_2000Quantity = 1092.00;
            Double Stock4_20_25SqIn_2000Quantity = 1387.00;
            Double Stock4_25_30SqIn_2000Quantity = 1393.00;
            Double Stock4_30_35SqIn_2000Quantity = 1983.00;
            Double Stock4_35_40SqIn_2000Quantity = 1987.00;
            //Color, 250 Quantity.
            Double Stock4Color_2000Quantity = 100.00;

            //2500 Quantity.
            Double Stock4_0_2_5SqIn_2500Quantity = 429.00;
            Double Stock4_2_5_5SqIn_2500Quantity = 532.00;
            Double Stock4_5_10SqIn_2500Quantity = 793.00;
            Double Stock4_10_15SqIn_2500Quantity = 1231.00;
            Double Stock4_15_20SqIn_2500Quantity = 1305.00;
            Double Stock4_20_25SqIn_2500Quantity = 1664.00;
            Double Stock4_25_30SqIn_2500Quantity = 1670.00;
            Double Stock4_30_35SqIn_2500Quantity = 2386.00;
            Double Stock4_35_40SqIn_2500Quantity = 2390.00;
            //Color, 250 Quantity.
            Double Stock4Color_2500Quantity = 115.00;

            //5000 Quantity.
            Double Stock4_0_2_5SqIn_5000Quantity = 664.00;
            Double Stock4_2_5_5SqIn_5000Quantity = 916.00;
            Double Stock4_5_10SqIn_5000Quantity = 1421.00;
            Double Stock4_10_15SqIn_5000Quantity = 1963.00;
            Double Stock4_15_20SqIn_5000Quantity = 2372.00;
            Double Stock4_20_25SqIn_5000Quantity = 3048.00;
            Double Stock4_25_30SqIn_5000Quantity = 3054.00;
            Double Stock4_30_35SqIn_5000Quantity = 4403.00;
            Double Stock4_35_40SqIn_5000Quantity = 4407.00;
            //Color, 250 Quantity.
            Double Stock4Color_5000Quantity = 230.00;

            //10000 Quantity.
            Double Stock4_0_2_5SqIn_10000Quantity = 1152.00;
            Double Stock4_2_5_5SqIn_10000Quantity = 1595.00;
            Double Stock4_5_10SqIn_10000Quantity = 3345.00;
            Double Stock4_10_15SqIn_10000Quantity = 3497.00;
            Double Stock4_15_20SqIn_10000Quantity = 4229.00;
            Double Stock4_20_25SqIn_10000Quantity = 5444.00;
            Double Stock4_25_30SqIn_10000Quantity = 5450.00;
            Double Stock4_30_35SqIn_10000Quantity = 7875.00;
            Double Stock4_35_40SqIn_10000Quantity = 7880.00;
            //Color, 250 Quantity.
            Double Stock4Color_10000Quantity = 360.00;

            //======================================================================================================
            //Stock 5 Pricing
            //======================================================================================================

            //50 Quantity.
            Double Stock5_0_2_5SqIn_50Quantity = 137.00;
            Double Stock5_2_5_5SqIn_50Quantity = 137.00;
            Double Stock5_5_10SqIn_50Quantity = 140.00;
            Double Stock5_10_15SqIn_50Quantity = 143.00;
            Double Stock5_15_20SqIn_50Quantity = 145.00;
            Double Stock5_20_25SqIn_50Quantity = 149.00;
            Double Stock5_25_30SqIn_50Quantity = 153.00;
            Double Stock5_30_35SqIn_50Quantity = 154.00;
            Double Stock5_35_40SqIn_50Quantity = 157.00;
            //Color, 50 Quantity.
            Double Stock5Color_50Quantity = 60.00;

            //100 Quantity.
            Double Stock5_0_2_5SqIn_100Quantity = 145.00;
            Double Stock5_2_5_5SqIn_100Quantity = 146.00;
            Double Stock5_5_10SqIn_100Quantity = 151.00;
            Double Stock5_10_15SqIn_100Quantity = 155.00;
            Double Stock5_15_20SqIn_100Quantity = 159.00;
            Double Stock5_20_25SqIn_100Quantity = 165.00;
            Double Stock5_25_30SqIn_100Quantity = 173.00;
            Double Stock5_30_35SqIn_100Quantity = 174.00;
            Double Stock5_35_40SqIn_100Quantity = 178.00;
            //Color, 100 Quantity.
            Double Stock5Color_100Quantity = 65.00;

            //250 Quantity.
            Double Stock5_0_2_5SqIn_250Quantity = 171.00;
            Double Stock5_2_5_5SqIn_250Quantity = 171.00;
            Double Stock5_5_10SqIn_250Quantity = 182.00;
            Double Stock5_10_15SqIn_250Quantity = 191.00;
            Double Stock5_15_20SqIn_250Quantity = 199.00;
            Double Stock5_20_25SqIn_250Quantity = 213.00;
            Double Stock5_25_30SqIn_250Quantity = 231.00;
            Double Stock5_30_35SqIn_250Quantity = 232.00;
            Double Stock5_35_40SqIn_250Quantity = 242.00;
            //Color, 250 Quantity.
            Double Stock5Color_250Quantity = 75.00;

            //500 Quantity.
            Double Stock5_0_2_5SqIn_500Quantity = 184.00;
            Double Stock5_2_5_5SqIn_500Quantity = 194.00;
            Double Stock5_5_10SqIn_500Quantity = 214.00;
            Double Stock5_10_15SqIn_500Quantity = 237.00;
            Double Stock5_15_20SqIn_500Quantity = 254.00;
            Double Stock5_20_25SqIn_500Quantity = 282.00;
            Double Stock5_25_30SqIn_500Quantity = 284.00;
            Double Stock5_30_35SqIn_500Quantity = 337.00;
            Double Stock5_35_40SqIn_500Quantity = 339.00;
            //Color, 250 Quantity.
            Double Stock5Color_500Quantity = 80.00;

            //1000 Quantity.
            Double Stock5_0_2_5SqIn_1000Quantity = 224.00;
            Double Stock5_2_5_5SqIn_1000Quantity = 141.00;
            Double Stock5_5_10SqIn_1000Quantity = 278.00;
            Double Stock5_10_15SqIn_1000Quantity = 329.00;
            Double Stock5_15_20SqIn_1000Quantity = 363.00;
            Double Stock5_20_25SqIn_1000Quantity = 419.00;
            Double Stock5_25_30SqIn_1000Quantity = 423.00;
            Double Stock5_30_35SqIn_1000Quantity = 529.00;
            Double Stock5_35_40SqIn_1000Quantity = 534.00;
            //Color, 250 Quantity.
            Double Stock5Color_1000Quantity = 85.00;

            //2000 Quantity.
            Double Stock5_0_2_5SqIn_2000Quantity = 297.00;
            Double Stock5_2_5_5SqIn_2000Quantity = 327.00;
            Double Stock5_5_10SqIn_2000Quantity = 412.00;
            Double Stock5_10_15SqIn_2000Quantity = 574.00;
            Double Stock5_15_20SqIn_2000Quantity = 582.00;
            Double Stock5_20_25SqIn_2000Quantity = 897.00;
            Double Stock5_25_30SqIn_2000Quantity = 917.00;
            Double Stock5_30_35SqIn_2000Quantity = 963.00;
            Double Stock5_35_40SqIn_2000Quantity = 967.00;
            //Color, 250 Quantity.
            Double Stock5Color_2000Quantity = 100.00;

            //2500 Quantity.
            Double Stock5_0_2_5SqIn_2500Quantity = 333.00;
            Double Stock5_2_5_5SqIn_2500Quantity = 374.00;
            Double Stock5_5_10SqIn_2500Quantity = 479.00;
            Double Stock5_10_15SqIn_2500Quantity = 682.00;
            Double Stock5_15_20SqIn_2500Quantity = 753.00;
            Double Stock5_20_25SqIn_2500Quantity = 1068.00;
            Double Stock5_25_30SqIn_2500Quantity = 1096.00;
            Double Stock5_30_35SqIn_2500Quantity = 1155.00;
            Double Stock5_35_40SqIn_2500Quantity = 1159.00;
            //Color, 250 Quantity.
            Double Stock5Color_2500Quantity = 115.00;

            //5000 Quantity.
            Double Stock5_0_2_5SqIn_5000Quantity = 512.00;
            Double Stock5_2_5_5SqIn_5000Quantity = 611.00;
            Double Stock5_5_10SqIn_5000Quantity = 811.00;
            Double Stock5_10_15SqIn_5000Quantity = 1205.00;
            Double Stock5_15_20SqIn_5000Quantity = 1228.00;
            Double Stock5_20_25SqIn_5000Quantity = 1465.00;
            Double Stock5_25_30SqIn_5000Quantity = 1529.00;
            Double Stock5_30_35SqIn_5000Quantity = 2115.00;
            Double Stock5_35_40SqIn_5000Quantity = 2119.00;
            //Color, 250 Quantity.
            Double Stock5Color_5000Quantity = 230.00;

            //10000 Quantity.
            Double Stock5_0_2_5SqIn_10000Quantity = 963.00;
            Double Stock5_2_5_5SqIn_10000Quantity = 1217.00;
            Double Stock5_5_10SqIn_10000Quantity = 1401.00;
            Double Stock5_10_15SqIn_10000Quantity = 2196.00;
            Double Stock5_15_20SqIn_10000Quantity = 2204.00;
            Double Stock5_20_25SqIn_10000Quantity = 2617.00;
            Double Stock5_25_30SqIn_10000Quantity = 2750.00;
            Double Stock5_30_35SqIn_10000Quantity = 3825.00;
            Double Stock5_35_40SqIn_10000Quantity = 3830.00;
            //Color, 250 Quantity.
            Double Stock5Color_10000Quantity = 360.00;

            //======================================================================================================
            //Stock 6 Pricing
            //======================================================================================================

            //50 Quantity.
            Double Stock6_0_2_5SqIn_50Quantity = 145.00;
            Double Stock6_2_5_5SqIn_50Quantity = 146.00;
            Double Stock6_5_10SqIn_50Quantity = 154.00;
            Double Stock6_10_15SqIn_50Quantity = 162.00;
            Double Stock6_15_20SqIn_50Quantity = 170.00;
            Double Stock6_20_25SqIn_50Quantity = 181.00;
            Double Stock6_25_30SqIn_50Quantity = 197.00;
            Double Stock6_30_35SqIn_50Quantity = 198.00;
            Double Stock6_35_40SqIn_50Quantity = 206.00;
            //Color, 50 Quantity.
            Double Stock6Color_50Quantity = 60.00;

            //100 Quantity.
            Double Stock6_0_2_5SqIn_100Quantity = 162.00;
            Double Stock6_2_5_5SqIn_100Quantity = 163.00;
            Double Stock6_5_10SqIn_100Quantity = 179.00;
            Double Stock6_10_15SqIn_100Quantity = 193.00;
            Double Stock6_15_20SqIn_100Quantity = 207.00;
            Double Stock6_20_25SqIn_100Quantity = 230.00;
            Double Stock6_25_30SqIn_100Quantity = 159.00;
            Double Stock6_30_35SqIn_100Quantity = 260.00;
            Double Stock6_35_40SqIn_100Quantity = 275.00;
            //Color, 100 Quantity.
            Double Stock6Color_100Quantity = 65.00;

            //250 Quantity.
            Double Stock6_0_2_5SqIn_250Quantity = 214.00;
            Double Stock6_2_5_5SqIn_250Quantity = 214.00;
            Double Stock6_5_10SqIn_250Quantity = 253.00;
            Double Stock6_10_15SqIn_250Quantity = 287.00;
            Double Stock6_15_20SqIn_250Quantity = 320.00;
            Double Stock6_20_25SqIn_250Quantity = 375.00;
            Double Stock6_25_30SqIn_250Quantity = 446.00;
            Double Stock6_30_35SqIn_250Quantity = 448.00;
            Double Stock6_35_40SqIn_250Quantity = 484.00;
            //Color, 250 Quantity.
            Double Stock6Color_250Quantity = 75.00;

            //500 Quantity.
            Double Stock6_0_2_5SqIn_500Quantity = 231.00;
            Double Stock6_2_5_5SqIn_500Quantity = 265.00;
            Double Stock6_5_10SqIn_500Quantity = 343.00;
            Double Stock6_10_15SqIn_500Quantity = 430.00;
            Double Stock6_15_20SqIn_500Quantity = 496.00;
            Double Stock6_20_25SqIn_500Quantity = 605.00;
            Double Stock6_25_30SqIn_500Quantity = 607.00;
            Double Stock6_30_35SqIn_500Quantity = 821.00;
            Double Stock6_35_40SqIn_500Quantity = 824.00;
            //Color, 250 Quantity.
            Double Stock6Color_500Quantity = 80.00;

            //1000 Quantity.
            Double Stock6_0_2_5SqIn_1000Quantity = 317.00;
            Double Stock6_2_5_5SqIn_1000Quantity = 380.00;
            Double Stock6_5_10SqIn_1000Quantity = 521.00;
            Double Stock6_10_15SqIn_1000Quantity = 716.00;
            Double Stock6_15_20SqIn_1000Quantity = 848.00;
            Double Stock6_20_25SqIn_1000Quantity = 1065.00;
            Double Stock6_25_30SqIn_1000Quantity = 1069.00;
            Double Stock6_30_35SqIn_1000Quantity = 1498.00;
            Double Stock6_35_40SqIn_1000Quantity = 1503.00;
            //Color, 250 Quantity.
            Double Stock6Color_1000Quantity = 85.00;

            //2000 Quantity.
            Double Stock6_0_2_5SqIn_2000Quantity = 459.00;
            Double Stock6_2_5_5SqIn_2000Quantity = 569.00;
            Double Stock6_5_10SqIn_2000Quantity = 897.00;
            Double Stock6_10_15SqIn_2000Quantity = 1543.00;
            Double Stock6_15_20SqIn_2000Quantity = 1551.00;
            Double Stock6_20_25SqIn_2000Quantity = 1999.00;
            Double Stock6_25_30SqIn_2000Quantity = 2005.00;
            Double Stock6_30_35SqIn_2000Quantity = 2901.00;
            Double Stock6_35_40SqIn_2000Quantity = 2905.00;
            //Color, 250 Quantity.
            Double Stock6Color_2000Quantity = 100.00;

            //2500 Quantity.
            Double Stock6_0_2_5SqIn_2500Quantity = 516.00;
            Double Stock6_2_5_5SqIn_2500Quantity = 673.00;
            Double Stock6_5_10SqIn_2500Quantity = 1076.00;
            Double Stock6_10_15SqIn_2500Quantity = 1750.00;
            Double Stock6_15_20SqIn_2500Quantity = 1880.00;
            Double Stock6_20_25SqIn_2500Quantity = 2403.00;
            Double Stock6_25_30SqIn_2500Quantity = 2409.00;
            Double Stock6_30_35SqIn_2500Quantity = 3494.00;
            Double Stock6_35_40SqIn_2500Quantity = 3499.00;
            //Color, 250 Quantity.
            Double Stock6Color_2500Quantity = 115.00;

            //5000 Quantity.
            Double Stock6_0_2_5SqIn_5000Quantity = 801.00;
            Double Stock6_2_5_5SqIn_5000Quantity = 1191.00;
            Double Stock6_5_10SqIn_5000Quantity = 1970.00;
            Double Stock6_10_15SqIn_5000Quantity = 2787.00;
            Double Stock6_15_20SqIn_5000Quantity = 3527.00;
            Double Stock6_20_25SqIn_5000Quantity = 4421.00;
            Double Stock6_25_30SqIn_5000Quantity = 4427.00;
            Double Stock6_30_35SqIn_5000Quantity = 6461.00;
            Double Stock6_35_40SqIn_5000Quantity = 6466.00;
            //Color, 250 Quantity.
            Double Stock6Color_5000Quantity = 230.00;

            //10000 Quantity.
            Double Stock6_0_2_5SqIn_10000Quantity = 1395.00;
            Double Stock6_2_5_5SqIn_10000Quantity = 2081.00;
            Double Stock6_5_10SqIn_10000Quantity = 4803.00;
            Double Stock6_10_15SqIn_10000Quantity = 4955.00;
            Double Stock6_15_20SqIn_10000Quantity = 6228.00;
            Double Stock6_20_25SqIn_10000Quantity = 7874.00;
            Double Stock6_25_30SqIn_10000Quantity = 7880.00;
            Double Stock6_30_35SqIn_10000Quantity = 11520.00;
            Double Stock6_35_40SqIn_10000Quantity = 11525.00;
            //Color, 250 Quantity.
            Double Stock6Color_10000Quantity = 360.00;

            //======================================================================================================
            //Stock 7 Pricing
            //======================================================================================================

            //50 Quantity.
            Double Stock7_0_2_5SqIn_50Quantity = 139.00;
            Double Stock7_2_5_5SqIn_50Quantity = 140.00;
            Double Stock7_5_10SqIn_50Quantity = 144.00;
            Double Stock7_10_15SqIn_50Quantity = 148.00;
            Double Stock7_15_20SqIn_50Quantity = 152.00;
            Double Stock7_20_25SqIn_50Quantity = 158.00;
            Double Stock7_25_30SqIn_50Quantity = 165.00;
            Double Stock7_30_35SqIn_50Quantity = 166.00;
            Double Stock7_35_40SqIn_50Quantity = 171.00;
            //Color, 50 Quantity.
            Double Stock7Color_50Quantity = 60.00;

            //100 Quantity.
            Double Stock7_0_2_5SqIn_100Quantity = 150.00;
            Double Stock7_2_5_5SqIn_100Quantity = 151.00;
            Double Stock7_5_10SqIn_100Quantity = 158.00;
            Double Stock7_10_15SqIn_100Quantity = 165.00;
            Double Stock7_15_20SqIn_100Quantity = 172.00;
            Double Stock7_20_25SqIn_100Quantity = 183.00;
            Double Stock7_25_30SqIn_100Quantity = 197.00;
            Double Stock7_30_35SqIn_100Quantity = 198.00;
            Double Stock7_35_40SqIn_100Quantity = 205.00;
            //Color, 100 Quantity.
            Double Stock7Color_100Quantity = 65.00;

            //250 Quantity.
            Double Stock7_0_2_5SqIn_250Quantity = 183.00;
            Double Stock7_2_5_5SqIn_250Quantity = 183.00;
            Double Stock7_5_10SqIn_250Quantity = 201.00;
            Double Stock7_10_15SqIn_250Quantity = 217.00;
            Double Stock7_15_20SqIn_250Quantity = 233.00;
            Double Stock7_20_25SqIn_250Quantity = 258.00;
            Double Stock7_25_30SqIn_250Quantity = 291.00;
            Double Stock7_30_35SqIn_250Quantity = 292.00;
            Double Stock7_35_40SqIn_250Quantity = 309.00;
            //Color, 250 Quantity.
            Double Stock7Color_250Quantity = 75.00;

            //500 Quantity.
            Double Stock7_0_2_5SqIn_500Quantity = 197.00;
            Double Stock7_2_5_5SqIn_500Quantity = 214.00;
            Double Stock7_5_10SqIn_500Quantity = 250.00;
            Double Stock7_10_15SqIn_500Quantity = 290.00;
            Double Stock7_15_20SqIn_500Quantity = 321.00;
            Double Stock7_20_25SqIn_500Quantity = 371.00;
            Double Stock7_25_30SqIn_500Quantity = 373.00;
            Double Stock7_30_35SqIn_500Quantity = 471.00;
            Double Stock7_35_40SqIn_500Quantity = 473.00;
            //Color, 250 Quantity.
            Double Stock7Color_500Quantity = 80.00;

            //1000 Quantity.
            Double Stock7_0_2_5SqIn_1000Quantity = 250.00;
            Double Stock7_2_5_5SqIn_1000Quantity = 279.00;
            Double Stock7_5_10SqIn_1000Quantity = 345.00;
            Double Stock7_10_15SqIn_1000Quantity = 436.00;
            Double Stock7_15_20SqIn_1000Quantity = 397.00;
            Double Stock7_20_25SqIn_1000Quantity = 597.00;
            Double Stock7_25_30SqIn_1000Quantity = 793.00;
            Double Stock7_30_35SqIn_1000Quantity = 797.00;
            Double Stock7_35_40SqIn_1000Quantity = 801.00;
            //Color, 250 Quantity.
            Double Stock7Color_1000Quantity = 85.00;

            //2000 Quantity.
            Double Stock7_0_2_5SqIn_2000Quantity = 342.00;
            Double Stock7_2_5_5SqIn_2000Quantity = 394.00;
            Double Stock7_5_10SqIn_2000Quantity = 546.00;
            Double Stock7_10_15SqIn_2000Quantity = 842.00;
            Double Stock7_15_20SqIn_2000Quantity = 850.00;
            Double Stock7_20_25SqIn_2000Quantity = 1063.00;
            Double Stock7_25_30SqIn_2000Quantity = 1070.00;
            Double Stock7_30_35SqIn_2000Quantity = 1841.00;
            Double Stock7_35_40SqIn_2000Quantity = 1848.00;
            //Color, 250 Quantity.
            Double Stock7Color_2000Quantity = 100.00;

            //2500 Quantity.
            Double Stock7_0_2_5SqIn_2500Quantity = 384.00;
            Double Stock7_2_5_5SqIn_2500Quantity = 457.00;
            Double Stock7_5_10SqIn_2500Quantity = 644.00;
            Double Stock7_10_15SqIn_2500Quantity = 956.00;
            Double Stock7_15_20SqIn_2500Quantity = 1136.00;
            Double Stock7_20_25SqIn_2500Quantity = 1273.00;
            Double Stock7_25_30SqIn_2500Quantity = 1280.00;
            Double Stock7_30_35SqIn_2500Quantity = 2087.00;
            Double Stock7_35_40SqIn_2500Quantity = 2095.00;
            //Color, 250 Quantity.
            Double Stock7Color_2500Quantity = 115.00;

            //5000 Quantity.
            Double Stock7_0_2_5SqIn_5000Quantity = 592.00;
            Double Stock7_2_5_5SqIn_5000Quantity = 772.00;
            Double Stock7_5_10SqIn_5000Quantity = 1131.00;
            Double Stock7_10_15SqIn_5000Quantity = 1528.00;
            Double Stock7_15_20SqIn_5000Quantity = 1810.00;
            Double Stock7_20_25SqIn_5000Quantity = 2324.00;
            Double Stock7_25_30SqIn_5000Quantity = 2330.00;
            Double Stock7_30_35SqIn_5000Quantity = 3315.00;
            Double Stock7_35_40SqIn_5000Quantity = 3320.00;
            //Color, 250 Quantity.
            Double Stock7Color_5000Quantity = 230.00;

            //10000 Quantity.
            Double Stock7_0_2_5SqIn_10000Quantity = 902.00;
            Double Stock7_2_5_5SqIn_10000Quantity = 1338.00;
            Double Stock7_5_10SqIn_10000Quantity = 2576.00;
            Double Stock7_10_15SqIn_10000Quantity = 2728.00;
            Double Stock7_15_20SqIn_10000Quantity = 3225.00;
            Double Stock7_20_25SqIn_10000Quantity = 4161.00;
            Double Stock7_25_30SqIn_10000Quantity = 4168.00;
            Double Stock7_30_35SqIn_10000Quantity = 5950.00;
            Double Stock7_35_40SqIn_10000Quantity = 5955.00;
            //Color, 250 Quantity.
            Double Stock7Color_10000Quantity = 360.00;

            //======================================================================================================
            //Stock 8 Pricing
            //======================================================================================================

            //50 Quantity.
            Double Stock8_0_2_5SqIn_50Quantity = 139.00;
            Double Stock8_2_5_5SqIn_50Quantity = 140.00;
            Double Stock8_5_10SqIn_50Quantity = 144.00;
            Double Stock8_10_15SqIn_50Quantity = 148.00;
            Double Stock8_15_20SqIn_50Quantity = 152.00;
            Double Stock8_20_25SqIn_50Quantity = 158.00;
            Double Stock8_25_30SqIn_50Quantity = 165.00;
            Double Stock8_30_35SqIn_50Quantity = 166.00;
            Double Stock8_35_40SqIn_50Quantity = 171.00;
            //Color, 50 Quantity.
            Double Stock8Color_50Quantity = 60.00;

            //100 Quantity.
            Double Stock8_0_2_5SqIn_100Quantity = 150.00;
            Double Stock8_2_5_5SqIn_100Quantity = 151.00;
            Double Stock8_5_10SqIn_100Quantity = 158.00;
            Double Stock8_10_15SqIn_100Quantity = 165.00;
            Double Stock8_15_20SqIn_100Quantity = 172.00;
            Double Stock8_20_25SqIn_100Quantity = 183.00;
            Double Stock8_25_30SqIn_100Quantity = 197.00;
            Double Stock8_30_35SqIn_100Quantity = 198.00;
            Double Stock8_35_40SqIn_100Quantity = 205.00;
            //Color, 100 Quantity.
            Double Stock8Color_100Quantity = 65.00;

            //250 Quantity.
            Double Stock8_0_2_5SqIn_250Quantity = 183.00;
            Double Stock8_2_5_5SqIn_250Quantity = 183.00;
            Double Stock8_5_10SqIn_250Quantity = 201.00;
            Double Stock8_10_15SqIn_250Quantity = 217.00;
            Double Stock8_15_20SqIn_250Quantity = 233.00;
            Double Stock8_20_25SqIn_250Quantity = 258.00;
            Double Stock8_25_30SqIn_250Quantity = 291.00;
            Double Stock8_30_35SqIn_250Quantity = 292.00;
            Double Stock8_35_40SqIn_250Quantity = 309.00;
            //Color, 250 Quantity.
            Double Stock8Color_250Quantity = 75.00;

            //500 Quantity.
            Double Stock8_0_2_5SqIn_500Quantity = 197.00;
            Double Stock8_2_5_5SqIn_500Quantity = 214.00;
            Double Stock8_5_10SqIn_500Quantity = 250.00;
            Double Stock8_10_15SqIn_500Quantity = 290.00;
            Double Stock8_15_20SqIn_500Quantity = 321.00;
            Double Stock8_20_25SqIn_500Quantity = 371.00;
            Double Stock8_25_30SqIn_500Quantity = 373.00;
            Double Stock8_30_35SqIn_500Quantity = 471.00;
            Double Stock8_35_40SqIn_500Quantity = 473.00;
            //Color, 250 Quantity.
            Double Stock8Color_500Quantity = 80.00;

            //1000 Quantity.
            Double Stock8_0_2_5SqIn_1000Quantity = 250.00;
            Double Stock8_2_5_5SqIn_1000Quantity = 279.00;
            Double Stock8_5_10SqIn_1000Quantity = 345.00;
            Double Stock8_10_15SqIn_1000Quantity = 436.00;
            Double Stock8_15_20SqIn_1000Quantity = 397.00;
            Double Stock8_20_25SqIn_1000Quantity = 597.00;
            Double Stock8_25_30SqIn_1000Quantity = 793.00;
            Double Stock8_30_35SqIn_1000Quantity = 797.00;
            Double Stock8_35_40SqIn_1000Quantity = 801.00;
            //Color, 250 Quantity.
            Double Stock8Color_1000Quantity = 85.00;

            //2000 Quantity.
            Double Stock8_0_2_5SqIn_2000Quantity = 342.00;
            Double Stock8_2_5_5SqIn_2000Quantity = 394.00;
            Double Stock8_5_10SqIn_2000Quantity = 546.00;
            Double Stock8_10_15SqIn_2000Quantity = 842.00;
            Double Stock8_15_20SqIn_2000Quantity = 850.00;
            Double Stock8_20_25SqIn_2000Quantity = 1063.00;
            Double Stock8_25_30SqIn_2000Quantity = 1070.00;
            Double Stock8_30_35SqIn_2000Quantity = 1841.00;
            Double Stock8_35_40SqIn_2000Quantity = 1848.00;
            //Color, 250 Quantity.
            Double Stock8Color_2000Quantity = 100.00;

            //2500 Quantity.
            Double Stock8_0_2_5SqIn_2500Quantity = 384.00;
            Double Stock8_2_5_5SqIn_2500Quantity = 457.00;
            Double Stock8_5_10SqIn_2500Quantity = 644.00;
            Double Stock8_10_15SqIn_2500Quantity = 956.00;
            Double Stock8_15_20SqIn_2500Quantity = 1136.00;
            Double Stock8_20_25SqIn_2500Quantity = 1273.00;
            Double Stock8_25_30SqIn_2500Quantity = 1280.00;
            Double Stock8_30_35SqIn_2500Quantity = 2087.00;
            Double Stock8_35_40SqIn_2500Quantity = 2095.00;
            //Color, 250 Quantity.
            Double Stock8Color_2500Quantity = 115.00;

            //5000 Quantity.
            Double Stock8_0_2_5SqIn_5000Quantity = 592.00;
            Double Stock8_2_5_5SqIn_5000Quantity = 772.00;
            Double Stock8_5_10SqIn_5000Quantity = 1131.00;
            Double Stock8_10_15SqIn_5000Quantity = 1528.00;
            Double Stock8_15_20SqIn_5000Quantity = 1810.00;
            Double Stock8_20_25SqIn_5000Quantity = 2324.00;
            Double Stock8_25_30SqIn_5000Quantity = 2330.00;
            Double Stock8_30_35SqIn_5000Quantity = 3315.00;
            Double Stock8_35_40SqIn_5000Quantity = 3320.00;
            //Color, 250 Quantity.
            Double Stock8Color_5000Quantity = 230.00;

            //10000 Quantity.
            Double Stock8_0_2_5SqIn_10000Quantity = 902.00;
            Double Stock8_2_5_5SqIn_10000Quantity = 1338.00;
            Double Stock8_5_10SqIn_10000Quantity = 2576.00;
            Double Stock8_10_15SqIn_10000Quantity = 2728.00;
            Double Stock8_15_20SqIn_10000Quantity = 3225.00;
            Double Stock8_20_25SqIn_10000Quantity = 4161.00;
            Double Stock8_25_30SqIn_10000Quantity = 4168.00;
            Double Stock8_30_35SqIn_10000Quantity = 5950.00;
            Double Stock8_35_40SqIn_10000Quantity = 5955.00;
            //Color, 250 Quantity.
            Double Stock8Color_10000Quantity = 360.00;

            //======================================================================================================
            //Stock 9 Pricing
            //======================================================================================================

            //50 Quantity.
            Double Stock9_0_2_5SqIn_50Quantity = 142.00;
            Double Stock9_2_5_5SqIn_50Quantity = 143.00;
            Double Stock9_5_10SqIn_50Quantity = 150.00;
            Double Stock9_10_15SqIn_50Quantity = 156.00;
            Double Stock9_15_20SqIn_50Quantity = 162.00;
            Double Stock9_20_25SqIn_50Quantity = 171.00;
            Double Stock9_25_30SqIn_50Quantity = 182.00;
            Double Stock9_30_35SqIn_50Quantity = 183.00;
            Double Stock9_35_40SqIn_50Quantity = 190.00;
            //Color, 50 Quantity.
            Double Stock9Color_50Quantity = 60.00;

            //100 Quantity.
            Double Stock9_0_2_5SqIn_100Quantity = 157.00;
            Double Stock9_2_5_5SqIn_100Quantity = 157.00;
            Double Stock9_5_10SqIn_100Quantity = 170.00;
            Double Stock9_10_15SqIn_100Quantity = 181.00;
            Double Stock9_15_20SqIn_100Quantity = 191.00;
            Double Stock9_20_25SqIn_100Quantity = 208.00;
            Double Stock9_25_30SqIn_100Quantity = 230.00;
            Double Stock9_30_35SqIn_100Quantity = 231.00;
            Double Stock9_35_40SqIn_100Quantity = 243.00;
            //Color, 100 Quantity.
            Double Stock9Color_100Quantity = 65.00;

            //250 Quantity.
            Double Stock9_0_2_5SqIn_250Quantity = 200.00;
            Double Stock9_2_5_5SqIn_250Quantity = 200.00;
            Double Stock9_5_10SqIn_250Quantity = 230.00;
            Double Stock9_10_15SqIn_250Quantity = 255.00;
            Double Stock9_15_20SqIn_250Quantity = 280.00;
            Double Stock9_20_25SqIn_250Quantity = 321.00;
            Double Stock9_25_30SqIn_250Quantity = 375.00;
            Double Stock9_30_35SqIn_250Quantity = 376.00;
            Double Stock9_35_40SqIn_250Quantity = 404.00;
            //Color, 250 Quantity.
            Double Stock9Color_250Quantity = 75.00;

            //500 Quantity.
            Double Stock9_0_2_5SqIn_500Quantity = 215.00;
            Double Stock9_2_5_5SqIn_500Quantity = 242.00;
            Double Stock9_5_10SqIn_500Quantity = 300.00;
            Double Stock9_10_15SqIn_500Quantity = 366.00;
            Double Stock9_15_20SqIn_500Quantity = 416.00;
            Double Stock9_20_25SqIn_500Quantity = 498.00;
            Double Stock9_25_30SqIn_500Quantity = 500.00;
            Double Stock9_30_35SqIn_500Quantity = 661.00;
            Double Stock9_35_40SqIn_500Quantity = 663.00;
            //Color, 250 Quantity.
            Double Stock9Color_500Quantity = 80.00;

            //1000 Quantity.
            Double Stock9_0_2_5SqIn_1000Quantity = 286.00;
            Double Stock9_2_5_5SqIn_1000Quantity = 334.00;
            Double Stock9_5_10SqIn_1000Quantity = 440.00;
            Double Stock9_10_15SqIn_1000Quantity = 588.00;
            Double Stock9_15_20SqIn_1000Quantity = 687.00;
            Double Stock9_20_25SqIn_1000Quantity = 850.00;
            Double Stock9_25_30SqIn_1000Quantity = 855.00;
            Double Stock9_30_35SqIn_1000Quantity = 1177.00;
            Double Stock9_35_40SqIn_1000Quantity = 1181.00;
            //Color, 250 Quantity.
            Double Stock9Color_1000Quantity = 85.00;

            //2000 Quantity.
            Double Stock9_0_2_5SqIn_2000Quantity = 405.00;
            Double Stock9_2_5_5SqIn_2000Quantity = 489.00;
            Double Stock9_5_10SqIn_2000Quantity = 736.00;
            Double Stock9_10_15SqIn_2000Quantity = 1222.00;
            Double Stock9_15_20SqIn_2000Quantity = 1230.00;
            Double Stock9_20_25SqIn_2000Quantity = 1570.00;
            Double Stock9_25_30SqIn_2000Quantity = 1576.00;
            Double Stock9_30_35SqIn_2000Quantity = 2258.00;
            Double Stock9_35_40SqIn_2000Quantity = 2263.00;
            //Color, 250 Quantity.
            Double Stock9Color_2000Quantity = 100.00;

            //2500 Quantity.
            Double Stock9_0_2_5SqIn_2500Quantity = 455.00;
            Double Stock9_2_5_5SqIn_2500Quantity = 574.00;
            Double Stock9_5_10SqIn_2500Quantity = 878.00;
            Double Stock9_10_15SqIn_2500Quantity = 1387.00;
            Double Stock9_15_20SqIn_2500Quantity = 1472.00;
            Double Stock9_20_25SqIn_2500Quantity = 1885.00;
            Double Stock9_25_30SqIn_2500Quantity = 1891.00;
            Double Stock9_30_35SqIn_2500Quantity = 2718.00;
            Double Stock9_35_40SqIn_2500Quantity = 2723.00;
            //Color, 250 Quantity.
            Double Stock9Color_2500Quantity = 115.00;

            //5000 Quantity.
            Double Stock9_0_2_5SqIn_5000Quantity = 705.00;
            Double Stock9_2_5_5SqIn_5000Quantity = 999.00;
            Double Stock9_5_10SqIn_5000Quantity = 1586.00;
            Double Stock9_10_15SqIn_5000Quantity = 2210.00;
            Double Stock9_15_20SqIn_5000Quantity = 2681.00;
            Double Stock9_20_25SqIn_5000Quantity = 3460.00;
            Double Stock9_25_30SqIn_5000Quantity = 3466.00;
            Double Stock9_30_35SqIn_5000Quantity = 5020.00;
            Double Stock9_35_40SqIn_5000Quantity = 5025.00;
            //Color, 250 Quantity.
            Double Stock9Color_5000Quantity = 230.00;

            //10000 Quantity.
            Double Stock9_0_2_5SqIn_10000Quantity = 1225.00;
            Double Stock9_2_5_5SqIn_10000Quantity = 1741.00;
            Double Stock9_5_10SqIn_10000Quantity = 3783.00;
            Double Stock9_10_15SqIn_10000Quantity = 3935.00;
            Double Stock9_15_20SqIn_10000Quantity = 4777.00;
            Double Stock9_20_25SqIn_10000Quantity = 6173.00;
            Double Stock9_25_30SqIn_10000Quantity = 6179.00;
            Double Stock9_30_35SqIn_10000Quantity = 8969.00;
            Double Stock9_35_40SqIn_10000Quantity = 8973.00;
            //Color, 250 Quantity.
            Double Stock9Color_10000Quantity = 360.00;

            //======================================================================================================
            //Stock 10 Pricing
            //======================================================================================================

            //50 Quantity.
            Double Stock10_0_2_5SqIn_50Quantity = 142.00;
            Double Stock10_2_5_5SqIn_50Quantity = 143.00;
            Double Stock10_5_10SqIn_50Quantity = 150.00;
            Double Stock10_10_15SqIn_50Quantity = 156.00;
            Double Stock10_15_20SqIn_50Quantity = 162.00;
            Double Stock10_20_25SqIn_50Quantity = 171.00;
            Double Stock10_25_30SqIn_50Quantity = 182.00;
            Double Stock10_30_35SqIn_50Quantity = 183.00;
            Double Stock10_35_40SqIn_50Quantity = 190.00;
            //Color, 50 Quantity.
            Double Stock10Color_50Quantity = 60.00;

            //100 Quantity.
            Double Stock10_0_2_5SqIn_100Quantity = 157.00;
            Double Stock10_2_5_5SqIn_100Quantity = 157.00;
            Double Stock10_5_10SqIn_100Quantity = 170.00;
            Double Stock10_10_15SqIn_100Quantity = 181.00;
            Double Stock10_15_20SqIn_100Quantity = 191.00;
            Double Stock10_20_25SqIn_100Quantity = 208.00;
            Double Stock10_25_30SqIn_100Quantity = 230.00;
            Double Stock10_30_35SqIn_100Quantity = 231.00;
            Double Stock10_35_40SqIn_100Quantity = 243.00;
            //Color, 100 Quantity.
            Double Stock10Color_100Quantity = 65.00;

            //250 Quantity.
            Double Stock10_0_2_5SqIn_250Quantity = 200.00;
            Double Stock10_2_5_5SqIn_250Quantity = 200.00;
            Double Stock10_5_10SqIn_250Quantity = 230.00;
            Double Stock10_10_15SqIn_250Quantity = 255.00;
            Double Stock10_15_20SqIn_250Quantity = 280.00;
            Double Stock10_20_25SqIn_250Quantity = 321.00;
            Double Stock10_25_30SqIn_250Quantity = 375.00;
            Double Stock10_30_35SqIn_250Quantity = 376.00;
            Double Stock10_35_40SqIn_250Quantity = 404.00;
            //Color, 250 Quantity.
            Double Stock10Color_250Quantity = 75.00;

            //500 Quantity.
            Double Stock10_0_2_5SqIn_500Quantity = 215.00;
            Double Stock10_2_5_5SqIn_500Quantity = 242.00;
            Double Stock10_5_10SqIn_500Quantity = 300.00;
            Double Stock10_10_15SqIn_500Quantity = 366.00;
            Double Stock10_15_20SqIn_500Quantity = 416.00;
            Double Stock10_20_25SqIn_500Quantity = 498.00;
            Double Stock10_25_30SqIn_500Quantity = 500.00;
            Double Stock10_30_35SqIn_500Quantity = 661.00;
            Double Stock10_35_40SqIn_500Quantity = 663.00;
            //Color, 250 Quantity.
            Double Stock10Color_500Quantity = 80.00;

            //1000 Quantity.
            Double Stock10_0_2_5SqIn_1000Quantity = 286.00;
            Double Stock10_2_5_5SqIn_1000Quantity = 334.00;
            Double Stock10_5_10SqIn_1000Quantity = 440.00;
            Double Stock10_10_15SqIn_1000Quantity = 588.00;
            Double Stock10_15_20SqIn_1000Quantity = 687.00;
            Double Stock10_20_25SqIn_1000Quantity = 850.00;
            Double Stock10_25_30SqIn_1000Quantity = 855.00;
            Double Stock10_30_35SqIn_1000Quantity = 1177.00;
            Double Stock10_35_40SqIn_1000Quantity = 1181.00;
            //Color, 250 Quantity.
            Double Stock10Color_1000Quantity = 85.00;

            //2000 Quantity.
            Double Stock10_0_2_5SqIn_2000Quantity = 405.00;
            Double Stock10_2_5_5SqIn_2000Quantity = 489.00;
            Double Stock10_5_10SqIn_2000Quantity = 736.00;
            Double Stock10_10_15SqIn_2000Quantity = 1222.00;
            Double Stock10_15_20SqIn_2000Quantity = 1230.00;
            Double Stock10_20_25SqIn_2000Quantity = 1570.00;
            Double Stock10_25_30SqIn_2000Quantity = 1576.00;
            Double Stock10_30_35SqIn_2000Quantity = 2258.00;
            Double Stock10_35_40SqIn_2000Quantity = 2263.00;
            //Color, 250 Quantity.
            Double Stock10Color_2000Quantity = 100.00;

            //2500 Quantity.
            Double Stock10_0_2_5SqIn_2500Quantity = 455.00;
            Double Stock10_2_5_5SqIn_2500Quantity = 574.00;
            Double Stock10_5_10SqIn_2500Quantity = 878.00;
            Double Stock10_10_15SqIn_2500Quantity = 1387.00;
            Double Stock10_15_20SqIn_2500Quantity = 1472.00;
            Double Stock10_20_25SqIn_2500Quantity = 1885.00;
            Double Stock10_25_30SqIn_2500Quantity = 1891.00;
            Double Stock10_30_35SqIn_2500Quantity = 2718.00;
            Double Stock10_35_40SqIn_2500Quantity = 2723.00;
            //Color, 250 Quantity.
            Double Stock10Color_2500Quantity = 115.00;

            //5000 Quantity.
            Double Stock10_0_2_5SqIn_5000Quantity = 705.00;
            Double Stock10_2_5_5SqIn_5000Quantity = 999.00;
            Double Stock10_5_10SqIn_5000Quantity = 1586.00;
            Double Stock10_10_15SqIn_5000Quantity = 2210.00;
            Double Stock10_15_20SqIn_5000Quantity = 2681.00;
            Double Stock10_20_25SqIn_5000Quantity = 3460.00;
            Double Stock10_25_30SqIn_5000Quantity = 3466.00;
            Double Stock10_30_35SqIn_5000Quantity = 5020.00;
            Double Stock10_35_40SqIn_5000Quantity = 5025.00;
            //Color, 250 Quantity.
            Double Stock10Color_5000Quantity = 230.00;

            //10000 Quantity.
            Double Stock10_0_2_5SqIn_10000Quantity = 1225.00;
            Double Stock10_2_5_5SqIn_10000Quantity = 1741.00;
            Double Stock10_5_10SqIn_10000Quantity = 3783.00;
            Double Stock10_10_15SqIn_10000Quantity = 3935.00;
            Double Stock10_15_20SqIn_10000Quantity = 4777.00;
            Double Stock10_20_25SqIn_10000Quantity = 6173.00;
            Double Stock10_25_30SqIn_10000Quantity = 6179.00;
            Double Stock10_30_35SqIn_10000Quantity = 8969.00;
            Double Stock10_35_40SqIn_10000Quantity = 8973.00;
            //Color, 250 Quantity.
            Double Stock10Color_10000Quantity = 360.00;

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






            //======================================================================================================
            //Stock 4
            //======================================================================================================

            //50 Quantity If Statements
            //======================================================================================================

            //Finding out if the stock is and show the price for that stock.
            if (ddlStock.SelectedValue == "4" && ddlLabelQuantities.SelectedValue == "50")
            {
                Double Subtotal = 0;

                //Displaying the Subtotal.
                if (SqIn >= 0 && SqIn <= 2.5)
                {
                    Subtotal = Stock4_0_2_5SqIn_50Quantity;
                }
                else if (SqIn >= 2.5 && SqIn <= 5)
                {
                    Subtotal = Stock4_2_5_5SqIn_50Quantity;
                }
                else if (SqIn >= 5.1 && SqIn <= 10)
                {
                    Subtotal = Stock4_5_10SqIn_50Quantity;
                }
                else if (SqIn >= 10.1 && SqIn <= 15)
                {
                    Subtotal = Stock4_10_15SqIn_50Quantity;
                }
                else if (SqIn >= 15.1 && SqIn <= 20)
                {
                    Subtotal = Stock4_15_20SqIn_50Quantity;
                }
                else if (SqIn >= 20.1 && SqIn <= 25)
                {
                    Subtotal = Stock4_20_25SqIn_50Quantity;
                }
                else if (SqIn >= 25.1 && SqIn <= 30)
                {
                    Subtotal = Stock4_25_30SqIn_50Quantity;
                }
                else if (SqIn >= 30.1 && SqIn <= 35)
                {
                    Subtotal = Stock4_30_35SqIn_50Quantity;
                }
                else if (SqIn >= 35.1 && SqIn <= 40)
                {
                    Subtotal = Stock4_35_40SqIn_50Quantity;
                }
                else if (SqIn > 40.1)
                {
                    lblCustomQuoteMessage.Text = CustomQuoteMessage;
                }
                //Calculating the price for the colors.
                Double ColorPrice = Stock4Color_50Quantity * Convert.ToDouble(NumberOfColors);

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
            if (ddlStock.SelectedValue == "4" && ddlLabelQuantities.SelectedValue == "100")
            {
                Double Subtotal = 0;

                //Displaying the Subtotal.
                if (SqIn >= 0 && SqIn <= 2.5)
                {
                    Subtotal = Stock4_0_2_5SqIn_100Quantity;
                }
                else if (SqIn >= 2.5 && SqIn <= 5)
                {
                    Subtotal = Stock4_2_5_5SqIn_100Quantity;
                }
                else if (SqIn >= 5.1 && SqIn <= 10)
                {
                    Subtotal = Stock4_5_10SqIn_100Quantity;
                }
                else if (SqIn >= 10.1 && SqIn <= 15)
                {
                    Subtotal = Stock4_10_15SqIn_100Quantity;
                }
                else if (SqIn >= 15.1 && SqIn <= 20)
                {
                    Subtotal = Stock4_15_20SqIn_100Quantity;
                }
                else if (SqIn >= 20.1 && SqIn <= 25)
                {
                    Subtotal = Stock4_20_25SqIn_100Quantity;
                }
                else if (SqIn >= 25.1 && SqIn <= 30)
                {
                    Subtotal = Stock4_25_30SqIn_100Quantity;
                }
                else if (SqIn >= 30.1 && SqIn <= 35)
                {
                    Subtotal = Stock4_30_35SqIn_100Quantity;
                }
                else if (SqIn >= 35.1 && SqIn <= 40)
                {
                    Subtotal = Stock4_35_40SqIn_100Quantity;
                }
                else if (SqIn > 40.1)
                {
                    lblCustomQuoteMessage.Text = CustomQuoteMessage;
                }
                //Calculating the price for the colors.
                Double ColorPrice = Stock4Color_100Quantity * Convert.ToDouble(NumberOfColors);

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
            if (ddlStock.SelectedValue == "4" && ddlLabelQuantities.SelectedValue == "250")
            {
                Double Subtotal = 0;

                //Displaying the Subtotal.
                if (SqIn >= 0 && SqIn <= 2.5)
                {
                    Subtotal = Stock4_0_2_5SqIn_250Quantity;
                }
                else if (SqIn >= 2.5 && SqIn <= 5)
                {
                    Subtotal = Stock4_2_5_5SqIn_250Quantity;
                }
                else if (SqIn >= 5.1 && SqIn <= 10)
                {
                    Subtotal = Stock4_5_10SqIn_250Quantity;
                }
                else if (SqIn >= 10.1 && SqIn <= 15)
                {
                    Subtotal = Stock4_10_15SqIn_250Quantity;
                }
                else if (SqIn >= 15.1 && SqIn <= 20)
                {
                    Subtotal = Stock4_15_20SqIn_250Quantity;
                }
                else if (SqIn >= 20.1 && SqIn <= 25)
                {
                    Subtotal = Stock4_20_25SqIn_250Quantity;
                }
                else if (SqIn >= 25.1 && SqIn <= 30)
                {
                    Subtotal = Stock4_25_30SqIn_250Quantity;
                }
                else if (SqIn >= 30.1 && SqIn <= 35)
                {
                    Subtotal = Stock4_30_35SqIn_250Quantity;
                }
                else if (SqIn >= 35.1 && SqIn <= 40)
                {
                    Subtotal = Stock4_35_40SqIn_250Quantity;
                }
                else if (SqIn > 40.1)
                {
                    lblCustomQuoteMessage.Text = CustomQuoteMessage;
                }
                //Calculating the price for the colors.
                Double ColorPrice = Stock4Color_250Quantity * Convert.ToDouble(NumberOfColors);

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
            if (ddlStock.SelectedValue == "4" && ddlLabelQuantities.SelectedValue == "500")
            {
                Double Subtotal = 0;

                //Displaying the Subtotal.
                if (SqIn >= 0 && SqIn <= 2.5)
                {
                    Subtotal = Stock4_0_2_5SqIn_500Quantity;
                }
                else if (SqIn >= 2.5 && SqIn <= 5)
                {
                    Subtotal = Stock4_2_5_5SqIn_500Quantity;
                }
                else if (SqIn >= 5.1 && SqIn <= 10)
                {
                    Subtotal = Stock4_5_10SqIn_500Quantity;
                }
                else if (SqIn >= 10.1 && SqIn <= 15)
                {
                    Subtotal = Stock4_10_15SqIn_500Quantity;
                }
                else if (SqIn >= 15.1 && SqIn <= 20)
                {
                    Subtotal = Stock4_15_20SqIn_500Quantity;
                }
                else if (SqIn >= 20.1 && SqIn <= 25)
                {
                    Subtotal = Stock4_20_25SqIn_500Quantity;
                }
                else if (SqIn >= 25.1 && SqIn <= 30)
                {
                    Subtotal = Stock4_25_30SqIn_500Quantity;
                }
                else if (SqIn >= 30.1 && SqIn <= 35)
                {
                    Subtotal = Stock4_30_35SqIn_500Quantity;
                }
                else if (SqIn >= 35.1 && SqIn <= 40)
                {
                    Subtotal = Stock4_35_40SqIn_500Quantity;
                }
                else if (SqIn > 40.1)
                {
                    lblCustomQuoteMessage.Text = CustomQuoteMessage;
                }
                //Calculating the price for the colors.
                Double ColorPrice = Stock4Color_500Quantity * Convert.ToDouble(NumberOfColors);

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
            if (ddlStock.SelectedValue == "4" && ddlLabelQuantities.SelectedValue == "1000")
            {
                Double Subtotal = 0;

                //Displaying the Subtotal.
                if (SqIn >= 0 && SqIn <= 2.5)
                {
                    Subtotal = Stock4_0_2_5SqIn_1000Quantity;
                }
                else if (SqIn >= 2.5 && SqIn <= 5)
                {
                    Subtotal = Stock4_2_5_5SqIn_1000Quantity;
                }
                else if (SqIn >= 5.1 && SqIn <= 10)
                {
                    Subtotal = Stock4_5_10SqIn_1000Quantity;
                }
                else if (SqIn >= 10.1 && SqIn <= 15)
                {
                    Subtotal = Stock4_10_15SqIn_1000Quantity;
                }
                else if (SqIn >= 15.1 && SqIn <= 20)
                {
                    Subtotal = Stock4_15_20SqIn_1000Quantity;
                }
                else if (SqIn >= 20.1 && SqIn <= 25)
                {
                    Subtotal = Stock4_20_25SqIn_1000Quantity;
                }
                else if (SqIn >= 25.1 && SqIn <= 30)
                {
                    Subtotal = Stock4_25_30SqIn_1000Quantity;
                }
                else if (SqIn >= 30.1 && SqIn <= 35)
                {
                    Subtotal = Stock4_30_35SqIn_1000Quantity;
                }
                else if (SqIn >= 35.1 && SqIn <= 40)
                {
                    Subtotal = Stock4_35_40SqIn_1000Quantity;
                }
                else if (SqIn > 40.1)
                {
                    lblCustomQuoteMessage.Text = CustomQuoteMessage;
                }
                //Calculating the price for the colors.
                Double ColorPrice = Stock4Color_1000Quantity * Convert.ToDouble(NumberOfColors);

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
            if (ddlStock.SelectedValue == "4" && ddlLabelQuantities.SelectedValue == "2000")
            {
                Double Subtotal = 0;

                //Displaying the Subtotal.
                if (SqIn >= 0 && SqIn <= 2.5)
                {
                    Subtotal = Stock4_0_2_5SqIn_2000Quantity;
                }
                else if (SqIn >= 2.5 && SqIn <= 5)
                {
                    Subtotal = Stock4_2_5_5SqIn_2000Quantity;
                }
                else if (SqIn >= 5.1 && SqIn <= 10)
                {
                    Subtotal = Stock4_5_10SqIn_2000Quantity;
                }
                else if (SqIn >= 10.1 && SqIn <= 15)
                {
                    Subtotal = Stock4_10_15SqIn_2000Quantity;
                }
                else if (SqIn >= 15.1 && SqIn <= 20)
                {
                    Subtotal = Stock4_15_20SqIn_2000Quantity;
                }
                else if (SqIn >= 20.1 && SqIn <= 25)
                {
                    Subtotal = Stock4_20_25SqIn_2000Quantity;
                }
                else if (SqIn >= 25.1 && SqIn <= 30)
                {
                    Subtotal = Stock4_25_30SqIn_2000Quantity;
                }
                else if (SqIn >= 30.1 && SqIn <= 35)
                {
                    Subtotal = Stock4_30_35SqIn_2000Quantity;
                }
                else if (SqIn >= 35.1 && SqIn <= 40)
                {
                    Subtotal = Stock4_35_40SqIn_2000Quantity;
                }
                else if (SqIn > 40.1)
                {
                    lblCustomQuoteMessage.Text = CustomQuoteMessage;
                }
                //Calculating the price for the colors.
                Double ColorPrice = Stock4Color_2000Quantity * Convert.ToDouble(NumberOfColors);

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
            if (ddlStock.SelectedValue == "4" && ddlLabelQuantities.SelectedValue == "2500")
            {
                Double Subtotal = 0;

                //Displaying the Subtotal.
                if (SqIn >= 0 && SqIn <= 2.5)
                {
                    Subtotal = Stock4_0_2_5SqIn_2500Quantity;
                }
                else if (SqIn >= 2.5 && SqIn <= 5)
                {
                    Subtotal = Stock4_2_5_5SqIn_2500Quantity;
                }
                else if (SqIn >= 5.1 && SqIn <= 10)
                {
                    Subtotal = Stock4_5_10SqIn_2500Quantity;
                }
                else if (SqIn >= 10.1 && SqIn <= 15)
                {
                    Subtotal = Stock4_10_15SqIn_2500Quantity;
                }
                else if (SqIn >= 15.1 && SqIn <= 20)
                {
                    Subtotal = Stock4_15_20SqIn_2500Quantity;
                }
                else if (SqIn >= 20.1 && SqIn <= 25)
                {
                    Subtotal = Stock4_20_25SqIn_2500Quantity;
                }
                else if (SqIn >= 25.1 && SqIn <= 30)
                {
                    Subtotal = Stock4_25_30SqIn_2500Quantity;
                }
                else if (SqIn >= 30.1 && SqIn <= 35)
                {
                    Subtotal = Stock4_30_35SqIn_2500Quantity;
                }
                else if (SqIn >= 35.1 && SqIn <= 40)
                {
                    Subtotal = Stock4_35_40SqIn_2500Quantity;
                }
                else if (SqIn > 40.1)
                {
                    lblCustomQuoteMessage.Text = CustomQuoteMessage;
                }
                //Calculating the price for the colors.
                Double ColorPrice = Stock4Color_2500Quantity * Convert.ToDouble(NumberOfColors);

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
            if (ddlStock.SelectedValue == "4" && ddlLabelQuantities.SelectedValue == "5000")
            {
                Double Subtotal = 0;

                //Displaying the Subtotal.
                if (SqIn >= 0 && SqIn <= 2.5)
                {
                    Subtotal = Stock4_0_2_5SqIn_5000Quantity;
                }
                else if (SqIn >= 2.5 && SqIn <= 5)
                {
                    Subtotal = Stock4_2_5_5SqIn_5000Quantity;
                }
                else if (SqIn >= 5.1 && SqIn <= 10)
                {
                    Subtotal = Stock4_5_10SqIn_5000Quantity;
                }
                else if (SqIn >= 10.1 && SqIn <= 15)
                {
                    Subtotal = Stock4_10_15SqIn_5000Quantity;
                }
                else if (SqIn >= 15.1 && SqIn <= 20)
                {
                    Subtotal = Stock4_15_20SqIn_5000Quantity;
                }
                else if (SqIn >= 20.1 && SqIn <= 25)
                {
                    Subtotal = Stock4_20_25SqIn_5000Quantity;
                }
                else if (SqIn >= 25.1 && SqIn <= 30)
                {
                    Subtotal = Stock4_25_30SqIn_5000Quantity;
                }
                else if (SqIn >= 30.1 && SqIn <= 35)
                {
                    Subtotal = Stock4_30_35SqIn_5000Quantity;
                }
                else if (SqIn >= 35.1 && SqIn <= 40)
                {
                    Subtotal = Stock4_35_40SqIn_5000Quantity;
                }
                else if (SqIn > 40.1)
                {
                    lblCustomQuoteMessage.Text = CustomQuoteMessage;
                }
                //Calculating the price for the colors.
                Double ColorPrice = Stock4Color_5000Quantity * Convert.ToDouble(NumberOfColors);

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
            if (ddlStock.SelectedValue == "4" && ddlLabelQuantities.SelectedValue == "10000")
            {
                Double Subtotal = 0;

                //Displaying the Subtotal.
                if (SqIn >= 0 && SqIn <= 2.5)
                {
                    Subtotal = Stock4_0_2_5SqIn_10000Quantity;
                }
                else if (SqIn >= 2.5 && SqIn <= 5)
                {
                    Subtotal = Stock4_2_5_5SqIn_10000Quantity;
                }
                else if (SqIn >= 5.1 && SqIn <= 10)
                {
                    Subtotal = Stock4_5_10SqIn_10000Quantity;
                }
                else if (SqIn >= 10.1 && SqIn <= 15)
                {
                    Subtotal = Stock4_10_15SqIn_10000Quantity;
                }
                else if (SqIn >= 15.1 && SqIn <= 20)
                {
                    Subtotal = Stock4_15_20SqIn_10000Quantity;
                }
                else if (SqIn >= 20.1 && SqIn <= 25)
                {
                    Subtotal = Stock4_20_25SqIn_10000Quantity;
                }
                else if (SqIn >= 25.1 && SqIn <= 30)
                {
                    Subtotal = Stock4_25_30SqIn_10000Quantity;
                }
                else if (SqIn >= 30.1 && SqIn <= 35)
                {
                    Subtotal = Stock4_30_35SqIn_10000Quantity;
                }
                else if (SqIn >= 35.1 && SqIn <= 40)
                {
                    Subtotal = Stock4_35_40SqIn_10000Quantity;
                }
                else if (SqIn > 40.1)
                {
                    lblCustomQuoteMessage.Text = CustomQuoteMessage;
                }
                //Calculating the price for the colors.
                Double ColorPrice = Stock4Color_10000Quantity * Convert.ToDouble(NumberOfColors);

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
            //Stock 5
            //======================================================================================================

            //50 Quantity If Statements
            //======================================================================================================

            //Finding out if the stock is and show the price for that stock.
            if (ddlStock.SelectedValue == "5" && ddlLabelQuantities.SelectedValue == "50")
            {
                Double Subtotal = 0;

                //Displaying the Subtotal.
                if (SqIn >= 0 && SqIn <= 2.5)
                {
                    Subtotal = Stock5_0_2_5SqIn_50Quantity;
                }
                else if (SqIn >= 2.5 && SqIn <= 5)
                {
                    Subtotal = Stock5_2_5_5SqIn_50Quantity;
                }
                else if (SqIn >= 5.1 && SqIn <= 10)
                {
                    Subtotal = Stock5_5_10SqIn_50Quantity;
                }
                else if (SqIn >= 10.1 && SqIn <= 15)
                {
                    Subtotal = Stock5_10_15SqIn_50Quantity;
                }
                else if (SqIn >= 15.1 && SqIn <= 20)
                {
                    Subtotal = Stock5_15_20SqIn_50Quantity;
                }
                else if (SqIn >= 20.1 && SqIn <= 25)
                {
                    Subtotal = Stock5_20_25SqIn_50Quantity;
                }
                else if (SqIn >= 25.1 && SqIn <= 30)
                {
                    Subtotal = Stock5_25_30SqIn_50Quantity;
                }
                else if (SqIn >= 30.1 && SqIn <= 35)
                {
                    Subtotal = Stock5_30_35SqIn_50Quantity;
                }
                else if (SqIn >= 35.1 && SqIn <= 40)
                {
                    Subtotal = Stock5_35_40SqIn_50Quantity;
                }
                else if (SqIn > 40.1)
                {
                    lblCustomQuoteMessage.Text = CustomQuoteMessage;
                }
                //Calculating the price for the colors.
                Double ColorPrice = Stock5Color_50Quantity * Convert.ToDouble(NumberOfColors);

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
            if (ddlStock.SelectedValue == "5" && ddlLabelQuantities.SelectedValue == "100")
            {
                Double Subtotal = 0;

                //Displaying the Subtotal.
                if (SqIn >= 0 && SqIn <= 2.5)
                {
                    Subtotal = Stock5_0_2_5SqIn_100Quantity;
                }
                else if (SqIn >= 2.5 && SqIn <= 5)
                {
                    Subtotal = Stock5_2_5_5SqIn_100Quantity;
                }
                else if (SqIn >= 5.1 && SqIn <= 10)
                {
                    Subtotal = Stock5_5_10SqIn_100Quantity;
                }
                else if (SqIn >= 10.1 && SqIn <= 15)
                {
                    Subtotal = Stock5_10_15SqIn_100Quantity;
                }
                else if (SqIn >= 15.1 && SqIn <= 20)
                {
                    Subtotal = Stock5_15_20SqIn_100Quantity;
                }
                else if (SqIn >= 20.1 && SqIn <= 25)
                {
                    Subtotal = Stock5_20_25SqIn_100Quantity;
                }
                else if (SqIn >= 25.1 && SqIn <= 30)
                {
                    Subtotal = Stock5_25_30SqIn_100Quantity;
                }
                else if (SqIn >= 30.1 && SqIn <= 35)
                {
                    Subtotal = Stock5_30_35SqIn_100Quantity;
                }
                else if (SqIn >= 35.1 && SqIn <= 40)
                {
                    Subtotal = Stock5_35_40SqIn_100Quantity;
                }
                else if (SqIn > 40.1)
                {
                    lblCustomQuoteMessage.Text = CustomQuoteMessage;
                }
                //Calculating the price for the colors.
                Double ColorPrice = Stock5Color_100Quantity * Convert.ToDouble(NumberOfColors);

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
            if (ddlStock.SelectedValue == "5" && ddlLabelQuantities.SelectedValue == "250")
            {
                Double Subtotal = 0;

                //Displaying the Subtotal.
                if (SqIn >= 0 && SqIn <= 2.5)
                {
                    Subtotal = Stock5_0_2_5SqIn_250Quantity;
                }
                else if (SqIn >= 2.5 && SqIn <= 5)
                {
                    Subtotal = Stock5_2_5_5SqIn_250Quantity;
                }
                else if (SqIn >= 5.1 && SqIn <= 10)
                {
                    Subtotal = Stock5_5_10SqIn_250Quantity;
                }
                else if (SqIn >= 10.1 && SqIn <= 15)
                {
                    Subtotal = Stock5_10_15SqIn_250Quantity;
                }
                else if (SqIn >= 15.1 && SqIn <= 20)
                {
                    Subtotal = Stock5_15_20SqIn_250Quantity;
                }
                else if (SqIn >= 20.1 && SqIn <= 25)
                {
                    Subtotal = Stock5_20_25SqIn_250Quantity;
                }
                else if (SqIn >= 25.1 && SqIn <= 30)
                {
                    Subtotal = Stock5_25_30SqIn_250Quantity;
                }
                else if (SqIn >= 30.1 && SqIn <= 35)
                {
                    Subtotal = Stock5_30_35SqIn_250Quantity;
                }
                else if (SqIn >= 35.1 && SqIn <= 40)
                {
                    Subtotal = Stock5_35_40SqIn_250Quantity;
                }
                else if (SqIn > 40.1)
                {
                    lblCustomQuoteMessage.Text = CustomQuoteMessage;
                }
                //Calculating the price for the colors.
                Double ColorPrice = Stock5Color_250Quantity * Convert.ToDouble(NumberOfColors);

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
            if (ddlStock.SelectedValue == "5" && ddlLabelQuantities.SelectedValue == "500")
            {
                Double Subtotal = 0;

                //Displaying the Subtotal.
                if (SqIn >= 0 && SqIn <= 2.5)
                {
                    Subtotal = Stock5_0_2_5SqIn_500Quantity;
                }
                else if (SqIn >= 2.5 && SqIn <= 5)
                {
                    Subtotal = Stock5_2_5_5SqIn_500Quantity;
                }
                else if (SqIn >= 5.1 && SqIn <= 10)
                {
                    Subtotal = Stock5_5_10SqIn_500Quantity;
                }
                else if (SqIn >= 10.1 && SqIn <= 15)
                {
                    Subtotal = Stock5_10_15SqIn_500Quantity;
                }
                else if (SqIn >= 15.1 && SqIn <= 20)
                {
                    Subtotal = Stock5_15_20SqIn_500Quantity;
                }
                else if (SqIn >= 20.1 && SqIn <= 25)
                {
                    Subtotal = Stock5_20_25SqIn_500Quantity;
                }
                else if (SqIn >= 25.1 && SqIn <= 30)
                {
                    Subtotal = Stock5_25_30SqIn_500Quantity;
                }
                else if (SqIn >= 30.1 && SqIn <= 35)
                {
                    Subtotal = Stock5_30_35SqIn_500Quantity;
                }
                else if (SqIn >= 35.1 && SqIn <= 40)
                {
                    Subtotal = Stock5_35_40SqIn_500Quantity;
                }
                else if (SqIn > 40.1)
                {
                    lblCustomQuoteMessage.Text = CustomQuoteMessage;
                }
                //Calculating the price for the colors.
                Double ColorPrice = Stock5Color_500Quantity * Convert.ToDouble(NumberOfColors);

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
            if (ddlStock.SelectedValue == "5" && ddlLabelQuantities.SelectedValue == "1000")
            {
                Double Subtotal = 0;

                //Displaying the Subtotal.
                if (SqIn >= 0 && SqIn <= 2.5)
                {
                    Subtotal = Stock5_0_2_5SqIn_1000Quantity;
                }
                else if (SqIn >= 2.5 && SqIn <= 5)
                {
                    Subtotal = Stock5_2_5_5SqIn_1000Quantity;
                }
                else if (SqIn >= 5.1 && SqIn <= 10)
                {
                    Subtotal = Stock5_5_10SqIn_1000Quantity;
                }
                else if (SqIn >= 10.1 && SqIn <= 15)
                {
                    Subtotal = Stock5_10_15SqIn_1000Quantity;
                }
                else if (SqIn >= 15.1 && SqIn <= 20)
                {
                    Subtotal = Stock5_15_20SqIn_1000Quantity;
                }
                else if (SqIn >= 20.1 && SqIn <= 25)
                {
                    Subtotal = Stock5_20_25SqIn_1000Quantity;
                }
                else if (SqIn >= 25.1 && SqIn <= 30)
                {
                    Subtotal = Stock5_25_30SqIn_1000Quantity;
                }
                else if (SqIn >= 30.1 && SqIn <= 35)
                {
                    Subtotal = Stock5_30_35SqIn_1000Quantity;
                }
                else if (SqIn >= 35.1 && SqIn <= 40)
                {
                    Subtotal = Stock5_35_40SqIn_1000Quantity;
                }
                else if (SqIn > 40.1)
                {
                    lblCustomQuoteMessage.Text = CustomQuoteMessage;
                }
                //Calculating the price for the colors.
                Double ColorPrice = Stock5Color_1000Quantity * Convert.ToDouble(NumberOfColors);

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
            if (ddlStock.SelectedValue == "5" && ddlLabelQuantities.SelectedValue == "2000")
            {
                Double Subtotal = 0;

                //Displaying the Subtotal.
                if (SqIn >= 0 && SqIn <= 2.5)
                {
                    Subtotal = Stock5_0_2_5SqIn_2000Quantity;
                }
                else if (SqIn >= 2.5 && SqIn <= 5)
                {
                    Subtotal = Stock5_2_5_5SqIn_2000Quantity;
                }
                else if (SqIn >= 5.1 && SqIn <= 10)
                {
                    Subtotal = Stock5_5_10SqIn_2000Quantity;
                }
                else if (SqIn >= 10.1 && SqIn <= 15)
                {
                    Subtotal = Stock5_10_15SqIn_2000Quantity;
                }
                else if (SqIn >= 15.1 && SqIn <= 20)
                {
                    Subtotal = Stock5_15_20SqIn_2000Quantity;
                }
                else if (SqIn >= 20.1 && SqIn <= 25)
                {
                    Subtotal = Stock5_20_25SqIn_2000Quantity;
                }
                else if (SqIn >= 25.1 && SqIn <= 30)
                {
                    Subtotal = Stock5_25_30SqIn_2000Quantity;
                }
                else if (SqIn >= 30.1 && SqIn <= 35)
                {
                    Subtotal = Stock5_30_35SqIn_2000Quantity;
                }
                else if (SqIn >= 35.1 && SqIn <= 40)
                {
                    Subtotal = Stock5_35_40SqIn_2000Quantity;
                }
                else if (SqIn > 40.1)
                {
                    lblCustomQuoteMessage.Text = CustomQuoteMessage;
                }
                //Calculating the price for the colors.
                Double ColorPrice = Stock5Color_2000Quantity * Convert.ToDouble(NumberOfColors);

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
            if (ddlStock.SelectedValue == "5" && ddlLabelQuantities.SelectedValue == "2500")
            {
                Double Subtotal = 0;

                //Displaying the Subtotal.
                if (SqIn >= 0 && SqIn <= 2.5)
                {
                    Subtotal = Stock5_0_2_5SqIn_2500Quantity;
                }
                else if (SqIn >= 2.5 && SqIn <= 5)
                {
                    Subtotal = Stock5_2_5_5SqIn_2500Quantity;
                }
                else if (SqIn >= 5.1 && SqIn <= 10)
                {
                    Subtotal = Stock5_5_10SqIn_2500Quantity;
                }
                else if (SqIn >= 10.1 && SqIn <= 15)
                {
                    Subtotal = Stock5_10_15SqIn_2500Quantity;
                }
                else if (SqIn >= 15.1 && SqIn <= 20)
                {
                    Subtotal = Stock5_15_20SqIn_2500Quantity;
                }
                else if (SqIn >= 20.1 && SqIn <= 25)
                {
                    Subtotal = Stock5_20_25SqIn_2500Quantity;
                }
                else if (SqIn >= 25.1 && SqIn <= 30)
                {
                    Subtotal = Stock5_25_30SqIn_2500Quantity;
                }
                else if (SqIn >= 30.1 && SqIn <= 35)
                {
                    Subtotal = Stock5_30_35SqIn_2500Quantity;
                }
                else if (SqIn >= 35.1 && SqIn <= 40)
                {
                    Subtotal = Stock5_35_40SqIn_2500Quantity;
                }
                else if (SqIn > 40.1)
                {
                    lblCustomQuoteMessage.Text = CustomQuoteMessage;
                }
                //Calculating the price for the colors.
                Double ColorPrice = Stock5Color_2500Quantity * Convert.ToDouble(NumberOfColors);

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
            if (ddlStock.SelectedValue == "5" && ddlLabelQuantities.SelectedValue == "5000")
            {
                Double Subtotal = 0;

                //Displaying the Subtotal.
                if (SqIn >= 0 && SqIn <= 2.5)
                {
                    Subtotal = Stock5_0_2_5SqIn_5000Quantity;
                }
                else if (SqIn >= 2.5 && SqIn <= 5)
                {
                    Subtotal = Stock5_2_5_5SqIn_5000Quantity;
                }
                else if (SqIn >= 5.1 && SqIn <= 10)
                {
                    Subtotal = Stock5_5_10SqIn_5000Quantity;
                }
                else if (SqIn >= 10.1 && SqIn <= 15)
                {
                    Subtotal = Stock5_10_15SqIn_5000Quantity;
                }
                else if (SqIn >= 15.1 && SqIn <= 20)
                {
                    Subtotal = Stock5_15_20SqIn_5000Quantity;
                }
                else if (SqIn >= 20.1 && SqIn <= 25)
                {
                    Subtotal = Stock5_20_25SqIn_5000Quantity;
                }
                else if (SqIn >= 25.1 && SqIn <= 30)
                {
                    Subtotal = Stock5_25_30SqIn_5000Quantity;
                }
                else if (SqIn >= 30.1 && SqIn <= 35)
                {
                    Subtotal = Stock5_30_35SqIn_5000Quantity;
                }
                else if (SqIn >= 35.1 && SqIn <= 40)
                {
                    Subtotal = Stock5_35_40SqIn_5000Quantity;
                }
                else if (SqIn > 40.1)
                {
                    lblCustomQuoteMessage.Text = CustomQuoteMessage;
                }
                //Calculating the price for the colors.
                Double ColorPrice = Stock5Color_5000Quantity * Convert.ToDouble(NumberOfColors);

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
            if (ddlStock.SelectedValue == "5" && ddlLabelQuantities.SelectedValue == "10000")
            {
                Double Subtotal = 0;

                //Displaying the Subtotal.
                if (SqIn >= 0 && SqIn <= 2.5)
                {
                    Subtotal = Stock5_0_2_5SqIn_10000Quantity;
                }
                else if (SqIn >= 2.5 && SqIn <= 5)
                {
                    Subtotal = Stock5_2_5_5SqIn_10000Quantity;
                }
                else if (SqIn >= 5.1 && SqIn <= 10)
                {
                    Subtotal = Stock5_5_10SqIn_10000Quantity;
                }
                else if (SqIn >= 10.1 && SqIn <= 15)
                {
                    Subtotal = Stock5_10_15SqIn_10000Quantity;
                }
                else if (SqIn >= 15.1 && SqIn <= 20)
                {
                    Subtotal = Stock5_15_20SqIn_10000Quantity;
                }
                else if (SqIn >= 20.1 && SqIn <= 25)
                {
                    Subtotal = Stock5_20_25SqIn_10000Quantity;
                }
                else if (SqIn >= 25.1 && SqIn <= 30)
                {
                    Subtotal = Stock5_25_30SqIn_10000Quantity;
                }
                else if (SqIn >= 30.1 && SqIn <= 35)
                {
                    Subtotal = Stock5_30_35SqIn_10000Quantity;
                }
                else if (SqIn >= 35.1 && SqIn <= 40)
                {
                    Subtotal = Stock5_35_40SqIn_10000Quantity;
                }
                else if (SqIn > 40.1)
                {
                    lblCustomQuoteMessage.Text = CustomQuoteMessage;
                }
                //Calculating the price for the colors.
                Double ColorPrice = Stock5Color_10000Quantity * Convert.ToDouble(NumberOfColors);

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
            //Stock 6
            //======================================================================================================

            //50 Quantity If Statements
            //======================================================================================================

            //Finding out if the stock is and show the price for that stock.
            if (ddlStock.SelectedValue == "6" && ddlLabelQuantities.SelectedValue == "50")
            {
                Double Subtotal = 0;

                //Displaying the Subtotal.
                if (SqIn >= 0 && SqIn <= 2.5)
                {
                    Subtotal = Stock6_0_2_5SqIn_50Quantity;
                }
                else if (SqIn >= 2.5 && SqIn <= 5)
                {
                    Subtotal = Stock6_2_5_5SqIn_50Quantity;
                }
                else if (SqIn >= 5.1 && SqIn <= 10)
                {
                    Subtotal = Stock6_5_10SqIn_50Quantity;
                }
                else if (SqIn >= 10.1 && SqIn <= 15)
                {
                    Subtotal = Stock6_10_15SqIn_50Quantity;
                }
                else if (SqIn >= 15.1 && SqIn <= 20)
                {
                    Subtotal = Stock6_15_20SqIn_50Quantity;
                }
                else if (SqIn >= 20.1 && SqIn <= 25)
                {
                    Subtotal = Stock6_20_25SqIn_50Quantity;
                }
                else if (SqIn >= 25.1 && SqIn <= 30)
                {
                    Subtotal = Stock6_25_30SqIn_50Quantity;
                }
                else if (SqIn >= 30.1 && SqIn <= 35)
                {
                    Subtotal = Stock6_30_35SqIn_50Quantity;
                }
                else if (SqIn >= 35.1 && SqIn <= 40)
                {
                    Subtotal = Stock6_35_40SqIn_50Quantity;
                }
                else if (SqIn > 40.1)
                {
                    lblCustomQuoteMessage.Text = CustomQuoteMessage;
                }
                //Calculating the price for the colors.
                Double ColorPrice = Stock6Color_50Quantity * Convert.ToDouble(NumberOfColors);

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
            if (ddlStock.SelectedValue == "6" && ddlLabelQuantities.SelectedValue == "100")
            {
                Double Subtotal = 0;

                //Displaying the Subtotal.
                if (SqIn >= 0 && SqIn <= 2.5)
                {
                    Subtotal = Stock6_0_2_5SqIn_100Quantity;
                }
                else if (SqIn >= 2.5 && SqIn <= 5)
                {
                    Subtotal = Stock6_2_5_5SqIn_100Quantity;
                }
                else if (SqIn >= 5.1 && SqIn <= 10)
                {
                    Subtotal = Stock6_5_10SqIn_100Quantity;
                }
                else if (SqIn >= 10.1 && SqIn <= 15)
                {
                    Subtotal = Stock6_10_15SqIn_100Quantity;
                }
                else if (SqIn >= 15.1 && SqIn <= 20)
                {
                    Subtotal = Stock6_15_20SqIn_100Quantity;
                }
                else if (SqIn >= 20.1 && SqIn <= 25)
                {
                    Subtotal = Stock6_20_25SqIn_100Quantity;
                }
                else if (SqIn >= 25.1 && SqIn <= 30)
                {
                    Subtotal = Stock6_25_30SqIn_100Quantity;
                }
                else if (SqIn >= 30.1 && SqIn <= 35)
                {
                    Subtotal = Stock6_30_35SqIn_100Quantity;
                }
                else if (SqIn >= 35.1 && SqIn <= 40)
                {
                    Subtotal = Stock6_35_40SqIn_100Quantity;
                }
                else if (SqIn > 40.1)
                {
                    lblCustomQuoteMessage.Text = CustomQuoteMessage;
                }
                //Calculating the price for the colors.
                Double ColorPrice = Stock6Color_100Quantity * Convert.ToDouble(NumberOfColors);

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
            if (ddlStock.SelectedValue == "6" && ddlLabelQuantities.SelectedValue == "250")
            {
                Double Subtotal = 0;

                //Displaying the Subtotal.
                if (SqIn >= 0 && SqIn <= 2.5)
                {
                    Subtotal = Stock6_0_2_5SqIn_250Quantity;
                }
                else if (SqIn >= 2.5 && SqIn <= 5)
                {
                    Subtotal = Stock6_2_5_5SqIn_250Quantity;
                }
                else if (SqIn >= 5.1 && SqIn <= 10)
                {
                    Subtotal = Stock6_5_10SqIn_250Quantity;
                }
                else if (SqIn >= 10.1 && SqIn <= 15)
                {
                    Subtotal = Stock6_10_15SqIn_250Quantity;
                }
                else if (SqIn >= 15.1 && SqIn <= 20)
                {
                    Subtotal = Stock6_15_20SqIn_250Quantity;
                }
                else if (SqIn >= 20.1 && SqIn <= 25)
                {
                    Subtotal = Stock6_20_25SqIn_250Quantity;
                }
                else if (SqIn >= 25.1 && SqIn <= 30)
                {
                    Subtotal = Stock6_25_30SqIn_250Quantity;
                }
                else if (SqIn >= 30.1 && SqIn <= 35)
                {
                    Subtotal = Stock6_30_35SqIn_250Quantity;
                }
                else if (SqIn >= 35.1 && SqIn <= 40)
                {
                    Subtotal = Stock6_35_40SqIn_250Quantity;
                }
                else if (SqIn > 40.1)
                {
                    lblCustomQuoteMessage.Text = CustomQuoteMessage;
                }
                //Calculating the price for the colors.
                Double ColorPrice = Stock6Color_250Quantity * Convert.ToDouble(NumberOfColors);

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
            if (ddlStock.SelectedValue == "6" && ddlLabelQuantities.SelectedValue == "500")
            {
                Double Subtotal = 0;

                //Displaying the Subtotal.
                if (SqIn >= 0 && SqIn <= 2.5)
                {
                    Subtotal = Stock6_0_2_5SqIn_500Quantity;
                }
                else if (SqIn >= 2.5 && SqIn <= 5)
                {
                    Subtotal = Stock6_2_5_5SqIn_500Quantity;
                }
                else if (SqIn >= 5.1 && SqIn <= 10)
                {
                    Subtotal = Stock6_5_10SqIn_500Quantity;
                }
                else if (SqIn >= 10.1 && SqIn <= 15)
                {
                    Subtotal = Stock6_10_15SqIn_500Quantity;
                }
                else if (SqIn >= 15.1 && SqIn <= 20)
                {
                    Subtotal = Stock6_15_20SqIn_500Quantity;
                }
                else if (SqIn >= 20.1 && SqIn <= 25)
                {
                    Subtotal = Stock6_20_25SqIn_500Quantity;
                }
                else if (SqIn >= 25.1 && SqIn <= 30)
                {
                    Subtotal = Stock6_25_30SqIn_500Quantity;
                }
                else if (SqIn >= 30.1 && SqIn <= 35)
                {
                    Subtotal = Stock6_30_35SqIn_500Quantity;
                }
                else if (SqIn >= 35.1 && SqIn <= 40)
                {
                    Subtotal = Stock6_35_40SqIn_500Quantity;
                }
                else if (SqIn > 40.1)
                {
                    lblCustomQuoteMessage.Text = CustomQuoteMessage;
                }
                //Calculating the price for the colors.
                Double ColorPrice = Stock6Color_500Quantity * Convert.ToDouble(NumberOfColors);

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
            if (ddlStock.SelectedValue == "6" && ddlLabelQuantities.SelectedValue == "1000")
            {
                Double Subtotal = 0;

                //Displaying the Subtotal.
                if (SqIn >= 0 && SqIn <= 2.5)
                {
                    Subtotal = Stock6_0_2_5SqIn_1000Quantity;
                }
                else if (SqIn >= 2.5 && SqIn <= 5)
                {
                    Subtotal = Stock6_2_5_5SqIn_1000Quantity;
                }
                else if (SqIn >= 5.1 && SqIn <= 10)
                {
                    Subtotal = Stock6_5_10SqIn_1000Quantity;
                }
                else if (SqIn >= 10.1 && SqIn <= 15)
                {
                    Subtotal = Stock6_10_15SqIn_1000Quantity;
                }
                else if (SqIn >= 15.1 && SqIn <= 20)
                {
                    Subtotal = Stock6_15_20SqIn_1000Quantity;
                }
                else if (SqIn >= 20.1 && SqIn <= 25)
                {
                    Subtotal = Stock6_20_25SqIn_1000Quantity;
                }
                else if (SqIn >= 25.1 && SqIn <= 30)
                {
                    Subtotal = Stock6_25_30SqIn_1000Quantity;
                }
                else if (SqIn >= 30.1 && SqIn <= 35)
                {
                    Subtotal = Stock6_30_35SqIn_1000Quantity;
                }
                else if (SqIn >= 35.1 && SqIn <= 40)
                {
                    Subtotal = Stock6_35_40SqIn_1000Quantity;
                }
                else if (SqIn > 40.1)
                {
                    lblCustomQuoteMessage.Text = CustomQuoteMessage;
                }
                //Calculating the price for the colors.
                Double ColorPrice = Stock6Color_1000Quantity * Convert.ToDouble(NumberOfColors);

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
            if (ddlStock.SelectedValue == "6" && ddlLabelQuantities.SelectedValue == "2000")
            {
                Double Subtotal = 0;

                //Displaying the Subtotal.
                if (SqIn >= 0 && SqIn <= 2.5)
                {
                    Subtotal = Stock6_0_2_5SqIn_2000Quantity;
                }
                else if (SqIn >= 2.5 && SqIn <= 5)
                {
                    Subtotal = Stock6_2_5_5SqIn_2000Quantity;
                }
                else if (SqIn >= 5.1 && SqIn <= 10)
                {
                    Subtotal = Stock6_5_10SqIn_2000Quantity;
                }
                else if (SqIn >= 10.1 && SqIn <= 15)
                {
                    Subtotal = Stock6_10_15SqIn_2000Quantity;
                }
                else if (SqIn >= 15.1 && SqIn <= 20)
                {
                    Subtotal = Stock6_15_20SqIn_2000Quantity;
                }
                else if (SqIn >= 20.1 && SqIn <= 25)
                {
                    Subtotal = Stock6_20_25SqIn_2000Quantity;
                }
                else if (SqIn >= 25.1 && SqIn <= 30)
                {
                    Subtotal = Stock6_25_30SqIn_2000Quantity;
                }
                else if (SqIn >= 30.1 && SqIn <= 35)
                {
                    Subtotal = Stock6_30_35SqIn_2000Quantity;
                }
                else if (SqIn >= 35.1 && SqIn <= 40)
                {
                    Subtotal = Stock6_35_40SqIn_2000Quantity;
                }
                else if (SqIn > 40.1)
                {
                    lblCustomQuoteMessage.Text = CustomQuoteMessage;
                }
                //Calculating the price for the colors.
                Double ColorPrice = Stock6Color_2000Quantity * Convert.ToDouble(NumberOfColors);

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
            if (ddlStock.SelectedValue == "6" && ddlLabelQuantities.SelectedValue == "2500")
            {
                Double Subtotal = 0;

                //Displaying the Subtotal.
                if (SqIn >= 0 && SqIn <= 2.5)
                {
                    Subtotal = Stock6_0_2_5SqIn_2500Quantity;
                }
                else if (SqIn >= 2.5 && SqIn <= 5)
                {
                    Subtotal = Stock6_2_5_5SqIn_2500Quantity;
                }
                else if (SqIn >= 5.1 && SqIn <= 10)
                {
                    Subtotal = Stock6_5_10SqIn_2500Quantity;
                }
                else if (SqIn >= 10.1 && SqIn <= 15)
                {
                    Subtotal = Stock6_10_15SqIn_2500Quantity;
                }
                else if (SqIn >= 15.1 && SqIn <= 20)
                {
                    Subtotal = Stock6_15_20SqIn_2500Quantity;
                }
                else if (SqIn >= 20.1 && SqIn <= 25)
                {
                    Subtotal = Stock6_20_25SqIn_2500Quantity;
                }
                else if (SqIn >= 25.1 && SqIn <= 30)
                {
                    Subtotal = Stock6_25_30SqIn_2500Quantity;
                }
                else if (SqIn >= 30.1 && SqIn <= 35)
                {
                    Subtotal = Stock6_30_35SqIn_2500Quantity;
                }
                else if (SqIn >= 35.1 && SqIn <= 40)
                {
                    Subtotal = Stock6_35_40SqIn_2500Quantity;
                }
                else if (SqIn > 40.1)
                {
                    lblCustomQuoteMessage.Text = CustomQuoteMessage;
                }
                //Calculating the price for the colors.
                Double ColorPrice = Stock6Color_2500Quantity * Convert.ToDouble(NumberOfColors);

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
            if (ddlStock.SelectedValue == "6" && ddlLabelQuantities.SelectedValue == "5000")
            {
                Double Subtotal = 0;

                //Displaying the Subtotal.
                if (SqIn >= 0 && SqIn <= 2.5)
                {
                    Subtotal = Stock6_0_2_5SqIn_5000Quantity;
                }
                else if (SqIn >= 2.5 && SqIn <= 5)
                {
                    Subtotal = Stock6_2_5_5SqIn_5000Quantity;
                }
                else if (SqIn >= 5.1 && SqIn <= 10)
                {
                    Subtotal = Stock6_5_10SqIn_5000Quantity;
                }
                else if (SqIn >= 10.1 && SqIn <= 15)
                {
                    Subtotal = Stock6_10_15SqIn_5000Quantity;
                }
                else if (SqIn >= 15.1 && SqIn <= 20)
                {
                    Subtotal = Stock6_15_20SqIn_5000Quantity;
                }
                else if (SqIn >= 20.1 && SqIn <= 25)
                {
                    Subtotal = Stock6_20_25SqIn_5000Quantity;
                }
                else if (SqIn >= 25.1 && SqIn <= 30)
                {
                    Subtotal = Stock6_25_30SqIn_5000Quantity;
                }
                else if (SqIn >= 30.1 && SqIn <= 35)
                {
                    Subtotal = Stock6_30_35SqIn_5000Quantity;
                }
                else if (SqIn >= 35.1 && SqIn <= 40)
                {
                    Subtotal = Stock6_35_40SqIn_5000Quantity;
                }
                else if (SqIn > 40.1)
                {
                    lblCustomQuoteMessage.Text = CustomQuoteMessage;
                }
                //Calculating the price for the colors.
                Double ColorPrice = Stock6Color_5000Quantity * Convert.ToDouble(NumberOfColors);

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
            if (ddlStock.SelectedValue == "6" && ddlLabelQuantities.SelectedValue == "10000")
            {
                Double Subtotal = 0;

                //Displaying the Subtotal.
                if (SqIn >= 0 && SqIn <= 2.5)
                {
                    Subtotal = Stock6_0_2_5SqIn_10000Quantity;
                }
                else if (SqIn >= 2.5 && SqIn <= 5)
                {
                    Subtotal = Stock6_2_5_5SqIn_10000Quantity;
                }
                else if (SqIn >= 5.1 && SqIn <= 10)
                {
                    Subtotal = Stock6_5_10SqIn_10000Quantity;
                }
                else if (SqIn >= 10.1 && SqIn <= 15)
                {
                    Subtotal = Stock6_10_15SqIn_10000Quantity;
                }
                else if (SqIn >= 15.1 && SqIn <= 20)
                {
                    Subtotal = Stock6_15_20SqIn_10000Quantity;
                }
                else if (SqIn >= 20.1 && SqIn <= 25)
                {
                    Subtotal = Stock6_20_25SqIn_10000Quantity;
                }
                else if (SqIn >= 25.1 && SqIn <= 30)
                {
                    Subtotal = Stock6_25_30SqIn_10000Quantity;
                }
                else if (SqIn >= 30.1 && SqIn <= 35)
                {
                    Subtotal = Stock6_30_35SqIn_10000Quantity;
                }
                else if (SqIn >= 35.1 && SqIn <= 40)
                {
                    Subtotal = Stock6_35_40SqIn_10000Quantity;
                }
                else if (SqIn > 40.1)
                {
                    lblCustomQuoteMessage.Text = CustomQuoteMessage;
                }
                //Calculating the price for the colors.
                Double ColorPrice = Stock6Color_10000Quantity * Convert.ToDouble(NumberOfColors);

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
            //Stock 7
            //======================================================================================================

            //50 Quantity If Statements
            //======================================================================================================

            //Finding out if the stock is and show the price for that stock.
            if (ddlStock.SelectedValue == "7" && ddlLabelQuantities.SelectedValue == "50")
            {
                Double Subtotal = 0;

                //Displaying the Subtotal.
                if (SqIn >= 0 && SqIn <= 2.5)
                {
                    Subtotal = Stock7_0_2_5SqIn_50Quantity;
                }
                else if (SqIn >= 2.5 && SqIn <= 5)
                {
                    Subtotal = Stock7_2_5_5SqIn_50Quantity;
                }
                else if (SqIn >= 5.1 && SqIn <= 10)
                {
                    Subtotal = Stock7_5_10SqIn_50Quantity;
                }
                else if (SqIn >= 10.1 && SqIn <= 15)
                {
                    Subtotal = Stock7_10_15SqIn_50Quantity;
                }
                else if (SqIn >= 15.1 && SqIn <= 20)
                {
                    Subtotal = Stock7_15_20SqIn_50Quantity;
                }
                else if (SqIn >= 20.1 && SqIn <= 25)
                {
                    Subtotal = Stock7_20_25SqIn_50Quantity;
                }
                else if (SqIn >= 25.1 && SqIn <= 30)
                {
                    Subtotal = Stock7_25_30SqIn_50Quantity;
                }
                else if (SqIn >= 30.1 && SqIn <= 35)
                {
                    Subtotal = Stock7_30_35SqIn_50Quantity;
                }
                else if (SqIn >= 35.1 && SqIn <= 40)
                {
                    Subtotal = Stock7_35_40SqIn_50Quantity;
                }
                else if (SqIn > 40.1)
                {
                    lblCustomQuoteMessage.Text = CustomQuoteMessage;
                }
                //Calculating the price for the colors.
                Double ColorPrice = Stock7Color_50Quantity * Convert.ToDouble(NumberOfColors);

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
            if (ddlStock.SelectedValue == "7" && ddlLabelQuantities.SelectedValue == "100")
            {
                Double Subtotal = 0;

                //Displaying the Subtotal.
                if (SqIn >= 0 && SqIn <= 2.5)
                {
                    Subtotal = Stock7_0_2_5SqIn_100Quantity;
                }
                else if (SqIn >= 2.5 && SqIn <= 5)
                {
                    Subtotal = Stock7_2_5_5SqIn_100Quantity;
                }
                else if (SqIn >= 5.1 && SqIn <= 10)
                {
                    Subtotal = Stock7_5_10SqIn_100Quantity;
                }
                else if (SqIn >= 10.1 && SqIn <= 15)
                {
                    Subtotal = Stock7_10_15SqIn_100Quantity;
                }
                else if (SqIn >= 15.1 && SqIn <= 20)
                {
                    Subtotal = Stock7_15_20SqIn_100Quantity;
                }
                else if (SqIn >= 20.1 && SqIn <= 25)
                {
                    Subtotal = Stock7_20_25SqIn_100Quantity;
                }
                else if (SqIn >= 25.1 && SqIn <= 30)
                {
                    Subtotal = Stock7_25_30SqIn_100Quantity;
                }
                else if (SqIn >= 30.1 && SqIn <= 35)
                {
                    Subtotal = Stock7_30_35SqIn_100Quantity;
                }
                else if (SqIn >= 35.1 && SqIn <= 40)
                {
                    Subtotal = Stock7_35_40SqIn_100Quantity;
                }
                else if (SqIn > 40.1)
                {
                    lblCustomQuoteMessage.Text = CustomQuoteMessage;
                }
                //Calculating the price for the colors.
                Double ColorPrice = Stock7Color_100Quantity * Convert.ToDouble(NumberOfColors);

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
            if (ddlStock.SelectedValue == "7" && ddlLabelQuantities.SelectedValue == "250")
            {
                Double Subtotal = 0;

                //Displaying the Subtotal.
                if (SqIn >= 0 && SqIn <= 2.5)
                {
                    Subtotal = Stock7_0_2_5SqIn_250Quantity;
                }
                else if (SqIn >= 2.5 && SqIn <= 5)
                {
                    Subtotal = Stock7_2_5_5SqIn_250Quantity;
                }
                else if (SqIn >= 5.1 && SqIn <= 10)
                {
                    Subtotal = Stock7_5_10SqIn_250Quantity;
                }
                else if (SqIn >= 10.1 && SqIn <= 15)
                {
                    Subtotal = Stock7_10_15SqIn_250Quantity;
                }
                else if (SqIn >= 15.1 && SqIn <= 20)
                {
                    Subtotal = Stock7_15_20SqIn_250Quantity;
                }
                else if (SqIn >= 20.1 && SqIn <= 25)
                {
                    Subtotal = Stock7_20_25SqIn_250Quantity;
                }
                else if (SqIn >= 25.1 && SqIn <= 30)
                {
                    Subtotal = Stock7_25_30SqIn_250Quantity;
                }
                else if (SqIn >= 30.1 && SqIn <= 35)
                {
                    Subtotal = Stock7_30_35SqIn_250Quantity;
                }
                else if (SqIn >= 35.1 && SqIn <= 40)
                {
                    Subtotal = Stock7_35_40SqIn_250Quantity;
                }
                else if (SqIn > 40.1)
                {
                    lblCustomQuoteMessage.Text = CustomQuoteMessage;
                }
                //Calculating the price for the colors.
                Double ColorPrice = Stock7Color_250Quantity * Convert.ToDouble(NumberOfColors);

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
            if (ddlStock.SelectedValue == "7" && ddlLabelQuantities.SelectedValue == "500")
            {
                Double Subtotal = 0;

                //Displaying the Subtotal.
                if (SqIn >= 0 && SqIn <= 2.5)
                {
                    Subtotal = Stock7_0_2_5SqIn_500Quantity;
                }
                else if (SqIn >= 2.5 && SqIn <= 5)
                {
                    Subtotal = Stock7_2_5_5SqIn_500Quantity;
                }
                else if (SqIn >= 5.1 && SqIn <= 10)
                {
                    Subtotal = Stock7_5_10SqIn_500Quantity;
                }
                else if (SqIn >= 10.1 && SqIn <= 15)
                {
                    Subtotal = Stock7_10_15SqIn_500Quantity;
                }
                else if (SqIn >= 15.1 && SqIn <= 20)
                {
                    Subtotal = Stock7_15_20SqIn_500Quantity;
                }
                else if (SqIn >= 20.1 && SqIn <= 25)
                {
                    Subtotal = Stock7_20_25SqIn_500Quantity;
                }
                else if (SqIn >= 25.1 && SqIn <= 30)
                {
                    Subtotal = Stock7_25_30SqIn_500Quantity;
                }
                else if (SqIn >= 30.1 && SqIn <= 35)
                {
                    Subtotal = Stock7_30_35SqIn_500Quantity;
                }
                else if (SqIn >= 35.1 && SqIn <= 40)
                {
                    Subtotal = Stock7_35_40SqIn_500Quantity;
                }
                else if (SqIn > 40.1)
                {
                    lblCustomQuoteMessage.Text = CustomQuoteMessage;
                }
                //Calculating the price for the colors.
                Double ColorPrice = Stock7Color_500Quantity * Convert.ToDouble(NumberOfColors);

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
            if (ddlStock.SelectedValue == "7" && ddlLabelQuantities.SelectedValue == "1000")
            {
                Double Subtotal = 0;

                //Displaying the Subtotal.
                if (SqIn >= 0 && SqIn <= 2.5)
                {
                    Subtotal = Stock7_0_2_5SqIn_1000Quantity;
                }
                else if (SqIn >= 2.5 && SqIn <= 5)
                {
                    Subtotal = Stock7_2_5_5SqIn_1000Quantity;
                }
                else if (SqIn >= 5.1 && SqIn <= 10)
                {
                    Subtotal = Stock7_5_10SqIn_1000Quantity;
                }
                else if (SqIn >= 10.1 && SqIn <= 15)
                {
                    Subtotal = Stock7_10_15SqIn_1000Quantity;
                }
                else if (SqIn >= 15.1 && SqIn <= 20)
                {
                    Subtotal = Stock7_15_20SqIn_1000Quantity;
                }
                else if (SqIn >= 20.1 && SqIn <= 25)
                {
                    Subtotal = Stock7_20_25SqIn_1000Quantity;
                }
                else if (SqIn >= 25.1 && SqIn <= 30)
                {
                    Subtotal = Stock7_25_30SqIn_1000Quantity;
                }
                else if (SqIn >= 30.1 && SqIn <= 35)
                {
                    Subtotal = Stock7_30_35SqIn_1000Quantity;
                }
                else if (SqIn >= 35.1 && SqIn <= 40)
                {
                    Subtotal = Stock7_35_40SqIn_1000Quantity;
                }
                else if (SqIn > 40.1)
                {
                    lblCustomQuoteMessage.Text = CustomQuoteMessage;
                }
                //Calculating the price for the colors.
                Double ColorPrice = Stock7Color_1000Quantity * Convert.ToDouble(NumberOfColors);

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
            if (ddlStock.SelectedValue == "7" && ddlLabelQuantities.SelectedValue == "2000")
            {
                Double Subtotal = 0;

                //Displaying the Subtotal.
                if (SqIn >= 0 && SqIn <= 2.5)
                {
                    Subtotal = Stock7_0_2_5SqIn_2000Quantity;
                }
                else if (SqIn >= 2.5 && SqIn <= 5)
                {
                    Subtotal = Stock7_2_5_5SqIn_2000Quantity;
                }
                else if (SqIn >= 5.1 && SqIn <= 10)
                {
                    Subtotal = Stock7_5_10SqIn_2000Quantity;
                }
                else if (SqIn >= 10.1 && SqIn <= 15)
                {
                    Subtotal = Stock7_10_15SqIn_2000Quantity;
                }
                else if (SqIn >= 15.1 && SqIn <= 20)
                {
                    Subtotal = Stock7_15_20SqIn_2000Quantity;
                }
                else if (SqIn >= 20.1 && SqIn <= 25)
                {
                    Subtotal = Stock7_20_25SqIn_2000Quantity;
                }
                else if (SqIn >= 25.1 && SqIn <= 30)
                {
                    Subtotal = Stock7_25_30SqIn_2000Quantity;
                }
                else if (SqIn >= 30.1 && SqIn <= 35)
                {
                    Subtotal = Stock7_30_35SqIn_2000Quantity;
                }
                else if (SqIn >= 35.1 && SqIn <= 40)
                {
                    Subtotal = Stock7_35_40SqIn_2000Quantity;
                }
                else if (SqIn > 40.1)
                {
                    lblCustomQuoteMessage.Text = CustomQuoteMessage;
                }
                //Calculating the price for the colors.
                Double ColorPrice = Stock7Color_2000Quantity * Convert.ToDouble(NumberOfColors);

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
            if (ddlStock.SelectedValue == "7" && ddlLabelQuantities.SelectedValue == "2500")
            {
                Double Subtotal = 0;

                //Displaying the Subtotal.
                if (SqIn >= 0 && SqIn <= 2.5)
                {
                    Subtotal = Stock7_0_2_5SqIn_2500Quantity;
                }
                else if (SqIn >= 2.5 && SqIn <= 5)
                {
                    Subtotal = Stock7_2_5_5SqIn_2500Quantity;
                }
                else if (SqIn >= 5.1 && SqIn <= 10)
                {
                    Subtotal = Stock7_5_10SqIn_2500Quantity;
                }
                else if (SqIn >= 10.1 && SqIn <= 15)
                {
                    Subtotal = Stock7_10_15SqIn_2500Quantity;
                }
                else if (SqIn >= 15.1 && SqIn <= 20)
                {
                    Subtotal = Stock7_15_20SqIn_2500Quantity;
                }
                else if (SqIn >= 20.1 && SqIn <= 25)
                {
                    Subtotal = Stock7_20_25SqIn_2500Quantity;
                }
                else if (SqIn >= 25.1 && SqIn <= 30)
                {
                    Subtotal = Stock7_25_30SqIn_2500Quantity;
                }
                else if (SqIn >= 30.1 && SqIn <= 35)
                {
                    Subtotal = Stock7_30_35SqIn_2500Quantity;
                }
                else if (SqIn >= 35.1 && SqIn <= 40)
                {
                    Subtotal = Stock7_35_40SqIn_2500Quantity;
                }
                else if (SqIn > 40.1)
                {
                    lblCustomQuoteMessage.Text = CustomQuoteMessage;
                }
                //Calculating the price for the colors.
                Double ColorPrice = Stock7Color_2500Quantity * Convert.ToDouble(NumberOfColors);

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
            if (ddlStock.SelectedValue == "7" && ddlLabelQuantities.SelectedValue == "5000")
            {
                Double Subtotal = 0;

                //Displaying the Subtotal.
                if (SqIn >= 0 && SqIn <= 2.5)
                {
                    Subtotal = Stock7_0_2_5SqIn_5000Quantity;
                }
                else if (SqIn >= 2.5 && SqIn <= 5)
                {
                    Subtotal = Stock7_2_5_5SqIn_5000Quantity;
                }
                else if (SqIn >= 5.1 && SqIn <= 10)
                {
                    Subtotal = Stock7_5_10SqIn_5000Quantity;
                }
                else if (SqIn >= 10.1 && SqIn <= 15)
                {
                    Subtotal = Stock7_10_15SqIn_5000Quantity;
                }
                else if (SqIn >= 15.1 && SqIn <= 20)
                {
                    Subtotal = Stock7_15_20SqIn_5000Quantity;
                }
                else if (SqIn >= 20.1 && SqIn <= 25)
                {
                    Subtotal = Stock7_20_25SqIn_5000Quantity;
                }
                else if (SqIn >= 25.1 && SqIn <= 30)
                {
                    Subtotal = Stock7_25_30SqIn_5000Quantity;
                }
                else if (SqIn >= 30.1 && SqIn <= 35)
                {
                    Subtotal = Stock7_30_35SqIn_5000Quantity;
                }
                else if (SqIn >= 35.1 && SqIn <= 40)
                {
                    Subtotal = Stock7_35_40SqIn_5000Quantity;
                }
                else if (SqIn > 40.1)
                {
                    lblCustomQuoteMessage.Text = CustomQuoteMessage;
                }
                //Calculating the price for the colors.
                Double ColorPrice = Stock7Color_5000Quantity * Convert.ToDouble(NumberOfColors);

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
            if (ddlStock.SelectedValue == "7" && ddlLabelQuantities.SelectedValue == "10000")
            {
                Double Subtotal = 0;

                //Displaying the Subtotal.
                if (SqIn >= 0 && SqIn <= 2.5)
                {
                    Subtotal = Stock7_0_2_5SqIn_10000Quantity;
                }
                else if (SqIn >= 2.5 && SqIn <= 5)
                {
                    Subtotal = Stock7_2_5_5SqIn_10000Quantity;
                }
                else if (SqIn >= 5.1 && SqIn <= 10)
                {
                    Subtotal = Stock7_5_10SqIn_10000Quantity;
                }
                else if (SqIn >= 10.1 && SqIn <= 15)
                {
                    Subtotal = Stock7_10_15SqIn_10000Quantity;
                }
                else if (SqIn >= 15.1 && SqIn <= 20)
                {
                    Subtotal = Stock7_15_20SqIn_10000Quantity;
                }
                else if (SqIn >= 20.1 && SqIn <= 25)
                {
                    Subtotal = Stock7_20_25SqIn_10000Quantity;
                }
                else if (SqIn >= 25.1 && SqIn <= 30)
                {
                    Subtotal = Stock7_25_30SqIn_10000Quantity;
                }
                else if (SqIn >= 30.1 && SqIn <= 35)
                {
                    Subtotal = Stock7_30_35SqIn_10000Quantity;
                }
                else if (SqIn >= 35.1 && SqIn <= 40)
                {
                    Subtotal = Stock7_35_40SqIn_10000Quantity;
                }
                else if (SqIn > 40.1)
                {
                    lblCustomQuoteMessage.Text = CustomQuoteMessage;
                }
                //Calculating the price for the colors.
                Double ColorPrice = Stock7Color_10000Quantity * Convert.ToDouble(NumberOfColors);

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
            //Stock 8
            //======================================================================================================

            //50 Quantity If Statements
            //======================================================================================================

            //Finding out if the stock is and show the price for that stock.
            if (ddlStock.SelectedValue == "8" && ddlLabelQuantities.SelectedValue == "50")
            {
                Double Subtotal = 0;

                //Displaying the Subtotal.
                if (SqIn >= 0 && SqIn <= 2.5)
                {
                    Subtotal = Stock8_0_2_5SqIn_50Quantity;
                }
                else if (SqIn >= 2.5 && SqIn <= 5)
                {
                    Subtotal = Stock8_2_5_5SqIn_50Quantity;
                }
                else if (SqIn >= 5.1 && SqIn <= 10)
                {
                    Subtotal = Stock8_5_10SqIn_50Quantity;
                }
                else if (SqIn >= 10.1 && SqIn <= 15)
                {
                    Subtotal = Stock8_10_15SqIn_50Quantity;
                }
                else if (SqIn >= 15.1 && SqIn <= 20)
                {
                    Subtotal = Stock8_15_20SqIn_50Quantity;
                }
                else if (SqIn >= 20.1 && SqIn <= 25)
                {
                    Subtotal = Stock8_20_25SqIn_50Quantity;
                }
                else if (SqIn >= 25.1 && SqIn <= 30)
                {
                    Subtotal = Stock8_25_30SqIn_50Quantity;
                }
                else if (SqIn >= 30.1 && SqIn <= 35)
                {
                    Subtotal = Stock8_30_35SqIn_50Quantity;
                }
                else if (SqIn >= 35.1 && SqIn <= 40)
                {
                    Subtotal = Stock8_35_40SqIn_50Quantity;
                }
                else if (SqIn > 40.1)
                {
                    lblCustomQuoteMessage.Text = CustomQuoteMessage;
                }
                //Calculating the price for the colors.
                Double ColorPrice = Stock8Color_50Quantity * Convert.ToDouble(NumberOfColors);

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
            if (ddlStock.SelectedValue == "8" && ddlLabelQuantities.SelectedValue == "100")
            {
                Double Subtotal = 0;

                //Displaying the Subtotal.
                if (SqIn >= 0 && SqIn <= 2.5)
                {
                    Subtotal = Stock8_0_2_5SqIn_100Quantity;
                }
                else if (SqIn >= 2.5 && SqIn <= 5)
                {
                    Subtotal = Stock8_2_5_5SqIn_100Quantity;
                }
                else if (SqIn >= 5.1 && SqIn <= 10)
                {
                    Subtotal = Stock8_5_10SqIn_100Quantity;
                }
                else if (SqIn >= 10.1 && SqIn <= 15)
                {
                    Subtotal = Stock8_10_15SqIn_100Quantity;
                }
                else if (SqIn >= 15.1 && SqIn <= 20)
                {
                    Subtotal = Stock8_15_20SqIn_100Quantity;
                }
                else if (SqIn >= 20.1 && SqIn <= 25)
                {
                    Subtotal = Stock8_20_25SqIn_100Quantity;
                }
                else if (SqIn >= 25.1 && SqIn <= 30)
                {
                    Subtotal = Stock8_25_30SqIn_100Quantity;
                }
                else if (SqIn >= 30.1 && SqIn <= 35)
                {
                    Subtotal = Stock8_30_35SqIn_100Quantity;
                }
                else if (SqIn >= 35.1 && SqIn <= 40)
                {
                    Subtotal = Stock8_35_40SqIn_100Quantity;
                }
                else if (SqIn > 40.1)
                {
                    lblCustomQuoteMessage.Text = CustomQuoteMessage;
                }
                //Calculating the price for the colors.
                Double ColorPrice = Stock8Color_100Quantity * Convert.ToDouble(NumberOfColors);

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
            if (ddlStock.SelectedValue == "8" && ddlLabelQuantities.SelectedValue == "250")
            {
                Double Subtotal = 0;

                //Displaying the Subtotal.
                if (SqIn >= 0 && SqIn <= 2.5)
                {
                    Subtotal = Stock8_0_2_5SqIn_250Quantity;
                }
                else if (SqIn >= 2.5 && SqIn <= 5)
                {
                    Subtotal = Stock8_2_5_5SqIn_250Quantity;
                }
                else if (SqIn >= 5.1 && SqIn <= 10)
                {
                    Subtotal = Stock8_5_10SqIn_250Quantity;
                }
                else if (SqIn >= 10.1 && SqIn <= 15)
                {
                    Subtotal = Stock8_10_15SqIn_250Quantity;
                }
                else if (SqIn >= 15.1 && SqIn <= 20)
                {
                    Subtotal = Stock8_15_20SqIn_250Quantity;
                }
                else if (SqIn >= 20.1 && SqIn <= 25)
                {
                    Subtotal = Stock8_20_25SqIn_250Quantity;
                }
                else if (SqIn >= 25.1 && SqIn <= 30)
                {
                    Subtotal = Stock8_25_30SqIn_250Quantity;
                }
                else if (SqIn >= 30.1 && SqIn <= 35)
                {
                    Subtotal = Stock8_30_35SqIn_250Quantity;
                }
                else if (SqIn >= 35.1 && SqIn <= 40)
                {
                    Subtotal = Stock8_35_40SqIn_250Quantity;
                }
                else if (SqIn > 40.1)
                {
                    lblCustomQuoteMessage.Text = CustomQuoteMessage;
                }
                //Calculating the price for the colors.
                Double ColorPrice = Stock8Color_250Quantity * Convert.ToDouble(NumberOfColors);

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
            if (ddlStock.SelectedValue == "8" && ddlLabelQuantities.SelectedValue == "500")
            {
                Double Subtotal = 0;

                //Displaying the Subtotal.
                if (SqIn >= 0 && SqIn <= 2.5)
                {
                    Subtotal = Stock8_0_2_5SqIn_500Quantity;
                }
                else if (SqIn >= 2.5 && SqIn <= 5)
                {
                    Subtotal = Stock8_2_5_5SqIn_500Quantity;
                }
                else if (SqIn >= 5.1 && SqIn <= 10)
                {
                    Subtotal = Stock8_5_10SqIn_500Quantity;
                }
                else if (SqIn >= 10.1 && SqIn <= 15)
                {
                    Subtotal = Stock8_10_15SqIn_500Quantity;
                }
                else if (SqIn >= 15.1 && SqIn <= 20)
                {
                    Subtotal = Stock8_15_20SqIn_500Quantity;
                }
                else if (SqIn >= 20.1 && SqIn <= 25)
                {
                    Subtotal = Stock8_20_25SqIn_500Quantity;
                }
                else if (SqIn >= 25.1 && SqIn <= 30)
                {
                    Subtotal = Stock8_25_30SqIn_500Quantity;
                }
                else if (SqIn >= 30.1 && SqIn <= 35)
                {
                    Subtotal = Stock8_30_35SqIn_500Quantity;
                }
                else if (SqIn >= 35.1 && SqIn <= 40)
                {
                    Subtotal = Stock8_35_40SqIn_500Quantity;
                }
                else if (SqIn > 40.1)
                {
                    lblCustomQuoteMessage.Text = CustomQuoteMessage;
                }
                //Calculating the price for the colors.
                Double ColorPrice = Stock8Color_500Quantity * Convert.ToDouble(NumberOfColors);

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
            if (ddlStock.SelectedValue == "8" && ddlLabelQuantities.SelectedValue == "1000")
            {
                Double Subtotal = 0;

                //Displaying the Subtotal.
                if (SqIn >= 0 && SqIn <= 2.5)
                {
                    Subtotal = Stock8_0_2_5SqIn_1000Quantity;
                }
                else if (SqIn >= 2.5 && SqIn <= 5)
                {
                    Subtotal = Stock8_2_5_5SqIn_1000Quantity;
                }
                else if (SqIn >= 5.1 && SqIn <= 10)
                {
                    Subtotal = Stock8_5_10SqIn_1000Quantity;
                }
                else if (SqIn >= 10.1 && SqIn <= 15)
                {
                    Subtotal = Stock8_10_15SqIn_1000Quantity;
                }
                else if (SqIn >= 15.1 && SqIn <= 20)
                {
                    Subtotal = Stock8_15_20SqIn_1000Quantity;
                }
                else if (SqIn >= 20.1 && SqIn <= 25)
                {
                    Subtotal = Stock8_20_25SqIn_1000Quantity;
                }
                else if (SqIn >= 25.1 && SqIn <= 30)
                {
                    Subtotal = Stock8_25_30SqIn_1000Quantity;
                }
                else if (SqIn >= 30.1 && SqIn <= 35)
                {
                    Subtotal = Stock8_30_35SqIn_1000Quantity;
                }
                else if (SqIn >= 35.1 && SqIn <= 40)
                {
                    Subtotal = Stock8_35_40SqIn_1000Quantity;
                }
                else if (SqIn > 40.1)
                {
                    lblCustomQuoteMessage.Text = CustomQuoteMessage;
                }
                //Calculating the price for the colors.
                Double ColorPrice = Stock8Color_1000Quantity * Convert.ToDouble(NumberOfColors);

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
            if (ddlStock.SelectedValue == "8" && ddlLabelQuantities.SelectedValue == "2000")
            {
                Double Subtotal = 0;

                //Displaying the Subtotal.
                if (SqIn >= 0 && SqIn <= 2.5)
                {
                    Subtotal = Stock8_0_2_5SqIn_2000Quantity;
                }
                else if (SqIn >= 2.5 && SqIn <= 5)
                {
                    Subtotal = Stock8_2_5_5SqIn_2000Quantity;
                }
                else if (SqIn >= 5.1 && SqIn <= 10)
                {
                    Subtotal = Stock8_5_10SqIn_2000Quantity;
                }
                else if (SqIn >= 10.1 && SqIn <= 15)
                {
                    Subtotal = Stock8_10_15SqIn_2000Quantity;
                }
                else if (SqIn >= 15.1 && SqIn <= 20)
                {
                    Subtotal = Stock8_15_20SqIn_2000Quantity;
                }
                else if (SqIn >= 20.1 && SqIn <= 25)
                {
                    Subtotal = Stock8_20_25SqIn_2000Quantity;
                }
                else if (SqIn >= 25.1 && SqIn <= 30)
                {
                    Subtotal = Stock8_25_30SqIn_2000Quantity;
                }
                else if (SqIn >= 30.1 && SqIn <= 35)
                {
                    Subtotal = Stock8_30_35SqIn_2000Quantity;
                }
                else if (SqIn >= 35.1 && SqIn <= 40)
                {
                    Subtotal = Stock8_35_40SqIn_2000Quantity;
                }
                else if (SqIn > 40.1)
                {
                    lblCustomQuoteMessage.Text = CustomQuoteMessage;
                }
                //Calculating the price for the colors.
                Double ColorPrice = Stock8Color_2000Quantity * Convert.ToDouble(NumberOfColors);

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
            if (ddlStock.SelectedValue == "8" && ddlLabelQuantities.SelectedValue == "2500")
            {
                Double Subtotal = 0;

                //Displaying the Subtotal.
                if (SqIn >= 0 && SqIn <= 2.5)
                {
                    Subtotal = Stock8_0_2_5SqIn_2500Quantity;
                }
                else if (SqIn >= 2.5 && SqIn <= 5)
                {
                    Subtotal = Stock8_2_5_5SqIn_2500Quantity;
                }
                else if (SqIn >= 5.1 && SqIn <= 10)
                {
                    Subtotal = Stock8_5_10SqIn_2500Quantity;
                }
                else if (SqIn >= 10.1 && SqIn <= 15)
                {
                    Subtotal = Stock8_10_15SqIn_2500Quantity;
                }
                else if (SqIn >= 15.1 && SqIn <= 20)
                {
                    Subtotal = Stock8_15_20SqIn_2500Quantity;
                }
                else if (SqIn >= 20.1 && SqIn <= 25)
                {
                    Subtotal = Stock8_20_25SqIn_2500Quantity;
                }
                else if (SqIn >= 25.1 && SqIn <= 30)
                {
                    Subtotal = Stock8_25_30SqIn_2500Quantity;
                }
                else if (SqIn >= 30.1 && SqIn <= 35)
                {
                    Subtotal = Stock8_30_35SqIn_2500Quantity;
                }
                else if (SqIn >= 35.1 && SqIn <= 40)
                {
                    Subtotal = Stock8_35_40SqIn_2500Quantity;
                }
                else if (SqIn > 40.1)
                {
                    lblCustomQuoteMessage.Text = CustomQuoteMessage;
                }
                //Calculating the price for the colors.
                Double ColorPrice = Stock8Color_2500Quantity * Convert.ToDouble(NumberOfColors);

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
            if (ddlStock.SelectedValue == "8" && ddlLabelQuantities.SelectedValue == "5000")
            {
                Double Subtotal = 0;

                //Displaying the Subtotal.
                if (SqIn >= 0 && SqIn <= 2.5)
                {
                    Subtotal = Stock8_0_2_5SqIn_5000Quantity;
                }
                else if (SqIn >= 2.5 && SqIn <= 5)
                {
                    Subtotal = Stock8_2_5_5SqIn_5000Quantity;
                }
                else if (SqIn >= 5.1 && SqIn <= 10)
                {
                    Subtotal = Stock8_5_10SqIn_5000Quantity;
                }
                else if (SqIn >= 10.1 && SqIn <= 15)
                {
                    Subtotal = Stock8_10_15SqIn_5000Quantity;
                }
                else if (SqIn >= 15.1 && SqIn <= 20)
                {
                    Subtotal = Stock8_15_20SqIn_5000Quantity;
                }
                else if (SqIn >= 20.1 && SqIn <= 25)
                {
                    Subtotal = Stock8_20_25SqIn_5000Quantity;
                }
                else if (SqIn >= 25.1 && SqIn <= 30)
                {
                    Subtotal = Stock8_25_30SqIn_5000Quantity;
                }
                else if (SqIn >= 30.1 && SqIn <= 35)
                {
                    Subtotal = Stock8_30_35SqIn_5000Quantity;
                }
                else if (SqIn >= 35.1 && SqIn <= 40)
                {
                    Subtotal = Stock8_35_40SqIn_5000Quantity;
                }
                else if (SqIn > 40.1)
                {
                    lblCustomQuoteMessage.Text = CustomQuoteMessage;
                }
                //Calculating the price for the colors.
                Double ColorPrice = Stock8Color_5000Quantity * Convert.ToDouble(NumberOfColors);

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
            if (ddlStock.SelectedValue == "8" && ddlLabelQuantities.SelectedValue == "10000")
            {
                Double Subtotal = 0;

                //Displaying the Subtotal.
                if (SqIn >= 0 && SqIn <= 2.5)
                {
                    Subtotal = Stock8_0_2_5SqIn_10000Quantity;
                }
                else if (SqIn >= 2.5 && SqIn <= 5)
                {
                    Subtotal = Stock8_2_5_5SqIn_10000Quantity;
                }
                else if (SqIn >= 5.1 && SqIn <= 10)
                {
                    Subtotal = Stock8_5_10SqIn_10000Quantity;
                }
                else if (SqIn >= 10.1 && SqIn <= 15)
                {
                    Subtotal = Stock8_10_15SqIn_10000Quantity;
                }
                else if (SqIn >= 15.1 && SqIn <= 20)
                {
                    Subtotal = Stock8_15_20SqIn_10000Quantity;
                }
                else if (SqIn >= 20.1 && SqIn <= 25)
                {
                    Subtotal = Stock8_20_25SqIn_10000Quantity;
                }
                else if (SqIn >= 25.1 && SqIn <= 30)
                {
                    Subtotal = Stock8_25_30SqIn_10000Quantity;
                }
                else if (SqIn >= 30.1 && SqIn <= 35)
                {
                    Subtotal = Stock8_30_35SqIn_10000Quantity;
                }
                else if (SqIn >= 35.1 && SqIn <= 40)
                {
                    Subtotal = Stock8_35_40SqIn_10000Quantity;
                }
                else if (SqIn > 40.1)
                {
                    lblCustomQuoteMessage.Text = CustomQuoteMessage;
                }
                //Calculating the price for the colors.
                Double ColorPrice = Stock8Color_10000Quantity * Convert.ToDouble(NumberOfColors);

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
            //Stock 9
            //======================================================================================================

            //50 Quantity If Statements
            //======================================================================================================

            //Finding out if the stock is and show the price for that stock.
            if (ddlStock.SelectedValue == "9" && ddlLabelQuantities.SelectedValue == "50")
            {
                Double Subtotal = 0;

                //Displaying the Subtotal.
                if (SqIn >= 0 && SqIn <= 2.5)
                {
                    Subtotal = Stock9_0_2_5SqIn_50Quantity;
                }
                else if (SqIn >= 2.5 && SqIn <= 5)
                {
                    Subtotal = Stock9_2_5_5SqIn_50Quantity;
                }
                else if (SqIn >= 5.1 && SqIn <= 10)
                {
                    Subtotal = Stock9_5_10SqIn_50Quantity;
                }
                else if (SqIn >= 10.1 && SqIn <= 15)
                {
                    Subtotal = Stock9_10_15SqIn_50Quantity;
                }
                else if (SqIn >= 15.1 && SqIn <= 20)
                {
                    Subtotal = Stock9_15_20SqIn_50Quantity;
                }
                else if (SqIn >= 20.1 && SqIn <= 25)
                {
                    Subtotal = Stock9_20_25SqIn_50Quantity;
                }
                else if (SqIn >= 25.1 && SqIn <= 30)
                {
                    Subtotal = Stock9_25_30SqIn_50Quantity;
                }
                else if (SqIn >= 30.1 && SqIn <= 35)
                {
                    Subtotal = Stock9_30_35SqIn_50Quantity;
                }
                else if (SqIn >= 35.1 && SqIn <= 40)
                {
                    Subtotal = Stock9_35_40SqIn_50Quantity;
                }
                else if (SqIn > 40.1)
                {
                    lblCustomQuoteMessage.Text = CustomQuoteMessage;
                }
                //Calculating the price for the colors.
                Double ColorPrice = Stock9Color_50Quantity * Convert.ToDouble(NumberOfColors);

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
            if (ddlStock.SelectedValue == "9" && ddlLabelQuantities.SelectedValue == "100")
            {
                Double Subtotal = 0;

                //Displaying the Subtotal.
                if (SqIn >= 0 && SqIn <= 2.5)
                {
                    Subtotal = Stock9_0_2_5SqIn_100Quantity;
                }
                else if (SqIn >= 2.5 && SqIn <= 5)
                {
                    Subtotal = Stock9_2_5_5SqIn_100Quantity;
                }
                else if (SqIn >= 5.1 && SqIn <= 10)
                {
                    Subtotal = Stock9_5_10SqIn_100Quantity;
                }
                else if (SqIn >= 10.1 && SqIn <= 15)
                {
                    Subtotal = Stock9_10_15SqIn_100Quantity;
                }
                else if (SqIn >= 15.1 && SqIn <= 20)
                {
                    Subtotal = Stock9_15_20SqIn_100Quantity;
                }
                else if (SqIn >= 20.1 && SqIn <= 25)
                {
                    Subtotal = Stock9_20_25SqIn_100Quantity;
                }
                else if (SqIn >= 25.1 && SqIn <= 30)
                {
                    Subtotal = Stock9_25_30SqIn_100Quantity;
                }
                else if (SqIn >= 30.1 && SqIn <= 35)
                {
                    Subtotal = Stock9_30_35SqIn_100Quantity;
                }
                else if (SqIn >= 35.1 && SqIn <= 40)
                {
                    Subtotal = Stock9_35_40SqIn_100Quantity;
                }
                else if (SqIn > 40.1)
                {
                    lblCustomQuoteMessage.Text = CustomQuoteMessage;
                }
                //Calculating the price for the colors.
                Double ColorPrice = Stock9Color_100Quantity * Convert.ToDouble(NumberOfColors);

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
            if (ddlStock.SelectedValue == "9" && ddlLabelQuantities.SelectedValue == "250")
            {
                Double Subtotal = 0;

                //Displaying the Subtotal.
                if (SqIn >= 0 && SqIn <= 2.5)
                {
                    Subtotal = Stock9_0_2_5SqIn_250Quantity;
                }
                else if (SqIn >= 2.5 && SqIn <= 5)
                {
                    Subtotal = Stock9_2_5_5SqIn_250Quantity;
                }
                else if (SqIn >= 5.1 && SqIn <= 10)
                {
                    Subtotal = Stock9_5_10SqIn_250Quantity;
                }
                else if (SqIn >= 10.1 && SqIn <= 15)
                {
                    Subtotal = Stock9_10_15SqIn_250Quantity;
                }
                else if (SqIn >= 15.1 && SqIn <= 20)
                {
                    Subtotal = Stock9_15_20SqIn_250Quantity;
                }
                else if (SqIn >= 20.1 && SqIn <= 25)
                {
                    Subtotal = Stock9_20_25SqIn_250Quantity;
                }
                else if (SqIn >= 25.1 && SqIn <= 30)
                {
                    Subtotal = Stock9_25_30SqIn_250Quantity;
                }
                else if (SqIn >= 30.1 && SqIn <= 35)
                {
                    Subtotal = Stock9_30_35SqIn_250Quantity;
                }
                else if (SqIn >= 35.1 && SqIn <= 40)
                {
                    Subtotal = Stock9_35_40SqIn_250Quantity;
                }
                else if (SqIn > 40.1)
                {
                    lblCustomQuoteMessage.Text = CustomQuoteMessage;
                }
                //Calculating the price for the colors.
                Double ColorPrice = Stock9Color_250Quantity * Convert.ToDouble(NumberOfColors);

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
            if (ddlStock.SelectedValue == "9" && ddlLabelQuantities.SelectedValue == "500")
            {
                Double Subtotal = 0;

                //Displaying the Subtotal.
                if (SqIn >= 0 && SqIn <= 2.5)
                {
                    Subtotal = Stock9_0_2_5SqIn_500Quantity;
                }
                else if (SqIn >= 2.5 && SqIn <= 5)
                {
                    Subtotal = Stock9_2_5_5SqIn_500Quantity;
                }
                else if (SqIn >= 5.1 && SqIn <= 10)
                {
                    Subtotal = Stock9_5_10SqIn_500Quantity;
                }
                else if (SqIn >= 10.1 && SqIn <= 15)
                {
                    Subtotal = Stock9_10_15SqIn_500Quantity;
                }
                else if (SqIn >= 15.1 && SqIn <= 20)
                {
                    Subtotal = Stock9_15_20SqIn_500Quantity;
                }
                else if (SqIn >= 20.1 && SqIn <= 25)
                {
                    Subtotal = Stock9_20_25SqIn_500Quantity;
                }
                else if (SqIn >= 25.1 && SqIn <= 30)
                {
                    Subtotal = Stock9_25_30SqIn_500Quantity;
                }
                else if (SqIn >= 30.1 && SqIn <= 35)
                {
                    Subtotal = Stock9_30_35SqIn_500Quantity;
                }
                else if (SqIn >= 35.1 && SqIn <= 40)
                {
                    Subtotal = Stock9_35_40SqIn_500Quantity;
                }
                else if (SqIn > 40.1)
                {
                    lblCustomQuoteMessage.Text = CustomQuoteMessage;
                }
                //Calculating the price for the colors.
                Double ColorPrice = Stock9Color_500Quantity * Convert.ToDouble(NumberOfColors);

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
            if (ddlStock.SelectedValue == "9" && ddlLabelQuantities.SelectedValue == "1000")
            {
                Double Subtotal = 0;

                //Displaying the Subtotal.
                if (SqIn >= 0 && SqIn <= 2.5)
                {
                    Subtotal = Stock9_0_2_5SqIn_1000Quantity;
                }
                else if (SqIn >= 2.5 && SqIn <= 5)
                {
                    Subtotal = Stock9_2_5_5SqIn_1000Quantity;
                }
                else if (SqIn >= 5.1 && SqIn <= 10)
                {
                    Subtotal = Stock9_5_10SqIn_1000Quantity;
                }
                else if (SqIn >= 10.1 && SqIn <= 15)
                {
                    Subtotal = Stock9_10_15SqIn_1000Quantity;
                }
                else if (SqIn >= 15.1 && SqIn <= 20)
                {
                    Subtotal = Stock9_15_20SqIn_1000Quantity;
                }
                else if (SqIn >= 20.1 && SqIn <= 25)
                {
                    Subtotal = Stock9_20_25SqIn_1000Quantity;
                }
                else if (SqIn >= 25.1 && SqIn <= 30)
                {
                    Subtotal = Stock9_25_30SqIn_1000Quantity;
                }
                else if (SqIn >= 30.1 && SqIn <= 35)
                {
                    Subtotal = Stock9_30_35SqIn_1000Quantity;
                }
                else if (SqIn >= 35.1 && SqIn <= 40)
                {
                    Subtotal = Stock9_35_40SqIn_1000Quantity;
                }
                else if (SqIn > 40.1)
                {
                    lblCustomQuoteMessage.Text = CustomQuoteMessage;
                }
                //Calculating the price for the colors.
                Double ColorPrice = Stock9Color_1000Quantity * Convert.ToDouble(NumberOfColors);

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
            if (ddlStock.SelectedValue == "9" && ddlLabelQuantities.SelectedValue == "2000")
            {
                Double Subtotal = 0;

                //Displaying the Subtotal.
                if (SqIn >= 0 && SqIn <= 2.5)
                {
                    Subtotal = Stock9_0_2_5SqIn_2000Quantity;
                }
                else if (SqIn >= 2.5 && SqIn <= 5)
                {
                    Subtotal = Stock9_2_5_5SqIn_2000Quantity;
                }
                else if (SqIn >= 5.1 && SqIn <= 10)
                {
                    Subtotal = Stock9_5_10SqIn_2000Quantity;
                }
                else if (SqIn >= 10.1 && SqIn <= 15)
                {
                    Subtotal = Stock9_10_15SqIn_2000Quantity;
                }
                else if (SqIn >= 15.1 && SqIn <= 20)
                {
                    Subtotal = Stock9_15_20SqIn_2000Quantity;
                }
                else if (SqIn >= 20.1 && SqIn <= 25)
                {
                    Subtotal = Stock9_20_25SqIn_2000Quantity;
                }
                else if (SqIn >= 25.1 && SqIn <= 30)
                {
                    Subtotal = Stock9_25_30SqIn_2000Quantity;
                }
                else if (SqIn >= 30.1 && SqIn <= 35)
                {
                    Subtotal = Stock9_30_35SqIn_2000Quantity;
                }
                else if (SqIn >= 35.1 && SqIn <= 40)
                {
                    Subtotal = Stock9_35_40SqIn_2000Quantity;
                }
                else if (SqIn > 40.1)
                {
                    lblCustomQuoteMessage.Text = CustomQuoteMessage;
                }
                //Calculating the price for the colors.
                Double ColorPrice = Stock9Color_2000Quantity * Convert.ToDouble(NumberOfColors);

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
            if (ddlStock.SelectedValue == "9" && ddlLabelQuantities.SelectedValue == "2500")
            {
                Double Subtotal = 0;

                //Displaying the Subtotal.
                if (SqIn >= 0 && SqIn <= 2.5)
                {
                    Subtotal = Stock9_0_2_5SqIn_2500Quantity;
                }
                else if (SqIn >= 2.5 && SqIn <= 5)
                {
                    Subtotal = Stock9_2_5_5SqIn_2500Quantity;
                }
                else if (SqIn >= 5.1 && SqIn <= 10)
                {
                    Subtotal = Stock9_5_10SqIn_2500Quantity;
                }
                else if (SqIn >= 10.1 && SqIn <= 15)
                {
                    Subtotal = Stock9_10_15SqIn_2500Quantity;
                }
                else if (SqIn >= 15.1 && SqIn <= 20)
                {
                    Subtotal = Stock9_15_20SqIn_2500Quantity;
                }
                else if (SqIn >= 20.1 && SqIn <= 25)
                {
                    Subtotal = Stock9_20_25SqIn_2500Quantity;
                }
                else if (SqIn >= 25.1 && SqIn <= 30)
                {
                    Subtotal = Stock9_25_30SqIn_2500Quantity;
                }
                else if (SqIn >= 30.1 && SqIn <= 35)
                {
                    Subtotal = Stock9_30_35SqIn_2500Quantity;
                }
                else if (SqIn >= 35.1 && SqIn <= 40)
                {
                    Subtotal = Stock9_35_40SqIn_2500Quantity;
                }
                else if (SqIn > 40.1)
                {
                    lblCustomQuoteMessage.Text = CustomQuoteMessage;
                }
                //Calculating the price for the colors.
                Double ColorPrice = Stock9Color_2500Quantity * Convert.ToDouble(NumberOfColors);

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
            if (ddlStock.SelectedValue == "9" && ddlLabelQuantities.SelectedValue == "5000")
            {
                Double Subtotal = 0;

                //Displaying the Subtotal.
                if (SqIn >= 0 && SqIn <= 2.5)
                {
                    Subtotal = Stock9_0_2_5SqIn_5000Quantity;
                }
                else if (SqIn >= 2.5 && SqIn <= 5)
                {
                    Subtotal = Stock9_2_5_5SqIn_5000Quantity;
                }
                else if (SqIn >= 5.1 && SqIn <= 10)
                {
                    Subtotal = Stock9_5_10SqIn_5000Quantity;
                }
                else if (SqIn >= 10.1 && SqIn <= 15)
                {
                    Subtotal = Stock9_10_15SqIn_5000Quantity;
                }
                else if (SqIn >= 15.1 && SqIn <= 20)
                {
                    Subtotal = Stock9_15_20SqIn_5000Quantity;
                }
                else if (SqIn >= 20.1 && SqIn <= 25)
                {
                    Subtotal = Stock9_20_25SqIn_5000Quantity;
                }
                else if (SqIn >= 25.1 && SqIn <= 30)
                {
                    Subtotal = Stock9_25_30SqIn_5000Quantity;
                }
                else if (SqIn >= 30.1 && SqIn <= 35)
                {
                    Subtotal = Stock9_30_35SqIn_5000Quantity;
                }
                else if (SqIn >= 35.1 && SqIn <= 40)
                {
                    Subtotal = Stock9_35_40SqIn_5000Quantity;
                }
                else if (SqIn > 40.1)
                {
                    lblCustomQuoteMessage.Text = CustomQuoteMessage;
                }
                //Calculating the price for the colors.
                Double ColorPrice = Stock9Color_5000Quantity * Convert.ToDouble(NumberOfColors);

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
            if (ddlStock.SelectedValue == "9" && ddlLabelQuantities.SelectedValue == "10000")
            {
                Double Subtotal = 0;

                //Displaying the Subtotal.
                if (SqIn >= 0 && SqIn <= 2.5)
                {
                    Subtotal = Stock9_0_2_5SqIn_10000Quantity;
                }
                else if (SqIn >= 2.5 && SqIn <= 5)
                {
                    Subtotal = Stock9_2_5_5SqIn_10000Quantity;
                }
                else if (SqIn >= 5.1 && SqIn <= 10)
                {
                    Subtotal = Stock9_5_10SqIn_10000Quantity;
                }
                else if (SqIn >= 10.1 && SqIn <= 15)
                {
                    Subtotal = Stock9_10_15SqIn_10000Quantity;
                }
                else if (SqIn >= 15.1 && SqIn <= 20)
                {
                    Subtotal = Stock9_15_20SqIn_10000Quantity;
                }
                else if (SqIn >= 20.1 && SqIn <= 25)
                {
                    Subtotal = Stock9_20_25SqIn_10000Quantity;
                }
                else if (SqIn >= 25.1 && SqIn <= 30)
                {
                    Subtotal = Stock9_25_30SqIn_10000Quantity;
                }
                else if (SqIn >= 30.1 && SqIn <= 35)
                {
                    Subtotal = Stock9_30_35SqIn_10000Quantity;
                }
                else if (SqIn >= 35.1 && SqIn <= 40)
                {
                    Subtotal = Stock9_35_40SqIn_10000Quantity;
                }
                else if (SqIn > 40.1)
                {
                    lblCustomQuoteMessage.Text = CustomQuoteMessage;
                }
                //Calculating the price for the colors.
                Double ColorPrice = Stock9Color_10000Quantity * Convert.ToDouble(NumberOfColors);

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
            //Stock 10
            //======================================================================================================

            //50 Quantity If Statements
            //======================================================================================================

            //Finding out if the stock is and show the price for that stock.
            if (ddlStock.SelectedValue == "10" && ddlLabelQuantities.SelectedValue == "50")
            {
                Double Subtotal = 0;

                //Displaying the Subtotal.
                if (SqIn >= 0 && SqIn <= 2.5)
                {
                    Subtotal = Stock10_0_2_5SqIn_50Quantity;
                }
                else if (SqIn >= 2.5 && SqIn <= 5)
                {
                    Subtotal = Stock10_2_5_5SqIn_50Quantity;
                }
                else if (SqIn >= 5.1 && SqIn <= 10)
                {
                    Subtotal = Stock10_5_10SqIn_50Quantity;
                }
                else if (SqIn >= 10.1 && SqIn <= 15)
                {
                    Subtotal = Stock10_10_15SqIn_50Quantity;
                }
                else if (SqIn >= 15.1 && SqIn <= 20)
                {
                    Subtotal = Stock10_15_20SqIn_50Quantity;
                }
                else if (SqIn >= 20.1 && SqIn <= 25)
                {
                    Subtotal = Stock10_20_25SqIn_50Quantity;
                }
                else if (SqIn >= 25.1 && SqIn <= 30)
                {
                    Subtotal = Stock10_25_30SqIn_50Quantity;
                }
                else if (SqIn >= 30.1 && SqIn <= 35)
                {
                    Subtotal = Stock10_30_35SqIn_50Quantity;
                }
                else if (SqIn >= 35.1 && SqIn <= 40)
                {
                    Subtotal = Stock10_35_40SqIn_50Quantity;
                }
                else if (SqIn > 40.1)
                {
                    lblCustomQuoteMessage.Text = CustomQuoteMessage;
                }
                //Calculating the price for the colors.
                Double ColorPrice = Stock10Color_50Quantity * Convert.ToDouble(NumberOfColors);

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
            if (ddlStock.SelectedValue == "10" && ddlLabelQuantities.SelectedValue == "100")
            {
                Double Subtotal = 0;

                //Displaying the Subtotal.
                if (SqIn >= 0 && SqIn <= 2.5)
                {
                    Subtotal = Stock10_0_2_5SqIn_100Quantity;
                }
                else if (SqIn >= 2.5 && SqIn <= 5)
                {
                    Subtotal = Stock10_2_5_5SqIn_100Quantity;
                }
                else if (SqIn >= 5.1 && SqIn <= 10)
                {
                    Subtotal = Stock10_5_10SqIn_100Quantity;
                }
                else if (SqIn >= 10.1 && SqIn <= 15)
                {
                    Subtotal = Stock10_10_15SqIn_100Quantity;
                }
                else if (SqIn >= 15.1 && SqIn <= 20)
                {
                    Subtotal = Stock10_15_20SqIn_100Quantity;
                }
                else if (SqIn >= 20.1 && SqIn <= 25)
                {
                    Subtotal = Stock10_20_25SqIn_100Quantity;
                }
                else if (SqIn >= 25.1 && SqIn <= 30)
                {
                    Subtotal = Stock10_25_30SqIn_100Quantity;
                }
                else if (SqIn >= 30.1 && SqIn <= 35)
                {
                    Subtotal = Stock10_30_35SqIn_100Quantity;
                }
                else if (SqIn >= 35.1 && SqIn <= 40)
                {
                    Subtotal = Stock10_35_40SqIn_100Quantity;
                }
                else if (SqIn > 40.1)
                {
                    lblCustomQuoteMessage.Text = CustomQuoteMessage;
                }
                //Calculating the price for the colors.
                Double ColorPrice = Stock10Color_100Quantity * Convert.ToDouble(NumberOfColors);

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
            if (ddlStock.SelectedValue == "10" && ddlLabelQuantities.SelectedValue == "250")
            {
                Double Subtotal = 0;

                //Displaying the Subtotal.
                if (SqIn >= 0 && SqIn <= 2.5)
                {
                    Subtotal = Stock10_0_2_5SqIn_250Quantity;
                }
                else if (SqIn >= 2.5 && SqIn <= 5)
                {
                    Subtotal = Stock10_2_5_5SqIn_250Quantity;
                }
                else if (SqIn >= 5.1 && SqIn <= 10)
                {
                    Subtotal = Stock10_5_10SqIn_250Quantity;
                }
                else if (SqIn >= 10.1 && SqIn <= 15)
                {
                    Subtotal = Stock10_10_15SqIn_250Quantity;
                }
                else if (SqIn >= 15.1 && SqIn <= 20)
                {
                    Subtotal = Stock10_15_20SqIn_250Quantity;
                }
                else if (SqIn >= 20.1 && SqIn <= 25)
                {
                    Subtotal = Stock10_20_25SqIn_250Quantity;
                }
                else if (SqIn >= 25.1 && SqIn <= 30)
                {
                    Subtotal = Stock10_25_30SqIn_250Quantity;
                }
                else if (SqIn >= 30.1 && SqIn <= 35)
                {
                    Subtotal = Stock10_30_35SqIn_250Quantity;
                }
                else if (SqIn >= 35.1 && SqIn <= 40)
                {
                    Subtotal = Stock10_35_40SqIn_250Quantity;
                }
                else if (SqIn > 40.1)
                {
                    lblCustomQuoteMessage.Text = CustomQuoteMessage;
                }
                //Calculating the price for the colors.
                Double ColorPrice = Stock10Color_250Quantity * Convert.ToDouble(NumberOfColors);

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
            if (ddlStock.SelectedValue == "10" && ddlLabelQuantities.SelectedValue == "500")
            {
                Double Subtotal = 0;

                //Displaying the Subtotal.
                if (SqIn >= 0 && SqIn <= 2.5)
                {
                    Subtotal = Stock10_0_2_5SqIn_500Quantity;
                }
                else if (SqIn >= 2.5 && SqIn <= 5)
                {
                    Subtotal = Stock10_2_5_5SqIn_500Quantity;
                }
                else if (SqIn >= 5.1 && SqIn <= 10)
                {
                    Subtotal = Stock10_5_10SqIn_500Quantity;
                }
                else if (SqIn >= 10.1 && SqIn <= 15)
                {
                    Subtotal = Stock10_10_15SqIn_500Quantity;
                }
                else if (SqIn >= 15.1 && SqIn <= 20)
                {
                    Subtotal = Stock10_15_20SqIn_500Quantity;
                }
                else if (SqIn >= 20.1 && SqIn <= 25)
                {
                    Subtotal = Stock10_20_25SqIn_500Quantity;
                }
                else if (SqIn >= 25.1 && SqIn <= 30)
                {
                    Subtotal = Stock10_25_30SqIn_500Quantity;
                }
                else if (SqIn >= 30.1 && SqIn <= 35)
                {
                    Subtotal = Stock10_30_35SqIn_500Quantity;
                }
                else if (SqIn >= 35.1 && SqIn <= 40)
                {
                    Subtotal = Stock10_35_40SqIn_500Quantity;
                }
                else if (SqIn > 40.1)
                {
                    lblCustomQuoteMessage.Text = CustomQuoteMessage;
                }
                //Calculating the price for the colors.
                Double ColorPrice = Stock10Color_500Quantity * Convert.ToDouble(NumberOfColors);

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
            if (ddlStock.SelectedValue == "10" && ddlLabelQuantities.SelectedValue == "1000")
            {
                Double Subtotal = 0;

                //Displaying the Subtotal.
                if (SqIn >= 0 && SqIn <= 2.5)
                {
                    Subtotal = Stock10_0_2_5SqIn_1000Quantity;
                }
                else if (SqIn >= 2.5 && SqIn <= 5)
                {
                    Subtotal = Stock10_2_5_5SqIn_1000Quantity;
                }
                else if (SqIn >= 5.1 && SqIn <= 10)
                {
                    Subtotal = Stock10_5_10SqIn_1000Quantity;
                }
                else if (SqIn >= 10.1 && SqIn <= 15)
                {
                    Subtotal = Stock10_10_15SqIn_1000Quantity;
                }
                else if (SqIn >= 15.1 && SqIn <= 20)
                {
                    Subtotal = Stock10_15_20SqIn_1000Quantity;
                }
                else if (SqIn >= 20.1 && SqIn <= 25)
                {
                    Subtotal = Stock10_20_25SqIn_1000Quantity;
                }
                else if (SqIn >= 25.1 && SqIn <= 30)
                {
                    Subtotal = Stock10_25_30SqIn_1000Quantity;
                }
                else if (SqIn >= 30.1 && SqIn <= 35)
                {
                    Subtotal = Stock10_30_35SqIn_1000Quantity;
                }
                else if (SqIn >= 35.1 && SqIn <= 40)
                {
                    Subtotal = Stock10_35_40SqIn_1000Quantity;
                }
                else if (SqIn > 40.1)
                {
                    lblCustomQuoteMessage.Text = CustomQuoteMessage;
                }
                //Calculating the price for the colors.
                Double ColorPrice = Stock10Color_1000Quantity * Convert.ToDouble(NumberOfColors);

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
            if (ddlStock.SelectedValue == "10" && ddlLabelQuantities.SelectedValue == "2000")
            {
                Double Subtotal = 0;

                //Displaying the Subtotal.
                if (SqIn >= 0 && SqIn <= 2.5)
                {
                    Subtotal = Stock10_0_2_5SqIn_2000Quantity;
                }
                else if (SqIn >= 2.5 && SqIn <= 5)
                {
                    Subtotal = Stock10_2_5_5SqIn_2000Quantity;
                }
                else if (SqIn >= 5.1 && SqIn <= 10)
                {
                    Subtotal = Stock10_5_10SqIn_2000Quantity;
                }
                else if (SqIn >= 10.1 && SqIn <= 15)
                {
                    Subtotal = Stock10_10_15SqIn_2000Quantity;
                }
                else if (SqIn >= 15.1 && SqIn <= 20)
                {
                    Subtotal = Stock10_15_20SqIn_2000Quantity;
                }
                else if (SqIn >= 20.1 && SqIn <= 25)
                {
                    Subtotal = Stock10_20_25SqIn_2000Quantity;
                }
                else if (SqIn >= 25.1 && SqIn <= 30)
                {
                    Subtotal = Stock10_25_30SqIn_2000Quantity;
                }
                else if (SqIn >= 30.1 && SqIn <= 35)
                {
                    Subtotal = Stock10_30_35SqIn_2000Quantity;
                }
                else if (SqIn >= 35.1 && SqIn <= 40)
                {
                    Subtotal = Stock10_35_40SqIn_2000Quantity;
                }
                else if (SqIn > 40.1)
                {
                    lblCustomQuoteMessage.Text = CustomQuoteMessage;
                }
                //Calculating the price for the colors.
                Double ColorPrice = Stock10Color_2000Quantity * Convert.ToDouble(NumberOfColors);

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
            if (ddlStock.SelectedValue == "10" && ddlLabelQuantities.SelectedValue == "2500")
            {
                Double Subtotal = 0;

                //Displaying the Subtotal.
                if (SqIn >= 0 && SqIn <= 2.5)
                {
                    Subtotal = Stock10_0_2_5SqIn_2500Quantity;
                }
                else if (SqIn >= 2.5 && SqIn <= 5)
                {
                    Subtotal = Stock10_2_5_5SqIn_2500Quantity;
                }
                else if (SqIn >= 5.1 && SqIn <= 10)
                {
                    Subtotal = Stock10_5_10SqIn_2500Quantity;
                }
                else if (SqIn >= 10.1 && SqIn <= 15)
                {
                    Subtotal = Stock10_10_15SqIn_2500Quantity;
                }
                else if (SqIn >= 15.1 && SqIn <= 20)
                {
                    Subtotal = Stock10_15_20SqIn_2500Quantity;
                }
                else if (SqIn >= 20.1 && SqIn <= 25)
                {
                    Subtotal = Stock10_20_25SqIn_2500Quantity;
                }
                else if (SqIn >= 25.1 && SqIn <= 30)
                {
                    Subtotal = Stock10_25_30SqIn_2500Quantity;
                }
                else if (SqIn >= 30.1 && SqIn <= 35)
                {
                    Subtotal = Stock10_30_35SqIn_2500Quantity;
                }
                else if (SqIn >= 35.1 && SqIn <= 40)
                {
                    Subtotal = Stock10_35_40SqIn_2500Quantity;
                }
                else if (SqIn > 40.1)
                {
                    lblCustomQuoteMessage.Text = CustomQuoteMessage;
                }
                //Calculating the price for the colors.
                Double ColorPrice = Stock10Color_2500Quantity * Convert.ToDouble(NumberOfColors);

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
            if (ddlStock.SelectedValue == "10" && ddlLabelQuantities.SelectedValue == "5000")
            {
                Double Subtotal = 0;

                //Displaying the Subtotal.
                if (SqIn >= 0 && SqIn <= 2.5)
                {
                    Subtotal = Stock10_0_2_5SqIn_5000Quantity;
                }
                else if (SqIn >= 2.5 && SqIn <= 5)
                {
                    Subtotal = Stock10_2_5_5SqIn_5000Quantity;
                }
                else if (SqIn >= 5.1 && SqIn <= 10)
                {
                    Subtotal = Stock10_5_10SqIn_5000Quantity;
                }
                else if (SqIn >= 10.1 && SqIn <= 15)
                {
                    Subtotal = Stock10_10_15SqIn_5000Quantity;
                }
                else if (SqIn >= 15.1 && SqIn <= 20)
                {
                    Subtotal = Stock10_15_20SqIn_5000Quantity;
                }
                else if (SqIn >= 20.1 && SqIn <= 25)
                {
                    Subtotal = Stock10_20_25SqIn_5000Quantity;
                }
                else if (SqIn >= 25.1 && SqIn <= 30)
                {
                    Subtotal = Stock10_25_30SqIn_5000Quantity;
                }
                else if (SqIn >= 30.1 && SqIn <= 35)
                {
                    Subtotal = Stock10_30_35SqIn_5000Quantity;
                }
                else if (SqIn >= 35.1 && SqIn <= 40)
                {
                    Subtotal = Stock10_35_40SqIn_5000Quantity;
                }
                else if (SqIn > 40.1)
                {
                    lblCustomQuoteMessage.Text = CustomQuoteMessage;
                }
                //Calculating the price for the colors.
                Double ColorPrice = Stock10Color_5000Quantity * Convert.ToDouble(NumberOfColors);

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
            if (ddlStock.SelectedValue == "10" && ddlLabelQuantities.SelectedValue == "10000")
            {
                Double Subtotal = 0;

                //Displaying the Subtotal.
                if (SqIn >= 0 && SqIn <= 2.5)
                {
                    Subtotal = Stock10_0_2_5SqIn_10000Quantity;
                }
                else if (SqIn >= 2.5 && SqIn <= 5)
                {
                    Subtotal = Stock10_2_5_5SqIn_10000Quantity;
                }
                else if (SqIn >= 5.1 && SqIn <= 10)
                {
                    Subtotal = Stock10_5_10SqIn_10000Quantity;
                }
                else if (SqIn >= 10.1 && SqIn <= 15)
                {
                    Subtotal = Stock10_10_15SqIn_10000Quantity;
                }
                else if (SqIn >= 15.1 && SqIn <= 20)
                {
                    Subtotal = Stock10_15_20SqIn_10000Quantity;
                }
                else if (SqIn >= 20.1 && SqIn <= 25)
                {
                    Subtotal = Stock10_20_25SqIn_10000Quantity;
                }
                else if (SqIn >= 25.1 && SqIn <= 30)
                {
                    Subtotal = Stock10_25_30SqIn_10000Quantity;
                }
                else if (SqIn >= 30.1 && SqIn <= 35)
                {
                    Subtotal = Stock10_30_35SqIn_10000Quantity;
                }
                else if (SqIn >= 35.1 && SqIn <= 40)
                {
                    Subtotal = Stock10_35_40SqIn_10000Quantity;
                }
                else if (SqIn > 40.1)
                {
                    lblCustomQuoteMessage.Text = CustomQuoteMessage;
                }
                //Calculating the price for the colors.
                Double ColorPrice = Stock10Color_10000Quantity * Convert.ToDouble(NumberOfColors);

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