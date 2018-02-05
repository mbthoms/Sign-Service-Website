using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
//Mail
using System.Net.Mail;
//Cryptography
using System.Security.Cryptography;
//Reference the Model
using Sign_Service_Label_Products.Models;


namespace Sign_Service_Label_Products
{
    public partial class login : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }


        //===========================================================================================
        //Creating Salt
        //===========================================================================================
        private static string CreateSalt(int size)
        {
            // Generate a cryptographic random number using the cryptographic 
            // service provider
            RNGCryptoServiceProvider rng = new RNGCryptoServiceProvider();
            byte[] buff = new byte[size];
            rng.GetBytes(buff);
            // Return a Base64 string representation of the random number
            return Convert.ToBase64String(buff);
        }


        //===========================================================================================
        //Login
        //===========================================================================================
        protected void btnDealerLogin_Click(object sender, EventArgs e)
        {
            //Connecting to the Database.
            using (DefaultConnection1 db = new DefaultConnection1())
            {
                //Creating user in memory.
                public_users objI = new public_users();

                //First get the salt value for this username.
                String email = txtEmailLogin.Text;

                objI = (from em in db.public_users
                        where em.email == email
                        select em).FirstOrDefault();

                //Did the email match?
                if (objI != null)
                {
                    //Grabing salt.
                    String salt = objI.salt;

                    //Salt and hash the plan text password.
                    String password = txtPasswordLogin.Text;
                    String pass_and_salt = password + salt;

                    // Create a new instance of the hash crypto service provider.
                    HashAlgorithm hashAlg = new SHA256CryptoServiceProvider();

                    // Convert the data to hash to an array of Bytes.
                    byte[] bytValue = System.Text.Encoding.UTF8.GetBytes(pass_and_salt);

                    // Compute the Hash. This returns an array of Bytes.
                    byte[] bytHash = hashAlg.ComputeHash(bytValue);

                    // Optionally, represent the hash value as a base64-encoded string, 
                    // For example, if you need to display the value or transmit it over a network.
                    string base64 = Convert.ToBase64String(bytHash);

                    //Check if the password that was just salted and hashed matches the password in the database.
                    if (objI.password == base64)
                    {
                        //Checking if the password was the same, Showing a valid login.
                        //lblSubmitLoginMessage.Text = "Valid Login";

                        //Store the indentity in the session object.
                        Session["user_id"] = objI.user_id;
                        Session["contact_name"] = objI.contact_name;
                        Session["company_name"] = objI.company_name;

                        //Rediect to logged in homepage.
                        Response.Redirect("dealer/index.aspx");
                    }
                    else
                    {
                        lblSubmitLoginMessageError.Text = "Invaild Login, the Email or Password may be wrong.";
                    }
                }
                else
                {
                    lblSubmitLoginMessageError.Text = "Invaild Login, the Email or Password may be wrong.";
                }
            }
        }


        //===========================================================================================
        //Signup
        //===========================================================================================
        protected void btnDealerSignUp_Click(object sender, EventArgs e)
        {
            //Connecting to Database.
            using (DefaultConnection1 db = new DefaultConnection1())
            {
                //Creating a new user.
                public_users objI = new public_users();

                //fill the properties from the form inputs.
                objI.contact_name = txtContactNameSignUp.Text;
                objI.email = txtContactEmailSignUp.Text;
                objI.company_name = txtCompanyNameSignUp.Text;
                objI.phone = txtContactPhoneNumberSignUp.Text;
                objI.fax = txtContactFaxSignUp.Text;
                objI.address_line_1 = txtAddressSignUp.Text;
                objI.address_line_2 = txtAddressLine2SignUp.Text;
                objI.city = txtCitySignUp.Text;
                objI.state_province = txtStateProvinceSignUp.Text;
                objI.zip_postal = txtZipPostalSignUp.Text;

                //Salt and Hash the plan text Password.
                String password = txtPasswordSignUp.Text;
                String salt = CreateSalt(8);
                String pass_and_salt = password + salt;

                // Create a new instance of the hash crypto service provider.
                HashAlgorithm hashAlg = new SHA256CryptoServiceProvider();

                // Convert the data to hash to an array of Bytes.
                byte[] bytValue = System.Text.Encoding.UTF8.GetBytes(pass_and_salt);

                // Compute the Hash. This returns an array of Bytes.
                byte[] bytHash = hashAlg.ComputeHash(bytValue);

                // Optionally, represent the hash value as a base64-encoded string, 
                // For example, if you need to display the value or transmit it over a network.
                string base64 = Convert.ToBase64String(bytHash);

                //Filling the properties of password to Database.
                objI.password = base64;
                objI.salt = salt;

                //Saving information into Database.
                db.public_users.Add(objI);
                db.SaveChanges();
            }


            //Email form information to sales@signservice.com

            //Getting Informaion from form inputs.
            String Name = txtContactNameSignUp.Text;
            String CompanyName = txtCompanyNameSignUp.Text;
            String Email = txtContactEmailSignUp.Text;
            String PhoneNumber = txtContactPhoneNumberSignUp.Text;
            String Fax = txtContactFaxSignUp.Text;
            String AddressLine1 = txtAddressSignUp.Text;
            String AddressLine2 = txtAddressLine2SignUp.Text;
            String City = txtCitySignUp.Text;
            String StateProvince = txtStateProvinceSignUp.Text;
            String ZipPostal = txtZipPostalSignUp.Text;
            String Password = txtPasswordSignUp.Text;


            try
            {
                MailMessage mail = new MailMessage();
                mail.To.Add("matthew@matthewthoms.com"); //Change to sales@signservice.com when launching.
                mail.From = new MailAddress("forms@signservicelabelproducts.com");
                mail.Subject = "New Dealer Signed Up: " + Name + " from " + CompanyName;

                string Body = "<h1>New Dealer Signed Up</h1>" +
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
                              "<h2>Address</h2>" +
                              "<b>Address Line 1:</b>" + "<br />" + AddressLine1 +
                              "<br />" +
                              "<b>Address Line 2:</b>" + "<br />" + AddressLine2 +
                              "<br />" +
                              "<b>City:</b>" + "<br />" + City +
                              "<br />" +
                              "<b>State / Province:</b>" + "<br />" + StateProvince +
                              "<br />" +
                              "<b>Zip Code / Postal Code:</b>" + "<br />" + AddressLine1 +
                              "<br />" +
                              "<h2>Password</h2>" +
                              "<b>Password:</b>" + "<br />" + Password +
                              "<br />" +
                              "<h2>Manage Users</h2>" +
                              "<a href='http://signservice.com/admin/admin_login.aspx'>Manage Users</a>";
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

                lblSubmitSignUpMessage.Text = "You can sign in now.";
            }
            catch
            {
                lblSubmitSignUpMessageError.Text = "Something went wrong! Please try again.";
            }
        }
    }
}