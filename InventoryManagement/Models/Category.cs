using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace InventoryManagement.Models
{
	public class Category
	{
		public long Id { get; set; }

		public string Code { get; set; }

		public string Name { get; set; }

		public ICollection<Article> Articles { get; set; }
	}
}