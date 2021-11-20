using System.Threading;
using System.Threading.Tasks;

namespace DDDToolkit.Repositories
{
    public interface IUnitOfWork
    {
        Task<bool> CommitAsync(CancellationToken cancellationToken);
    }
}
