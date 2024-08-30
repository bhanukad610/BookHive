using System;
using bookhive.domain.Aggregates.Books;

namespace bookhive.domain.Aggregates.Orders
{
	public class OrderItem : Entity
	{
		public OrderItem(Guid bookId, int quantity)
		{
			this.BookId = bookId;
			this.Quantity = quantity;
            Amount = CalculateAmount();
        }

        private OrderItem()
        {
        }

        public Guid BookId { get; private set; }

		public Book Book { get; private set; }

        public int Quantity { get; private set; }

		public double Amount { get; private set; }

        private double CalculateAmount()
        {
            return Quantity * (Book?.Price ?? 0);
        }
    }
}