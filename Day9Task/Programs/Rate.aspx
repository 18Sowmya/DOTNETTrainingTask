using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication1
{
    public partial class Rate : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            TextBox1.Visible = false;
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            Session["Rate"] = DropDownList1.SelectedItem.Text;
            if (Session["Rate"].Equals("Gold"))
            {
              
                TextBox1.Visible = true;
                TextBox1.Text="4000";


            }
            if (Session["Rate"].Equals("Silver"))
            {
                TextBox1.Visible = true;
                TextBox1.Text = "450";
            }
          
        }
    }
}
