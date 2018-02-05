<%@ Page Title="Polyester Pricing - Dealer - Sign Service Label Products" Language="C#" MasterPageFile="~/Dealer/DealerLogin.Master" AutoEventWireup="true" CodeBehind="polyester_pricing.aspx.cs" Inherits="Sign_Service_Label_Products.Dealer.polyester_pricing" %>

<%@ Register Src="~/auth.ascx" TagPrefix="uc1" TagName="auth" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <uc1:auth runat="server" ID="auth" />
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    
    <div class="container cd-container" id="nav_bar">
        <div class="col-sm-12 col-md-12 col-lg-12">
            <div class="row">
                <section class="page-header">
                    <h1>Polyester (Mylar<span class="superscript-header">&reg;</span>) Pricing</h1>
                </section>
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
                        <asp:ListItem Text="Gloss White Polyester" Value="1" />
                        <asp:ListItem Text="Matte Silver Polyester" Value="2" />
                        <asp:ListItem Text="Bright Silver (Chrome) Polyester" Value="3" />
                        <asp:ListItem Text="Brushed Silver Polyester" Value="4" />
                        <asp:ListItem Text="Clear Polyester" Value="5" />
                        <asp:ListItem Text="Brushed Gold Polyester" Value="6" />
                        <asp:ListItem Text="Computer Printable White Polyester" Value="7" />
                        <asp:ListItem Text="Computer Printable Matte Silver Polyester" Value="8" />
                        <asp:ListItem Text="Void Silver Polyester" Value="9" />
                        <asp:ListItem Text="Bright Gold Polyester" Value="10" />
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
                <fieldset class="fieldset-number-of-colors">
                    <legend>Number of Colours</legend>
                    <asp:Label Text="Number of Colours:" ID="lblNumberOfColours" runat="server" />
                    <asp:TextBox ID="txtNumberOfColours" Value="1" runat="server" CssClass="form-control" />
                    <asp:RequiredFieldValidator ID="RequiredFieldValidator4" ControlToValidate="txtNumberOfColours" runat="server" ErrorMessage="Please Include the Number of Colours"
                        Display="Dynamic" CssClass="label label-danger"></asp:RequiredFieldValidator>
                    <asp:RangeValidator ID="RangeValidator3" runat="server" ControlToValidate="txtNumberOfColours" MinimumValue="1" MaximumValue="999" ErrorMessage="Please choose a number that is 1 or higher." Display="Dynamic" CssClass="label label-danger"></asp:RangeValidator>
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
                        <asp:ListItem Text="290G Extended UV Inhibited Vinyl" Value="0.0106" />
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

        <!-- Vinyl Information Panel
                =================================================================================================================================================================== -->
        <div id="info-panels" class="row">
            <div class="col-sm-12 col-md-8 col-lg-8">
                <div id="info-panel-pricing" class="panel panel-default">
                    <div class="panel-heading">
                        <h3 class="panel-title"><span class="fa fa-book"></span> Polyester Information
                        </h3>
                    </div>
                    <div class="panel-body text-center">
                        <p>If you would like more information on the stock that you have selected, click "Polyester Information".</p>
                        <!-- Vinyl Information trigger to show modal -->
                        <a href="#" class="btn btn-default" data-toggle="modal" data-target="#myModal"><i class="fa fa-folder-open"></i> Polyester Information</a>
                    </div>
                </div>
            </div>
            <div class="col-sm-12 col-md-4 col-lg-4">
            </div>
            <!-- Order Information Panel
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

        </div>
        <!-- /.row -->

        <!-- =====================================================================================================================================================================
            Vinyl Information Modal 
            =================================================================================================================================================================== -->
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
                                    <li><a href="#gloss-white-polyester">Gloss White Polyester</a></li>
                                    <li><a href="#matte-silver-polyester">Matte Silver Polyester</a></li>
                                    <li><a href="#bright-chrome-polyester">Bright Chrome Polyester</a></li>
                                    <li><a href="#brushed-chrome-polyester">Brushed Silver Polyester</a></li>
                                    <li><a href="#clear-polyester">Clear Polyester</a></li>
                                    <li><a href="#brushed-gold-polyester">Brushed Gold Polyester</a></li>
                                    <li><a href="#comp-print-polyester">Computer Printable Polyester White or Matte Silver</a></li>
                                    <li><a href="#comp-print-silver-polyester">Computer Printable Polyester White or Matte Silver</a></li>
                                    <li><a href="#void-silver-polyester">Void Silver Polyester</a></li>
                                    <li><a href="#bright-gold-polyester">Bright Gold Polyester</a></li>
                                </ul>
                            </section>
                            <section class="col-sm-12 col-md-9 col-lg-9">
                                <section id="gloss-white-polyester">
                                    <h2>Gloss White Polyester (Mylar®)</h2>
                                    <p>.002" Gloss White Polyester (Mylar®) has a wide variety of uses' it is an ideal choice for P.O.P displays to product markings. It has a permanent adhesive with a gloss white finish and is ideal for higher temperature uses.</p>
                                    <p>This product is good for application above 50ºF but once the adhesive has set for 72 hours it can withstand outdoor temperatures of -40ºF to +250ºF and has a indoor / outdoor life of 2 - 3 years.</p>
                                </section>
                                <section id="matte-silver-polyester">
                                    <h2>Matte Silver Polyester (Mylar®)</h2>
                                    <p>.002" Matte Silver Polyester (Mylar®) has a wide variety of uses which makes it ideal for P.O.P displays to product markings. It has a permanent adhesive with a Matte Silver finish which makes it easily readable and is ideal for higher temperature uses.</p>
                                    <p>This product is good for application above 50ºF but once the adhesive has set for 72 hours it can withstand outdoor temperatures of -40ºF to +250ºF and has a indoor / outdoor life of 2 - 3 years.</p>
                                </section>
                                <section id="bright-chrome-polyester">
                                    <h2>Bright Chrome Polyester (Mylar®)</h2>
                                    <p>.002" Bright Chrome Polyester (Mylar®) has a wide variety of uses, it is an ideal choice for P.O.P displays to product markings. It has a permanent adhesive with a bright chrome finish and is ideal for higher temperature uses.</p>
                                    <p>This product is good for application above 50ºF but once the adhesive has set for 72 hours it can withstand outdoor temperatures of -40ºF to +250ºF and has a indoor / outdoor life of 2 - 3 years. </p>
                                </section>
                                <section id="brushed-chrome-polyester">
                                    <h2>Brushed Silver Polyester (Mylar®)</h2>
                                    <p>.002" Brushed Silver Polyester (Mylar®) has a wide variety of uses which is ideal for high quality product markings. It has a permanent adhesive with Brushed Silver finish.</p>
                                    <p>This product is good for application above 50ºF but once the adhesive has set for 72 hours it can withstand temperatures of -30ºF to +200ºF.</p>
                                </section>
                                <section id="clear-polyester">
                                    <h2>Clear Polyester (Mylar®)</h2>
                                    <p>.002" Clear Polyester (Mylar®) has a wide variety of uses it is an ideal choice for P.O.P displays to product markings. It has a permanent adhesive with a clear finish stock and is ideal for higher temperature uses.</p>
                                    <p>This product is good for application above 50ºF but once the adhesive has set for 72 hours it can withstand outdoor temperatures of -40ºF to +250ºF and has a indoor / outdoor life of 2 - 3 years.</p>
                                </section>
                                <section id="brushed-gold-polyester">
                                    <h2>Brushed Gold Polyester (Mylar®)</h2>
                                    <p>.002" Brushed Gold Polyester (Mylar®) has a wide variety of uses which is ideal for high quality product markings . It has a permanent adhesive with Brushed Gold finish.</p>
                                    <p>This product is good for application above 50ºF but once the adhesive has set for 72 hours it can withstand temperatures of -30ºF to +200ºF.</p>
                                </section>
                                <section id="comp-print-polyester">
                                    <h2>Computer Printable Polyester (Mylar®) White or Matte Silver</h2>
                                    <p>.002" Computer Printable Polyester (Mylar®) has a wide variety of uses which are ideal for asset tags to serialized product markings. It has a permanent adhesive with matte silver or white finish.</p>
                                    <p>This product is good for application above 50ºF but once the adhesive has set for 72 hours it can withstand temperatures of -40ºF to +250ºF.</p>
                                </section>
                                <section id="comp-print-silver-polyester">
                                    <h2>Computer Printable Polyester (Mylar®) White or Matte Silver</h2>
                                    <p>.002" Computer Printable Polyester (Mylar®) has a wide variety of uses which are ideal for asset tags to serialized product markings. It has a permanent adhesive with matte silver or white finish.</p>
                                    <p>This product is good for application above 50ºF but once the adhesive has set for 72 hours it can withstand temperatures of -40ºF to +250ºF.</p>    
                                </section>
                                <section id="void-silver-polyester">
                                    <h2>Void Silver Polyester (Mylar®)</h2>
                                    <p>.002" Void Silver Polyester (Mylar®) has a wide variety of uses, which makes it an ideal product for security markings. The adhesive has a pattern within it that says void. When it is attempted to be removed, it removes the word void from the silver background and cannot be replaced into position without easily seeing that the label has been tampered with.</p>
                                    <p>This product has a permanent adhesive that is good for indoor / outdoor use.</p>
                                    <p>This product is good for application above 50ºF but once the adhesive has set for 72 hours it can withstand temperatures of -30ºF to +250ºF and has a life of 2 - 3 years.</p>
                                </section>
                                <section id="bright-gold-polyester">
                                    <h2>Bright Gold Polyester (Mylar®)</h2>
                                    <p>.002" Bright Gold Polyester (Mylar®) has a wide variety of uses which is ideal for P.O.P displays to product markings. It has a permanent adhesive with a Bright Gold finish similar to gold foil and is ideal for higher temperature uses.</p>
                                    <p>This product is good for application above 50ºF but once the adhesive has set for 72 hours it can withstand temperatures of -40ºF to +250ºF.</p>
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
