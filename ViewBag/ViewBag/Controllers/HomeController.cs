using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using ViewBag.BAL;
using ViewBag.Models;

namespace ViewBag.Controllers
{
	public class HomeController : Controller
	{
		public ActionResult Index()
		{
			EmployeeBusinessLayer employeeBL = new EmployeeBusinessLayer();
			Employee employee = employeeBL.GetEmployeeDetails(101);

			ViewBag.Employee = employee;
			ViewBag.Header = "Employee Details";
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