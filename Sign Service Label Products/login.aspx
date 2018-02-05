<%@ Page Title="Login - Sign Service Label Products" Language="C#" MasterPageFile="~/Public.Master" AutoEventWireup="true" CodeBehind="login.aspx.cs" Inherits="Sign_Service_Label_Products.login" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div id="page-content" class="container">
        <div class="page-header">
            <h1>Dealer Login</h1>
        </div>
        <div class="row">
            <section class="col-sm-12 col-md-4 col-lg-4 text-center"></section>
            <section class="col-sm-12 col-md-4 col-lg-4 text-center">
                <asp:Label ID="lblSubmitSignUpMessage" Text="" runat="server" CssClass="label label-success" />
                <asp:Label ID="lblSubmitSignUpMessageError" Text="" runat="server" CssClass="label label-danger" />
                <asp:Label ID="lblSubmitLoginMessage" Text="" runat="server" CssClass="label label-success" />
                <asp:Label ID="lblSubmitLoginMessageError" Text="" runat="server" CssClass="label label-danger" />
                <fieldset class="login-fields">
                    <asp:Label ID="lblEmailLogin" Text="Email:" runat="server" />
                    <asp:TextBox ID="txtEmailLogin" runat="server" CssClass="form-control" />
                    <br />
                    <asp:Label ID="lblPasswordLogin" Text="Password:" runat="server" />
                    <asp:TextBox ID="txtPasswordLogin" TextMode="Password" runat="server" CssClass="form-control" />
                    <br />
                    <!-- Sign Up Button trigger Modal -->
                    <button type="button" class="btn btn-primary signup-modal-button" data-toggle="modal" data-target="#myModal">Sign Up</button>
                    <!-- Login Submit button -->
                    <asp:Button ID="btnDealerLogin" Text="Login" OnClick="btnDealerLogin_Click" runat="server" CssClass="btn btn-success" />
                </fieldset>
            </section>
            <section class="col-sm-12 col-md-4 col-lg-4 text-center"></section>
        </div>
        <!-- /.row -->
        <section class="col-sm-12 col-md-12 col-lg-12 text-center">
            <a href="#" data-toggle="modal" data-target="#forgot_password">Forgot Password?</a>
        </section>
    </div>
    <!-- /.container -->

    <!-- Forgot Password Modal -->
    <div class="modal fade" id="forgot_password" tabindex="-1" role="dialog" aria-labelledby="myModalLabel">
        <div class="modal-dialog" role="document">
            <div class="modal-content">
                <div class="modal-header">
                    <button type="button" class="close" data-dismiss="modal" aria-label="Close"><span aria-hidden="true">&times;</span></button>
                    <h4 class="modal-title" id="myModalLabel">Forgot Password?</h4>
                </div>
                <div class="modal-body">
                    Please Contact Sign Service Label Products to recover your password.
                    <h4><a href="tel:18007872382">1(800) 787-2382</a></h4>
                    <p>OR</p>
                    <h4><a href="mailto:sales@signservice.com">sales@signservice.com</a></h4>
                </div>
                <div class="modal-footer">
                    <button type="button" class="btn btn-default" data-dismiss="modal">Close</button>
                </div>
            </div>
        </div>
    </div>



    <!-- Sign Up Modal -->
    <div class="modal fade" id="myModal" tabindex="-1" role="dialog" aria-labelledby="myModalLabel">
        <div class="modal-dialog" role="document">
            <div class="modal-content">
                <div class="modal-header">
                    <button type="button" class="close" data-dismiss="modal" aria-label="Close"><span aria-hidden="true">&times;</span></button>
                    <h1 class="modal-title" id="myModalLabel">Sign Up <small>for Dealer Login</small></h1>
                </div>
                <div class="modal-body">
                    <fieldset>
                        <legend>Contact Information</legend>
                        <asp:Label ID="lblContactNameSignUp" Text="Contact Name:" runat="server" />
                        <asp:TextBox ID="txtContactNameSignUp" runat="server" CssClass="form-control" />
                        <asp:RequiredFieldValidator ID="RequiredFieldValidator1" ValidationGroup="ValSignUp" ControlToValidate="txtContactNameSignUp" runat="server" ErrorMessage="Contact Name is Required." CssClass="label label-danger"></asp:RequiredFieldValidator>
                        <br />
                        <asp:Label ID="lblContactEmailSignUp" Text="Contact Email:" runat="server" />
                        <asp:TextBox ID="txtContactEmailSignUp" runat="server" CssClass="form-control" />
                        <asp:RequiredFieldValidator ID="RequiredFieldValidator2" ValidationGroup="ValSignUp" ControlToValidate="txtContactEmailSignUp" runat="server" ErrorMessage="Contact Email is Required." CssClass="label label-danger"></asp:RequiredFieldValidator>
                        <br />
                        <asp:Label Text="Company Name:" runat="server" />
                        <asp:TextBox ID="txtCompanyNameSignUp" runat="server" CssClass="form-control" />
                        <asp:RequiredFieldValidator ID="RequiredFieldValidator3" ValidationGroup="ValSignUp" ControlToValidate="txtCompanyNameSignUp" runat="server" ErrorMessage="Company Name is Required." CssClass="label label-danger"></asp:RequiredFieldValidator>
                        <br />
                        <asp:Label ID="lblContactPhoneNumberSignUp" Text="Contact Phone Number:" runat="server" />
                        <asp:TextBox ID="txtContactPhoneNumberSignUp" runat="server" CssClass="form-control" />
                        <asp:RegularExpressionValidator ID="RegularExpressionValidator1" ValidationGroup="ValSignUp" ControlToValidate="txtContactPhoneNumberSignUp" runat="server" ErrorMessage="Not a vaild phone number. Please use this format: 5555555555" ValidationExpression="^[01]?[- .]?(\([2-9]\d{2}\)|[2-9]\d{2})[- .]?\d{3}[- .]?\d{4}$" CssClass="label label-danger"></asp:RegularExpressionValidator>
                        <asp:RequiredFieldValidator ID="RequiredFieldValidator4" ValidationGroup="ValSignUp" runat="server" ControlToValidate="txtContactPhoneNumberSignUp" ErrorMessage="Phone Number is Requried." CssClass="label label-danger"></asp:RequiredFieldValidator>
                        <br />
                        <asp:Label ID="lblContactFaxSignUp" Text="Fax:" runat="server" />
                        <asp:TextBox ID="txtContactFaxSignUp" runat="server" CssClass="form-control" />
                        <asp:RegularExpressionValidator ID="RegularExpressionValidator2" ValidationGroup="ValSignUp" ControlToValidate="txtContactFaxSignUp" runat="server" ErrorMessage="Not a vaild Fax number. Please use this format: 5555555555" ValidationExpression="^[01]?[- .]?(\([2-9]\d{2}\)|[2-9]\d{2})[- .]?\d{3}[- .]?\d{4}$" CssClass="label label-danger"></asp:RegularExpressionValidator>
                    </fieldset>

                    <fieldset>
                        <legend>Address</legend>
                        <asp:Label ID="lblAddressSignUp" Text="Address:" runat="server" />
                        <asp:TextBox ID="txtAddressSignUp" runat="server" CssClass="form-control" />
                        <asp:RequiredFieldValidator ID="RequiredFieldValidator5" ValidationGroup="ValSignUp" ControlToValidate="txtAddressSignUp" runat="server" ErrorMessage="Address is Required." CssClass="label label-danger"></asp:RequiredFieldValidator>
                        <br />
                        <asp:Label ID="lblAddressLine2SignUp" Text="Address Line 2 (optional):" runat="server" />
                        <asp:TextBox ID="txtAddressLine2SignUp" runat="server" CssClass="form-control" />
                        <br />
                        <asp:Label ID="lblCitySignUp" Text="City:" runat="server" />
                        <asp:TextBox ID="txtCitySignUp" runat="server" CssClass="form-control" />
                        <asp:RequiredFieldValidator ID="RequiredFieldValidator6" ValidationGroup="ValSignUp" ControlToValidate="txtCitySignUp" runat="server" ErrorMessage="City is Required." CssClass="label label-danger"></asp:RequiredFieldValidator>
                        <br />
                        <asp:Label ID="lblStateProvinceSignUp" Text="State / Province:" runat="server" />
                        <asp:TextBox ID="txtStateProvinceSignUp" runat="server" CssClass="form-control" />
                        <asp:RequiredFieldValidator ID="RequiredFieldValidator7" ValidationGroup="ValSignUp" ControlToValidate="txtStateProvinceSignUp" runat="server" ErrorMessage="RequiredFieldValidator" CssClass="label label-danger"></asp:RequiredFieldValidator>
                        <br />
                        <asp:Label Text="Zip Code / Postal Code" runat="server" />
                        <asp:TextBox ID="txtZipPostalSignUp" runat="server" CssClass="form-control" />
                        <asp:RequiredFieldValidator ID="RequiredFieldValidator8" ValidationGroup="ValSignUp" ControlToValidate="txtZipPostalSignUp" runat="server" ErrorMessage="Zip / Postal Code is Required." CssClass="label label-danger"></asp:RequiredFieldValidator>
                    </fieldset>
                    <fieldset>
                        <legend>Password</legend>
                        <asp:Label ID="lblPasswordSignUp" Text="Password:" runat="server" />
                        <asp:TextBox ID="txtPasswordSignUp" TextMode="Password" runat="server" CssClass="form-control" />
                        <asp:RequiredFieldValidator ID="RequiredFieldValidator9" ValidationGroup="ValSignUp" ControlToValidate="txtPasswordSignUp" runat="server" ErrorMessage="Password is Required." CssClass="label label-danger"></asp:RequiredFieldValidator>
                        <br />
                        <asp:Label ID="lblConfirmPasswordSignUp" Text="Confirm Password:" runat="server" />
                        <asp:TextBox ID="txtConfirmPasswordSignUp" TextMode="Password" runat="server" CssClass="form-control" />
                        <asp:RequiredFieldValidator ID="RequiredFieldValidator10" ValidationGroup="ValSignUp" ControlToValidate="txtConfirmPasswordSignUp" runat="server" ErrorMessage="Confirm Password is Required." CssClass="label label-danger"></asp:RequiredFieldValidator>
                        <asp:CompareValidator ID="CompareValidator1" ValidationGroup="ValSignUp" ControlToValidate="txtPasswordSignUp" ControlToCompare="txtConfirmPasswordSignUp" runat="server" ErrorMessage="Passwords do not match." CssClass="label label-danger"></asp:CompareValidator>
                    </fieldset>
                </div>
                <div class="modal-footer">
                    <button type="button" class="btn btn-default" data-dismiss="modal">Close</button>
                    <asp:Button ID="btnDealerSignUp" ValidationGroup="ValSignUp" Text="Sign Up" OnClick="btnDealerSignUp_Click" runat="server" CssClass="btn btn-primary" />
                </div>
            </div>
        </div>
    </div>


</asp:Content>
