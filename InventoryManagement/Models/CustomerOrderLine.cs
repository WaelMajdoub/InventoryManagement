using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace InventoryManagement.Models
{
	public class CustomerOrderLine
	{
		public long Id { get; set; }

		public Article Article { get; set; }
		public long ArticleId { get; set; }

		public CustomerOrder CustomerOrder { get; set; }
		public long CustomerOrderId { get; set; }

	}
}