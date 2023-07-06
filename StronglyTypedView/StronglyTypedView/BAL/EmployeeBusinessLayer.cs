using StronglyTypedView.Models;
namespace StronglyTypedView.BAL
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