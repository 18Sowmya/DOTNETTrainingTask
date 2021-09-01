using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace TransportProject.Controllers
{
    public class LoginController : Controller
    {
        // GET: Login
        public ActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Authorize(TransportProject.Admin Aobj)
        {
            using (ProjectEntities db = new ProjectEntities())
            {
                var userDetails = db.Admins.Where(x => x.Username == Aobj.Username && x.Password == Aobj.Password).FirstOrDefault();
                if(userDetails == null)
                {
                    Aobj.LoginErrorMessage = "Wrong username and password";
                    return View("Index", Aobj);
                }
                else
                {
                    Session["userID"] = userDetails.Userid;
                    return RedirectToAction("HomePage", "Home");
                }

            }
           
        }
    }
}