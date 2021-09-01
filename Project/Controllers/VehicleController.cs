using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using TransportProject.Models;
    
namespace TransportProject.Controllers
{
    public class VehicleController : Controller
    {
        // GET: Vehicle
        public ActionResult Index()
        {
            DataModel dmobj = new DataModel();
            DataTable dt = dmobj.GetVehicle();

            return View("~/Views/Home/HomePage.cshtml", dt);
        }


        public ActionResult Insert()
        {
            DataModel dmobj = new DataModel();
            DataTable dt = dmobj.GetVehicle();

            return View("VehiclePage", dt);


        }




        public ActionResult InsertRecord(FormCollection frm, string action)
        {
            DataModel dmobj = new DataModel();

            if (action == "Submit")
            {
                int vVehicleNumber = Convert.ToInt32(frm["txtvehicle"]);
                int vCapacity = Convert.ToInt32(frm["txtcapacity"]);
                int vAvailableSeats = Convert.ToInt32(frm["txtavailable"]);
                //bool vIsOperable = Convert.ToBoolean(frm["isOperable"]);
                //bool vIsOperable = Convert.ToBoolean(IsOperable).Checked ? "Y" : "N";
                string vIsOperable = frm["txtoperable"];

             
                int instatus = dmobj.InsertVehicles(vVehicleNumber, vCapacity, vAvailableSeats, vIsOperable);
                DataTable dt = dmobj.GetVehicle();
                //return View("Home", dt);
                return View("~/Views/Home/HomePage.cshtml", dt);
            }
            else
            {
                DataTable dt = dmobj.GetVehicle();
                return RedirectToAction("~/Views/Home/HomePage.cshtml", dt);
            }
        }

        public ActionResult Record()
        {
            DataModel dmobj = new DataModel();
            DataTable dt = dmobj.GetVehicle();

            return View("Records", dt);

        }

        public ActionResult EditVehicle(int VehicleNumber)
        {
            DataModel dmobj = new DataModel();
            DataTable dt = dmobj.VehicleByNo(VehicleNumber);
            return View(dt);
        }

        public ActionResult UpdateVehicle(FormCollection frm, string action)
        {
            DataModel dmodel = new DataModel();
            if (action == "Submit")
            {
                int vVehicleNumber = Convert.ToInt32(frm["txtvehicle"]);
                int vCapacity = Convert.ToInt32(frm["txtcapacity"]);
                int vAvailableSeats = Convert.ToInt32(frm["txtavailable"]);
                string vIsOperable = frm["txtoperable"];
                int res = dmodel.UpdateVehicles(vVehicleNumber, vCapacity, vAvailableSeats, vIsOperable);

                return RedirectToAction("Index");
            }
            return View();

        }
    }
}