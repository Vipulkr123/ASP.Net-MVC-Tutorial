using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using ViewModel.Models;

namespace ViewModel.Controllers
{
	public class HomeController : Controller
	{
		public ActionResult Index()
		{
			Employee employee = new Employee()
			{
				EmployeeId = 101,
				Name = "Vipul Kumar",
				Gender = "Male",
				Department = "CE",
				Salary = 10000,
				AddressId = 1001
			};
			//Employee Address
			Address address = new Address()
			{
				AddressId = 1001,
				City = "Ahmedabad",
				State = "Gujarat",
				Country = "India",
				Pin = "280029"
			};

			EmployeeDetailsViewModel employeeDetailsViewModel = new EmployeeDetailsViewModel()
			{
				Employee = employee,
				Address = address,
				PageTitle = "Employee Details Page",
				PageHeader = "Employee Details",
			};
			return View(employeeDetailsViewModel);
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