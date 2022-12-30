﻿namespace BulkyBook.Models
{
	using System.ComponentModel.DataAnnotations;
	using System.ComponentModel.DataAnnotations.Schema;
	using Microsoft.AspNetCore.Mvc.ModelBinding.Validation;

	public class OrderDetail
	{
		public int Id { get; set; }
		[Required]
		public int OrderId { get; set; }
		[ValidateNever]
		[ForeignKey("OrderId")]
		public OrderHeader OrderHeader { get; set; }
		[Required]
		public int ProductId { get; set; }
		[ValidateNever]
		[ForeignKey("ProductId")]
		public Product Product { get; set; }
		public int Count { get; set; }
		public double Price { get; set; }
	}
}
