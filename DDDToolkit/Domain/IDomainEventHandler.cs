using MediatR;

namespace DDDToolkit.Domain
{
    public interface IDomainEventHandler<in TDomainEvent>
        : INotificationHandler<TDomainEvent> where TDomainEvent : INotification
    {
    }
}
