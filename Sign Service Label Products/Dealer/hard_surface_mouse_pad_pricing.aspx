<%@ Page Title="Hard Surface Mouse Pad Pricing - Dealer - Sign Service Label Products" Language="C#" MasterPageFile="~/dealer/DealerLogin.Master" AutoEventWireup="true" CodeBehind="hard_surface_mouse_pad_pricing.aspx.cs" Inherits="Sign_Service_Label_Products.dealer.hard_surface_mouse_pad_pricing" %>

<%@ Register Src="~/auth.ascx" TagPrefix="uc1" TagName="auth" %>



<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <uc1:auth runat="server" ID="auth" />
    <div class="container cd-container" id="nav_bar">
        <div class="col-sm-12 col-md-12 col-lg-12">
            <div class="row">
                <section class="page-header">
                    <h1>Digitally Printed Hard Surface Mouse Pads Pricing</h1>
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
                        <asp:ListItem Text="Round Corner" Selected="True" />
                    </asp:RadioButtonList>
                </fieldset>

                <!-- Mouse Pad Size
                =================================================================================================================================================================== -->
                <fieldset class="fieldset-label-size">
                    <legend>Mouse Pad Size:</legend>
                    <asp:DropDownList runat="server" CssClass="form-control">
                        <asp:ListItem Text="7.375 x 9" Value="1" />
                    </asp:DropDownList>
                    <asp:Label Text="Sizes are in inches." runat="server" CssClass="label label-info" />
                </fieldset>
            </section>
            <section class="col-sm-12 col-md-4 col-lg-4">

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

        <!-- Mouse Pad Information Panel
                =================================================================================================================================================================== -->
        <div id="info-panels" class="row">
            <div class="col-sm-12 col-md-8 col-lg-8">
                <div id="info-panel-pricing" class="panel panel-default">
                    <div class="panel-heading">
                        <h3 class="panel-title"><span class="fa fa-book"></span> Mouse Pad Information
                        </h3>
                    </div>
                    <div class="panel-body text-center">
                        <p>If you would like more information on the stock that you have selected, click "Mouse Pad Information".</p>
                        <!-- Vinyl Information trigger to show modal -->
                        <a href="#" class="btn btn-default" data-toggle="modal" data-target="#myModal"><i class="fa fa-folder-open"></i> Mouse Pad Information</a>
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
                        <h4 class="modal-title" id="myModalLabel">Mouse Pad Information</h4>
                    </div>
                    <div class="modal-body">
                        <p>At Sign Service Label Products we offer full colour digitally printed Mouse Pads.<br />
                        We have two options available for pricing on our website. Please remember that custom quotes are always available for other styles of products.<br />
                        Both styles are of a hard surface type that are printed 4 colour process digital with a textured vinyl laminated over the graphic, protecting the images from deteriorating with use.<br />
                        Low height mouse pads are a removable low tack adhesive backed vinyl, that are digitally printed then laminated with textured clear vinyl to be durable and add stability.<br />
                        These mouse pads can be adhered directly onto your desk to provide a durable mouse surface.<br />
                        Standard height mouse pads are a permanent adhesive backed vinyl, that are digitally printed then laminated with textured clear vinyl and then have a mouse pad rubber backing that is laminated onto the back sandwiching the print between.<br />
                        The durability of this product is outstanding coupled with our non-fading printing inks this product makes an attractive and useful product. This product can be custom diecut to any shape (a die charge may apply).</p>

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
