namespace Pharmacore.Core.Db;

public interface ICrudRepository<T> :
    ICreateRepository<T>,
    IUpdateRepository<T>,
    IDeleteRepository<T>,
    IFindAllRepository<T>,
    IFindByIdRepository<T>
{
}
