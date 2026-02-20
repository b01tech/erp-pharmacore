using Pharmacore.Core.Base;

namespace Pharmacore.Core.Db;

public interface IFindByIdRepository<T>
{
    Task<Result<T?>> FindByIdAsync(Guid id);
}
