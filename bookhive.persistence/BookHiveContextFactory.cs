using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;

namespace bookhive.persistence
{
    public class BookHiveContextFactory : IDesignTimeDbContextFactory<BookHiveDbContext>
    {
        public BookHiveContextFactory()
        {
        }

        public BookHiveDbContext CreateDbContext(string[] args)
        {
            var optionsBuilder = new DbContextOptionsBuilder<BookHiveDbContext>();
            optionsBuilder.UseNpgsql("Host=localhost;Port=5432;Database=BookHive;Username=postgres;Password=postgres");

            return new BookHiveDbContext(optionsBuilder.Options);
        }
    }
}

