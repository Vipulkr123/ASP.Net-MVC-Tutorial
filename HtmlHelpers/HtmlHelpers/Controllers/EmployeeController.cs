using HtmlHelpers.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace HtmlHelpers.Controllers
{
	public class EmployeeController : Controller
	{
		public ActionResult Index()
		{
			//Get the data from the database
			//Here we are creating Department list 
			List<Department> ListDepartments = new List<Department>()
			{
				new Department() {Id = 1, Name="IT" },
				new Department() {Id = 2, Name="HR" },
				new Department() {Id = 3, Name="Payroll" },
			};

			// Retrieve departments and build SelectList
			ViewBag.Departments = new SelectList(ListDepartments, "Id", "Name");
			return View();
		}
	}
}