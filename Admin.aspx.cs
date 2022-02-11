using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication1
{
    public partial class Admin : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if(Session["UserID"]==null)
            {
                Response.Redirect("Default.aspx");
            }
            if (!IsPostBack)
            {
                WBSettings Settings = (WBSettings)Application["Settings"];
              /*  TextBoxDefaultPageText1.Text = Settings.DefaultPageText1;
                TextBoxDefaultPageText2.Text = Settings.DefaultPageText2;
                Header.Text = Settings.HeaderText;
                Footer.Text = Settings.FooterText;*/
            }
        }

        protected void ButtonSave_Click(object sender, EventArgs e)
        {
            WBSettings Settings = (WBSettings)Application["Settings"];
            Settings.DefaultPageText1 = TextBoxDefaultPageText1.Text;
            Settings.DefaultPageText2 = TextBoxDefaultPageText2.Text;
            Settings.HeaderText = Header.Text;
            Settings.FooterText = Footer.Text;
            Manager.SaveSettings(Server.MapPath("~/App_Data/Settings.xml"),Settings);
            Application["Settings"] = Settings;


        }
    }
}