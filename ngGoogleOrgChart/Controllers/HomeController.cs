using ngGoogleOrgChart.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ngGoogleOrgChart.Controllers
{
    public class HomeController : Controller
    {
        //
        // GET: /Home/
        public ActionResult Index()
        {
            return View();
        }

        public JsonResult getChartData()
        {
            List<EmployeeTable> list = new List<EmployeeTable>();
            using (dbEntities dc = new dbEntities())
            {
                list = dc.EmployeeTables.ToList();
            }

            return new JsonResult {  Data = list,  JsonRequestBehavior = JsonRequestBehavior.AllowGet};
        }
	}
}