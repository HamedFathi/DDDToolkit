using System.Threading.Tasks;

namespace DDDToolkit.Domain
{
    public interface IDomainEventManager
    {
        Task Publish(IDomainEvent @event);
        Task Publish(params IDomainEvent[] events);
    }
}
