<%@ Page Title="Dealer Home - Dealer - Sign Service Label Products" Language="C#" MasterPageFile="~/Dealer/DealerLogin.Master" AutoEventWireup="true" CodeBehind="index.aspx.cs" Inherits="Sign_Service_Label_Products.Dealer.dealer_index" %>

<%@ Register Src="~/auth.ascx" TagPrefix="uc1" TagName="auth" %>


<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <uc1:auth runat="server" ID="auth" />
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div id="page-content" class="container">
        <div class="page-header">
            <h1>
                <asp:Label ID="lblDealerIndexTitle" Text="" runat="server" />

            </h1>
        </div>
        <p>In this part of our site you can find pricing for labels and decals up to 40 square inches by going to the Product Pricing dropdown at the top of the site as well as Coroplast signs up to 24" x 32". Label & decal pricing above 40 sq. in. can be custom quoted using our online quotation form in the product pricing section or by calling <a href="tel:9058732300">(905) 873-2300</a> or Toll Free at <a href="tel:18007872382">1(800) 787-2382</a>. <br> Requests for quotations can be faxed as well at: <a href="fax:9058737208">(905) 873-7208</a> or Toll Free at: <a href="fax:18005831120">1(800) 583-1120</a> or they can be e-mailed to <a href="mailto:sales@signservice.com">sales@signservice.com</a> and please with a subject line of QUOTE and then your company's name.</p>
    </div>

</asp:Content>
