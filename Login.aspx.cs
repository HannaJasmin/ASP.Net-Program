using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.Configuration;

namespace WebApplication1
{
    public partial class Contact : Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void submit_Click(object sender, EventArgs e)
        {
            string UserName = WebConfigurationManager.AppSettings["UserName"];
            string Password = WebConfigurationManager.AppSettings["Password"];
            if(TextBox1.Text== UserName && TextBox2.Text==Password)
            {
                Session.Add("UserID",UserName);
                Response.Redirect("Admin.aspx");
            }
            else
            {
                LabelMessage.Text = "Please Enter Valid User Name and Password";
            }
        }
    }
}