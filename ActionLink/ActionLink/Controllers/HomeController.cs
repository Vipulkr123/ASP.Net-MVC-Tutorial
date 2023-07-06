using ActionLink.EmployeeDb;
using ActionLink.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ActionLink.Controllers
{
	public class HomeController : Controller
	{
		public ActionResult Index()
		{
			EmployeeDbContext dbContext = new EmployeeDbContext();
			Employee emp = dbContext.GetEmployeeDetails();
			return View(emp);
		}

		public ActionResult About()
		{
			ViewBag.Message = "Your application description page.";

			return View();
		}

		public ActionResult Contact()
		{
			ViewBag.Message = "Your contact page.";

			return View();
		}
	}
}