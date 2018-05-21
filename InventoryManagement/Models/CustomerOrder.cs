using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace InventoryManagement.Models
{
	public class CustomerOrder
	{
		public long Id { get; set; }

		public string Code { get; set; }

		public DateTime Date { get; set; }
		public Customer Customer { get; set; }
		public long CustomerId { get; set; }

		public ICollection<CustomerOrderLine> CustomerOrderLines { get; set; }
	}
}