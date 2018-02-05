<%@ Page Title="Digitally Printed Vinyl Pricing - Dealer - Sign Service Label Products" Language="C#" MasterPageFile="~/Dealer/DealerLogin.Master" AutoEventWireup="true" CodeBehind="digital_vinyl_pricing.aspx.cs" Inherits="Sign_Service_Label_Products.Dealer.digital_vinyl_pricing" %>

<%@ Register Src="~/auth.ascx" TagPrefix="uc1" TagName="auth" %>


<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <uc1:auth runat="server" ID="auth" />

    <div class="container cd-container" id="nav_bar">
        <div class="col-sm-12 col-md-12 col-lg-12">
            <div class="row">
                <section class="page-header">
                    <h1>Digitally Printed Vinyl Pricing</h1>
                </section>
            </div>
        </div>

        <!-- =====================================================================================================================================================================
            Quote Form
            =================================================================================================================================================================== -->
        <div class="row">
            <section class="col-12 col-md-4 col-lg-4">
                

                <!-- Stock Dropdown
                =================================================================================================================================================================== -->
                <fieldset class="fieldset-stock">
                    <legend>Select a Stock</legend>
                    <asp:Label Text="Stock:" ID="lblStock" runat="server" />
                    <asp:DropDownList ID="ddlStock" runat="server" CssClass="form-control">
                        <asp:ListItem Text="-Select a Stock-" Value="0" />
                        <asp:ListItem Text="Matte White Vinyl" Value="1" />
                        <asp:ListItem Text="Gloss White Vinyl" Value="15" />
                        <asp:ListItem Text="Hi Tack Vinyl" Value="11" />
                        <asp:ListItem Text="White Hi-Tack 156 Vinyl" Value="4" />
                        <asp:ListItem Text="Matte White Removable Vinyl" Value="2" />
                        <asp:ListItem Text="Low Tack White Vinyl" Value="7" />
                        <asp:ListItem Text="Clear Vinyl" Value="8" />
                        <asp:ListItem Text="Low Tack Clear Vinyl" Value="10" />
                        <asp:ListItem Text="Clear Static Cling Vinyl" Value="9" />
                        <asp:ListItem Text="White Static Cling Vinyl" Value="6" />
                        <asp:ListItem Text="Light Yellow Vinyl" Value="14" />
                        <asp:ListItem Text="3M 3290 White Reflective" Value="3" />
                        <asp:ListItem Text="Destructible Vinyl" Value="13" />
                    </asp:DropDownList>
                    <asp:RequiredFieldValidator ID="RequiredFieldValidator1" ControlToValidate="ddlStock" InitialValue="0" runat="server" ErrorMessage="Please Select a Stock in order to get a quote."
                        Display="Dynamic" CssClass="label label-danger"></asp:RequiredFieldValidator>
                </fieldset>

                <!-- Corner Cut Options
                =================================================================================================================================================================== -->
                <fieldset>
                    <legend>Corner Cut Options</legend>
                    <asp:RadioButtonList ID="rblCornerCutOption" runat="server">
                        <asp:ListItem Text="Square Cut" Selected="True" />
                        <asp:ListItem Text="Round Corner" />
                    </asp:RadioButtonList>
                </fieldset>

                <!-- Label Size
                =================================================================================================================================================================== -->
                <fieldset class="fieldset-label-size">
                    <legend>Label Size</legend>
                    <asp:Label Text="Label Height:" ID="lblLabelHeight" runat="server" />
                    <asp:TextBox ID="txtLabelHeight" runat="server" CssClass="form-control" />
                    <asp:RequiredFieldValidator ID="RequiredFieldValidator2" ControlToValidate="txtLabelHeight" runat="server" ErrorMessage="Please Include a Height Value."
                        Display="Dynamic" CssClass="label label-danger"></asp:RequiredFieldValidator>
                    <asp:RangeValidator ID="RangeValidator1" ControlToValidate="txtLabelHeight" MinimumValue="0" MaximumValue="9999999999999" Type="Double" runat="server" ErrorMessage="Must be a number." Display="Dynamic" CssClass="label label-danger"></asp:RangeValidator>
                    <br />
                    <asp:Label Text="Label Width:" runat="server" />
                    <asp:TextBox ID="txtLabelWidth" runat="server" CssClass="form-control" />
                    <asp:Label Text="Sizes are in inches." runat="server" CssClass="label label-info" />
                    <asp:RequiredFieldValidator ID="RequiredFieldValidator3" ControlToValidate="txtLabelWidth" runat="server" ErrorMessage="Please Include a Width Value"
                        Display="Dynamic" CssClass="label label-danger"></asp:RequiredFieldValidator>
                    <asp:RangeValidator ID="RangeValidator2" ControlToValidate="txtLabelWidth" MinimumValue="0" MaximumValue="9999999999999" Type="Double" runat="server" ErrorMessage="Must be a number." Display="Dynamic" CssClass="label label-danger"></asp:RangeValidator>
                </fieldset>
            </section>
            <section class="col-sm-12 col-md-4 col-lg-4">

                <!-- Number of Colours
                =================================================================================================================================================================== -->
                <p>Digitally printed labels are printed CMYK. Pantone colours will be matched as close as possible. White or metallic colours are not available on digital labels.</p>
                <fieldset class="fieldset-number-of-colors-digital-vinyl">
                    <legend>Number of Colours</legend>
                    <asp:Label Text="Number of Colours:" ID="lblNumberOfColours" runat="server" />
                    <asp:TextBox ID="txtNumberOfColours" Value="1" runat="server" CssClass="form-control" />
                </fieldset>
                
                <!-- Label Quantities
                =================================================================================================================================================================== -->
                <fieldset>
                    <legend>Label Quantities</legend>
                    <asp:Label Text="Label Quantities:" ID="lblLabelQuantities" runat="server" />
                    <asp:DropDownList ID="ddlLabelQuantities" runat="server" CssClass="form-control">
                        <asp:ListItem Text="-Select a Quantity-" Value="0" />
                        <asp:ListItem Text="50" Value="50" />
                        <asp:ListItem Text="100" Value="100" />
                        <asp:ListItem Text="250" Value="250" />
                        <asp:ListItem Text="500" Value="500" />
                        <asp:ListItem Text="1,000" Value="1000" />
                        <asp:ListItem Text="2,000" Value="2000" />
                        <asp:ListItem Text="2,500" Value="2500" />
                        <asp:ListItem Text="5,000" Value="5000" />
                        <asp:ListItem Text="10,000" Value="10000" />
                    </asp:DropDownList>
                    <asp:RequiredFieldValidator ID="RequiredFieldValidator5" ControlToValidate="ddlLabelQuantities" InitialValue="0" Display="Dynamic"
                        runat="server" ErrorMessage="Please Indicate how many labels you are looking for." CssClass="label label-danger"></asp:RequiredFieldValidator>
                </fieldset>

                <!-- Overlamination
                =================================================================================================================================================================== -->
                <fieldset>
                    <legend>Overlamination</legend>
                    <asp:DropDownList ID="ddlLamination" runat="server" CssClass="form-control">
                        <asp:ListItem Text="No Lamination" Value="0" />
                        <asp:ListItem Text=".001 Inch Gloss Clear Polyester Lamination" Value="0.0032" />
                        <asp:ListItem Text="210G UV Inhibited Vinyl Lamination" Value="0.0058" />
                        <asp:ListItem Text=".001 Inch Matte Clear Polyester Lamination" Value="0.0037" />
                    </asp:DropDownList>
                </fieldset>

                <!-- Submit Button for the form -->
                <asp:LinkButton ID="btnFindPrices" runat="server" OnClick="btnFindPrices_Click" CssClass="btn btn-primary btn-block padding-btn"><i class="fa fa-usd"></i>&nbsp;Get Quote</asp:LinkButton>
            </section>
            <section class="col-sm-12 col-md-4 col-lg-4">

                <!-- Quote Form Pricing
                =================================================================================================================================================================== -->
                <fieldset>
                    <legend>Pricing for the Current Selection</legend>
                    <div class="well">

                        <asp:Label ID="lblPriceWithoutLamination" Text="Cost without Lamination:" runat="server" />
                        <br />
                        <asp:Label ID="lblOverlamination" Text="Overlamination:" runat="server" />
                        <br />
                        <div class="total-pricing-amount">
                            <asp:Label ID="lblTotal" Text="Total:*" runat="server" />
                            <asp:Label ID="lblCustomQuoteMessage" Text="" runat="server" CssClass=" label label-danger custom-quote-message" />
                        </div>
                        <asp:Label ID="lblPlusTax" Text="*Plus Applicable Taxes." runat="server" />
                    </div>
                </fieldset>

            </section>
            <!-- End of Form Section -->
        </div>
        <!-- /.row -->

        <!-- =====================================================================================================================================================================
            Information Panels
            =================================================================================================================================================================== -->

        <!-- Vinyl Information Bubble
                =================================================================================================================================================================== -->
        <div id="vinyl-info" class="row">
            <div class="col-sm-12 col-md-8 col-lg-8">
                <div id="info-panel-pricing" class="panel panel-default">
                    <div class="panel-heading">
                        <h3 class="panel-title"><span class="fa fa-info-circle"></span> Vinyl Information
                        </h3>
                    </div>
                    <div class="panel-body text-center">
                        <p>If you would like more information on the stock that you have selected, Click "Vinyl Information".</p>
                        
                        <!-- Vinyl Information trigger to show modal -->
                        <a href="#" class="btn btn-default" data-toggle="modal" data-target="#myModal"><i class="fa fa-book"></i> Vinyl Information</a>
                    </div>
                </div>
            </div>
            <div class="col-sm-12 col-md-4 col-lg-4">
            </div>

            <!-- Order Information
                =================================================================================================================================================================== -->
            <div class="col-sm-12 col-md-4 col-lg-4">
                <div id="info-panel-pricing" class="panel panel-info">
                    <div class="panel-heading">
                        <h3 class="panel-title"><span class="fa fa-question-circle"></span> Looking to Order?
                        </h3>
                    </div>
                    <div class="panel-body text-center">
                        You can order by sending an email to <a href="mailto:sales@signservice.com">sales@signservice.com</a> with a subject line of QUOTE and then your company's name.
                    </div>
                </div>
            </div>

            <!-- =====================================================================================================================================================================
            Vinyl Information Modal 
            ====================================================================================================================================================================== -->
            <div class="modal fade" id="myModal" tabindex="-1" role="dialog" aria-labelledby="myModalLabel">
                <div class="modal-dialog modal-lg" role="document">
                    <div class="modal-content">
                        <div class="modal-header">
                            <button type="button" class="close" data-dismiss="modal" aria-label="Close"><span aria-hidden="true">&times;</span></button>
                            <h4 class="modal-title" id="myModalLabel">Vinyl Information</h4>
                        </div>
                        <div class="modal-body">
                            <div class="row">
                                <section class="col-sm-12 col-md-3 col-lg-3">
                                    <h2>List of Stock Information</h2>
                                    <ul id="stock-list">
                                        <li><a href="#matte-white-vinyl">Matte White</a></li>
                                        <li><a href="#matte-white-removable-vinyl">Matte White Removable</a></li>
                                        <li><a href="#matte-safety-yellow-vinyl">Matte Safety Yellow</a></li>
                                        <li><a href="#white-hi-tack-156-vinyl">White Hi Tack 156</a></li>
                                        <li><a href="#blockout-white-vinyl">Blockout White</a></li>
                                        <li><a href="#static-cling-vinyl">Static Cling White or Clear</a></li>
                                        <li><a href="#low-tack-vinyl">Low Tack White or Clear Vinyl</a></li>
                                        <li><a href="#clear-vinyl">Clear</a></li>
                                        <li><a href="#hi-tack-white-vinyl">Hi Tack White Vinyl</a></li>
                                        <li><a href="#destructible-vinyl">Destructible</a></li>
                                        <li><a href="#matte-light-yellow-vinyl">Matte Light Yellow</a></li>
                                        <li><a href="#gloss-white-vinyl">Gloss White</a></li>
                                    </ul>
                                </section>
                                <section class="col-sm-12 col-md-9 col-lg-9">
                                    <section id="matte-white-vinyl">
                                        <h2>Matte White Vinyl</h2>
                                        <p>.004" Matte White Vinyl is one of our most cost effective stocks, with it's wide variety of uses, it is an ideal product for anything from P.O.P display labels to product markings.</p>
                                        <p>This product is good for application above 50ºF but once the adhesive has set for 72 hours it can withstand outdoor temperatures of -30ºF to +170ºF and has an indoor/outdoor expected life of 2-3 years.</p>
                                    </section>
                                    <section id="matte-white-removable-vinyl">
                                        <h2>Matte White Removable Vinyl</h2>
                                        <p>.004" Matte White Removable Vinyl has a wide variety of uses which makes it ideal for anything from P.O.P display labels to product markings. It's removable adhesive makes it a great temporary label and will stay removable for up to six months, after that it will leave an adhesive residue behind when removed. This product will last longer indoor or outdoor then the six months but will leave the residue behind when removed.</p>
                                        <p>This Product is good for application above 50ºF but once the adhesive has set for 72 hours it can withstand outdoor temperatures of -30ºF to +170ºF.</p>
                                    </section>
                                    <section id="matte-safety-yellow-vinyl">
                                        <h2>Matte Safety Yellow Vinyl</h2>
                                        <p>.004" Matte Safety Yellow Vinyl has a wide variety of uses which makes it ideal for anything from P.O.P display labels to product markings. The colour is close to PMS 123 which makes it perfect for safety and caution labels or where you require a high contrast background.</p>
                                        <p>This product is good for application above 50ºF but once the adhesive has set for 72 hours it can withstand indoor / outdoor temperatures of -30ºF to +170ºF.</p>
                                    </section>
                                    <section id="white-hi-tack-156-vinyl">
                                        <h2>White Hi Tack 156 Vinyl</h2>
                                        <p>.004" White Hi Tack 156 Vinyl has a wide variety of uses which makes it ideal for anything from P.O.P display labels to vehicle markings. It has a high tack adhesive that allows cold temperature application. Once adhesive has setup this makes a very permanent label.</p>
                                        <p>This Product is good for application above 32ºF but once the adhesive has set for 72 hours it can withstand outdoor temperatures of -30ºF to +170ºF.</p>
                                    </section>
                                    <section id="blockout-white-vinyl">
                                        <h2>Blockout White Vinyl</h2>
                                        <p>.004" Blockout White Vinyl has a wide variety of uses which makes it ideal for covering from old P.O.P displays to product markings . It has a permanent adhesive with a white finish.</p>
                                        <p>Within the adhesive is a silver-grey blocker so that previous markings underneath where you apply the label will not show through.</p>
                                        <p>This product is good for application above 50ºF but once the adhesive has set for 72 hours it can withstand outdoor temperatures of -30ºF to +170ºF.</p>
                                    </section>
                                    <section id="static-cling-vinyl">
                                        <h2>Static Cling White or Clear Vinyl</h2>
                                        <p>.008" Static Cling Vinyl comes either in white or clear and has a wide variety of uses which makes it ideal for anything from product protection labels to window decals. The static cling properties make it ideal to apply where removal and reuse are a benefit.</p>
                                        <p>This product is good for application above 50ºF on a clean surface and it can withstand temperatures of -30ºF to +170ºF</p>
                                    </section>
                                    <section id="low-tack-vinyl">
                                        <h2>Low Tack White or Clear Vinyl</h2>
                                        <p>.004" Low Tack Vinyl comes either in white or clear and has a wide variety of uses which makes it ideal for anything from P.O.P display labels to Window Decals. It has a low tack adhesive that makes it adhere better then a static cling label but just as removable.</p>
                                        <p>This product is good for application above 50ºF but once the adhesive has set for 72 hours it can withstand temperatures of -30ºF to +170ºF. </p>
                                    </section>
                                    <section id="clear-vinyl">
                                        <h2>Clear Vinyl</h2>
                                        <p>.004" Clear Vinyl has a wide variety of uses which makes it ideal for anything from P.O.P display labels to product markings & vehicle markings.</p>
                                        <p>This product is good for application above 50ºF but once the adhesive has set for 72 hours it can withstand outdoor temperatures of -30ºF to +170ºF and has an indoor/outdoor expected life of 1-2 years.</p>
                                    </section>
                                    <section id="hi-tack-white-vinyl">
                                        <h2>Hi Tack White Vinyl</h2>
                                        <p>.004" 5 Year Outdoor Hi Tack White Vinyl has a wide variety of uses, which makes it ideal for anything from P.O.P display labels to vehicle markings. It's specially designed adhesive coupled with it's extended life vinyl make it great for applying to hard to adhere to surfaces like polyetholine.</p>
                                        <p>This product is good for application above 50ºF but once the adhesive has set for 72 hours it can withstand indoor / outdoor temperatures of -30ºF to +170ºF.</p>
                                    </section>
                                    <section id="destructible-vinyl">
                                        <h2>Destructible Vinyl</h2>
                                        <p>.0025" Destructible Vinyl is a great destructible stock used in tamper proof markings. When this stock is attempted to be removed after the adhesive has set for 72 hours, the product breaks apart into very small hard to remove pieces. This stock has a hi-tack permanent adhesive. </p>
                                        <p></p>
                                    </section>
                                    <section id="matte-light-yellow-vinyl">
                                        <h2>Matte Light Yellow Vinyl</h2>
                                        <p>.004" Matte Light Yellow Vinyl has a wide variety of uses which makes it ideal for anything from P.O.P display labels to product markings. The colour is close to Pantone® Yellow making it great where a lighter yellow background is needed.</p>
                                        <p>This product is good for application above 50ºF but once the adhesive has set for 72 hours it can withstand outdoor temperatures of -30ºF to +170ºF and has an indoor/outdoor expected life of 2-3 years.</p>
                                    </section>
                                    <section id="gloss-white-vinyl">
                                        <h2>Gloss White Vinyl</h2>
                                        <p>.004" Gloss White Vinyl has a wide variety of uses which makes it ideal for anything from P.O.P display labels to product markings. It has a permanent adhesive with a gloss white finish.</p>
                                        <p>This product is good for application above 50ºF but once the adhesive has set for 72 hours it can withstand outdoor temperatures of -30ºF to +170ºF.</p>
                                    </section>
                                </section>
                                <!-- End of Col -->
                            </div>
                        </div>
                        <div class="modal-footer">
                            <button type="button" class="btn btn-default" data-dismiss="modal">Close</button>
                        </div>
                    </div>
                </div>
            </div>
        </div>
    </div>
    <!-- End of Container -->
</asp:Content>
