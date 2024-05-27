using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Orders.WebAPI.Entities
{
	public class OrderItem
	{
		[Key]
		public Guid OrderItemId { get; set; }

		[Required(ErrorMessage = "The OrderId field is required.")]
		public Guid OrderId { get; set; }

		[Required(ErrorMessage = "The ProductName field is required.")]
		[StringLength(50, ErrorMessage = "The ProductName field must not exceed 50 characters.")]
		public string? ProductName { get; set; }

		[Range(1, int.MaxValue, ErrorMessage = "Quantity should be positive number")]
		public int Quantity { get; set; }

		[Range(0, double.MaxValue, ErrorMessage = "The UnitPrice should be positive number")]
		[Column(TypeName = "decimal")]
		public decimal UnitPrice { get; set; }

		[Range(0, double.MaxValue, ErrorMessage = "The TotalPrice should be positive number")]
		[Column(TypeName = "decimal")]
		public decimal TotalPrice { get; set; }
	}
}
