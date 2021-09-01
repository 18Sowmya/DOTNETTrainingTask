using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using TransportProject.Models;

namespace TransportProject.Controllers
{
    public class RouteController : Controller
    {
        // GET: Route
        public ActionResult Index()
        {
            DataModel dmobj = new DataModel();
            DataTable dt = dmobj.GetRoute();

            return View("~/Views/Home/HomePage.cshtml", dt);
        }

        public ActionResult Insert()
        {
            DataModel dmobj = new DataModel();
            DataTable dt = dmobj.GetRoute();

            return View("RouteInsert", dt);


        }

        public ActionResult InsertRoute(FormCollection frm, string action)
        {
            DataModel dmobj = new DataModel();

            if (action == "Submit")
            {
                int rRootNumber = Convert.ToInt32(frm["txtrootnumber"]);
                int rVehicleNumber = Convert.ToInt32(frm["txtvehiclenumber"]);
                string rStop1 = frm["txtstop1"];
                string rStop2 = frm["txtstop2"];
                string rStop3 = frm["txtstop3"];
                int instatus = dmobj.InsertRoutes(rRootNumber, rVehicleNumber, rStop1, rStop2, rStop3);
                DataTable dt = dmobj.GetVehicle();
                
                return View("~/Views/Home/HomePage.cshtml", dt);
            }
            else
            {
                DataTable dt = dmobj.GetVehicle();
                return RedirectToAction("~/Views/Home/HomePage.cshtml", dt);
            }
        }

        public ActionResult RouteRecord()
        {
            DataModel dmobj = new DataModel();
            DataTable dt = dmobj.GetRoute();

            return View("RouteRecords", dt);

        }

        public ActionResult RouteEdit(int RootNumber)
        {
            DataModel dmobj = new DataModel();
            DataTable dt = dmobj.RouteByNo(RootNumber);
            return View(dt);
        }

        public ActionResult UpdateRoute(FormCollection frm, string action)
        {
            DataModel dmodel = new DataModel();
            if (action == "Submit")
            {
                int rRootNumber = Convert.ToInt32(frm["txtrootnumber"]);
                int rVehicleNumber = Convert.ToInt32(frm["txtvehiclenumber"]);
                string rStop1 = frm["txtstop1"];
                string rStop2 = frm["txtstop2"];
                string rStop3 = frm["txtstop3"];
                int res = dmodel.UpdateRoutes(rRootNumber, rVehicleNumber, rStop1, rStop2, rStop3);

                return RedirectToAction("Index");
            }
            return View();

        }
    }
}