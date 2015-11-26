using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Message_Prototype
{
    public partial class SendMessage : System.Web.UI.Page
    {
        Message mssg;
        protected void Page_Load(object sender, EventArgs e)
        {
            RadioButtonList1.SelectedIndex = 0;
        }

        protected void btnSend_Click(object sender, EventArgs e)
        {
            string subject = TextBox1.Text;
            string typUsr = RadioButtonList1.SelectedIndex.ToString();
            string nme =  Session["usrname"].ToString();
            mssg = new Message(TextArea1.InnerText, DateTime.Now, nme,subject, typUsr);
        }
    }
}