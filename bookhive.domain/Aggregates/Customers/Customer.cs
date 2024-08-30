using System;
namespace bookhive.domain.Aggregates.Customers
{
	public class Customer : Entity, IAggregateRoot
	{
		public Customer(string name, string email, string phone)
		{
			this.Name = name;
			this.Email = email;
			this.Phone = phone;
		}

        private Customer()
        {
        }

        public string Name { get; private set; }

        public string Email { get; private set; }

        public string Phone { get; private set; }
    }
}

