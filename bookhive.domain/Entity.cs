using System;
namespace bookhive.domain
{
	public class Entity : IDomainEntity
    {
        public Entity()
		{
            Id = Guid.NewGuid();
        }

        public Entity(Guid id)
        {
            Id = id;
        }

        public Guid Id { get; set; }

        public DateTime CreatedAt { get; set; }
    }
}

