<%@ Page Title="Admin List - Admin - Sign Service Label Products" Language="C#" MasterPageFile="~/admin/AdminLoggedIn.Master" AutoEventWireup="true" CodeBehind="admin_grid.aspx.cs" Inherits="Sign_Service_Label_Products.admin.admin_grid" %>

<%@ Register Src="~/admin_auth.ascx" TagPrefix="uc1" TagName="admin_auth" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <uc1:admin_auth runat="server" ID="admin_auth" />
    <!--===================================================================================================
    This is not mobile friendly
    =====================================================================================================-->
    <div id="page-content" class="container">
        <div class="page-header">
            <h1>List of Users</h1>
        </div>
        <div class="alert alert-info" role="alert"><strong>Instructions:</strong> To delete a user simply click the delete button. Once clicked confirm the deletion of the user.</div>
       
    <asp:GridView runat="server" ID="grdPublicUsers" CssClass="table table-striped table-hover" AutoGenerateColumns="false" OnRowDeleting="grdPublicUsers_RowDeleting" DataKeyNames="user_id">
        <Columns>
            <asp:BoundField DataField="user_id" HeaderText="User ID" Visible="false" />
            <asp:BoundField DataField="contact_name" HeaderText="Name" />
            <asp:BoundField DataField="email" HeaderText="Email" />
            <asp:BoundField DataField="company_name" HeaderText="Company Name" />
            <asp:BoundField DataField="phone" HeaderText="Phone" />
            <asp:BoundField DataField="fax" HeaderText="Fax" Visible="false" />
            <asp:BoundField DataField="address_line_1" HeaderText="Address Line 1" />
            <asp:BoundField DataField="address_line_2" HeaderText="Address Line 2" Visible="false" />
            <asp:BoundField DataField="city" HeaderText="City" />
            <asp:BoundField DataField="state_province" HeaderText="State/Province" />
            <asp:BoundField DataField="zip_postal" HeaderText="Zip/Postal Code" />
            <asp:CommandField ShowDeleteButton="true" DeleteText="Delete" HeaderText="Delete" ControlStyle-CssClass="btn btn-danger" />
        </Columns>
    </asp:GridView>
        </div>
    <!-- /.container -->
</asp:Content>
