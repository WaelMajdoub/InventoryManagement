using System.Data.Entity;
using Microsoft.AspNet.Identity.EntityFramework;

namespace InventoryManagement.Models
{
	public class ApplicationDbContext : IdentityDbContext<ApplicationUser>
	{
		public DbSet<Category> Categories { get; set; }
		public DbSet<Article> Articles { get; set; }

		public DbSet<Person> Persons { get; set; }
		//public DbSet<CustomerOrderLine> CustomerOrderLines { get; set; }
		//public DbSet<Customer> Customers { get; set; }
		//public DbSet<CustomerOrder> CustomerOrders { get; set; }

		public ApplicationDbContext()
			: base("DefaultConnection", throwIfV1Schema: false)
		{
		}

		public static ApplicationDbContext Create()
		{
			return new ApplicationDbContext();
		}

		public System.Data.Entity.DbSet<InventoryManagement.Models.Customer> Customers { get; set; }

		public System.Data.Entity.DbSet<InventoryManagement.Models.CustomerOrder> CustomerOrders { get; set; }

		public System.Data.Entity.DbSet<InventoryManagement.Models.CustomerOrderLine> CustomerOrderLines { get; set; }
	}
}