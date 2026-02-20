namespace Pharmacore.Core.Db;

public interface IUpdateRepository<in T>
{
    Task UpdateAsync(T entity);
}
