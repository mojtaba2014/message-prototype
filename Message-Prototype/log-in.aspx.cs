using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Message_Prototype
{
    public partial class log_in : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            TextBox1.Text = "";
            TextBox2.Text = "";
        }
        private void MessageBoxShow(Page page, string message)
        {
            Literal ltr = new Literal();
            ltr.Text = @"<script type='text/javascript'> alert('" + message + "') </script>";
            page.Controls.Add(ltr);
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            string txtusr = TextBox1.Text;
            string txtpsswrd = TextBox2.Text;
            while (txtusr != null && txtpsswrd != null)
            {
                try
                {
                    Session["usrname"] = txtusr;
                    Session["pasword"] = txtpsswrd;
                    Response.Redirect("SendMessage.aspx");
                }
                catch
                {
                    MessageBoxShow(this, "fill username and password");

                }

            }
        }
    }
}