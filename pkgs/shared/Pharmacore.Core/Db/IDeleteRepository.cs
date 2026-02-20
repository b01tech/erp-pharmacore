namespace Pharmacore.Core.Db;

public interface IDeleteRepository<in T>
{
    Task DeleteAsync(Guid id);
}
