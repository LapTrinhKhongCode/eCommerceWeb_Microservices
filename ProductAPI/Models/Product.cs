﻿using System.ComponentModel.DataAnnotations;

namespace ProductAPI.Models
{
	public class Product
	{
		[Key]
		public int ProductId { get; set; }
		[Required]
		public string Name { get; set; }
		public string Description { get; set; }
		[Range(1,1000)]
		public decimal Price { get; set; }
		public string CategoryName { get; set; }
		public string ImageUrl { get; set; }

	}
}
