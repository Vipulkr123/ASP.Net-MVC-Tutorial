using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace TempData.Controllers
{
	public class HomeController : Controller
	{
		public ActionResult Index()
		{
			TempData["Name"] = "Vipul Kumar";
			TempData["Age"] = 24;
			return View();
		}

		public ActionResult About()
		{
			ViewBag.Message = "Your application description page.";
			string Name;
			int Age;
			if (TempData.ContainsKey("Name"))
				Name = TempData["Name"].ToString();
			if (TempData.ContainsKey("Age"))
				Age = int.Parse(TempData["Age"].ToString());
			// for more than one place use keep method 
			TempData.Keep();
			return View();
		}

		public ActionResult Contact()
		{
			ViewBag.Message = "Your contact page.";

			return View();
		}
	}
}