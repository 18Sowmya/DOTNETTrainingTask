using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace TransportProject.Models
{
    public class DataModel
    {
        SqlConnection con;
        public DataModel()
        {
            con = new SqlConnection("Data source=");

        }
        public DataTable GetVehicle()
        {
            string selqry = "select VehicleNumber, Capacity, AvailableSeats, IsOperable from Vehicle";
            SqlDataAdapter da = new SqlDataAdapter(selqry, con);
            DataTable dt = new DataTable();
            da.Fill(dt);
            return dt;
        }

        public int InsertVehicles(int vVehicleNumber, int vCapacity, int vAvailableSeats, string vIsOperable)
        {
            string insqry = "insert Vehicle(VehicleNumber, Capacity, AvailableSeats, IsOperable) values (@VehicleNumber, @Capacity, @AvailableSeats, @IsOperable)";
            SqlCommand cmd = new SqlCommand(insqry, con);
            cmd.Parameters.AddWithValue("@VehicleNumber", vVehicleNumber);
            cmd.Parameters.AddWithValue("@Capacity", vCapacity);
            cmd.Parameters.AddWithValue("@AvailableSeats", vAvailableSeats);
            cmd.Parameters.AddWithValue("@IsOperable", vIsOperable);
            con.Open();
            return cmd.ExecuteNonQuery();
            con.Close();
        }


        public DataTable VehicleByNo(int VehicleNumber)
        {
            string byNoQry = "select VehicleNumber, Capacity, AvailableSeats, IsOperable from Vehicle where VehicleNumber =" + VehicleNumber;
            SqlDataAdapter da = new SqlDataAdapter(byNoQry, con);
            DataTable dt = new DataTable();
            da.Fill(dt);
            return dt;
        }

        public int UpdateVehicles(int vVehicleNumber, int vCapacity, int vAvailableSeats, string vIsOperable)
        {
            string updqry = "update Vehicle set VehicleNumber=@VehicleNumber, Capacity =@Capacity,AvailableSeats = @AvailableSeats, IsOperable=@IsOperable where VehicleNumber = @VehicleNumber";

            SqlCommand cmd = new SqlCommand(updqry, con);
            cmd.Parameters.AddWithValue("@VehicleNumber", vVehicleNumber);
            cmd.Parameters.AddWithValue("@Capacity", vCapacity);
            cmd.Parameters.AddWithValue("@AvailableSeats", vAvailableSeats);
            cmd.Parameters.AddWithValue("@IsOperable", vIsOperable);
            con.Open();
            int res = cmd.ExecuteNonQuery();
            con.Close();
            return res;
        }

        public DataTable GetRoute()
        {
            string selqry = "select RootNumber, VehicleNumber, Stop1, Stop2, Stop3 from RouteInfo";
            SqlDataAdapter da = new SqlDataAdapter(selqry, con);
            DataTable dt = new DataTable();
            da.Fill(dt);
            return dt;
        }

        public int InsertRoutes(int rRootNumber, int rVehicleNumber, string rStop1, string rStop2, string rStop3)
        {
            string insqry = "insert RouteInfo(RootNumber, VehicleNumber, Stop1, Stop2, Stop3) values (@RootNumber, @VehicleNumber, @Stop1, @Stop2, @Stop3)";
            SqlCommand cmd = new SqlCommand(insqry, con);
            cmd.Parameters.AddWithValue("@RootNumber", rRootNumber);
            cmd.Parameters.AddWithValue("@VehicleNumber", rVehicleNumber);
            cmd.Parameters.AddWithValue("@Stop1", rStop1);
            cmd.Parameters.AddWithValue("@Stop2", rStop2);
            cmd.Parameters.AddWithValue("@Stop3", rStop3);
            con.Open();
            return cmd.ExecuteNonQuery();
            con.Close();
        }

        public DataTable RouteByNo(int RootNumber)
        {
            string byNoQry = "select RootNumber, VehicleNumber, Stop1, Stop2, Stop3 from RouteInfo where RootNumber =" + RootNumber;
            SqlDataAdapter da = new SqlDataAdapter(byNoQry, con);
            DataTable dt = new DataTable();
            da.Fill(dt);
            return dt;
        }

        public int UpdateRoutes(int rRootNumber, int rVehicleNumber, string rStop1, string rStop2, string rStop3)
        {
            string updqry = "update RouteInfo set RootNumber=@RootNumber, VehicleNumber=@VehicleNumber, Stop1=@Stop1, Stop2=@Stop2, Stop3=@Stop3 where RootNumber = @RootNumber";

            SqlCommand cmd = new SqlCommand(updqry, con);
            cmd.Parameters.AddWithValue("@RootNumber", rRootNumber);
            cmd.Parameters.AddWithValue("@VehicleNumber", rVehicleNumber);
            cmd.Parameters.AddWithValue("@Stop1", rStop1);
            cmd.Parameters.AddWithValue("@Stop2", rStop2);
            cmd.Parameters.AddWithValue("@Stop3", rStop3);
            con.Open();
            int res = cmd.ExecuteNonQuery();
            con.Close();
            return res;
        }

        public DataTable GetEmployee()
        {
            string selqry = "select EmployeeId, EmployeeName, Age, Locations, Phone, VehicleID from Employee";
            SqlDataAdapter da = new SqlDataAdapter(selqry, con);
            DataTable dt = new DataTable();
            da.Fill(dt);
            return dt;
        }
        public int InsertEmployees(int eEmployeeid, string eEmployeename, int eAge, string eLocations, string ePhone, int eVehicleID)
        {
            string insqry = "insert Employee(EmployeeId, EmployeeName, Age, Locations, Phone, VehicleID) values (@EmployeeId, @EmployeeName, @Age, @Locations, @Phone, @VehicleID)";
            SqlCommand cmd = new SqlCommand(insqry, con);
            cmd.Parameters.AddWithValue("@EmployeeId", eEmployeeid);
            cmd.Parameters.AddWithValue("@EmployeeName", eEmployeename);
            cmd.Parameters.AddWithValue("@Age", eAge);
            cmd.Parameters.AddWithValue("@Locations", eLocations);
            cmd.Parameters.AddWithValue("@Phone", ePhone);
            cmd.Parameters.AddWithValue("@VehicleID", eVehicleID);
            con.Open();
            return cmd.ExecuteNonQuery();
            con.Close();
        }

        public DataTable EmployeeByNo(int EmployeeId)
        {
            string byNoQry = "select EmployeeId, EmployeeName, Age, Locations, Phone, VehicleID from Employee where EmployeeId =" + EmployeeId;
            SqlDataAdapter da = new SqlDataAdapter(byNoQry, con);
            DataTable dt = new DataTable();
            da.Fill(dt);
            return dt;
        }

        public int UpdateEmployees(int eEmployeeid, string eEmployeename, int eAge, string eLocations, string ePhone, int eVehicleID)
        {
            string updqry = "update Employee set EmployeeId=@EmployeeId, EmployeeName=@EmployeeName, Age=@Age, Locations=@Locations, Phone=@Phone, VehicleID=@VehicleID where EmployeeId = @EmployeeId";

            SqlCommand cmd = new SqlCommand(updqry, con);
            cmd.Parameters.AddWithValue("@EmployeeId", eEmployeeid);
            cmd.Parameters.AddWithValue("@EmployeeName", eEmployeename);
            cmd.Parameters.AddWithValue("@Age", eAge);
            cmd.Parameters.AddWithValue("@Locations", eLocations);
            cmd.Parameters.AddWithValue("@Phone", ePhone);
            cmd.Parameters.AddWithValue("@VehicleID", eVehicleID);
            con.Open();
            int res = cmd.ExecuteNonQuery();
            con.Close();
            return res;
        }

        public DataTable EmployeeByVehicle()
        {
            string byNoQry = "select EmployeeId, EmployeeName,  Locations,  VehicleID from Employee where VehicleID=0 "; 
            SqlDataAdapter da = new SqlDataAdapter(byNoQry, con);
            DataTable dt = new DataTable();
            da.Fill(dt);
            return dt;
        }

        //public int AvailableSeats(int VehicleNumber)
        //{
        //    string byNoQry = "select VehicleNumber from Vehicle where capacity >=availableseats and VehicleNumber" + VehicleNumber;
        //}
        public DataTable AllocateByNo(int Employeeid)
        {
            //string byNoQry = "select EmployeeId, EmployeeName, Locations, VehicleID from Employee where EmployeeId = " + Employeeid;
            string byNoQry = "select Employee.EmployeeId, Employee.EmployeeName, Employee.Locations, RouteInfo.VehicleNumber from Employee  join RouteInfo on RouteInfo.Stop1 = Employee.locations or RouteInfo.Stop2 = Employee.locations or RouteInfo.Stop3 = Employee.locations  where Employee.VehicleID = 0 and  Employee.EmployeeId = " + Employeeid;
            //string byNoQry = "select Employee.EmployeeId, Employee.EmployeeName, Employee.Locations, RouteInfo.VehicleNumber from Employee  join RouteInfo on RouteInfo.Stop1 = Employee.locations or RouteInfo.Stop2 = Employee.locations or RouteInfo.Stop3 = Employee.locations join Vehicle on Vehicle.VehicleNumber=RouteInfo.VehicleNumber   where Employee.VehicleID = 0 and  Vehicle.Capacity >=Vehicle.AvailableSeats and Employee.EmployeeId = " + Employeeid;
            SqlDataAdapter da = new SqlDataAdapter(byNoQry, con);
            DataTable dt = new DataTable();
            da.Fill(dt);
            return dt;
        }


        public int UpdateVehicleAllocates(int vVehicleNumber, int eEmployeeid)
        {
            string updqry = "update Employee set VehicleID=@VehicleID where EmployeeId = @EmployeeId";
            //string updqry = "update Employee set Employee.VehicleID = @RouteInfo.VehicleNumber  from Employee join RouteInfo on RouteInfo.Stop1 = Employee.locations  or RouteInfo.Stop2 = Employee.locations  or RouteInfo.Stop3 = Employee.locations where Employee.VehicleID = 0 and  Employee.EmployeeId = " + eEmployeeid;
            SqlCommand cmd = new SqlCommand(updqry, con);
            cmd.Parameters.AddWithValue("@VehicleID", vVehicleNumber);
            cmd.Parameters.AddWithValue("@EmployeeId", eEmployeeid);
            
            con.Open();
            int res = cmd.ExecuteNonQuery();
            con.Close();
            return res;
        }
    }
}
