using HRM.Web.Models;
using HRM.Web.ViewModels;

namespace HRM.Web.Mapper
{
	public static class DepartmentMapper
	{
		public static DepartmentViewModel ToViewModelDepartment(this Department department) =>
			new()
			{
				Id = department.Id,
				Name = department.Name,
				Description = department.Description,
				Established = department.Established,
			};

		public static List<DepartmentViewModel> ToViewModelDepartment(this List<Department> departments) =>
		departments.Select(departments => departments.ToViewModelDepartment()).ToList();

		public static Department ToModelDepartment(this DepartmentViewModel departmentViewModel) =>
		new()
		{
			Id = departmentViewModel.Id,
			Name = departmentViewModel.Name,
			Description = departmentViewModel.Description,
			Established = departmentViewModel.Established,
		};

		public static List<Department> ToModelDepartment(this List<DepartmentViewModel> departmentViewModels) =>
			departmentViewModels.Select(departmentViewModel => departmentViewModel.ToModelDepartment()).ToList();
	}
}