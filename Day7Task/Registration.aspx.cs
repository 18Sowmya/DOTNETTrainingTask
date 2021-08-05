using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication1
{
    public partial class Registration : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            if (DropDownList1.SelectedValue == "TamilNadu")
            {
                DropDownList2.Items.Clear();
                DropDownList2.Items.Add("Chennai");
                DropDownList2.Items.Add("Tiruvallur");
               
            }
            else if (DropDownList1.SelectedValue == "Kerala")
            {
                DropDownList2.Items.Clear();
                DropDownList2.Items.Add("Kochi");
                DropDownList2.Items.Add("Tirusur");
              
            }
            else if (DropDownList1.SelectedValue == "AndhraPradhesh")
            {
                DropDownList2.Items.Clear();
                DropDownList2.Items.Add("Tirupati");
                DropDownList2.Items.Add("Vijayawada");
            }
            else if (DropDownList1.SelectedValue == "Telangana")
            {
                DropDownList2.Items.Clear();
                DropDownList2.Items.Add("Hyderabad");
                DropDownList2.Items.Add("Warangal");
            }
            else if (DropDownList1.SelectedValue == "Karnataka")
            {
                DropDownList2.Items.Clear();
                DropDownList2.Items.Add("Bangalore");
                DropDownList2.Items.Add("Mysore");
            }
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            ListBox1.Items.Clear();
            ListBox1.Items.Add(TextBox1.Text);
            ListBox1.Items.Add(TextBox2.Text);
            ListBox1.Items.Add(RadioButtonList1.SelectedItem.Value);
            ListBox1.Items.Add(TextBox3.Text);
            ListBox1.Items.Add(DropDownList1.SelectedValue);
            ListBox1.Items.Add(ListBox1.SelectedValue);


        }

      
    }
}