using Orders.WebAPI.ServiceContracts.DTO;

namespace Orders.WebAPI.ServiceContracts.OrderItems
{
	/// <summary>
	/// Represents the service contract for updating order items.
	/// </summary>
	public interface IOrderItemsUpdaterService
	{
		/// <summary>
		/// Updates an order item.
		/// </summary>
		/// <param name="orderItemRequest">The request containing the updated order item data.</param>
		/// <returns>The updated order item.</returns>
		Task<OrderItemResponse> UpdateOrderItem(OrderItemUpdateRequest orderItemRequest);
	}
}
