using Pharmacore.Core.Base;

namespace Pharmacore.Core.Db;

public interface IFindAllRepository<T>
{
    Task<Result<IEnumerable<T>>> FindAllAsync();
}
