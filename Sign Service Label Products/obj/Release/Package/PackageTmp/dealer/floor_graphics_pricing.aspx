<%@ Page Title="Floor Graphics - Dealer - Sign Service Label Products" Language="C#" MasterPageFile="~/dealer/DealerLogin.Master" AutoEventWireup="true" CodeBehind="floor_graphics_pricing.aspx.cs" Inherits="Sign_Service_Label_Products.dealer.floor_graphics_pricing" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="container cd-container" id="nav_bar">
        <div class="col-sm-12 col-md-12 col-lg-12">
            <div class="row">
                <section class="page-header">
                    <h1>Floor Graphics Pricing</h1>
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
                <fieldset>
                    <legend>Label Size</legend>
                    <asp:DropDownList ID="ddlLabelSize" runat="server" CssClass="form-control">
                        <asp:ListItem Text="-Select-" Value="0" />
                        <asp:ListItem Text="12x12 Circle or Square" Value="1" />
                        <asp:ListItem Text="12x24 Rectangle" Value="2" />
                    </asp:DropDownList>
                    <asp:Label Text="Sizes are in inches." runat="server" CssClass="label label-info" />
                    <asp:RequiredFieldValidator ID="RequiredFieldValidator1" ControlToValidate="ddlLabelSize" runat="server" ErrorMessage="Size is Required."></asp:RequiredFieldValidator>
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
                        <asp:ListItem Text="5" Value="5" />
                        <asp:ListItem Text="10" Value="10" />
                        <asp:ListItem Text="25" Value="25" />
                        <asp:ListItem Text="50" Value="50" />
                        <asp:ListItem Text="100" Value="100" />
                        <asp:ListItem Text="250" Value="250" />
                        <asp:ListItem Text="500" Value="500" />
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
            <div class="col-sm-12 col-md-4 col-lg-4">
                <div id="info-panel-pricing" class="panel panel-default">
                    <div class="panel-heading">
                        <h3 class="panel-title"><span class="fa fa-book"></span>Floor Graphics Information
                        </h3>
                    </div>
                    <div class="panel-body text-center">
                        <p>If you would like more information on the stock that you have selected, click "Floor Graphics Information".</p>
                        <!-- Vinyl Information trigger to show modal -->
                        <a href="#" class="btn btn-default" data-toggle="modal" data-target="#myModal"><i class="fa fa-folder-open"></i>Floor Graphics Information</a>
                    </div>
                </div>
            </div>
            <div class="col-sm-12 col-md-4 col-lg-4">
                <div id="info-panel-pricing" class="panel panel-default">
                    <div class="panel-heading">
                        <h3 class="panel-title"><span class="fa fa-book"></span>Floor Graphics Application Instructions
                        </h3>
                    </div>
                    <div class="panel-body text-center">
                        <p>For Application Instructions for Sign Service Label Products Floor Graphics Products please click "Application Instructions"</p>
                        <!-- Vinyl Information trigger to show modal -->
                        <a href="#" class="btn btn-default" data-toggle="modal" data-target="#myModalApp"><i class="fa fa-folder-open"></i>Application Instructions</a>
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
                        <h3 class="panel-title"><span class="fa fa-question-circle"></span>Looking to Order?
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
                        <h4 class="modal-title" id="myModalLabel">Floor Graphics Information</h4>
                    </div>
                    <div class="modal-body">
                        <p>
                            Sign Service Label Products offers custom screen printed floor grapics.
                            <br />
                            This product allows you to advertise or direct traffic to the product on sale.
                            <br />
                            Imagine for a minute how much exposure you customers company will receive, every time someone walks through that entrance or down that aisle their name is there telling them what they do or the benefits of using that product.
                            <br />
                            This product is a textured vinyl no slip surface with a white background finish.
                            <br />
                    </div>
                    <div class="modal-footer">
                        <button type="button" class="btn btn-default" data-dismiss="modal">Close</button>
                    </div>
                </div>
            </div>
        </div>


        <!-- =====================================================================================================================================================================
            Floor Graphics App Information Modal 
            =================================================================================================================================================================== -->
        <div class="modal fade" id="myModalApp" tabindex="-1" role="dialog" aria-labelledby="myModalLabelApp">
            <div class="modal-dialog modal-lg" role="document">
                <div class="modal-content">
                    <div class="modal-header">
                        <button type="button" class="close" data-dismiss="modal" aria-label="Close"><span aria-hidden="true">&times;</span></button>
                        <h4 class="modal-title" id="myModalLabelApp">Application Instructions for Sign Service Label Products Floor Graphics Products</h4>
                    </div>
                    <div class="modal-body">
                        <p>Sign Service Label Products Floor Graphics Film System is designed to be applied to smooth surfaces including: waxed and non-waxed commercial PVC tile, certain ceramic tile and sealed concrete. The following is a general recommendation on the steps that should be taken to apply Sign Service Label Products floor graphics products.</p>
                        <h4>Floor Condition</h4>
                        <p>Floor surface must be clean prior to application of graphics. Traditional floor cleaning methods can be used to prepare the surface. Insure that the floor surface is adequately dry before application of graphics.</p>
                        <h4>Application Method:</h4>
                        <ol>
                            <li>Peel the backing paper down 1” from top, fold, and crease the backing paper.</li>
                            <li>Align and apply the graphic starting at the top using firm strokes with a plastic squeegee, stiff cardboard or a soft cloth. Continue removing backing paper and smooth out with squeegee. Re-squeegee the edges of the graphic using firm strokes to insure edge adhesion.</li>
                        </ol>
                        <h4>Routine Maintenance</h4>
                        <ol>
                            <li>do not clean or wax floor graphics for at least 24 hours after application.</li>
                            <li>When selecting a floor wax, insure it meets or exceeds ASTM D 2047 standards for appropriate static coefficient of friction (.5 min.).</li>
                            <li>Avoid damaging graphics by heavy equipment traffic (fork trucks, pallets or other heavy equipment).</li>
                        </ol>
                        <p><em>*NOTE*</em> To avoid risk of injury, immediately remove graphics if any edge of the graphic lifts, and replace with a new graphic.</p>
                        <h4>Removal Instructions</h4>
                        <p>Lift one edge of the graphic ( using a putty knife) and pull using quick strokes (pull at an angle less then 45 degrees for best results). </p>
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
