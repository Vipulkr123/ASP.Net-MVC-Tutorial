using ActionLink.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ActionLink.EmployeeDb
{
	public class EmployeeDbContext
	{
		public Employee GetEmployeeDetails()
		{
			Employee employee = new Employee()
			{
				EmployeeId = 5,
				Name = "Vipul Kumar",
				City = "Ahmedabad",
				Address = "Gujarat",
				Gender = "Male",
				Salary = 10000
			};
			return employee;
		}
	}
}