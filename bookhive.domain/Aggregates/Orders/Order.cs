using System;
using bookhive.domain.Aggregates.Customers;

namespace bookhive.domain.Aggregates.Orders
{
	public class Order : Entity, IAggregateRoot
	{
		private readonly List<OrderItem> _orderItems;

		public Order(Guid customerId)
		{
			this.CustomerId = customerId;
            DateTime = DateTime.UtcNow;

            _orderItems = new List<OrderItem>();
		}

		private Order()
		{
			_orderItems = new List<OrderItem>();
		}

		public Guid CustomerId { get; private set; }

		public Customer Customer { get; private set; }

		public DateTime DateTime { get; private set; }

		public IReadOnlyList<OrderItem> OrderItems => _orderItems;

		public void AddOrderItem(OrderItem orderItem)
		{
			_orderItems.Add(orderItem);
		}
	}
}

