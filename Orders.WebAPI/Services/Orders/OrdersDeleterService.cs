using Orders.WebAPI.RepositoryContracts;
using Orders.WebAPI.ServiceContracts.Orders;

namespace Orders.WebAPI.Services.Orders
{
	public class OrdersDeleterService : IOrdersDeleterService
	{
		private readonly IOrdersRepository _ordersRepository;
		private readonly ILogger<OrdersDeleterService> _logger;


		public OrdersDeleterService(IOrdersRepository ordersRepository, ILogger<OrdersDeleterService> logger)
		{
			_ordersRepository = ordersRepository;
			_logger = logger;
		}


		/// <inheritdoc/>
		public async Task<bool> DeleteOrderByOrderId(Guid orderId)
		{
			_logger.LogInformation($"Deleting order with ID: {orderId}");

			// Call the repository method to delete the order
			var isDeleted = await _ordersRepository.DeleteOrderByOrderId(orderId);

			if (isDeleted)
			{
				_logger.LogInformation($"Order with ID {orderId} deleted successfully");
			}
			else
			{
				_logger.LogWarning($"Order with ID {orderId} not found");
			}

			return isDeleted;
		}
	}
}
