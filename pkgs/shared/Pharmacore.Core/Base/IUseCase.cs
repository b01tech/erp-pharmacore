namespace Pharmacore.Core.Base;

public interface IUseCase<in TIn, TOut>
{
    Task<Result<TOut>> ExecuteAsync(TIn request);
}
