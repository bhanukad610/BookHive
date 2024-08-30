using System;
namespace bookhive.domain.Aggregates.Authors
{
	public class Author : Entity, IAggregateRoot
	{
		public Author(string name)
		{
			this.Name = name;
		}

        private Author()
        {
        }

        public string Name { get; private set; }
	}
}