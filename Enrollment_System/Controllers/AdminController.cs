using Enrollment_System.Models;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Enrollment_System.Controllers
{
    public class AdminController : Controller
    {
        string ENTRMNT_REGISTRATION = ConfigurationManager.ConnectionStrings["Enrollment_Registration"].ConnectionString;
        // GET: Admin
        public ActionResult Index()
        {
            Enrollment_Registration model = new Enrollment_Registration();
            model.PopulatealLRecords = PopulateAllRecords();
            return View(model);
        }
        public ActionResult Login()
        {
            return View();
        }

        public ActionResult StudentProfile()
        {
            return View();
        }
        public ActionResult StudentApplication_form()
        {
            return View();
        }
        public ActionResult TeacherApplication_form()
        {
            return View();
        }
        public ActionResult ClassManagement()
        {
            return View();
        }
        public ActionResult TeacherProfile()
        {
            ViewBag.Classes = "true";
            return View();
        }
        public ActionResult GetTeacherProfile()
        {
            ViewBag.Classes = "false";
            return View("~/Views/Admin/TeacherProfile.cshtml");
        }

        public ActionResult Accounting()
        {
            ViewBag.Accounting = "true";
            return View();
        }
        public ActionResult GetPaymentDetails()
        {
            ViewBag.Accounting = "false";
            return View("~/Views/Admin/Accounting.cshtml");
        }
        


        public List<Enrollment_Registration> PopulateAllRecords()
        {
            List<Enrollment_Registration> listmodel = new List<Enrollment_Registration>();
            SqlConnection connection = null;
            SqlCommand command = null;
            try
            {
                using (connection = new SqlConnection(ENTRMNT_REGISTRATION))
                {
                    connection.Open();
                    using (command = new SqlCommand("Select_PopulateRecords", connection))
                    {
                        SqlDataAdapter sda = new SqlDataAdapter(command);
                        DataTable dt = new DataTable();
                        sda.Fill(dt);

                        foreach (DataRow row in dt.Rows) {
                            Enrollment_Registration model = new Enrollment_Registration
                            {
                                FirstName = row["ENRMNT_FIRSTNAME"].ToString(),
                                MiddleName = row["ENRMNT_MIDDLENAME"].ToString(),
                                LastName = row["ENRMNT_LASTNAME"].ToString(),
                                Age = row["ENRMNT_AGE"].ToString(),
                                Gender = row["ENRMNT_SEX"].ToString(),
                                EmailAddress = row["ENRMNT_EMAIL"].ToString(),
                                EntryYear = row["ENRMNT_ENTRYYEAR"].ToString(),
                                MobileNumber = row["ENRMNT_MOBILE"].ToString(),
                                BirthDate = row["ENRMNT_BIRTHDATE"].ToString(),
                                Grade = row["ENRMNT_GRADE"].ToString(),
                                Location = row["ENRMNT_LOCATION"].ToString(),
                                StatusForm = row["ENRMNT_FORMSTATUS"].ToString(),
                                StudentStatus = row["ENRMNT_STUDENTSTATUS"].ToString(),
                                
                            };
                            listmodel.Add(model);
                            
                        }
                        return listmodel;
                    }
                }
            }
            catch
            {
                return listmodel;

            }
            finally
            {
                connection.Close();
            }
        }
    }
}