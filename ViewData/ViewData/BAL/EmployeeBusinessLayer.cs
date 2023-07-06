using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using ViewData.Models;

namespace ViewData.BAL
{
	public class EmployeeBusinessLayer
	{
		public Employee GetEmployeeDetails(int id)
		{
			Employee employee = new Employee()
			{
				EmployeeId = id,
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