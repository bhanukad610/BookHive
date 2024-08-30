using System;
using bookhive.domain.Aggregates.Authors;
using bookhive.domain.Aggregates.Books;
using bookhive.domain.Aggregates.Customers;
using bookhive.domain.Aggregates.Orders;
using Microsoft.EntityFrameworkCore;

namespace bookhive.persistence
{
    public class BookHiveDbContext : DbContext
    {
        public BookHiveDbContext(DbContextOptions<BookHiveDbContext> options) : base(options)
        {
        }

        public BookHiveDbContext() { }

        public DbSet<Author> Authors { get; set; }

        public DbSet<Book> Books { get; set; }

        public DbSet<Category> Categories { get; set; }

        public DbSet<Customer> Customers { get; set; }

        public DbSet<Order> Orders { get; set; }

        public DbSet<OrderItem> OrderItems { get; set; }
    }
}

