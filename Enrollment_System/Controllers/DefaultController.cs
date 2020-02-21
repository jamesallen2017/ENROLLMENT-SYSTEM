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
    public class DefaultController : Controller
    {
        string ENTRMNT_REGISTRATION = ConfigurationManager.ConnectionStrings["Enrollment_Registration"].ConnectionString;
        // GET: Default
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult Registration()
        {
            return View();
        }
        [HttpPost]
        public JsonResult Registration(Enrollment_Registration main)
        {
            var data = Insert_Registration(main);

            return Json(data);
        }

        public int Insert_Registration(Enrollment_Registration main)
        {
            int i = 0;
            SqlConnection connection = null;
            SqlCommand command = null;

            try
            {
                using (connection = new SqlConnection(ENTRMNT_REGISTRATION))
                {
                    connection.Open();
                    using (command = new SqlCommand("Insert_UserRegistration", connection))
                    {
                        command.CommandType =CommandType.StoredProcedure;
                        command.Parameters.AddWithValue("@ENRMNT_FIRSTNAME", main.FirstName);
                        command.Parameters.AddWithValue("@ENRMNT_MIDDLENAME", main.MiddleName);
                        command.Parameters.AddWithValue("@ENRMNT_LASTNAME", main.LastName);
                        command.Parameters.AddWithValue("@ENRMNT_AGE", main.Age);
                        command.Parameters.AddWithValue("@ENRMNT_SEX", main.Gender);
                        command.Parameters.AddWithValue("@ENRMNT_ENTRYYEAR", main.EntryYear);
                        command.Parameters.AddWithValue("@ENRMNT_EMAIL", main.EmailAddress);
                        command.Parameters.AddWithValue("@ENRMNT_BIRTHDATE", main.BirthDate);
                        command.Parameters.AddWithValue("@ENRMNT_GRADE", main.Grade);
                        command.Parameters.AddWithValue("@ENRMNT_MOBILE", main.MobileNumber);
                        command.Parameters.AddWithValue("@ENRMNT_LOCATION", main.Location);

                        command.ExecuteNonQuery();
                        i++;
                        return i;
                    }
                }
            }
            catch
            {
                throw;
            }
            finally
            {
                connection.Close();
            }
        }
    }
}