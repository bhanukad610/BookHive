using System;
using bookhive.domain.Aggregates.Authors;

namespace bookhive.domain.Aggregates.Books
{
	public class Book : Entity, IAggregateRoot
	{
		public Book(string title, string description, double price, Guid catagoryId, int stock)
		{
			this.Title = title;
			this.Description = description;
			this.Price = price;
			this.CategoryId = catagoryId;
			this.Stock = stock;
		}

		private Book()
		{
		}

		public string Title { get; private set; }

        public string Description { get; private set; }

		public double Price { get; private set; }

		public Guid CategoryId { get; private set; }

		public Category Category { get; private set; }

        public Guid AuthorId { get; private set; }

		public Author Author { get; private set; }

        public int Stock { get; private set; }

        public void UpdateStock(int amount)
        {
            Stock += amount;
        }
    }
}

