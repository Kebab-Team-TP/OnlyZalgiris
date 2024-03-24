using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Security;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace OnlyZalgiris
{
    public partial class SiteMaster : MasterPage
    {
        

        protected void Page_Load(object sender, EventArgs e)
        {
            //AuthenticateEventArgs AE = e as AuthenticateEventArgs;

            // Retrieving a value from session
;           //Session["authenticated"] 
            bool authenticated;
            //if(Session["authenticated"])    
            try
            {
                authenticated = (bool)Session["authenticated"];

                if (authenticated)
                {
                    string userName = (string)Session["UserName"];
                    user.Text = userName;
                }
                else
                {
                    user.Text = "log in";
                }

            }
            catch
            {
                user.Text = "login";

            }


        }
    }
}