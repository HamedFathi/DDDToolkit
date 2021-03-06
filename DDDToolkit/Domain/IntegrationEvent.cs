using System;

namespace DDDToolkit.Domain
{
    public abstract class IntegrationEvent
    {
        public Guid Id { get; private set; }
        public DateTimeOffset OccuredOn { get; private set; }

        protected IntegrationEvent()
        {
            Id = Guid.NewGuid();
            OccuredOn = DateTimeOffset.Now;
        }
    }
}
