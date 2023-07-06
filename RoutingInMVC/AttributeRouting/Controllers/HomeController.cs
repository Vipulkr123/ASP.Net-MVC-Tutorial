using AttributeRouting.Models;
using System.Collections.Generic;
using System.Web.Mvc;

namespace AttributeRouting.Controllers
{
	[Route("Home")]
	public class HomeController : Controller
	{
		[Route("{id:alpha}")]
		public ActionResult Index(string id)
		{
			List<Student> students = new List<Student>()
		{
			new Student() { Id = 1, Name = "Vipul" },
			new Student() { Id = 2, Name = "Priyanka" },
			new Student() { Id = 3, Name = "Anurag" },
			new Student() { Id = 4, Name = "Sambit" }
		};
			return View();
		}
		// Optional URI Parameter
		[Route("{sid ?}")]
		public ActionResult About(string sid)
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