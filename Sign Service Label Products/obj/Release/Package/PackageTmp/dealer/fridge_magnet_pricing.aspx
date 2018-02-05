<%@ Page Title="Screen Printed Fridge Magnet Pricing - Desler - Sign Service Label Products" Language="C#" MasterPageFile="~/dealer/DealerLogin.Master" AutoEventWireup="true" CodeBehind="fridge_magnet_pricing.aspx.cs" Inherits="Sign_Service_Label_Products.dealer.fridge_magnet_pricing" %>

<%@ Register Src="~/auth.ascx" TagPrefix="uc1" TagName="auth" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <uc1:auth runat="server" ID="auth" />
     <div class="container cd-container" id="nav_bar">
        <div class="col-sm-12 col-md-12 col-lg-12">
            <div class="row">
                <section class="page-header">
                    <h1>Screen Printed Fridge Magnet Pricing</h1>
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
                    <asp:DropDownList ID="ddlLabelSize" runat="server" CssClass="form-control">
                        <asp:ListItem Text="2x2 Inches" Value="1" />
                        <asp:ListItem Text="2x3 Inches" Value="2" />
                        <asp:ListItem Text="2x3.5 Inches" Value="3" />
                    </asp:DropDownList>
                    <asp:Label Text="Sizes are in inches." runat="server" CssClass="label label-info" />
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
                    <asp:RangeValidator ID="RangeValidator3" runat="server" ControlToValidate="txtNumberOfColours" Type="Integer" MinimumValue="1" MaximumValue="999" ErrorMessage="Please choose a number that is 1 or higher." Display="Dynamic" CssClass="label label-danger"></asp:RangeValidator>
                </fieldset>
                
                <!-- Label Quantities
                =================================================================================================================================================================== -->
                <fieldset>
                    <legend>Label Quantities</legend>
                    <asp:Label Text="Label Quantities:" ID="lblLabelQuantities" runat="server" />
                    <asp:DropDownList ID="ddlLabelQuantities" runat="server" CssClass="form-control">
                        <asp:ListItem Text="-Select a Quantity-" Value="0" />
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


                <!-- Submit Button for the form -->
                <asp:LinkButton ID="btnFindPrices" runat="server" OnClick="btnFindPrices_Click" CssClass="btn btn-primary btn-block padding-btn"><i class="fa fa-usd"></i>&nbsp;Get Quote</asp:LinkButton>
            </section>
            <section class="col-sm-12 col-md-4 col-lg-4">

                <!-- Quote Form Pricing
                =================================================================================================================================================================== -->
                <fieldset>
                    <legend>Pricing for the Current Selection</legend>
                    <div class="well">

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
                        <h3 class="panel-title"><span class="fa fa-info-circle"></span> Fridge Magnet Information
                        </h3>
                    </div>
                    <div class="panel-body text-center">
                        <p>If you would like more information on the stock that you have selected, Click "Fridge Magnet Information".</p>
                        
                        <!-- Fridge Magnet Information trigger to show modal -->
                        <a href="#" class="btn btn-default" data-toggle="modal" data-target="#myModal"><i class="fa fa-book"></i> Fridge Magnet Information</a>
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
                            <h4 class="modal-title" id="myModalLabel">Fridge Magnet Information</h4>
                        </div>
                        <div class="modal-body">
                            <div class="row">
                                <section class="col-sm-12 col-md-12 col-lg-12">
                                    <p>Sign Service Label Products has offered custom screen printed fridge and file cabinet magnets for over 20 years. This product allows you to advertise in one of the fastest growing media markets in North America today. Once distributed these magnets will give your customer repeated advertising throughout the year. Imagine for a minute how much exposure your customers company will receive, if every time someone opens a fridge or file cabinet. Their name is there telling them what they do. This product is a .020" white magnetic sheeting and can be die cut to any custom shape for an additional die charge.</p>
                                    
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
