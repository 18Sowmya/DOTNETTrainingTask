using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication1
{

    public partial class Register : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            ArrayList list = new ArrayList();
            list.Add(Fname.Text);
            list.Add(Lname.Text);
            list.Add(Age.Text);
            list.Add(Gender.SelectedValue.ToString());
            list.Add(Martial.SelectedValue.ToString());
            list.Add(Email.Text);
            list.Add(Pincode.Text);
            list.Add(Password.Text);
            list.Add(ConfirmPassword.Text);
            list.Add(CheckBoxOccu.SelectedValue.ToString());

            FileStream fs = new FileStream("D:\\Inatech\\Register.txt", FileMode.OpenOrCreate, FileAccess.ReadWrite);
            StreamWriter sw = new StreamWriter(fs);
            foreach (var v in list)
                sw.Write(v + "\t");

            sw.Flush();
            sw.Close();
            fs.Close();
            Response.Redirect("Ending.aspx");
        }
    }
}
