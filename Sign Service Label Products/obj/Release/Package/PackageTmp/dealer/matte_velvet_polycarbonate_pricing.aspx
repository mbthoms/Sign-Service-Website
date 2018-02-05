<%@ Page Title="Matte Velvet Polycarbonate Pricing - Dealer - Sign Service Label Products" Language="C#" MasterPageFile="~/dealer/DealerLogin.Master" AutoEventWireup="true" CodeBehind="matte_velvet_polycarbonate_pricing.aspx.cs" Inherits="Sign_Service_Label_Products.dealer.matte_velvet_polycarbonate_pricing" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
     <div class="container cd-container" id="nav_bar">
        <div class="col-sm-12 col-md-12 col-lg-12">
            <div class="row">
                <section class="page-header">
                    <h1>Matte Velvet Polycarbonate Pricing</h1>
                </section>
            </div>
        </div>

        <!-- =====================================================================================================================================================================
            Quote Form
            =================================================================================================================================================================== -->
        <div class="row">
            <section class="col-12 col-md-4 col-lg-4">

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
                    <asp:TextBox ID="txtNumberOfColours" Value="2" runat="server" CssClass="form-control" />
                    <asp:RequiredFieldValidator ID="RequiredFieldValidator4" ControlToValidate="txtNumberOfColours" runat="server" ErrorMessage="Please Include the Number of Colours"
                        Display="Dynamic" CssClass="label label-danger"></asp:RequiredFieldValidator>
                    <asp:RangeValidator ID="RangeValidator3" runat="server" ControlToValidate="txtNumberOfColours" MinimumValue="2" MaximumValue="999" ErrorMessage="Please choose a number that is 2 or higher." Display="Dynamic" CssClass="label label-danger"></asp:RangeValidator>
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

                <!-- Adhesive
                =================================================================================================================================================================== -->
                <fieldset>
                    <legend>Adhesive</legend>
                    <asp:DropDownList ID="ddlAdhesive" runat="server" CssClass="form-control">
                        <asp:ListItem Text="No Adhesive" Value="0" />
                        <asp:ListItem Text="SS-200 (equivalent to 3M-467)" Value="0.0083" />
                        <asp:ListItem Text="SS-400 (equivalent to 3M-468)" Value="0.01323" />
                        <asp:ListItem Text="3M-467" Value="0.01181" />
                        <asp:ListItem Text="3M-468" Value="0.01421" />
                        <asp:ListItem Text="3M-9471" Value="0.01219"/>
                        <asp:ListItem Text="3M-9471-LE" Value="0.01289"/>
                        <asp:ListItem Text="3M-9472" Value="0.0278"/>
                        <asp:ListItem Text="3M-9472-LE" Value="0.03183"/>
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

                        <asp:Label ID="lblPriceWithoutAdhesive" Text="Cost without Adhesive:" runat="server" />
                        <br />
                        <asp:Label ID="lblAdhesive" Text="Adhesive:" runat="server" />
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

        <!-- Matte Velvet Polycarbonate Information Panel
                =================================================================================================================================================================== -->
        <div id="info-panels" class="row">
            <div class="col-sm-12 col-md-8 col-lg-8">
                <div id="info-panel-pricing" class="panel panel-default">
                    <div class="panel-heading">
                        <h3 class="panel-title"><span class="fa fa-book"></span> Matte Velvet Polycarbonate Information
                        </h3>
                    </div>
                    <div class="panel-body text-center">
                        <p>If you would like more information on the stock that you have selected, click "Matte Velvet Polycarbonate Information".</p>
                        <!-- Vinyl Information trigger to show modal -->
                        <a href="#" class="btn btn-default" data-toggle="modal" data-target="#myModal"><i class="fa fa-folder-open"></i> Matte Velvet Polycarbonate Information</a>
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
                        <h4 class="modal-title" id="myModalLabel">Matte Velvet Polycarbonate Information</h4>
                    </div>
                    <div class="modal-body">
                        <p>Sign Service Label Products has been offering polycarbonate (LEXAN®) to it's customers for over 15 years. It is a product that is widely used in the electronics and telecommunications fields. But has many other uses. Lexan® is ideal for hi profile product markings as well as name plates and even screw covers. It comes in various thickness and textures, it is a clear material that is usually sub surface printed with a solid colour printed background and a .002" adhesive laminated to the backside, trapping the ink between the Lexan® and the adhesive giving it the ultimate abrasion resistance. <br />
                            This pricing covers .010" Matte Velvet LEXAN® which has a pebble like finish. For other styles and thickness please call or fax for a custom quotation. <br />
                            This product is good for application above 50ºF but once the adhesive has set for 72 hours it can withstand indoor temperatures of -40ºF to +300ºF. </p>
                    </div>
                    <div class="modal-footer">
                        <button type="button" class="btn btn-default" data-dismiss="modal">Close</button>
                    </div>
                </div>
            </div>
        </div>

    </div>
    <!-- End of Container -->
</asp:Content>
