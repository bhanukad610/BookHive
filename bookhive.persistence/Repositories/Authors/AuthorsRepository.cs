using System;
using bookhive.domain.Aggregates.Authors;

namespace bookhive.persistence.Repositories.Authors
{
	public class AuthorsRepository : Repository<Author>, IAuthorRepository
	{
        public AuthorsRepository(BookHiveDbContext context)
            : base(context)
        {
        }
    }
}

