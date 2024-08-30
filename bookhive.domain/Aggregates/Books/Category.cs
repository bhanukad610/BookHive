using System;
namespace bookhive.domain.Aggregates.Books
{
	public class Category : Entity
	{
		public Category(string name, string description)
		{
			this.Name = name;
			this.Description = description;
		}

		private Category()
		{
		}

		public string Name { get; private set; }

		public string Description { get; private set; }
    }
}

