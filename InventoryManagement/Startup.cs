using InventoryManagement.Models;
using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.EntityFramework;
using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(InventoryManagement.Startup))]
namespace InventoryManagement
{
    public partial class Startup
    {	
				ApplicationDbContext db= new ApplicationDbContext();
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
						CreateRoles();
						CreateUsers();
        }

				public void CreateUsers()
				{
					var useManager = new UserManager<ApplicationUser>(new UserStore<ApplicationUser>(db));
					var user= new ApplicationUser();
					user.Email = "default@example.com";
					user.UserName = "default@example.com";
					var check = useManager.Create(user, "default@!123");
					if (check.Succeeded)
					{
						useManager.AddToRole(user.Id, "Admins");
					}
				}
		public void CreateRoles()
				{
					var roleManager = new RoleManager<IdentityRole>(new RoleStore<IdentityRole>(db));
					IdentityRole role;
					if (!roleManager.RoleExists("Admins"))
					{
						role = new IdentityRole {Name = "Admins"};
						roleManager.Create(role);
					}
					if (!roleManager.RoleExists("Read"))
					{
						role = new IdentityRole {Name = "Read"};
						roleManager.Create(role);
					}
		}
    }
}
