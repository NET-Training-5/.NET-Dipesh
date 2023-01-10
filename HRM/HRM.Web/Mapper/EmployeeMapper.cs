using HRM.Web.Models;
using HRM.Web.ViewModels;

namespace HRM.Web.Mapper;

public static class EmployeeMapper
{
	public static EmployeeViewModel ToViewModel(this Employee employee) =>

		 new()
		 {
			 Id = employee.Id,
			 Name = employee.Name,
			 Address = employee.Address,
			 Gender = employee.Gender,
			 Dob = employee.Dob,
			 Email = employee.Email,
			 JoinDate = employee.JoinDate,
			 Designation = employee.Designation,
			 DepartmentId = employee.DepartmentId,
			 DepartmentName = employee.Department.Name,
			 ProfileImagePath = employee.ProfileImagePath
		 };

	public static List<EmployeeViewModel> ToViewModel(this List<Employee> employees) =>
		employees.Select(employee => employee.ToViewModel()).ToList();

	//write two extension methods to map viewmodel objects to model

	public static Employee ToModel(this EmployeeViewModel employeeViewModel) =>
		new()
		{
			Id = employeeViewModel.Id,
			Name = employeeViewModel.Name,
			Address = employeeViewModel.Address,
			Gender = employeeViewModel.Gender,
			Dob = employeeViewModel.Dob,
			Email = employeeViewModel.Email,
			JoinDate = employeeViewModel.JoinDate,
			Designation = employeeViewModel.Designation,
			DepartmentId = employeeViewModel.DepartmentId,
			ProfileImagePath = employeeViewModel.ProfileImagePath
		};

	public static List<Employee> ToModel(this List<EmployeeViewModel> employeeViewModels) =>
		employeeViewModels.Select(employeeViewModel => employeeViewModel.ToModel()).ToList();
}