using DDDToolkit.Domain;
using MediatR;

namespace DDDToolkit.Cqrs
{
    public interface ICommand : ICommand<Void>
    {
    }

    public interface ICommand<out TResult> : IRequest<TResult>
    {
    }
}
