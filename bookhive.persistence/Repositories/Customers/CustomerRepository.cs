using System;
using bookhive.domain.Aggregates.Customers;

namespace bookhive.persistence.Repositories.Customers
{
	public class CustomerRepository : Repository<Customer>, ICustomersRepository
	{
		public CustomerRepository(BookHiveDbContext context)
			: base(context)
		{
		}
	}
}