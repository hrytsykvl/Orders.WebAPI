﻿using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Orders.WebAPI.Entities
{
	public class Order
	{
		[Key]
		public Guid OrderId { get; set; }

		[Required(ErrorMessage = "The OrderNumber field is required.")]
		[RegularExpression(@"^(?i)ORD_\d{4}_\d+$\r\n", 
			ErrorMessage = "The Order number should begin with 'ORD' followed by an underscore (_) and a sequential number.")]
		public string? OrderNumber { get; set; }

		[Required(ErrorMessage = "The CustomerName field is required.")]
		[StringLength(50, ErrorMessage = "The CustomerName field must not exceed 50 characters.")]
		public string? CustomerName { get; set; }

		[Required(ErrorMessage = "The OrderDate field is required.")]
		public DateTime OrderDate { get; set; }

		[Range(0, double.MaxValue, ErrorMessage = "The TotalAmount should be positive number")]
		[Column(TypeName = "decimal")]
		public decimal TotalAmount { get; set; }
	}
}
