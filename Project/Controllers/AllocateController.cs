using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using TransportProject.Models;

namespace TransportProject.Controllers
{
    public class AllocateController : Controller
    {
        // GET: Allocate
        public ActionResult Index()
        {
            DataModel dmobj = new DataModel();
            DataTable dt = dmobj.GetEmployee();

            return View("~/Views/Home/HomePage.cshtml", dt);
        }

        //public ActionResult AllocateRecords(int Employeeid)
        //{
        //    DataModel dmobj = new DataModel();
        //    DataTable dt = dmobj.EmployeeByVehicle(Employeeid);
        //    return View("AllocateRecord", dt);
        //}

        public ActionResult AllocateRecords()
        {
            DataModel dmobj = new DataModel();
            DataTable dt = dmobj.EmployeeByVehicle();
            return View("AllocateRecord", dt);
        }

        public ActionResult AllocateEdit(int Employeeid)
        {
            DataModel dmobj = new DataModel();
            DataTable dt = dmobj.AllocateByNo(Employeeid);
            return View(dt);
        }


        public ActionResult UpdateVehicleAllocate(FormCollection frm, string action)
        {
            DataModel dmodel = new DataModel();
            if (action == "Submit")
            {
         
                int vVehicleNumber = Convert.ToInt32(frm["txtvehiclenumber"]); 
                int eEmployeeid = Convert.ToInt32(frm["txtemployeeid"]);
                
                int res = dmodel.UpdateVehicleAllocates(vVehicleNumber, eEmployeeid);

                return RedirectToAction("Index");
            }
            return View();

        }



    }
}