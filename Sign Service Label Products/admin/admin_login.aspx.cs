using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
//Cryptography
using System.Security.Cryptography;
//Reference the Model
using Sign_Service_Label_Products.Models;

namespace Sign_Service_Label_Products.admin
{
    public partial class admin_login : System.Web.UI.Page
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
        protected void btnAdminLogin_Click(object sender, EventArgs e)
        {
            
            //Connecting to the Database. 
            using (DefaultConnection1 db = new DefaultConnection1())
            {
                //Creating user in memory. 
                admin_users objI = new admin_users();
                
                //First get the salt value for this username
                String username = txtUsernameLogin.Text;

                objI = (from em in db.admin_users
                        where em.admin_username == username
                        select em).FirstOrDefault();

                //Did the username match?
                if (objI != null)
                {
                    //Grabing salt.
                    String salt = objI.admin_salt;

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
                    if (objI.admin_password == base64)
                    {
                        //Checking if the password was the same, Showing a valid login.
                        lblSubmitLoginMessage.Text = "Valid Login";

                        //Store the indentity in the session object.
                        Session["admin_user_id"] = objI.admin_user_id;

                        //Rediect to logged in homepage.
                        Response.Redirect("admin_grid.aspx");
                    }
                    else
                    {
                        lblSubmitLoginMessageError.Text = "Invaild Login, the Email or Password may be wrong.";
                    }
                }
            }
        }
    }
}