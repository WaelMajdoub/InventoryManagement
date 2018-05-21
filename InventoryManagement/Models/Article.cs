using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace InventoryManagement.Models
{
	public class Article
	{
		public long Id { get; set; }

		public string Code { get; set; }

		public string Name { get; set; }

		public decimal UnitPriceExcludingTax { get; set; }

		public decimal VatRate { get; set; }

		public string Picture { get; set; }

		public decimal UnitPriceIncludingTax { get; set; }

		public long CategoryId { get; set; }
		public Category Category { get; set; }
	}
}