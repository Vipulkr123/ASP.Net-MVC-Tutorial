using StronglyTypedView.BAL;
using StronglyTypedView.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace StronglyTypedView.Controllers
{
	public class HomeController : Controller
	{
		public ActionResult Index()
		{
			EmployeeBusinessLayer employeeBL = new EmployeeBusinessLayer();
			Employee employee = employeeBL.GetEmployeeDetails(101);
			ViewBag.Header = "Employee Details";
			return View(employee);
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