<%@ Page Title="Window Decals Single Sided Pricing - Dealer - Sign Service Label Products" Language="C#" MasterPageFile="~/Dealer/DealerLogin.Master" AutoEventWireup="true" CodeBehind="single_sided_window_decal_pricing.aspx.cs" Inherits="Sign_Service_Label_Products.Dealer.window_decal_pricing" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
     
    <div class="container cd-container" id="nav_bar">
        <div class="col-sm-12 col-md-12 col-lg-12">
            <div class="row">
                <section class="page-header">
                    <h1>Window Decal Pricing<small> Single Sided</small></h1>
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
                        <asp:ListItem Text="Clear Polyester" Value="1" />
                        <asp:ListItem Text="Clear Static Cling" Value="2" />
                        <asp:ListItem Text="Clear Low Tack Vinyl" Value="3" />
                    </asp:DropDownList>
                    <asp:RequiredFieldValidator ID="RequiredFieldValidator1" ControlToValidate="ddlStock" InitialValue="0" runat="server" ErrorMessage="Please Select a Stock in order to get a quote."
                        Display="Dynamic" CssClass="label label-danger"></asp:RequiredFieldValidator>
                </fieldset>
                <!-- Corner Cut Options
                =================================================================================================================================================================== -->
                <!-- This doesn't do anything. -->
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
                <asp:Label Text="Base price includes one colour plus a white background colour." runat="server" CssClass="label label-info" />
                

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
                        <asp:ListItem Text=".001 Inch Gloss Clear Polyester Lamination" Value="0.006" />
                        <asp:ListItem Text="210G UV Inhibited Vinyl Lamination" Value="0.02" />
                        <asp:ListItem Text="290G Extended UV Inhibited Vinyl" Value="0.1" />
                        <asp:ListItem Text=".001 Inch Matte Clear Polyester Lamination" Value="0.2" />
                    </asp:DropDownList>
                </fieldset>
                <!-- Submit Button for the form -->
                <asp:LinkButton ID="btnFindPrices" runat="server" OnClick="btnFindPrices_Click1" CssClass="btn btn-primary btn-block padding-btn"><i class="fa fa-usd"></i>&nbsp;Get Quote</asp:LinkButton>
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
                        <h3 class="panel-title"><span class="fa fa-book"></span> Window Decal Information
                        </h3>
                    </div>
                    <div class="panel-body text-center">
                        <p>If you would like more information on the stock that you have selected, Click "Window Decal Information".</p>
                        <!-- Vinyl Information trigger to show modal -->
                        <a href="#" class="btn btn-default" data-toggle="modal" data-target="#myModal"><i class="fa fa-folder-open"></i> Window Decal Information</a>
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
                                    <li><a href="#clear-polyester">One Sided Window Decal on Clear Polyester </a></li>
                                    <li><a href="#static-cling">One Sided Window Decal on Clear Static Cling Vinyl</a></li>
                                    <li><a href="#low-tack-clear">One Sided Window Decal on Clear Low Tack Vinyl</a></li>
                                </ul>
                            </section>
                            <section class="col-sm-12 col-md-9 col-lg-9">
                                <section id="gloss-white-polyester">
                                    <h2>One Sided Window Decal on Clear Polyester (Mylar®)</h2>
                                    <p>One sided window decal on Clear Polyester, makes a great permanent window decal. The printing is viewed from the adhesive side so that the decal can be placed on the inside of the window and viewed from the outside, protecting the decal from vandals.</p>    
                                </section>
                                <section id="static-cling">
                                    <h2>One Sided Window Decal on Clear Static Cling Vinyl</h2>
                                    <p>One sided Window decal on Clear Static Cling, makes a great removable/reusable window decal. The printing is viewed from the static cling side so that the decal can be placed on the inside of the window and viewed from the outside, protecting the decal from vandalism or theft.</p>    
                                </section>
                                <section id="low-tack-clear">
                                    <h2>One Sided Window Decal on Clear Low Tack Vinyl</h2>
                                    <p>One sided window decal on clear low tack vinyl, makes a great removable window decal. This product allows better adhesion then static cling yet not as permanent as clear mylar. The printing is viewed from the static cling side so that the decal can be placed on the inside of the window and viewed from the outside, protecting the decal from vandals or theft.</p>
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
