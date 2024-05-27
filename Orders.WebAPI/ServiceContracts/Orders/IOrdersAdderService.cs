using Orders.WebAPI.ServiceContracts.DTO;

namespace Orders.WebAPI.ServiceContracts.Orders
{
	/// <summary>
	/// Represents a service for adding orders.
	/// </summary>
	public interface IOrdersAdderService
	{
		/// <summary>
		/// Adds a new order.
		/// </summary>
		/// <param name="orderRequest">The order details.</param>
		/// <returns>The added order.</returns>
		Task<OrderResponse> AddOrder(OrderAddRequest orderRequest);
	}
}
