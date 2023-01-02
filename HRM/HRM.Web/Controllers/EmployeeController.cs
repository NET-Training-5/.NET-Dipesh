using HRM.Web.Models;
using Microsoft.AspNetCore.Mvc;

namespace HRM.Web.Controllers
{
	public class EmployeeController : Controller
	{
		private HRDbContext db = new HRDbContext();

		public IActionResult Index()
		{
			var employees = db.Employees.ToList();
			return View(employees);
		}

		public IActionResult Add()
		{
			return View();
		}

		[HttpPost]
		public IActionResult Add(Employee employee)
		{
			db.Employees.Add(employee);
			db.SaveChanges();
			return RedirectToAction(nameof(Index));
		}

		public IActionResult Edit(int id)
		{
			var employee = db.Employees.Find(id);
			return View(employee);
		}

		[HttpPost]
		public IActionResult edit(Employee employee)
		{
			db.Employees.Update(employee);
			db.SaveChanges();
			return RedirectToAction(nameof(Index));
		}
	}
}