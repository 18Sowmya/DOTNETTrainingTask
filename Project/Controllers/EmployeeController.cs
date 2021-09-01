using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using TransportProject.Models;

namespace TransportProject.Controllers
{
    public class EmployeeController : Controller
    {
        // GET: Employee
        public ActionResult Index()
        {
            DataModel dmobj = new DataModel();
            DataTable dt = dmobj.GetEmployee();

            return View("~/Views/Home/HomePage.cshtml", dt);
        }

        public ActionResult Insert()
        {
            DataModel dmobj = new DataModel();
            DataTable dt = dmobj.GetEmployee();

            return View("EmployeeInsert", dt);


        }

        public ActionResult InsertEmployee(FormCollection frm, string action)
        {
            DataModel dmobj = new DataModel();
            int eVehicleID=0;

            if (action == "Submit")
            {
                int eEmployeeid = Convert.ToInt32(frm["txtemployeeid"]);
                string eEmployeename = frm["txtemployeename"];
                int eAge = Convert.ToInt32(frm["txtage"]);
                string eLocations = frm["txtlocations"];
                string ePhone = frm["txtphone"];
               
                    string sVehicleID = frm["txtvehicleid"];
               if(sVehicleID != null)
               {
                   eVehicleID = Convert.ToInt32(sVehicleID);
                }
               
                int instatus = dmobj.InsertEmployees(eEmployeeid, eEmployeename, eAge, eLocations, ePhone, eVehicleID);
                DataTable dt = dmobj.GetEmployee();

                return View("~/Views/Home/HomePage.cshtml", dt);
            }
            else
            {
                DataTable dt = dmobj.GetEmployee();
                return RedirectToAction("~/Views/Home/HomePage.cshtml", dt);
            }
        }

        public ActionResult EmployeeRecord()
        {
            DataModel dmobj = new DataModel();
            DataTable dt = dmobj.GetEmployee();

            return View("EmployeeRecords", dt);

        }

        public ActionResult EmployeeEdit(int Employeeid)
        {
            DataModel dmobj = new DataModel();
            DataTable dt = dmobj.EmployeeByNo(Employeeid);
            return View(dt);
        }

        public ActionResult UpdateEmployee(FormCollection frm, string action)
        {
            DataModel dmodel = new DataModel();
            if (action == "Submit")
            {
                int eEmployeeid = Convert.ToInt32(frm["txtemployeeid"]);
                string eEmployeename = frm["txtemployeename"];
                int eAge = Convert.ToInt32(frm["txtage"]);
                string eLocations = frm["txtlocations"];
                string ePhone = frm["txtphone"];
                int eVehicleID = Convert.ToInt32(frm["txtvehicleid"]);
                int res = dmodel.UpdateEmployees(eEmployeeid, eEmployeename, eAge, eLocations, ePhone, eVehicleID);

                return RedirectToAction("Index");
            }
            return View();

        }
    }
}