﻿using Orders.WebAPI.ServiceContracts.DTO;

namespace Orders.WebAPI.ServiceContracts.Orders
{
	/// <summary>
	/// Represents a service for updating orders.
	/// </summary>
	public interface IOrdersUpdaterService
	{
		/// <summary>
		/// Updates an existing order.
		/// </summary>
		/// <param name="orderRequest">The updated order details.</param>
		/// <returns>The updated order.</returns>
		Task<OrderResponse> UpdateOrder(OrderUpdateRequest orderRequest);
	}
}
