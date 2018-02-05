 <%@ Page Title="Dealer FAQ - Dealer - Sign Service Label Products" Language="C#" MasterPageFile="~/Dealer/DealerLogin.Master" AutoEventWireup="true" CodeBehind="dealer_faq.aspx.cs" Inherits="Sign_Service_Label_Products.Dealer.dealer_faq" %>

<%@ Register Src="~/auth.ascx" TagPrefix="uc1" TagName="auth" %>


<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <uc1:auth runat="server" ID="auth" />
    <div id="page-content" class="container">
        <div class="page-header">
            <h1>Dealer FAQ <small>(Frequently Asked Questions)</small></h1>
        </div>
        <!--Start of the accordion with for questions.-->
        <div class="row">
            <div class="col-lg-12">
                <div class="panel-group" id="accordion">
                    <div class="panel panel-default">
                        <div class="panel-heading">
                            <h4 class="panel-title">
                                <a class="accordion-toggle" data-toggle="collapse" data-parent="#accordion" href="#collapseOne">What is the suggested mark up for Sign Service's products?</a>
                            </h4>
                        </div>
                        <div id="collapseOne" class="panel-collapse collapse">
                            <div class="panel-body">
                                <p>The profit mark up that is suggested is between 25% and 30%, however this is entirely up to the distributor to decide what they think the their market bears. <br />
                                It is within the distributors right and there will be no conflict from Sign Service Label Products if you are to sell below or above that suggested mark up.</p>    
                            </div>
                        </div>
                    </div>
                    <!-- /.panel -->
                    <div class="panel panel-default">
                        <div class="panel-heading">
                            <h4 class="panel-title">
                                <a class="accordion-toggle" data-toggle="collapse" data-parent="#accordion" href="#collapseTwo">What form of payment do you accept?</a>
                            </h4>
                        </div>
                        <div id="collapseTwo" class="panel-collapse collapse">
                            <div class="panel-body">
                                <p>We accept Visa, Master card or Company cheque. First orders are COD.</p>
                                <span class="fa fa-cc-visa fa-3x"></span> <span class="fa fa-cc-mastercard fa-3x"></span>
                            </div>
                        </div>
                    </div>
                    <!-- /.panel -->
                    <div class="panel panel-default">
                        <div class="panel-heading">
                            <h4 class="panel-title">
                                <a class="accordion-toggle" data-toggle="collapse" data-parent="#accordion" href="#collapseThree">As a trade only supplier, what services do you offer that helps the reseller?</a>
                            </h4>
                        </div>
                        <div id="collapseThree" class="panel-collapse collapse">
                            <div class="panel-body">
                                Sign Service Label Products ships the product in unmarked plain boxes. We can blind ship to your customer at no additonal charge. We supply additonal samples of the order for reseller.
                            </div>
                        </div>
                    </div>
                    <!-- /.panel -->
                    <div class="panel panel-default">
                        <div class="panel-heading">
                            <h4 class="panel-title">
                                <a class="accordion-toggle" data-toggle="collapse" data-parent="#accordion" href="#collapseFour">The website has a lot of different materials listed. How do I know what product will be good for my application?</a>
                            </h4>
                        </div>
                        <div id="collapseFour" class="panel-collapse collapse">
                            <div class="panel-body">
                                If you are not sure what stock to use, please call our office. One of our staff will be happy to discuss your application.<br />
                                We also have additional stocks that are not on the website for unique applications.
                            </div>
                        </div>
                    </div>
                    <!-- /.panel -->
                    <div class="panel panel-default">
                        <div class="panel-heading">
                            <h4 class="panel-title">
                                <a class="accordion-toggle" data-toggle="collapse" data-parent="#accordion" href="#collapseFive">The pricing starts at 50 labels. Can I order less than 50?</a>
                            </h4>
                        </div>
                        <div id="collapseFive" class="panel-collapse collapse">
                            <div class="panel-body">
                                We can do any quantity that is required. We would custom quote based on your requirements. The total price will not be much less that the 50 piece price.
                            </div>
                        </div>
                    </div>
                    <!-- /.panel -->
                    <div class="panel panel-default">
                        <div class="panel-heading">
                            <h4 class="panel-title">
                                <a class="accordion-toggle" data-toggle="collapse" data-parent="#accordion" href="#collapseSix">I see that the customer is to supply the artwork. Do you create any artwork?</a>
                            </h4>
                        </div>
                        <div id="collapseSix" class="panel-collapse collapse">
                            <div class="panel-body">
                                Sign Service Label Products can create artwork, but we do not do any creative design.<br />There is an additonal  charge depending on how complex the art is.
                            </div>
                        </div>
                    </div>
                    <!-- /.panel -->
                    <div class="panel panel-default">
                        <div class="panel-heading">
                            <h4 class="panel-title">
                                <a class="accordion-toggle" data-toggle="collapse" data-parent="#accordion" href="#collapseSeven">How long does it take to produce an order?</a>
                            </h4>
                        </div>
                        <div id="collapseSeven" class="panel-collapse collapse">
                            <div class="panel-body">
                                Our standard turn around is 2 weeks for screen printing and 8 days for digital orders.<br />We offer shorter deliveries if required. Call or email us to discuss your requirements.
                            </div>
                        </div>
                    </div>
                    <!-- /.panel -->
                    <div class="panel panel-default">
                        <div class="panel-heading">
                            <h4 class="panel-title">
                                <a class="accordion-toggle" data-toggle="collapse" data-parent="#accordion" href="#collapseEight">Do you do custom colours?</a>
                            </h4>
                        </div>
                        <div id="collapseEight" class="panel-collapse collapse">
                            <div class="panel-body">
                                We use the Pantone Matching System (PMS) Coated Pantone colors can be matched as closely as possible. Some variation may occur depending on the background material used.
                            </div>
                        </div>
                    </div>
                    <!-- /.panel -->
                    <div class="panel panel-default">
                        <div class="panel-heading">
                            <h4 class="panel-title">
                                <a class="accordion-toggle" data-toggle="collapse" data-parent="#accordion" href="#collapseNine">The prices have square cut or rounded corners. Do you offer special shape labels?</a>
                            </h4>
                        </div>
                        <div id="collapseNine" class="panel-collapse collapse">
                            <div class="panel-body">
                                For digital labels, any shape can be cut for the same cost. For screen printed products, there would be a die charge. We would have to custom quote a die and the price would depend on its complexity.
                            </div>
                        </div>
                    </div>
                    <!-- /.panel -->
                    <div class="panel panel-default">
                        <div class="panel-heading">
                            <h4 class="panel-title">
                                <a class="accordion-toggle" data-toggle="collapse" data-parent="#accordion" href="#collapseTen">Can you print consecutive numbers?</a>
                            </h4>
                        </div>
                        <div id="collapseTen" class="panel-collapse collapse">
                            <div class="panel-body">
                                Yes we can print any size consecutive number on our digital labels. Screen printed labels can have a 3/16" or 1/4" high consecutive number.
                            </div>
                        </div>
                    </div>
                    <!-- /.panel -->
                </div>
                <!-- /.panel-group -->
            </div>
            <!-- /.col-lg-12 -->
        </div>
        <!-- /.row -->
    </div>
    <!-- /.container -->
</asp:Content>
