using Microsoft.Ajax.Utilities;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Text.Json;
using System.IO;
using Antlr.Runtime.Tree;
using OnlyZalgiris.Models;
using OnlyZalgiris.App;

namespace OnlyZalgiris
{
    public partial class Login : System.Web.UI.Page
    {

        static string relativePath = "App_Data/Users.json";
        static string currentDirectory = AppDomain.CurrentDomain.BaseDirectory;
        static string fullPath = Path.Combine(currentDirectory, relativePath);

        protected void Page_Load(object sender, EventArgs e)
        {

        }

    protected void Login1_Authenticate(object sender, AuthenticateEventArgs e)
        {
            string json= File.ReadAllText(fullPath);
            //var Users =;
            Message.Text += Login1.UserName + '\n' + Login1.Password + '\n' + '\n';
            List<User> users = UsersController.GetAll();
            foreach (User user in users)
            {
                Message.Text += user.Username.Equals(Login1.UserName).ToString() +'\n'+user.Password + '\n';
                if (Login1.UserName.Equals(user.Username) && Login1.Password.Equals(user.Password))
                {

                    Session["UserName"] = user.Username;
                    e.Authenticated = true;
                    Session["authenticated"] = e.Authenticated;
                    Response.Redirect("/");
                }
                else
                {
                    //Message.Text = "Try again";

                }
            }
            Message.Text = "Try again";
            //e.Authenticated = false;
        }

        protected void LinkRegister_Click(object sender, EventArgs e)
        {

        }
        
    }
}