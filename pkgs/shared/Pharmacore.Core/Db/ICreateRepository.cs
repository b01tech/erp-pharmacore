namespace Pharmacore.Core.Db;

public interface ICreateRepository<in T>
{
    Task CreateAsync(T entity);
}
