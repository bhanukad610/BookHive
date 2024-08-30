using System;
using bookhive.domain.Aggregates.Orders;

namespace bookhive.persistence.Repositories.Orders
{
	public class OrdersRepository : Repository<Order>, IOrdersRepository
	{
		public OrdersRepository(BookHiveDbContext context)
            : base(context)
        {
        }
    }
}

