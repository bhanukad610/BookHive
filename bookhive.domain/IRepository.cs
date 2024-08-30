using System;
using System.Linq.Expressions;

namespace bookhive.domain
{
    public interface IRepository
    {
    }

    public interface IRepository<T> : IRepository where T : class, IAggregateRoot
    {
        void Add(T entity);

        void Update(T entity);

        void Remove(T entity);

        Task<T> FindOneAsync(params object[] keys);

        Task<T> FindOneAsync(Expression<Func<T, bool>> predicate);

        Task<IEnumerable<T>> FindAllAsync(Expression<Func<T, bool>> predicate);

        Task<IEnumerable<T>> FindAllAsync(Expression<Func<T, bool>> predicate, int skip, int take);
    }
}

