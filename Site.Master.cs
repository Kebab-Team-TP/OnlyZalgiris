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
                    hlLogin.Visible = false; 
                    lblUsername.Visible = true; 
                    lblUsername.Text = "Labas, " + userName;
                }
                else
                {
                    hlLogin.Visible = true; 
                    lblUsername.Visible = false; 
                }

            }
            catch
            {
                hlLogin.Visible = true; 
                lblUsername.Visible = false; 

            }


        }
    }
}