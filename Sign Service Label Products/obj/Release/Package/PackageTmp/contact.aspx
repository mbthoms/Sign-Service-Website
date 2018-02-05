<%@ Page Title="Contact Us - Sign Serivce Label Products" Language="C#" MasterPageFile="~/Public.Master" AutoEventWireup="true" CodeBehind="contact.aspx.cs" Inherits="Sign_Service_Label_Products.contact" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div id="page-content" class="container">
        <div class="page-header">
            <h1>Contact Us</h1>
        </div>
        <div class="row">
            <section class="col-sm-12 col-md-12 col-lg-12">
                <p>We would like to hear from you, you can use the contact form below or use any on the contact information below to contact us.</p>
            </section>
        </div>
        <!-- ================================================================================================
             Contact Information 
             ================================================================================================ -->
        <div class="row contact-area">
            <section class="container">
                <div class="col-sm-12 col-md-6 col-lg-3 text-center margin-top-footer">
                    <span class="fa fa-map-marker fa-3x text-center"></span>
                    <h3>Address</h3>
                    <div class="padding-top">
                        <a href="https://www.google.ca/maps/place/Sign+Service+Label+Product/@43.6524315,-79.9042284,17z/data=!3m1!4b1!4m2!3m1!1s0x882b12b3a42c2e8d:0x428b2bad148b06ce">14 Todd Road, Georgetown,
                            <br />
                            Ontario, Canada L7G 4R7
                        </a>
                    </div>
                </div>
                <div class="col-sm-12 col-md-6 col-lg-3 text-center margin-top-footer">
                    <span class="fa fa-phone fa-3x text-center" aria-hidden="true"></span>
                    <h3>Phone</h3>
                    <div class="padding-top">
                        <a href="tel:9058732300">(905) 873-2300</a>
                    </div>
                    <div class="padding-top">
                        Toll-Free:<a href="tel:18007872382"> 1(800) 787-2382</a>
                    </div>
                </div>

                <div class="col-sm-12 col-md-6 col-lg-3 text-center margin-top-footer">
                    <span class="fa fa-fax fa-3x text-center" aria-hidden="true"></span>
                    <h3>Fax</h3>
                    <div class="padding-top">
                        <a href="fax:9058737208">(905) 873-7208</a>
                    </div>
                    <div class="padding-top">
                        Toll-Free:<a href="fax:18005831120"> 1(800) 583-1120</a>
                    </div>
                </div>

                <div class="col-sm-12 col-md-6 col-lg-3 text-center margin-top-footer">
                    <span class="fa fa-envelope-o fa-3x text-center" aria-hidden="true"></span>
                    <h3>Email</h3>
                    <div class="padding-top">
                        <a href="mailto:sales@signservice.com">sales@signservice.com</a>
                    </div>
                </div>
            </section>
        </div>
        <div class="row">
            <!-- =======================================================================
                Contact Form
                ======================================================================== -->
            <section class="col-sm-12 col-md-6 col-lg-6">
                <div class="row">
                    <div class="col-sm-12 col-md-6 col-lg-12 text-center margin-top-footer">
                        <span class="fa fa-clock-o fa-3x text-center" aria-hidden="true"></span>
                        <h3>Hours of Operation</h3>
                        <div class="padding-top">
                            <div class="col-sm-12 col-md-12 col-lg-12 hours">
                                <p>Monday: 8:00 AM – 5:00 PM</p>
                                <p>Tuesday: 8:00 AM – 5:00 PM</p>
                                <p>Wednesday: 8:00 AM – 5:00 PM</p>
                                <p>Thrusday: 8:00 AM – 5:00 PM</p>
                                <p>Friday: 8:00 AM – 5:00 PM</p>
                                <p>Saturday: Closed</p>
                                <p>Sunday: Closed</p>
                                <p>Holidays: Closed</p>
                            </div>
                        </div>
                    </div>
                </div>
            </section>

            <section class="col-sm-12 col-md-6 col-lg-5">
                <asp:Label ID="lblSubmitButtonMessageSent" Text="" runat="server" CssClass="label label-success" />
                <asp:Label ID="lblSubmitButtonMessageError" Text="" runat="server" CssClass="label label-danger" />
                <br />
                <!-- Contact Name -->
                <asp:Label ID="lblContactName" Text="Contact Name:*" runat="server" />
                <asp:TextBox ID="txtContactName" runat="server" CssClass="form-control" />
                <!-- Validators -->
                <asp:RequiredFieldValidator ID="RequiredFieldValidator1" ControlToValidate="txtContactName" runat="server" ErrorMessage="Must include Contact Name." Display="Dynamic" CssClass="label label-danger"></asp:RequiredFieldValidator>
                <br />
                <!-- Company Name -->
                <asp:Label ID="lblContactCompanyName" Text="Contact Company Name:*" runat="server" />
                <asp:TextBox ID="txtContactCompanyName" runat="server" CssClass="form-control" />
                <!-- Validators -->
                <asp:RequiredFieldValidator ID="RequiredFieldValidator2" ControlToValidate="txtContactCompanyName" runat="server" ErrorMessage="Must include Company Name." Display="Dynamic" CssClass="label label-danger"></asp:RequiredFieldValidator>
                <br />
                <!-- Contact Email -->
                <asp:Label ID="lblContactEmail" Text="Contact Email:*" runat="server" />
                <asp:TextBox ID="txtContactEmail" runat="server" CssClass="form-control" />
                <!-- Validators -->
                <asp:RequiredFieldValidator ID="RequiredFieldValidator3" ControlToValidate="txtContactEmail" runat="server" ErrorMessage="Must include Contact Email." Display="Dynamic" CssClass="label label-danger"></asp:RequiredFieldValidator>
                <br />
                <!-- Contact Phone -->
                <asp:Label ID="lblContactPhone" Text="Contact Phone Number:*" runat="server" />
                <asp:TextBox ID="txtContactPhone" runat="server" CssClass="form-control" />
                <!-- Validators -->
                <asp:RegularExpressionValidator ID="RegularExpressionValidator1" ControlToValidate="txtContactPhone" runat="server" ErrorMessage="Must include valid Contact Phone Number." ValidationExpression="^[01]?[- .]?(\([2-9]\d{2}\)|[2-9]\d{2})[- .]?\d{3}[- .]?\d{4}$" Display="Dynamic" CssClass="label label-danger"></asp:RegularExpressionValidator>
                <asp:RequiredFieldValidator ID="RequiredFieldValidator4" ControlToValidate="txtContactPhone" runat="server" ErrorMessage="Must include Contact Phone Number." Display="Dynamic" CssClass="label label-danger"></asp:RequiredFieldValidator>
                <br />
                <!-- Contact Fax -->
                <asp:Label ID="lblContactFax" Text="Contact Fax:" runat="server" />
                <asp:TextBox ID="txtContactFax" runat="server" CssClass="form-control" />
                <asp:RegularExpressionValidator ID="RegularExpressionValidator2" ControlToValidate="txtContactFax" runat="server" ErrorMessage="Must include Contact Fax Number." ValidationExpression="^[01]?[- .]?(\([2-9]\d{2}\)|[2-9]\d{2})[- .]?\d{3}[- .]?\d{4}$" Display="Dynamic" CssClass="label label-danger"></asp:RegularExpressionValidator>
                <br />
                <!-- Contact Message Subject -->
                <asp:Label ID="lblContactMessageSubject" Text="Message Subject:*" runat="server" />
                <asp:TextBox ID="txtContactMessageSubject" runat="server" CssClass="form-control" />
                <!-- Validators -->
                <asp:RequiredFieldValidator ID="RequiredFieldValidator6" ControlToValidate="txtContactMessageSubject" runat="server" ErrorMessage="Must include a Message Subject." Display="Dynamic" CssClass="label label-danger"></asp:RequiredFieldValidator>
                <br />
                <!-- Contact Message -->
                <asp:Label ID="lblContactMessage" Text="Message:*" runat="server" />
                <asp:TextBox ID="txtContactMessage" runat="server" TextMode="MultiLine" Height="100px" CssClass="form-control" />
                <!-- Validators -->
                <asp:RequiredFieldValidator ID="RequiredFieldValidator5" ControlToValidate="txtContactMessage" runat="server" ErrorMessage="Must include a Message." Display="Dynamic" CssClass="label label-danger"></asp:RequiredFieldValidator>
                <br />
                <!-- Submit Button -->
                <asp:LinkButton ID="SelectButton" runat="server" OnClick="btnContactSubmit_Click" CssClass="btn btn-primary btn-block contact-submit-btn"><i class="fa fa-paper-plane"></i>&nbsp;Send Message</asp:LinkButton>
                <p><span class="req">* Required Fields</span></p>
            </section>
            <section class="col-sm-12 col-md-12 col-lg-1"></section>
            <!-- /Contact Form -->

            <!-- Google Maps/ Google Maps API -->
            <section class="col-sm-12 col-md-12 col-lg-12">
                <iframe src="https://www.google.com/maps/embed?pb=!1m18!1m12!1m3!1d2886.795086054539!2d-79.9042284!3d43.6524315!2m3!1f0!2f0!3f0!3m2!1i1024!2i768!4f13.1!3m3!1m2!1s0x882b12b3a42c2e8d%3A0x428b2bad148b06ce!2sSign+Service+Label+Product!5e0!3m2!1sen!2sca!4v1441890814702" width="100%" height="300" frameborder="0" style="border: 0" allowfullscreen></iframe>
            </section>
            <!-- /Google Maps/Google Maps API. -->
        </div>
    </div>
    <!-- /.container -->
</asp:Content>
