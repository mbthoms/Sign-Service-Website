<%@ Page Title="" Language="C#" MasterPageFile="~/dealer/DealerLogin.Master" AutoEventWireup="true" CodeBehind="parking_hang_tag_two_sided_pricing.aspx.cs" Inherits="Sign_Service_Label_Products.dealer.parking_hang_tags_two_sided" %>

<%@ Register Src="~/auth.ascx" TagPrefix="uc1" TagName="auth" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <uc1:auth runat="server" ID="auth" />
    <div class="container cd-container" id="nav_bar">
        <div class="col-sm-12 col-md-12 col-lg-12">
            <div class="row">
                <section class="page-header">
                    <h1>Parking Hang Tags Pricing<small> Two Sided</small></h1>
                </section>
            </div>
        </div>

        <!-- =====================================================================================================================================================================
            Quote Form
            =================================================================================================================================================================== -->
        <div class="row">
            <section class="col-12 col-md-4 col-lg-4">


                <!-- Side Options
                =================================================================================================================================================================== -->
                <fieldset>
                    <legend>Side Options</legend>
                    <asp:DropDownList ID="ddlSideOption" runat="server" CssClass="form-control">
                        <asp:ListItem Text="Two Sided" Value="2" />
                    </asp:DropDownList>
                    <asp:RequiredFieldValidator ID="RequiredFieldValidator2" ControlToValidate="ddlSideOption" InitialValue="0" runat="server" ErrorMessage="Side Option Required." CssClass="label label-danger"></asp:RequiredFieldValidator>
                </fieldset>



                <!-- Consecutive Number Options
                =================================================================================================================================================================== -->
                <fieldset>
                    <legend>Consecutive Number</legend>
                    <asp:Label ID="lblConsecutiveNumber" Text="Consecutive Number:" runat="server" />
                    <asp:DropDownList ID="ddlConsecutiveNumber" runat="server" CssClass="form-control">
                        <asp:ListItem Text="-Select-" Value="0" />
                        <asp:ListItem Text="No Consecutive Number" Value="0.00"/>
                        <asp:ListItem Text="Consecutive Number" Value="0.10" />
                    </asp:DropDownList>
                    <asp:RequiredFieldValidator ID="RequiredFieldValidator6" ControlToValidate="ddlConsecutiveNumber" InitialValue="0" runat="server" ErrorMessage="Consecutive Number Option Required." CssClass="label label-danger"></asp:RequiredFieldValidator>
                </fieldset>

                <!-- Tag Size
                =================================================================================================================================================================== -->
                <fieldset class="fieldset-label-size">
                    <legend>Tag Size</legend>
                    <asp:Label ID="lblLabelSize" Text="Label Size:" runat="server" />
                    <asp:DropDownList ID="ddlLabelSize" runat="server" CssClass="form-control">
                        <asp:ListItem Text="-Select-" Value="0" />
                        <asp:ListItem Text="2.5 x 4.5 Inches" Value="1" />
                        <asp:ListItem Text="2.75 x 6.5 Inches" Value="2" />
                    </asp:DropDownList>
                    <asp:Label Text="Sizes are in inches." runat="server" CssClass="label label-info" />
                    <asp:RequiredFieldValidator ID="RequiredFieldValidator1" ControlToValidate="ddlLabelSize" runat="server" InitialValue="0" ErrorMessage="Label Size is Required." CssClass="label label-danger"></asp:RequiredFieldValidator>
                </fieldset>
            </section>
            <section class="col-sm-12 col-md-4 col-lg-4">

                <!-- Number of Colours
                =================================================================================================================================================================== -->
                <fieldset class="fieldset-number-of-colors">
                    <legend>Number of Colours</legend>
                    <asp:Label Text="Front Colours" ID="lblNumberOfColours" runat="server" />
                    <asp:TextBox ID="txtNumberOfColours" Value="1" runat="server" CssClass="form-control" />
                    <asp:RequiredFieldValidator ID="RequiredFieldValidator4" ControlToValidate="txtNumberOfColours" runat="server" ErrorMessage="Please Include the Number of Colours"
                        Display="Dynamic" CssClass="label label-danger"></asp:RequiredFieldValidator>
                    <asp:RangeValidator ID="RangeValidator3" runat="server" ControlToValidate="txtNumberOfColours" Type="Integer" MinimumValue="1" MaximumValue="999" ErrorMessage="Please choose a number that is 1 or higher." Display="Dynamic" CssClass="label label-danger"></asp:RangeValidator>
                    
                    <asp:Label ID="lblBackColours" Text="Back Colours" runat="server" />
                    <asp:TextBox ID="txtBackColours" Value="1" runat="server" CssClass="form-control" />
                    <asp:RequiredFieldValidator ID="RequiredFieldValidator3" ControlToValidate="txtBackColours" runat="server" ErrorMessage="Please choose a number that is 1 or higher." CssClass="label label-danger"></asp:RequiredFieldValidator>
                     <asp:RangeValidator ID="RangeValidator1" runat="server" ControlToValidate="txtBackColours" Type="Integer" MinimumValue="1" MaximumValue="999" ErrorMessage="Please choose a number that is 0 or higher." Display="Dynamic" CssClass="label label-danger"></asp:RangeValidator>
                </fieldset>
                
                <!-- Tag Quantities
                =================================================================================================================================================================== -->
                <fieldset>
                    <legend>Tag Quantities</legend>
                    <asp:Label Text="Tag Quantities:" ID="lblLabelQuantities" runat="server" />
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
                            <asp:Label ID="Con" Text="" runat="server" />
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
                        <h3 class="panel-title"><span class="fa fa-info-circle"></span> Parking Hang Tag Information
                        </h3>
                    </div>
                    <div class="panel-body text-center">
                        <p>If you would like more information on the stock that you have selected, Click "Parking Hang Tag Information".</p>
                        
                        <!-- Vinyl Information trigger to show modal -->
                        <a href="#" class="btn btn-default" data-toggle="modal" data-target="#myModal"><i class="fa fa-book"></i> Parking Hang Tag Information</a>
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
                            <h4 class="modal-title" id="myModalLabel">Parking Hang Tag Information</h4>
                        </div>
                        <div class="modal-body">
                            <p>Sign Service Label Products offers Parking Hang Tags. This product hangs from the rear view mirror, allowing the ability to transfer easily between vehicles, as well as giving great visibility for parking staff to ensure the vehicle is permitted to park in that lot. This product is a .020" polycarbonate with an opaque white finish allowing the best stability during the high temperatures inside a vehicle at times.</p>
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
