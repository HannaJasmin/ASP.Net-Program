using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication1
{
    public partial class SiteMaster : MasterPage
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            LabelCounter.Text = "You Are Visitor No" + Application["Counter"].ToString();
            WBSettings Settings = (WBSettings)Application["Settings"];
            LabelHeader.Text = Settings.HeaderText;
            LabelFooter.Text = Settings.FooterText;
        }


        protected void LinkButton1_Click(object sender, EventArgs e)
        {
            Session.Remove("UserID");
            Response.Redirect("Default.aspx");
        }
    }
}