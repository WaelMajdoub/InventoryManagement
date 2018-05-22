using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using Microsoft.AspNet.Identity.EntityFramework;

namespace InventoryManagement.Models
{
	public class Customer : Person
	{
		public ICollection<CustomerOrder> CustomerOrders { get; set; }
	}
}