using HRM.Web.Models;

namespace HRM.Web.ViewModels
{
	public class DepartmentViewModel
	{
		public int Id { get; set; }
		public string Name { get; set; }
		public string? Description { get; set; }
		public DateTime? Established { get; set; }
	}
}