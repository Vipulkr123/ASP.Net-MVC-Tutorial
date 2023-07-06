using HtmlHelpers.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace HtmlHelpers.Controllers
{
	public class HomeController : Controller
	{
		public ActionResult Index()
		{
			Employee emp = new Employee()
			{
				EmployeeId = 1,
				Address = "Thaltej, Ahmedabad, Gujarat, 380029, India"
			};
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