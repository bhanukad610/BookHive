using System;
using bookhive.domain.Aggregates.Books;

namespace bookhive.persistence.Repositories.Books
{
	public class BooksRepository : Repository<Book>, IBooksRespository
	{
        public BooksRepository(BookHiveDbContext context)
            : base(context)
        {
        }
    }
}

