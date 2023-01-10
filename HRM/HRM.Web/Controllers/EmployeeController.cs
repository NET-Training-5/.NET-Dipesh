using HRM.Web.Mapper;
using HRM.Web.Models;
using HRM.Web.ViewModels;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Infrastructure;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using System.Reflection;

namespace HRM.Web.Controllers
{
	public class EmployeeController : Controller
	{
		private HRDbContext db = new HRDbContext();

		public async Task<IActionResult> Index()
		{
			var employees = await db.Employees.Include(e => e.Department).ToListAsync();

			var employeeViewModels = employees.ToViewModel();
			return View(employeeViewModels);
		}

		public async Task<IActionResult> Add()
		{
			var departments = await db.Departments.Select(x => new SelectListItem { Text = x.Name, Value = x.Id.ToString() }).ToListAsync();

			ViewData["departments"] = departments;

			var designations = await db.Designations.Select(x => new SelectListItem { Text = x.Name, Value = x.Name }).ToListAsync();

			ViewData["designations"] = designations;

			return View();
		}

		[HttpPost]
		public async Task<IActionResult> Add(EmployeeViewModel employeeViewModel)
		{
			var relativePath = await SaveProfileImage(employeeViewModel.ProfileImage);

			//Map viewModel to model

			var employee = employeeViewModel.ToModel();

			employee.ProfileImagePath = relativePath;

			await db.Employees.AddAsync(employee);
			await db.SaveChangesAsync();
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

		public IActionResult Delete(int id)
		{
			var employee = db.Employees.Find(id);
			return View(employee);
		}

		[HttpPost]
		public async Task<IActionResult> Delete(Employee employee)
		{
			db.Employees.Remove(employee);
			await db.SaveChangesAsync();
			return RedirectToAction(nameof(Index));
		}

		private async Task<string> SaveProfileImage(IFormFile profileImage)
		{
			var fileName = profileImage.FileName;
			var uniqueFileName = $"{Guid.NewGuid()}_{fileName}";
			var relativePath = $"/images/profiles/{uniqueFileName}";
			var currentAppPath = Directory.GetCurrentDirectory();
			var fullFilePath = Path.Combine(currentAppPath, $"wwwroot/{relativePath}");

			var stream = System.IO.File.Create(fullFilePath);
			await profileImage.CopyToAsync(stream);
			return relativePath;
		}
	}
}