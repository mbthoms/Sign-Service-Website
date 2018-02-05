<%@ Page Title="Admin Login - Admin - Sign Service Label Products" Language="C#" MasterPageFile="~/admin/admin.Master" AutoEventWireup="true" CodeBehind="admin_login.aspx.cs" Inherits="Sign_Service_Label_Products.admin.admin_login" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
     <div id="page-content" class="container">
        <div class="page-header">
            <h1>Admin Login</h1>
        </div>
        <div class="row">
            <section class="col-sm-12 col-md-4 col-lg-4 text-center"></section>
            <section class="col-sm-12 col-md-4 col-lg-4 text-center">
                <asp:Label ID="lblSubmitLoginMessage" Text="" runat="server" CssClass="label label-success" />
                <asp:Label ID="lblSubmitLoginMessageError" Text="" runat="server" CssClass="label label-danger" />
                <fieldset class="login-fields">
                    <asp:Label ID="lblUsernameLogin" Text="Username:" runat="server" />
                    <asp:TextBox ID="txtUsernameLogin" runat="server" CssClass="form-control" />
                    <br />
                    <asp:Label ID="lblPasswordLogin" Text="Password:" runat="server" />
                    <asp:TextBox ID="txtPasswordLogin" TextMode="Password" runat="server" CssClass="form-control" />
                    <br />
                    <!-- Sign Up Button trigger Modal -->
                    <a href="admin_signup.aspx" class="btn btn-primary signup-modal-button">Admin Sign Up</a>
                    <!-- Login Submit button -->
                    <asp:Button ID="btnAdminLogin" Text="Login" OnClick="btnAdminLogin_Click" runat="server" CssClass="btn btn-success" />
                </fieldset>
            </section>
            <section class="col-sm-12 col-md-4 col-lg-4 text-center"></section>
        </div>
        <!-- /.row -->
    </div>
    <!-- /.container -->
</asp:Content>
