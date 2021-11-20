using DDDToolkit.Domain;

namespace DDDToolkit.Repositories
{
    public interface IRepository<T> where T : class, IAggregateRoot
    {
        IUnitOfWork UnitOfWork { get; }
    }
}
