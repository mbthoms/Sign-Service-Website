using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Sign_Service_Label_Products.Dealer.Pricing
{
    public partial class vinyl_pricing : System.Web.UI.Page
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
            //Global Vars
            //======================================================================================================
            String CustomQuoteMessage = "<div class='alert alert-danger' role='alert'>Please call or email our sales desk for a custom quote at: <a href='tel:18007872382'>1 (800)-787-2382</a><br />or <a href='mailto:sales@signservice.com'>sales@signservice.com</a></div>";

            //======================================================================================================
            //Stock 1 Pricing
            //======================================================================================================

            //50 Quantity.
            Double Stock1_0_2_5SqIn_50Quantity = 135.00;
            Double Stock1_2_5_5SqIn_50Quantity = 135.00;
            Double Stock1_5_10SqIn_50Quantity = 139.00;
            Double Stock1_10_15SqIn_50Quantity = 142.00;
            Double Stock1_15_20SqIn_50Quantity = 145.00;
            Double Stock1_20_25SqIn_50Quantity = 147.00;
            Double Stock1_25_30SqIn_50Quantity = 149.00;
            Double Stock1_30_35SqIn_50Quantity = 151.00;
            Double Stock1_35_40SqIn_50Quantity = 155.00;
            //Color, 50 Quantity.
            Double Stock1Color_50Quantity = 60.00;

            //100 Quantity.
            Double Stock1_0_2_5SqIn_100Quantity = 145.00;
            Double Stock1_2_5_5SqIn_100Quantity = 145.00;
            Double Stock1_5_10SqIn_100Quantity = 148.00;
            Double Stock1_10_15SqIn_100Quantity = 153.00;
            Double Stock1_15_20SqIn_100Quantity = 159.00;
            Double Stock1_20_25SqIn_100Quantity = 160.00;
            Double Stock1_25_30SqIn_100Quantity = 164.00;
            Double Stock1_30_35SqIn_100Quantity = 168.00;
            Double Stock1_35_40SqIn_100Quantity = 175.00;
            //Color, 100 Quantity.
            Double Stock1Color_100Quantity = 65.00;

            //250 Quantity.
            Double Stock1_0_2_5SqIn_250Quantity = 155.00;
            Double Stock1_2_5_5SqIn_250Quantity = 155.00;
            Double Stock1_5_10SqIn_250Quantity = 168.00;
            Double Stock1_10_15SqIn_250Quantity = 178.00;
            Double Stock1_15_20SqIn_250Quantity = 193.00;
            Double Stock1_20_25SqIn_250Quantity = 201.00;
            Double Stock1_25_30SqIn_250Quantity = 210.00;
            Double Stock1_30_35SqIn_250Quantity = 216.00;
            Double Stock1_35_40SqIn_250Quantity = 230.00;
            //Color, 250 Quantity.
            Double Stock1Color_250Quantity = 75.00;

            //500 Quantity.
            Double Stock1_0_2_5SqIn_500Quantity = 180.00;
            Double Stock1_2_5_5SqIn_500Quantity = 185.00;
            Double Stock1_5_10SqIn_500Quantity = 204.00;
            Double Stock1_10_15SqIn_500Quantity = 222.00;
            Double Stock1_15_20SqIn_500Quantity = 250.00;
            Double Stock1_20_25SqIn_500Quantity = 284.00;
            Double Stock1_25_30SqIn_500Quantity = 260.00;
            Double Stock1_30_35SqIn_500Quantity = 288.00;
            Double Stock1_35_40SqIn_500Quantity = 305.00;
            //Color, 250 Quantity.
            Double Stock1Color_500Quantity = 80.00;

            //1000 Quantity.
            Double Stock1_0_2_5SqIn_1000Quantity = 215.00;
            Double Stock1_2_5_5SqIn_1000Quantity = 235.00;
            Double Stock1_5_10SqIn_1000Quantity = 280.00;
            Double Stock1_10_15SqIn_1000Quantity = 324.00;
            Double Stock1_15_20SqIn_1000Quantity = 328.00;
            Double Stock1_20_25SqIn_1000Quantity = 371.00;
            Double Stock1_25_30SqIn_1000Quantity = 411.00;
            Double Stock1_30_35SqIn_1000Quantity = 460.00;
            Double Stock1_35_40SqIn_1000Quantity = 465.00;
            //Color, 250 Quantity.
            Double Stock1Color_1000Quantity = 85.00;

            //2000 Quantity.
            Double Stock1_0_2_5SqIn_2000Quantity = 285.00;
            Double Stock1_2_5_5SqIn_2000Quantity = 315.00;
            Double Stock1_5_10SqIn_2000Quantity = 416.00;
            Double Stock1_10_15SqIn_2000Quantity = 503.00;
            Double Stock1_15_20SqIn_2000Quantity = 511.00;
            Double Stock1_20_25SqIn_2000Quantity = 598.00;
            Double Stock1_25_30SqIn_2000Quantity = 689.00;
            Double Stock1_30_35SqIn_2000Quantity = 730.00;
            Double Stock1_35_40SqIn_2000Quantity = 825.00;
            //Color, 250 Quantity.
            Double Stock1Color_2000Quantity = 100.00;

            //2500 Quantity.
            Double Stock1_0_2_5SqIn_2500Quantity = 322.00;
            Double Stock1_2_5_5SqIn_2500Quantity = 358.00;
            Double Stock1_5_10SqIn_2500Quantity = 468.00;
            Double Stock1_10_15SqIn_2500Quantity = 573.00;
            Double Stock1_15_20SqIn_2500Quantity = 581.00;
            Double Stock1_20_25SqIn_2500Quantity = 707.00;
            Double Stock1_25_30SqIn_2500Quantity = 820.00;
            Double Stock1_30_35SqIn_2500Quantity = 868.00;
            Double Stock1_35_40SqIn_2500Quantity = 988.00;
            //Color, 250 Quantity.
            Double Stock1Color_2500Quantity = 115.00;

            //5000 Quantity.
            Double Stock1_0_2_5SqIn_5000Quantity = 505.00;
            Double Stock1_2_5_5SqIn_5000Quantity = 570.00;
            Double Stock1_5_10SqIn_5000Quantity = 726.00;
            Double Stock1_10_15SqIn_5000Quantity = 920.00;
            Double Stock1_15_20SqIn_5000Quantity = 931.00;
            Double Stock1_20_25SqIn_5000Quantity = 1252.00;
            Double Stock1_25_30SqIn_5000Quantity = 1476.00;
            Double Stock1_30_35SqIn_5000Quantity = 1555.00;
            Double Stock1_35_40SqIn_5000Quantity = 1800.00;
            //Color, 250 Quantity.
            Double Stock1Color_5000Quantity = 230.00;

            //10000 Quantity.
            Double Stock1_0_2_5SqIn_10000Quantity = 870.00;
            Double Stock1_2_5_5SqIn_10000Quantity = 980.00;
            Double Stock1_5_10SqIn_10000Quantity = 1250.00;
            Double Stock1_10_15SqIn_10000Quantity = 1651.00;
            Double Stock1_15_20SqIn_10000Quantity = 1661.00;
            Double Stock1_20_25SqIn_10000Quantity = 2240.00;
            Double Stock1_25_30SqIn_10000Quantity = 2656.00;
            Double Stock1_30_35SqIn_10000Quantity = 2790.00;
            Double Stock1_35_40SqIn_10000Quantity = 3265.00;
            //Color, 250 Quantity.
            Double Stock1Color_10000Quantity = 360.00;

            //======================================================================================================
            //Stock 2 Pricing
            //======================================================================================================

            //50 Quantity.
            Double Stock2_0_2_5SqIn_50Quantity = 136.00;
            Double Stock2_2_5_5SqIn_50Quantity = 137.00;
            Double Stock2_5_10SqIn_50Quantity = 139.00;
            Double Stock2_10_15SqIn_50Quantity = 142.00;
            Double Stock2_15_20SqIn_50Quantity = 145.00;
            Double Stock2_20_25SqIn_50Quantity = 147.00;
            Double Stock2_25_30SqIn_50Quantity = 150.00;
            Double Stock2_30_35SqIn_50Quantity = 152.00;
            Double Stock2_35_40SqIn_50Quantity = 156.00;
            //Color, 50 Quantity.
            Double Stock2Color_50Quantity = 60.00;

            //100 Quantity.
            Double Stock2_0_2_5SqIn_100Quantity = 144.00;
            Double Stock2_2_5_5SqIn_100Quantity = 145.00;
            Double Stock2_5_10SqIn_100Quantity = 149.00;
            Double Stock2_10_15SqIn_100Quantity = 154.00;
            Double Stock2_15_20SqIn_100Quantity = 157.00;
            Double Stock2_20_25SqIn_100Quantity = 162.00;
            Double Stock2_25_30SqIn_100Quantity = 166.00;
            Double Stock2_30_35SqIn_100Quantity = 169.00;
            Double Stock2_35_40SqIn_100Quantity = 175.00;
            //Color, 100 Quantity.
            Double Stock2Color_100Quantity = 65.00;

            //250 Quantity.
            Double Stock2_0_2_5SqIn_250Quantity = 169.00;
            Double Stock2_2_5_5SqIn_250Quantity = 169.00;
            Double Stock2_5_10SqIn_250Quantity = 178.00;
            Double Stock2_10_15SqIn_250Quantity = 188.00;
            Double Stock2_15_20SqIn_250Quantity = 195.00;
            Double Stock2_20_25SqIn_250Quantity = 205.00;
            Double Stock2_25_30SqIn_250Quantity = 214.00;
            Double Stock2_30_35SqIn_250Quantity = 221.00;
            Double Stock2_35_40SqIn_250Quantity = 234.00;
            //Color, 250 Quantity.
            Double Stock2Color_250Quantity = 75.00;

            //500 Quantity.
            Double Stock2_0_2_5SqIn_500Quantity = 183.00;
            Double Stock2_2_5_5SqIn_500Quantity = 190.00;
            Double Stock2_5_10SqIn_500Quantity = 207.00;
            Double Stock2_10_15SqIn_500Quantity = 227.00;
            Double Stock2_15_20SqIn_500Quantity = 242.00;
            Double Stock2_20_25SqIn_500Quantity = 294.00;
            Double Stock2_25_30SqIn_500Quantity = 267.00;
            Double Stock2_30_35SqIn_500Quantity = 298.00;
            Double Stock2_35_40SqIn_500Quantity = 314.00;
            //Color, 250 Quantity.
            Double Stock2Color_500Quantity = 80.00;

            //1000 Quantity.
            Double Stock2_0_2_5SqIn_1000Quantity = 217.00;
            Double Stock2_2_5_5SqIn_1000Quantity = 231.00;
            Double Stock2_5_10SqIn_1000Quantity = 387.00;
            Double Stock2_10_15SqIn_1000Quantity = 320.00;
            Double Stock2_15_20SqIn_1000Quantity = 339.00;
            Double Stock2_20_25SqIn_1000Quantity = 386.00;
            Double Stock2_25_30SqIn_1000Quantity = 390.00;
            Double Stock2_30_35SqIn_1000Quantity = 479.00;
            Double Stock2_35_40SqIn_1000Quantity = 484.00;
            //Color, 250 Quantity.
            Double Stock2Color_1000Quantity = 85.00;

            //2000 Quantity.
            Double Stock2_0_2_5SqIn_2000Quantity = 289.00;
            Double Stock2_2_5_5SqIn_2000Quantity = 319.00;
            Double Stock2_5_10SqIn_2000Quantity = 406.00;
            Double Stock2_10_15SqIn_2000Quantity = 473.00;
            Double Stock2_15_20SqIn_2000Quantity = 533.00;
            Double Stock2_20_25SqIn_2000Quantity = 627.00;
            Double Stock2_25_30SqIn_2000Quantity = 647.00;
            Double Stock2_30_35SqIn_2000Quantity = 767.00;
            Double Stock2_35_40SqIn_2000Quantity = 868.00;
            //Color, 250 Quantity.
            Double Stock2Color_2000Quantity = 100.00;

            //2500 Quantity.
            Double Stock2_0_2_5SqIn_2500Quantity = 324.00;
            Double Stock2_2_5_5SqIn_2500Quantity = 360.00;
            Double Stock2_5_10SqIn_2500Quantity = 464.00;
            Double Stock2_10_15SqIn_2500Quantity = 554.00;
            Double Stock2_15_20SqIn_2500Quantity = 631.00;
            Double Stock2_20_25SqIn_2500Quantity = 742.00;
            Double Stock2_25_30SqIn_2500Quantity = 769.00;
            Double Stock2_30_35SqIn_2500Quantity = 913.00;
            Double Stock2_35_40SqIn_2500Quantity = 1039.00;
            //Color, 250 Quantity.
            Double Stock2Color_2500Quantity = 115.00;

            //5000 Quantity.
            Double Stock2_0_2_5SqIn_5000Quantity = 497.00;
            Double Stock2_2_5_5SqIn_5000Quantity = 565.00;
            Double Stock2_5_10SqIn_5000Quantity = 752.00;
            Double Stock2_10_15SqIn_5000Quantity = 959.00;
            Double Stock2_15_20SqIn_5000Quantity = 1123.00;
            Double Stock2_20_25SqIn_5000Quantity = 1317.00;
            Double Stock2_25_30SqIn_5000Quantity = 1381.00;
            Double Stock2_30_35SqIn_5000Quantity = 1642.00;
            Double Stock2_35_40SqIn_5000Quantity = 1896.00;
            //Color, 250 Quantity.
            Double Stock2Color_5000Quantity = 230.00;

            //10000 Quantity.
            Double Stock2_0_2_5SqIn_10000Quantity = 856.00;
            Double Stock2_2_5_5SqIn_10000Quantity = 1002.00;
            Double Stock2_5_10SqIn_10000Quantity = 1296.00;
            Double Stock2_10_15SqIn_10000Quantity = 1719.00;
            Double Stock2_15_20SqIn_10000Quantity = 2001.00;
            Double Stock2_20_25SqIn_10000Quantity = 2355.00;
            Double Stock2_25_30SqIn_10000Quantity = 2487.00;
            Double Stock2_30_35SqIn_10000Quantity = 2946.00;
            Double Stock2_35_40SqIn_10000Quantity = 3435.00;
            //Color, 250 Quantity.
            Double Stock2Color_10000Quantity = 360.00;

            //======================================================================================================
            //Stock 3 Pricing
            //======================================================================================================

            //50 Quantity.
            Double Stock3_0_2_5SqIn_50Quantity = 137.00;
            Double Stock3_2_5_5SqIn_50Quantity = 137.00;
            Double Stock3_5_10SqIn_50Quantity = 140.00;
            Double Stock3_10_15SqIn_50Quantity = 144.00;
            Double Stock3_15_20SqIn_50Quantity = 146.00;
            Double Stock3_20_25SqIn_50Quantity = 149.00;
            Double Stock3_25_30SqIn_50Quantity = 153.00;
            Double Stock3_30_35SqIn_50Quantity = 155.00;
            Double Stock3_35_40SqIn_50Quantity = 159.00;
            //Color, 50 Quantity.
            Double Stock3Color_50Quantity = 60.00;

            //100 Quantity.
            Double Stock3_0_2_5SqIn_100Quantity = 145.00;
            Double Stock3_2_5_5SqIn_100Quantity = 146.00;
            Double Stock3_5_10SqIn_100Quantity = 151.00;
            Double Stock3_10_15SqIn_100Quantity = 157.00;
            Double Stock3_15_20SqIn_100Quantity = 161.00;
            Double Stock3_20_25SqIn_100Quantity = 166.00;
            Double Stock3_25_30SqIn_100Quantity = 171.00;
            Double Stock3_30_35SqIn_100Quantity = 175.00;
            Double Stock3_35_40SqIn_100Quantity = 182.00;
            //Color, 100 Quantity.
            Double Stock3Color_100Quantity = 65.00;

            //250 Quantity.
            Double Stock3_0_2_5SqIn_250Quantity = 171.00;
            Double Stock3_2_5_5SqIn_250Quantity = 172.00;
            Double Stock3_5_10SqIn_250Quantity = 182.00;
            Double Stock3_10_15SqIn_250Quantity = 195.00;
            Double Stock3_15_20SqIn_250Quantity = 203.00;
            Double Stock3_20_25SqIn_250Quantity = 215.00;
            Double Stock3_25_30SqIn_250Quantity = 227.00;
            Double Stock3_30_35SqIn_250Quantity = 235.00;
            Double Stock3_35_40SqIn_250Quantity = 250.00;
            //Color, 250 Quantity.
            Double Stock3Color_250Quantity = 75.00;

            //500 Quantity.
            Double Stock3_0_2_5SqIn_500Quantity = 186.00;
            Double Stock3_2_5_5SqIn_500Quantity = 195.00;
            Double Stock3_5_10SqIn_500Quantity = 216.00;
            Double Stock3_10_15SqIn_500Quantity = 246.00;
            Double Stock3_15_20SqIn_500Quantity = 257.00;
            Double Stock3_20_25SqIn_500Quantity = 286.00;
            Double Stock3_25_30SqIn_500Quantity = 288.00;
            Double Stock3_30_35SqIn_500Quantity = 325.00;
            Double Stock3_35_40SqIn_500Quantity = 345.00;
            //Color, 250 Quantity.
            Double Stock3Color_500Quantity = 80.00;

            //1000 Quantity.
            Double Stock3_0_2_5SqIn_1000Quantity = 222.00;
            Double Stock3_2_5_5SqIn_1000Quantity = 240.00;
            Double Stock3_5_10SqIn_1000Quantity = 308.00;
            Double Stock3_10_15SqIn_1000Quantity = 348.00;
            Double Stock3_15_20SqIn_1000Quantity = 370.00;
            Double Stock3_20_25SqIn_1000Quantity = 427.00;
            Double Stock3_25_30SqIn_1000Quantity = 431.00;
            Double Stock3_30_35SqIn_1000Quantity = 542.00;
            Double Stock3_35_40SqIn_1000Quantity = 546.00;
            //Color, 250 Quantity.
            Double Stock3Color_1000Quantity = 85.00;

            //2000 Quantity.
            Double Stock3_0_2_5SqIn_2000Quantity = 299.00;
            Double Stock3_2_5_5SqIn_2000Quantity = 336.00;
            Double Stock3_5_10SqIn_2000Quantity = 472.00;
            Double Stock3_10_15SqIn_2000Quantity = 523.00;
            Double Stock3_15_20SqIn_2000Quantity = 595.00;
            Double Stock3_20_25SqIn_2000Quantity = 710.00;
            Double Stock3_25_30SqIn_2000Quantity = 730.00;
            Double Stock3_30_35SqIn_2000Quantity = 878.00;
            Double Stock3_35_40SqIn_2000Quantity = 993.00;
            //Color, 250 Quantity.
            Double Stock3Color_2000Quantity = 100.00;

            //2500 Quantity.
            Double Stock3_0_2_5SqIn_2500Quantity = 335.00;
            Double Stock3_2_5_5SqIn_2500Quantity = 383.00;
            Double Stock3_5_10SqIn_2500Quantity = 518.00;
            Double Stock3_10_15SqIn_2500Quantity = 614.00;
            Double Stock3_15_20SqIn_2500Quantity = 708.00;
            Double Stock3_20_25SqIn_2500Quantity = 842.00;
            Double Stock3_25_30SqIn_2500Quantity = 870.00;
            Double Stock3_30_35SqIn_2500Quantity = 1047.00;
            Double Stock3_35_40SqIn_2500Quantity = 1190.00;
            //Color, 250 Quantity.
            Double Stock3Color_2500Quantity = 115.00;

            //5000 Quantity.
            Double Stock3_0_2_5SqIn_5000Quantity = 515.00;
            Double Stock3_2_5_5SqIn_5000Quantity = 619.00;
            Double Stock3_5_10SqIn_5000Quantity = 750.00;
            Double Stock3_10_15SqIn_5000Quantity = 1071.00;
            Double Stock3_15_20SqIn_5000Quantity = 1272.00;
            Double Stock3_20_25SqIn_5000Quantity = 1504.00;
            Double Stock3_25_30SqIn_5000Quantity = 1567.00;
            Double Stock3_30_35SqIn_5000Quantity = 1892.00;
            Double Stock3_35_40SqIn_5000Quantity = 2177.00;
            //Color, 250 Quantity.
            Double Stock3Color_5000Quantity = 230.00;

            //10000 Quantity.
            Double Stock3_0_2_5SqIn_10000Quantity = 889.00;
            Double Stock3_2_5_5SqIn_10000Quantity = 1068.00;
            Double Stock3_5_10SqIn_10000Quantity = 1428.00;
            Double Stock3_10_15SqIn_10000Quantity = 1918.00;
            Double Stock3_15_20SqIn_10000Quantity = 2266.00;
            Double Stock3_20_25SqIn_10000Quantity = 2685.00;
            Double Stock3_25_30SqIn_10000Quantity = 2818.00;
            Double Stock3_30_35SqIn_10000Quantity = 3387.00;
            Double Stock3_35_40SqIn_10000Quantity = 3931.00;
            //Color, 250 Quantity.
            Double Stock3Color_10000Quantity = 360.00;

            //======================================================================================================
            //Stock 4 Pricing
            //======================================================================================================

            //50 Quantity.
            Double Stock4_0_2_5SqIn_50Quantity = 137.00;
            Double Stock4_2_5_5SqIn_50Quantity = 137.00;
            Double Stock4_5_10SqIn_50Quantity = 140.00;
            Double Stock4_10_15SqIn_50Quantity = 143.00;
            Double Stock4_15_20SqIn_50Quantity = 146.00;
            Double Stock4_20_25SqIn_50Quantity = 148.00;
            Double Stock4_25_30SqIn_50Quantity = 151.00;
            Double Stock4_30_35SqIn_50Quantity = 155.00;
            Double Stock4_35_40SqIn_50Quantity = 158.00;
            //Color, 50 Quantity.
            Double Stock4Color_50Quantity = 60.00;

            //100 Quantity.
            Double Stock4_0_2_5SqIn_100Quantity = 145.00;
            Double Stock4_2_5_5SqIn_100Quantity = 146.00;
            Double Stock4_5_10SqIn_100Quantity = 151.00;
            Double Stock4_10_15SqIn_100Quantity = 155.00;
            Double Stock4_15_20SqIn_100Quantity = 160.00;
            Double Stock4_20_25SqIn_100Quantity = 164.00;
            Double Stock4_25_30SqIn_100Quantity = 169.00;
            Double Stock4_30_35SqIn_100Quantity = 175.00;
            Double Stock4_35_40SqIn_100Quantity = 180.00;
            //Color, 100 Quantity.
            Double Stock4Color_100Quantity = 65.00;

            //250 Quantity.
            Double Stock4_0_2_5SqIn_250Quantity = 171.00;
            Double Stock4_2_5_5SqIn_250Quantity = 172.00;
            Double Stock4_5_10SqIn_250Quantity = 183.00;
            Double Stock4_10_15SqIn_250Quantity = 192.00;
            Double Stock4_15_20SqIn_250Quantity = 201.00;
            Double Stock4_20_25SqIn_250Quantity = 210.00;
            Double Stock4_25_30SqIn_250Quantity = 220.00;
            Double Stock4_30_35SqIn_250Quantity = 236.00;
            Double Stock4_35_40SqIn_250Quantity = 245.00;
            //Color, 250 Quantity.
            Double Stock4Color_250Quantity = 75.00;

            //500 Quantity.
            Double Stock4_0_2_5SqIn_500Quantity = 186.00;
            Double Stock4_2_5_5SqIn_500Quantity = 195.00;
            Double Stock4_5_10SqIn_500Quantity = 214.00;
            Double Stock4_10_15SqIn_500Quantity = 232.00;
            Double Stock4_15_20SqIn_500Quantity = 249.00;
            Double Stock4_20_25SqIn_500Quantity = 275.00;
            Double Stock4_25_30SqIn_500Quantity = 301.00;
            Double Stock4_30_35SqIn_500Quantity = 327.00;
            Double Stock4_35_40SqIn_500Quantity = 345.00;
            //Color, 250 Quantity.
            Double Stock4Color_500Quantity = 80.00;

            //1000 Quantity.
            Double Stock4_0_2_5SqIn_1000Quantity = 224.00;
            Double Stock4_2_5_5SqIn_1000Quantity = 245.00;
            Double Stock4_5_10SqIn_1000Quantity = 281.00;
            Double Stock4_10_15SqIn_1000Quantity = 325.00;
            Double Stock4_15_20SqIn_1000Quantity = 353.00;
            Double Stock4_20_25SqIn_1000Quantity = 453.00;
            Double Stock4_25_30SqIn_1000Quantity = 457.00;
            Double Stock4_30_35SqIn_1000Quantity = 561.00;
            Double Stock4_35_40SqIn_1000Quantity = 585.00;
            //Color, 250 Quantity.
            Double Stock4Color_1000Quantity = 85.00;

            //2000 Quantity.
            Double Stock4_0_2_5SqIn_2000Quantity = 294.00;
            Double Stock4_2_5_5SqIn_2000Quantity = 330.00;
            Double Stock4_5_10SqIn_2000Quantity = 418.00;
            Double Stock4_10_15SqIn_2000Quantity = 506.00;
            Double Stock4_15_20SqIn_2000Quantity = 633.00;
            Double Stock4_20_25SqIn_2000Quantity = 761.00;
            Double Stock4_25_30SqIn_2000Quantity = 781.00;
            Double Stock4_30_35SqIn_2000Quantity = 946.00;
            Double Stock4_35_40SqIn_2000Quantity = 1069.00;
            //Color, 250 Quantity.
            Double Stock4Color_2000Quantity = 100.00;

            //2500 Quantity.
            Double Stock4_0_2_5SqIn_2500Quantity = 333.00;
            Double Stock4_2_5_5SqIn_2500Quantity = 375.00;
            Double Stock4_5_10SqIn_2500Quantity = 494.00;
            Double Stock4_10_15SqIn_2500Quantity = 612.00;
            Double Stock4_15_20SqIn_2500Quantity = 719.00;
            Double Stock4_20_25SqIn_2500Quantity = 904.00;
            Double Stock4_25_30SqIn_2500Quantity = 931.00;
            Double Stock4_30_35SqIn_2500Quantity = 1129.00;
            Double Stock4_35_40SqIn_2500Quantity = 1282.00;
            //Color, 250 Quantity.
            Double Stock4Color_2500Quantity = 115.00;

            //5000 Quantity.
            Double Stock4_0_2_5SqIn_5000Quantity = 527.00;
            Double Stock4_2_5_5SqIn_5000Quantity = 599.00;
            Double Stock4_5_10SqIn_5000Quantity = 872.00;
            Double Stock4_10_15SqIn_5000Quantity = 1140.00;
            Double Stock4_15_20SqIn_5000Quantity = 1150.00;
            Double Stock4_20_25SqIn_5000Quantity = 1618.00;
            Double Stock4_25_30SqIn_5000Quantity = 1682.00;
            Double Stock4_30_35SqIn_5000Quantity = 2044.00;
            Double Stock4_35_40SqIn_5000Quantity = 2348.00;
            //Color, 250 Quantity.
            Double Stock4Color_5000Quantity = 230.00;

            //10000 Quantity.
            Double Stock4_0_2_5SqIn_10000Quantity = 909.00;
            Double Stock4_2_5_5SqIn_10000Quantity = 1109.00;
            Double Stock4_5_10SqIn_10000Quantity = 1509.00;
            Double Stock4_10_15SqIn_10000Quantity = 1509.00;
            Double Stock4_15_20SqIn_10000Quantity = 2039.00;
            Double Stock4_20_25SqIn_10000Quantity = 2050.00;
            Double Stock4_25_30SqIn_10000Quantity = 2888.00;
            Double Stock4_30_35SqIn_10000Quantity = 3020.00;
            Double Stock4_35_40SqIn_10000Quantity = 3657.00;
            //Color, 250 Quantity.
            Double Stock4Color_10000Quantity = 360.00;

            //======================================================================================================
            //Stock 6 Pricing
            //======================================================================================================

            //50 Quantity.
            Double Stock6_0_2_5SqIn_50Quantity = 136.00;
            Double Stock6_2_5_5SqIn_50Quantity = 136.00;
            Double Stock6_5_10SqIn_50Quantity = 141.00;
            Double Stock6_10_15SqIn_50Quantity = 145.00;
            Double Stock6_15_20SqIn_50Quantity = 148.00;
            Double Stock6_20_25SqIn_50Quantity = 151.00;
            Double Stock6_25_30SqIn_50Quantity = 153.00;
            Double Stock6_30_35SqIn_50Quantity = 158.00;
            Double Stock6_35_40SqIn_50Quantity = 162.00;
            //Color, 50 Quantity.
            Double Stock6Color_50Quantity = 60.00;

            //100 Quantity.
            Double Stock6_0_2_5SqIn_100Quantity = 144.00;
            Double Stock6_2_5_5SqIn_100Quantity = 144.00;
            Double Stock6_5_10SqIn_100Quantity = 153.00;
            Double Stock6_10_15SqIn_100Quantity = 159.00;
            Double Stock6_15_20SqIn_100Quantity = 164.00;
            Double Stock6_20_25SqIn_100Quantity = 170.00;
            Double Stock6_25_30SqIn_100Quantity = 171.00;
            Double Stock6_30_35SqIn_100Quantity = 181.00;
            Double Stock6_35_40SqIn_100Quantity = 189.00;
            //Color, 100 Quantity.
            Double Stock6Color_100Quantity = 65.00;

            //250 Quantity.
            Double Stock6_0_2_5SqIn_250Quantity = 159.00;
            Double Stock6_2_5_5SqIn_250Quantity = 160.00;
            Double Stock6_5_10SqIn_250Quantity = 178.00;
            Double Stock6_10_15SqIn_250Quantity = 193.00;
            Double Stock6_15_20SqIn_250Quantity = 205.00;
            Double Stock6_20_25SqIn_250Quantity = 226.00;
            Double Stock6_25_30SqIn_250Quantity = 227.00;
            Double Stock6_30_35SqIn_250Quantity = 249.00;
            Double Stock6_35_40SqIn_250Quantity = 267.00;
            //Color, 250 Quantity.
            Double Stock6Color_250Quantity = 75.00;

            //500 Quantity.
            Double Stock6_0_2_5SqIn_500Quantity = 189.00;
            Double Stock6_2_5_5SqIn_500Quantity = 190.00;
            Double Stock6_5_10SqIn_500Quantity = 224.00;
            Double Stock6_10_15SqIn_500Quantity = 252.00;
            Double Stock6_15_20SqIn_500Quantity = 273.00;
            Double Stock6_20_25SqIn_500Quantity = 350.00;
            Double Stock6_25_30SqIn_500Quantity = 309.00;
            Double Stock6_30_35SqIn_500Quantity = 311.00;
            Double Stock6_35_40SqIn_500Quantity = 377.00;
            //Color, 250 Quantity.
            Double Stock6Color_500Quantity = 80.00;

            //1000 Quantity.
            Double Stock6_0_2_5SqIn_1000Quantity = 227.00;
            Double Stock6_2_5_5SqIn_1000Quantity = 254.00;
            Double Stock6_5_10SqIn_1000Quantity = 329.00;
            Double Stock6_10_15SqIn_1000Quantity = 397.00;
            Double Stock6_15_20SqIn_1000Quantity = 402.00;
            Double Stock6_20_25SqIn_1000Quantity = 470.00;
            Double Stock6_25_30SqIn_1000Quantity = 474.00;
            Double Stock6_30_35SqIn_1000Quantity = 606.00;
            Double Stock6_35_40SqIn_1000Quantity = 610.00;
            //Color, 250 Quantity.
            Double Stock6Color_1000Quantity = 85.00;

            //2000 Quantity.
            Double Stock6_0_2_5SqIn_2000Quantity = 310.00;
            Double Stock6_2_5_5SqIn_2000Quantity = 253.00;
            Double Stock6_5_10SqIn_2000Quantity = 514.00;
            Double Stock6_10_15SqIn_2000Quantity = 650.00;
            Double Stock6_15_20SqIn_2000Quantity = 659.00;
            Double Stock6_20_25SqIn_2000Quantity = 795.00;
            Double Stock6_25_30SqIn_2000Quantity = 815.00;
            Double Stock6_30_35SqIn_2000Quantity = 991.00;
            Double Stock6_35_40SqIn_2000Quantity = 1120.00;
            //Color, 250 Quantity.
            Double Stock6Color_2000Quantity = 100.00;

            //2500 Quantity.
            Double Stock6_0_2_5SqIn_2500Quantity = 351.00;
            Double Stock6_2_5_5SqIn_2500Quantity = 320.00;
            Double Stock6_5_10SqIn_2500Quantity = 579.00;
            Double Stock6_10_15SqIn_2500Quantity = 739.00;
            Double Stock6_15_20SqIn_2500Quantity = 749.00;
            Double Stock6_20_25SqIn_2500Quantity = 945.00;
            Double Stock6_25_30SqIn_2500Quantity = 972.00;
            Double Stock6_30_35SqIn_2500Quantity = 1184.00;
            Double Stock6_35_40SqIn_2500Quantity = 1344.00;
            //Color, 250 Quantity.
            Double Stock6Color_2500Quantity = 115.00;

            //5000 Quantity.
            Double Stock6_0_2_5SqIn_5000Quantity = 557.00;
            Double Stock6_2_5_5SqIn_5000Quantity = 657.00;
            Double Stock6_5_10SqIn_5000Quantity = 903.00;
            Double Stock6_10_15SqIn_5000Quantity = 1185.00;
            Double Stock6_15_20SqIn_5000Quantity = 1196.00;
            Double Stock6_20_25SqIn_5000Quantity = 1694.00;
            Double Stock6_25_30SqIn_5000Quantity = 1758.00;
            Double Stock6_30_35SqIn_5000Quantity = 2146.00;
            Double Stock6_35_40SqIn_5000Quantity = 2463.00;
            //Color, 250 Quantity.
            Double Stock6Color_5000Quantity = 230.00;

            //10000 Quantity.
            Double Stock6_0_2_5SqIn_10000Quantity = 963.00;
            Double Stock6_2_5_5SqIn_10000Quantity = 1163.00;
            Double Stock6_5_10SqIn_10000Quantity = 1563.00;
            Double Stock6_10_15SqIn_10000Quantity = 2120.00;
            Double Stock6_15_20SqIn_10000Quantity = 2131.00;
            Double Stock6_20_25SqIn_10000Quantity = 3023.00;
            Double Stock6_25_30SqIn_10000Quantity = 3155.00;
            Double Stock6_30_35SqIn_10000Quantity = 3837.00;
            Double Stock6_35_40SqIn_10000Quantity = 4437.00;
            //Color, 250 Quantity.
            Double Stock6Color_10000Quantity = 360.00;

            //======================================================================================================
            //Stock 7 Pricing
            //======================================================================================================

            //50 Quantity.
            Double Stock7_0_2_5SqIn_50Quantity = 136.00;
            Double Stock7_2_5_5SqIn_50Quantity = 137.00;
            Double Stock7_5_10SqIn_50Quantity = 139.00;
            Double Stock7_10_15SqIn_50Quantity = 142.00;
            Double Stock7_15_20SqIn_50Quantity = 145.00;
            Double Stock7_20_25SqIn_50Quantity = 147.00;
            Double Stock7_25_30SqIn_50Quantity = 150.00;
            Double Stock7_30_35SqIn_50Quantity = 152.00;
            Double Stock7_35_40SqIn_50Quantity = 156.00;
            //Color, 50 Quantity.
            Double Stock7Color_50Quantity = 60.00;

            //100 Quantity.
            Double Stock7_0_2_5SqIn_100Quantity = 144.00;
            Double Stock7_2_5_5SqIn_100Quantity = 145.00;
            Double Stock7_5_10SqIn_100Quantity = 149.00;
            Double Stock7_10_15SqIn_100Quantity = 154.00;
            Double Stock7_15_20SqIn_100Quantity = 157.00;
            Double Stock7_20_25SqIn_100Quantity = 162.00;
            Double Stock7_25_30SqIn_100Quantity = 166.00;
            Double Stock7_30_35SqIn_100Quantity = 169.00;
            Double Stock7_35_40SqIn_100Quantity = 175.00;
            //Color, 100 Quantity.
            Double Stock7Color_100Quantity = 65.00;

            //250 Quantity.
            Double Stock7_0_2_5SqIn_250Quantity = 169.00;
            Double Stock7_2_5_5SqIn_250Quantity = 169.00;
            Double Stock7_5_10SqIn_250Quantity = 178.00;
            Double Stock7_10_15SqIn_250Quantity = 188.00;
            Double Stock7_15_20SqIn_250Quantity = 195.00;
            Double Stock7_20_25SqIn_250Quantity = 205.00;
            Double Stock7_25_30SqIn_250Quantity = 214.00;
            Double Stock7_30_35SqIn_250Quantity = 221.00;
            Double Stock7_35_40SqIn_250Quantity = 234.00;
            //Color, 250 Quantity.
            Double Stock7Color_250Quantity = 75.00;

            //500 Quantity.
            Double Stock7_0_2_5SqIn_500Quantity = 183.00;
            Double Stock7_2_5_5SqIn_500Quantity = 190.00;
            Double Stock7_5_10SqIn_500Quantity = 207.00;
            Double Stock7_10_15SqIn_500Quantity = 227.00;
            Double Stock7_15_20SqIn_500Quantity = 242.00;
            Double Stock7_20_25SqIn_500Quantity = 294.00;
            Double Stock7_25_30SqIn_500Quantity = 267.00;
            Double Stock7_30_35SqIn_500Quantity = 298.00;
            Double Stock7_35_40SqIn_500Quantity = 314.00;
            //Color, 250 Quantity.
            Double Stock7Color_500Quantity = 80.00;

            //1000 Quantity.
            Double Stock7_0_2_5SqIn_1000Quantity = 217.00;
            Double Stock7_2_5_5SqIn_1000Quantity = 231.00;
            Double Stock7_5_10SqIn_1000Quantity = 387.00;
            Double Stock7_10_15SqIn_1000Quantity = 320.00;
            Double Stock7_15_20SqIn_1000Quantity = 339.00;
            Double Stock7_20_25SqIn_1000Quantity = 386.00;
            Double Stock7_25_30SqIn_1000Quantity = 390.00;
            Double Stock7_30_35SqIn_1000Quantity = 479.00;
            Double Stock7_35_40SqIn_1000Quantity = 484.00;
            //Color, 250 Quantity.
            Double Stock7Color_1000Quantity = 85.00;

            //2000 Quantity.
            Double Stock7_0_2_5SqIn_2000Quantity = 289.00;
            Double Stock7_2_5_5SqIn_2000Quantity = 319.00;
            Double Stock7_5_10SqIn_2000Quantity = 406.00;
            Double Stock7_10_15SqIn_2000Quantity = 473.00;
            Double Stock7_15_20SqIn_2000Quantity = 533.00;
            Double Stock7_20_25SqIn_2000Quantity = 627.00;
            Double Stock7_25_30SqIn_2000Quantity = 647.00;
            Double Stock7_30_35SqIn_2000Quantity = 767.00;
            Double Stock7_35_40SqIn_2000Quantity = 868.00;
            //Color, 250 Quantity.
            Double Stock7Color_2000Quantity = 100.00;

            //2500 Quantity.
            Double Stock7_0_2_5SqIn_2500Quantity = 324.00;
            Double Stock7_2_5_5SqIn_2500Quantity = 360.00;
            Double Stock7_5_10SqIn_2500Quantity = 464.00;
            Double Stock7_10_15SqIn_2500Quantity = 554.00;
            Double Stock7_15_20SqIn_2500Quantity = 631.00;
            Double Stock7_20_25SqIn_2500Quantity = 742.00;
            Double Stock7_25_30SqIn_2500Quantity = 769.00;
            Double Stock7_30_35SqIn_2500Quantity = 913.00;
            Double Stock7_35_40SqIn_2500Quantity = 1039.00;
            //Color, 250 Quantity.
            Double Stock7Color_2500Quantity = 115.00;

            //5000 Quantity.
            Double Stock7_0_2_5SqIn_5000Quantity = 497.00;
            Double Stock7_2_5_5SqIn_5000Quantity = 565.00;
            Double Stock7_5_10SqIn_5000Quantity = 752.00;
            Double Stock7_10_15SqIn_5000Quantity = 959.00;
            Double Stock7_15_20SqIn_5000Quantity = 1123.00;
            Double Stock7_20_25SqIn_5000Quantity = 1317.00;
            Double Stock7_25_30SqIn_5000Quantity = 1381.00;
            Double Stock7_30_35SqIn_5000Quantity = 1642.00;
            Double Stock7_35_40SqIn_5000Quantity = 1896.00;
            //Color, 250 Quantity.
            Double Stock7Color_5000Quantity = 230.00;

            //10000 Quantity.
            Double Stock7_0_2_5SqIn_10000Quantity = 858.00;
            Double Stock7_2_5_5SqIn_10000Quantity = 1002.00;
            Double Stock7_5_10SqIn_10000Quantity = 1296.00;
            Double Stock7_10_15SqIn_10000Quantity = 1719.00;
            Double Stock7_15_20SqIn_10000Quantity = 2001.00;
            Double Stock7_20_25SqIn_10000Quantity = 2355.00;
            Double Stock7_25_30SqIn_10000Quantity = 2487.00;
            Double Stock7_30_35SqIn_10000Quantity = 2946.00;
            Double Stock7_35_40SqIn_10000Quantity = 3435.00;
            //Color, 250 Quantity.
            Double Stock7Color_10000Quantity = 360.00;

            //======================================================================================================
            //Stock 8 Pricing
            //======================================================================================================

            //50 Quantity.
            Double Stock8_0_2_5SqIn_50Quantity = 136.00;
            Double Stock8_2_5_5SqIn_50Quantity = 137.00;
            Double Stock8_5_10SqIn_50Quantity = 140.00;
            Double Stock8_10_15SqIn_50Quantity = 143.00;
            Double Stock8_15_20SqIn_50Quantity = 145.00;
            Double Stock8_20_25SqIn_50Quantity = 148.00;
            Double Stock8_25_30SqIn_50Quantity = 151.00;
            Double Stock8_30_35SqIn_50Quantity = 154.00;
            Double Stock8_35_40SqIn_50Quantity = 157.00;
            //Color, 50 Quantity.
            Double Stock8Color_50Quantity = 60.00;

            //100 Quantity.
            Double Stock8_0_2_5SqIn_100Quantity = 145.00;
            Double Stock8_2_5_5SqIn_100Quantity = 145.00;
            Double Stock8_5_10SqIn_100Quantity = 150.00;
            Double Stock8_10_15SqIn_100Quantity = 155.00;
            Double Stock8_15_20SqIn_100Quantity = 159.00;
            Double Stock8_20_25SqIn_100Quantity = 164.00;
            Double Stock8_25_30SqIn_100Quantity = 169.00;
            Double Stock8_30_35SqIn_100Quantity = 172.00;
            Double Stock8_35_40SqIn_100Quantity = 179.00;
            //Color, 100 Quantity.
            Double Stock8Color_100Quantity = 65.00;

            //250 Quantity.
            Double Stock8_0_2_5SqIn_250Quantity = 170.00;
            Double Stock8_2_5_5SqIn_250Quantity = 171.00;
            Double Stock8_5_10SqIn_250Quantity = 180.00;
            Double Stock8_10_15SqIn_250Quantity = 192.00;
            Double Stock8_15_20SqIn_250Quantity = 199.00;
            Double Stock8_20_25SqIn_250Quantity = 210.00;
            Double Stock8_25_30SqIn_250Quantity = 221.00;
            Double Stock8_30_35SqIn_250Quantity = 228.00;
            Double Stock8_35_40SqIn_250Quantity = 242.00;
            //Color, 250 Quantity.
            Double Stock8Color_250Quantity = 75.00;

            //500 Quantity.
            Double Stock8_0_2_5SqIn_500Quantity = 184.00;
            Double Stock8_2_5_5SqIn_500Quantity = 192.00;
            Double Stock8_5_10SqIn_500Quantity = 212.00;
            Double Stock8_10_15SqIn_500Quantity = 233.00;
            Double Stock8_15_20SqIn_500Quantity = 250.00;
            Double Stock8_20_25SqIn_500Quantity = 276.00;
            Double Stock8_25_30SqIn_500Quantity = 278.00;
            Double Stock8_30_35SqIn_500Quantity = 312.00;
            Double Stock8_35_40SqIn_500Quantity = 330.00;
            //Color, 250 Quantity.
            Double Stock8Color_500Quantity = 80.00;

            //1000 Quantity.
            Double Stock8_0_2_5SqIn_1000Quantity = 223.00;
            Double Stock8_2_5_5SqIn_1000Quantity = 240.00;
            Double Stock8_5_10SqIn_1000Quantity = 298.00;
            Double Stock8_10_15SqIn_1000Quantity = 334.00;
            Double Stock8_15_20SqIn_1000Quantity = 355.00;
            Double Stock8_20_25SqIn_1000Quantity = 407.00;
            Double Stock8_25_30SqIn_1000Quantity = 411.00;
            Double Stock8_30_35SqIn_1000Quantity = 511.00;
            Double Stock8_35_40SqIn_1000Quantity = 516.00;
            //Color, 250 Quantity.
            Double Stock8Color_1000Quantity = 85.00;

            //2000 Quantity.
            Double Stock8_0_2_5SqIn_2000Quantity = 294.00;
            Double Stock8_2_5_5SqIn_2000Quantity = 327.00;
            Double Stock8_5_10SqIn_2000Quantity = 452.00;
            Double Stock8_10_15SqIn_2000Quantity = 498.00;
            Double Stock8_15_20SqIn_2000Quantity = 565.00;
            Double Stock8_20_25SqIn_2000Quantity = 669.00;
            Double Stock8_25_30SqIn_2000Quantity = 689.00;
            Double Stock8_30_35SqIn_2000Quantity = 824.00;
            Double Stock8_35_40SqIn_2000Quantity = 932.00;
            //Color, 250 Quantity.
            Double Stock8Color_2000Quantity = 100.00;

            //2500 Quantity.
            Double Stock8_0_2_5SqIn_2500Quantity = 330.00;
            Double Stock8_2_5_5SqIn_2500Quantity = 370.00;
            Double Stock8_5_10SqIn_2500Quantity = 508.00;
            Double Stock8_10_15SqIn_2500Quantity = 584.00;
            Double Stock8_15_20SqIn_2500Quantity = 671.00;
            Double Stock8_20_25SqIn_2500Quantity = 793.00;
            Double Stock8_25_30SqIn_2500Quantity = 820.00;
            Double Stock8_30_35SqIn_2500Quantity = 982.00;
            Double Stock8_35_40SqIn_2500Quantity = 1117.00;
            //Color, 250 Quantity.
            Double Stock8Color_2500Quantity = 115.00;

            //5000 Quantity.
            Double Stock8_0_2_5SqIn_5000Quantity = 512.00;
            Double Stock8_2_5_5SqIn_5000Quantity = 582.00;
            Double Stock8_5_10SqIn_5000Quantity = 790.00;
            Double Stock8_10_15SqIn_5000Quantity = 1016.00;
            Double Stock8_15_20SqIn_5000Quantity = 1199.00;
            Double Stock8_20_25SqIn_5000Quantity = 1412.00;
            Double Stock8_25_30SqIn_5000Quantity = 1476.00;
            Double Stock8_30_35SqIn_5000Quantity = 1770.00;
            Double Stock8_35_40SqIn_5000Quantity = 2039.00;
            //Color, 250 Quantity.
            Double Stock8Color_5000Quantity = 230.00;

            //10000 Quantity.
            Double Stock8_0_2_5SqIn_10000Quantity = 872.00;
            Double Stock8_2_5_5SqIn_10000Quantity = 1036.00;
            Double Stock8_5_10SqIn_10000Quantity = 1363.00;
            Double Stock8_10_15SqIn_10000Quantity = 1821.00;
            Double Stock8_15_20SqIn_10000Quantity = 2136.00;
            Double Stock8_20_25SqIn_10000Quantity = 2523.00;
            Double Stock8_25_30SqIn_10000Quantity = 2656.00;
            Double Stock8_30_35SqIn_10000Quantity = 3171.00;
            Double Stock8_35_40SqIn_10000Quantity = 3688.00;
            //Color, 250 Quantity.
            Double Stock8Color_10000Quantity = 360.00;

            //======================================================================================================
            //Stock 9 Pricing
            //======================================================================================================

            //50 Quantity.
            Double Stock9_0_2_5SqIn_50Quantity = 135.00;
            Double Stock9_2_5_5SqIn_50Quantity = 135.00;
            Double Stock9_5_10SqIn_50Quantity = 138.00;
            Double Stock9_10_15SqIn_50Quantity = 141.00;
            Double Stock9_15_20SqIn_50Quantity = 143.00;
            Double Stock9_20_25SqIn_50Quantity = 145.00;
            Double Stock9_25_30SqIn_50Quantity = 146.00;
            Double Stock9_30_35SqIn_50Quantity = 147.00;
            Double Stock9_35_40SqIn_50Quantity = 152.00;
            //Color, 50 Quantity.
            Double Stock9Color_50Quantity = 60.00;

            //100 Quantity.
            Double Stock9_0_2_5SqIn_100Quantity = 142.00;
            Double Stock9_2_5_5SqIn_100Quantity = 142.00;
            Double Stock9_5_10SqIn_100Quantity = 147.00;
            Double Stock9_10_15SqIn_100Quantity = 151.00;
            Double Stock9_15_20SqIn_100Quantity = 154.00;
            Double Stock9_20_25SqIn_100Quantity = 157.00;
            Double Stock9_25_30SqIn_100Quantity = 159.00;
            Double Stock9_30_35SqIn_100Quantity = 160.00;
            Double Stock9_35_40SqIn_100Quantity = 168.00;
            //Color, 100 Quantity.
            Double Stock9Color_100Quantity = 65.00;

            //250 Quantity.
            Double Stock9_0_2_5SqIn_250Quantity = 154.00;
            Double Stock9_2_5_5SqIn_250Quantity = 155.00;
            Double Stock9_5_10SqIn_250Quantity = 166.00;
            Double Stock9_10_15SqIn_250Quantity = 174.00;
            Double Stock9_15_20SqIn_250Quantity = 181.00;
            Double Stock9_20_25SqIn_250Quantity = 194.00;
            Double Stock9_25_30SqIn_250Quantity = 195.00;
            Double Stock9_30_35SqIn_250Quantity = 196.00;
            Double Stock9_35_40SqIn_250Quantity = 217.00;
            //Color, 250 Quantity.
            Double Stock9Color_250Quantity = 75.00;

            //500 Quantity.
            Double Stock9_0_2_5SqIn_500Quantity = 180.00;
            Double Stock9_2_5_5SqIn_500Quantity = 181.00;
            Double Stock9_5_10SqIn_500Quantity = 199.00;
            Double Stock9_10_15SqIn_500Quantity = 214.00;
            Double Stock9_15_20SqIn_500Quantity = 226.00;
            Double Stock9_20_25SqIn_500Quantity = 244.00;
            Double Stock9_25_30SqIn_500Quantity = 246.00;
            Double Stock9_30_35SqIn_500Quantity = 248.00;
            Double Stock9_35_40SqIn_500Quantity = 283.00;
            //Color, 250 Quantity.
            Double Stock9Color_500Quantity = 80.00;

            //1000 Quantity.
            Double Stock9_0_2_5SqIn_1000Quantity = 211.00;
            Double Stock9_2_5_5SqIn_1000Quantity = 226.00;
            Double Stock9_5_10SqIn_1000Quantity = 267.00;
            Double Stock9_10_15SqIn_1000Quantity = 303.00;
            Double Stock9_15_20SqIn_1000Quantity = 307.00;
            Double Stock9_20_25SqIn_1000Quantity = 344.00;
            Double Stock9_25_30SqIn_1000Quantity = 348.00;
            Double Stock9_30_35SqIn_1000Quantity = 417.00;
            Double Stock9_35_40SqIn_1000Quantity = 421.00;
            //Color, 250 Quantity.
            Double Stock9Color_1000Quantity = 85.00;

            //2000 Quantity.
            Double Stock9_0_2_5SqIn_2000Quantity = 278.00;
            Double Stock9_2_5_5SqIn_2000Quantity = 302.00;
            Double Stock9_5_10SqIn_2000Quantity = 389.00;
            Double Stock9_10_15SqIn_2000Quantity = 462.00;
            Double Stock9_15_20SqIn_2000Quantity = 470.00;
            Double Stock9_20_25SqIn_2000Quantity = 543.00;
            Double Stock9_25_30SqIn_2000Quantity = 563.00;
            Double Stock9_30_35SqIn_2000Quantity = 656.00;
            Double Stock9_35_40SqIn_2000Quantity = 743.00;
            //Color, 250 Quantity.
            Double Stock9Color_2000Quantity = 100.00;

            //2500 Quantity.
            Double Stock9_0_2_5SqIn_2500Quantity = 313.00;
            Double Stock9_2_5_5SqIn_2500Quantity = 342.00;
            Double Stock9_5_10SqIn_2500Quantity = 437.00;
            Double Stock9_10_15SqIn_2500Quantity = 526.00;
            Double Stock9_15_20SqIn_2500Quantity = 535.00;
            Double Stock9_20_25SqIn_2500Quantity = 641.00;
            Double Stock9_25_30SqIn_2500Quantity = 668.00;
            Double Stock9_30_35SqIn_2500Quantity = 779.00;
            Double Stock9_35_40SqIn_2500Quantity = 889.00;
            //Color, 250 Quantity.
            Double Stock9Color_2500Quantity = 115.00;

            //5000 Quantity.
            Double Stock9_0_2_5SqIn_5000Quantity = 490.00;
            Double Stock9_2_5_5SqIn_5000Quantity = 544.00;
            Double Stock9_5_10SqIn_5000Quantity = 677.00;
            Double Stock9_10_15SqIn_5000Quantity = 847.00;
            Double Stock9_15_20SqIn_5000Quantity = 857.00;
            Double Stock9_20_25SqIn_5000Quantity = 1130.00;
            Double Stock9_25_30SqIn_5000Quantity = 1194.00;
            Double Stock9_30_35SqIn_5000Quantity = 1393.00;
            Double Stock9_35_40SqIn_5000Quantity = 1616.00;
            //Color, 250 Quantity.
            Double Stock9Color_5000Quantity = 230.00;

            //10000 Quantity.
            Double Stock9_0_2_5SqIn_10000Quantity = 843.00;
            Double Stock9_2_5_5SqIn_10000Quantity = 936.00;
            Double Stock9_5_10SqIn_10000Quantity = 1164.00;
            Double Stock9_10_15SqIn_10000Quantity = 1521.00;
            Double Stock9_15_20SqIn_10000Quantity = 1532.00;
            Double Stock9_20_25SqIn_10000Quantity = 2024.00;
            Double Stock9_25_30SqIn_10000Quantity = 2156.00;
            Double Stock9_30_35SqIn_10000Quantity = 2505.00;
            Double Stock9_35_40SqIn_10000Quantity = 2939.00;
            //Color, 250 Quantity.
            Double Stock9Color_10000Quantity = 360.00;

            //======================================================================================================
            //Stock 10 Pricing
            //======================================================================================================

            //50 Quantity.
            Double Stock10_0_2_5SqIn_50Quantity = 135.00;
            Double Stock10_2_5_5SqIn_50Quantity = 135.00;
            Double Stock10_5_10SqIn_50Quantity = 139.00;
            Double Stock10_10_15SqIn_50Quantity = 141.00;
            Double Stock10_15_20SqIn_50Quantity = 143.00;
            Double Stock10_20_25SqIn_50Quantity = 145.00;
            Double Stock10_25_30SqIn_50Quantity = 146.00;
            Double Stock10_30_35SqIn_50Quantity = 150.00;
            Double Stock10_35_40SqIn_50Quantity = 153.00;
            //Color, 50 Quantity.
            Double Stock10Color_50Quantity = 60.00;

            //100 Quantity.
            Double Stock10_0_2_5SqIn_100Quantity = 142.00;
            Double Stock10_2_5_5SqIn_100Quantity = 142.00;
            Double Stock10_5_10SqIn_100Quantity = 147.00;
            Double Stock10_10_15SqIn_100Quantity = 151.00;
            Double Stock10_15_20SqIn_100Quantity = 154.00;
            Double Stock10_20_25SqIn_100Quantity = 158.00;
            Double Stock10_25_30SqIn_100Quantity = 159.00;
            Double Stock10_30_35SqIn_100Quantity = 164.00;
            Double Stock10_35_40SqIn_100Quantity = 169.00;
            //Color, 100 Quantity.
            Double Stock10Color_100Quantity = 65.00;

            //250 Quantity.
            Double Stock10_0_2_5SqIn_250Quantity = 154.00;
            Double Stock10_2_5_5SqIn_250Quantity = 155.00;
            Double Stock10_5_10SqIn_250Quantity = 166.00;
            Double Stock10_10_15SqIn_250Quantity = 175.00;
            Double Stock10_15_20SqIn_250Quantity = 182.00;
            Double Stock10_20_25SqIn_250Quantity = 192.00;
            Double Stock10_25_30SqIn_250Quantity = 196.00;
            Double Stock10_30_35SqIn_250Quantity = 208.00;
            Double Stock10_35_40SqIn_250Quantity = 218.00;
            //Color, 250 Quantity.
            Double Stock10Color_250Quantity = 75.00;

            //500 Quantity.
            Double Stock10_0_2_5SqIn_500Quantity = 180.00;
            Double Stock10_2_5_5SqIn_500Quantity = 181.00;
            Double Stock10_5_10SqIn_500Quantity = 200.00;
            Double Stock10_10_15SqIn_500Quantity = 215.00;
            Double Stock10_15_20SqIn_500Quantity = 227.00;
            Double Stock10_20_25SqIn_500Quantity = 238.00;
            Double Stock10_25_30SqIn_500Quantity = 248.00;
            Double Stock10_30_35SqIn_500Quantity = 250.00;
            Double Stock10_35_40SqIn_500Quantity = 285.00;
            //Color, 250 Quantity.
            Double Stock10Color_500Quantity = 80.00;

            //1000 Quantity.
            Double Stock10_0_2_5SqIn_1000Quantity = 212.00;
            Double Stock10_2_5_5SqIn_1000Quantity = 227.00;
            Double Stock10_5_10SqIn_1000Quantity = 268.00;
            Double Stock10_10_15SqIn_1000Quantity = 306.00;
            Double Stock10_15_20SqIn_1000Quantity = 310.00;
            Double Stock10_20_25SqIn_1000Quantity = 347.00;
            Double Stock10_25_30SqIn_1000Quantity = 352.00;
            Double Stock10_30_35SqIn_1000Quantity = 422.00;
            Double Stock10_35_40SqIn_1000Quantity = 426.00;

            //Color, 250 Quantity.
            Double Stock10Color_1000Quantity = 85.00;

            //2000 Quantity.
            Double Stock10_0_2_5SqIn_2000Quantity = 279.00;
            Double Stock10_2_5_5SqIn_2000Quantity = 304.00;
            Double Stock10_5_10SqIn_2000Quantity = 396.00;
            Double Stock10_10_15SqIn_2000Quantity = 467.00;
            Double Stock10_15_20SqIn_2000Quantity = 475.00;
            Double Stock10_20_25SqIn_2000Quantity = 550.00;
            Double Stock10_25_30SqIn_2000Quantity = 570.00;
            Double Stock10_30_35SqIn_2000Quantity = 665.00;
            Double Stock10_35_40SqIn_2000Quantity = 754.00;
            //Color, 250 Quantity.
            Double Stock10Color_2000Quantity = 100.00;

            //2500 Quantity.
            Double Stock10_0_2_5SqIn_2500Quantity = 313.00;
            Double Stock10_2_5_5SqIn_2500Quantity = 320.00;
            Double Stock10_5_10SqIn_2500Quantity = 441.00;
            Double Stock10_10_15SqIn_2500Quantity = 532.00;
            Double Stock10_15_20SqIn_2500Quantity = 540.00;
            Double Stock10_20_25SqIn_2500Quantity = 649.00;
            Double Stock10_25_30SqIn_2500Quantity = 677.00;
            Double Stock10_30_35SqIn_2500Quantity = 790.00;
            Double Stock10_35_40SqIn_2500Quantity = 902.00;
            //Color, 250 Quantity.
            Double Stock10Color_2500Quantity = 115.00;

            //5000 Quantity.
            Double Stock10_0_2_5SqIn_5000Quantity = 480.00;
            Double Stock10_2_5_5SqIn_5000Quantity = 547.00;
            Double Stock10_5_10SqIn_5000Quantity = 683.00;
            Double Stock10_10_15SqIn_5000Quantity = 856.00;
            Double Stock10_15_20SqIn_5000Quantity = 867.00;
            Double Stock10_20_25SqIn_5000Quantity = 1145.00;
            Double Stock10_25_30SqIn_5000Quantity = 1209.00;
            Double Stock10_30_35SqIn_5000Quantity = 1414.00;
            Double Stock10_35_40SqIn_5000Quantity = 1639.00;
            //Color, 250 Quantity.
            Double Stock10Color_5000Quantity = 230.00;

            //10000 Quantity.
            Double Stock10_0_2_5SqIn_10000Quantity = 825.00;
            Double Stock10_2_5_5SqIn_10000Quantity = 942.00;
            Double Stock10_5_10SqIn_10000Quantity = 1174.00;
            Double Stock10_10_15SqIn_10000Quantity = 1537.00;
            Double Stock10_15_20SqIn_10000Quantity = 1548.00;
            Double Stock10_20_25SqIn_10000Quantity = 2051.00;
            Double Stock10_25_30SqIn_10000Quantity = 2183.00;
            Double Stock10_30_35SqIn_10000Quantity = 2541.00;
            Double Stock10_35_40SqIn_10000Quantity = 2979.00;
            //Color, 250 Quantity.
            Double Stock10Color_10000Quantity = 360.00;

            //======================================================================================================
            //Stock 11 Pricing
            //======================================================================================================

            //50 Quantity.
            Double Stock11_0_2_5SqIn_50Quantity = 136.00;
            Double Stock11_2_5_5SqIn_50Quantity = 137.00;
            Double Stock11_5_10SqIn_50Quantity = 139.00;
            Double Stock11_10_15SqIn_50Quantity = 143.00;
            Double Stock11_15_20SqIn_50Quantity = 145.00;
            Double Stock11_20_25SqIn_50Quantity = 148.00;
            Double Stock11_25_30SqIn_50Quantity = 150.00;
            Double Stock11_30_35SqIn_50Quantity = 153.00;
            Double Stock11_35_40SqIn_50Quantity = 156.00;
            //Color, 50 Quantity.
            Double Stock11Color_50Quantity = 60.00;

            //100 Quantity.
            Double Stock11_0_2_5SqIn_100Quantity = 144.00;
            Double Stock11_2_5_5SqIn_100Quantity = 145.00;
            Double Stock11_5_10SqIn_100Quantity = 149.00;
            Double Stock11_10_15SqIn_100Quantity = 154.00;
            Double Stock11_15_20SqIn_100Quantity = 158.00;
            Double Stock11_20_25SqIn_100Quantity = 162.00;
            Double Stock11_25_30SqIn_100Quantity = 167.00;
            Double Stock11_30_35SqIn_100Quantity = 170.00;
            Double Stock11_35_40SqIn_100Quantity = 176.00;
            //Color, 100 Quantity.
            Double Stock11Color_100Quantity = 65.00;

            //250 Quantity.
            Double Stock11_0_2_5SqIn_250Quantity = 169.00;
            Double Stock11_2_5_5SqIn_250Quantity = 170.00;
            Double Stock11_5_10SqIn_250Quantity = 178.00;
            Double Stock11_10_15SqIn_250Quantity = 189.00;
            Double Stock11_15_20SqIn_250Quantity = 196.00;
            Double Stock11_20_25SqIn_250Quantity = 206.00;
            Double Stock11_25_30SqIn_250Quantity = 216.00;
            Double Stock11_30_35SqIn_250Quantity = 223.00;
            Double Stock11_35_40SqIn_250Quantity = 236.00;
            //Color, 250 Quantity.
            Double Stock11Color_250Quantity = 75.00;

            //500 Quantity.
            Double Stock11_0_2_5SqIn_500Quantity = 183.00;
            Double Stock11_2_5_5SqIn_500Quantity = 191.00;
            Double Stock11_5_10SqIn_500Quantity = 207.00;
            Double Stock11_10_15SqIn_500Quantity = 228.00;
            Double Stock11_15_20SqIn_500Quantity = 244.00;
            Double Stock11_20_25SqIn_500Quantity = 268.00;
            Double Stock11_25_30SqIn_500Quantity = 270.00;
            Double Stock11_30_35SqIn_500Quantity = 302.00;
            Double Stock11_35_40SqIn_500Quantity = 319.00;
            //Color, 250 Quantity.
            Double Stock11Color_500Quantity = 80.00;

            //1000 Quantity.
            Double Stock11_0_2_5SqIn_1000Quantity = 221.00;
            Double Stock11_2_5_5SqIn_1000Quantity = 237.00;
            Double Stock11_5_10SqIn_1000Quantity = 290.00;
            Double Stock11_10_15SqIn_1000Quantity = 324.00;
            Double Stock11_15_20SqIn_1000Quantity = 343.00;
            Double Stock11_20_25SqIn_1000Quantity = 391.00;
            Double Stock11_25_30SqIn_1000Quantity = 396.00;
            Double Stock11_30_35SqIn_1000Quantity = 488.00;
            Double Stock11_35_40SqIn_1000Quantity = 493.00;
            //Color, 250 Quantity.
            Double Stock11Color_1000Quantity = 85.00;

            //2000 Quantity.
            Double Stock11_0_2_5SqIn_2000Quantity = 290.00;
            Double Stock11_2_5_5SqIn_2000Quantity = 321.00;
            Double Stock11_5_10SqIn_2000Quantity = 411.00;
            Double Stock11_10_15SqIn_2000Quantity = 480.00;
            Double Stock11_15_20SqIn_2000Quantity = 542.00;
            Double Stock11_20_25SqIn_2000Quantity = 638.00;
            Double Stock11_25_30SqIn_2000Quantity = 658.00;
            Double Stock11_30_35SqIn_2000Quantity = 783.00;
            Double Stock11_35_40SqIn_2000Quantity = 841.00;
            //Color, 250 Quantity.
            Double Stock11Color_2000Quantity = 100.00;

            //2500 Quantity.
            Double Stock11_0_2_5SqIn_2500Quantity = 325.00;
            Double Stock11_2_5_5SqIn_2500Quantity = 362.00;
            Double Stock11_5_10SqIn_2500Quantity = 470.00;
            Double Stock11_10_15SqIn_2500Quantity = 563.00;
            Double Stock11_15_20SqIn_2500Quantity = 642.00;
            Double Stock11_20_25SqIn_2500Quantity = 756.00;
            Double Stock11_25_30SqIn_2500Quantity = 783.00;
            Double Stock11_30_35SqIn_2500Quantity = 932.00;
            Double Stock11_35_40SqIn_2500Quantity = 995.00;
            //Color, 250 Quantity.
            Double Stock11Color_2500Quantity = 115.00;

            //5000 Quantity.
            Double Stock11_0_2_5SqIn_5000Quantity = 499.00;
            Double Stock11_2_5_5SqIn_5000Quantity = 569.00;
            Double Stock11_5_10SqIn_5000Quantity = 762.00;
            Double Stock11_10_15SqIn_5000Quantity = 972.00;
            Double Stock11_15_20SqIn_5000Quantity = 1144.00;
            Double Stock11_20_25SqIn_5000Quantity = 1343.00;
            Double Stock11_25_30SqIn_5000Quantity = 1407.00;
            Double Stock11_30_35SqIn_5000Quantity = 1678.00;
            Double Stock11_35_40SqIn_5000Quantity = 1766.00;
            //Color, 250 Quantity.
            Double Stock11Color_5000Quantity = 230.00;

            //10000 Quantity.
            Double Stock11_0_2_5SqIn_10000Quantity = 860.00;
            Double Stock11_2_5_5SqIn_10000Quantity = 1012.00;
            Double Stock11_5_10SqIn_10000Quantity = 1315.00;
            Double Stock11_10_15SqIn_10000Quantity = 1148.00;
            Double Stock11_15_20SqIn_10000Quantity = 2039.00;
            Double Stock11_20_25SqIn_10000Quantity = 2402.00;
            Double Stock11_25_30SqIn_10000Quantity = 2534.00;
            Double Stock11_30_35SqIn_10000Quantity = 3009.00;
            Double Stock11_35_40SqIn_10000Quantity = 3506.00;
            //Color, 250 Quantity.
            Double Stock11Color_10000Quantity = 360.00;

            //======================================================================================================
            //Stock 13 Pricing
            //======================================================================================================

            //50 Quantity.
            Double Stock13_0_2_5SqIn_50Quantity = 141.00;
            Double Stock13_2_5_5SqIn_50Quantity = 142.00;
            Double Stock13_5_10SqIn_50Quantity = 147.00;
            Double Stock13_10_15SqIn_50Quantity = 152.00;
            Double Stock13_15_20SqIn_50Quantity = 158.00;
            Double Stock13_20_25SqIn_50Quantity = 162.00;
            Double Stock13_25_30SqIn_50Quantity = 168.00;
            Double Stock13_30_35SqIn_50Quantity = 172.00;
            Double Stock13_35_40SqIn_50Quantity = 182.00;
            //Color, 50 Quantity.
            Double Stock13Color_50Quantity = 60.00;

            //100 Quantity.
            Double Stock13_0_2_5SqIn_100Quantity = 154.00;
            Double Stock13_2_5_5SqIn_100Quantity = 154.00;
            Double Stock13_5_10SqIn_100Quantity = 165.00;
            Double Stock13_10_15SqIn_100Quantity = 174.00;
            Double Stock13_15_20SqIn_100Quantity = 184.00;
            Double Stock13_20_25SqIn_100Quantity = 192.00;
            Double Stock13_25_30SqIn_100Quantity = 202.00;
            Double Stock13_30_35SqIn_100Quantity = 209.00;
            Double Stock13_35_40SqIn_100Quantity = 229.00;
            //Color, 100 Quantity.
            Double Stock13Color_100Quantity = 65.00;

            //250 Quantity.
            Double Stock13_0_2_5SqIn_250Quantity = 193.00;
            Double Stock13_2_5_5SqIn_250Quantity = 193.00;
            Double Stock13_5_10SqIn_250Quantity = 218.00;
            Double Stock13_10_15SqIn_250Quantity = 239.00;
            Double Stock13_15_20SqIn_250Quantity = 262.00;
            Double Stock13_20_25SqIn_250Quantity = 280.00;
            Double Stock13_25_30SqIn_250Quantity = 305.00;
            Double Stock13_30_35SqIn_250Quantity = 322.00;
            Double Stock13_35_40SqIn_250Quantity = 368.00;
            //Color, 250 Quantity.
            Double Stock13Color_250Quantity = 75.00;

            //500 Quantity.
            Double Stock13_0_2_5SqIn_500Quantity = 210.00;
            Double Stock13_2_5_5SqIn_500Quantity = 242.00;
            Double Stock13_5_10SqIn_500Quantity = 291.00;
            Double Stock13_10_15SqIn_500Quantity = 317.00;
            Double Stock13_15_20SqIn_500Quantity = 356.00;
            Double Stock13_20_25SqIn_500Quantity = 416.00;
            Double Stock13_25_30SqIn_500Quantity = 465.00;
            Double Stock13_30_35SqIn_500Quantity = 499.00;
            Double Stock13_35_40SqIn_500Quantity = 540.00;
            //Color, 250 Quantity.
            Double Stock13Color_500Quantity = 80.00;

            //1000 Quantity.
            Double Stock13_0_2_5SqIn_1000Quantity = 276.00;
            Double Stock13_2_5_5SqIn_1000Quantity = 339.00;
            Double Stock13_5_10SqIn_1000Quantity = 438.00;
            Double Stock13_10_15SqIn_1000Quantity = 490.00;
            Double Stock13_15_20SqIn_1000Quantity = 565.00;
            Double Stock13_20_25SqIn_1000Quantity = 687.00;
            Double Stock13_25_30SqIn_1000Quantity = 786.00;
            Double Stock13_30_35SqIn_1000Quantity = 932.00;
            Double Stock13_35_40SqIn_1000Quantity = 936.00;
            //Color, 250 Quantity.
            Double Stock13Color_1000Quantity = 85.00;

            //2000 Quantity.
            Double Stock13_0_2_5SqIn_2000Quantity = 375.00;
            Double Stock13_2_5_5SqIn_2000Quantity = 487.00;
            Double Stock13_5_10SqIn_2000Quantity = 732.00;
            Double Stock13_10_15SqIn_2000Quantity = 835.00;
            Double Stock13_15_20SqIn_2000Quantity = 985.00;
            Double Stock13_20_25SqIn_2000Quantity = 1230.00;
            Double Stock13_25_30SqIn_2000Quantity = 1565.00;
            Double Stock13_30_35SqIn_2000Quantity = 1572.00;
            Double Stock13_35_40SqIn_2000Quantity = 1773.00;
            //Color, 250 Quantity.
            Double Stock13Color_2000Quantity = 100.00;

            //2500 Quantity.
            Double Stock13_0_2_5SqIn_2500Quantity = 430.00;
            Double Stock13_2_5_5SqIn_2500Quantity = 548.00;
            Double Stock13_5_10SqIn_2500Quantity = 874.00;
            Double Stock13_10_15SqIn_2500Quantity = 991.00;
            Double Stock13_15_20SqIn_2500Quantity = 1188.00;
            Double Stock13_20_25SqIn_2500Quantity = 1470.00;
            Double Stock13_25_30SqIn_2500Quantity = 1878.00;
            Double Stock13_30_35SqIn_2500Quantity = 1885.00;
            Double Stock13_35_40SqIn_2500Quantity = 2132.00;
            //Color, 250 Quantity.
            Double Stock13Color_2500Quantity = 115.00;

            //5000 Quantity.
            Double Stock13_0_2_5SqIn_5000Quantity = 703.00;
            Double Stock13_2_5_5SqIn_5000Quantity = 852.00;
            Double Stock13_5_10SqIn_5000Quantity = 1585.00;
            Double Stock13_10_15SqIn_5000Quantity = 1771.00;
            Double Stock13_15_20SqIn_5000Quantity = 2205.00;
            Double Stock13_20_25SqIn_5000Quantity = 2670.00;
            Double Stock13_25_30SqIn_5000Quantity = 3440.00;
            Double Stock13_30_35SqIn_5000Quantity = 3447.00;
            Double Stock13_35_40SqIn_5000Quantity = 3927.00;
            //Color, 250 Quantity.
            Double Stock13Color_5000Quantity = 230.00;

            //10000 Quantity.
            Double Stock13_0_2_5SqIn_10000Quantity = 1170.00;
            Double Stock13_2_5_5SqIn_10000Quantity = 1482.00;
            Double Stock13_5_10SqIn_10000Quantity = 2849.00;
            Double Stock13_10_15SqIn_10000Quantity = 3157.00;
            Double Stock13_15_20SqIn_10000Quantity = 3918.00;
            Double Stock13_20_25SqIn_10000Quantity = 4751.00;
            Double Stock13_25_30SqIn_10000Quantity = 6134.00;
            Double Stock13_30_35SqIn_10000Quantity = 6141.00;
            Double Stock13_35_40SqIn_10000Quantity = 7029.00;
            //Color, 250 Quantity.
            Double Stock13Color_10000Quantity = 360.00;

            //======================================================================================================
            //Stock 14 Pricing
            //======================================================================================================

            //50 Quantity.
            Double Stock14_0_2_5SqIn_50Quantity = 137.00;
            Double Stock14_2_5_5SqIn_50Quantity = 137.00;
            Double Stock14_5_10SqIn_50Quantity = 140.00;
            Double Stock14_10_15SqIn_50Quantity = 144.00;
            Double Stock14_15_20SqIn_50Quantity = 146.00;
            Double Stock14_20_25SqIn_50Quantity = 149.00;
            Double Stock14_25_30SqIn_50Quantity = 153.00;
            Double Stock14_30_35SqIn_50Quantity = 155.00;
            Double Stock14_35_40SqIn_50Quantity = 159.00;
            //Color, 50 Quantity.
            Double Stock14Color_50Quantity = 60.00;

            //100 Quantity.
            Double Stock14_0_2_5SqIn_100Quantity = 145.00;
            Double Stock14_2_5_5SqIn_100Quantity = 146.00;
            Double Stock14_5_10SqIn_100Quantity = 151.00;
            Double Stock14_10_15SqIn_100Quantity = 157.00;
            Double Stock14_15_20SqIn_100Quantity = 161.00;
            Double Stock14_20_25SqIn_100Quantity = 166.00;
            Double Stock14_25_30SqIn_100Quantity = 171.00;
            Double Stock14_30_35SqIn_100Quantity = 175.00;
            Double Stock14_35_40SqIn_100Quantity = 182.00;
            //Color, 100 Quantity.
            Double Stock14Color_100Quantity = 65.00;

            //250 Quantity.
            Double Stock14_0_2_5SqIn_250Quantity = 171.00;
            Double Stock14_2_5_5SqIn_250Quantity = 172.00;
            Double Stock14_5_10SqIn_250Quantity = 182.00;
            Double Stock14_10_15SqIn_250Quantity = 195.00;
            Double Stock14_15_20SqIn_250Quantity = 203.00;
            Double Stock14_20_25SqIn_250Quantity = 215.00;
            Double Stock14_25_30SqIn_250Quantity = 227.00;
            Double Stock14_30_35SqIn_250Quantity = 235.00;
            Double Stock14_35_40SqIn_250Quantity = 250.00;
            //Color, 250 Quantity.
            Double Stock14Color_250Quantity = 75.00;

            //500 Quantity.
            Double Stock14_0_2_5SqIn_500Quantity = 186.00;
            Double Stock14_2_5_5SqIn_500Quantity = 195.00;
            Double Stock14_5_10SqIn_500Quantity = 216.00;
            Double Stock14_10_15SqIn_500Quantity = 246.00;
            Double Stock14_15_20SqIn_500Quantity = 257.00;
            Double Stock14_20_25SqIn_500Quantity = 286.00;
            Double Stock14_25_30SqIn_500Quantity = 288.00;
            Double Stock14_30_35SqIn_500Quantity = 325.00;
            Double Stock14_35_40SqIn_500Quantity = 345.00;
            //Color, 250 Quantity.
            Double Stock14Color_500Quantity = 80.00;

            //1000 Quantity.
            Double Stock14_0_2_5SqIn_1000Quantity = 222.00;
            Double Stock14_2_5_5SqIn_1000Quantity = 240.00;
            Double Stock14_5_10SqIn_1000Quantity = 308.00;
            Double Stock14_10_15SqIn_1000Quantity = 348.00;
            Double Stock14_15_20SqIn_1000Quantity = 370.00;
            Double Stock14_20_25SqIn_1000Quantity = 427.00;
            Double Stock14_25_30SqIn_1000Quantity = 431.00;
            Double Stock14_30_35SqIn_1000Quantity = 542.00;
            Double Stock14_35_40SqIn_1000Quantity = 546.00;
            //Color, 250 Quantity.
            Double Stock14Color_1000Quantity = 85.00;

            //2000 Quantity.
            Double Stock14_0_2_5SqIn_2000Quantity = 299.00;
            Double Stock14_2_5_5SqIn_2000Quantity = 336.00;
            Double Stock14_5_10SqIn_2000Quantity = 472.00;
            Double Stock14_10_15SqIn_2000Quantity = 523.00;
            Double Stock14_15_20SqIn_2000Quantity = 595.00;
            Double Stock14_20_25SqIn_2000Quantity = 710.00;
            Double Stock14_25_30SqIn_2000Quantity = 730.00;
            Double Stock14_30_35SqIn_2000Quantity = 878.00;
            Double Stock14_35_40SqIn_2000Quantity = 993.00;
            //Color, 250 Quantity.
            Double Stock14Color_2000Quantity = 100.00;

            //2500 Quantity.
            Double Stock14_0_2_5SqIn_2500Quantity = 335.00;
            Double Stock14_2_5_5SqIn_2500Quantity = 383.00;
            Double Stock14_5_10SqIn_2500Quantity = 518.00;
            Double Stock14_10_15SqIn_2500Quantity = 614.00;
            Double Stock14_15_20SqIn_2500Quantity = 708.00;
            Double Stock14_20_25SqIn_2500Quantity = 842.00;
            Double Stock14_25_30SqIn_2500Quantity = 870.00;
            Double Stock14_30_35SqIn_2500Quantity = 1047.00;
            Double Stock14_35_40SqIn_2500Quantity = 1190.00;
            //Color, 250 Quantity.
            Double Stock14Color_2500Quantity = 115.00;

            //5000 Quantity.
            Double Stock14_0_2_5SqIn_5000Quantity = 515.00;
            Double Stock14_2_5_5SqIn_5000Quantity = 619.00;
            Double Stock14_5_10SqIn_5000Quantity = 750.00;
            Double Stock14_10_15SqIn_5000Quantity = 1071.00;
            Double Stock14_15_20SqIn_5000Quantity = 1272.00;
            Double Stock14_20_25SqIn_5000Quantity = 1504.00;
            Double Stock14_25_30SqIn_5000Quantity = 1567.00;
            Double Stock14_30_35SqIn_5000Quantity = 1892.00;
            Double Stock14_35_40SqIn_5000Quantity = 2177.00;
            //Color, 250 Quantity.
            Double Stock14Color_5000Quantity = 230.00;

            //10000 Quantity.
            Double Stock14_0_2_5SqIn_10000Quantity = 889.00;
            Double Stock14_2_5_5SqIn_10000Quantity = 1068.00;
            Double Stock14_5_10SqIn_10000Quantity = 1428.00;
            Double Stock14_10_15SqIn_10000Quantity = 1918.00;
            Double Stock14_15_20SqIn_10000Quantity = 2266.00;
            Double Stock14_20_25SqIn_10000Quantity = 2685.00;
            Double Stock14_25_30SqIn_10000Quantity = 2818.00;
            Double Stock14_30_35SqIn_10000Quantity = 3387.00;
            Double Stock14_35_40SqIn_10000Quantity = 3931.00;
            //Color, 250 Quantity.
            Double Stock14Color_10000Quantity = 360.00;

            //======================================================================================================
            //Stock 15 Pricing
            //======================================================================================================

            //50 Quantity.
            Double Stock15_0_2_5SqIn_50Quantity = 135.00;
            Double Stock15_2_5_5SqIn_50Quantity = 136.00;
            Double Stock15_5_10SqIn_50Quantity = 140.00;
            Double Stock15_10_15SqIn_50Quantity = 143.00;
            Double Stock15_15_20SqIn_50Quantity = 146.00;
            Double Stock15_20_25SqIn_50Quantity = 148.00;
            Double Stock15_25_30SqIn_50Quantity = 151.00;
            Double Stock15_30_35SqIn_50Quantity = 153.00;
            Double Stock15_35_40SqIn_50Quantity = 158.00;

            //Color, 50 Quantity.
            Double Stock15Color_50Quantity = 60.00;

            //100 Quantity.
            Double Stock15_0_2_5SqIn_100Quantity = 143.00;
            Double Stock15_2_5_5SqIn_100Quantity = 144.00;
            Double Stock15_5_10SqIn_100Quantity = 150.00;
            Double Stock15_10_15SqIn_100Quantity = 156.00;
            Double Stock15_15_20SqIn_100Quantity = 159.00;
            Double Stock15_20_25SqIn_100Quantity = 163.00;
            Double Stock15_25_30SqIn_100Quantity = 169.00;
            Double Stock15_30_35SqIn_100Quantity = 172.00;
            Double Stock15_35_40SqIn_100Quantity = 179.00;
            //Color, 100 Quantity.
            Double Stock15Color_100Quantity = 65.00;

            //250 Quantity.
            Double Stock15_0_2_5SqIn_250Quantity = 157.00;
            Double Stock15_2_5_5SqIn_250Quantity = 158.00;
            Double Stock15_5_10SqIn_250Quantity = 172.00;
            Double Stock15_10_15SqIn_250Quantity = 184.00;
            Double Stock15_15_20SqIn_250Quantity = 193.00;
            Double Stock15_20_25SqIn_250Quantity = 210.00;
            Double Stock15_25_30SqIn_250Quantity = 221.00;
            Double Stock15_30_35SqIn_250Quantity = 228.00;
            Double Stock15_35_40SqIn_250Quantity = 243.00;
            //Color, 250 Quantity.
            Double Stock15Color_250Quantity = 75.00;

            //500 Quantity.
            Double Stock15_0_2_5SqIn_500Quantity = 185.00;
            Double Stock15_2_5_5SqIn_500Quantity = 186.00;
            Double Stock15_5_10SqIn_500Quantity = 212.00;
            Double Stock15_10_15SqIn_500Quantity = 233.00;
            Double Stock15_15_20SqIn_500Quantity = 250.00;
            Double Stock15_20_25SqIn_500Quantity = 278.00;
            Double Stock15_25_30SqIn_500Quantity = 279.00;
            Double Stock15_30_35SqIn_500Quantity = 312.00;
            Double Stock15_35_40SqIn_500Quantity = 330.00;
            //Color, 250 Quantity.
            Double Stock15Color_500Quantity = 80.00;

            //1000 Quantity.
            Double Stock15_0_2_5SqIn_1000Quantity = 220.00;
            Double Stock15_2_5_5SqIn_1000Quantity = 241.00;
            Double Stock15_5_10SqIn_1000Quantity = 299.00;
            Double Stock15_10_15SqIn_1000Quantity = 351.00;
            Double Stock15_15_20SqIn_1000Quantity = 355.00;
            Double Stock15_20_25SqIn_1000Quantity = 407.00;
            Double Stock15_25_30SqIn_1000Quantity = 411.00;
            Double Stock15_30_35SqIn_1000Quantity = 432.00;
            Double Stock15_35_40SqIn_1000Quantity = 516.00;
            //Color, 250 Quantity.
            Double Stock15Color_1000Quantity = 85.00;

            //2000 Quantity.
            Double Stock15_0_2_5SqIn_2000Quantity = 295.00;
            Double Stock15_2_5_5SqIn_2000Quantity = 328.00;
            Double Stock15_5_10SqIn_2000Quantity = 452.00;
            Double Stock15_10_15SqIn_2000Quantity = 556.00;
            Double Stock15_15_20SqIn_2000Quantity = 565.00;
            Double Stock15_20_25SqIn_2000Quantity = 669.00;
            Double Stock15_25_30SqIn_2000Quantity = 690.00;
            Double Stock15_30_35SqIn_2000Quantity = 728.00;
            Double Stock15_35_40SqIn_2000Quantity = 932.00;
            //Color, 250 Quantity.
            Double Stock15Color_2000Quantity = 100.00;

            //2500 Quantity.
            Double Stock15_0_2_5SqIn_2500Quantity = 333.00;
            Double Stock15_2_5_5SqIn_2500Quantity = 374.00;
            Double Stock15_5_10SqIn_2500Quantity = 508.00;
            Double Stock15_10_15SqIn_2500Quantity = 633.00;
            Double Stock15_15_20SqIn_2500Quantity = 642.00;
            Double Stock15_20_25SqIn_2500Quantity = 793.00;
            Double Stock15_25_30SqIn_2500Quantity = 821.00;
            Double Stock15_30_35SqIn_2500Quantity = 866.00;
            Double Stock15_35_40SqIn_2500Quantity = 1117.00;
            //Color, 250 Quantity.
            Double Stock15Color_2500Quantity = 115.00;

            //5000 Quantity.
            Double Stock15_0_2_5SqIn_5000Quantity = 524.00;
            Double Stock15_2_5_5SqIn_5000Quantity = 601.00;
            Double Stock15_5_10SqIn_5000Quantity = 790.00;
            Double Stock15_10_15SqIn_5000Quantity = 1016.00;
            Double Stock15_15_20SqIn_5000Quantity = 1027.00;
            Double Stock15_20_25SqIn_5000Quantity = 1412.00;
            Double Stock15_25_30SqIn_5000Quantity = 1476.00;
            Double Stock15_30_35SqIn_5000Quantity = 1556.00;
            Double Stock15_35_40SqIn_5000Quantity = 2039.00;
            //Color, 250 Quantity.
            Double Stock15Color_5000Quantity = 230.00;

            //10000 Quantity.
            Double Stock15_0_2_5SqIn_10000Quantity = 903.00;
            Double Stock15_2_5_5SqIn_10000Quantity = 1036.00;
            Double Stock15_5_10SqIn_10000Quantity = 1364.00;
            Double Stock15_10_15SqIn_10000Quantity = 1821.00;
            Double Stock15_15_20SqIn_10000Quantity = 1832.00;
            Double Stock15_20_25SqIn_10000Quantity = 2524.00;
            Double Stock15_25_30SqIn_10000Quantity = 2656.00;
            Double Stock15_30_35SqIn_10000Quantity = 2793.00;
            Double Stock15_35_40SqIn_10000Quantity = 3688.00;
            //Color, 250 Quantity.
            Double Stock15Color_10000Quantity = 360.00;


            //======================================================================================================
            //Lamination Pricing
            //======================================================================================================

            //Calculating the Square Inches from the form values.
            Double SelectedHeight = Convert.ToDouble(txtLabelHeight.Text);
            Double SelectedWidth = Convert.ToDouble(txtLabelWidth.Text);
            Double SqIn = Convert.ToDouble(txtLabelHeight.Text) * Convert.ToDouble(txtLabelWidth.Text);

            //Lamination price is the value of the dropdpwn items.********
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
                if (SqIn > 0 && SqIn <= 2.5)
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
                if (SqIn > 0 && SqIn <= 2.5)
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
                if (SqIn > 0 && SqIn <= 2.5)
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
                if (SqIn > 0 && SqIn <= 2.5)
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
                if (SqIn > 0 && SqIn <= 2.5)
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
                if (SqIn > 0 && SqIn <= 2.5)
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
                if (SqIn > 0 && SqIn <= 2.5)
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
                if (SqIn > 0 && SqIn <= 2.5)
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
                if (SqIn > 0 && SqIn <= 2.5)
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
                if (SqIn > 0 && SqIn <= 2.5)
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
                if (SqIn > 0 && SqIn <= 2.5)
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
                if (SqIn > 0 && SqIn <= 2.5)
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
                if (SqIn > 0 && SqIn <= 2.5)
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
                if (SqIn > 0 && SqIn <= 2.5)
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
                if (SqIn > 0 && SqIn <= 2.5)
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
                if (SqIn > 0 && SqIn <= 2.5)
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
                if (SqIn > 0 && SqIn <= 2.5)
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
                if (SqIn > 0 && SqIn <= 2.5)
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
                if (SqIn > 0 && SqIn <= 2.5)
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
                if (SqIn > 0 && SqIn <= 2.5)
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
                if (SqIn > 0 && SqIn <= 2.5)
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
                if (SqIn > 0 && SqIn <= 2.5)
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
                if (SqIn > 0 && SqIn <= 2.5)
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
                if (SqIn > 0 && SqIn <= 2.5)
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
                if (SqIn > 0 && SqIn <= 2.5)
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
                if (SqIn > 0 && SqIn <= 2.5)
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
                if (SqIn > 0 && SqIn <= 2.5)
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
                if (SqIn > 0 && SqIn <= 2.5)
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
                if (SqIn > 0 && SqIn <= 2.5)
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
                if (SqIn > 0 && SqIn <= 2.5)
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
                if (SqIn > 0 && SqIn <= 2.5)
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
                if (SqIn > 0 && SqIn <= 2.5)
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
                if (SqIn > 0 && SqIn <= 2.5)
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
                if (SqIn > 0 && SqIn <= 2.5)
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
                if (SqIn > 0 && SqIn <= 2.5)
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
                if (SqIn > 0 && SqIn <= 2.5)
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
            //Stock 6
            //======================================================================================================

            //50 Quantity If Statements
            //======================================================================================================

            //Finding out if the stock is and show the price for that stock.
            if (ddlStock.SelectedValue == "6" && ddlLabelQuantities.SelectedValue == "50")
            {
                Double Subtotal = 0;

                //Displaying the Subtotal.
                if (SqIn > 0 && SqIn <= 2.5)
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
                if (SqIn > 0 && SqIn <= 2.5)
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
                if (SqIn > 0 && SqIn <= 2.5)
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
                if (SqIn > 0 && SqIn <= 2.5)
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
                if (SqIn > 0 && SqIn <= 2.5)
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
                if (SqIn > 0 && SqIn <= 2.5)
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
                if (SqIn > 0 && SqIn <= 2.5)
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
                if (SqIn > 0 && SqIn <= 2.5)
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
                if (SqIn > 0 && SqIn <= 2.5)
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
                if (SqIn > 0 && SqIn <= 2.5)
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
                if (SqIn > 0 && SqIn <= 2.5)
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
                if (SqIn > 0 && SqIn <= 2.5)
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
                if (SqIn > 0 && SqIn <= 2.5)
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
                if (SqIn > 0 && SqIn <= 2.5)
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
                if (SqIn > 0 && SqIn <= 2.5)
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
                if (SqIn > 0 && SqIn <= 2.5)
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
                if (SqIn > 0 && SqIn <= 2.5)
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
                if (SqIn > 0 && SqIn <= 2.5)
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
                if (SqIn > 0 && SqIn <= 2.5)
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
                if (SqIn > 0 && SqIn <= 2.5)
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
                if (SqIn > 0 && SqIn <= 2.5)
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
                if (SqIn > 0 && SqIn <= 2.5)
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
                if (SqIn > 0 && SqIn <= 2.5)
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
                if (SqIn > 0 && SqIn <= 2.5)
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
                if (SqIn > 0 && SqIn <= 2.5)
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
                if (SqIn > 0 && SqIn <= 2.5)
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
                if (SqIn > 0 && SqIn <= 2.5)
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
                if (SqIn > 0 && SqIn <= 2.5)
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
                if (SqIn > 0 && SqIn <= 2.5)
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
                if (SqIn > 0 && SqIn <= 2.5)
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
                if (SqIn > 0 && SqIn <= 2.5)
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
                if (SqIn > 0 && SqIn <= 2.5)
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
                if (SqIn > 0 && SqIn <= 2.5)
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
                if (SqIn > 0 && SqIn <= 2.5)
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
                if (SqIn > 0 && SqIn <= 2.5)
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
                if (SqIn > 0 && SqIn <= 2.5)
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
                if (SqIn > 0 && SqIn <= 2.5)
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
                if (SqIn > 0 && SqIn <= 2.5)
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
                if (SqIn > 0 && SqIn <= 2.5)
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
                if (SqIn > 0 && SqIn <= 2.5)
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
                if (SqIn > 0 && SqIn <= 2.5)
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
                if (SqIn > 0 && SqIn <= 2.5)
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
                if (SqIn > 0 && SqIn <= 2.5)
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
                if (SqIn > 0 && SqIn <= 2.5)
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
                if (SqIn > 0 && SqIn <= 2.5)
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





            //======================================================================================================
            //Stock 11
            //======================================================================================================

            //50 Quantity If Statements
            //======================================================================================================

            //Finding out if the stock is and show the price for that stock.
            if (ddlStock.SelectedValue == "11" && ddlLabelQuantities.SelectedValue == "50")
            {
                Double Subtotal = 0;

                //Displaying the Subtotal.
                if (SqIn > 0 && SqIn <= 2.5)
                {
                    Subtotal = Stock11_0_2_5SqIn_50Quantity;
                }
                else if (SqIn >= 2.5 && SqIn <= 5)
                {
                    Subtotal = Stock11_2_5_5SqIn_50Quantity;
                }
                else if (SqIn >= 5.1 && SqIn <= 10)
                {
                    Subtotal = Stock11_5_10SqIn_50Quantity;
                }
                else if (SqIn >= 10.1 && SqIn <= 15)
                {
                    Subtotal = Stock11_10_15SqIn_50Quantity;
                }
                else if (SqIn >= 15.1 && SqIn <= 20)
                {
                    Subtotal = Stock11_15_20SqIn_50Quantity;
                }
                else if (SqIn >= 20.1 && SqIn <= 25)
                {
                    Subtotal = Stock11_20_25SqIn_50Quantity;
                }
                else if (SqIn >= 25.1 && SqIn <= 30)
                {
                    Subtotal = Stock11_25_30SqIn_50Quantity;
                }
                else if (SqIn >= 30.1 && SqIn <= 35)
                {
                    Subtotal = Stock11_30_35SqIn_50Quantity;
                }
                else if (SqIn >= 35.1 && SqIn <= 40)
                {
                    Subtotal = Stock11_35_40SqIn_50Quantity;
                }
                else if (SqIn > 40.1)
                {
                    lblCustomQuoteMessage.Text = CustomQuoteMessage;
                }
                //Calculating the price for the colors.
                Double ColorPrice = Stock11Color_50Quantity * Convert.ToDouble(NumberOfColors);

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
            if (ddlStock.SelectedValue == "11" && ddlLabelQuantities.SelectedValue == "100")
            {
                Double Subtotal = 0;

                //Displaying the Subtotal.
                if (SqIn > 0 && SqIn <= 2.5)
                {
                    Subtotal = Stock11_0_2_5SqIn_100Quantity;
                }
                else if (SqIn >= 2.5 && SqIn <= 5)
                {
                    Subtotal = Stock11_2_5_5SqIn_100Quantity;
                }
                else if (SqIn >= 5.1 && SqIn <= 10)
                {
                    Subtotal = Stock11_5_10SqIn_100Quantity;
                }
                else if (SqIn >= 10.1 && SqIn <= 15)
                {
                    Subtotal = Stock11_10_15SqIn_100Quantity;
                }
                else if (SqIn >= 15.1 && SqIn <= 20)
                {
                    Subtotal = Stock11_15_20SqIn_100Quantity;
                }
                else if (SqIn >= 20.1 && SqIn <= 25)
                {
                    Subtotal = Stock11_20_25SqIn_100Quantity;
                }
                else if (SqIn >= 25.1 && SqIn <= 30)
                {
                    Subtotal = Stock11_25_30SqIn_100Quantity;
                }
                else if (SqIn >= 30.1 && SqIn <= 35)
                {
                    Subtotal = Stock11_30_35SqIn_100Quantity;
                }
                else if (SqIn >= 35.1 && SqIn <= 40)
                {
                    Subtotal = Stock11_35_40SqIn_100Quantity;
                }
                else if (SqIn > 40.1)
                {
                    lblCustomQuoteMessage.Text = CustomQuoteMessage;
                }
                //Calculating the price for the colors.
                Double ColorPrice = Stock11Color_100Quantity * Convert.ToDouble(NumberOfColors);

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
            if (ddlStock.SelectedValue == "11" && ddlLabelQuantities.SelectedValue == "250")
            {
                Double Subtotal = 0;

                //Displaying the Subtotal.
                if (SqIn > 0 && SqIn <= 2.5)
                {
                    Subtotal = Stock11_0_2_5SqIn_250Quantity;
                }
                else if (SqIn >= 2.5 && SqIn <= 5)
                {
                    Subtotal = Stock11_2_5_5SqIn_250Quantity;
                }
                else if (SqIn >= 5.1 && SqIn <= 10)
                {
                    Subtotal = Stock11_5_10SqIn_250Quantity;
                }
                else if (SqIn >= 10.1 && SqIn <= 15)
                {
                    Subtotal = Stock11_10_15SqIn_250Quantity;
                }
                else if (SqIn >= 15.1 && SqIn <= 20)
                {
                    Subtotal = Stock11_15_20SqIn_250Quantity;
                }
                else if (SqIn >= 20.1 && SqIn <= 25)
                {
                    Subtotal = Stock11_20_25SqIn_250Quantity;
                }
                else if (SqIn >= 25.1 && SqIn <= 30)
                {
                    Subtotal = Stock11_25_30SqIn_250Quantity;
                }
                else if (SqIn >= 30.1 && SqIn <= 35)
                {
                    Subtotal = Stock11_30_35SqIn_250Quantity;
                }
                else if (SqIn >= 35.1 && SqIn <= 40)
                {
                    Subtotal = Stock11_35_40SqIn_250Quantity;
                }
                else if (SqIn > 40.1)
                {
                    lblCustomQuoteMessage.Text = CustomQuoteMessage;
                }
                //Calculating the price for the colors.
                Double ColorPrice = Stock11Color_250Quantity * Convert.ToDouble(NumberOfColors);

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
            if (ddlStock.SelectedValue == "11" && ddlLabelQuantities.SelectedValue == "500")
            {
                Double Subtotal = 0;

                //Displaying the Subtotal.
                if (SqIn > 0 && SqIn <= 2.5)
                {
                    Subtotal = Stock11_0_2_5SqIn_500Quantity;
                }
                else if (SqIn >= 2.5 && SqIn <= 5)
                {
                    Subtotal = Stock11_2_5_5SqIn_500Quantity;
                }
                else if (SqIn >= 5.1 && SqIn <= 10)
                {
                    Subtotal = Stock11_5_10SqIn_500Quantity;
                }
                else if (SqIn >= 10.1 && SqIn <= 15)
                {
                    Subtotal = Stock11_10_15SqIn_500Quantity;
                }
                else if (SqIn >= 15.1 && SqIn <= 20)
                {
                    Subtotal = Stock11_15_20SqIn_500Quantity;
                }
                else if (SqIn >= 20.1 && SqIn <= 25)
                {
                    Subtotal = Stock11_20_25SqIn_500Quantity;
                }
                else if (SqIn >= 25.1 && SqIn <= 30)
                {
                    Subtotal = Stock11_25_30SqIn_500Quantity;
                }
                else if (SqIn >= 30.1 && SqIn <= 35)
                {
                    Subtotal = Stock11_30_35SqIn_500Quantity;
                }
                else if (SqIn >= 35.1 && SqIn <= 40)
                {
                    Subtotal = Stock11_35_40SqIn_500Quantity;
                }
                else if (SqIn > 40.1)
                {
                    lblCustomQuoteMessage.Text = CustomQuoteMessage;
                }
                //Calculating the price for the colors.
                Double ColorPrice = Stock11Color_500Quantity * Convert.ToDouble(NumberOfColors);

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
            if (ddlStock.SelectedValue == "11" && ddlLabelQuantities.SelectedValue == "1000")
            {
                Double Subtotal = 0;

                //Displaying the Subtotal.
                if (SqIn > 0 && SqIn <= 2.5)
                {
                    Subtotal = Stock11_0_2_5SqIn_1000Quantity;
                }
                else if (SqIn >= 2.5 && SqIn <= 5)
                {
                    Subtotal = Stock11_2_5_5SqIn_1000Quantity;
                }
                else if (SqIn >= 5.1 && SqIn <= 10)
                {
                    Subtotal = Stock11_5_10SqIn_1000Quantity;
                }
                else if (SqIn >= 10.1 && SqIn <= 15)
                {
                    Subtotal = Stock11_10_15SqIn_1000Quantity;
                }
                else if (SqIn >= 15.1 && SqIn <= 20)
                {
                    Subtotal = Stock11_15_20SqIn_1000Quantity;
                }
                else if (SqIn >= 20.1 && SqIn <= 25)
                {
                    Subtotal = Stock11_20_25SqIn_1000Quantity;
                }
                else if (SqIn >= 25.1 && SqIn <= 30)
                {
                    Subtotal = Stock11_25_30SqIn_1000Quantity;
                }
                else if (SqIn >= 30.1 && SqIn <= 35)
                {
                    Subtotal = Stock11_30_35SqIn_1000Quantity;
                }
                else if (SqIn >= 35.1 && SqIn <= 40)
                {
                    Subtotal = Stock11_35_40SqIn_1000Quantity;
                }
                else if (SqIn > 40.1)
                {
                    lblCustomQuoteMessage.Text = CustomQuoteMessage;
                }
                //Calculating the price for the colors.
                Double ColorPrice = Stock11Color_1000Quantity * Convert.ToDouble(NumberOfColors);

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
            if (ddlStock.SelectedValue == "11" && ddlLabelQuantities.SelectedValue == "2000")
            {
                Double Subtotal = 0;

                //Displaying the Subtotal.
                if (SqIn > 0 && SqIn <= 2.5)
                {
                    Subtotal = Stock11_0_2_5SqIn_2000Quantity;
                }
                else if (SqIn >= 2.5 && SqIn <= 5)
                {
                    Subtotal = Stock11_2_5_5SqIn_2000Quantity;
                }
                else if (SqIn >= 5.1 && SqIn <= 10)
                {
                    Subtotal = Stock11_5_10SqIn_2000Quantity;
                }
                else if (SqIn >= 10.1 && SqIn <= 15)
                {
                    Subtotal = Stock11_10_15SqIn_2000Quantity;
                }
                else if (SqIn >= 15.1 && SqIn <= 20)
                {
                    Subtotal = Stock11_15_20SqIn_2000Quantity;
                }
                else if (SqIn >= 20.1 && SqIn <= 25)
                {
                    Subtotal = Stock11_20_25SqIn_2000Quantity;
                }
                else if (SqIn >= 25.1 && SqIn <= 30)
                {
                    Subtotal = Stock11_25_30SqIn_2000Quantity;
                }
                else if (SqIn >= 30.1 && SqIn <= 35)
                {
                    Subtotal = Stock11_30_35SqIn_2000Quantity;
                }
                else if (SqIn >= 35.1 && SqIn <= 40)
                {
                    Subtotal = Stock11_35_40SqIn_2000Quantity;
                }
                else if (SqIn > 40.1)
                {
                    lblCustomQuoteMessage.Text = CustomQuoteMessage;
                }
                //Calculating the price for the colors.
                Double ColorPrice = Stock11Color_2000Quantity * Convert.ToDouble(NumberOfColors);

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
            if (ddlStock.SelectedValue == "11" && ddlLabelQuantities.SelectedValue == "2500")
            {
                Double Subtotal = 0;

                //Displaying the Subtotal.
                if (SqIn > 0 && SqIn <= 2.5)
                {
                    Subtotal = Stock11_0_2_5SqIn_2500Quantity;
                }
                else if (SqIn >= 2.5 && SqIn <= 5)
                {
                    Subtotal = Stock11_2_5_5SqIn_2500Quantity;
                }
                else if (SqIn >= 5.1 && SqIn <= 10)
                {
                    Subtotal = Stock11_5_10SqIn_2500Quantity;
                }
                else if (SqIn >= 10.1 && SqIn <= 15)
                {
                    Subtotal = Stock11_10_15SqIn_2500Quantity;
                }
                else if (SqIn >= 15.1 && SqIn <= 20)
                {
                    Subtotal = Stock11_15_20SqIn_2500Quantity;
                }
                else if (SqIn >= 20.1 && SqIn <= 25)
                {
                    Subtotal = Stock11_20_25SqIn_2500Quantity;
                }
                else if (SqIn >= 25.1 && SqIn <= 30)
                {
                    Subtotal = Stock11_25_30SqIn_2500Quantity;
                }
                else if (SqIn >= 30.1 && SqIn <= 35)
                {
                    Subtotal = Stock11_30_35SqIn_2500Quantity;
                }
                else if (SqIn >= 35.1 && SqIn <= 40)
                {
                    Subtotal = Stock11_35_40SqIn_2500Quantity;
                }
                else if (SqIn > 40.1)
                {
                    lblCustomQuoteMessage.Text = CustomQuoteMessage;
                }
                //Calculating the price for the colors.
                Double ColorPrice = Stock11Color_2500Quantity * Convert.ToDouble(NumberOfColors);

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
            if (ddlStock.SelectedValue == "11" && ddlLabelQuantities.SelectedValue == "5000")
            {
                Double Subtotal = 0;

                //Displaying the Subtotal.
                if (SqIn > 0 && SqIn <= 2.5)
                {
                    Subtotal = Stock11_0_2_5SqIn_5000Quantity;
                }
                else if (SqIn >= 2.5 && SqIn <= 5)
                {
                    Subtotal = Stock11_2_5_5SqIn_5000Quantity;
                }
                else if (SqIn >= 5.1 && SqIn <= 10)
                {
                    Subtotal = Stock11_5_10SqIn_5000Quantity;
                }
                else if (SqIn >= 10.1 && SqIn <= 15)
                {
                    Subtotal = Stock11_10_15SqIn_5000Quantity;
                }
                else if (SqIn >= 15.1 && SqIn <= 20)
                {
                    Subtotal = Stock11_15_20SqIn_5000Quantity;
                }
                else if (SqIn >= 20.1 && SqIn <= 25)
                {
                    Subtotal = Stock11_20_25SqIn_5000Quantity;
                }
                else if (SqIn >= 25.1 && SqIn <= 30)
                {
                    Subtotal = Stock11_25_30SqIn_5000Quantity;
                }
                else if (SqIn >= 30.1 && SqIn <= 35)
                {
                    Subtotal = Stock11_30_35SqIn_5000Quantity;
                }
                else if (SqIn >= 35.1 && SqIn <= 40)
                {
                    Subtotal = Stock11_35_40SqIn_5000Quantity;
                }
                else if (SqIn > 40.1)
                {
                    lblCustomQuoteMessage.Text = CustomQuoteMessage;
                }
                //Calculating the price for the colors.
                Double ColorPrice = Stock11Color_5000Quantity * Convert.ToDouble(NumberOfColors);

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
            if (ddlStock.SelectedValue == "11" && ddlLabelQuantities.SelectedValue == "10000")
            {
                Double Subtotal = 0;

                //Displaying the Subtotal.
                if (SqIn > 0 && SqIn <= 2.5)
                {
                    Subtotal = Stock11_0_2_5SqIn_10000Quantity;
                }
                else if (SqIn >= 2.5 && SqIn <= 5)
                {
                    Subtotal = Stock11_2_5_5SqIn_10000Quantity;
                }
                else if (SqIn >= 5.1 && SqIn <= 10)
                {
                    Subtotal = Stock11_5_10SqIn_10000Quantity;
                }
                else if (SqIn >= 10.1 && SqIn <= 15)
                {
                    Subtotal = Stock11_10_15SqIn_10000Quantity;
                }
                else if (SqIn >= 15.1 && SqIn <= 20)
                {
                    Subtotal = Stock11_15_20SqIn_10000Quantity;
                }
                else if (SqIn >= 20.1 && SqIn <= 25)
                {
                    Subtotal = Stock11_20_25SqIn_10000Quantity;
                }
                else if (SqIn >= 25.1 && SqIn <= 30)
                {
                    Subtotal = Stock11_25_30SqIn_10000Quantity;
                }
                else if (SqIn >= 30.1 && SqIn <= 35)
                {
                    Subtotal = Stock11_30_35SqIn_10000Quantity;
                }
                else if (SqIn >= 35.1 && SqIn <= 40)
                {
                    Subtotal = Stock11_35_40SqIn_10000Quantity;
                }
                else if (SqIn > 40.1)
                {
                    lblCustomQuoteMessage.Text = CustomQuoteMessage;
                }
                //Calculating the price for the colors.
                Double ColorPrice = Stock11Color_10000Quantity * Convert.ToDouble(NumberOfColors);

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
            //Stock 13
            //======================================================================================================

            //50 Quantity If Statements
            //======================================================================================================

            //Finding out if the stock is and show the price for that stock.
            if (ddlStock.SelectedValue == "13" && ddlLabelQuantities.SelectedValue == "50")
            {
                Double Subtotal = 0;

                //Displaying the Subtotal.
                if (SqIn > 0 && SqIn <= 2.5)
                {
                    Subtotal = Stock13_0_2_5SqIn_50Quantity;
                }
                else if (SqIn >= 2.5 && SqIn <= 5)
                {
                    Subtotal = Stock13_2_5_5SqIn_50Quantity;
                }
                else if (SqIn >= 5.1 && SqIn <= 10)
                {
                    Subtotal = Stock13_5_10SqIn_50Quantity;
                }
                else if (SqIn >= 10.1 && SqIn <= 15)
                {
                    Subtotal = Stock13_10_15SqIn_50Quantity;
                }
                else if (SqIn >= 15.1 && SqIn <= 20)
                {
                    Subtotal = Stock13_15_20SqIn_50Quantity;
                }
                else if (SqIn >= 20.1 && SqIn <= 25)
                {
                    Subtotal = Stock13_20_25SqIn_50Quantity;
                }
                else if (SqIn >= 25.1 && SqIn <= 30)
                {
                    Subtotal = Stock13_25_30SqIn_50Quantity;
                }
                else if (SqIn >= 30.1 && SqIn <= 35)
                {
                    Subtotal = Stock13_30_35SqIn_50Quantity;
                }
                else if (SqIn >= 35.1 && SqIn <= 40)
                {
                    Subtotal = Stock13_35_40SqIn_50Quantity;
                }
                else if (SqIn > 40.1)
                {
                    lblCustomQuoteMessage.Text = CustomQuoteMessage;
                }
                //Calculating the price for the colors.
                Double ColorPrice = Stock13Color_50Quantity * Convert.ToDouble(NumberOfColors);

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
            if (ddlStock.SelectedValue == "13" && ddlLabelQuantities.SelectedValue == "100")
            {
                Double Subtotal = 0;

                //Displaying the Subtotal.
                if (SqIn > 0 && SqIn <= 2.5)
                {
                    Subtotal = Stock13_0_2_5SqIn_100Quantity;
                }
                else if (SqIn >= 2.5 && SqIn <= 5)
                {
                    Subtotal = Stock13_2_5_5SqIn_100Quantity;
                }
                else if (SqIn >= 5.1 && SqIn <= 10)
                {
                    Subtotal = Stock13_5_10SqIn_100Quantity;
                }
                else if (SqIn >= 10.1 && SqIn <= 15)
                {
                    Subtotal = Stock13_10_15SqIn_100Quantity;
                }
                else if (SqIn >= 15.1 && SqIn <= 20)
                {
                    Subtotal = Stock13_15_20SqIn_100Quantity;
                }
                else if (SqIn >= 20.1 && SqIn <= 25)
                {
                    Subtotal = Stock13_20_25SqIn_100Quantity;
                }
                else if (SqIn >= 25.1 && SqIn <= 30)
                {
                    Subtotal = Stock13_25_30SqIn_100Quantity;
                }
                else if (SqIn >= 30.1 && SqIn <= 35)
                {
                    Subtotal = Stock13_30_35SqIn_100Quantity;
                }
                else if (SqIn >= 35.1 && SqIn <= 40)
                {
                    Subtotal = Stock13_35_40SqIn_100Quantity;
                }
                else if (SqIn > 40.1)
                {
                    lblCustomQuoteMessage.Text = CustomQuoteMessage;
                }
                //Calculating the price for the colors.
                Double ColorPrice = Stock13Color_100Quantity * Convert.ToDouble(NumberOfColors);

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
            if (ddlStock.SelectedValue == "13" && ddlLabelQuantities.SelectedValue == "250")
            {
                Double Subtotal = 0;

                //Displaying the Subtotal.
                if (SqIn > 0 && SqIn <= 2.5)
                {
                    Subtotal = Stock13_0_2_5SqIn_250Quantity;
                }
                else if (SqIn >= 2.5 && SqIn <= 5)
                {
                    Subtotal = Stock13_2_5_5SqIn_250Quantity;
                }
                else if (SqIn >= 5.1 && SqIn <= 10)
                {
                    Subtotal = Stock13_5_10SqIn_250Quantity;
                }
                else if (SqIn >= 10.1 && SqIn <= 15)
                {
                    Subtotal = Stock13_10_15SqIn_250Quantity;
                }
                else if (SqIn >= 15.1 && SqIn <= 20)
                {
                    Subtotal = Stock13_15_20SqIn_250Quantity;
                }
                else if (SqIn >= 20.1 && SqIn <= 25)
                {
                    Subtotal = Stock13_20_25SqIn_250Quantity;
                }
                else if (SqIn >= 25.1 && SqIn <= 30)
                {
                    Subtotal = Stock13_25_30SqIn_250Quantity;
                }
                else if (SqIn >= 30.1 && SqIn <= 35)
                {
                    Subtotal = Stock13_30_35SqIn_250Quantity;
                }
                else if (SqIn >= 35.1 && SqIn <= 40)
                {
                    Subtotal = Stock13_35_40SqIn_250Quantity;
                }
                else if (SqIn > 40.1)
                {
                    lblCustomQuoteMessage.Text = CustomQuoteMessage;
                }
                //Calculating the price for the colors.
                Double ColorPrice = Stock13Color_250Quantity * Convert.ToDouble(NumberOfColors);

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
            if (ddlStock.SelectedValue == "13" && ddlLabelQuantities.SelectedValue == "500")
            {
                Double Subtotal = 0;

                //Displaying the Subtotal.
                if (SqIn > 0 && SqIn <= 2.5)
                {
                    Subtotal = Stock13_0_2_5SqIn_500Quantity;
                }
                else if (SqIn >= 2.5 && SqIn <= 5)
                {
                    Subtotal = Stock13_2_5_5SqIn_500Quantity;
                }
                else if (SqIn >= 5.1 && SqIn <= 10)
                {
                    Subtotal = Stock13_5_10SqIn_500Quantity;
                }
                else if (SqIn >= 10.1 && SqIn <= 15)
                {
                    Subtotal = Stock13_10_15SqIn_500Quantity;
                }
                else if (SqIn >= 15.1 && SqIn <= 20)
                {
                    Subtotal = Stock13_15_20SqIn_500Quantity;
                }
                else if (SqIn >= 20.1 && SqIn <= 25)
                {
                    Subtotal = Stock13_20_25SqIn_500Quantity;
                }
                else if (SqIn >= 25.1 && SqIn <= 30)
                {
                    Subtotal = Stock13_25_30SqIn_500Quantity;
                }
                else if (SqIn >= 30.1 && SqIn <= 35)
                {
                    Subtotal = Stock13_30_35SqIn_500Quantity;
                }
                else if (SqIn >= 35.1 && SqIn <= 40)
                {
                    Subtotal = Stock13_35_40SqIn_500Quantity;
                }
                else if (SqIn > 40.1)
                {
                    lblCustomQuoteMessage.Text = CustomQuoteMessage;
                }
                //Calculating the price for the colors.
                Double ColorPrice = Stock13Color_500Quantity * Convert.ToDouble(NumberOfColors);

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
            if (ddlStock.SelectedValue == "13" && ddlLabelQuantities.SelectedValue == "1000")
            {
                Double Subtotal = 0;

                //Displaying the Subtotal.
                if (SqIn > 0 && SqIn <= 2.5)
                {
                    Subtotal = Stock13_0_2_5SqIn_1000Quantity;
                }
                else if (SqIn >= 2.5 && SqIn <= 5)
                {
                    Subtotal = Stock13_2_5_5SqIn_1000Quantity;
                }
                else if (SqIn >= 5.1 && SqIn <= 10)
                {
                    Subtotal = Stock13_5_10SqIn_1000Quantity;
                }
                else if (SqIn >= 10.1 && SqIn <= 15)
                {
                    Subtotal = Stock13_10_15SqIn_1000Quantity;
                }
                else if (SqIn >= 15.1 && SqIn <= 20)
                {
                    Subtotal = Stock13_15_20SqIn_1000Quantity;
                }
                else if (SqIn >= 20.1 && SqIn <= 25)
                {
                    Subtotal = Stock13_20_25SqIn_1000Quantity;
                }
                else if (SqIn >= 25.1 && SqIn <= 30)
                {
                    Subtotal = Stock13_25_30SqIn_1000Quantity;
                }
                else if (SqIn >= 30.1 && SqIn <= 35)
                {
                    Subtotal = Stock13_30_35SqIn_1000Quantity;
                }
                else if (SqIn >= 35.1 && SqIn <= 40)
                {
                    Subtotal = Stock13_35_40SqIn_1000Quantity;
                }
                else if (SqIn > 40.1)
                {
                    lblCustomQuoteMessage.Text = CustomQuoteMessage;
                }
                //Calculating the price for the colors.
                Double ColorPrice = Stock13Color_1000Quantity * Convert.ToDouble(NumberOfColors);

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
            if (ddlStock.SelectedValue == "13" && ddlLabelQuantities.SelectedValue == "2000")
            {
                Double Subtotal = 0;

                //Displaying the Subtotal.
                if (SqIn > 0 && SqIn <= 2.5)
                {
                    Subtotal = Stock13_0_2_5SqIn_2000Quantity;
                }
                else if (SqIn >= 2.5 && SqIn <= 5)
                {
                    Subtotal = Stock13_2_5_5SqIn_2000Quantity;
                }
                else if (SqIn >= 5.1 && SqIn <= 10)
                {
                    Subtotal = Stock13_5_10SqIn_2000Quantity;
                }
                else if (SqIn >= 10.1 && SqIn <= 15)
                {
                    Subtotal = Stock13_10_15SqIn_2000Quantity;
                }
                else if (SqIn >= 15.1 && SqIn <= 20)
                {
                    Subtotal = Stock13_15_20SqIn_2000Quantity;
                }
                else if (SqIn >= 20.1 && SqIn <= 25)
                {
                    Subtotal = Stock13_20_25SqIn_2000Quantity;
                }
                else if (SqIn >= 25.1 && SqIn <= 30)
                {
                    Subtotal = Stock13_25_30SqIn_2000Quantity;
                }
                else if (SqIn >= 30.1 && SqIn <= 35)
                {
                    Subtotal = Stock13_30_35SqIn_2000Quantity;
                }
                else if (SqIn >= 35.1 && SqIn <= 40)
                {
                    Subtotal = Stock13_35_40SqIn_2000Quantity;
                }
                else if (SqIn > 40.1)
                {
                    lblCustomQuoteMessage.Text = CustomQuoteMessage;
                }
                //Calculating the price for the colors.
                Double ColorPrice = Stock13Color_2000Quantity * Convert.ToDouble(NumberOfColors);

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
            if (ddlStock.SelectedValue == "13" && ddlLabelQuantities.SelectedValue == "2500")
            {
                Double Subtotal = 0;

                //Displaying the Subtotal.
                if (SqIn > 0 && SqIn <= 2.5)
                {
                    Subtotal = Stock13_0_2_5SqIn_2500Quantity;
                }
                else if (SqIn >= 2.5 && SqIn <= 5)
                {
                    Subtotal = Stock13_2_5_5SqIn_2500Quantity;
                }
                else if (SqIn >= 5.1 && SqIn <= 10)
                {
                    Subtotal = Stock13_5_10SqIn_2500Quantity;
                }
                else if (SqIn >= 10.1 && SqIn <= 15)
                {
                    Subtotal = Stock13_10_15SqIn_2500Quantity;
                }
                else if (SqIn >= 15.1 && SqIn <= 20)
                {
                    Subtotal = Stock13_15_20SqIn_2500Quantity;
                }
                else if (SqIn >= 20.1 && SqIn <= 25)
                {
                    Subtotal = Stock13_20_25SqIn_2500Quantity;
                }
                else if (SqIn >= 25.1 && SqIn <= 30)
                {
                    Subtotal = Stock13_25_30SqIn_2500Quantity;
                }
                else if (SqIn >= 30.1 && SqIn <= 35)
                {
                    Subtotal = Stock13_30_35SqIn_2500Quantity;
                }
                else if (SqIn >= 35.1 && SqIn <= 40)
                {
                    Subtotal = Stock13_35_40SqIn_2500Quantity;
                }
                else if (SqIn > 40.1)
                {
                    lblCustomQuoteMessage.Text = CustomQuoteMessage;
                }
                //Calculating the price for the colors.
                Double ColorPrice = Stock13Color_2500Quantity * Convert.ToDouble(NumberOfColors);

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
            if (ddlStock.SelectedValue == "13" && ddlLabelQuantities.SelectedValue == "5000")
            {
                Double Subtotal = 0;

                //Displaying the Subtotal.
                if (SqIn > 0 && SqIn <= 2.5)
                {
                    Subtotal = Stock13_0_2_5SqIn_5000Quantity;
                }
                else if (SqIn >= 2.5 && SqIn <= 5)
                {
                    Subtotal = Stock13_2_5_5SqIn_5000Quantity;
                }
                else if (SqIn >= 5.1 && SqIn <= 10)
                {
                    Subtotal = Stock13_5_10SqIn_5000Quantity;
                }
                else if (SqIn >= 10.1 && SqIn <= 15)
                {
                    Subtotal = Stock13_10_15SqIn_5000Quantity;
                }
                else if (SqIn >= 15.1 && SqIn <= 20)
                {
                    Subtotal = Stock13_15_20SqIn_5000Quantity;
                }
                else if (SqIn >= 20.1 && SqIn <= 25)
                {
                    Subtotal = Stock13_20_25SqIn_5000Quantity;
                }
                else if (SqIn >= 25.1 && SqIn <= 30)
                {
                    Subtotal = Stock13_25_30SqIn_5000Quantity;
                }
                else if (SqIn >= 30.1 && SqIn <= 35)
                {
                    Subtotal = Stock13_30_35SqIn_5000Quantity;
                }
                else if (SqIn >= 35.1 && SqIn <= 40)
                {
                    Subtotal = Stock13_35_40SqIn_5000Quantity;
                }
                else if (SqIn > 40.1)
                {
                    lblCustomQuoteMessage.Text = CustomQuoteMessage;
                }
                //Calculating the price for the colors.
                Double ColorPrice = Stock13Color_5000Quantity * Convert.ToDouble(NumberOfColors);

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
            if (ddlStock.SelectedValue == "13" && ddlLabelQuantities.SelectedValue == "10000")
            {
                Double Subtotal = 0;

                //Displaying the Subtotal.
                if (SqIn > 0 && SqIn <= 2.5)
                {
                    Subtotal = Stock13_0_2_5SqIn_10000Quantity;
                }
                else if (SqIn >= 2.5 && SqIn <= 5)
                {
                    Subtotal = Stock13_2_5_5SqIn_10000Quantity;
                }
                else if (SqIn >= 5.1 && SqIn <= 10)
                {
                    Subtotal = Stock13_5_10SqIn_10000Quantity;
                }
                else if (SqIn >= 10.1 && SqIn <= 15)
                {
                    Subtotal = Stock13_10_15SqIn_10000Quantity;
                }
                else if (SqIn >= 15.1 && SqIn <= 20)
                {
                    Subtotal = Stock13_15_20SqIn_10000Quantity;
                }
                else if (SqIn >= 20.1 && SqIn <= 25)
                {
                    Subtotal = Stock13_20_25SqIn_10000Quantity;
                }
                else if (SqIn >= 25.1 && SqIn <= 30)
                {
                    Subtotal = Stock13_25_30SqIn_10000Quantity;
                }
                else if (SqIn >= 30.1 && SqIn <= 35)
                {
                    Subtotal = Stock13_30_35SqIn_10000Quantity;
                }
                else if (SqIn >= 35.1 && SqIn <= 40)
                {
                    Subtotal = Stock13_35_40SqIn_10000Quantity;
                }
                else if (SqIn > 40.1)
                {
                    lblCustomQuoteMessage.Text = CustomQuoteMessage;
                }
                //Calculating the price for the colors.
                Double ColorPrice = Stock13Color_10000Quantity * Convert.ToDouble(NumberOfColors);

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
            //Stock 14
            //======================================================================================================

            //50 Quantity If Statements
            //======================================================================================================

            //Finding out if the stock is and show the price for that stock.
            if (ddlStock.SelectedValue == "14" && ddlLabelQuantities.SelectedValue == "50")
            {
                Double Subtotal = 0;

                //Displaying the Subtotal.
                if (SqIn > 0 && SqIn <= 2.5)
                {
                    Subtotal = Stock14_0_2_5SqIn_50Quantity;
                }
                else if (SqIn >= 2.5 && SqIn <= 5)
                {
                    Subtotal = Stock14_2_5_5SqIn_50Quantity;
                }
                else if (SqIn >= 5.1 && SqIn <= 10)
                {
                    Subtotal = Stock14_5_10SqIn_50Quantity;
                }
                else if (SqIn >= 10.1 && SqIn <= 15)
                {
                    Subtotal = Stock14_10_15SqIn_50Quantity;
                }
                else if (SqIn >= 15.1 && SqIn <= 20)
                {
                    Subtotal = Stock14_15_20SqIn_50Quantity;
                }
                else if (SqIn >= 20.1 && SqIn <= 25)
                {
                    Subtotal = Stock14_20_25SqIn_50Quantity;
                }
                else if (SqIn >= 25.1 && SqIn <= 30)
                {
                    Subtotal = Stock14_25_30SqIn_50Quantity;
                }
                else if (SqIn >= 30.1 && SqIn <= 35)
                {
                    Subtotal = Stock14_30_35SqIn_50Quantity;
                }
                else if (SqIn >= 35.1 && SqIn <= 40)
                {
                    Subtotal = Stock14_35_40SqIn_50Quantity;
                }
                else if (SqIn > 40.1)
                {
                    lblCustomQuoteMessage.Text = CustomQuoteMessage;
                }
                //Calculating the price for the colors.
                Double ColorPrice = Stock14Color_50Quantity * Convert.ToDouble(NumberOfColors);

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
            if (ddlStock.SelectedValue == "14" && ddlLabelQuantities.SelectedValue == "100")
            {
                Double Subtotal = 0;

                //Displaying the Subtotal.
                if (SqIn > 0 && SqIn <= 2.5)
                {
                    Subtotal = Stock14_0_2_5SqIn_100Quantity;
                }
                else if (SqIn >= 2.5 && SqIn <= 5)
                {
                    Subtotal = Stock14_2_5_5SqIn_100Quantity;
                }
                else if (SqIn >= 5.1 && SqIn <= 10)
                {
                    Subtotal = Stock14_5_10SqIn_100Quantity;
                }
                else if (SqIn >= 10.1 && SqIn <= 15)
                {
                    Subtotal = Stock14_10_15SqIn_100Quantity;
                }
                else if (SqIn >= 15.1 && SqIn <= 20)
                {
                    Subtotal = Stock14_15_20SqIn_100Quantity;
                }
                else if (SqIn >= 20.1 && SqIn <= 25)
                {
                    Subtotal = Stock14_20_25SqIn_100Quantity;
                }
                else if (SqIn >= 25.1 && SqIn <= 30)
                {
                    Subtotal = Stock14_25_30SqIn_100Quantity;
                }
                else if (SqIn >= 30.1 && SqIn <= 35)
                {
                    Subtotal = Stock14_30_35SqIn_100Quantity;
                }
                else if (SqIn >= 35.1 && SqIn <= 40)
                {
                    Subtotal = Stock14_35_40SqIn_100Quantity;
                }
                else if (SqIn > 40.1)
                {
                    lblCustomQuoteMessage.Text = CustomQuoteMessage;
                }
                //Calculating the price for the colors.
                Double ColorPrice = Stock14Color_100Quantity * Convert.ToDouble(NumberOfColors);

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
            if (ddlStock.SelectedValue == "14" && ddlLabelQuantities.SelectedValue == "250")
            {
                Double Subtotal = 0;

                //Displaying the Subtotal.
                if (SqIn > 0 && SqIn <= 2.5)
                {
                    Subtotal = Stock14_0_2_5SqIn_250Quantity;
                }
                else if (SqIn >= 2.5 && SqIn <= 5)
                {
                    Subtotal = Stock14_2_5_5SqIn_250Quantity;
                }
                else if (SqIn >= 5.1 && SqIn <= 10)
                {
                    Subtotal = Stock14_5_10SqIn_250Quantity;
                }
                else if (SqIn >= 10.1 && SqIn <= 15)
                {
                    Subtotal = Stock14_10_15SqIn_250Quantity;
                }
                else if (SqIn >= 15.1 && SqIn <= 20)
                {
                    Subtotal = Stock14_15_20SqIn_250Quantity;
                }
                else if (SqIn >= 20.1 && SqIn <= 25)
                {
                    Subtotal = Stock14_20_25SqIn_250Quantity;
                }
                else if (SqIn >= 25.1 && SqIn <= 30)
                {
                    Subtotal = Stock14_25_30SqIn_250Quantity;
                }
                else if (SqIn >= 30.1 && SqIn <= 35)
                {
                    Subtotal = Stock14_30_35SqIn_250Quantity;
                }
                else if (SqIn >= 35.1 && SqIn <= 40)
                {
                    Subtotal = Stock14_35_40SqIn_250Quantity;
                }
                else if (SqIn > 40.1)
                {
                    lblCustomQuoteMessage.Text = CustomQuoteMessage;
                }
                //Calculating the price for the colors.
                Double ColorPrice = Stock14Color_250Quantity * Convert.ToDouble(NumberOfColors);

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
            if (ddlStock.SelectedValue == "14" && ddlLabelQuantities.SelectedValue == "500")
            {
                Double Subtotal = 0;

                //Displaying the Subtotal.
                if (SqIn > 0 && SqIn <= 2.5)
                {
                    Subtotal = Stock14_0_2_5SqIn_500Quantity;
                }
                else if (SqIn >= 2.5 && SqIn <= 5)
                {
                    Subtotal = Stock14_2_5_5SqIn_500Quantity;
                }
                else if (SqIn >= 5.1 && SqIn <= 10)
                {
                    Subtotal = Stock14_5_10SqIn_500Quantity;
                }
                else if (SqIn >= 10.1 && SqIn <= 15)
                {
                    Subtotal = Stock14_10_15SqIn_500Quantity;
                }
                else if (SqIn >= 15.1 && SqIn <= 20)
                {
                    Subtotal = Stock14_15_20SqIn_500Quantity;
                }
                else if (SqIn >= 20.1 && SqIn <= 25)
                {
                    Subtotal = Stock14_20_25SqIn_500Quantity;
                }
                else if (SqIn >= 25.1 && SqIn <= 30)
                {
                    Subtotal = Stock14_25_30SqIn_500Quantity;
                }
                else if (SqIn >= 30.1 && SqIn <= 35)
                {
                    Subtotal = Stock14_30_35SqIn_500Quantity;
                }
                else if (SqIn >= 35.1 && SqIn <= 40)
                {
                    Subtotal = Stock14_35_40SqIn_500Quantity;
                }
                else if (SqIn > 40.1)
                {
                    lblCustomQuoteMessage.Text = CustomQuoteMessage;
                }
                //Calculating the price for the colors.
                Double ColorPrice = Stock14Color_500Quantity * Convert.ToDouble(NumberOfColors);

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
            if (ddlStock.SelectedValue == "14" && ddlLabelQuantities.SelectedValue == "1000")
            {
                Double Subtotal = 0;

                //Displaying the Subtotal.
                if (SqIn > 0 && SqIn <= 2.5)
                {
                    Subtotal = Stock14_0_2_5SqIn_1000Quantity;
                }
                else if (SqIn >= 2.5 && SqIn <= 5)
                {
                    Subtotal = Stock14_2_5_5SqIn_1000Quantity;
                }
                else if (SqIn >= 5.1 && SqIn <= 10)
                {
                    Subtotal = Stock14_5_10SqIn_1000Quantity;
                }
                else if (SqIn >= 10.1 && SqIn <= 15)
                {
                    Subtotal = Stock14_10_15SqIn_1000Quantity;
                }
                else if (SqIn >= 15.1 && SqIn <= 20)
                {
                    Subtotal = Stock14_15_20SqIn_1000Quantity;
                }
                else if (SqIn >= 20.1 && SqIn <= 25)
                {
                    Subtotal = Stock14_20_25SqIn_1000Quantity;
                }
                else if (SqIn >= 25.1 && SqIn <= 30)
                {
                    Subtotal = Stock14_25_30SqIn_1000Quantity;
                }
                else if (SqIn >= 30.1 && SqIn <= 35)
                {
                    Subtotal = Stock14_30_35SqIn_1000Quantity;
                }
                else if (SqIn >= 35.1 && SqIn <= 40)
                {
                    Subtotal = Stock14_35_40SqIn_1000Quantity;
                }
                else if (SqIn > 40.1)
                {
                    lblCustomQuoteMessage.Text = CustomQuoteMessage;
                }
                //Calculating the price for the colors.
                Double ColorPrice = Stock14Color_1000Quantity * Convert.ToDouble(NumberOfColors);

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
            if (ddlStock.SelectedValue == "14" && ddlLabelQuantities.SelectedValue == "2000")
            {
                Double Subtotal = 0;

                //Displaying the Subtotal.
                if (SqIn > 0 && SqIn <= 2.5)
                {
                    Subtotal = Stock14_0_2_5SqIn_2000Quantity;
                }
                else if (SqIn >= 2.5 && SqIn <= 5)
                {
                    Subtotal = Stock14_2_5_5SqIn_2000Quantity;
                }
                else if (SqIn >= 5.1 && SqIn <= 10)
                {
                    Subtotal = Stock14_5_10SqIn_2000Quantity;
                }
                else if (SqIn >= 10.1 && SqIn <= 15)
                {
                    Subtotal = Stock14_10_15SqIn_2000Quantity;
                }
                else if (SqIn >= 15.1 && SqIn <= 20)
                {
                    Subtotal = Stock14_15_20SqIn_2000Quantity;
                }
                else if (SqIn >= 20.1 && SqIn <= 25)
                {
                    Subtotal = Stock14_20_25SqIn_2000Quantity;
                }
                else if (SqIn >= 25.1 && SqIn <= 30)
                {
                    Subtotal = Stock14_25_30SqIn_2000Quantity;
                }
                else if (SqIn >= 30.1 && SqIn <= 35)
                {
                    Subtotal = Stock14_30_35SqIn_2000Quantity;
                }
                else if (SqIn >= 35.1 && SqIn <= 40)
                {
                    Subtotal = Stock14_35_40SqIn_2000Quantity;
                }
                else if (SqIn > 40.1)
                {
                    lblCustomQuoteMessage.Text = CustomQuoteMessage;
                }
                //Calculating the price for the colors.
                Double ColorPrice = Stock14Color_2000Quantity * Convert.ToDouble(NumberOfColors);

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
            if (ddlStock.SelectedValue == "14" && ddlLabelQuantities.SelectedValue == "2500")
            {
                Double Subtotal = 0;

                //Displaying the Subtotal.
                if (SqIn > 0 && SqIn <= 2.5)
                {
                    Subtotal = Stock14_0_2_5SqIn_2500Quantity;
                }
                else if (SqIn >= 2.5 && SqIn <= 5)
                {
                    Subtotal = Stock14_2_5_5SqIn_2500Quantity;
                }
                else if (SqIn >= 5.1 && SqIn <= 10)
                {
                    Subtotal = Stock14_5_10SqIn_2500Quantity;
                }
                else if (SqIn >= 10.1 && SqIn <= 15)
                {
                    Subtotal = Stock14_10_15SqIn_2500Quantity;
                }
                else if (SqIn >= 15.1 && SqIn <= 20)
                {
                    Subtotal = Stock14_15_20SqIn_2500Quantity;
                }
                else if (SqIn >= 20.1 && SqIn <= 25)
                {
                    Subtotal = Stock14_20_25SqIn_2500Quantity;
                }
                else if (SqIn >= 25.1 && SqIn <= 30)
                {
                    Subtotal = Stock14_25_30SqIn_2500Quantity;
                }
                else if (SqIn >= 30.1 && SqIn <= 35)
                {
                    Subtotal = Stock14_30_35SqIn_2500Quantity;
                }
                else if (SqIn >= 35.1 && SqIn <= 40)
                {
                    Subtotal = Stock14_35_40SqIn_2500Quantity;
                }
                else if (SqIn > 40.1)
                {
                    lblCustomQuoteMessage.Text = CustomQuoteMessage;
                }
                //Calculating the price for the colors.
                Double ColorPrice = Stock14Color_2500Quantity * Convert.ToDouble(NumberOfColors);

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
            if (ddlStock.SelectedValue == "14" && ddlLabelQuantities.SelectedValue == "5000")
            {
                Double Subtotal = 0;

                //Displaying the Subtotal.
                if (SqIn > 0 && SqIn <= 2.5)
                {
                    Subtotal = Stock14_0_2_5SqIn_5000Quantity;
                }
                else if (SqIn >= 2.5 && SqIn <= 5)
                {
                    Subtotal = Stock14_2_5_5SqIn_5000Quantity;
                }
                else if (SqIn >= 5.1 && SqIn <= 10)
                {
                    Subtotal = Stock14_5_10SqIn_5000Quantity;
                }
                else if (SqIn >= 10.1 && SqIn <= 15)
                {
                    Subtotal = Stock14_10_15SqIn_5000Quantity;
                }
                else if (SqIn >= 15.1 && SqIn <= 20)
                {
                    Subtotal = Stock14_15_20SqIn_5000Quantity;
                }
                else if (SqIn >= 20.1 && SqIn <= 25)
                {
                    Subtotal = Stock14_20_25SqIn_5000Quantity;
                }
                else if (SqIn >= 25.1 && SqIn <= 30)
                {
                    Subtotal = Stock14_25_30SqIn_5000Quantity;
                }
                else if (SqIn >= 30.1 && SqIn <= 35)
                {
                    Subtotal = Stock14_30_35SqIn_5000Quantity;
                }
                else if (SqIn >= 35.1 && SqIn <= 40)
                {
                    Subtotal = Stock14_35_40SqIn_5000Quantity;
                }
                else if (SqIn > 40.1)
                {
                    lblCustomQuoteMessage.Text = CustomQuoteMessage;
                }
                //Calculating the price for the colors.
                Double ColorPrice = Stock14Color_5000Quantity * Convert.ToDouble(NumberOfColors);

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
            if (ddlStock.SelectedValue == "14" && ddlLabelQuantities.SelectedValue == "10000")
            {
                Double Subtotal = 0;

                //Displaying the Subtotal.
                if (SqIn > 0 && SqIn <= 2.5)
                {
                    Subtotal = Stock14_0_2_5SqIn_10000Quantity;
                }
                else if (SqIn >= 2.5 && SqIn <= 5)
                {
                    Subtotal = Stock14_2_5_5SqIn_10000Quantity;
                }
                else if (SqIn >= 5.1 && SqIn <= 10)
                {
                    Subtotal = Stock14_5_10SqIn_10000Quantity;
                }
                else if (SqIn >= 10.1 && SqIn <= 15)
                {
                    Subtotal = Stock14_10_15SqIn_10000Quantity;
                }
                else if (SqIn >= 15.1 && SqIn <= 20)
                {
                    Subtotal = Stock14_15_20SqIn_10000Quantity;
                }
                else if (SqIn >= 20.1 && SqIn <= 25)
                {
                    Subtotal = Stock14_20_25SqIn_10000Quantity;
                }
                else if (SqIn >= 25.1 && SqIn <= 30)
                {
                    Subtotal = Stock14_25_30SqIn_10000Quantity;
                }
                else if (SqIn >= 30.1 && SqIn <= 35)
                {
                    Subtotal = Stock14_30_35SqIn_10000Quantity;
                }
                else if (SqIn >= 35.1 && SqIn <= 40)
                {
                    Subtotal = Stock14_35_40SqIn_10000Quantity;
                }
                else if (SqIn > 40.1)
                {
                    lblCustomQuoteMessage.Text = CustomQuoteMessage;
                }
                //Calculating the price for the colors.
                Double ColorPrice = Stock14Color_10000Quantity * Convert.ToDouble(NumberOfColors);

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
            //Stock 15
            //======================================================================================================

            //50 Quantity If Statements
            //======================================================================================================

            //Finding out if the stock is and show the price for that stock.
            if (ddlStock.SelectedValue == "15" && ddlLabelQuantities.SelectedValue == "50")
            {
                Double Subtotal = 0;

                //Displaying the Subtotal.
                if (SqIn > 0 && SqIn <= 2.5)
                {
                    Subtotal = Stock15_0_2_5SqIn_50Quantity;
                }
                else if (SqIn >= 2.5 && SqIn <= 5)
                {
                    Subtotal = Stock15_2_5_5SqIn_50Quantity;
                }
                else if (SqIn >= 5.1 && SqIn <= 10)
                {
                    Subtotal = Stock15_5_10SqIn_50Quantity;
                }
                else if (SqIn >= 10.1 && SqIn <= 15)
                {
                    Subtotal = Stock15_10_15SqIn_50Quantity;
                }
                else if (SqIn >= 15.1 && SqIn <= 20)
                {
                    Subtotal = Stock15_15_20SqIn_50Quantity;
                }
                else if (SqIn >= 20.1 && SqIn <= 25)
                {
                    Subtotal = Stock15_20_25SqIn_50Quantity;
                }
                else if (SqIn >= 25.1 && SqIn <= 30)
                {
                    Subtotal = Stock15_25_30SqIn_50Quantity;
                }
                else if (SqIn >= 30.1 && SqIn <= 35)
                {
                    Subtotal = Stock15_30_35SqIn_50Quantity;
                }
                else if (SqIn >= 35.1 && SqIn <= 40)
                {
                    Subtotal = Stock15_35_40SqIn_50Quantity;
                }
                else if (SqIn > 40.1)
                {
                    lblCustomQuoteMessage.Text = CustomQuoteMessage;
                }
                //Calculating the price for the colors.
                Double ColorPrice = Stock15Color_50Quantity * Convert.ToDouble(NumberOfColors);

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
            if (ddlStock.SelectedValue == "15" && ddlLabelQuantities.SelectedValue == "100")
            {
                Double Subtotal = 0;

                //Displaying the Subtotal.
                if (SqIn > 0 && SqIn <= 2.5)
                {
                    Subtotal = Stock15_0_2_5SqIn_100Quantity;
                }
                else if (SqIn >= 2.5 && SqIn <= 5)
                {
                    Subtotal = Stock15_2_5_5SqIn_100Quantity;
                }
                else if (SqIn >= 5.1 && SqIn <= 10)
                {
                    Subtotal = Stock15_5_10SqIn_100Quantity;
                }
                else if (SqIn >= 10.1 && SqIn <= 15)
                {
                    Subtotal = Stock15_10_15SqIn_100Quantity;
                }
                else if (SqIn >= 15.1 && SqIn <= 20)
                {
                    Subtotal = Stock15_15_20SqIn_100Quantity;
                }
                else if (SqIn >= 20.1 && SqIn <= 25)
                {
                    Subtotal = Stock15_20_25SqIn_100Quantity;
                }
                else if (SqIn >= 25.1 && SqIn <= 30)
                {
                    Subtotal = Stock15_25_30SqIn_100Quantity;
                }
                else if (SqIn >= 30.1 && SqIn <= 35)
                {
                    Subtotal = Stock15_30_35SqIn_100Quantity;
                }
                else if (SqIn >= 35.1 && SqIn <= 40)
                {
                    Subtotal = Stock15_35_40SqIn_100Quantity;
                }
                else if (SqIn > 40.1)
                {
                    lblCustomQuoteMessage.Text = CustomQuoteMessage;
                }
                //Calculating the price for the colors.
                Double ColorPrice = Stock15Color_100Quantity * Convert.ToDouble(NumberOfColors);

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
            if (ddlStock.SelectedValue == "15" && ddlLabelQuantities.SelectedValue == "250")
            {
                Double Subtotal = 0;

                //Displaying the Subtotal.
                if (SqIn > 0 && SqIn <= 2.5)
                {
                    Subtotal = Stock15_0_2_5SqIn_250Quantity;
                }
                else if (SqIn >= 2.5 && SqIn <= 5)
                {
                    Subtotal = Stock15_2_5_5SqIn_250Quantity;
                }
                else if (SqIn >= 5.1 && SqIn <= 10)
                {
                    Subtotal = Stock15_5_10SqIn_250Quantity;
                }
                else if (SqIn >= 10.1 && SqIn <= 15)
                {
                    Subtotal = Stock15_10_15SqIn_250Quantity;
                }
                else if (SqIn >= 15.1 && SqIn <= 20)
                {
                    Subtotal = Stock15_15_20SqIn_250Quantity;
                }
                else if (SqIn >= 20.1 && SqIn <= 25)
                {
                    Subtotal = Stock15_20_25SqIn_250Quantity;
                }
                else if (SqIn >= 25.1 && SqIn <= 30)
                {
                    Subtotal = Stock15_25_30SqIn_250Quantity;
                }
                else if (SqIn >= 30.1 && SqIn <= 35)
                {
                    Subtotal = Stock15_30_35SqIn_250Quantity;
                }
                else if (SqIn >= 35.1 && SqIn <= 40)
                {
                    Subtotal = Stock15_35_40SqIn_250Quantity;
                }
                else if (SqIn > 40.1)
                {
                    lblCustomQuoteMessage.Text = CustomQuoteMessage;
                }
                //Calculating the price for the colors.
                Double ColorPrice = Stock15Color_250Quantity * Convert.ToDouble(NumberOfColors);

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
            if (ddlStock.SelectedValue == "15" && ddlLabelQuantities.SelectedValue == "500")
            {
                Double Subtotal = 0;

                //Displaying the Subtotal.
                if (SqIn > 0 && SqIn <= 2.5)
                {
                    Subtotal = Stock15_0_2_5SqIn_500Quantity;
                }
                else if (SqIn >= 2.5 && SqIn <= 5)
                {
                    Subtotal = Stock15_2_5_5SqIn_500Quantity;
                }
                else if (SqIn >= 5.1 && SqIn <= 10)
                {
                    Subtotal = Stock15_5_10SqIn_500Quantity;
                }
                else if (SqIn >= 10.1 && SqIn <= 15)
                {
                    Subtotal = Stock15_10_15SqIn_500Quantity;
                }
                else if (SqIn >= 15.1 && SqIn <= 20)
                {
                    Subtotal = Stock15_15_20SqIn_500Quantity;
                }
                else if (SqIn >= 20.1 && SqIn <= 25)
                {
                    Subtotal = Stock15_20_25SqIn_500Quantity;
                }
                else if (SqIn >= 25.1 && SqIn <= 30)
                {
                    Subtotal = Stock15_25_30SqIn_500Quantity;
                }
                else if (SqIn >= 30.1 && SqIn <= 35)
                {
                    Subtotal = Stock15_30_35SqIn_500Quantity;
                }
                else if (SqIn >= 35.1 && SqIn <= 40)
                {
                    Subtotal = Stock15_35_40SqIn_500Quantity;
                }
                else if (SqIn > 40.1)
                {
                    lblCustomQuoteMessage.Text = CustomQuoteMessage;
                }
                //Calculating the price for the colors.
                Double ColorPrice = Stock15Color_500Quantity * Convert.ToDouble(NumberOfColors);

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
            if (ddlStock.SelectedValue == "15" && ddlLabelQuantities.SelectedValue == "1000")
            {
                Double Subtotal = 0;

                //Displaying the Subtotal.
                if (SqIn > 0 && SqIn <= 2.5)
                {
                    Subtotal = Stock15_0_2_5SqIn_1000Quantity;
                }
                else if (SqIn >= 2.5 && SqIn <= 5)
                {
                    Subtotal = Stock15_2_5_5SqIn_1000Quantity;
                }
                else if (SqIn >= 5.1 && SqIn <= 10)
                {
                    Subtotal = Stock15_5_10SqIn_1000Quantity;
                }
                else if (SqIn >= 10.1 && SqIn <= 15)
                {
                    Subtotal = Stock15_10_15SqIn_1000Quantity;
                }
                else if (SqIn >= 15.1 && SqIn <= 20)
                {
                    Subtotal = Stock15_15_20SqIn_1000Quantity;
                }
                else if (SqIn >= 20.1 && SqIn <= 25)
                {
                    Subtotal = Stock15_20_25SqIn_1000Quantity;
                }
                else if (SqIn >= 25.1 && SqIn <= 30)
                {
                    Subtotal = Stock15_25_30SqIn_1000Quantity;
                }
                else if (SqIn >= 30.1 && SqIn <= 35)
                {
                    Subtotal = Stock15_30_35SqIn_1000Quantity;
                }
                else if (SqIn >= 35.1 && SqIn <= 40)
                {
                    Subtotal = Stock15_35_40SqIn_1000Quantity;
                }
                else if (SqIn > 40.1)
                {
                    lblCustomQuoteMessage.Text = CustomQuoteMessage;
                }
                //Calculating the price for the colors.
                Double ColorPrice = Stock15Color_1000Quantity * Convert.ToDouble(NumberOfColors);

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
            if (ddlStock.SelectedValue == "15" && ddlLabelQuantities.SelectedValue == "2000")
            {
                Double Subtotal = 0;

                //Displaying the Subtotal.
                if (SqIn > 0 && SqIn <= 2.5)
                {
                    Subtotal = Stock15_0_2_5SqIn_2000Quantity;
                }
                else if (SqIn >= 2.5 && SqIn <= 5)
                {
                    Subtotal = Stock15_2_5_5SqIn_2000Quantity;
                }
                else if (SqIn >= 5.1 && SqIn <= 10)
                {
                    Subtotal = Stock15_5_10SqIn_2000Quantity;
                }
                else if (SqIn >= 10.1 && SqIn <= 15)
                {
                    Subtotal = Stock15_10_15SqIn_2000Quantity;
                }
                else if (SqIn >= 15.1 && SqIn <= 20)
                {
                    Subtotal = Stock15_15_20SqIn_2000Quantity;
                }
                else if (SqIn >= 20.1 && SqIn <= 25)
                {
                    Subtotal = Stock15_20_25SqIn_2000Quantity;
                }
                else if (SqIn >= 25.1 && SqIn <= 30)
                {
                    Subtotal = Stock15_25_30SqIn_2000Quantity;
                }
                else if (SqIn >= 30.1 && SqIn <= 35)
                {
                    Subtotal = Stock15_30_35SqIn_2000Quantity;
                }
                else if (SqIn >= 35.1 && SqIn <= 40)
                {
                    Subtotal = Stock15_35_40SqIn_2000Quantity;
                }
                else if (SqIn > 40.1)
                {
                    lblCustomQuoteMessage.Text = CustomQuoteMessage;
                }
                //Calculating the price for the colors.
                Double ColorPrice = Stock15Color_2000Quantity * Convert.ToDouble(NumberOfColors);

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
            if (ddlStock.SelectedValue == "15" && ddlLabelQuantities.SelectedValue == "2500")
            {
                Double Subtotal = 0;

                //Displaying the Subtotal.
                if (SqIn > 0 && SqIn <= 2.5)
                {
                    Subtotal = Stock15_0_2_5SqIn_2500Quantity;
                }
                else if (SqIn >= 2.5 && SqIn <= 5)
                {
                    Subtotal = Stock15_2_5_5SqIn_2500Quantity;
                }
                else if (SqIn >= 5.1 && SqIn <= 10)
                {
                    Subtotal = Stock15_5_10SqIn_2500Quantity;
                }
                else if (SqIn >= 10.1 && SqIn <= 15)
                {
                    Subtotal = Stock15_10_15SqIn_2500Quantity;
                }
                else if (SqIn >= 15.1 && SqIn <= 20)
                {
                    Subtotal = Stock15_15_20SqIn_2500Quantity;
                }
                else if (SqIn >= 20.1 && SqIn <= 25)
                {
                    Subtotal = Stock15_20_25SqIn_2500Quantity;
                }
                else if (SqIn >= 25.1 && SqIn <= 30)
                {
                    Subtotal = Stock15_25_30SqIn_2500Quantity;
                }
                else if (SqIn >= 30.1 && SqIn <= 35)
                {
                    Subtotal = Stock15_30_35SqIn_2500Quantity;
                }
                else if (SqIn >= 35.1 && SqIn <= 40)
                {
                    Subtotal = Stock15_35_40SqIn_2500Quantity;
                }
                else if (SqIn > 40.1)
                {
                    lblCustomQuoteMessage.Text = CustomQuoteMessage;
                }
                //Calculating the price for the colors.
                Double ColorPrice = Stock15Color_2500Quantity * Convert.ToDouble(NumberOfColors);

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
            if (ddlStock.SelectedValue == "15" && ddlLabelQuantities.SelectedValue == "5000")
            {
                Double Subtotal = 0;

                //Displaying the Subtotal.
                if (SqIn > 0 && SqIn <= 2.5)
                {
                    Subtotal = Stock15_0_2_5SqIn_5000Quantity;
                }
                else if (SqIn >= 2.5 && SqIn <= 5)
                {
                    Subtotal = Stock15_2_5_5SqIn_5000Quantity;
                }
                else if (SqIn >= 5.1 && SqIn <= 10)
                {
                    Subtotal = Stock15_5_10SqIn_5000Quantity;
                }
                else if (SqIn >= 10.1 && SqIn <= 15)
                {
                    Subtotal = Stock15_10_15SqIn_5000Quantity;
                }
                else if (SqIn >= 15.1 && SqIn <= 20)
                {
                    Subtotal = Stock15_15_20SqIn_5000Quantity;
                }
                else if (SqIn >= 20.1 && SqIn <= 25)
                {
                    Subtotal = Stock15_20_25SqIn_5000Quantity;
                }
                else if (SqIn >= 25.1 && SqIn <= 30)
                {
                    Subtotal = Stock15_25_30SqIn_5000Quantity;
                }
                else if (SqIn >= 30.1 && SqIn <= 35)
                {
                    Subtotal = Stock15_30_35SqIn_5000Quantity;
                }
                else if (SqIn >= 35.1 && SqIn <= 40)
                {
                    Subtotal = Stock15_35_40SqIn_5000Quantity;
                }
                else if (SqIn > 40.1)
                {
                    lblCustomQuoteMessage.Text = CustomQuoteMessage;
                }
                //Calculating the price for the colors.
                Double ColorPrice = Stock15Color_5000Quantity * Convert.ToDouble(NumberOfColors);

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
            if (ddlStock.SelectedValue == "15" && ddlLabelQuantities.SelectedValue == "10000")
            {
                Double Subtotal = 0;

                //Displaying the Subtotal.
                if (SqIn > 0 && SqIn <= 2.5)
                {
                    Subtotal = Stock15_0_2_5SqIn_10000Quantity;
                }
                else if (SqIn >= 2.5 && SqIn <= 5)
                {
                    Subtotal = Stock15_2_5_5SqIn_10000Quantity;
                }
                else if (SqIn >= 5.1 && SqIn <= 10)
                {
                    Subtotal = Stock15_5_10SqIn_10000Quantity;
                }
                else if (SqIn >= 10.1 && SqIn <= 15)
                {
                    Subtotal = Stock15_10_15SqIn_10000Quantity;
                }
                else if (SqIn >= 15.1 && SqIn <= 20)
                {
                    Subtotal = Stock15_15_20SqIn_10000Quantity;
                }
                else if (SqIn >= 20.1 && SqIn <= 25)
                {
                    Subtotal = Stock15_20_25SqIn_10000Quantity;
                }
                else if (SqIn >= 25.1 && SqIn <= 30)
                {
                    Subtotal = Stock15_25_30SqIn_10000Quantity;
                }
                else if (SqIn >= 30.1 && SqIn <= 35)
                {
                    Subtotal = Stock15_30_35SqIn_10000Quantity;
                }
                else if (SqIn >= 35.1 && SqIn <= 40)
                {
                    Subtotal = Stock15_35_40SqIn_10000Quantity;
                }
                else if (SqIn > 40.1)
                {
                    lblCustomQuoteMessage.Text = CustomQuoteMessage;
                }
                //Calculating the price for the colors.
                Double ColorPrice = Stock15Color_10000Quantity * Convert.ToDouble(NumberOfColors);

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