using System;
using System.ComponentModel.DataAnnotations;
namespace HtmlHelpers.Models
{
	public class Employee
	{
		public int EmployeeId { get; set; }
		[Display(Name = "Name")]
		public string EmployeeName { get; set; }
		public string Password { get; set; }
		public string Gender { get; set; }
		public string City { get; set; }
		public Nullable<decimal> Salary { get; set; }
		public string Address { get; set; }
		public bool isActive { get; set; }
	}

	public enum Gender
	{
		Male,
		Female
	}
}