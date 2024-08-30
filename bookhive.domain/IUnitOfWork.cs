using System;
namespace bookhive.domain
{
	public interface IUnitOfWork
	{
        int SaveChanges();

        Task<int> SaveChangesAsync(CancellationToken cancellationToken = default);
    }
}

