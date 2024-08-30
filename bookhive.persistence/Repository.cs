using System;
using bookhive.domain;
using System.Linq.Expressions;
using Microsoft.EntityFrameworkCore;

namespace bookhive.persistence
{
    public class Repository<T> : IRepository<T> where T : class, IAggregateRoot
    {
        protected BookHiveDbContext Context { get; }

        public Repository(BookHiveDbContext context)
        {
            Context = context;
        }

        public void Add(T entity)
        {
            Context.Set<T>().Add(entity);
        }

        public void Update(T entity)
        {
            Context.Set<T>().Update(entity);
        }

        public void Remove(T entity)
        {
            Context.Set<T>().Remove(entity);
        }

        public async Task<T> FindOneAsync(params object[] keys)
        {
            return await Context.Set<T>().FindAsync(keys);
        }

        public async Task<T> FindOneAsync(Expression<Func<T, bool>> predicate)
        {
            return await Context.Set<T>().Where(predicate).FirstOrDefaultAsync();
        }

        public async Task<IEnumerable<T>> FindAllAsync(Expression<Func<T, bool>> predicate)
        {
            return await Context.Set<T>().Where(predicate).ToListAsync();
        }

        public async Task<IEnumerable<T>> FindAllAsync(Expression<Func<T, bool>> predicate, int skip, int take)
        {
            return await Context.Set<T>().Where(predicate).Skip(skip).Take(take).ToListAsync();
        }
    }
}

