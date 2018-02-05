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
    public partial class admin_signup : System.Web.UI.Page
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
        //Signup
        //===========================================================================================
        protected void btnAdminSignUp_Click(object sender, EventArgs e)
        {
            //Connect to the Database.
            using (DefaultConnection1 db = new DefaultConnection1())
            {
                //Creating a new user.
                admin_users objI = new admin_users();

                //Fill the properties from the form inputs.
                objI.admin_username = txtUsernameSignUp.Text;
                
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
                objI.admin_password = base64;
                objI.admin_salt = salt;

                //Saving information into Database.
                db.admin_users.Add(objI);
                db.SaveChanges();
            }
        }
    }
}