using Orders.WebAPI.RepositoryContracts;
using Orders.WebAPI.ServiceContracts.OrderItems;

namespace Orders.WebAPI.Services.OrderItems
{
	public class OrderItemsDeleterService : IOrderItemsDeleterService
	{
		private readonly IOrderItemsRepository _orderItemsRepository;
		private readonly ILogger<OrderItemsDeleterService> _logger;


		/// <summary>
		/// Initializes a new instance of the <see cref="OrderItemsDeleterService"/> class.
		/// </summary>
		/// <param name="orderItemsRepository">The repository for order items.</param>
		/// <param name="logger">The logger.</param>
		public OrderItemsDeleterService(IOrderItemsRepository orderItemsRepository, ILogger<OrderItemsDeleterService> logger)
		{
			_orderItemsRepository = orderItemsRepository;
			_logger = logger;
		}


		/// <inheritdoc />
		public async Task<bool> DeleteOrderItemByOrderItemId(Guid orderItemId)
		{
			_logger.LogInformation($"Deleting order item with ID: {orderItemId}...");

			// Delete the order item by its Order Item ID
			var isDeleted = await _orderItemsRepository.DeleteOrderItemByOrderItemId(orderItemId);

			if (isDeleted)
			{
				_logger.LogInformation($"Order item deleted successfully. ID: {orderItemId}.");
			}
			else
			{
				_logger.LogWarning($"Order item not found for deletion. ID: {orderItemId}.");
			}

			return isDeleted;
		}
	}
}
