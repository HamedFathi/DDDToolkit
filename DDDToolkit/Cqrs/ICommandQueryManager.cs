using System.Threading.Tasks;

namespace DDDToolkit.Cqrs
{
    // Cqrs.Behaviours.Caching
    // Cqrs.Behaviours.ErrorHandler
    // Cqrs.Behaviours.Validation
    public interface ICommandQueryManager
    {
        Task Send(ICommand command);
        Task<TResponse> Send<TResponse>(ICommand<TResponse> command);
        Task<TResponse> Send<TResponse>(IQuery<TResponse> query);
    }
}
