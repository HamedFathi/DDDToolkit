using System.Threading.Tasks;

namespace DDDToolkit.Cqrs
{
    public interface ICommandQueryManager
    {
        Task Send(ICommand command);
        Task<TResponse> Send<TResponse>(ICommand<TResponse> command);
        Task<TResponse> Send<TResponse>(IQuery<TResponse> query);
    }
}
