<%@ Page Title="Vinyl Lettered Vehicle Magnets - Dealer - Sign Service Label Products" Language="C#" MasterPageFile="~/dealer/DealerLogin.Master" AutoEventWireup="true" CodeBehind="vinyl_lettered_vehicle_magnet_pricing.aspx.cs" Inherits="Sign_Service_Label_Products.dealer.vehicle_magnet_pricing" %>

<%@ Register Src="~/auth.ascx" TagPrefix="uc1" TagName="auth" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <uc1:auth runat="server" ID="auth" />

    <div class="container cd-container" id="nav_bar">
        <div class="col-sm-12 col-md-12 col-lg-12">
            <div class="row">
                <section class="page-header">
                    <h1>Vinyl Lettered Vehicle Magnet Pricing</h1>
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

                <!-- Magnet Size
                =================================================================================================================================================================== -->
                <fieldset class="fieldset-label-size">
                    <legend>Magnet Size</legend>
                    <asp:DropDownList ID="ddlLabelSize" runat="server" CssClass="form-control">
                        <asp:ListItem Text="-Select-" Value="0" />
                        <asp:ListItem Text="12 x 24" Value="1" />
                        <asp:ListItem Text="11 1/2 x 18" Value="2" />
                    </asp:DropDownList> 
                    <asp:Label Text="Sizes are in inches." runat="server" CssClass="label label-info" />
                    <asp:RequiredFieldValidator ID="RequiredFieldValidator1" ControlToValidate="ddlLabelSize" InitialValue="0" runat="server" ErrorMessage="Magnet Size is Required."></asp:RequiredFieldValidator>
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
                        <asp:ListItem Text="2" Value="2" />
                        <asp:ListItem Text="4" Value="4" />
                        <asp:ListItem Text="6" Value="6" />
                        <asp:ListItem Text="8" Value="8" />
                        <asp:ListItem Text="10" Value="10" />
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

        <!-- Vinyl Information Panel
                =================================================================================================================================================================== -->
        <div id="info-panels" class="row">
            <div class="col-sm-12 col-md-8 col-lg-8">
                <div id="info-panel-pricing" class="panel panel-default">
                    <div class="panel-heading">
                        <h3 class="panel-title"><span class="fa fa-book"></span> Vinyl Lettered Vehicle Magnet Information
                        </h3>
                    </div>
                    <div class="panel-body text-center">
                        <p>If you would like more information on the stock that you have selected, click "Vinyl Lettered Vehicle Magnet Information".</p>
                        <!-- Vinyl Information trigger to show modal -->
                        <a href="#" class="btn btn-default" data-toggle="modal" data-target="#myModal"><i class="fa fa-folder-open"></i> Vinyl Lettered Vehicle Magnet Information</a>
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
                        <h4 class="modal-title" id="myModalLabel">Vinyl Lettered Vehicle Magnet Information</h4>
                    </div>
                    <div class="modal-body">
                        <p>Sign Service Label Products offers Vehicle Magnetic Door Signs. This product is printed on a .030" White Magnetic Sheeting. The .030" thickness allows for better magnetic adhesion to the vehicle, but it is recommended to clean behind the door magnet on a regular basis as dirt and dust will get in behind the magnet and affect magnetic adhesion.</p>
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
