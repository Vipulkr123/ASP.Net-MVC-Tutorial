using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using ViewData.BAL;
using ViewData.Models;

namespace ViewData.Controllers
{
	public class HomeController : Controller
	{
		public ActionResult Index()
		{
			EmployeeBusinessLayer employeeBusinessLayer = new EmployeeBusinessLayer();
			Employee employee = employeeBusinessLayer.GetEmployeeDetails(5);
			ViewData["Employee"] = employee;
			ViewData["Header"] = "Employee Details";
			return View();
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