using HRM.Web.Models;
using Microsoft.EntityFrameworkCore;

namespace HRM.Web
{
	public class HRDbContext : DbContext
	{
		public DbSet<Employee> Employees { get; set; }
		public DbSet<Department> Departments { get; set; }

		protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
		{
			optionsBuilder.UseSqlServer("Data Source =(localdb)\\mssqllocaldb;Initial Catalog=HumanResource;Integrated Security=true");
		}
	}
}