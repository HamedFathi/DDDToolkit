using MediatR;

namespace DDDToolkit.Cqrs
{
    public interface IQuery<out TResult> : IRequest<TResult>
    {
    }
}