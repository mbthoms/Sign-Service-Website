<%@ Page Title="Sign Up - Admin - Sign Service Label Products" Language="C#" MasterPageFile="~/admin/admin.Master" AutoEventWireup="true" CodeBehind="admin_signup.aspx.cs" Inherits="Sign_Service_Label_Products.admin.admin_signup" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div id="page-content" class="container">
        <div class="page-header">
            <h1>Admin Sign Up</h1>
        </div>

        <asp:Label ID="lblSubmitSignUpMessage" Text="" runat="server" CssClass="label label-success" />
                <asp:Label ID="lblSubmitSignUpMessageError" Text="" runat="server" CssClass="label label-danger" />
                <fieldset class="login-fields">
                    <asp:Label ID="lblUsernameSignUp" Text="Username:" runat="server" />
                    <asp:TextBox ID="txtUsernameSignUp" runat="server" CssClass="form-control" />
                    <br />
                    <asp:Label ID="lblPasswordSignUp" Text="Password:" runat="server" />
                    <asp:TextBox ID="txtPasswordSignUp" TextMode="Password" runat="server" CssClass="form-control" />
                    <br />
                    <!-- Sign Up Submit button -->
                    <asp:Button ID="btnAdminSignUp" Text="Sign Up" OnClick="btnAdminSignUp_Click" runat="server" CssClass="btn btn-success" />
                </fieldset>

        </div>
    <!-- /.container -->
</asp:Content>
