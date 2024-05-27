using Orders.WebAPI.RepositoryContracts;
using Orders.WebAPI.ServiceContracts.DTO;
using Orders.WebAPI.ServiceContracts.OrderItems;

namespace Orders.WebAPI.Services.OrderItems
{
	public class OrderItemsUpdaterService : IOrderItemsUpdaterService
	{
		private readonly IOrderItemsRepository _orderItemsRepository;
		private readonly ILogger<OrderItemsUpdaterService> _logger;

		public OrderItemsUpdaterService(IOrderItemsRepository orderItemsRepository, ILogger<OrderItemsUpdaterService> logger)
		{
			_orderItemsRepository = orderItemsRepository;
			_logger = logger;
		}


		/// <inheritdoc />
		public async Task<OrderItemResponse> UpdateOrderItem(OrderItemUpdateRequest orderItemRequest)
		{
			_logger.LogInformation($"Updating order item. Order Item ID: {orderItemRequest.OrderItemId}...");

			// Convert the update request to an OrderItem entity
			var orderItem = orderItemRequest.ToOrderItem();

			// Update the order item
			var updatedOrderItem = await _orderItemsRepository.UpdateOrderItem(orderItem);

			_logger.LogInformation($"Order item updated successfully. Order Item ID: {updatedOrderItem.OrderItemId}.");

			// Convert the updated order item to a response object
			return updatedOrderItem.ToOrderItemResponse();
		}
	}
}
