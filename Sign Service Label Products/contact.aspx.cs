using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Net.Mail;

namespace Sign_Service_Label_Products
{
    public partial class contact : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnContactSubmit_Click(object sender, EventArgs e)
        {
            String Name = txtContactName.Text;
            String CompanyName = txtContactCompanyName.Text;
            String Email = txtContactEmail.Text;
            String PhoneNumber = txtContactPhone.Text;
            String Fax = txtContactFax.Text;
            String Subject = txtContactMessageSubject.Text;
            String Message = txtContactMessage.Text;

            //try
            //{
            MailMessage mail = new MailMessage();
            mail.To.Add("matthew@matthewthoms.com"); //Change to sales@signservice.com when launching.
            mail.To.Add(Email);
            mail.From = new MailAddress("forms@signservicelabelproducts.com");
            mail.Subject = Subject;

            string Body = "<h1>Message from Contact Form</h1>" +
                          "<br />" +
                          "<b>Name:</b>" + " " + Name +
                          "<br />" +
                          "<b>Comapny Name:</b>" + " " + CompanyName +
                          "<br />" +
                          "<b>Contact Email:</b>" + " " + Email +
                          "<br />" +
                          "<b>Contact Phone Number:</b>" + " " + PhoneNumber +
                          "<br />" +
                          "<b>Contact Fax:</b>" + " " + Fax +
                          "<br />" +
                          "<b>Message:</b>" + "<br />" + Message;
            mail.Body = Body;

            mail.IsBodyHtml = true;
            SmtpClient smtp = new SmtpClient();
            smtp.Host = "mail.signservicelabelproducts.com"; //Or Your SMTP Server Address
            smtp.Credentials = new System.Net.NetworkCredential
            ("forms@signservicelabelproducts.com", "3Mavsol3*");
            smtp.Port = 1025;
            //Or your Smtp Email ID and Password
            smtp.EnableSsl = false;
            smtp.Send(mail);

            lblSubmitButtonMessageSent.Text = "Message Sent! Thank-you.";
            //}
            //catch
            //{
            //    lblSubmitButtonMessageError.Text = "Something went wrong! Please try again.";
            //}

        }
    }
}
