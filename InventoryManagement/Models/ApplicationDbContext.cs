using System.Data.Entity;
using Microsoft.AspNet.Identity.EntityFramework;

namespace InventoryManagement.Models
{
	public class ApplicationDbContext : IdentityDbContext<ApplicationUser>
	{
		public DbSet<Category> Categories { get; set; }
		private DbSet<Article> articles { get; set; }
		public ApplicationDbContext()
			: base("DefaultConnection", throwIfV1Schema: false)
		{
		}

		public static ApplicationDbContext Create()
		{
			return new ApplicationDbContext();
		}

	}
}