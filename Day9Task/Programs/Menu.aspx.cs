using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication1
{
    public partial class Menu : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            List<String> students = new List<String>
            {
                "Select",
                "BreakFast",
                "Lunch",
                "Snacks"
            };
            foreach (var v in students)
                Menu_dd.Items.Add(v);

        }

        protected void DropDownList1_SelectedIndexChanged(object sender, EventArgs e)
        {
            Session["Food"] = Menu_dd.SelectedItem.Text;
            Response.Redirect("Food.aspx");

        }
    }
}