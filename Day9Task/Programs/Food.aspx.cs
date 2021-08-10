using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication1
{
    public partial class Food : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            try
            {
                if (Session["Food"].Equals("BreakFast"))
                {
                    List<string> students = new List<string>
                    { "Dosa",
                      "Idly",
                      "Upma"
                     };

                    foreach (var v in students)
                    {
                        Response.Write("\n" + v);
                    }

                }
                if (Session["Food"].Equals("Lunch"))
                {
                    List<string> students = new List<string>
                    { "Brinji",
                      "Fried Rice",
                      "Noodles"
                     };

                    foreach (var v in students)
                    {
                        Response.Write("\n" + v);
                    }

                }
                if (Session["Food"].Equals("Snacks"))
                {
                    List<string> students = new List<string>
                    { "Samosa",
                      "Puffs",
                      "Veg roll"
                     };

                    foreach (var v in students)
                    {
                        Response.Write("\n" + v);
                    }

                }


            }
            catch (Exception ex)
            {
                Response.Write( ex.Message );
            }
        }
    }
}