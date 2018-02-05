using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
//Add a reference to Database.
using Sign_Service_Label_Products.Models;

namespace Sign_Service_Label_Products.admin
{
    public partial class admin_grid : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            //Call the GetUser function to populate the grid.
            if (!IsPostBack)
            {
                GetUser();
            }
        }

        protected void GetUser()
        {
            //Connecting to Database.
            using (DefaultConnection1 db = new DefaultConnection1())
            {
                var ur = from u in db.public_users
                         select u;

                //bind the us query results to the grid
                grdPublicUsers.DataSource = ur.ToList();
                grdPublicUsers.DataBind();
            }
        }

        protected void grdPublicUsers_RowDeleting(object sender, GridViewDeleteEventArgs e)
        {
            Int32 user_id = Convert.ToInt32(grdPublicUsers.DataKeys[e.RowIndex].Values["user_id"]);

            //Connecting to Database.
            using (DefaultConnection1 db = new DefaultConnection1())
            {
                public_users ur = (from u in db.public_users
                                   where u.user_id == user_id
                                   select u).FirstOrDefault();

                //Deleting the user.
                db.public_users.Remove(ur);
                db.SaveChanges();

                //Refreshing the grid.
                GetUser();
            }
        }
    }
}