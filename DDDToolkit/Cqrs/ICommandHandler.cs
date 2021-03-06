using MediatR;

namespace DDDToolkit.Cqrs
{
    public interface ICommandHandler<T> : IRequestHandler<T> where T : IRequest<Unit>
    {
    }

    public interface ICommandHandler<TCommand, TResult> : IRequestHandler<TCommand, TResult>
        where TCommand : ICommand<TResult>
    {
    }
}
