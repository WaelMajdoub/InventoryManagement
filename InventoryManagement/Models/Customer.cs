using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace InventoryManagement.Models
{
	public class Customer
	{
		public long Id { get; set; }

		public ApplicationUser User { get; set; }
		public ICollection<CustomerOrder> CustomerOrders { get; set; }
	}
}