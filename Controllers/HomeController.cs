using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Security;
using System.Web.Services;

namespace CasaVueStatic.Controllers
{
    public class HomeController : Controller
    {
        //
        // GET: /Home/

        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            return View();
        }

        public ActionResult MyTest()
        {
            return View();
        }

        //check if user email exists
        [HttpPost]
        public JsonResult doesUserEmailExist(string UserName)
        {
            SqlConnection vcon = new SqlConnection(ConfigurationManager.ConnectionStrings["DefaultConnection"].ToString());

            SqlDataAdapter da = new SqlDataAdapter("select * from UserProfile WHERE UserName='"+UserName+"'", vcon);
            var dt = new DataTable();
            da.Fill(dt);

            //var userExists = dt.Rows[0]["UserName"];
            //var user = Membership.FindUsersByEmail(UserName);
            if (dt.Rows.Count > 0)            
                return Json(true);
            else
                return Json(false);

        }

        public JsonResult doesUserNameExistGet(string term)
        {

            var user = Membership.GetUser(term);

            return Json(user == null, JsonRequestBehavior.AllowGet);
        }


        public SqlDataAdapter da { get; set; }
    }
}
